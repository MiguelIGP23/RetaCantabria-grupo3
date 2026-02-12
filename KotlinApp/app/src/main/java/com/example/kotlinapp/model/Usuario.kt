package com.example.kotlinapp.model

import com.example.kotlinapp.model.enums.Rol

data class Usuario(
    val id: Int?,
    val nombre: String,
    val apellido: String,
    val email: String,
    val password: String,
    val rol: Rol?
)
