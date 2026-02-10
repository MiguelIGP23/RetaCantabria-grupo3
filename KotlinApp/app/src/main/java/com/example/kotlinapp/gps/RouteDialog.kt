package com.example.kotlinapp.gps

import androidx.activity.result.ActivityResultLauncher
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Spacer
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.height
import androidx.compose.material3.AlertDialog
import androidx.compose.material3.Button
import androidx.compose.material3.ButtonDefaults
import androidx.compose.material3.OutlinedTextField
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.runtime.MutableState
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.runtime.snapshots.SnapshotStateList
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.unit.dp
import com.example.kotlinapp.model.Trackpoint
import com.example.kotlinapp.model.Waypoint
import com.example.kotlinapp.views.generarRuta

@Composable
fun FinishRouteDialog(
    showDialog: MutableState<Boolean>,
    rutaNombre: MutableState<String>,
    rutaDescripcion: MutableState<String>,
    savedTrackpoints: SnapshotStateList<Trackpoint>,
    savedWaypoints: SnapshotStateList<Waypoint>,
    usuarioId: Int,
    currentGPX: MutableState<String?>,
    createFileLauncher: ActivityResultLauncher<String>,
    onRouteSaved: () -> Unit = {},
) {
    if (!showDialog.value) return

    // Estados de error
    val showTrackpointsError = remember { mutableStateOf(false) }
    val showNameError = remember { mutableStateOf(false) }

    AlertDialog(
        onDismissRequest = {
            showDialog.value = false
            showTrackpointsError.value = false
            showNameError.value = false
        },
        title = { Text("Finalizar Ruta") },
        text = {
            Column {
                Text("Escribe un nombre para la ruta:")

                // OutlinedTextField con borde rojo si el nombre está vacío
                OutlinedTextField(
                    value = rutaNombre.value,
                    onValueChange = {
                        rutaNombre.value = it
                        if (it.isNotBlank()) showNameError.value = false
                    },
                    placeholder = { Text("Nombre de la ruta") },
                    singleLine = true,
                    isError = showNameError.value,
                    modifier = Modifier.fillMaxWidth()
                )

                if (showNameError.value) {
                    Text(
                        "Debes ingresar un nombre",
                        color = Color.Red,
                        fontWeight = FontWeight.Bold
                    )
                }

                Spacer(Modifier.height(8.dp))

                Text("Escribe una descripción:")
                OutlinedTextField(
                    value = rutaDescripcion.value,
                    onValueChange = { rutaDescripcion.value = it },
                    placeholder = { Text("Descripción de la ruta") },
                    singleLine = false,
                    modifier = Modifier.fillMaxWidth()
                )

                Spacer(Modifier.height(8.dp))

                if (showTrackpointsError.value) {
                    Text(
                        "No se puede guardar una ruta sin trackpoints",
                        color = Color.Red,
                        fontWeight = FontWeight.Bold
                    )
                }
            }
        },
        confirmButton = {
            Button(
                onClick = {
                    var error = false

                    if (savedTrackpoints.isEmpty()) {
                        showTrackpointsError.value = true
                        error = true
                    }

                    if (rutaNombre.value.isBlank()) {
                        showNameError.value = true
                        error = true
                    }

                    if (error) return@Button



                    // Cerramos diálogo pero NO borramos las listas aún,
                    // se borrarán luego de que se guarde el GPX
                    showDialog.value = false
                    showTrackpointsError.value = false
                    showNameError.value = false

                    onRouteSaved()
                },
                colors = ButtonDefaults.buttonColors(
                    containerColor = Color(0xFF64B5F6),
                    contentColor = Color.White
                )
            ) { Text("Publicar Ruta") }
        },
        dismissButton = {
            Button(
                onClick = {
                    showDialog.value = false
                    showTrackpointsError.value = false
                    showNameError.value = false
                }
            ) {
                Text("Cancelar")
            }
        }
    )
}
