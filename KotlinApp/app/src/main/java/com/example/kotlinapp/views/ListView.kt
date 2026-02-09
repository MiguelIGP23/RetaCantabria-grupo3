package com.example.kotlinapp.views

import android.content.Context
import android.content.Intent
import android.net.Uri
import androidx.activity.compose.rememberLauncherForActivityResult
import androidx.activity.result.contract.ActivityResultContracts
import androidx.compose.foundation.Image
import androidx.compose.foundation.background
import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.*
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.foundation.lazy.items
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.AddCircle
import androidx.compose.material.icons.filled.Build
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
    Scaffold(topBar = { ListaTopBar(
        navController = navController,
        rutas = rutas,
        vm = vm
    ) }, floatingActionButton = {
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
fun ListaTopBar(navController: NavHostController, rutas: List<Ruta>, vm: DBViewModel) {
    val context = LocalContext.current

    val gpxLauncher = rememberLauncherForActivityResult(
        contract = ActivityResultContracts.OpenDocument(),
        onResult = { uri: Uri? ->
            uri?.let { selectedUri ->
                // Tomar permiso persistente
                context.contentResolver.takePersistableUriPermission(
                    selectedUri,
                    Intent.FLAG_GRANT_READ_URI_PERMISSION
                )

                // Leer GPX
                val gpxContent = context.contentResolver.openInputStream(selectedUri)
                    ?.bufferedReader().use { it?.readText() }

                if (!gpxContent.isNullOrEmpty()) {
                    // Crear ruta temporal
                    val rutaImportada = Ruta(
                        id = -1,
                        nombre = "Ruta importada",
                        nombreInicioruta = "Inicio GPX",
                        nombreFinalruta = "Final GPX",
                        latitudInicial = 0.0,
                        latitudFinal = 0.0,
                        longitudInicial = 0.0,
                        longitudFinal = 0.0,
                        distancia = 0.0,
                        duracion = "",
                        desnivelPositivo = 0,
                        desnivelNegativo = 0,
                        altitudMax = 0.0,
                        altitudMin = 0.0,
                        clasificacion = Clasificacion.CIRCULAR,
                        nivelEsfuerzo = 0,
                        nivelRiesgo = 0,
                        estadoRuta = 1,
                        tipoTerreno = 1,
                        indicaciones = 1,
                        temporadas = "",
                        accesibilidad = 0,
                        rutaFamiliar = 0,
                        archivoGPX = gpxContent,
                        recomendacionesEquipo = "",
                        zonaGeografica = "",
                        mediaEstrellas = 0.0,
                        usuario = IdRef(1)
                    )
                    // Guardar en ViewModel
                    vm.setRutaImportada(rutaImportada)

                    // Navegar a Travel
                    navController.navigate("Travel/imported")
                }
            }
        }
    )

    TopAppBar(
        title = { ListaTopBarTitle() },
        actions = {
            // Botón para importar GPX
            IconButton(onClick = { gpxLauncher.launch(arrayOf("application/gpx+xml")) }) {
                Icon(Icons.Default.Build, contentDescription = "Importar GPX")
            }

            // Botón recargar
            IconButton(onClick = { /* vm.cargarRutas() */ }) {
                Icon(Icons.Filled.Refresh, contentDescription = "Recargar Rutas")
            }

            // Botón cerrar sesión
            IconButton(onClick = { vm.logout() }) {
                Icon(Icons.Outlined.AccountCircle, contentDescription = "Cerrar Sesión")
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


