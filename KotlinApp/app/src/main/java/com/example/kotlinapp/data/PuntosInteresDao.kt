package com.example.kotlinapp.data

import androidx.room.Dao
import androidx.room.Insert
import androidx.room.Query

@Dao
interface PuntosInteresDao {

    //@Query("SELECT * FROM PuntoDeInteres WHERE rutaId = :rutaId")
    //suspend fun obtenerPuntosPorRuta(rutaId: Int): List<PuntoDeInteres>

    //@Insert(onConflict = OnConflictStrategy.REPLACE)
    //suspend fun insertarPunto(punto: PuntosInteres): Long

    //@Insert(onConflict = OnConflictStrategy.REPLACE)
    //suspend fun insertarPuntos(puntos: List<PuntoDeInteres>)
}