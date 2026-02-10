package com.example.kotlinapp.data.services

import com.example.kotlinapp.model.Ruta
import okhttp3.MultipartBody
import okhttp3.RequestBody
import retrofit2.Response
import retrofit2.http.Body
import retrofit2.http.DELETE
import retrofit2.http.GET
import retrofit2.http.Multipart
import retrofit2.http.POST
import retrofit2.http.PUT
import retrofit2.http.Part
import retrofit2.http.Path

interface RutaService {

    @POST("rutas")
    suspend fun insert(@Body t: Ruta): Response<Ruta>

    @PUT("rutas/{id}")
    suspend fun update(@Path("id") id: Int, @Body t: Ruta): Response<Ruta>

    @DELETE("rutas/{id}")
    suspend fun delete(@Path("id") id: Int): Response<Unit>

    @GET("rutas/{id}")
    suspend fun findById(@Path("id") id: Int): Response<Ruta>

    @GET("rutas")
    suspend fun findAll(): Response<List<Ruta>>

    @GET("rutas/validadas")
    suspend fun findAllValidadas(): Response<List<Ruta>>

    @GET("rutas/validadas/{id}")
    suspend fun findValidadaById(@Path("id") id: Int): Response<Ruta>

    @Multipart
    @POST("rutas/gpx")
    suspend fun uploadGPX(
        @Part("dto") rutaBase: RequestBody,
        @Part gpx: MultipartBody.Part
    ): Response<Ruta>
}
