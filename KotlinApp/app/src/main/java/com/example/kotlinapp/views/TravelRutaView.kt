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
import android.os.Looper
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.filled.ArrowBack
import androidx.compose.ui.unit.dp
import androidx.core.content.ContextCompat
import com.example.kotlinapp.gps.gpx.parseGpxTrackpointsSafe
import com.example.kotlinapp.gps.gpx.parseGpxWaypointsToPuntos
import com.example.kotlinapp.gps.map.createTrackpointMarker
import com.example.kotlinapp.model.PuntoInteres
import com.example.kotlinapp.model.PuntoPeligro
import com.example.kotlinapp.model.enums.MarkerType

@Composable
fun TravelRutaView(navController: NavHostController, ruta: Ruta) {
    val context = LocalContext.current
    val fusedLocationClient = LocationServices.getFusedLocationProviderClient(context)

    val currentPosition = remember { mutableStateOf<GeoPoint?>(null) }

    // MapView y marcador del usuario
    val mapView = remember { createMapView(context) }
    val currentMarker = remember { createCurrentLocationMarker(mapView, context) }

    LaunchedEffect(Unit) {
        mapView.overlays.add(currentMarker)
    }

    // Cargar trackpoints GPX
    // Cargar trackpoints GPX y dibujar ruta
    LaunchedEffect(ruta.archivoGPX) {
        ruta.archivoGPX?.let { gpx ->
            val trackpoints = parseGpxTrackpointsSafe(gpx)

            // Polyline de la ruta
            if (trackpoints.isNotEmpty()) {
                val polyline = org.osmdroid.views.overlay.Polyline().apply {
                    setPoints(trackpoints)
                    outlinePaint.color = android.graphics.Color.BLUE
                    outlinePaint.strokeWidth = 5f
                }
                mapView.overlays.add(polyline)
                mapView.controller.setCenter(trackpoints.first())
            }

            // Marcadores solo de INTERES/PELIGRO usando metodo del Gpx.kt
            val puntos = parseGpxWaypointsToPuntos(gpx)
            puntos.forEach { punto ->
                val tipo = when (punto) {
                    is PuntoInteres -> MarkerType.INTERES
                    is PuntoPeligro -> MarkerType.PELIGRO
                    else -> MarkerType.TRACKPOINT
                }

                val marker = createTrackpointMarker(
                    mapView,
                    context,
                    when (punto) {
                        is PuntoInteres -> "Interés: ${punto.nombre}"
                        is PuntoPeligro -> "Peligro: ${punto.nombre}"
                        else -> ""
                    },
                    tipo
                )
                val geo = when (punto) {
                    is PuntoInteres -> GeoPoint(punto.latitud, punto.longitud, punto.elevacion ?: 0.0)
                    is PuntoPeligro -> GeoPoint(punto.latitud, punto.longitud, punto.elevacion ?: 0.0)
                    else -> null
                }
                geo?.let { marker.position = it }
                mapView.overlays.add(marker)
            }

            mapView.invalidate()
        }
    }




    val locationRequest = remember {
        LocationRequest.Builder(Priority.PRIORITY_HIGH_ACCURACY, 1000L)
            .setMinUpdateDistanceMeters(0f)
            .build()
    }

    val locationCallback = remember {
        object : LocationCallback() {
            override fun onLocationResult(result: LocationResult) {
                val loc = result.lastLocation ?: return
                if (loc.accuracy > 30f) return

                val point = GeoPoint(loc.latitude, loc.longitude, loc.altitude)
                currentPosition.value = point

                currentMarker.position = point
                mapView.controller.setCenter(point)
                mapView.invalidate()
            }
        }
    }

    // Iniciar tracking automáticamente y parar al salir
    DisposableEffect(Unit) {
        val hasPermission = ContextCompat.checkSelfPermission(
            context,
            android.Manifest.permission.ACCESS_FINE_LOCATION
        ) == PackageManager.PERMISSION_GRANTED

        if (hasPermission) {
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

        // Botón volver
        IconButton(
            onClick = { navController.popBackStack() },
            modifier = Modifier.align(Alignment.TopStart).padding(16.dp)
        ) {
            Icon(Icons.Filled.ArrowBack, contentDescription = "Volver", tint = Color.Black)
        }

        // Mostrar posición actual
        currentPosition.value?.let { pos ->
            Text(
                "Latitud: ${pos.latitude}, Longitud: ${pos.longitude}",
                color = Color.Black,
                modifier = Modifier.align(Alignment.BottomCenter).padding(16.dp)
            )
        }
    }
}
