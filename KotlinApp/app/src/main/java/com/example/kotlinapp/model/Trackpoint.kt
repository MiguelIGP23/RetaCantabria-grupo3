package com.example.kotlinapp.model

data class Trackpoint(
    val id: Int,
    val posicion: Int,
    val latitud: Double,
    val longitud: Double,
    val altitud: Double,
    val time: Long
)

data class TrackpointId(
    val idRuta: Int,
    val posicion: Int
)