package com.example.kotlinapp.data.room.repository

import com.example.kotlinapp.data.room.daos.UsuarioDao

class UsuarioRepository(private val usuarioDao: UsuarioDao) {

    // --- Login ---
    // suspend fun login(email: String, password: String): Usuario? {
    // return usuarioDao.login(email, password)
    // }

    // --- Obtener usuario por ID ---
    // suspend fun obtenerUsuario(id: Int): Usuario? {
    // return usuarioDao.obtenerUsuario(id)
    // }

    // --- Guardar usuario autenticado ---
    // suspend fun guardarUsuario(usuario: Usuario): Long {
    // return usuarioDao.guardarUsuario(usuario)
    // }

    // --- Roles ---
    // suspend fun obtenerRol(id: Int): Rol? {
    // return usuarioDao.obtenerRol(id)
    // }
}