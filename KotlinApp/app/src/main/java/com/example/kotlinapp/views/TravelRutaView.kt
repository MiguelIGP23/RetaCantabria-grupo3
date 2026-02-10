package com.example.kotlinapp.views

import android.R.attr.id
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
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.ArrowBack
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.unit.dp
import androidx.core.content.ContextCompat
import com.example.kotlinapp.gps.gpx.parseGpxTrackpoints
import com.example.kotlinapp.gps.gpx.parseGpxTrackpointsSafe
import com.example.kotlinapp.gps.map.createTrackpointMarker
import org.xmlpull.v1.XmlPullParser
import org.xmlpull.v1.XmlPullParserFactory
import java.io.StringReader

@Composable
fun TravelRutaView(navController: NavHostController, ruta: Ruta) {
    val context = LocalContext.current
    val fusedLocationClient = LocationServices.getFusedLocationProviderClient(context)

    val isTracking = remember { mutableStateOf(true) }
    val currentPosition = remember { mutableStateOf<GeoPoint?>(null) }

    // MapView y marcador del usuario
    val mapView = remember { createMapView(context) }
    val currentMarker = remember { createCurrentLocationMarker(mapView, context) }

    LaunchedEffect(Unit) {
        mapView.overlays.add(currentMarker)
    }

    // Cargar trackpoints GPX (solo marcadores, sin líneas)
    LaunchedEffect(ruta.archivoGPX) {
        ruta.archivoGPX?.let { gpx ->
            val points = parseGpxTrackpointsSafe(gpx)
            points.forEachIndexed { index, point ->
                val marker = createTrackpointMarker(mapView, context, "TRKPT ${index + 1}")
                marker.position = point
                mapView.overlays.add(marker)
            }
            if (points.isNotEmpty()) mapView.controller.setCenter(points.first())
            mapView.invalidate()
        }
    }

    val locationRequest = remember {
        LocationRequest.Builder(Priority.PRIORITY_HIGH_ACCURACY, 1000L)
            .setMinUpdateDistanceMeters(0f) // sin filtrado de distancia
            .build()
    }

    val locationCallback = remember {
        object : LocationCallback() {
            override fun onLocationResult(result: LocationResult) {
                val loc = result.lastLocation ?: return
                if (!isTracking.value || loc.accuracy > 30f) return

                val point = GeoPoint(loc.latitude, loc.longitude, loc.altitude)
                currentPosition.value = point

                // Actualizar marcador y centrar mapa
                currentMarker.position = point
                mapView.controller.setCenter(point)
                mapView.invalidate()
            }
        }
    }

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

        onDispose { fusedLocationClient.removeLocationUpdates(locationCallback) }
    }

    // UI
    Box(Modifier.fillMaxSize()) {
        AndroidView(factory = { mapView }, modifier = Modifier.fillMaxSize())

        // Botón volver
        IconButton(
            onClick = { navController.popBackStack() },
            modifier = Modifier.align(Alignment.TopStart).padding(16.dp)
        ) {
            Icon(Icons.Filled.ArrowBack, contentDescription = "Volver", tint = Color.Black)
        }

        // Controles inferiores
        Column(
            modifier = Modifier.align(Alignment.BottomCenter).padding(16.dp)
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
