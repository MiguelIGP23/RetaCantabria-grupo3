package com.example.kotlinapp.model

data class ImagenesInteres(
    val idimagenesinteres: Int?,
    val url: String,
    val descripcion: String?,
    val puntosinteres_idPuntosinteres: PuntosInteres
)

