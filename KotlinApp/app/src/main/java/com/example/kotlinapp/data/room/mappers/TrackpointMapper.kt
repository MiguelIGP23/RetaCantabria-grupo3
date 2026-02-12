package com.example.kotlinapp.data.room.mappers

import com.example.kotlinapp.data.room.entity.TrackpointEntity
import com.example.kotlinapp.model.Trackpoint

fun Trackpoint.toEntity() = TrackpointEntity(
    idRuta = idRuta,
    posicion = posicion,
    latitud = latitud,
    longitud = longitud,
    altitud = elevacion,
    time = time
)

fun TrackpointEntity.toDomain() = Trackpoint(
    idRuta = idRuta,
    posicion = posicion,
    latitud = latitud,
    longitud = longitud,
    elevacion = altitud,
    time = time
)