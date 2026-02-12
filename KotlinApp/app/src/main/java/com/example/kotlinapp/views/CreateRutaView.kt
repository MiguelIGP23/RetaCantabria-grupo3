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
import androidx.compose.material3.Button
import androidx.compose.material3.ButtonDefaults
import androidx.compose.material3.Checkbox
import androidx.compose.material3.CheckboxDefaults
import androidx.compose.material3.Icon
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
import androidx.compose.ui.unit.dp
import androidx.compose.ui.viewinterop.AndroidView
import androidx.lifecycle.Lifecycle
import androidx.lifecycle.LifecycleEventObserver
import androidx.navigation.NavHostController
import androidx.preference.PreferenceManager
import com.example.kotlinapp.gps.FinishRouteDialog
import com.example.kotlinapp.gps.WaypointDialog
import com.example.kotlinapp.gps.gpx.generateGpx
import com.example.kotlinapp.gps.map.createCurrentLocationMarker
import com.example.kotlinapp.gps.map.createMapView
import com.example.kotlinapp.gps.map.createTrackpointMarker
import com.example.kotlinapp.model.PuntoInteres
import com.example.kotlinapp.model.PuntoPeligro
import com.example.kotlinapp.model.Ruta
import com.example.kotlinapp.model.Trackpoint
import com.example.kotlinapp.model.Waypoint
import com.example.kotlinapp.model.WaypointDialogData
import com.example.kotlinapp.model.enums.WaypointType
import com.example.kotlinapp.viewmodels.DBViewModel
import com.google.android.gms.location.LocationCallback
import com.google.android.gms.location.LocationRequest
import com.google.android.gms.location.LocationResult
import com.google.android.gms.location.LocationServices
import com.google.android.gms.location.Priority
import org.osmdroid.config.Configuration
import org.osmdroid.util.GeoPoint
import org.osmdroid.views.MapView
import org.osmdroid.views.overlay.Marker
import org.osmdroid.views.overlay.Polyline
import androidx.compose.runtime.collectAsState


private const val MIN_DISTANCE_METERS = 15f
private const val MIN_TIME_MS = 5000L

@Composable
fun CreateRutaView(navController: NavHostController, dbViewModel: DBViewModel) {
    val autoTrackpointEnabled = remember { mutableStateOf(false) }
    val context = LocalContext.current
    val lifecycleOwner = LocalLifecycleOwner.current
    val trackpointIdCounter = remember { mutableStateOf(1) }
    val fusedLocationClient = remember { LocationServices.getFusedLocationProviderClient(context) }
    val textLat = remember { mutableStateOf("Latitud: --") }
    val textLon = remember { mutableStateOf("Longitud: --") }
    val isTracking = remember { mutableStateOf(false) }
    val currentAltitude = remember { mutableStateOf(0.0) }

    val trackPolyline = remember {
        Polyline().apply {
            color = android.graphics.Color.RED
            width = 6f
        }
    }


    // Ahora guardamos Trackpoint completo
    val savedTrackpoints = remember { mutableStateListOf<Trackpoint>() }
    val savedPuntosInteres = remember { mutableStateListOf<PuntoInteres>() }
    val savedPuntosPeligro = remember { mutableStateListOf<PuntoPeligro>() }

    // Configuración osmdroid
    val ctx = LocalContext.current.applicationContext
    Configuration.getInstance()
        .load(ctx, ctx.getSharedPreferences("osmdroid", Context.MODE_PRIVATE))
    Configuration.getInstance()
        .load(context, PreferenceManager.getDefaultSharedPreferences(context))

    val mapView = remember { createMapView(context) }
    val currentMarker = remember(mapView) { createCurrentLocationMarker(mapView, context) }
    LaunchedEffect(Unit) {
        mapView.overlays.add(currentMarker)
        mapView.overlays.add(trackPolyline)
    }

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
            mapView,
            currentMarker,
            trackPolyline,
            isTracking,
            autoTrackpointEnabled,
            savedTrackpoints,
            context,
            ::canSaveTrackpoint,
            textLat,
            textLon,
            currentAltitude,
            trackpointIdCounter
        )
    }

    val locationManager = remember {
        LocationManager(fusedLocationClient, locationRequest, locationCallback, isTracking)
    }

    LaunchedEffect(isTracking.value) {
        if (isTracking.value) locationManager.start(context)
        else locationManager.stop()
    }

    DisposableEffect(lifecycleOwner) {
        val observer = LifecycleEventObserver { _, event ->
            if (event == Lifecycle.Event.ON_DESTROY) locationManager.stop()
        }
        lifecycleOwner.lifecycle.addObserver(observer)
        onDispose { lifecycleOwner.lifecycle.removeObserver(observer) }
    }

    // UI
    Box(modifier = Modifier.fillMaxSize()) {
        AndroidView(
            factory = { mapView }, modifier = Modifier
                .fillMaxWidth()
                .height(300.dp)
        )
        BackButton(navController)

        Column(modifier = Modifier.fillMaxSize()) {
            Spacer(modifier = Modifier.weight(1f))
            LocationControls(
                textLat = textLat,
                textLon = textLon,
                trackPolyline = trackPolyline,
                isTracking = isTracking,
                autoTrackpointEnabled = autoTrackpointEnabled,
                savedTrackpoints = savedTrackpoints,
                savedPuntosInteres = savedPuntosInteres,
                savedPuntosPeligro = savedPuntosPeligro,
                mapView = mapView,
                locationManager = locationManager,
                context = context,
                canSaveTrackpoint = ::canSaveTrackpoint,
                currentAltitude = currentAltitude,
                trackpointIdCounter = trackpointIdCounter,
                dbViewModel = dbViewModel,
                navController = navController,
                usuarioId = -1
            )
        }
    }
}

