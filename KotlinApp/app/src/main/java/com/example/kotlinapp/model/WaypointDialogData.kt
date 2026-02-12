package com.example.kotlinapp.model

import com.example.kotlinapp.model.enums.TipoPunto
import com.example.kotlinapp.model.enums.WaypointType

data class WaypointDialogData(
    val lat: Double,
    val lon: Double,
    val elevation: Double,
    val type: WaypointType,
    val id: Int? = null,
    val nombre: String? = null,
    val caracteristicas: String? = null,
    val descripcion: String? = null,
    val timestamp: Long? = null,
    val rutaId: Int? = null,
    val kilometros: Double? = null,
    val gravedad: Byte? = null,
    val tipo: TipoPunto? = null
)
