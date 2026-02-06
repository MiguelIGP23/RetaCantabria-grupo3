package com.example.kotlinapp.data

import android.content.Context
import android.util.Log
import androidx.room.Database
import androidx.room.Room
import androidx.room.RoomDatabase
import androidx.room.TypeConverters
import androidx.sqlite.db.SupportSQLiteDatabase
import com.example.kotlinapp.data.room.Converters
import com.example.kotlinapp.data.room.daos.RutaDao
import com.example.kotlinapp.data.room.entity.ImagenInteresEntity
import com.example.kotlinapp.data.room.entity.ImagenPeligroEntity
import com.example.kotlinapp.data.room.entity.PuntoInteresEntity
import com.example.kotlinapp.data.room.entity.PuntoPeligroEntity
import com.example.kotlinapp.data.room.entity.RutaEntity
import com.example.kotlinapp.data.room.entity.TrackpointEntity
import com.example.kotlinapp.data.room.entity.UsuarioEntity
import java.util.concurrent.Executors

@Database(
    entities = [
        RutaEntity::class,
        TrackpointEntity::class,
        PuntoInteresEntity::class,
        PuntoPeligroEntity::class,
        ImagenInteresEntity::class,
        ImagenPeligroEntity::class,
        UsuarioEntity::class
    ],
    version = 3,
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
                )
                    .setQueryCallback(
                        { sql, args ->
                            Log.d("SQL", "Query: $sql | Args: $args")
                        },
                        Executors.newSingleThreadExecutor()
                    )
                    .fallbackToDestructiveMigration()
                    .addCallback(
                        object : RoomDatabase.Callback() {
                            override fun onCreate(db: SupportSQLiteDatabase) {
                                super.onCreate(db)
                                Log.d("ROOM", "Base de datos creada correctamente")
                            }
                        }
                    )
                    .build()

                INSTANCE = instance
                instance
            }
        }
    }
}
