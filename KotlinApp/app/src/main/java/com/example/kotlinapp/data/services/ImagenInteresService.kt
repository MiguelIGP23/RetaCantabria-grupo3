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

    @POST("rutas/{idRuta}/puntosPeligro/{idPunto}/imagenesinteres")
    suspend fun insert(
        @Path("idRuta") idRuta: Int, @Path("idPunto") idPunto: Int, @Body t: ImagenInteres
    ): Response<ImagenInteres>

    @PUT("rutas/{idRuta}/puntosPeligro/{idPunto}/imagenesinteres/{id}")
    suspend fun update(
        @Path("idRuta") idRuta: Int,
        @Path("idPunto") idPunto: Int,
        @Path("id") id: Int,
        @Body imagen: ImagenInteres
    ): Response<ImagenInteres>

    @DELETE("rutas/{idRuta}/puntosPeligro/{idPunto}/imagenesinteres/{id}")
    suspend fun delete(
        @Path("idRuta") idRuta: Int, @Path("idPunto") idPunto: Int, @Path("id") id: Int
    ): Response<Unit>

    @GET("rutas/{idRuta}/puntosPeligro/{idPunto}/imagenesinteres/{id}")
    suspend fun findById(
        @Path("idRuta") idRuta: Int, @Path("idPunto") idPunto: Int, @Path("id") id: Int
    ): Response<ImagenInteres>

    @GET("rutas/{idRuta}/puntosPeligro/{idPunto}/imagenesinteres")
    suspend fun findAll(
        @Path("idRuta") idRuta: Int, @Path("idPunto") idPunto: Int
    ): Response<List<ImagenInteres>>
}
