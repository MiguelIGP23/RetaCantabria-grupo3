package com.example.kotlinapp.views

import android.content.Context
import androidx.compose.foundation.Image
import androidx.compose.foundation.background
import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.*
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.foundation.lazy.items
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.AddCircle
import androidx.compose.material.icons.filled.Refresh
import androidx.compose.material.icons.outlined.AccountCircle
import androidx.compose.material3.*
import androidx.compose.runtime.*
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.platform.LocalContext
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import androidx.navigation.NavHostController
import com.example.kotlinapp.R
import com.example.kotlinapp.data.IdRef
import com.example.kotlinapp.gps.gpx.generateGpx
import com.example.kotlinapp.model.Ruta
import com.example.kotlinapp.model.Trackpoint
import com.example.kotlinapp.model.Usuario
import com.example.kotlinapp.model.Waypoint
import com.example.kotlinapp.model.enums.Clasificacion
import com.example.kotlinapp.model.enums.Rol
import com.example.kotlinapp.model.enums.WaypointType
import com.example.kotlinapp.ui.theme.fondoPrincipal
import com.example.kotlinapp.viewmodels.DBViewModel
import kotlinx.coroutines.flow.firstOrNull


@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun ListView(navController: NavHostController, vm: DBViewModel) {
//fun ListView(navController: NavHostController, vm: DBViewModel) {
    val context = LocalContext.current
    var searchText by remember { mutableStateOf("") }

    val rutas by vm.rutas.collectAsState() // Lista de ejemplo

    val loginState by vm.loginState.collectAsState()
    LaunchedEffect(Unit) {
        if (vm.token.firstOrNull() != null) {
            vm.checkAuth()
        } else {
            navController.navigate("Login")
        }
    }
    LaunchedEffect(loginState) {
        when (loginState) {
            DBViewModel.LoginState.Valid -> Unit
            DBViewModel.LoginState.Waiting -> Unit
            else -> navController.navigate("Login")
        }
    }
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
    Scaffold(topBar = { ListaTopBar(context, vm) }, floatingActionButton = {
        FloatingActionButton(
            onClick = {
                navController.navigate("Create")
            }, containerColor = Color(0xFF4CAF50), // verde
            contentColor = Color.White
        ) {
            Icon(
                Icons.Default.AddCircle,
                contentDescription = "Añadir Ruta",
                modifier = Modifier.size(24.dp)
            )
        }
    }) { innerPadding ->
        Column(
            modifier = Modifier
                .fillMaxSize()
                .padding(innerPadding)
        ) {
            Spacer(modifier = Modifier.height(8.dp))
            SearchBar(searchText) { searchText = it }
            Spacer(modifier = Modifier.height(8.dp))
            RutaList(
                rutasFiltradas,
                navController
            )
        }
    }
}


// TopBar de la lista con logo y botón de recarga
@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun ListaTopBar(context: Context, vm: DBViewModel) {
    TopAppBar(
        title = { ListaTopBarTitle() }, actions = {
            IconButton(onClick = { /* api.cargarRutas() */ }) {
                Icon(Icons.Filled.Refresh, contentDescription = "Recargar Rutas")
            }
            IconButton(
                onClick = { vm.logout()}) {
                Icon(
                    Icons.Outlined.AccountCircle,
                    contentDescription = "Cerrar Sesion"
                ) //Icono temporal
            }
        }, colors = TopAppBarDefaults.topAppBarColors(
            containerColor = fondoPrincipal, titleContentColor = Color.Black
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
fun RutaList(rutas: List<Ruta>, navController: NavHostController) {
    LazyColumn(
        modifier = Modifier.fillMaxSize(),
        contentPadding = PaddingValues(8.dp),
        verticalArrangement = Arrangement.spacedBy(8.dp)
    ) {
        items(rutas) { ruta ->
            RutaItem(ruta) {
                // onClick: navegar al detalle de la ruta
                navController.navigate("detail/${ruta.id}")
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
            .clickable { onClick() }) {
        Text(
            text = "Ruta: ${ruta.nombre}",
            color = Color.Black,
            fontSize = 16.sp
        )
    }
}


fun cargarRutasDummy(): List<Ruta> {
    val usuarioDummy = Usuario(1, "Oriol", "Fernandez", "", "", Rol.ADMINISTRADOR)
    val usuarioRef = IdRef(usuarioDummy.id ?: 0)

    // Trackpoints dummy
    val trackpoints1 = listOf(
        Trackpoint(1, 1,40.0, -3.0, 100.0, System.currentTimeMillis()),
        Trackpoint(1, 2,40.1, -3.05, 120.0, System.currentTimeMillis() + 10000),
        Trackpoint(1, 3,40.2, -3.1, 130.0, System.currentTimeMillis() + 20000)
    )

    // Waypoints dummy
    val waypoints1 = listOf(
        Waypoint(40.05, -3.02, 110.0, WaypointType.INTERES, "Inicio", "Inicio de la ruta"),
        Waypoint(40.15, -3.08, 125.0, WaypointType.INTERES, "Mirador", "Vistas panorámicas")
    )

    // Creamos la ruta primero sin GPX
    val ruta1 = Ruta(
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
        archivoGPX = null, // temporal
        recomendacionesEquipo = "Agua y calzado adecuado",
        zonaGeografica = "Sierra",
        mediaEstrellas = 4.5,
        usuario = usuarioRef
    )

    // Ahora generamos GPX usando la ruta creada
    val ruta1ConGpx = ruta1.copy(
        archivoGPX = generateGpx(ruta1, trackpoints1, waypoints1)
    )

    // Las demás rutas pueden quedar como antes
    val ruta2 = Ruta(
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
    )

    // Resto de rutas sin cambios
    val ruta3 = Ruta(
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
    )

    val ruta4 = Ruta(
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
    )

    val ruta5 = Ruta(
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

    return listOf(ruta1ConGpx, ruta2, ruta3, ruta4, ruta5)
}
