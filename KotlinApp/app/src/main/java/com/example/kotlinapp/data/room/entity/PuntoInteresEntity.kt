package com.example.kotlinapp.data.room.entity

import androidx.room.Entity
import androidx.room.ForeignKey
import androidx.room.Index
import androidx.room.PrimaryKey
import com.example.kotlinapp.data.IdRef
import com.example.kotlinapp.model.Ruta
import com.example.kotlinapp.model.enums.TipoPunto

@Entity(
    tableName = "puntosinteres",
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
data class PuntoInteresEntity(
    @PrimaryKey
    val id: Int?,
    val nombre: String,
    val latitud: Double,
    val longitud: Double,
    val elevacion: Double,
    val caracteristicas: String?,
    val tipo: TipoPunto?,
    val descripcion: String?,
    val timestamp: Int?,
    val rutaId: Int
)
