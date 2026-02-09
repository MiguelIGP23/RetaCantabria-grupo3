package com.example.kotlinapp.views

import android.content.pm.PackageManager
import androidx.compose.foundation.layout.*
import androidx.compose.material3.*
import androidx.compose.runtime.*
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.platform.LocalContext
import androidx.compose.ui.viewinterop.AndroidView
import androidx.navigation.NavHostController
import com.example.kotlinapp.gps.map.createCurrentLocationMarker
import com.example.kotlinapp.gps.map.createMapView
import com.example.kotlinapp.model.Ruta
import com.google.android.gms.location.*
import org.osmdroid.util.GeoPoint
import org.osmdroid.views.MapView
import org.osmdroid.views.overlay.Marker
import org.osmdroid.views.overlay.Polyline
import android.os.Looper
import androidx.compose.ui.unit.dp
import androidx.core.content.ContextCompat
import org.xmlpull.v1.XmlPullParser
import org.xmlpull.v1.XmlPullParserFactory
import java.io.StringReader

@Composable
fun TravelRutaView(navController: NavHostController, ruta: Ruta) {
    val context = LocalContext.current
    val fusedLocationClient = LocationServices.getFusedLocationProviderClient(context)

    // Estados de tracking y posición
    val isTracking = remember { mutableStateOf(false) }
    val currentPosition = remember { mutableStateOf<GeoPoint?>(null) }

    // MapView y overlays
    val mapView = remember { createMapView(context) }
    val currentMarker = remember { createCurrentLocationMarker(mapView, context) }
    val polyline = remember { Polyline().apply { color = android.graphics.Color.RED; width = 6f } }

    val trackpoints = remember { mutableStateListOf<GeoPoint>() }


    LaunchedEffect(Unit) {
        mapView.overlays.add(currentMarker)
        mapView.overlays.add(polyline)
    }

    LaunchedEffect(ruta.archivoGPX) {
        ruta.archivoGPX?.let { gpx ->
            val trackpoints = parseGpxTrackpoints(gpx)
            trackpoints.forEachIndexed { index, point ->
                val marker = Marker(mapView)
                marker.position = point
                marker.title = "TRKPT ${index + 1}"
                mapView.overlays.add(marker)
                polyline.addPoint(point)
            }
            if (trackpoints.isNotEmpty()) {
                mapView.controller.setCenter(trackpoints.first())
            }
            mapView.invalidate()
        }
    }



    // FusedLocationClient

    val locationRequest = remember {
        LocationRequest.Builder(Priority.PRIORITY_HIGH_ACCURACY, 1000L)
            .setMinUpdateDistanceMeters(1f)
            .build()
    }

    val locationCallback = remember {
        object : LocationCallback() {
            override fun onLocationResult(result: LocationResult) {
                if (!isTracking.value) return
                val loc = result.lastLocation ?: return
                if (loc.accuracy > 20f) return

                val point = GeoPoint(loc.latitude, loc.longitude, loc.altitude)
                currentPosition.value = point
                currentMarker.position = point

// Añadir al polyline
                polyline.addPoint(point)

// Añadir marcador visual del trackpoint
                trackpoints.add(point)
                val marker = Marker(mapView)
                marker.position = point
                marker.title = "TRKPT ${trackpoints.size}"
                mapView.overlays.add(marker)

                mapView.controller.setCenter(point)
                mapView.invalidate()

            }
        }
    }

    // Control de tracking
    DisposableEffect(isTracking.value) {
        val hasPermission = ContextCompat.checkSelfPermission(
            context,
            android.Manifest.permission.ACCESS_FINE_LOCATION
        ) == PackageManager.PERMISSION_GRANTED

        if (isTracking.value && hasPermission) {
            fusedLocationClient.requestLocationUpdates(
                locationRequest,
                locationCallback,
                Looper.getMainLooper()
            )
        }

        onDispose {
            fusedLocationClient.removeLocationUpdates(locationCallback)
        }
    }

    // UI
    Box(Modifier.fillMaxSize()) {
        AndroidView(factory = { mapView }, modifier = Modifier.fillMaxSize())

        Column(
            modifier = Modifier
                .align(Alignment.BottomCenter)
                .padding(16.dp)
        ) {
            Button(
                onClick = { isTracking.value = !isTracking.value },
                colors = ButtonDefaults.buttonColors(
                    containerColor = if (isTracking.value) Color.Red else Color.Green
                )
            ) {
                Text(if (isTracking.value) "Detener recorrido" else "Iniciar recorrido")
            }

            currentPosition.value?.let { pos ->
                Text("Latitud: ${pos.latitude}, Longitud: ${pos.longitude}", color = Color.Black)
            }
        }
    }
}

fun parseGpxTrackpoints(gpx: String): List<GeoPoint> {
    val points = mutableListOf<GeoPoint>()
    val factory = XmlPullParserFactory.newInstance()
    val parser = factory.newPullParser()
    parser.setInput(StringReader(gpx))

    var event = parser.eventType
    var lat: Double? = null
    var lon: Double? = null
    var ele: Double? = null

    while (event != XmlPullParser.END_DOCUMENT) {
        when (event) {
            XmlPullParser.START_TAG -> {
                when (parser.name) {
                    "trkpt" -> {
                        lat = parser.getAttributeValue(null, "lat")?.toDoubleOrNull()
                        lon = parser.getAttributeValue(null, "lon")?.toDoubleOrNull()
                    }
                    "ele" -> ele = parser.nextText().toDoubleOrNull()
                }
            }
            XmlPullParser.END_TAG -> {
                if (parser.name == "trkpt" && lat != null && lon != null) {
                    points.add(GeoPoint(lat, lon, ele ?: 0.0))
                    lat = null; lon = null; ele = null
                }
            }
        }
        event = parser.next()
    }
    return points
}