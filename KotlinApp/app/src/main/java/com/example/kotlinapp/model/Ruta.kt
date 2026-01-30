package com.example.kotlinapp.model

import com.example.kotlinapp.model.enums.Clasificacion

import java.time.LocalTime

data class Ruta(
    val idRuta: Int?,
    val nombre: String,
    val nombre_inicioruta: String,
    val nombre_finalruta: String,
    val latitudInicial: Double,
    val latitudFinal: Double,
    val longitudInicial: Double,
    val longitudFinal: Double,
    val distancia: Double,
    val duracion: LocalTime,
    val desnivelPositivo: Int?,
    val desnivelNegativo: Int?,
    val altitudMax: Double?,
    val altitudMin: Double?,
    val clasificacion: Clasificacion?,
    val nivelEsfuerzo: Byte?,
    val nivelRiesgo: Byte?,
    val estadoRuta: Byte?,
    val tipoTerreno: Byte?,
    val indicaciones: Byte?,
    val temporadas: String?,
    val accesibilidad: Byte?,
    val rutaFamiliar: Byte?,
    val archivoGPX: String?,
    val recomendacionesEquipo: String?,
    val zonaGeografica: String?,
    val mediaEstrellas: Double?,
    val usuario_idUsuario: Usuario
)
