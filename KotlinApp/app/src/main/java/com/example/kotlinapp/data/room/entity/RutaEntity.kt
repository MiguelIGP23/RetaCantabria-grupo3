package com.example.kotlinapp.data.room.entity

import androidx.room.Entity
import androidx.room.PrimaryKey
import com.example.kotlinapp.data.IdRef
import com.example.kotlinapp.model.enums.Clasificacion

@Entity(tableName = "rutas")
data class RutaEntity(
    @PrimaryKey(autoGenerate = true)
    val idRuta: Int = 0,
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
    val usuarioId: Int
)