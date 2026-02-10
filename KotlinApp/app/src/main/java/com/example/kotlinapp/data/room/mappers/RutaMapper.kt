package com.example.kotlinapp.data.room.mappers

import com.example.kotlinapp.data.room.entity.RutaEntity
import com.example.kotlinapp.model.Ruta

// Dominio -> Entidad
fun Ruta.toEntity() = RutaEntity(
    idRuta = id ?: 0,
    nombre = nombre,
    nombreInicioruta = nombreInicioruta,
    nombreFinalruta = nombreFinalruta,
    latitudInicial = latitudInicial,
    latitudFinal = latitudFinal,
    longitudInicial = longitudInicial,
    longitudFinal = longitudFinal,
    distancia = distancia,
    duracion = duracion,
    desnivelPositivo = desnivelPositivo,
    desnivelNegativo = desnivelNegativo,
    altitudMax = altitudMax,
    altitudMin = altitudMin,
    clasificacion = clasificacion, // enum directo
    nivelEsfuerzo = nivelEsfuerzo,
    nivelRiesgo = nivelRiesgo,
    estadoRuta = estadoRuta,
    tipoTerreno = tipoTerreno,
    indicaciones = indicaciones,
    temporadas = temporadas,
    accesibilidad = accesibilidad,
    rutaFamiliar = rutaFamiliar,
    archivoGPX = archivoGPX,
    recomendacionesEquipo = recomendacionesEquipo,
    zonaGeografica = zonaGeografica,
    mediaEstrellas = mediaEstrellas,
    usuarioId = usuarioId
)

// Entidad -> Dominio
fun RutaEntity.toDomain() = Ruta(
    id = idRuta,
    nombre = nombre,
    nombreInicioruta = nombreInicioruta,
    nombreFinalruta = nombreFinalruta,
    latitudInicial = latitudInicial,
    latitudFinal = latitudFinal,
    longitudInicial = longitudInicial,
    longitudFinal = longitudFinal,
    distancia = distancia,
    duracion = duracion,
    desnivelPositivo = desnivelPositivo,
    desnivelNegativo = desnivelNegativo,
    altitudMax = altitudMax,
    altitudMin = altitudMin,
    clasificacion = clasificacion, // enum directo
    nivelEsfuerzo = nivelEsfuerzo,
    nivelRiesgo = nivelRiesgo,
    estadoRuta = estadoRuta,
    tipoTerreno = tipoTerreno,
    indicaciones = indicaciones,
    temporadas = temporadas,
    accesibilidad = accesibilidad,
    rutaFamiliar = rutaFamiliar,
    archivoGPX = archivoGPX,
    recomendacionesEquipo = recomendacionesEquipo,
    zonaGeografica = zonaGeografica,
    mediaEstrellas = mediaEstrellas,
    usuarioId = usuarioId
)
