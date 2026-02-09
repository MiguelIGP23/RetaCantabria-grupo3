package com.example.kotlinapp.data.room.repository

import android.util.Log
import com.example.kotlinapp.data.room.daos.PuntosPeligroDao
import com.example.kotlinapp.data.room.entity.PuntoPeligroEntity
import com.example.kotlinapp.data.room.mappers.toDomain
import com.example.kotlinapp.data.room.mappers.toEntity
import com.example.kotlinapp.data.services.PuntoPeligroService
import com.example.kotlinapp.model.PuntoPeligro
import kotlinx.coroutines.flow.Flow
import kotlinx.coroutines.flow.map

class PuntosPeligroRepository(
    private val api: PuntoPeligroService,
    private val dao: PuntosPeligroDao
) {
    fun getPuntosPeligro(): Flow<List<PuntoPeligro>> = dao.getAll()
        .map { list -> list.map { it.toDomain() } }

    suspend fun insertPuntoPeligro(punto: PuntoPeligro) {
        dao.insert(punto.toEntity())
    }

    suspend fun syncPuntosPeligro(idRuta: Int) {
        val response = api.findAll(idRuta)
        Log.d("PUNTOSPELIGRO", "code=${response.code()} body=${response.body()}")
        if (response.isSuccessful) {
            response.body()?.let { puntos ->
                dao.insertAll(puntos.map { it.toEntity() })
            }
        }
    }
}