fun generarRuta(
    nombre: String,
    descripcion: String? = null,
    trackpoints: List<Trackpoint>,
    puntosInteres: List<PuntoInteres>,
    puntosPeligro: List<PuntoPeligro>,
    usuarioId: Int
): Ruta {
    require(trackpoints.isNotEmpty()) { "No hay trackpoints para generar la ruta" }

    val trackpointsList = trackpoints.toList()
    val puntosInteresList = puntosInteres.toList()
    val puntosPeligroList = puntosPeligro.toList()

    val latInicial = trackpointsList.first().latitud
    val lonInicial = trackpointsList.first().longitud
    val latFinal = trackpointsList.last().latitud
    val lonFinal = trackpointsList.last().longitud

    val altitudes = trackpointsList.mapNotNull { it.elevacion }
    val altMax = altitudes.maxOrNull() ?: 0.0
    val altMin = altitudes.minOrNull() ?: 0.0

    val distanciaTotal = if (trackpointsList.size > 1) {
        trackpointsList.zipWithNext { a, b ->
            GeoPoint(a.latitud, a.longitud).distanceToAsDouble(GeoPoint(b.latitud, b.longitud))
        }.sum()
    } else 0.0

    val tiempoInicio = trackpointsList.first().time
    val tiempoFinal = trackpointsList.last().time
    val duracionSegundos = maxOf(0, ((tiempoFinal - tiempoInicio) / 1000).toInt())
    val duracionStr = "%02d:%02d:%02d".format(
        duracionSegundos / 3600,
        (duracionSegundos % 3600) / 60,
        duracionSegundos % 60
    )

    val desnivelPositivo = altitudes.zipWithNext { a, b -> (b - a).coerceAtLeast(0.0) }.sum()
    val desnivelNegativo = altitudes.zipWithNext { a, b -> (a - b).coerceAtLeast(0.0) }.sum()

    // Crear ruta inicial sin GPX
    val ruta = Ruta(
        id = null,
        nombre = nombre,
        nombreInicioruta = "Inicio",
        nombreFinalruta = "Fin",
        latitudInicial = latInicial,
        latitudFinal = latFinal,
        longitudInicial = lonInicial,
        longitudFinal = lonFinal,
        distancia = distanciaTotal,
        duracion = duracionStr,
        desnivelPositivo = desnivelPositivo.toInt(),
        desnivelNegativo = desnivelNegativo.toInt(),
        altitudMax = altMax,
        altitudMin = altMin,
        clasificacion = null,
        nivelEsfuerzo = null,
        nivelRiesgo = null,
        estadoRuta = null,
        tipoTerreno = null,
        indicaciones = null,
        temporadas = null,
        accesibilidad = null,
        rutaFamiliar = null,
        archivoGPX = null,
        recomendacionesEquipo = descripcion,
        zonaGeografica = null,
        mediaEstrellas = null,
        usuarioId = usuarioId
    )

    // Generar GPX usando la ruta creada
    val gpx = runCatching {
        generateGpx(ruta, trackpointsList, puntosInteres, puntosPeligro)
    }.getOrElse {
        Log.e("GPX", "Error generando GPX", it)
        ""
    }

    // Retornar una copia de la ruta con GPX
    return ruta.copy(archivoGPX = gpx)
}


