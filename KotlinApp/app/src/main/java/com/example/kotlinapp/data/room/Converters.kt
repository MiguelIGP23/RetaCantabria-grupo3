package com.example.kotlinapp.data.room

import androidx.room.TypeConverter
import com.example.kotlinapp.data.IdRef
import com.example.kotlinapp.model.enums.Clasificacion
import com.example.kotlinapp.model.enums.Rol
import com.example.kotlinapp.model.enums.TipoPunto
import com.example.kotlinapp.model.enums.WaypointType

class Converters {

    // IdRef <-> Int
    @TypeConverter
    fun fromIdRef(idRef: IdRef?): Int? = idRef?.id

    @TypeConverter
    fun toIdRef(id: Int?): IdRef? = id?.let { IdRef(it) }


    @TypeConverter
    fun toWaypointType(value: String?): WaypointType? =
        value?.let { WaypointType.valueOf(it) }

    @TypeConverter
    fun toTipoPunto(value: String?): TipoPunto? =
        value?.let { TipoPunto.valueOf(it) }

    @TypeConverter
    fun fromClasificacion(value: Clasificacion?): String? = value?.name

    @TypeConverter
    fun toClasificacion(value: String?): Clasificacion? =
        value?.let { Clasificacion.valueOf(it) }

    @TypeConverter
    fun fromRol(rol: Rol): String = rol.name

    @TypeConverter
    fun toRol(value: String): Rol = Rol.valueOf(value)
}
