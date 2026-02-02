package com.example.kotlinapp.model

import com.example.kotlinapp.data.IdRef
import com.google.gson.annotations.SerializedName

data class ImagenInteres(
    val id: Int?,
    val url: String,
    val descripcion: String?,
    @SerializedName("puntosInteres")
    val puntosInteres: IdRef
)

