package com.example.kotlinapp.data.room.mappers

import com.example.kotlinapp.data.IdRef
import com.example.kotlinapp.data.room.entity.ImagenPeligroEntity
import com.example.kotlinapp.model.ImagenPeligro

fun ImagenPeligro.toEntity() = ImagenPeligroEntity(
    idimagenespeligro = id,
    url = url,
    descripcion = descripcion,
    puntospeligro_idPuntospeligro = puntospeligroId
)

fun ImagenPeligroEntity.toDomain() = ImagenPeligro(
    id = idimagenespeligro,
    url = url,
    descripcion = descripcion,
    puntospeligroId = puntospeligro_idPuntospeligro
)