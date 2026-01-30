package com.example.kotlinapp.data

import com.example.kotlinapp.model.ImagenPeligro
import retrofit2.Response
import retrofit2.http.Body
import retrofit2.http.DELETE
import retrofit2.http.GET
import retrofit2.http.POST
import retrofit2.http.PUT
import retrofit2.http.Path

interface ImagenPeligroService {

    @POST("imagenespeligro")
    suspend fun insert(@Body t: ImagenPeligro): Response<ImagenPeligro>

    @PUT("imagenespeligro/{id}")
    suspend fun update(@Path("id") id: Int, @Body t: ImagenPeligro): Response<ImagenPeligro>

    @DELETE("imagenespeligro/{id}")
    suspend fun delete(@Path("id") id: Int): Response<Unit>

    @GET("imagenespeligro/{id}")
    suspend fun findById(@Path("id") id: Int): Response<ImagenPeligro>

    @GET("imagenespeligro")
    suspend fun findAll(): Response<List<ImagenPeligro>>
}
