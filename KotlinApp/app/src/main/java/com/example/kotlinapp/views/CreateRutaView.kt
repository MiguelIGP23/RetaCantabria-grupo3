package com.example.kotlinapp.views

import com.example.kotlinapp.gps.location.LocationManager

import android.content.Context
import android.location.Location
import android.util.Log
import androidx.activity.compose.rememberLauncherForActivityResult
import androidx.activity.result.contract.ActivityResultContracts
import androidx.compose.foundation.background
import androidx.compose.foundation.layout.Box
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.Spacer
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.height
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.layout.size
import androidx.compose.foundation.layout.width
import androidx.compose.foundation.shape.RoundedCornerShape
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.AddCircle
import androidx.compose.material.icons.filled.ArrowBack
import androidx.compose.material3.Button
import androidx.compose.material3.ButtonDefaults
import androidx.compose.material3.Checkbox
import androidx.compose.material3.CheckboxDefaults
import androidx.compose.material3.Icon
import androidx.compose.material3.IconButton
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.runtime.DisposableEffect
import androidx.compose.runtime.LaunchedEffect
import androidx.compose.runtime.MutableState
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateListOf
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.runtime.setValue
import androidx.compose.runtime.snapshots.SnapshotStateList
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.platform.LocalContext
import androidx.compose.ui.platform.LocalLifecycleOwner
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import androidx.compose.ui.viewinterop.AndroidView
import androidx.lifecycle.Lifecycle
import androidx.lifecycle.LifecycleEventObserver
import androidx.navigation.NavController
import androidx.preference.PreferenceManager
import com.example.kotlinapp.gps.WaypointDialog
import com.example.kotlinapp.gps.gpx.generateGpx
import com.example.kotlinapp.gps.map.createCurrentLocationMarker
import com.example.kotlinapp.gps.map.createMapView
import com.example.kotlinapp.gps.map.createTrackpointMarker
import com.example.kotlinapp.model.Waypoint
import com.example.kotlinapp.model.WaypointDialogData
import com.example.kotlinapp.model.enums.WaypointType
import com.google.android.gms.location.LocationCallback
import com.google.android.gms.location.LocationRequest
import com.google.android.gms.location.LocationResult
import com.google.android.gms.location.LocationServices
import com.google.android.gms.location.Priority
import org.osmdroid.config.Configuration
import org.osmdroid.util.GeoPoint
import org.osmdroid.views.MapView
import org.osmdroid.views.overlay.Marker


private const val MIN_DISTANCE_METERS = 15f
private const val MIN_TIME_MS = 5000L

@Composable
fun CreateRutaView(navController: NavController) {
    val autoTrackpointEnabled = remember { mutableStateOf(false) }
    val context = LocalContext.current
    val lifecycleOwner = LocalLifecycleOwner.current

    val fusedLocationClient = remember { LocationServices.getFusedLocationProviderClient(context) }
    val textLat = remember { mutableStateOf("Latitud: --") }
    val textLon = remember { mutableStateOf("Longitud: --") }
    val isTracking = remember { mutableStateOf(false) }
    val savedTrackpoints = remember { mutableStateListOf<Triple<Double, Double, Double>>() }
    val savedWaypoints = remember { mutableStateListOf<Waypoint>() }

    // Configuración osmdroid
    val ctx = LocalContext.current.applicationContext
    Configuration.getInstance().load(ctx, ctx.getSharedPreferences("osmdroid", Context.MODE_PRIVATE))
    Configuration.getInstance().load(context, PreferenceManager.getDefaultSharedPreferences(context))

    // --------------------------- MAPA ---------------------------
    val mapView = remember { createMapView(context) }
    val currentMarker = remember(mapView) { createCurrentLocationMarker(mapView, context) }
    LaunchedEffect(Unit) { mapView.overlays.add(currentMarker) }

    var lastTrackpointLocation by remember { mutableStateOf<Location?>(null) }
    var lastTrackpointTime by remember { mutableStateOf(0L) }

    fun canSaveTrackpoint(newLocation: Location): Boolean {
        val now = System.currentTimeMillis()
        lastTrackpointLocation?.let { last ->
            if (last.distanceTo(newLocation) < MIN_DISTANCE_METERS) return false
            if (now - lastTrackpointTime < MIN_TIME_MS) return false
        }
        lastTrackpointLocation = newLocation
        lastTrackpointTime = now
        return true
    }

    val locationRequest = remember {
        LocationRequest.Builder(Priority.PRIORITY_HIGH_ACCURACY, 1000)
            .setMinUpdateDistanceMeters(1f)
            .build()
    }

    val locationCallback = remember {
        createLocationCallback(
            mapView = mapView,
            marker = currentMarker,
            isTracking = isTracking,
            autoTrackpointEnabled = autoTrackpointEnabled,
            savedLocations = savedTrackpoints,
            context = context,
            canSaveTrackpoint = ::canSaveTrackpoint,
            textLat = textLat,
            textLon = textLon
        )
    }

    val locationManager = remember {
        LocationManager(fusedLocationClient, locationRequest, locationCallback, isTracking)
    }

    // Observar cambios de isTracking y activar/desactivar location updates
    LaunchedEffect(isTracking.value) {
        if (isTracking.value) {
            locationManager.start(context)  // aquí inicia las actualizaciones
        } else {
            locationManager.stop()   // aquí detiene las actualizaciones
        }
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
                autoTrackpointEnabled = autoTrackpointEnabled,
                savedTrackpoints = savedTrackpoints,
                savedWaypoints = savedWaypoints,
                mapView = mapView,
                locationManager = locationManager,
                context = context,
                canSaveTrackpoint = ::canSaveTrackpoint
            )
        }
    }
}




