package com.example.kotlinapp

import android.Manifest
import android.content.Context
import android.content.pm.PackageManager
import android.os.Bundle
import android.os.Environment
import android.util.Log
import androidx.activity.ComponentActivity
import androidx.activity.compose.rememberLauncherForActivityResult
import androidx.activity.compose.setContent
import androidx.activity.result.contract.ActivityResultContracts
import androidx.compose.foundation.background
import androidx.compose.foundation.layout.*
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.ArrowBack
import androidx.compose.material3.*
import androidx.compose.runtime.*
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.platform.LocalContext
import androidx.compose.ui.platform.LocalLifecycleOwner
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import androidx.compose.ui.viewinterop.AndroidView
import androidx.core.content.ContextCompat
import androidx.lifecycle.Lifecycle
import androidx.lifecycle.LifecycleEventObserver
import androidx.preference.PreferenceManager
import com.google.android.gms.location.*
import org.osmdroid.config.Configuration
import org.osmdroid.tileprovider.tilesource.TileSourceFactory
import org.osmdroid.util.GeoPoint
import org.osmdroid.views.MapView
import org.osmdroid.views.overlay.Marker
import java.io.File

class MainActivity : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContent {
            Scaffold { padding ->
                MainScreen(modifier = Modifier.padding(padding))
            }
        }
    }
}

@Composable
fun MainScreen(modifier: Modifier) {
    RequestPermission(Manifest.permission.ACCESS_FINE_LOCATION, "Permiso de ubicación requerido") {
        LocationScreen(modifier)
    }
}

// --------------------------- PERMISOS REUTILIZABLE ---------------------------

@Composable
fun RequestPermission(permission: String, message: String, onGranted: @Composable () -> Unit) {
    val context = LocalContext.current
    var hasPermission by remember {
        mutableStateOf(
            ContextCompat.checkSelfPermission(context, permission) == PackageManager.PERMISSION_GRANTED
        )
    }

    val permissionLauncher = rememberLauncherForActivityResult(
        contract = ActivityResultContracts.RequestPermission()
    ) { isGranted -> hasPermission = isGranted }

    LaunchedEffect(Unit) { if (!hasPermission) permissionLauncher.launch(permission) }

    if (hasPermission) onGranted() else Text(message)
}

// --------------------------- LOCATION SCREEN ---------------------------

@Composable
fun LocationScreen(modifier: Modifier) {

    val context = LocalContext.current
    val lifecycleOwner = LocalLifecycleOwner.current

    val fusedLocationClient = remember { LocationServices.getFusedLocationProviderClient(context) }
    val textLat = remember { mutableStateOf("Latitud: --") }
    val textLon = remember { mutableStateOf("Longitud: --") }
    val isTracking = remember { mutableStateOf(false) }
    val savedLocations = remember { mutableStateListOf<Pair<Double, Double>>() }

    // Configuración osmdroid
    val ctx = LocalContext.current.applicationContext
    Configuration.getInstance().load(ctx, ctx.getSharedPreferences("osmdroid", Context.MODE_PRIVATE))
    Configuration.getInstance().load(context, PreferenceManager.getDefaultSharedPreferences(context))

    // --------------------------- MAPA ---------------------------
    val mapView = remember { createMapView(context) }
    val currentMarker = remember { createCurrentLocationMarker(
        mapView, context
    ) }
    LaunchedEffect(Unit) { mapView.overlays.add(currentMarker) }

    val locationRequest = remember { LocationRequest.Builder(Priority.PRIORITY_HIGH_ACCURACY, 100).build() }
    val locationCallback = remember { createLocationCallback(mapView, currentMarker, textLat, textLon) }

    val locationManager = remember {
        LocationManager(
            fusedLocationClient,
            locationRequest,
            locationCallback,
            isTracking
        )
    }



    DisposableEffect(lifecycleOwner) {
        val observer = LifecycleEventObserver { _, event ->
            if (event == Lifecycle.Event.ON_DESTROY) locationManager.stop()
        }
        lifecycleOwner.lifecycle.addObserver(observer)
        onDispose { lifecycleOwner.lifecycle.removeObserver(observer) }
    }

    // --------------------------- UI ---------------------------
    Box(modifier = Modifier.fillMaxSize()) {
        AndroidView(factory = { mapView }, modifier = Modifier.fillMaxWidth().height(300.dp))

        IconButton(
            onClick = {},
            modifier = Modifier.align(Alignment.TopStart).padding(16.dp)
        ) { Icon(Icons.Default.ArrowBack, contentDescription = "Volver") }

        Column(modifier = Modifier.fillMaxSize()) {
            Spacer(modifier = Modifier.weight(1f))
            LocationControls(
                textLat = textLat,
                textLon = textLon,
                isTracking = isTracking,
                savedLocations = savedLocations,
                mapView = mapView,
                locationManager = locationManager,
                context = context
            )
        }
    }
}

// --------------------------- FUNCIONES AUXILIARES ---------------------------

fun createMapView(context: Context): MapView = MapView(context).apply {
    setTileSource(TileSourceFactory.MAPNIK)
    setMultiTouchControls(true)
    controller.setZoom(15.0)
}

