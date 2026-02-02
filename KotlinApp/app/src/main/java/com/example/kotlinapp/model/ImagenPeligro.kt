package com.example.kotlinapp.model

import com.example.kotlinapp.data.IdRef

data class ImagenPeligro(
    val id: Int?,
    val url: String,
    val descripcion: String?,
    val puntospeligro: IdRef
)
