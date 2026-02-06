package com.example.kotlinapp.data.room.entity

import com.example.kotlinapp.data.IdRef
import com.google.gson.annotations.SerializedName

data class ImagenInteresEntity(
    val id: Int?,
    val url: String,
    val descripcion: String?,
    @SerializedName("puntosInteres")
    val puntosInteres: IdRef
)