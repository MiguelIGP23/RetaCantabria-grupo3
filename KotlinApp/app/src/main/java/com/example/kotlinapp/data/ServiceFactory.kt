package com.example.kotlinapp.data

import okhttp3.OkHttpClient
import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory

object ServiceFactory {
    private const val URL = "https://api.raspiremote.org/api/reta3"

    //private const val URL = "http://10.0.2.2:8080/api/reta3/"
    fun createLoginRetrofit(): Retrofit {
        return Retrofit.Builder().baseUrl(URL)
            .addConverterFactory(GsonConverterFactory.create())
            .build()
    }

    fun createAuthenticatedRetrofit(tokenProvider: () -> String?): Retrofit {
        val client = OkHttpClient.Builder()
            .addInterceptor(AuthInterceptor(tokenProvider))
            .build()
        return Retrofit.Builder()
            .baseUrl(URL)
            .client(client)
            .addConverterFactory(GsonConverterFactory.create())
            .build()
    }

    fun auth(): AuthService {
        return createLoginRetrofit().create(AuthService::class.java)
    }

    fun imagenesInteres(tokenProvider: () -> String?) =
        createAuthenticatedRetrofit(tokenProvider).create(ImagenInteresService::class.java)

    fun imagenesPeligro(tokenProvider: () -> String?) =
        createAuthenticatedRetrofit(tokenProvider).create(ImagenPeligroService::class.java)

    fun puntosInteres(tokenProvider: () -> String?) =
        createAuthenticatedRetrofit(tokenProvider).create(PuntoInteresService::class.java)

    fun puntosPeligro(tokenProvider: () -> String?) =
        createAuthenticatedRetrofit(tokenProvider).create(PuntoPeligroService::class.java)

    fun ruta(tokenProvider: () -> String?) =
        createAuthenticatedRetrofit(tokenProvider).create(RutaService::class.java)

    fun trackpoint(tokenProvider: () -> String?) =
        createAuthenticatedRetrofit(tokenProvider).create(TrackpointService::class.java)

    fun usuario(tokenProvider: () -> String?) =
        createAuthenticatedRetrofit(tokenProvider).create(UsuarioService::class.java)
}
