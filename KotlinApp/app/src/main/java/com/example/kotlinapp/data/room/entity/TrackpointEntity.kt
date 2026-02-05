package com.example.kotlinapp.data.room.entity

import androidx.room.Entity
import androidx.room.ForeignKey
import androidx.room.PrimaryKey
import com.example.kotlinapp.model.Ruta

@Entity(
    tableName = "trackpoints",
    primaryKeys = ["idRuta", "posicion"],
    foreignKeys = [
        ForeignKey(
            entity = RutaEntity::class, // Use the Entity class here
            parentColumns = ["idRuta"],
            childColumns = ["idRuta"],
            onDelete = ForeignKey.CASCADE
        )
    ]
)
data class TrackpointEntity(
    val idRuta: Long,
    val posicion: Int,
    val latitud: Double,
    val longitud: Double,
    val altitud: Double,
    val time: Long
)