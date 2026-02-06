package com.example.kotlinapp.data.room.daos

import androidx.room.Insert
import androidx.room.OnConflictStrategy
import androidx.room.Query
import com.example.kotlinapp.data.room.entity.ImagenInteresEntity
import kotlinx.coroutines.flow.Flow

interface ImagenInteresDao {
    
    @Query("SELECT * FROM imagenesInteres")
    fun getAll(): Flow<List<ImagenInteresEntity>>

    @Query("SELECT * FROM imagenesInteres WHERE idimagenesinteres = :id")
    suspend fun getById(id: Int): ImagenInteresEntity?

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    suspend fun insertAll(imagenesInteres: List<ImagenInteresEntity>)

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    suspend fun insert(imagenesInteres: ImagenInteresEntity)

    @Query("DELETE FROM imagenesInteres WHERE idimagenesinteres = :id")
    suspend fun clear(id: Int)
}