package com.example.kotlinapp.data.services

import com.example.kotlinapp.model.PuntoPeligro
import com.example.kotlinapp.model.Ruta
import retrofit2.Response
import retrofit2.http.Body
import retrofit2.http.DELETE
import retrofit2.http.GET
import retrofit2.http.POST
import retrofit2.http.PUT
import retrofit2.http.Path

interface PuntoPeligroService {

    @POST("rutas/{idRuta}/puntospeligro")
    suspend fun insert(@Path("idRuta") idRuta: Int, @Body t: PuntoPeligro): Response<PuntoPeligro>

    @PUT("rutas/{idRuta}/puntospeligro/{id}")
    suspend fun update(
        @Path("idRuta") idRuta: Int,
        @Path("id") id: Int,
        @Body t: PuntoPeligro
    ): Response<PuntoPeligro>

    @DELETE("rutas/{idRuta}/puntospeligro/{id}")
    suspend fun delete(@Path("idRuta") idRuta: Int, @Path("id") id: Int): Response<Unit>

    @GET("rutas/{idRuta}/puntospeligro/{id}")
    suspend fun findById(@Path("idRuta") idRuta: Int, @Path("id") id: Int): Response<PuntoPeligro>

    @GET("rutas/{idRuta}/puntospeligro")
    suspend fun findAll(@Path("idRuta") idRuta: Int): Response<List<PuntoPeligro>>
}