fun createCurrentLocationMarker(mapView: MapView, context: Context): Marker =
    Marker(mapView).apply {
        title = "Estás aquí"
        setAnchor(Marker.ANCHOR_CENTER, Marker.ANCHOR_BOTTOM)

        val drawable = ContextCompat.getDrawable(context, R.drawable.currentlocation)
        drawable?.setBounds(0, 0, 80, 80) // 👈 TAMAÑO OBLIGATORIO
        icon = drawable
    }


fun createWaypointMarker(mapView: MapView, context: Context, title: String): Marker =
    Marker(mapView).apply {
        this.title = title
        setAnchor(Marker.ANCHOR_CENTER, Marker.ANCHOR_BOTTOM)

        val drawable = ContextCompat.getDrawable(context, R.drawable.locationicon)
        drawable?.setBounds(0, 0, 60, 60) // 👈 TAMAÑO OBLIGATORIO
        icon = drawable
    }



fun createLocationCallback(
    mapView: MapView,
    marker: Marker,
    textLat: MutableState<String>,
    textLon: MutableState<String>
) = object : LocationCallback() {
    override fun onLocationResult(locationResult: LocationResult) {
        locationResult.lastLocation?.let { location ->
            val lat = location.latitude
            val lon = location.longitude
            textLat.value = "Latitud: $lat"
            textLon.value = "Longitud: $lon"

            val geoPoint = GeoPoint(lat, lon)
            marker.position = geoPoint
            mapView.controller.setCenter(geoPoint)
            mapView.invalidate()
        }
    }
}

@Composable
fun LocationControls(
    textLat: MutableState<String>,
    textLon: MutableState<String>,
    isTracking: MutableState<Boolean>,
    savedLocations: MutableList<Pair<Double, Double>>,
    mapView: MapView,
    locationManager: LocationManager,
    context: Context
) {
    Column(
        modifier = Modifier.fillMaxWidth().background(Color.White).padding(16.dp)
    ) {

        // SAF: selector para guardar archivo
        val createFileLauncher = rememberLauncherForActivityResult(
            ActivityResultContracts.CreateDocument("application/gpx+xml")
        ) { uri ->
            if (uri != null) {
                try {
                    context.contentResolver.openOutputStream(uri)?.use { output ->
                        output.write(generateGpx(savedLocations).toByteArray())
                    }
                    Log.d("GPX", "GPX guardado correctamente")
                } catch (e: Exception) {
                    Log.e("GPX", "Error guardando GPX", e)
                }
            }
        }

        Text(textLat.value, fontSize = 20.sp, fontWeight = FontWeight.Bold)
        Spacer(Modifier.height(8.dp))
        Text(textLon.value, fontSize = 20.sp, fontWeight = FontWeight.Bold)
        Spacer(Modifier.height(16.dp))

        Button(onClick = { locationManager.start(context) }, enabled = !isTracking.value) { Text("Iniciar") }
        Spacer(Modifier.height(16.dp))

        Button(
            onClick = {
                val lat = textLat.value.removePrefix("Latitud: ").toDoubleOrNull()
                val lon = textLon.value.removePrefix("Longitud: ").toDoubleOrNull()
                if (lat != null && lon != null) {
                    savedLocations.add(Pair(lat, lon))
                    val marker = createWaypointMarker(
                        mapView,
                        context,
                        "Ubicación ${savedLocations.size}"
                    )

                    marker.position = GeoPoint(lat, lon) // 👈 ESTO FALTABA
                    mapView.overlays.add(marker)
                    mapView.invalidate()

                }
            },
            enabled = textLat.value != "Latitud: --"
        ) { Text("Guardar ubicación") }

        Spacer(Modifier.height(16.dp))

        Button( onClick = { createFileLauncher.launch("mis_puntos.gpx") }, enabled = savedLocations.isNotEmpty() ) { Text("Exportar GPX") }

        Spacer(Modifier.height(16.dp))
        LazyColumn {
            items(savedLocations.size) { index ->
                val (lat, lon) = savedLocations[index]
                //Text("${index + 1}. Lat: $lat, Lon: $lon", fontSize = 16.sp)
            }
        }
    }
}

// --------------------------- FUNCIONES GPX ---------------------------

fun generateGpx(savedLocations: List<Pair<Double, Double>>): String {
    val sb = StringBuilder()
    sb.append("""<?xml version="1.0" encoding="UTF-8"?>""")
    sb.append("\n<gpx version=\"1.1\" creator=\"KotlinApp\">\n")
    savedLocations.forEachIndexed { index, (lat, lon) ->
        sb.append("    <wpt lat=\"$lat\" lon=\"$lon\">\n")
        sb.append("        <name>Punto ${index + 1}</name>\n")
        sb.append("    </wpt>\n")
    }
    sb.append("</gpx>")
    return sb.toString()
}

fun saveGpx(context: Context, savedLocations: List<Pair<Double, Double>>, fileName: String = "mis_puntos.gpx") {
    try {
        val downloadsDir = Environment.getExternalStoragePublicDirectory(Environment.DIRECTORY_DOWNLOADS)
        if (!downloadsDir.exists()) downloadsDir.mkdirs()
        val file = File(downloadsDir, fileName)
        file.writeText(generateGpx(savedLocations))
        Log.d("GPX", "Archivo guardado en Descargas: ${file.absolutePath}")
    } catch (e: Exception) {
        Log.e("GPX", "Error guardando GPX en Descargas", e)
    }
}