fun createLocationCallback(
    mapView: MapView,
    marker: Marker,
    isTracking: MutableState<Boolean>,
    autoTrackpointEnabled: MutableState<Boolean>,
    savedLocations: MutableList<Triple<Double, Double, Double>>, // <-- corregido
    context: Context,
    canSaveTrackpoint: (Location) -> Boolean,
    textLat: MutableState<String>,
    textLon: MutableState<String>
): LocationCallback {

    var lastLat: Double? = null
    var lastLon: Double? = null
    val smoothFactor = 0.2

    return object : LocationCallback() {
        override fun onLocationResult(locationResult: LocationResult) {
            if (!isTracking.value) return
            val location = locationResult.lastLocation ?: return
            if (location.accuracy > 20f) return

            var lat = location.latitude
            var lon = location.longitude
            val alt = location.altitude

            val lastGeoPoint = lastLat?.let { GeoPoint(it, lastLon!!) }
            if (lastGeoPoint != null) {
                val newGeo = GeoPoint(lat, lon)
                val distance = lastGeoPoint.distanceToAsDouble(newGeo).toFloat()
                if (distance > 1f) {
                    lat = lastLat!! * (1 - smoothFactor) + lat * smoothFactor
                    lon = lastLon!! * (1 - smoothFactor) + lon * smoothFactor
                }
            }

            lastLat = lat
            lastLon = lon

            val geoPoint = GeoPoint(lat, lon, alt)
            marker.position = geoPoint
            mapView.controller.setCenter(geoPoint)
            mapView.invalidate()

            textLat.value = "Latitud: $lat"
            textLon.value = "Longitud: $lon"

            if (autoTrackpointEnabled.value && canSaveTrackpoint(location)) {
                // Guardar lat, lon y altitud
                savedLocations.add(Triple(lat, lon, alt))
                val wpMarker = createTrackpointMarker(mapView, context, "TRKPT ${savedLocations.size}")
                wpMarker.position = GeoPoint(lat, lon, alt)
                mapView.overlays.add(wpMarker)
                mapView.invalidate()
            }
        }
    }
}


