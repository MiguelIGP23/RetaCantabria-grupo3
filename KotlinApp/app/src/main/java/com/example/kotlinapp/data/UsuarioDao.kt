package com.example.kotlinapp.data

import androidx.room.Dao
import androidx.room.Delete
import androidx.room.Insert
import androidx.room.OnConflictStrategy
import androidx.room.Query

@Dao
interface UsuarioDao {

    // --- Login ---
    // @Query("SELECT * FROM Usuario WHERE email = :email AND password = :password")
    //suspend fun login(email: String, password: String): Usuario?

    // --- Obtener usuario por ID ---
    // @Query("SELECT * FROM Usuario WHERE idUsuario = :id")
    // suspend fun obtenerUsuario(id: Int): Usuario?

    // --- Guardar usuario autenticado ---
    // @Insert(onConflict = OnConflictStrategy.REPLACE)
    // suspend fun guardarUsuario(usuario: Usuario): Long

    // --- Roles --- @Query("SELECT rol FROM Usuario WHERE idUsuario = :id")
    // suspend fun obtenerRol(id: Int): Rol?

}