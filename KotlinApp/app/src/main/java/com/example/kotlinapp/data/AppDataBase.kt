package com.example.kotlinapp.data

import androidx.room.Database;
import androidx.room.RoomDatabase;
import com.example.kotlinapp.model.PuntoInteres
import com.example.kotlinapp.model.Ruta
import com.example.kotlinapp.model.Usuario


@Database(
    // Se agregan la entidades
    entities = [Ruta::class, PuntoInteres::class,Usuario::class],
    // Cambiar este número si se modifica la estructura de la DB
    version = 1
)
abstract class AppDatabase : RoomDatabase() {
     abstract fun usuarioDao(): UsuarioDao
     abstract fun puntosInteresDao(): PuntosInteresDao
     abstract fun rutaDao(): RutaDao
}