package com.example.kotlinapp.data.services

import com.example.kotlinapp.model.ImagenPeligro
import retrofit2.Response
import retrofit2.http.Body
import retrofit2.http.DELETE
import retrofit2.http.GET
import retrofit2.http.POST
import retrofit2.http.PUT
import retrofit2.http.Path

interface ImagenPeligroService {

    @POST("rutas/{idRuta}/puntosPeligro/{idPunto}/imagenespeligro")
    suspend fun insert(
        @Path("idRuta") idRuta: Int,
        @Path("idPunto") idPunto: Int,
        @Body t: ImagenPeligro
    ): Response<ImagenPeligro>

    @PUT("rutas/{idRuta}/puntosPeligro/{idPunto}/imagenespeligro/{id}")
    suspend fun update(
        @Path("idRuta") idRuta: Int,
        @Path("idPunto") idPunto: Int,
        @Path("id") id: Int,
        @Body t: ImagenPeligro
    ): Response<ImagenPeligro>

    @DELETE("rutas/{idRuta}/puntosPeligro/{idPunto}/imagenespeligro/{id}")
    suspend fun delete(
        @Path("idRuta") idRuta: Int,
        @Path("idPunto") idPunto: Int,
        @Path("id") id: Int
    ): Response<Unit>

    @GET("rutas/{idRuta}/puntosPeligro/{idPunto}/imagenespeligro/{id}")
    suspend fun findById(
        @Path("idRuta") idRuta: Int,
        @Path("idPunto") idPunto: Int,
        @Path("id") id: Int
    ): Response<ImagenPeligro>

    @GET("rutas/{idRuta}/puntosPeligro/{idPunto}/imagenespeligro")
    suspend fun findAll(
        @Path("idRuta") idRuta: Int,
        @Path("idPunto") idPunto: Int
    ): Response<List<ImagenPeligro>>
}
