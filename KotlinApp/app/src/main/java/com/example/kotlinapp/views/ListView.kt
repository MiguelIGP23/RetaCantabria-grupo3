package com.example.kotlinapp.views

import android.os.Build
import androidx.annotation.RequiresApi
import androidx.compose.foundation.Image
import androidx.compose.foundation.background
import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.*
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.foundation.lazy.items
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.AddCircle
import androidx.compose.material.icons.filled.Refresh
import androidx.compose.material3.*
import androidx.compose.runtime.*
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.platform.LocalContext
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import androidx.navigation.NavController
import com.example.kotlinapp.R
import com.example.kotlinapp.data.IdRef
import com.example.kotlinapp.model.Ruta
import com.example.kotlinapp.model.Usuario
import com.example.kotlinapp.model.enums.Clasificacion
import com.example.kotlinapp.model.enums.Rol
import com.example.kotlinapp.ui.theme.fondoPrincipal

@RequiresApi(Build.VERSION_CODES.O)
@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun ListView(navController: NavController) {
    val context = LocalContext.current
    var searchText by remember { mutableStateOf("") }

    val rutas = cargarRutasDummy() // Lista de ejemplo

    // Filtrar rutas según texto de búsqueda
    val rutasFiltradas = remember(rutas, searchText) {
        if (searchText.isNotEmpty()) {
            rutas.filter {
                it.nombre.contains(searchText, ignoreCase = true)
            }
        } else {
            rutas
        }
    }

    // Scaffold con floatingActionButton
    Scaffold(
        topBar = { ListaTopBar(context) },
        floatingActionButton = {
            FloatingActionButton(
                onClick = {
                    // Por ahora no hace nada
                },
                containerColor = Color(0xFF4CAF50), // verde
                contentColor = Color.White
            ) {
                Icon(Icons.Default.AddCircle, contentDescription = "Añadir Ruta", modifier = Modifier.size(24.dp))
            }
        }
    ) { innerPadding ->
        Column(
            modifier = Modifier
                .fillMaxSize()
                .padding(innerPadding)
        ) {
            Spacer(modifier = Modifier.height(8.dp))
            SearchBar(searchText) { searchText = it }
            Spacer(modifier = Modifier.height(8.dp))
            RutaList(rutasFiltradas)
        }
    }
}


// TopBar de la lista con logo y botón de recarga
@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun ListaTopBar(context: android.content.Context /*, api: ApiModel*/) {
    TopAppBar(
        title = { ListaTopBarTitle() },
        actions = {
            IconButton(onClick = { /* api.cargarRutas() */ }) {
                Icon(Icons.Filled.Refresh, contentDescription = "Recargar Rutas")
            }
        },
        colors = TopAppBarDefaults.topAppBarColors(
            containerColor = fondoPrincipal,
            titleContentColor = Color.Black
        )
    )
}

// Composable de título del TopBar (logo + texto)
@Composable
fun ListaTopBarTitle() {
    Row(verticalAlignment = Alignment.CenterVertically) {
        Image(
            painter = painterResource(R.drawable.currentlocation),
            contentDescription = "Logo",
            modifier = Modifier.size(32.dp)
        )
        Spacer(modifier = Modifier.width(8.dp))
        Text("Rutas")
    }
}



// Campo de búsqueda de rutas
@Composable
fun SearchBar(value: String, onValueChange: (String) -> Unit) {
    OutlinedTextField(
        value = value,
        onValueChange = onValueChange,
        label = { Text("Buscar ruta (nombre)") },
        modifier = Modifier
            .fillMaxWidth()
            .padding(horizontal = 8.dp)
    )
}

// Lista de rutas en LazyColumn
@Composable
fun RutaList(rutas: List<Ruta> /*, navController: NavHostController*/) {
    LazyColumn(
        modifier = Modifier.fillMaxSize(),
        contentPadding = PaddingValues(8.dp),
        verticalArrangement = Arrangement.spacedBy(8.dp)
    ) {
        items(rutas) { ruta ->
            RutaItem(ruta) {
                // onClick: navegar al detalle de la ruta
                // navController.navigate("detail/${ruta.idRuta}")
            }
        }
    }
}

// Composable individual de cada ruta
@Composable
fun RutaItem(ruta: Ruta, onClick: () -> Unit) {
    val color = when (ruta.clasificacion) {
        Clasificacion.CIRCULAR -> Color(0xFFA5D6A7) // ejemplo verde
        Clasificacion.LINEAL -> Color(0xFFFFCC80)   // ejemplo naranja
        else -> Color.LightGray
    }

    Box(
        modifier = Modifier
            .fillMaxWidth()
            .background(color)
            .padding(16.dp)
            .clickable { onClick() }
    ) {
        Text(
            text = "Ruta: ${ruta.nombre}",
            color = Color.Black,
            fontSize = 16.sp
        )
    }
}

