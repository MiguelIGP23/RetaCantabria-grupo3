package com.example.kotlinapp.data.room.daos

import androidx.room.Insert
import androidx.room.OnConflictStrategy
import androidx.room.Query
import com.example.kotlinapp.data.room.entity.TrackpointEntity
import kotlinx.coroutines.flow.Flow

interface TrackpointDao {

    @Query("SELECT * FROM trackpoints")
    fun getAll(): Flow<List<TrackpointEntity>>

    @Query("SELECT * FROM trackpoints WHERE idRuta = :id")
    suspend fun getById(id: Int): TrackpointEntity?

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    suspend fun insertAll(trackpoints: List<TrackpointEntity>)

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    suspend fun insert(trackpoints: TrackpointEntity)

    @Query("DELETE FROM trackpoints WHERE idRuta = :id")
    suspend fun clear(id: Int)
}