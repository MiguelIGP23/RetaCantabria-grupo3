package com.example.kotlinapp.data.services

import com.example.kotlinapp.model.PuntoInteres
import retrofit2.Response
import retrofit2.http.Body
import retrofit2.http.DELETE
import retrofit2.http.GET
import retrofit2.http.POST
import retrofit2.http.PUT
import retrofit2.http.Path

interface PuntoInteresService {

    @POST("puntosinteres")
    suspend fun insert(@Body t: PuntoInteres): Response<PuntoInteres>

    @PUT("puntosinteres/{id}")
    suspend fun update(@Path("id") id: Int, @Body t: PuntoInteres): Response<PuntoInteres>

    @DELETE("puntosinteres/{id}")
    suspend fun delete(@Path("id") id: Int): Response<Unit>

    @GET("puntosinteres/{id}")
    suspend fun findById(@Path("id") id: Int): Response<PuntoInteres>

    @GET("puntosinteres")
    suspend fun findAll(): Response<List<PuntoInteres>>
}
