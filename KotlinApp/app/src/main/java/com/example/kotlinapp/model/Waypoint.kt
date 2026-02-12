package com.example.kotlinapp.model

import com.example.kotlinapp.model.enums.WaypointType

data class Waypoint(
    val lat: Double,
    val lon: Double,
    val elevation: Double,
    val type: WaypointType,
    val title: String,
    val description: String,
    val photoPath: String? = null, // ruta interna o URI de la foto
)



