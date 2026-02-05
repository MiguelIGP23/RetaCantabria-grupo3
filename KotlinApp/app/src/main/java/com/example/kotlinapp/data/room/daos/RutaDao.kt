package com.example.kotlinapp.data.room.daos

import androidx.room.Dao

@Dao
interface RutaDao {

    // --- Catálogo ---
    // @Query("SELECT * FROM Ruta")
    // suspend fun obtenerCatalogo(): List<Ruta>

    // @Insert(onConflict = OnConflictStrategy.REPLACE)
    // suspend fun insertarCatalogo(rutas: List<Ruta>)

    // --- Seguimiento ---
    // @Query("SELECT * FROM Ruta WHERE idRuta = :id")
    // suspend fun obtenerRuta(id: Int): Ruta?

    // --- Grabación de rutas (modo tracking) ---
    // @Insert(onConflict = OnConflictStrategy.REPLACE)
    // suspend fun insertarRutaGrabada(ruta: Ruta): Long

    // --- Sincronización ---
    // @Query("SELECT * FROM Ruta WHERE sincronizada = 0")
    // suspend fun obtenerRutasPendientes(): List<Ruta>

    // @Query("UPDATE Ruta SET sincronizada = 1 WHERE idRuta = :id")
    // suspend fun marcarComoSincronizada(id: Int)
}