package com.example.kotlinapp.data

import com.example.kotlinapp.model.Usuario
import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory

object ServiceFactory {
    private const val URL = "https://api.raspiremote.org/api/reta3"
    private val DEFAULT_BUILDER = Retrofit.Builder()
        .baseUrl(URL)
        //usar convertidor de JSON
        .addConverterFactory(GsonConverterFactory.create())

    fun imagenesInteres(): ImagenesInteresService {
        return DEFAULT_BUILDER.build().create(ImagenesInteresService::class.java)
    }
    fun imagenesPeligro(): ImagenesPeligroService {
        return DEFAULT_BUILDER.build().create(ImagenesPeligroService::class.java)
    }
    fun puntosInteres(): PuntosInteresService {
        return DEFAULT_BUILDER.build().create(PuntosInteresService::class.java)
    }
    fun puntosPeligro(): PuntosPeligroService {
        return DEFAULT_BUILDER.build().create(PuntosPeligroService::class.java)
    }
    fun ruta(): ImagenesInteresService {
        return DEFAULT_BUILDER.build().create(ImagenesInteresService::class.java)
    }
    fun trackpoint(): TrackpointService {
        return DEFAULT_BUILDER.build().create(TrackpointService::class.java)
    }
    fun usuario(): UsuarioService {
        return DEFAULT_BUILDER.build().create(UsuarioService::class.java)
    }
}
