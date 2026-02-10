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
import com.example.kotlinapp.viewmodels.DBViewModel
import com.example.kotlinapp.views.DetailView
import com.example.kotlinapp.views.LoginView
import com.example.kotlinapp.views.TravelRutaView
import androidx.compose.runtime.collectAsState
import com.example.kotlinapp.views.BorradorView


@Composable
fun NavManager(dbViewModel: DBViewModel) {
    val navController = rememberNavController()
    val rutas = dbViewModel.rutas.collectAsState().value
    NavHost(
        navController = navController, startDestination = "List"
    ) {
        composable("Login") {
            LoginView(navController, dbViewModel)
        }
        composable("Home") {
            //HomeView(navController)
        }
        composable("List") {
            ListView(
                navController, dbViewModel
            )
        }

        composable(
            route = "detail/{id}", arguments = listOf(navArgument("id") { type = NavType.IntType })
        ) { backStackEntry ->
            val id = backStackEntry.arguments?.getInt("id")
            DetailView(navController, id, dbViewModel)
        }

        composable("Create") {
            RequestPermission(
                Manifest.permission.ACCESS_FINE_LOCATION, "Permiso de ubicación requerido"
            ) {
                CreateRutaView(navController, dbViewModel)
            }

        }

        composable("Travel/imported") {
            dbViewModel.rutaImportada.value?.let { ruta ->
                RequestPermission(
                    Manifest.permission.ACCESS_FINE_LOCATION, "Permiso de ubicación requerido"
                ) {
                    TravelRutaView(navController, ruta)
                }
            }
        }

        composable(
            route = "borrador/{id}", arguments = listOf(navArgument("id") { type = NavType.IntType })
        ) { backStackEntry ->
            val id = backStackEntry.arguments?.getInt("id")
            BorradorView(navController, id, dbViewModel)
        }

    }
}