fun createLocationCallback(
    mapView: MapView,
    marker: Marker,
    trackPolyline: Polyline,
    isTracking: MutableState<Boolean>,
    autoTrackpointEnabled: MutableState<Boolean>,
    savedTrackpoints: MutableList<Trackpoint>,
    context: Context,
    canSaveTrackpoint: (Location) -> Boolean,
    textLat: MutableState<String>,
    textLon: MutableState<String>,
    currentAltitude: MutableState<Double>,
    trackpointIdCounter: MutableState<Int>
): LocationCallback {

    var lastLat: Double? = null
    var lastLon: Double? = null
    var lastAlt: Double? = null // Guarda última altitud conocida
    val smoothFactor = 0.2

    return object : LocationCallback() {
        override fun onLocationResult(locationResult: LocationResult) {
            if (!isTracking.value) return
            val location = locationResult.lastLocation ?: return
            if (location.accuracy > 20f) return
            Log.d(
                "ALTITUD_DEBUG",
                "hasAltitude=${location.hasAltitude()} alt=${location.altitude}"
            )

            var lat = location.latitude
            var lon = location.longitude

            // Altitud segura: si GPS tiene altitud válida, la usamos, si no usamos la última conocida o 0
            val alt = if (location.hasAltitude()) {
                location.altitude
            } else {
                lastAlt ?: 0.0
            }

            lastAlt = alt
            currentAltitude.value = alt

            Log.d(
                "ALT_FINAL",
                "location.alt=${location.altitude} | alt_guardada=$alt"
            )

            // Suavizado de lat/lon
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

            // Actualizar marcador y mapa
            val geoPoint = GeoPoint(lat, lon, alt)
            marker.position = geoPoint
            mapView.controller.setCenter(geoPoint)
            mapView.invalidate()

            textLat.value = "Latitud: $lat"
            textLon.value = "Longitud: $lon"

            // Guardar Trackpoint automáticamente si está activado
            if (autoTrackpointEnabled.value && canSaveTrackpoint(location)) {
                val trackpoint = Trackpoint(
                    idRuta = -1,
                    latitud = lat,
                    longitud = lon,
                    elevacion = alt, // Altitud suavizada y segura
                    time = System.currentTimeMillis(),
                    posicion = savedTrackpoints.size + 1
                )
                savedTrackpoints.add(trackpoint)
                Log.d("TRACKPOINT", "Guardado: ${trackpoint.elevacion}")
                trackPolyline.addPoint(GeoPoint(lat, lon, alt))
                val wpMarker =
                    createTrackpointMarker(mapView, context, "TRKPT ${savedTrackpoints.size}")
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
    trackPolyline: Polyline,
    isTracking: MutableState<Boolean>,
    autoTrackpointEnabled: MutableState<Boolean>,
    savedTrackpoints: SnapshotStateList<Trackpoint>,
    savedPuntosInteres: SnapshotStateList<PuntoInteres>,
    savedPuntosPeligro: SnapshotStateList<PuntoPeligro>,
    mapView: MapView,
    locationManager: LocationManager,
    context: Context,
    canSaveTrackpoint: (Location) -> Boolean,
    currentAltitude: MutableState<Double>,
    trackpointIdCounter: MutableState<Int>,
    dbViewModel: DBViewModel,
    navController: NavHostController,
    usuarioId: Int
) {
    var waypointDialog by remember { mutableStateOf<WaypointDialogData?>(null) }
    val pendingGpx = remember { mutableStateOf<String?>(null) }

    val finishRouteDialog = remember { mutableStateOf(false) }
    val rutaNombreState = remember { mutableStateOf("") }
    val rutaDescripcionState = remember { mutableStateOf("") }

    val context = LocalContext.current

    val createFileLauncher = rememberLauncherForActivityResult(
        ActivityResultContracts.CreateDocument("application/gpx+xml")
    ) { uri ->
        if (uri != null) {
            try {
                // Genera GPX otra vez por si hubo cambios de última hora
                val ruta = generarRuta(
                    nombre = rutaNombreState.value.ifBlank { "mis_puntos" },
                    trackpoints = savedTrackpoints.toList(),
                    usuarioId = usuarioId,
                    descripcion = rutaDescripcionState.value.ifBlank { "Sin_descripcion" },
                    puntosInteres = savedPuntosInteres,
                    puntosPeligro = savedPuntosPeligro
                )

                context.contentResolver.openOutputStream(uri)?.use { output ->
                    output.write((ruta.archivoGPX ?: "").toByteArray())
                }

                Log.d("GPX", "GPX guardado correctamente")

                // limpiar lista y campos si quieres
                savedTrackpoints.clear()
                savedPuntosInteres.clear()
                savedPuntosPeligro.clear()
                rutaNombreState.value = ""
                rutaDescripcionState.value = ""

            } catch (e: Exception) {
                Log.e("GPX", "Error guardando GPX", e)
            }
        }
    }

    Column(
        modifier = Modifier
            .fillMaxWidth()
            .background(Color.White)
            .padding(16.dp)
    ) {


        Spacer(Modifier.height(16.dp))

        // --- Resto de controles: Tracking, Añadir Trackpoint y Waypoints ---
        Row(
            modifier = Modifier.fillMaxWidth(),
            verticalAlignment = Alignment.CenterVertically
        ) {
            Button(
                onClick = {
                    if (isTracking.value) {
                        // Se estaba trackeando → lo detenemos y abrimos el diálogo
                        isTracking.value = false
                        finishRouteDialog.value = true
                    } else {
                        // Iniciar tracking
                        isTracking.value = true
                    }
                },
                colors = ButtonDefaults.buttonColors(
                    containerColor = if (isTracking.value) Color(0xFFFF6F61) else Color(0xFF4CAF50),
                    contentColor = Color.White
                )
            ) { Text(if (isTracking.value) "Detener Tracking" else "Iniciar Tracking") }

            Spacer(Modifier.weight(1f))

            Button(
                onClick = {
                    val lat =
                        textLat.value.removePrefix("Latitud: ").toDoubleOrNull() ?: return@Button
                    val lon =
                        textLon.value.removePrefix("Longitud: ").toDoubleOrNull() ?: return@Button
                    val alt = currentAltitude.value
                    savedTrackpoints.add(
                        Trackpoint(
                            idRuta = -1,
                            latitud = lat,
                            longitud = lon,
                            elevacion = alt,
                            time = System.currentTimeMillis(),
                            posicion = savedTrackpoints.size + 1
                        )
                    )
                    val marker =
                        createTrackpointMarker(mapView, context, "WP ${savedTrackpoints.size}")
                    marker.position = GeoPoint(lat, lon, alt)
                    mapView.overlays.add(marker)
                    trackPolyline.addPoint(GeoPoint(lat, lon, alt))
                    mapView.invalidate()
                },
                enabled = isTracking.value && !autoTrackpointEnabled.value,
                colors = ButtonDefaults.buttonColors(
                    containerColor = Color(0xFF2196F3),
                    contentColor = Color.White
                ),
                shape = RoundedCornerShape(12.dp),
                modifier = Modifier.height(48.dp)
            ) {
                Icon(
                    Icons.Default.AddCircle,
                    contentDescription = "Añadir Punto",
                    modifier = Modifier.size(24.dp)
                )
                Spacer(modifier = Modifier.width(8.dp))
                Text("Añadir Punto")
            }
        }

        Spacer(Modifier.height(16.dp))

        Row(verticalAlignment = Alignment.CenterVertically) {
            Checkbox(
                checked = autoTrackpointEnabled.value,
                onCheckedChange = { autoTrackpointEnabled.value = it },
                colors = CheckboxDefaults.colors(
                    checkedColor = Color(0xFF4CAF50),
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
                    val lat =
                        textLat.value.removePrefix("Latitud: ").toDoubleOrNull() ?: return@Button
                    val lon =
                        textLon.value.removePrefix("Longitud: ").toDoubleOrNull() ?: return@Button
                    // Abrir diálogo para PuntoInteres
                    waypointDialog = WaypointDialogData(
                        lat, lon, type = WaypointType.INTERES,
                        elevation = currentAltitude.value
                    )
                },
                enabled = isTracking.value
            ) { Text("Punto Interés") }

            Spacer(Modifier.width(16.dp))

            Button(
                colors = ButtonDefaults.buttonColors(
                    containerColor = Color(0xFFFFA726),
                    contentColor = Color.White
                ),
                onClick = {
                    val lat =
                        textLat.value.removePrefix("Latitud: ").toDoubleOrNull() ?: return@Button
                    val lon =
                        textLon.value.removePrefix("Longitud: ").toDoubleOrNull() ?: return@Button
                    // Abrir diálogo para PuntoPeligro
                    waypointDialog = WaypointDialogData(
                        lat,
                        lon,
                        currentAltitude.value,
                        type = WaypointType.PELIGRO
                    )
                },
                enabled = isTracking.value
            ) { Text("Punto Peligro") }
        }

        Spacer(Modifier.height(16.dp))

        // --- Diálogo Waypoint ---
        waypointDialog?.let { dialogData ->
            WaypointDialog(
                dialogData = dialogData,
                onDismiss = { waypointDialog = null },
                onSave = { punto ->
                    when (punto) {
                        is PuntoInteres -> {
                            savedPuntosInteres.add(punto)
                            val marker = createTrackpointMarker(mapView, context, punto.nombre)
                            marker.position = GeoPoint(punto.latitud, punto.longitud)
                            mapView.overlays.add(marker)
                        }

                        is PuntoPeligro -> {
                            savedPuntosPeligro.add(punto)
                            val marker = createTrackpointMarker(mapView, context, punto.nombre)
                            marker.position = GeoPoint(punto.latitud, punto.longitud)
                            mapView.overlays.add(marker)
                        }
                    }
                    mapView.invalidate()
                    waypointDialog = null
                }
            )
        }


        // --- Diálogo Finalizar Ruta ---
        FinishRouteDialog(
            showDialog = finishRouteDialog,        // Pasamos el MutableState real
            rutaNombre = rutaNombreState,          // Pasamos el MutableState real
            rutaDescripcion = rutaDescripcionState,// Pasamos el MutableState real
            savedTrackpoints = savedTrackpoints,
            usuarioId = usuarioId,              // usa el MutableState para GPX
            createFileLauncher = createFileLauncher,
            onRouteSaved = {
                // ✅ Generar ruta y GPX antes de lanzar el launcher
                val nuevaRuta = generarRuta(
                    nombre = rutaNombreState.value,
                    descripcion = rutaDescripcionState.value,
                    trackpoints = savedTrackpoints.toList(),
                    waypoints = savedWaypoints.toList(),
                    usuarioId = usuarioId
                ).copy(recomendacionesEquipo = rutaDescripcionState.value)

                // Guardamos el GPX en el MutableState
                pendingGpx.value = nuevaRuta.archivoGPX
                val finishedGpx: String = pendingGpx.value.toString()
                dbViewModel.uploadGpx(nuevaRuta, finishedGpx)

//                // Lanzamos el launcher para guardar el archivo
//                createFileLauncher.launch("${nuevaRuta.nombre}.gpx")


                finishRouteDialog.value = false
                // opcional: aquí puedes limpiar otros estados si quieres
            },
            currentGPX = pendingGpx,
            savedPuntosInteres = savedPuntosInteres,
            savedPuntosPeligro = savedPuntosPeligro
        )
    }
    val rutaState = dbViewModel.ruta.collectAsState()
    LaunchedEffect(rutaState.value) {

        val idBorrador = dbViewModel.ruta.value?.id
        if (idBorrador != null)
            navController.navigate("borrador/$idBorrador")
    }
}
