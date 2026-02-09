package com.example.kotlinapp.data.room.daos

import androidx.room.Dao
import androidx.room.Insert
import androidx.room.OnConflictStrategy
import androidx.room.Query
import com.example.kotlinapp.data.room.entity.PuntoInteresEntity
import com.example.kotlinapp.data.room.entity.RutaEntity
import kotlinx.coroutines.flow.Flow

@Dao
interface PuntosInteresDao {

    @Query("SELECT * FROM puntosinteres")
    fun getAll(): Flow<List<PuntoInteresEntity>>

    @Query("SELECT * FROM puntosinteres WHERE id = :id")
    suspend fun getById(id: Int): PuntoInteresEntity?

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    suspend fun insertAll(puntosinteres: List<PuntoInteresEntity>)

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    suspend fun insert(puntosinteres: PuntoInteresEntity)

    @Query("DELETE FROM puntosinteres WHERE id = :id")
    suspend fun clear(id: Int)
}