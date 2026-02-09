package com.example.kotlinapp.data.room.mappers

import com.example.kotlinapp.data.IdRef
import com.example.kotlinapp.data.room.entity.ImagenPeligroEntity
import com.example.kotlinapp.data.room.entity.PuntoPeligroEntity
import com.example.kotlinapp.model.ImagenPeligro
import com.example.kotlinapp.model.PuntoPeligro

fun PuntoPeligro.toEntity() = PuntoPeligroEntity(
    id = id,
    nombre = nombre,
    latitud = latitud,
    longitud = longitud,
    elevacion = elevacion,
    descripcion = descripcion,
    timestamp = timestamp,
    kilometros = kilometros,
    gravedad = gravedad,
    rutaId = ruta.id,
)

fun PuntoPeligroEntity.toDomain() = PuntoPeligro(
    id = id,
    nombre = nombre,
    latitud = latitud,
    longitud = longitud,
    elevacion = elevacion,
    descripcion = descripcion,
    timestamp = timestamp,
    gravedad = gravedad,
    kilometros = kilometros,
    ruta = IdRef(rutaId)
)