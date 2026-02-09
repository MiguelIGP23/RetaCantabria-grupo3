package com.example.kotlinapp.data.room.repository

import android.util.Log
import com.example.kotlinapp.data.room.daos.ImagenPeligroDao
import com.example.kotlinapp.data.room.entity.ImagenPeligroEntity
import com.example.kotlinapp.data.room.mappers.toDomain
import com.example.kotlinapp.data.room.mappers.toEntity
import com.example.kotlinapp.data.services.ImagenPeligroService
import com.example.kotlinapp.model.ImagenPeligro
import kotlinx.coroutines.flow.Flow
import kotlinx.coroutines.flow.map

class ImagenPeligroRepository(
    private val api: ImagenPeligroService,
    private val dao: ImagenPeligroDao
) {
    fun getImagenesPeligro(): Flow<List<ImagenPeligro>> = dao.getAll()
        .map { list -> list.map { it.toDomain() } }

    suspend fun insertImagenPeligro(imagen: ImagenPeligro) {
        dao.insert(imagen.toEntity())
    }

    suspend fun syncImagenesPeligro() {
        val response = api.findAll()
        Log.d("IMAGENESPELIGRO", "code=${response.code()} body=${response.body()}")
        if (response.isSuccessful) {
            response.body()?.let { images ->
                dao.insertAll(images.map { it.toEntity() })
            }
        }
    }
}
