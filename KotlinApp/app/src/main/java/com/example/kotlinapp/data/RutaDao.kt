package com.example.kotlinapp.data

import androidx.room.Dao
import androidx.room.Insert
import androidx.room.OnConflictStrategy
import androidx.room.Query

@Dao
interface RutaDao {

    //@Query("SELECT * FROM Ruta")
    //suspend fun obtenerRutas(): List<Ruta>

    //@Query("SELECT * FROM Ruta WHERE idRuta = :id")
    //suspend fun obtenerRutaPorId(id: Int): Ruta?

    //@Insert(onConflict = OnConflictStrategy.REPLACE)
    //suspend fun insertarRutas(rutas: List<Ruta>)

    //@Insert
    //suspend fun insertarRuta(ruta: Ruta): Long
}