package com.example.kotlinapp.repository

import com.example.kotlinapp.data.RutaDao
import com.example.kotlinapp.data.RutaService
import com.example.kotlinapp.model.Ruta
import retrofit2.Response

class RutaRepository(
    private val rutaDao: RutaDao,
    private val rutaService: RutaService
) {

    // =========================
    // --- Catálogo / Lectura ---
    // =========================

    // Traer rutas de Room
    suspend fun obtenerCatalogoLocal(): List<Ruta> {
        return rutaDao.obtenerCatalogo()
    }

    // Traer rutas de API
    suspend fun obtenerCatalogoRemoto(): List<Ruta> {
        val response: Response<List<Ruta>> = rutaService.findAll()
        if (response.isSuccessful) {
            return response.body() ?: emptyList()
        } else {
            return emptyList()
        }
    }

    // Guardar rutas en Room
    suspend fun insertarCatalogoLocal(rutas: List<Ruta>) {
        rutaDao.insertarCatalogo(rutas)
    }

    // Guardar rutas en API
    suspend fun insertarCatalogoRemoto(rutas: List<Ruta>) {
        rutas.forEach { ruta ->
            try {
                rutaService.insert(ruta)
            } catch (_: Exception) { }
        }
    }

    // =========================
    // --- Seguimiento / Grabación ---
    // =========================

    suspend fun obtenerRutaLocal(id: Int): Ruta? {
        return rutaDao.obtenerRuta(id)
    }

    suspend fun insertarRutaGrabadaLocal(ruta: Ruta): Long {
        return rutaDao.insertarRutaGrabada(ruta)
    }

    // =========================
    // --- Sincronización ---
    // =========================

    suspend fun obtenerRutasPendientesLocal(): List<Ruta> {
        return rutaDao.obtenerRutasPendientes()
    }

    suspend fun marcarComoSincronizadaLocal(id: Int) {
        rutaDao.marcarComoSincronizada(id)
    }

}
