package com.example.kotlinapp.views

import android.util.Log
import androidx.activity.compose.rememberLauncherForActivityResult
import androidx.activity.result.contract.ActivityResultContracts
import androidx.compose.foundation.background
import androidx.compose.foundation.layout.*
import androidx.compose.foundation.rememberScrollState
import androidx.compose.foundation.verticalScroll
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.AddCircle
import androidx.compose.material.icons.filled.ArrowBack
import androidx.compose.material.icons.filled.Build
import androidx.compose.material.icons.filled.Clear
import androidx.compose.material.icons.filled.Delete
import androidx.compose.material.icons.filled.Edit
import androidx.compose.material.icons.filled.Refresh
import androidx.compose.material.icons.filled.Share
import androidx.compose.material3.*
import androidx.compose.runtime.Composable
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.platform.LocalContext
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import androidx.navigation.NavHostController
import com.example.kotlinapp.gps.gpx.rememberGpxLauncher
import com.example.kotlinapp.model.Ruta
import com.example.kotlinapp.model.enums.Clasificacion
import com.example.kotlinapp.ui.theme.fondoPrincipal

@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun DetailView(navController: NavHostController, rutas: List<Ruta>, id: Int?) {
    val rutaSeleccionada = getRutaById(rutas, id) ?: return
    val context = LocalContext.current
    val createFileLauncher = rememberGpxLauncher(
        context = context,
        getGpxContent = { rutaSeleccionada.archivoGPX ?: "" },

    )
    Scaffold(
        // TopBar con logo, título y botones
        topBar = { DetailTopBar(navController, rutaSeleccionada) },
        floatingActionButton = {
            Column(
                verticalArrangement = Arrangement.spacedBy(16.dp),
                horizontalAlignment = Alignment.End
            ) {
                // Botón Modificar
                FloatingActionButton(
                    onClick = {
                        // Lógica para modificar la ruta
                    },
                    containerColor = Color(0xFF365DA9), // azul
                    contentColor = Color.White
                ) {
                    Icon(
                        Icons.Default.Edit,
                        contentDescription = "Modificar Ruta",
                        modifier = Modifier.size(24.dp)
                    )
                }

                // Botón Eliminar
                FloatingActionButton(
                    onClick = {
                        // Lógica para eliminar la ruta
                    },
                    containerColor = Color(0xFFE53935), // rojo
                    contentColor = Color.White
                ) {
                    Icon(
                        Icons.Default.Delete,
                        contentDescription = "Eliminar Ruta",
                        modifier = Modifier.size(24.dp)
                    )
                }

                FloatingActionButton(
                    onClick = {
                        rutaSeleccionada.archivoGPX?.let { gpxContent ->
                            // Aquí puedes lanzar un Intent para guardar o compartir el GPX
                            // Por ejemplo, crear un archivo temporal y usar ACTION_CREATE_DOCUMENT
                            createFileLauncher.launch("${rutaSeleccionada.nombre}.gpx")
                        }
                    },
                    containerColor = Color(0xFF4CAF50), // verde
                    contentColor = Color.White
                ) {
                    Icon(
                        Icons.Default.Share, // puedes usar otro icono si quieres
                        contentDescription = "Exportar GPX",
                        modifier = Modifier.size(24.dp)
                    )
                }
            }
        }
    ) { innerPadding ->
        // Contenido principal de la parcela
        ContentDetailView(
            innerPadding = innerPadding,
            rutas = rutas,
            id = id
        )

    }
}

fun getRutaById(rutas: List<Ruta>, id: Int?): Ruta? {
    return rutas.firstOrNull { it.id == id }
}

@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun DetailTopBar(navController: NavHostController, ruta: Ruta /*, api: ApiModel*/) {
    TopAppBar(
        title = { DetailTopBarTitle(navController, ruta) },
        actions = {
        },
        colors = TopAppBarDefaults.topAppBarColors(
            containerColor = fondoPrincipal,
            titleContentColor = Color.Black
        )
    )
}

@Composable
fun DetailTopBarTitle(navController: NavHostController, ruta: Ruta) {
    Row(verticalAlignment = Alignment.CenterVertically) {
        BackButton(navController)
        Spacer(modifier = Modifier.width(8.dp))
        Text(
            text = ruta.nombre,
            fontSize = 24.sp
        )
    }
}

@Composable
fun BackButton(navController: NavHostController) {
    IconButton(onClick = { navController.popBackStack() }) {
        Icon(Icons.Filled.ArrowBack, contentDescription = "Volver")
    }
}

@Composable
fun ContentDetailView(
    innerPadding: PaddingValues,
    rutas: List<Ruta>,
    id: Int?
) {
    val ruta = getRutaById(rutas, id) ?: return

    val backgroundColor = Color.White


    Column(
        modifier = Modifier
            .padding(innerPadding)
            .fillMaxSize()
            .verticalScroll(rememberScrollState())
    ) {
        Card(
            modifier = Modifier
                .fillMaxWidth()
                .background(backgroundColor)
                .padding(vertical = 8.dp),
            colors = CardDefaults.cardColors(containerColor = backgroundColor)
        ) {
            Column(modifier = Modifier.padding(16.dp)) {
                InfoRow("Inicio Ruta", ruta.nombreInicioruta)
                InfoRow("Final Ruta", ruta.nombreFinalruta)
                InfoRow("Latitud Inicial", ruta.latitudInicial.toString())
                InfoRow("Latitud Final", ruta.latitudFinal.toString())
                InfoRow("Longitud Inicial", ruta.longitudInicial.toString())
                InfoRow("Longitud Final", ruta.longitudFinal.toString())
                InfoRow("Distancia", "${ruta.distancia} km")
                InfoRow("Duración", ruta.duracion.ifEmpty { "No disponible" })
                InfoRow("Desnivel Positivo", ruta.desnivelPositivo?.toString() ?: "No disponible")
                InfoRow("Desnivel Negativo", ruta.desnivelNegativo?.toString() ?: "No disponible")
                InfoRow("Altitud Máxima", ruta.altitudMax?.toString() ?: "No disponible")
                InfoRow("Altitud Mínima", ruta.altitudMin?.toString() ?: "No disponible")
                InfoRow("Nivel de Esfuerzo", ruta.nivelEsfuerzo?.toString() ?: "No disponible")
                InfoRow("Nivel de Riesgo", ruta.nivelRiesgo?.toString() ?: "No disponible")
                InfoRow("Temporadas", ruta.temporadas ?: "No disponible")
                InfoRow("Accesibilidad", ruta.accesibilidad?.toString() ?: "No disponible")
                InfoRow("Ruta Familiar", ruta.rutaFamiliar?.toString() ?: "No disponible")
                InfoRow("Recomendaciones", ruta.recomendacionesEquipo ?: "No disponible")
                InfoRow("Zona Geográfica", ruta.zonaGeografica ?: "No disponible")
                InfoRow("Valoración Media", ruta.mediaEstrellas?.toString() ?: "No disponible")
            }
        }
    }
}

@Composable
fun InfoRow(label: String, value: String) {
    Column(modifier = Modifier.padding(vertical = 4.dp)) {
        Text(
            text = label,
            fontWeight = FontWeight.SemiBold,
            fontSize = 14.sp,
            color = Color.Black.copy(alpha = 0.7f)
        )
        Text(
            text = value,
            fontWeight = FontWeight.Medium,
            fontSize = 16.sp,
            color = Color.Black
        )
    }
}
