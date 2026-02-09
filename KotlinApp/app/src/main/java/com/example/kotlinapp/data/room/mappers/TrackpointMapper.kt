package com.example.kotlinapp.data.room.mappers

import com.example.kotlinapp.data.room.entity.TrackpointEntity
import com.example.kotlinapp.model.Trackpoint

fun Trackpoint.toEntity() = TrackpointEntity(
    idRuta = id,
    posicion = posicion,
    latitud = latitud,
    longitud = longitud,
    altitud = altitud,
    time = time
)

fun TrackpointEntity.toDomain() = Trackpoint(
    id = idRuta,
    posicion = posicion,
    latitud = latitud,
    longitud = longitud,
    altitud = altitud,
    time = time
)