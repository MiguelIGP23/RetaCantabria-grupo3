package com.example.kotlinapp.model

import com.example.kotlinapp.model.enums.TipoPunto

data class PuntoInteres(
    val id: Int?,
    val nombre: String,
    val latitud: Double,
    val longitud: Double,
    val elevacion: Double,
    val caracteristicas: String?,
    val tipo: TipoPunto?,
    val descripcion: String?,
    val timestamp: Int?,
    val rutaId: Int
)
