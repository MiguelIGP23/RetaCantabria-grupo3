package com.example.kotlinapp.data.room.daos

import androidx.room.Insert
import androidx.room.OnConflictStrategy
import androidx.room.Query
import com.example.kotlinapp.data.room.entity.PuntoPeligroEntity
import kotlinx.coroutines.flow.Flow

interface PuntosPeligroDao {

    @Query("SELECT * FROM puntospeligro")
    fun getAll(): Flow<List<PuntoPeligroEntity>>

    @Query("SELECT * FROM puntospeligro WHERE id = :id")
    suspend fun getById(id: Int): PuntoPeligroEntity?

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    suspend fun insertAll(puntospeligro: List<PuntoPeligroEntity>)

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    suspend fun insert(puntospeligro: PuntoPeligroEntity)

    @Query("DELETE FROM puntospeligro WHERE id = :id")
    suspend fun clear(id: Int)
}