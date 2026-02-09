package com.example.kotlinapp.data.room.repository

import android.util.Log
import com.example.kotlinapp.data.room.daos.ImagenInteresDao
import com.example.kotlinapp.data.room.mappers.toDomain
import com.example.kotlinapp.data.room.mappers.toEntity
import com.example.kotlinapp.data.services.ImagenInteresService
import com.example.kotlinapp.model.ImagenInteres
import kotlinx.coroutines.flow.Flow
import kotlinx.coroutines.flow.map
import retrofit2.http.Path

class ImagenInteresRepository(
    private val api: ImagenInteresService,
    private val dao: ImagenInteresDao
) {
    fun getImagenesInteres(): Flow<List<ImagenInteres>> = dao.getAll()
        .map { list -> list.map { it.toDomain() } }

    suspend fun insertImagenInteres(imagen: ImagenInteres) {
        dao.insert(imagen.toEntity())
    }

    suspend fun syncImagenesInteres(idRuta: Int,idPunto: Int) {
        val response = api.findAll(idRuta, idPunto)
        Log.d("IMAGENESINTERES", "code=${response.code()} body=${response.body()}")
        if (response.isSuccessful) {
            response.body()?.let { images ->
                dao.insertAll(images.map { it.toEntity() })
            }
        }
    }
}
