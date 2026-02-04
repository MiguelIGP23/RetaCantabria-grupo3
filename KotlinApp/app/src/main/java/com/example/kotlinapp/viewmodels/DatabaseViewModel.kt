package com.example.kotlinapp.viewmodels


import android.util.Log
import androidx.compose.runtime.mutableStateOf
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import com.example.kotlinapp.data.AuthRepository
import com.example.kotlinapp.data.RutaDao
import com.example.kotlinapp.data.RutaService
import com.example.kotlinapp.data.ServiceFactory
import com.example.kotlinapp.model.Ruta
import com.example.kotlinapp.repository.RutaRepository
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch
import kotlinx.coroutines.withContext


class DatabaseViewModel(private val authRepository: AuthRepository, private val rutaDao: RutaDao) : ViewModel() {

    val token = authRepository.token
    val rol = authRepository.rol

    val rutas = mutableStateOf<List<Ruta>>(emptyList())

    // Repositorio inicializado con Retrofit + token dinámico
    private val rutaService by lazy { ServiceFactory.ruta { token.toString() } }

    private val repo by lazy { RutaRepository(rutaDao, rutaService) }

    fun login(email: String, password: String): Boolean {
        viewModelScope.launch {
            authRepository.login(email, password)
        }
        return true // Placeholder
    }

    fun cargarRutas() {
        viewModelScope.launch(Dispatchers.IO) {
            try {
                // 1️⃣ Traer de API
                val remotas = repo.obtenerCatalogoRemoto()

                // 2️⃣ Guardar en Room
                repo.insertarCatalogoLocal(remotas)

                // 3️⃣ Traer de Room
                val locales = repo.obtenerCatalogoLocal()

                // 4️⃣ Actualizar UI
                withContext(Dispatchers.Main) {
                    rutas.value = locales
                }

            } catch (e: Exception) {
                Log.e("DB", "Error cargando rutas", e)
            }
        }
    }
}