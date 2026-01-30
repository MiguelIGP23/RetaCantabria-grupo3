package com.example.kotlinapp.model

data class ImagenInteres(
    val idimagenesinteres: Int?,
    val url: String,
    val descripcion: String?,
    val puntosinteres_idPuntosinteres: PuntoInteres
)

