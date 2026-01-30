package com.example.kotlinapp.data

import android.icu.lang.UCharacter.GraphemeClusterBreak.T
import com.example.kotlinapp.model.ImagenesInteres
import retrofit2.Response
import retrofit2.http.Body
import retrofit2.http.DELETE
import retrofit2.http.GET
import retrofit2.http.POST
import retrofit2.http.PUT
import retrofit2.http.Path

interface ImagenesInteresService {

    @POST("imagenesinteres")
    suspend fun insert(@Body t: ImagenesInteres): Response<ImagenesInteres>
    @PUT("imagenesinteres/{id}")
    suspend fun update(
        @Path("id") id: Int,
        @Body imagen: ImagenesInteres
    ): Response<ImagenesInteres>
    @DELETE("imagenesinteres/{id}")
    suspend fun delete(@Path("id") id: Int): Response<Unit>
    @GET("imagenesinteres/{id}")
    suspend fun findById(@Path("id") id: Int): Response<ImagenesInteres>
    @GET("imagenesinteres")
    suspend fun findAll(): Response<List<ImagenesInteres>>
}
