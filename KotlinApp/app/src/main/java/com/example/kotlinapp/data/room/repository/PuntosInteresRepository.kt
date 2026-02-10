package com.example.kotlinapp.data.room.repository

import android.util.Log
import com.example.kotlinapp.data.room.daos.PuntosInteresDao
import com.example.kotlinapp.data.room.entity.PuntoInteresEntity
import com.example.kotlinapp.data.room.mappers.toDomain
import com.example.kotlinapp.data.room.mappers.toEntity
import com.example.kotlinapp.data.services.PuntoInteresService
import com.example.kotlinapp.model.PuntoInteres
import kotlinx.coroutines.flow.Flow
import kotlinx.coroutines.flow.map

class PuntosInteresRepository(
    private val api: PuntoInteresService,
    private val dao: PuntosInteresDao
) {
    fun getPuntosInteres(): Flow<List<PuntoInteres>> = dao.getAll()
        .map { list -> list.map { it.toDomain() } }

    suspend fun insertPuntoInteres(punto: PuntoInteres) {
        dao.insert(punto.toEntity())
    }

    suspend fun syncPuntosInteres(idRuta: Int) {
        val response = api.findAll(idRuta)
        Log.d("PUNTOSINTERES", "code=${response.code()} body=${response.body()}")
        if (response.isSuccessful) {
            response.body()?.let { puntos ->
                dao.insertAll(puntos.map { it.toEntity() })
            }
        }
    }
}
