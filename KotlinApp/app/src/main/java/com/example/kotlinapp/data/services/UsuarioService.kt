package com.example.kotlinapp.data.services

import com.example.kotlinapp.model.Usuario
import retrofit2.Response
import retrofit2.http.Body
import retrofit2.http.DELETE
import retrofit2.http.GET
import retrofit2.http.POST
import retrofit2.http.PUT
import retrofit2.http.Path

interface UsuarioService {

    @POST("usuarios")
    suspend fun insert(@Body t: Usuario): Response<Usuario>

    @PUT("usuarios/{id}")
    suspend fun update(@Path("id") id: Int, @Body t: Usuario): Response<Usuario>

    @DELETE("usuarios/{id}")
    suspend fun delete(@Path("id") id: Int): Response<Unit>

    @GET("usuarios/{id}")
    suspend fun findById(@Path("id") id: Int): Response<Usuario>

    @GET("usuarios")
    suspend fun findAll(): Response<List<Usuario>>
}
