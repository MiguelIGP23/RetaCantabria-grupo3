package com.example.kotlinapp.gps

import android.content.Context
import androidx.activity.compose.rememberLauncherForActivityResult
import androidx.activity.result.contract.ActivityResultContracts
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Spacer
import androidx.compose.foundation.layout.height
import androidx.compose.material3.AlertDialog
import androidx.compose.material3.Button
import androidx.compose.material3.OutlinedTextField
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.runtime.setValue
import androidx.compose.ui.Modifier
import androidx.compose.ui.platform.LocalContext
import androidx.compose.ui.unit.dp
import androidx.core.content.FileProvider
import com.example.kotlinapp.model.Waypoint
import com.example.kotlinapp.model.WaypointDialogData
import java.io.File

@Composable
fun WaypointDialog(
    dialogData: WaypointDialogData,
    onDismiss: () -> Unit,
    onSave: (Waypoint) -> Unit
) {
    var title by remember { mutableStateOf("") }
    var description by remember { mutableStateOf("") }
    var photoUri by remember { mutableStateOf<String?>(null) } // ruta o URL futura

    val context = LocalContext.current

    // Launcher para tomar foto (preparado, sin guardar aún en servidor)
    fun createTempImageFile(context: Context): File {
        val dir = context.cacheDir
        return File.createTempFile("waypoint_${System.currentTimeMillis()}", ".jpg", dir)
    }

    val takePictureLauncher = rememberLauncherForActivityResult(
        contract = ActivityResultContracts.TakePicture()
    ) { success ->
        if (success) {
            photoUri?.let { uri ->
                // la foto fue guardada en uri, listo para usar
            }
        }
    }

    AlertDialog(
        onDismissRequest = onDismiss,
        title = { Text("Nuevo Waypoint (${dialogData.type})") },
        text = {
            Column {
                OutlinedTextField(
                    value = title,
                    onValueChange = { title = it },
                    label = { Text("Título") }
                )
                OutlinedTextField(
                    value = description,
                    onValueChange = { description = it },
                    label = { Text("Descripción") }
                )
                Spacer(modifier = Modifier.height(8.dp))
                Button(onClick = {
                    val file = createTempImageFile(context)
                    val uri = FileProvider.getUriForFile(
                        context,
                        "${context.packageName}.provider",
                        file
                    )
                    photoUri = uri.toString()
                    takePictureLauncher.launch(uri)
                }) {
                    Text(if (photoUri == null) "Tomar foto" else "Foto lista")
                }
            }
        },
        confirmButton = {
            Button(
                onClick = {
                    // Guardamos la "fotoUri" en el waypoint (aunque ahora sea solo un placeholder)
                    onSave(
                        Waypoint(
                            lat = dialogData.lat,
                            lon = dialogData.lon,
                            type = dialogData.type,
                            title = title,
                            description = description,
                            photoPath = photoUri // aquí estará la URL futura
                        )
                    )
                }
            ) {
                Text("Guardar")
            }
        },
        dismissButton = {
            Button(onClick = onDismiss) { Text("Cancelar") }
        }
    )
}
