package com.example.kotlinapp.model

data class Trackpoint(
    val id: TrackpointId,
    val latitud: Double,
    val longitud: Double
)

data class TrackpointId(
    val idRuta: Int,
    val posicion: Int
)