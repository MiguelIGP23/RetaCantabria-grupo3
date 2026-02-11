package com.example.kotlinapp.model

data class PuntoPeligro(
    val id: Int?,
    val nombre: String,
    val latitud: Double,
    val longitud: Double,
    val elevacion: Double,
    val kilometros: Double?,
    val gravedad: Byte?,
    val descripcion: String?,
    val timestamp: Long,
    val rutaId: Int
)