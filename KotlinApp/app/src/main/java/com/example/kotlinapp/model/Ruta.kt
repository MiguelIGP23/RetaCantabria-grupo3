package com.example.kotlinapp.model

import com.example.kotlinapp.data.IdRef
import com.example.kotlinapp.model.enums.Clasificacion


data class Ruta(
    val id: Int?,
    val nombre: String,
    val nombreInicioruta: String,
    val nombreFinalruta: String,
    val latitudInicial: Double,
    val latitudFinal: Double,
    val longitudInicial: Double,
    val longitudFinal: Double,
    val distancia: Double,
    val duracion: String,
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
    val usuario: IdRef
)
