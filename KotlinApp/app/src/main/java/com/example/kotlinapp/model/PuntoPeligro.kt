package com.example.kotlinapp.model

data class PuntoPeligro(
    val idPuntospeligro: Int?,
    val nombre: String,
    val latitud: Double,
    val longitud: Double,
    val elevacion: Double,
    val kilometros: Double?,
    val gravedad: Byte?,
    val posicion: Int?,
    val descripcion: String?,
    val timestamp: Int?,
    val rutas_idRuta: Ruta
)