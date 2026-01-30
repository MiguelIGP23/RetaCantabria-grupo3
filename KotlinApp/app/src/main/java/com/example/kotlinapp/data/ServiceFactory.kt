package com.example.kotlinapp.data

import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory

object ServiceFactory {
    private const val URL = "https://api.raspiremote.org/api/reta3"
    private val DEFAULT_BUILDER = Retrofit.Builder()
        .baseUrl(URL)
        //usar convertidor de JSON
        .addConverterFactory(GsonConverterFactory.create())

    fun makeRetrofitService(): RetrofitService {
        return DEFAULT_BUILDER.build().create(RetrofitService::class.java)
    }
}
