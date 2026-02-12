package com.example.kotlinapp.data.services

import com.example.kotlinapp.model.Trackpoint
import retrofit2.Response
import retrofit2.http.Body
import retrofit2.http.DELETE
import retrofit2.http.GET
import retrofit2.http.POST
import retrofit2.http.PUT
import retrofit2.http.Path

interface TrackpointService {

    @GET("trackpoints")
    suspend fun findAll(): Response<List<Trackpoint>>

    @GET("rutas/{idRuta}/trackpoints")
    suspend fun findByRuta(
        @Path("idRuta") idRuta: Int
    ): Response<List<Trackpoint>>

    @GET("rutas/{idRuta}/trackpoints/{posicion}")
    suspend fun findById(
        @Path("idRuta") idRuta: Int,
        @Path("posicion") posicion: Int
    ): Response<Trackpoint>

    @POST("rutas/{idRuta}/trackpoints")
    suspend fun insert(
        @Path("idRuta") idRuta: Int,
        @Body trackpoint: Trackpoint
    ): Response<Trackpoint>

    @PUT("rutas/{idRuta}/trackpoints/{posicion}")
    suspend fun update(
        @Path("idRuta") idRuta: Int,
        @Path("posicion") posicion: Int,
        @Body trackpoint: Trackpoint
    ): Response<Trackpoint>

    @DELETE("rutas/{idRuta}/trackpoints/{posicion}")
    suspend fun delete(
        @Path("idRuta") idRuta: Int,
        @Path("posicion") posicion: Int
    ): Response<Unit>
}
