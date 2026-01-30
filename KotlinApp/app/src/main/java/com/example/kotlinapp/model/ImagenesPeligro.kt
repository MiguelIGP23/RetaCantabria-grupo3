package com.example.kotlinapp.model

data class ImagenesPeligro(
    val idimagenespeligro: Int?,
    val url: String,
    val descripcion: String?,
    val puntospeligro_idPuntospeligro: PuntosPeligro
)
