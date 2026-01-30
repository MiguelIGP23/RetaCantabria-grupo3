package com.example.kotlinapp.data

import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory

object ServiceFactory {
    private const val URL = "https://api.raspiremote.org/api/reta3"
    private val DEFAULT_BUILDER = Retrofit.Builder()
        .baseUrl(URL)
        //usar convertidor de JSON
        .addConverterFactory(GsonConverterFactory.create())

    fun imagenesInteres(): ImagenInteresService {
        return DEFAULT_BUILDER.build().create(ImagenInteresService::class.java)
    }
    fun imagenesPeligro(): ImagenPeligroService {
        return DEFAULT_BUILDER.build().create(ImagenPeligroService::class.java)
    }
    fun puntosInteres(): PuntoInteresService {
        return DEFAULT_BUILDER.build().create(PuntoInteresService::class.java)
    }
    fun puntosPeligro(): PuntoPeligroService {
        return DEFAULT_BUILDER.build().create(PuntoPeligroService::class.java)
    }
    fun ruta(): ImagenInteresService {
        return DEFAULT_BUILDER.build().create(ImagenInteresService::class.java)
    }
    fun trackpoint(): TrackpointService {
        return DEFAULT_BUILDER.build().create(TrackpointService::class.java)
    }
    fun usuario(): UsuarioService {
        return DEFAULT_BUILDER.build().create(UsuarioService::class.java)
    }
}
