package com.example.kotlinapp.navigation

import android.os.Build
import androidx.annotation.RequiresApi
import androidx.compose.runtime.Composable
import androidx.navigation.compose.NavHost
import androidx.navigation.compose.composable
import androidx.navigation.compose.rememberNavController
import com.example.kotlinapp.gps.permissions.RequestPermission
import com.example.kotlinapp.views.CreateRutaView
import com.example.kotlinapp.views.ListView
import android.Manifest


@Composable
fun NavManager() {
    val navController = rememberNavController()

    NavHost(
        navController = navController,
        startDestination = "List"
    ) {
        composable("Login") {
            //LoginView(navController)
        }
        composable("Home") {
            //HomeView(navController)
        }
        composable("List") {
            ListView(navController)
        }
        composable("Create"){
            RequestPermission(Manifest.permission.ACCESS_FINE_LOCATION, "Permiso de ubicación requerido") {
                CreateRutaView(navController)
            }

        }
    }
}