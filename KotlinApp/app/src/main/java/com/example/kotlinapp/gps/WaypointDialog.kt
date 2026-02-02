package com.example.kotlinapp.gps

import android.content.Intent
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
import com.example.kotlinapp.gps.permissions.RequestPermission
import com.example.kotlinapp.model.Waypoint
import com.example.kotlinapp.model.WaypointDialogData
import java.io.File
import android.Manifest
import android.net.Uri
import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Row
import androidx.compose.runtime.LaunchedEffect


@Composable
fun WaypointDialog(
    dialogData: WaypointDialogData,
    onDismiss: () -> Unit,
    onSave: (Waypoint) -> Unit
) {
    val context = LocalContext.current

    var title by remember { mutableStateOf("") }
    var description by remember { mutableStateOf("") }
    var photoUri by remember { mutableStateOf<String?>(null) }
    var pendingUri by remember { mutableStateOf<Uri?>(null) }
    var requestCamera by remember { mutableStateOf(false) }
    var cameraGranted by remember { mutableStateOf(false) }

    // Función para crear archivo temporal para la foto
    fun createTempImageFile(): File {
        return File.createTempFile(
            "waypoint_${System.currentTimeMillis()}",
            ".jpg",
            context.cacheDir
        )
    }

    // Launcher para tomar la foto
    val takePictureLauncher = rememberLauncherForActivityResult(
        contract = ActivityResultContracts.TakePicture()
    ) { success ->
        if (success) {
            // Foto tomada correctamente
        }
    }

    // Lanzar la cámara cuando se conceda el permiso
    LaunchedEffect(cameraGranted, pendingUri) {
        if (cameraGranted && pendingUri != null) {
            takePictureLauncher.launch(pendingUri!!)
            requestCamera = false
            cameraGranted = false
        }
    }

    AlertDialog(
        onDismissRequest = onDismiss,
        title = { Text("Nuevo Waypoint (${dialogData.type})") },
        text = {
            // Solicitar permiso si el usuario presionó "Tomar foto"
            if (requestCamera) {
                RequestPermission(
                    permission = Manifest.permission.CAMERA,
                    message = "Permiso de cámara requerido para tomar fotos"
                ) {
                    cameraGranted = true
                }
            }

            Column {
                // Campos de texto
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

                // Fila de botones: Tomar foto y Ver foto
                Row(horizontalArrangement = Arrangement.spacedBy(8.dp)) {
                    // Botón tomar foto
                    Button(onClick = {
                        val file = createTempImageFile()
                        val authority = "${context.applicationContext.packageName}.provider"
                        val uri = FileProvider.getUriForFile(context, authority, file)

                        pendingUri = uri
                        photoUri = uri.toString()
                        requestCamera = true
                    }) {
                        Text(if (photoUri == null) "Tomar foto" else "Foto lista")
                    }

                    // Botón ver foto
                    Button(
                        enabled = photoUri != null,
                        onClick = {
                            photoUri?.let { uriStr ->
                                val fileUri = Uri.parse(uriStr)
                                val intent = Intent(Intent.ACTION_VIEW).apply {
                                    setDataAndType(fileUri, "image/*")
                                    flags = Intent.FLAG_GRANT_READ_URI_PERMISSION
                                }
                                context.startActivity(intent)
                            }
                        }
                    ) {
                        Text("Ver foto")
                    }
                }
            }
        },
        confirmButton = {
            Button(
                onClick = {
                    onSave(
                        Waypoint(
                            lat = dialogData.lat,
                            lon = dialogData.lon,
                            type = dialogData.type,
                            title = title,
                            description = description,
                            photoPath = photoUri,
                            elevation = dialogData.elevation ?: 0.0
                        )
                    )
                }
            ) { Text("Guardar") }
        },
        dismissButton = {
            Button(onClick = onDismiss) { Text("Cancelar") }
        }
    )
}