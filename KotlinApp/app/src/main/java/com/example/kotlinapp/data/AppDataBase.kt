package com.example.kotlinapp.data

import androidx.room.Database;
import androidx.room.RoomDatabase;


@Database(
    // Se agregan la entidades
    //entities = [Ruta::class, PuntosInteres::class,Usuario::class],
    // Cambiar este número si se modifica la estructura de la DB
    version = 1
)
abstract class AppDatabase : RoomDatabase() {
    // abstract fun usuarioDao(): UsuarioDao
    // abstract fun puntosInteresDao(): PuntosInteresDao
    // abstract fun rutaDao(): RutaDao
}