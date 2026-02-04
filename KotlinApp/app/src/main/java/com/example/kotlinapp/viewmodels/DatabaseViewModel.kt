package com.example.kotlinapp.viewmodels


import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import com.example.kotlinapp.data.AuthRepository
import kotlinx.coroutines.launch

class DatabaseViewModel(private val authRepository: AuthRepository) : ViewModel() {

    val token = authRepository.token
    val rol = authRepository.rol
    fun login(email: String, password: String): Boolean {
        viewModelScope.launch {
            authRepository.login(email, password)
        }
        return true //Placeholder
    }
}