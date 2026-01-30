package com.example.kotlinapp.data

import com.example.kotlinapp.model.ImagenesPeligro
import retrofit2.Response
import retrofit2.http.Body
import retrofit2.http.DELETE
import retrofit2.http.GET
import retrofit2.http.POST
import retrofit2.http.PUT
import retrofit2.http.Path

interface ImagenesPeligroService {

    @POST("imagenespeligro")
    suspend fun insert(@Body t: ImagenesPeligro): Response<ImagenesPeligro>

    @PUT("imagenespeligro/{id}")
    suspend fun update(@Path("id") id: Int, @Body t: ImagenesPeligro): Response<ImagenesPeligro>

    @DELETE("imagenespeligro/{id}")
    suspend fun delete(@Path("id") id: Int): Response<Unit>

    @GET("imagenespeligro/{id}")
    suspend fun findById(@Path("id") id: Int): Response<ImagenesPeligro>

    @GET("imagenespeligro")
    suspend fun findAll(): Response<List<ImagenesPeligro>>
}
