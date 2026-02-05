package com.example.kotlinapp.data.room.repository

import com.example.kotlinapp.data.room.daos.RutaDao
import com.example.kotlinapp.data.room.entity.RutaEntity
import com.example.kotlinapp.data.room.mappers.toDomain
import com.example.kotlinapp.data.room.mappers.toEntity
import com.example.kotlinapp.data.services.RutaService
import com.example.kotlinapp.model.Ruta
import kotlinx.coroutines.flow.Flow
import kotlinx.coroutines.flow.map

class RutaRepository(
    private val api: RutaService,
    private val dao: RutaDao
) {

    fun getRutas(): Flow<List<Ruta>> = dao.getAll()
        .map { list -> list.map { it.toDomain() } }  // mapeo aquí


    suspend fun syncRutas() {
        val response = api.findAll()

        if (response.isSuccessful) {
            response.body()?.let { rutas ->
                dao.insertAll(rutas.map { it.toEntity() })
            }
        }
    }
}

