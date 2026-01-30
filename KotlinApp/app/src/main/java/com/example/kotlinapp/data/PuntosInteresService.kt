package com.example.kotlinapp.data

import com.example.kotlinapp.model.PuntosInteres
import retrofit2.Response
import retrofit2.http.Body
import retrofit2.http.DELETE
import retrofit2.http.GET
import retrofit2.http.POST
import retrofit2.http.PUT
import retrofit2.http.Path

interface PuntosInteresService {

    @POST("puntosinteres")
    suspend fun insert(@Body t: PuntosInteres): Response<PuntosInteres>

    @PUT("puntosinteres/{id}")
    suspend fun update(@Path("id") id: Int, @Body t: PuntosInteres): Response<PuntosInteres>

    @DELETE("puntosinteres/{id}")
    suspend fun delete(@Path("id") id: Int): Response<Unit>

    @GET("puntosinteres/{id}")
    suspend fun findById(@Path("id") id: Int): Response<PuntosInteres>

    @GET("puntosinteres")
    suspend fun findAll(): Response<List<PuntosInteres>>
}
