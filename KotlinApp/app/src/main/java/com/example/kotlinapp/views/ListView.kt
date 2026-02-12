package com.example.kotlinapp.views

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
import androidx.compose.material.icons.filled.PlayArrow
import androidx.compose.material.icons.filled.Refresh
import androidx.compose.material.icons.outlined.AccountCircle
import androidx.compose.material.icons.outlined.PlayArrow
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
import com.example.kotlinapp.gps.gpx.importarGpx
import com.example.kotlinapp.model.Ruta
import com.example.kotlinapp.model.enums.Clasificacion
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
                navController,
                vm
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
        ActivityResultContracts.OpenDocument()
    ) { uri ->
        uri ?: return@rememberLauncherForActivityResult

        val ruta = importarGpx(context, uri) ?: return@rememberLauncherForActivityResult

        vm.setRutaImportada(ruta)
        navController.navigate("Travel/imported")
    }


    TopAppBar(
        title = { ListaTopBarTitle() },
        actions = {
            // Botón para importar GPX
            IconButton(onClick = { gpxLauncher.launch(arrayOf("application/xml", "text/xml", "*/*"))
            }) {
                Icon(Icons.Default.PlayArrow, contentDescription = "Importar GPX")
            }

            // Botón recargar
            IconButton(onClick = { vm.checkAuth() }) {
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
fun RutaList(rutas: List<Ruta>, navController: NavHostController, vm: DBViewModel) {
    LazyColumn(
        modifier = Modifier.fillMaxSize(),
        contentPadding = PaddingValues(8.dp),
        verticalArrangement = Arrangement.spacedBy(8.dp)
    ) {
        items(rutas) { ruta ->
            RutaItem(
                ruta = ruta,
                onClick = {
                    // clic en todo el item → ir al detalle
                    navController.navigate("detail/${ruta.id}")
                },
                onPlayClick = {
                    // clic en el botón de recorrer ruta → iniciar recorrido
                    vm.setRutaImportada(ruta)
                    navController.navigate("Travel/imported") // o lo que haga iniciar la ruta
                }
            )
        }
    }
}


// Composable individual de cada ruta
@Composable
fun RutaItem(ruta: Ruta, onClick: () -> Unit, onPlayClick: () -> Unit = {}) {
    val color = when (ruta.estadoRuta!!.toInt()) {
        1 -> Color(0xFFA5D6A7) // verde
        0 -> Color(0xFFFF7369)   // rojo
        else -> Color(0xFF79BDFA)
    }

    Card(
        modifier = Modifier
            .fillMaxWidth()
            .clickable { onClick() },
        colors = CardDefaults.cardColors(containerColor = color),
        elevation = CardDefaults.cardElevation(defaultElevation = 4.dp)
    ) {
        Row(
            modifier = Modifier
                .fillMaxWidth()
                .padding(horizontal = 16.dp, vertical = 12.dp),
            verticalAlignment = Alignment.CenterVertically
        ) {
            // Nombre de la ruta ocupa la mayor parte del Row
            Text(
                text = ruta.nombre,
                color = Color.Black,
                fontSize = 16.sp,
                modifier = Modifier.weight(1f)
            )

            Spacer(modifier = Modifier.width(8.dp)) // separador entre texto y botón

            // Botón recorrer ruta a la derecha con forma circular y fondo
            Box(
                modifier = Modifier
                    .size(40.dp)
                    .background(color = Color.White, shape = MaterialTheme.shapes.small)
            ) {
                IconButton(
                    onClick = onPlayClick,
                    modifier = Modifier.fillMaxSize()
                ) {
                    Icon(
                        Icons.Outlined.PlayArrow,
                        contentDescription = "Recorrer Ruta",
                        tint = Color.Black
                    )
                }
            }
        }
    }
}



