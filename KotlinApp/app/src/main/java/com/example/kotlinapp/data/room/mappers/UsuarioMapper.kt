package com.example.kotlinapp.data.room.mappers

import com.example.kotlinapp.data.room.entity.UsuarioEntity
import com.example.kotlinapp.model.Usuario

fun Usuario.toEntity() = UsuarioEntity(
    idUsuario = id,
    nombre = nombre,
    apellido = apellido,
    email = email,
    password = password,
    rol = rol
)

fun UsuarioEntity.toDomain() = Usuario(
    id = idUsuario,
    nombre = nombre,
    apellido = apellido,
    email = email,
    password = password,
    rol = rol
)
