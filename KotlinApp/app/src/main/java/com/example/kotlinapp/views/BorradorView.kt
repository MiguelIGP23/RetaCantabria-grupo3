package com.example.kotlinapp.views

import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.Spacer
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.height
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.Check
import androidx.compose.material.icons.filled.Close
import androidx.compose.material3.Checkbox
import androidx.compose.material3.ExperimentalMaterial3Api
import androidx.compose.material3.Icon
import androidx.compose.material3.IconButton
import androidx.compose.material3.OutlinedTextField
import androidx.compose.material3.Scaffold
import androidx.compose.material3.Slider
import androidx.compose.material3.Text
import androidx.compose.material3.TopAppBar
import androidx.compose.runtime.Composable
import androidx.compose.runtime.collectAsState
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.runtime.setValue
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.unit.dp
import androidx.navigation.NavHostController
import com.example.kotlinapp.model.enums.Clasificacion
import com.example.kotlinapp.viewmodels.DBViewModel

@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun BorradorView(navController: NavHostController, id: Int?, dbViewModel: DBViewModel) {
    val ruta = dbViewModel.ruta.collectAsState()

    var nombre by remember { mutableStateOf(ruta.value?.nombre ?: "") }
    var zonaGeografica by remember { mutableStateOf("") }
    var puntoInicial by remember { mutableStateOf(ruta.value?.nombreInicioruta ?: "") }
    var puntoFinal by remember { mutableStateOf(ruta.value?.nombreFinalruta ?: "") }
    val opcionesTemporadas = listOf("Primavera", "Verano", "Otoño", "Invierno")
    var temporadasSeleccionadas by remember { mutableStateOf(setOf<String>()) }
    var equipo by remember { mutableStateOf("") }
    var terreno by remember { mutableStateOf(1f) }
    var indicaciones by remember { mutableStateOf(1f) }
    var accesibilidad by remember { mutableStateOf(ruta.value?.accesibilidad == 1.toByte()) }
    var rutaFamiliar by remember { mutableStateOf(ruta.value?.rutaFamiliar == 1.toByte()) }
    var clasificacion by remember { mutableStateOf("lineal") }

    Scaffold(
        // TopBar con logo, título y botones
        topBar = {
            TopAppBar(
                title = { Text("${ruta.value?.nombre}") },
                actions = {
                    IconButton(
                        onClick = {
                            val temporadasString =
                                temporadasSeleccionadas.joinToString(separator = ",") { temp ->
                                    temp.uppercase().replace("Ñ", "N")
                                }
                            val clasificacionEnum = Clasificacion.valueOf(clasificacion.uppercase())
                            dbViewModel.confirmarBorrador(
                                nombre,
                                zonaGeografica,
                                puntoInicial,
                                puntoFinal,
                                temporadasString,
                                equipo,
                                terreno.toInt(),
                                indicaciones.toInt(),
                                id,
                                accesibilidad,
                                rutaFamiliar,
                                clasificacionEnum

                            )
                            navController.popBackStack("List", false)
                        },
                    ) {
                        Icon(
                            Icons.Default.Check, contentDescription = "Agregar Ruta"
                        )
                    }
                    IconButton(
                        onClick = {
                            dbViewModel.cancelarBorrador(id!!)
                            navController.popBackStack("list", false)
                        },
                    ) {
                        Icon(
                            Icons.Default.Close, contentDescription = "Descartar Ruta"
                        )
                    }
                }
            )
        }) { innerPadding ->
        // Contenido principal de la parcela
        LazyColumn(
            Modifier
                .padding(innerPadding)
                .padding(14.dp)
                .fillMaxSize()
        ) {
            items(1) {
                OutlinedTextField(
                    value = nombre,
                    onValueChange = { nombre = it },
                    label = { Text("Nombre de la ruta") },
                    modifier = Modifier.fillMaxWidth()
                )
                Spacer(Modifier.height(12.dp))
                OutlinedTextField(
                    value = zonaGeografica,
                    onValueChange = { zonaGeografica = it },
                    label = { Text("Zona Geografica") },
                    modifier = Modifier.fillMaxWidth()
                )
                Spacer(Modifier.height(12.dp))
                OutlinedTextField(
                    value =
                        puntoInicial, onValueChange = {
                        puntoInicial = it
                    }, label = { Text("Punto inicial") }, modifier = Modifier.fillMaxWidth()
                )
                Spacer(Modifier.height(12.dp))
                OutlinedTextField(
                    value =
                        puntoFinal, onValueChange = {
                        puntoFinal = it
                    }, label = { Text("Punto final") }, modifier = Modifier.fillMaxWidth()
                )
                Spacer(Modifier.height(20.dp))
                Text("Temporadas recomendadas")
                opcionesTemporadas.forEach { temporada ->
                    Row(
                        verticalAlignment = Alignment.CenterVertically
                    ) {
                        Checkbox(
                            checked = temporadasSeleccionadas.contains(temporada),
                            onCheckedChange = {
                                temporadasSeleccionadas =
                                    if (temporadasSeleccionadas.contains(temporada)) temporadasSeleccionadas - temporada else temporadasSeleccionadas + temporada
                            })
                        Text(temporada)
                    }
                }
                Spacer(Modifier.height(20.dp))
                OutlinedTextField(
                    value = equipo,
                    onValueChange = {
                        equipo = it
                    },
                    label = { Text("Recomendaciones de equipo") },
                    modifier = Modifier.fillMaxWidth(),
                    maxLines = 4
                )
                Spacer(Modifier.height(20.dp))
                Text("Terreno (1 - 5)")
                Slider(
                    value =
                        terreno, onValueChange = {
                        terreno = it
                    }, valueRange = 1f..5f, steps = 3
                )
                Text(
                    terreno.toInt()
                        .toString()
                )
                Spacer(Modifier.height(20.dp))
                Text("Indicaciones (1 - 5)")
                Slider(value = indicaciones, onValueChange = {
                    indicaciones = it
                }, valueRange = 1f..5f, steps = 3)
                Text(indicaciones.toInt().toString())
                Spacer(Modifier.height(20.dp))
                Text("Accesibilidad")
                Row(verticalAlignment = Alignment.CenterVertically) {
                    Checkbox(
                        checked = accesibilidad,
                        onCheckedChange = { accesibilidad = it }
                    )
                    Text("Ruta accesible")
                }

                Spacer(Modifier.height(20.dp))
                Text("Ruta Familiar")
                Row(verticalAlignment = Alignment.CenterVertically) {
                    Checkbox(
                        checked = rutaFamiliar,
                        onCheckedChange = { rutaFamiliar = it }
                    )
                    Text("Apta para familias")
                }

                Spacer(Modifier.height(20.dp))
                Text("Clasificación")
                Row(verticalAlignment = Alignment.CenterVertically) {
                    Checkbox(
                        checked = clasificacion == "lineal",
                        onCheckedChange = { if (it) clasificacion = "lineal" }
                    )
                    Text("Lineal")
                }

                Row(verticalAlignment = Alignment.CenterVertically) {
                    Checkbox(
                        checked = clasificacion == "circular",
                        onCheckedChange = { if (it) clasificacion = "circular" }
                    )
                    Text("Circular")
                }

            }
        }
    }
}


