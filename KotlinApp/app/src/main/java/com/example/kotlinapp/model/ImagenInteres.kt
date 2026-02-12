package com.example.kotlinapp.model

import com.google.gson.annotations.SerializedName

data class ImagenInteres(
    val id: Int?,
    val url: String,
    val descripcion: String?,
    @SerializedName("puntosInteres")
    val puntosInteresId: Int
)

