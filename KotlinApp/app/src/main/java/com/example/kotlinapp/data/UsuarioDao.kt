package com.example.kotlinapp.data

import androidx.room.Dao
import androidx.room.Delete
import androidx.room.Insert
import androidx.room.OnConflictStrategy
import androidx.room.Query

@Dao
interface UsuarioDao {

    //@Query("SELECT * FROM Usuario WHERE idUsuario = :id")
    //suspend fun obtenerUsuario(id: Long): Usuario?

    //@Insert(onConflict = OnConflictStrategy.REPLACE)
    //suspend fun insertarUsuario(usuario: Usuario): Long

}