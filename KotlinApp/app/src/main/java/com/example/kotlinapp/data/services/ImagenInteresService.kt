package com.example.kotlinapp.data.services

import com.example.kotlinapp.model.ImagenInteres
import retrofit2.Response
import retrofit2.http.Body
import retrofit2.http.DELETE
import retrofit2.http.GET
import retrofit2.http.POST
import retrofit2.http.PUT
import retrofit2.http.Path

interface ImagenInteresService {

    @POST("imagenesinteres")
    suspend fun insert(@Body t: ImagenInteres): Response<ImagenInteres>
    @PUT("imagenesinteres/{id}")
    suspend fun update(
        @Path("id") id: Int,
        @Body imagen: ImagenInteres
    ): Response<ImagenInteres>
    @DELETE("imagenesinteres/{id}")
    suspend fun delete(@Path("id") id: Int): Response<Unit>
    @GET("imagenesinteres/{id}")
    suspend fun findById(@Path("id") id: Int): Response<ImagenInteres>
    @GET("imagenesinteres")
    suspend fun findAll(): Response<List<ImagenInteres>>
}
