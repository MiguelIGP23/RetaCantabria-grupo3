package com.example.kotlinapp.repository

import com.example.kotlinapp.data.RutaDao

class RutaRepository(private val rutaDao: RutaDao) {

    // --- Catálogo ---
    //suspend fun obtenerCatalogo(): List<Ruta> {
    // return rutaDao.obtenerCatalogo()
    // }

    // suspend fun insertarCatalogo(rutas: List<Ruta>) {
    // rutaDao.insertarCatalogo(rutas)
    // }

    // --- Seguimiento ---
    // suspend fun obtenerRuta(id: Int): Ruta? {
    // return rutaDao.obtenerRuta(id)
    // }

    // --- Grabación de rutas (modo tracking) ---
    // suspend fun insertarRutaGrabada(ruta: Ruta): Long {
    // return rutaDao.insertarRutaGrabada(ruta)
    // }

    // --- Sincronización ---
    // suspend fun obtenerRutasPendientes(): List<Ruta> {
    // return rutaDao.obtenerRutasPendientes()
    // }

    // suspend fun marcarComoSincronizada(id: Int) {
    // rutaDao.marcarComoSincronizada(id)
    // }
}