@Composable
fun LocationControls(
    textLat: MutableState<String>,
    textLon: MutableState<String>,
    isTracking: MutableState<Boolean>,
    autoTrackpointEnabled: MutableState<Boolean>,
    savedTrackpoints: SnapshotStateList<Triple<Double, Double, Double>>,
    savedWaypoints: SnapshotStateList<Waypoint>,
    mapView: MapView,
    locationManager: LocationManager,
    context: Context,
    canSaveTrackpoint: (Location) -> Boolean
) {
    var waypointDialog by remember { mutableStateOf<WaypointDialogData?>(null) }

    Column(
        modifier = Modifier
            .fillMaxWidth()
            .background(Color.White)
            .padding(16.dp)
    ) {

        val createFileLauncher = rememberLauncherForActivityResult(
            ActivityResultContracts.CreateDocument("application/gpx+xml")
        ) { uri ->
            if (uri != null) {
                try {
                    context.contentResolver.openOutputStream(uri)?.use { output ->
                        output.write(generateGpx(savedTrackpoints,savedWaypoints).toByteArray())
                    }
                    Log.d("GPX", "GPX guardado correctamente")
                } catch (e: Exception) {
                    Log.e("GPX", "Error guardando GPX", e)
                }
            }
        }


        // --- Fila de Tracking y Añadir Trackpoint ---
        Row(
            modifier = Modifier.fillMaxWidth(),
            verticalAlignment = Alignment.CenterVertically
        ) {
            Button(
                onClick = { isTracking.value = !isTracking.value },
                colors = ButtonDefaults.buttonColors(
                    containerColor = if (isTracking.value) Color(0xFFFF6F61) else Color(0xFF4CAF50),
                    contentColor = Color.White
                )
            ) { Text(if (isTracking.value) "Detener Tracking" else "Iniciar Tracking") }

            Spacer(Modifier.weight(1f))

            Button(
                onClick = {
                    val lat = textLat.value.removePrefix("Latitud: ").toDoubleOrNull() ?: return@Button
                    val lon = textLon.value.removePrefix("Longitud: ").toDoubleOrNull() ?: return@Button
                    val alt = 0.0
                    savedTrackpoints.add(Triple(lat, lon, alt))
                    val marker = createTrackpointMarker(mapView, context, "WP ${savedTrackpoints.size}")
                    marker.position = GeoPoint(lat, lon, alt)
                    mapView.overlays.add(marker)
                    mapView.invalidate()
                },
                enabled = isTracking.value && !autoTrackpointEnabled.value,
                colors = ButtonDefaults.buttonColors(
                    containerColor = Color(0xFF2196F3),
                    contentColor = Color.White
                ),
                shape = RoundedCornerShape(12.dp),
                modifier = Modifier.height(48.dp) // solo height, no align
            ) {
                Icon(Icons.Default.AddCircle, contentDescription = "Añadir Punto", modifier = Modifier.size(24.dp))
                Spacer(modifier = Modifier.width(8.dp))
                Text("Añadir Punto")
            }
        }



// --- Texto de Latitud y Longitud ---
        Text(textLat.value, fontWeight = FontWeight.Bold, fontSize = 16.sp)
        Text(textLon.value, fontWeight = FontWeight.Bold, fontSize = 16.sp)

        Spacer(Modifier.height(16.dp))

// --- Toggle Auto Trackpoint ---
        Row(verticalAlignment = Alignment.CenterVertically) {
            Checkbox(
                checked = autoTrackpointEnabled.value,
                onCheckedChange = { autoTrackpointEnabled.value = it },
                colors = CheckboxDefaults.colors(
                    checkedColor = Color(0xFF4CAF50), // verde suave
                    uncheckedColor = Color.Gray
                )
            )
            Spacer(Modifier.width(8.dp))
            Text("Auto Trackpoint")
        }

        Spacer(Modifier.height(16.dp))

// --- Botones de Waypoint ---
        Row {
            Button(
                colors = ButtonDefaults.buttonColors(
                    containerColor = Color(0xFF4CAF50),
                    contentColor = Color.White
                ),
                onClick = {
                    val lat = textLat.value.removePrefix("Latitud: ").toDoubleOrNull() ?: return@Button
                    val lon = textLon.value.removePrefix("Longitud: ").toDoubleOrNull() ?: return@Button
                    val alt = 0.0
                    waypointDialog = WaypointDialogData(lat, lon,alt, WaypointType.INTERES)
                },
                enabled = isTracking.value
            ) { Text("Punto Interés") }

            Spacer(Modifier.width(16.dp))

            Button(
                colors = ButtonDefaults.buttonColors(
                    containerColor = Color(0xFFFFA726), // naranja suave
                    contentColor = Color.White
                ),
                onClick = {
                    val lat = textLat.value.removePrefix("Latitud: ").toDoubleOrNull() ?: return@Button
                    val lon = textLon.value.removePrefix("Longitud: ").toDoubleOrNull() ?: return@Button
                    val alt = 0.0
                    waypointDialog = WaypointDialogData(lat, lon,alt, WaypointType.PELIGRO)
                },
                enabled = isTracking.value
            ) { Text("Punto Peligro") }
        }

        Spacer(Modifier.height(16.dp))

        Button(
            onClick = { createFileLauncher.launch("mis_puntos.gpx") },
            enabled = savedTrackpoints.isNotEmpty(),
            colors = ButtonDefaults.buttonColors(
                containerColor = Color(0xFF64B5F6), // azul suave
                contentColor = Color.White
            ),
            modifier = Modifier.fillMaxWidth()
        ) {
            Text("Descargar GPX")
        }




        // --- Diálogo Waypoint ---
        waypointDialog?.let { dialogData ->
            WaypointDialog(
                dialogData = dialogData,
                onDismiss = { waypointDialog = null },
                onSave = { wp ->
                    savedWaypoints.add(wp)
                    val marker = createTrackpointMarker(mapView, context, wp.title)
                    marker.position = GeoPoint(wp.lat, wp.lon)
                    mapView.overlays.add(marker)
                    mapView.invalidate()
                    waypointDialog = null
                }
            )
        }
    }
}