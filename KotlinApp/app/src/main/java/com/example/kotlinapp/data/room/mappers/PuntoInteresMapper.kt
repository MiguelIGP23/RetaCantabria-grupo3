package com.example.kotlinapp.data.room.mappers

import com.example.kotlinapp.data.IdRef
import com.example.kotlinapp.data.room.entity.ImagenPeligroEntity
import com.example.kotlinapp.data.room.entity.PuntoInteresEntity
import com.example.kotlinapp.model.ImagenPeligro
import com.example.kotlinapp.model.PuntoInteres

fun PuntoInteres.toEntity() = PuntoInteresEntity(
    id = id,
    nombre = nombre,
    latitud = latitud,
    longitud = longitud,
    elevacion = elevacion,
    caracteristicas = caracteristicas,
    tipo = tipo,
    descripcion = descripcion,
    timestamp = timestamp,
    rutaId = ruta.id
)

fun PuntoInteresEntity.toDomain() = PuntoInteres(
    id = id,
    nombre = nombre,
    latitud = latitud,
    longitud = longitud,
    elevacion = elevacion,
    caracteristicas = caracteristicas,
    tipo = tipo,
    descripcion = descripcion,
    timestamp = timestamp,
    ruta = IdRef(rutaId)
)