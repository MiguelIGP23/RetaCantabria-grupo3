package com.example.kotlinapp.viewmodels


import androidx.compose.material3.CircularProgressIndicator
import androidx.compose.runtime.*
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import com.example.kotlinapp.data.AppDatabase
import com.example.kotlinapp.data.AuthRepository
import com.example.kotlinapp.data.ServiceFactory
import com.example.kotlinapp.data.room.repository.RutaRepository
import com.example.kotlinapp.model.Ruta
import com.example.kotlinapp.model.enums.Clasificacion
import com.google.gson.Gson
import com.example.kotlinapp.views.RutaList
import kotlinx.coroutines.flow.MutableStateFlow
import kotlinx.coroutines.flow.SharingStarted
import kotlinx.coroutines.flow.asStateFlow
import kotlinx.coroutines.flow.first
import kotlinx.coroutines.flow.stateIn
import kotlinx.coroutines.launch
import kotlinx.coroutines.runBlocking
import okhttp3.MediaType.Companion.toMediaType
import okhttp3.MediaType.Companion.toMediaTypeOrNull
import okhttp3.MultipartBody
import okhttp3.RequestBody.Companion.toRequestBody

class DBViewModel(private val authRepository: AuthRepository, private val roomDB: AppDatabase) : ViewModel() {

    //Session Stuff
    val token = authRepository.token
    val rol = authRepository.rol

    //Login Stuff
    private val _loginState = MutableStateFlow<LoginState>(LoginState.Waiting)

    private val _rutaImportada = mutableStateOf<Ruta?>(null)
    val rutaImportada: State<Ruta?> get() = _rutaImportada

    fun setRutaImportada(ruta: Ruta) {
        _rutaImportada.value = ruta
    }

    fun login(email: String, password: String) {
        viewModelScope.launch {
            val result = authRepository.login(email, password)
            _loginState.value = if (result) LoginState.Valid else LoginState.Invalid
            if (result) {
                onLoginSuccess() // sincroniza rutas después de login
            }
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
            val response = rutaService.findAll()
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

    val rutaService by lazy { ServiceFactory.ruta(tokenProvider()) }
    private val rutaRepo = RutaRepository(rutaService, roomDB.rutaDao())
    private val _rutasLoaded = mutableStateOf(false)
    val rutas = rutaRepo.getRutas()
        .stateIn(viewModelScope, SharingStarted.WhileSubscribed(5000), emptyList())

    fun onLoginSuccess() {
        viewModelScope.launch {
            // Primero sincroniza con servidor
            rutaRepo.syncRutas()
            _rutasLoaded.value = true
        }
    }

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

    private val _ruta = MutableStateFlow<Ruta?>(null)
    var ruta = _ruta.asStateFlow()

    fun getRuta(id: Int) {
        viewModelScope.launch {
            val response = rutaService.findById(id)
            _ruta.value = response.body()
        }
    }

    fun deleteRuta(id: Int) {
        viewModelScope.launch {
            val response = rutaService.delete(id)
        }
    }

    fun uploadGpx(ruta: Ruta, gpx: String) {
        viewModelScope.launch {
            val rutaResponseBody =
                Gson().toJson(ruta).toRequestBody("application/json".toMediaTypeOrNull())
            val gpxRequestBody = gpx.toRequestBody(
                "application/octet-stream".toMediaType()
            )
            val gpxPart = MultipartBody.Part.createFormData(
                name = "file",
                filename = "track.gpx",
                body = gpxRequestBody
            )
            val response = rutaService.uploadGPX(rutaResponseBody, gpxPart)
            _ruta.value = response.body();
        }
    }

    fun limpiarRuta() {
        _ruta.value = null
    }

    fun confirmarBorrador(
        nombre: String,
        zonaGeografica: String,
        puntoInicial: String,
        puntoFinal: String,
        temporadasString: String,
        equipo: String,
        terreno: Int,
        indicaciones: Int,
        id: Int?,
        accesibilidad: Boolean,
        rutaFamiliar: Boolean,
        clasificacion: Clasificacion
    ) {
        viewModelScope.launch {
            val rutaModificada = ruta.value?.copy(
                nombre = nombre,
                nombreInicioruta = puntoInicial,
                nombreFinalruta = puntoFinal,
                zonaGeografica = zonaGeografica,
                temporadas = temporadasString,
                recomendacionesEquipo = equipo,
                indicaciones = indicaciones.toByte(),
                tipoTerreno = terreno.toByte(),
                accesibilidad = if (accesibilidad) 1 else 0,
                rutaFamiliar = if (rutaFamiliar) 1 else 0,
                clasificacion = clasificacion
            )
            rutaService.confirmarBorrador(id!!, rutaModificada!!)
        }
    }

    fun cancelarBorrador(id: Int) {
        viewModelScope.launch {
            rutaService.cancelarBorrador(id)
        }
    }
}
