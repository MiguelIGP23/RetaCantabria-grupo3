package com.example.kotlinapp.data

import com.example.kotlinapp.model.enums.Rol

data class LoginResponse(
    val token: String,
    val rol : Rol
)
