package com.example.kotlinapp.model

import com.example.kotlinapp.data.IdRef

data class PuntoPeligro(
    val id: Int?,
    val nombre: String,
    val latitud: Double,
    val longitud: Double,
    val elevacion: Double,
    val kilometros: Double?,
    val gravedad: Byte?,
    val descripcion: String?,
    val timestamp: Int?,
    val ruta: IdRef
)