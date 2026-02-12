package com.example.kotlinapp.data.room.entity

import androidx.room.Entity
import androidx.room.ForeignKey
import androidx.room.Index
import androidx.room.PrimaryKey
import com.example.kotlinapp.data.IdRef

@Entity(
    tableName = "imagenesPeligro",
    foreignKeys = [
        ForeignKey(
            entity = PuntoPeligroEntity::class,
            parentColumns = ["id"],
            childColumns = ["puntospeligro_idPuntospeligro"],
            onDelete = ForeignKey.CASCADE
        )
    ],
    indices = [Index("puntospeligro_idPuntospeligro")]
)
data class ImagenPeligroEntity(
    @PrimaryKey(autoGenerate = true) val idimagenespeligro: Int? = null,
    val url: String,
    val descripcion: String?,
    val puntospeligro_idPuntospeligro: Int
)