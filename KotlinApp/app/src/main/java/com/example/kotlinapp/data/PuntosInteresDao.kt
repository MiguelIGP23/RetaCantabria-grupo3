package com.example.kotlinapp.data

import androidx.room.Dao
import androidx.room.Insert
import androidx.room.Query

@Dao
interface PuntosInteresDao {

    // --- Puntos del catálogo ---
    // @Query("SELECT * FROM PuntosInteres WHERE rutaId = :rutaId")
    // suspend fun obtenerPuntosDeRuta(rutaId: Int): List<PuntosInteres>

    // --- Waypoints grabados ---
    // @Insert(onConflict = OnConflictStrategy.REPLACE)
    // suspend fun insertarPunto(punto: PuntosInteres): Long

    // @Insert(onConflict = OnConflictStrategy.REPLACE)
    // suspend fun insertarPuntos(puntos: List<PuntosInteres>)

    // --- Sincronización ---
    // @Query("SELECT * FROM PuntosInteres WHERE sincronizado = 0")
    // suspend fun obtenerPuntosPendientes(): List<PuntosInteres>

    // @Query("UPDATE PuntosInteres SET sincronizado = 1 WHERE idPuntosinteres = :id")
    // suspend fun marcarComoSincronizado(id: Int)
}