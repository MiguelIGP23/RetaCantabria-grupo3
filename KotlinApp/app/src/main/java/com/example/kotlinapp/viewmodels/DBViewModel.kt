package com.example.kotlinapp.viewmodels


import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import com.example.kotlinapp.data.AppDatabase
import com.example.kotlinapp.data.AuthRepository
import com.example.kotlinapp.data.ServiceFactory
import com.example.kotlinapp.data.room.repository.RutaRepository
import kotlinx.coroutines.flow.MutableStateFlow
import kotlinx.coroutines.flow.SharingStarted
import kotlinx.coroutines.flow.asStateFlow
import kotlinx.coroutines.flow.first
import kotlinx.coroutines.flow.stateIn
import kotlinx.coroutines.launch
import kotlinx.coroutines.runBlocking

class DBViewModel(private val authRepository: AuthRepository, private val roomDB: AppDatabase) : ViewModel() {

    //Session Stuff
    val token = authRepository.token
    val rol = authRepository.rol
    //Login Stuff
    private val _loginState = MutableStateFlow<LoginState>(LoginState.Waiting)

    fun login(email: String, password: String) {
        viewModelScope.launch {
            val result = authRepository.login(email, password)
            _loginState.value = if (result) LoginState.Valid else LoginState.Invalid
        }
    }

    fun logout() {
        viewModelScope.launch {
            authRepository.logout()
            _loginState.value = LoginState.Expired
        }
    }

    fun resetLoginState() {
        _loginState.value = LoginState.Waiting
    }

    sealed class LoginState() {
        object Valid : LoginState()
        object Invalid : LoginState()
        object Waiting : LoginState()
        object Expired : LoginState()
    }

    val loginState = _loginState.asStateFlow()

    fun checkAuth() {
        viewModelScope.launch {
            val response = ruta.findAll()
            _loginState.value = when (response.code()) {
                200 -> LoginState.Valid
                401 -> LoginState.Expired //Buscamos este codigo, ver si ha caducado el token
                else -> LoginState.Invalid
            }
        }
    }

    fun tokenProvider(): () -> String? = {
        runBlocking { token.first() }
    }
    //DB Stuff

    val ruta by lazy { ServiceFactory.ruta(tokenProvider()) }
    private val rutaRepo = RutaRepository(ruta, roomDB.rutaDao())
    val rutas = rutaRepo.getRutas()
        .stateIn(
            scope = viewModelScope,
            started = SharingStarted.WhileSubscribed(5000),
            initialValue = emptyList()
        )

//    init {
//        viewModelScope.launch {
//            rutaRepo.syncRutas()
//        }
//    }

    fun insertRuta(ruta: com.example.kotlinapp.model.Ruta) {
        viewModelScope.launch {
            rutaRepo.insertRuta(ruta)
        }
    }

    fun syncRutas() {
        viewModelScope.launch {
            rutaRepo.syncRutas()
        }
    }
}
