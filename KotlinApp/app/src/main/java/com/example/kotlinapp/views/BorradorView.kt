package com.example.kotlinapp.views

import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.Spacer
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.height
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.layout.size
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.ArrowBack
import androidx.compose.material.icons.filled.Check
import androidx.compose.material.icons.filled.Close
import androidx.compose.material.icons.filled.Delete
import androidx.compose.material.icons.filled.Edit
import androidx.compose.material.icons.filled.Share
import androidx.compose.material3.Checkbox
import androidx.compose.material3.ExperimentalMaterial3Api
import androidx.compose.material3.FloatingActionButton
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
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.unit.dp
import androidx.navigation.NavHostController
import com.example.kotlinapp.viewmodels.DBViewModel

@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun BorradorView(navController: NavHostController, id: Int?, dbViewModel: DBViewModel) {
    val ruta = dbViewModel.ruta.collectAsState()

    var nombre by remember { mutableStateOf(ruta.value?.nombre ?: "") }
    var descripcion by remember { mutableStateOf(ruta.value?.nombre ?: "") }
    var puntoInicial by remember { mutableStateOf(ruta.value?.nombreInicioruta ?: "") }
    var puntoFinal by remember { mutableStateOf(ruta.value?.nombreFinalruta ?: "") }
    val opcionesTemporadas = listOf("Primavera", "Verano", "Otoño", "Invierno")
    var temporadasSeleccionadas by remember { mutableStateOf(setOf<String>()) }
    var equipo by remember { mutableStateOf("") }
    var terreno by remember { mutableStateOf(1f) }
    var indicaciones by remember { mutableStateOf(1f) }
    Scaffold(
        // TopBar con logo, título y botones
        topBar = {
            TopAppBar(
                title = { Text("${ruta.value?.nombre}") },
                actions = {
                    IconButton(
                        onClick = {

                        },
                    ) {
                        Icon(
                            Icons.Default.Check, contentDescription = "Agregar Ruta"
                        )
                    }
                    IconButton(
                        onClick = {
                            dbViewModel.deleteRuta(id!!)
                            navController.popBackStack("list",false)
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
                    value = descripcion,
                    onValueChange = { descripcion = it },
                    label = { Text("Descripcion de la ruta") },
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
            }
        }
    }
}


