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
import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.padding
import androidx.compose.material3.ButtonDefaults
import androidx.compose.material3.DropdownMenuItem
import androidx.compose.material3.ExperimentalMaterial3Api
import androidx.compose.material3.ExposedDropdownMenuBox
import androidx.compose.material3.ExposedDropdownMenuDefaults
import androidx.compose.material3.MaterialTheme
import androidx.compose.material3.OutlinedTextFieldDefaults
import androidx.compose.material3.Slider
import androidx.compose.material3.SliderDefaults
import androidx.compose.runtime.LaunchedEffect
import androidx.compose.ui.graphics.Color
import com.example.kotlinapp.model.PuntoInteres
import com.example.kotlinapp.model.PuntoPeligro
import com.example.kotlinapp.model.enums.TipoPunto
import com.example.kotlinapp.model.enums.WaypointType
import com.example.kotlinapp.ui.theme.botonActivo
import com.example.kotlinapp.ui.theme.botonActivoTexto
import com.example.kotlinapp.ui.theme.botonInactivo


@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun WaypointDialog(
    dialogData: WaypointDialogData,
    onDismiss: () -> Unit,
    onSave: (Any) -> Unit
) {
    val context = LocalContext.current

    var title by remember { mutableStateOf("") }
    var description by remember { mutableStateOf("") }
    var selectedTipoPunto by remember { mutableStateOf<TipoPunto?>(null) }
    var expanded by remember { mutableStateOf(false) }

    // Estados de error
    var titleError by remember { mutableStateOf(false) }
    var descriptionError by remember { mutableStateOf(false) }
    var tipoPuntoError by remember { mutableStateOf(false) }
    var gravedad by remember { mutableStateOf<Byte>(0) }
    var gravedadError by remember { mutableStateOf(false) }

    // Otros estados (foto, cámara, etc.) omitidos para claridad

    AlertDialog(
        onDismissRequest = onDismiss,
        title = { Text("Nuevo Waypoint (${dialogData.type})") },
        text = {
            Column {
                // Título
                OutlinedTextField(
                    value = title,
                    onValueChange = { title = it; if (titleError) titleError = false },
                    label = { Text("Título") },
                    isError = titleError,
                    colors = OutlinedTextFieldDefaults.colors(
                        focusedBorderColor = botonActivo,
                        focusedLabelColor = botonActivo,
                        cursorColor = Color.Black
                    )
                )
                if (titleError) Text(
                    "El título es obligatorio",
                    color = MaterialTheme.colorScheme.error
                )

                Spacer(modifier = Modifier.height(8.dp))

                // Descripción
                OutlinedTextField(
                    value = description,
                    onValueChange = {
                        description = it; if (descriptionError) descriptionError = false
                    },
                    label = { Text("Descripción") },
                    isError = descriptionError,
                    colors = OutlinedTextFieldDefaults.colors(
                        focusedBorderColor = botonActivo,
                        focusedLabelColor = botonActivo,
                        cursorColor = Color.Black
                    )
                )
                if (descriptionError) Text(
                    "La descripción es obligatoria",
                    color = MaterialTheme.colorScheme.error
                )

                Spacer(modifier = Modifier.height(8.dp))

                // ComboBox solo si es INTERES
                if (dialogData.type == WaypointType.INTERES) {
                    ExposedDropdownMenuBox(
                        expanded = expanded,
                        onExpandedChange = { expanded = !expanded }
                    ) {
                        OutlinedTextField(
                            value = selectedTipoPunto?.name ?: "Selecciona tipo",
                            onValueChange = {},
                            readOnly = true,
                            label = { Text("Tipo de Punto") },
                            isError = tipoPuntoError,
                            trailingIcon = { ExposedDropdownMenuDefaults.TrailingIcon(expanded = expanded) },
                            modifier = Modifier
                                .menuAnchor()
                                .clickable { expanded = true },
                            colors = OutlinedTextFieldDefaults.colors(
                                focusedBorderColor = botonActivo,
                                focusedLabelColor = botonActivo,
                                cursorColor = Color.Black
                            )
                        )
                        ExposedDropdownMenu(
                            expanded = expanded,
                            onDismissRequest = { expanded = false }
                        ) {
                            TipoPunto.values().forEach { tipo ->
                                DropdownMenuItem(
                                    text = { Text(tipo.name) },
                                    onClick = {
                                        selectedTipoPunto = tipo
                                        tipoPuntoError = false
                                        expanded = false
                                    }
                                )
                            }
                        }
                    }
                    if (tipoPuntoError) Text(
                        "Debes seleccionar un tipo de punto",
                        color = MaterialTheme.colorScheme.error
                    )
                } else {
                    Text("Nivel de peligro: ${gravedad.toInt().toByte()}")
                    Slider(
                        value = gravedad.toFloat(), // convertir a Float para el Slider
                        onValueChange = {
                            gravedad = it.toInt().toByte() // convertir de Float a Byte
                            if (gravedadError) gravedadError = false
                        },
                        valueRange = 0f..5f,
                        steps = 6,
                        modifier = Modifier
                            .fillMaxWidth()
                            .padding(horizontal = 8.dp), colors = SliderDefaults.colors(
                            thumbColor = botonActivo,
                            activeTrackColor = botonActivo,
                            inactiveTrackColor = botonInactivo
                        )
                    )
                }
            }
        },
        confirmButton = {
            Button(
                colors = ButtonDefaults.textButtonColors(
                    contentColor = botonActivoTexto, containerColor = botonActivo
                ),
                onClick = {
                    // Validación
                    var hasError = false
                    if (title.isBlank()) {
                        titleError = true; hasError = true
                    }
                    if (description.isBlank()) {
                        descriptionError = true; hasError = true
                    }
                    if (dialogData.type == WaypointType.INTERES && selectedTipoPunto == null) {
                        tipoPuntoError = true; hasError = true
                    }

                    if (!hasError) {
                        val punto = if (dialogData.type == WaypointType.INTERES) {
                            PuntoInteres(
                                id = null,
                                nombre = title,
                                latitud = dialogData.lat,
                                longitud = dialogData.lon,
                                elevacion = dialogData.elevation ?: 0.0,
                                caracteristicas = null,
                                tipo = selectedTipoPunto,
                                descripcion = description,
                                timestamp = System.currentTimeMillis(),
                                rutaId = -1
                            )
                        } else {
                            PuntoPeligro(
                                id = null,
                                nombre = title,
                                latitud = dialogData.lat,
                                longitud = dialogData.lon,
                                elevacion = dialogData.elevation ?: 0.0,
                                kilometros = null,
                                gravedad = gravedad,
                                descripcion = description,
                                timestamp = System.currentTimeMillis(),
                                rutaId = -1
                            )
                        }

                        onSave(punto)
                        onDismiss()
                    }
                }
            ) { Text("Guardar") }
        },
        dismissButton = {
            Button(
                onClick = onDismiss, colors = ButtonDefaults.textButtonColors(
                    contentColor = botonActivoTexto, containerColor = botonActivo
                )
            ) { Text("Cancelar") }
        }
    )
}
