package com.example.kotlinapp.data.room.entity

import androidx.room.Entity
import androidx.room.PrimaryKey
import com.example.kotlinapp.model.enums.Rol

@Entity(tableName = "usuario")
data class UsuarioEntity(
    @PrimaryKey(autoGenerate = true) val idUsuario: Int? = null,
    val nombre: String,
    val apellido: String,
    val email: String,
    val password: String,
    val rol: Rol? = Rol.ALUMNO
)
