package com.example.kotlinapp.data.room.repository

import android.util.Log
import com.example.kotlinapp.data.room.daos.UsuarioDao
import com.example.kotlinapp.data.room.entity.UsuarioEntity
import com.example.kotlinapp.data.room.mappers.toDomain
import com.example.kotlinapp.data.room.mappers.toEntity
import com.example.kotlinapp.data.services.UsuarioService
import com.example.kotlinapp.model.Usuario
import kotlinx.coroutines.flow.Flow
import kotlinx.coroutines.flow.map

class UsuarioRepository(
    private val api: UsuarioService,
    private val dao: UsuarioDao
) {
    fun getUsuarios(): Flow<List<Usuario>> = dao.getAll()
        .map { list -> list.map { it.toDomain() } }

    suspend fun insertUsuario(usuario: Usuario) {
        dao.insert(usuario.toEntity())
    }

    suspend fun syncUsuarios() {
        val response = api.findAll()
        Log.d("USUARIOS", "code=${response.code()} body=${response.body()}")
        if (response.isSuccessful) {
            response.body()?.let { usuarios ->
                dao.insertAll(usuarios.map { it.toEntity() })
            }
        }
    }
}
