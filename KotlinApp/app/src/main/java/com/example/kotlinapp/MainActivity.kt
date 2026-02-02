package com.example.kotlinapp

import android.Manifest
import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.compose.foundation.layout.*
import androidx.compose.material3.*
import androidx.compose.runtime.*
import androidx.compose.ui.Modifier
import com.example.kotlinapp.gps.location.LocationScreen
import com.example.kotlinapp.gps.permissions.RequestPermission

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
