package com.example.kotlinapp.repository

import com.example.kotlinapp.data.PuntosInteresDao


class PuntosInteresRepository(private val puntosDao: PuntosInteresDao) {

    // --- Puntos del catálogo ---
    // suspend fun obtenerPuntosDeRuta(rutaId: Int): List<PuntosInteres> {
    // return puntosDao.obtenerPuntosDeRuta(rutaId)
    // }

    // --- Waypoints grabados ---
    // suspend fun insertarPunto(punto: PuntosInteres): Long {
    // return puntosDao.insertarPunto(punto)
    // }

    // suspend fun insertarPuntos(puntos: List<PuntosInteres>) {
    // puntosDao.insertarPuntos(puntos)
    // }

    // --- Sincronización ---
    // suspend fun obtenerPuntosPendientes(): List<PuntosInteres> {
    // return puntosDao.obtenerPuntosPendientes()
    // }

    // suspend fun marcarComoSincronizado(id: Int) {
    // puntosDao.marcarComoSincronizado(id)
    // }
}