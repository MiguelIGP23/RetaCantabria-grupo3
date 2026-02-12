package com.example.kotlinapp.data.room.repository

import android.util.Log
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
    //todas las rutas local
    fun getRutas(): Flow<List<Ruta>> = dao.getAll()
        .map { list -> list.map { it.toDomain() } }

    suspend fun insertRuta(ruta: Ruta) {
        dao.insertOrUpdate(ruta.toEntity())
    }

    //todas las rutas remotas
    suspend fun syncRutas() {
        val response = api.findAll()
        if (response.isSuccessful) {
            response.body()?.let { rutas ->
                // Primero borrar todo
                dao.clearAll()
                // Luego insertar las nuevas rutas
                dao.insertOrUpdate(rutas.map { it.toEntity() })
            }
        }
    }


}

