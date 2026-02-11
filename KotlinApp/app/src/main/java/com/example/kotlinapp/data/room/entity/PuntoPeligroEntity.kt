package com.example.kotlinapp.data.room.entity

import androidx.room.Entity
import androidx.room.ForeignKey
import androidx.room.Index
import androidx.room.PrimaryKey
import com.example.kotlinapp.data.IdRef
import com.example.kotlinapp.model.Ruta

@Entity(
    tableName = "puntospeligro",
    foreignKeys = [
        ForeignKey(
            entity = RutaEntity::class,
            parentColumns = ["idRuta"],
            childColumns = ["rutaId"],
            onDelete = ForeignKey.CASCADE
        )
    ],
    indices = [Index("rutaId")]
)
data class PuntoPeligroEntity(
    @PrimaryKey
    val id: Int?,
    val nombre: String,
    val latitud: Double,
    val longitud: Double,
    val elevacion: Double,
    val kilometros: Double?,
    val gravedad: Byte?,
    val descripcion: String?,
    val timestamp: Long,
    val rutaId: Int
)