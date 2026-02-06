package com.example.kotlinapp.data.room.daos

import androidx.room.Insert
import androidx.room.OnConflictStrategy
import androidx.room.Query
import com.example.kotlinapp.data.room.entity.ImagenPeligroEntity
import kotlinx.coroutines.flow.Flow

interface ImagenPeligroDao {

    @Query("SELECT * FROM imagenesPeligro")
    fun getAll(): Flow<List<ImagenPeligroEntity>>

    @Query("SELECT * FROM imagenesPeligro WHERE idimagenespeligro = :id")
    suspend fun getById(id: Int): ImagenPeligroEntity?

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    suspend fun insertAll(imagenesPeligro: List<ImagenPeligroEntity>)

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    suspend fun insert(imagenesPeligro: ImagenPeligroEntity)

    @Query("DELETE FROM imagenesPeligro WHERE idimagenespeligro = :id")
    suspend fun clear(id: Int)
}