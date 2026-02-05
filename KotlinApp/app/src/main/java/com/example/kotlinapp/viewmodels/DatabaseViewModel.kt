package com.example.kotlinapp.viewmodels


import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import com.example.kotlinapp.data.AuthRepository
import com.example.kotlinapp.data.ServiceFactory
import kotlinx.coroutines.flow.first
import kotlinx.coroutines.launch
import kotlinx.coroutines.runBlocking

class DatabaseViewModel(private val authRepository: AuthRepository) : ViewModel() {

    val token = authRepository.token
    val rol = authRepository.rol

    val ruta = ServiceFactory.ruta(tokenProvider())

    fun login(email: String, password: String): Boolean {
        var result = false
        viewModelScope.launch {
            result = authRepository.login(email, password)
        }
        return result
    }

    fun tokenProvider(): () -> String? = {
        runBlocking { token.first() }
    }

    fun checkAuth(): Boolean {
        var autorizado = false
        viewModelScope.launch {
            val response = ruta.findAll()
            autorizado = when (response.code()) {
                200 -> true
                401 -> false //Buscamos este codigo, ver si ha caducado el token
                else -> false
            }
        }
        return autorizado
    }
}