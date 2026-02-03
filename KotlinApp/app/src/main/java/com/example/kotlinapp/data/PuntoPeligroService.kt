package com.example.kotlinapp.data

import com.example.kotlinapp.model.PuntoPeligro
import retrofit2.Response
import retrofit2.http.Body
import retrofit2.http.DELETE
import retrofit2.http.GET
import retrofit2.http.POST
import retrofit2.http.PUT
import retrofit2.http.Path

interface PuntoPeligroService {

    @POST("puntospeligro")
    suspend fun insert(@Body t: PuntoPeligro): Response<PuntoPeligro>

    @PUT("puntospeligro/{id}")
    suspend fun update(@Path("id") id: Int, @Body t: PuntoPeligro): Response<PuntoPeligro>

    @DELETE("puntospeligro/{id}")
    suspend fun delete(@Path("id") id: Int): Response<Unit>

    @GET("puntospeligro/{id}")
    suspend fun findById(@Path("id") id: Int): Response<PuntoPeligro>

    @GET("puntospeligro")
    suspend fun findAll(): Response<List<PuntoPeligro>>
}
