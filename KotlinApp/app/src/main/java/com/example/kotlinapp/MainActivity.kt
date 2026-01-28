package com.example.kotlinapp

import android.content.pm.PackageManager
import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.rememberLauncherForActivityResult
import androidx.activity.compose.setContent
import androidx.activity.enableEdgeToEdge
import androidx.activity.result.contract.ActivityResultContracts
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.padding
import androidx.compose.material3.Scaffold
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.runtime.LaunchedEffect
import androidx.compose.ui.Modifier
import androidx.compose.ui.platform.LocalContext
import androidx.core.content.ContextCompat
import android.Manifest
import android.R.attr.title
import android.content.Context.MODE_PRIVATE
import android.os.Looper
import android.util.Log
import androidx.compose.foundation.gestures.snapping.SnapPosition.Center.position
import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Spacer
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.height
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.material3.Button
import androidx.compose.runtime.DisposableEffect
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateListOf
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.runtime.setValue
import androidx.compose.ui.Alignment
import androidx.compose.ui.platform.LocalLifecycleOwner
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import androidx.compose.ui.viewinterop.AndroidView
import androidx.lifecycle.Lifecycle
import androidx.lifecycle.LifecycleEventObserver
import com.google.android.gms.location.LocationCallback
import com.google.android.gms.location.LocationRequest
import com.google.android.gms.location.LocationResult
import com.google.android.gms.location.LocationServices
import com.google.android.gms.location.Priority
import org.osmdroid.config.Configuration
import org.osmdroid.tileprovider.tilesource.TileSourceFactory
import org.osmdroid.util.GeoPoint
import org.osmdroid.views.MapView
import org.osmdroid.views.overlay.Marker


class MainActivity : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContent {

            MainScreen()
        }
    }
}
@Composable
fun MainScreen() {
    RequestLocationPermission {
        LocationScreen()
    }
}

