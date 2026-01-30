package com.example.kotlinapp.model

data class ImagenPeligro(
    val idimagenespeligro: Int?,
    val url: String,
    val descripcion: String?,
    val puntospeligro_idPuntospeligro: PuntoPeligro
)
