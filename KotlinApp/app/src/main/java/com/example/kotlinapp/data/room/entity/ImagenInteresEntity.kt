package com.example.kotlinapp.data.room.entity

import androidx.room.Entity
import androidx.room.ForeignKey
import androidx.room.Index
import androidx.room.PrimaryKey
import com.example.kotlinapp.data.IdRef
import com.google.gson.annotations.SerializedName

@Entity(
    tableName = "imagenesInteres",
    foreignKeys = [
        ForeignKey(
            entity = PuntoInteresEntity::class,
            parentColumns = ["id"],
            childColumns = ["puntosinteres_idPuntosinteres"],
            onDelete = ForeignKey.CASCADE
        )
    ],
    indices = [Index("puntosinteres_idPuntosinteres")]
)
data class ImagenInteresEntity(
    @PrimaryKey(autoGenerate = true) val idimagenesinteres: Int? = null,
    val url: String,
    val descripcion: String?,
    @SerializedName("puntosInteres")
    val puntosinteres_idPuntosinteres: Int
)