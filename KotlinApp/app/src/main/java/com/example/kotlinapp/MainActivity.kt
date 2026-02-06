package com.example.kotlinapp

import android.os.Bundle
import android.util.Log
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.compose.foundation.layout.*
import androidx.compose.material3.*
import androidx.compose.runtime.*
import androidx.compose.ui.Modifier
import com.example.kotlinapp.data.AppDatabase
import com.example.kotlinapp.data.AuthRepository
import com.example.kotlinapp.data.ServiceFactory
import com.example.kotlinapp.data.SessionDataStore
import com.example.kotlinapp.data.room.repository.RutaRepository
import com.example.kotlinapp.navigation.NavManager
import com.example.kotlinapp.viewmodels.DatabaseViewModel
import com.example.kotlinapp.viewmodels.RutasViewModel
import kotlinx.coroutines.flow.firstOrNull
import kotlinx.coroutines.runBlocking

class MainActivity : ComponentActivity() {
    private lateinit var session : SessionDataStore
    private lateinit var dbViewModel: DatabaseViewModel
    private lateinit var rutaViewModel: RutasViewModel
    private lateinit var rutaRepo: RutaRepository

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        session = SessionDataStore(this)
        dbViewModel = DatabaseViewModel(
            AuthRepository(
                api = ServiceFactory.auth(),
                session = session
            )
        )
        // Instancia de la base de datos (Room)
        val database = AppDatabase.getDatabase(this) // tu singleton de Room
        val rutaDao = database.rutaDao()
        try {
            val db = AppDatabase.getDatabase(this)
            Log.d("TEST", "DB instance creada: $db")
        } catch (e: Exception) {
            Log.e("TEST", "Error creando la BD", e)
        }
        // Instancia del API
        val rutaService = ServiceFactory.ruta {
            runBlocking {
                session.tokenFlow.firstOrNull()
            }
        }
// Retrofit service

        // Repository
        rutaRepo = RutaRepository(rutaService, rutaDao)

        // ViewModel de rutas
        rutaViewModel = RutasViewModel(rutaRepo)
        setContent {
            Scaffold { padding ->
                MainScreen(modifier = Modifier.padding(padding),dbViewModel, rutaViewModel)
            }
        }
    }
}


@Composable
fun MainScreen(modifier: Modifier,databaseViewModel: DatabaseViewModel,ViewModel: RutasViewModel) {
    NavManager(
        databaseViewModel,
        viewModel = ViewModel
    )
}
