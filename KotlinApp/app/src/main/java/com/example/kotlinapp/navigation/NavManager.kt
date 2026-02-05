package com.example.kotlinapp.navigation

import androidx.compose.runtime.Composable
import androidx.navigation.compose.NavHost
import androidx.navigation.compose.composable
import androidx.navigation.compose.rememberNavController
import com.example.kotlinapp.gps.permissions.RequestPermission
import com.example.kotlinapp.views.CreateRutaView
import com.example.kotlinapp.views.ListView
import android.Manifest
import androidx.navigation.NavType
import androidx.navigation.navArgument
import com.example.kotlinapp.viewmodels.DatabaseViewModel
import com.example.kotlinapp.viewmodels.RutaViewModel
import com.example.kotlinapp.views.DetailView
import com.example.kotlinapp.views.LoginView
import com.example.kotlinapp.views.cargarRutasDummy


@Composable
fun NavManager(dbViewModel: DatabaseViewModel, viewModel: RutaViewModel) {
    val navController = rememberNavController()
    val rutas = cargarRutasDummy()
    NavHost(
        navController = navController,
        startDestination = "Login"
    ) {
        composable("Login") {
            LoginView(navController, dbViewModel)
        }
        composable("Home") {
            //HomeView(navController)
        }
        composable("List") {
            ListView(
                navController,
                viewModel = viewModel
            )
        }

        composable(route = "detail/{id}", arguments = listOf(navArgument("id") { type = NavType.IntType })
        ) { backStackEntry ->
            val id = backStackEntry.arguments?.getInt("id")
            DetailView(navController,rutas,id)
        }

        composable("Create"){
            RequestPermission(Manifest.permission.ACCESS_FINE_LOCATION, "Permiso de ubicación requerido") {
                CreateRutaView(navController)
            }

        }
    }
}