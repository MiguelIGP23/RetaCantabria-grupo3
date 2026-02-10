package com.example.kotlinapp.data.room.mappers

import com.example.kotlinapp.data.IdRef
import com.example.kotlinapp.data.room.entity.ImagenInteresEntity
import com.example.kotlinapp.model.ImagenInteres


fun ImagenInteres.toEntity() = ImagenInteresEntity(
    idimagenesinteres = id,
    url = url,
    descripcion = descripcion,
    puntosinteres_idPuntosinteres = puntosInteresId
)

fun ImagenInteresEntity.toDomain() = ImagenInteres(
    id = idimagenesinteres,
    url = url,
    descripcion = descripcion,
    puntosInteresId = puntosinteres_idPuntosinteres
)