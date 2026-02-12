package com.example.kotlinapp.model

data class Trackpoint(
    val idRuta: Int,
    val posicion: Int,
    val latitud: Double,
    val longitud: Double,
    val elevacion: Double,
    val time: Long
)
