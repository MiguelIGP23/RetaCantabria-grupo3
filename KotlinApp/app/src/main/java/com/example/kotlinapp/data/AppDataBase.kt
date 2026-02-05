package com.example.kotlinapp.data

import android.content.Context
import androidx.room.Database
import androidx.room.Room
import androidx.room.RoomDatabase
import androidx.room.TypeConverters
import com.example.kotlinapp.data.room.Converters
import com.example.kotlinapp.data.room.daos.RutaDao
import com.example.kotlinapp.data.room.entity.PuntoInteresEntity
import com.example.kotlinapp.data.room.entity.PuntoPeligroEntity
import com.example.kotlinapp.data.room.entity.RutaEntity
import com.example.kotlinapp.data.room.entity.TrackpointEntity

@Database(
    entities = [
        RutaEntity::class,
        TrackpointEntity::class,
        PuntoInteresEntity::class,
        PuntoPeligroEntity::class
    ],
    version = 1,
    exportSchema = false
)
@TypeConverters(Converters::class)
abstract class AppDatabase : RoomDatabase() {

    abstract fun rutaDao(): RutaDao

    companion object {
        @Volatile
        private var INSTANCE: AppDatabase? = null

        fun getDatabase(context: Context): AppDatabase {
            return INSTANCE ?: synchronized(this) {
                val instance = Room.databaseBuilder(
                    context.applicationContext,
                    AppDatabase::class.java,
                    "app_database"
                ).build()
                INSTANCE = instance
                instance
            }
        }
    }
}
