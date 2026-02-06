package com.example.kotlinapp.data

import com.example.kotlinapp.model.PuntoInteres
import retrofit2.Response
import retrofit2.http.Body
import retrofit2.http.DELETE
import retrofit2.http.GET
import retrofit2.http.POST
import retrofit2.http.PUT
import retrofit2.http.Path

interface PuntoInteresService {
    @GET("rutas/{idRuta}/puntosinteres")
    suspend fun findAll(@Path("idRuta") idRuta: Int): Response<List<PuntoInteres>>

    @GET("puntosinteres/{id}")
    suspend fun findById(@Path("id") id: Int): Response<PuntoInteres>

    @POST("rutas/{idRuta}/puntosinteres")
    suspend fun insert(@Path("idRuta") idRuta: Int, @Body t: PuntoInteres): Response<PuntoInteres>

    @PUT("rutas/{idRuta}/puntosinteres/{id}")
    suspend fun update(
        @Path("idRuta") idRuta: Int,
        @Path("id") id: Int,
        @Body t: PuntoInteres
    ): Response<PuntoInteres>

    @DELETE("rutas/{idRuta}/puntosinteres/{id}")
    suspend fun delete(@Path("idRuta") idRuta: Int, @Path("id") id: Int): Response<Unit>


}