@RequiresApi(Build.VERSION_CODES.O)
fun cargarRutasDummy(): List<Ruta> {
    val usuarioDummy = Usuario(1, "Oriol", "Fernandez", "", "", Rol.ADMINISTRADOR)
    val usuarioRef = IdRef(usuarioDummy.id ?: 0)
    return listOf(
        Ruta(
            id = 1,
            nombre = "Ruta Circular Montaña",
            nombreInicioruta = "Inicio A",
            nombreFinalruta = "Final A",
            latitudInicial = 40.0,
            latitudFinal = 40.5,
            longitudInicial = -3.0,
            longitudFinal = -3.5,
            distancia = 10.0,
            duracion = "",
            desnivelPositivo = 300,
            desnivelNegativo = 300,
            altitudMax = 1200.0,
            altitudMin = 900.0,
            clasificacion = Clasificacion.CIRCULAR,
            nivelEsfuerzo = 3,
            nivelRiesgo = 2,
            estadoRuta = 1,
            tipoTerreno = 1,
            indicaciones = 1,
            temporadas = "Verano",
            accesibilidad = 1,
            rutaFamiliar = 0,
            archivoGPX = null,
            recomendacionesEquipo = "Agua y calzado adecuado",
            zonaGeografica = "Sierra",
            mediaEstrellas = 4.5,
            usuario = usuarioRef
        ),
        Ruta(
            id = 2,
            nombre = "Ruta Lineal Río",
            nombreInicioruta = "Inicio B",
            nombreFinalruta = "Final B",
            latitudInicial = 41.0,
            latitudFinal = 41.5,
            longitudInicial = -2.0,
            longitudFinal = -2.5,
            distancia = 8.0,
            duracion = "",
            desnivelPositivo = 100,
            desnivelNegativo = 120,
            altitudMax = 600.0,
            altitudMin = 500.0,
            clasificacion = Clasificacion.LINEAL,
            nivelEsfuerzo = 2,
            nivelRiesgo = 1,
            estadoRuta = 1,
            tipoTerreno = 1,
            indicaciones = 1,
            temporadas = "Primavera",
            accesibilidad = 1,
            rutaFamiliar = 1,
            archivoGPX = null,
            recomendacionesEquipo = "Calzado cómodo",
            zonaGeografica = "Valle",
            mediaEstrellas = 4.0,
            usuario = usuarioRef
        ),
        Ruta(
            id = 3,
            nombre = "Ruta Circular Bosque",
            nombreInicioruta = "Inicio C",
            nombreFinalruta = "Final C",
            latitudInicial = 42.0,
            latitudFinal = 42.3,
            longitudInicial = -1.0,
            longitudFinal = -1.4,
            distancia = 6.5,
            duracion = "",
            desnivelPositivo = 150,
            desnivelNegativo = 150,
            altitudMax = 800.0,
            altitudMin = 650.0,
            clasificacion = Clasificacion.CIRCULAR,
            nivelEsfuerzo = 2,
            nivelRiesgo = 1,
            estadoRuta = 1,
            tipoTerreno = 1,
            indicaciones = 1,
            temporadas = "Otoño",
            accesibilidad = 1,
            rutaFamiliar = 1,
            archivoGPX = null,
            recomendacionesEquipo = "Ropa de abrigo ligera",
            zonaGeografica = "Bosque",
            mediaEstrellas = 4.7,
            usuario = usuarioRef
        ),
        Ruta(
            id = 4,
            nombre = "Ruta Lineal Costa",
            nombreInicioruta = "Inicio D",
            nombreFinalruta = "Final D",
            latitudInicial = 43.0,
            latitudFinal = 43.5,
            longitudInicial = 0.0,
            longitudFinal = 0.5,
            distancia = 9.0,
            duracion = "",
            desnivelPositivo = 50,
            desnivelNegativo = 50,
            altitudMax = 50.0,
            altitudMin = 0.0,
            clasificacion = Clasificacion.LINEAL,
            nivelEsfuerzo = 1,
            nivelRiesgo = 1,
            estadoRuta = 1,
            tipoTerreno = 1,
            indicaciones = 1,
            temporadas = "Verano",
            accesibilidad = 1,
            rutaFamiliar = 1,
            archivoGPX = null,
            recomendacionesEquipo = "Protector solar",
            zonaGeografica = "Costa",
            mediaEstrellas = 4.3,
            usuario = usuarioRef
        ),
        Ruta(
            id = 5,
            nombre = "Ruta Circular Lago",
            nombreInicioruta = "Inicio E",
            nombreFinalruta = "Final E",
            latitudInicial = 44.0,
            latitudFinal = 44.5,
            longitudInicial = 1.0,
            longitudFinal = 1.5,
            distancia = 7.0,
            duracion = "",
            desnivelPositivo = 200,
            desnivelNegativo = 200,
            altitudMax = 700.0,
            altitudMin = 500.0,
            clasificacion = Clasificacion.CIRCULAR,
            nivelEsfuerzo = 2,
            nivelRiesgo = 1,
            estadoRuta = 1,
            tipoTerreno = 1,
            indicaciones = 1,
            temporadas = "Invierno",
            accesibilidad = 1,
            rutaFamiliar = 0,
            archivoGPX = null,
            recomendacionesEquipo = "Ropa de abrigo",
            zonaGeografica = "Lago",
            mediaEstrellas = 4.6,
            usuario = usuarioRef
        )
    )
}
