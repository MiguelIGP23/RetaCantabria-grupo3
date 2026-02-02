package com.example.kotlinapp.model

import com.example.kotlinapp.model.enums.WaypointType

data class WaypointDialogData(
    val lat: Double,
    val lon: Double,
    val elevation: Double,
    val type: WaypointType
)