@Composable
fun LocationScreen() {
    val context = LocalContext.current
    //cliente que se usa para acceder a la ubicación del dispositivo
    val fusedLocationClient = remember {
        LocationServices.getFusedLocationProviderClient(context) }
    //estado que obtiene el ciclo de vida de la Activity
    // que lanzo el composable (mainactivity)
    val lifecycleOwner = LocalLifecycleOwner.current
    val textLatitud = remember { mutableStateOf("Latitud: --") }
    val textLongitud = remember { mutableStateOf("Longitud: --") }
    // Estado para saber si está obteniendo la ubicación
    val isTracking = remember { mutableStateOf(false) }

    val ctx = LocalContext.current.applicationContext
    Configuration.getInstance().load(
        ctx,
        ctx.getSharedPreferences("osmdroid", MODE_PRIVATE)
    )


    val savedLocations = remember { mutableStateListOf<Pair<Double, Double>>() }

    Configuration.getInstance().load(context, androidx.preference.PreferenceManager.getDefaultSharedPreferences(context))

    val mapView = remember { MapView(context).apply {
        setTileSource(TileSourceFactory.MAPNIK)
        setMultiTouchControls(true)
        controller.setZoom(15.0)
    } }

    val locationRequest = remember {
        // Cada 1 segundos
        LocationRequest.Builder(Priority.PRIORITY_HIGH_ACCURACY, 100)
            .build()
    }
    //objeto que recibirá las actualizaciones de ubicación
    val locationCallback = remember {
        //El objeto implementa el interface LocationCallback
        object : LocationCallback() {
            // Cuando se recibe una actualización de ubicación se hace esto
            override fun onLocationResult(locationResult: LocationResult) {
                // si se recibió una actualización se actualiza la latitud y la longitud
                locationResult.lastLocation?.let { location ->
                    Log.d("Location", "Latitud: ${location.latitude}, Longitud: ${location.longitude}")
                    textLatitud.value = "Latitud: ${location.latitude}"
                    textLongitud.value = "Longitud: ${location.longitude}"
                }
            }
        }
    }
    //Función para iniciar la actualización de ubicación
    fun startLocationUpdates() {
        Log.d("Location", "Iniciando actualizaciones de ubicación")
        //Verificamos si el usuario ha dado permisos
        if (ContextCompat.checkSelfPermission(context, Manifest.permission.ACCESS_FINE_LOCATION) ==
            PackageManager.PERMISSION_GRANTED) {
            // Si ha dado permisos se inicia la actualización de ubicación
            //se pasa la solicitud y el callback
            //y se pasa el Looper para que se ejecute en el hilo principal
            fusedLocationClient.requestLocationUpdates(locationRequest,
                locationCallback,
                Looper.getMainLooper())
            //se cambia el estado a true (para que se use en el Button)
            isTracking.value = true
        }
    }
    //detiene la actualización de ubicación
    fun stopLocationUpdates() {
        fusedLocationClient.removeLocationUpdates(locationCallback)
    }
    //se ejecuta cuando el composable se crea y se destruye
    // cuando se sale de la pantalla
    DisposableEffect(lifecycleOwner) {
        //observador que escucha los cambios en el ciclo de vida del owner
        // (de la mainactivity)
        // _ es el LifecycleOwner (no lo usamos, lo ignoramos)
        val observer = LifecycleEventObserver { _, event ->
            when (event) {
                // Detener ubicación al salir de la app
                Lifecycle.Event.ON_DESTROY -> stopLocationUpdates()
                else -> {}
            }
        }
        //añadir el observador al ciclo de vida del owner
        lifecycleOwner.lifecycle.addObserver(observer)
        //cuando se sale de la pantalla se elimina el observador
        onDispose {
            lifecycleOwner.lifecycle.removeObserver(observer)
        }
    }
    Column(
        modifier = Modifier
            .fillMaxSize()
            .padding(16.dp),
        horizontalAlignment = Alignment.CenterHorizontally,
        verticalArrangement = Arrangement.Center
    ) {
        Text(text = textLatitud.value, fontSize = 20.sp, fontWeight = FontWeight.Bold)
        Spacer(modifier = Modifier.height(8.dp))
        Text(text = textLongitud.value, fontSize = 20.sp, fontWeight = FontWeight.Bold)
        Spacer(modifier = Modifier.height(16.dp))
        Button(
            onClick = { startLocationUpdates() },
            enabled = !isTracking.value
        ) {
            Text("Iniciar")
        }

        Spacer(modifier = Modifier.height(16.dp))

        Button(
            onClick = {
                val lat = textLatitud.value.removePrefix("Latitud: ").toDoubleOrNull()
                val lon = textLongitud.value.removePrefix("Longitud: ").toDoubleOrNull()
                if (lat != null && lon != null) {
                    savedLocations.add(Pair(lat, lon))
                    val marker = Marker(mapView).apply {
                        position = GeoPoint(lat, lon)
                        title = "Ubicación ${savedLocations.size}"
                    }
                    mapView.overlays.add(marker)
                    mapView.invalidate()
                }

            },
            enabled = textLatitud.value != "Latitud: --"
        ) {
            Text("Guardar ubicación")
        }

        Spacer(modifier = Modifier.height(16.dp))

        AndroidView(
            factory = { mapView },
            modifier = Modifier
                .fillMaxWidth()
                .height(600.dp) // <-- altura fija evita que se superponga
        )

        Spacer(modifier = Modifier.height(16.dp))
        LazyColumn {
            items(savedLocations.size){
                index->val (lat, lon) = savedLocations[index]
                Text("${index + 1}. Lat: $lat, Lon: $lon", fontSize = 16.sp)
            }
        }
    }
}

@Composable
fun RequestLocationPermission(onGranted: @Composable () -> Unit) {
    val context = LocalContext.current
    var hasPermission by remember {
        mutableStateOf(
            ContextCompat.checkSelfPermission(
                context,
                Manifest.permission.ACCESS_FINE_LOCATION
            ) == PackageManager.PERMISSION_GRANTED
        )
    }

    val permissionLauncher = rememberLauncherForActivityResult(
        contract = ActivityResultContracts.RequestPermission()
    ) { isGranted ->
        hasPermission = isGranted
    }

    // Lanzar solicitud solo si no hay permiso
    LaunchedEffect(Unit) {
        if (!hasPermission) {
            permissionLauncher.launch(Manifest.permission.ACCESS_FINE_LOCATION)
        }
    }

    if (hasPermission) {
        onGranted()
    } else {
        // Opcional: mostrar mensaje mientras se espera el permiso
        Text("Permiso de ubicación requerido")
    }
}

