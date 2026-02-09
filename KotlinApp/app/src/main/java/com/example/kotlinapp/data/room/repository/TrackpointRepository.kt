package com.example.kotlinapp.data.room.repository

import android.util.Log
import com.example.kotlinapp.data.room.daos.TrackpointDao
import com.example.kotlinapp.data.room.entity.TrackpointEntity
import com.example.kotlinapp.data.room.mappers.toDomain
import com.example.kotlinapp.data.room.mappers.toEntity
import com.example.kotlinapp.data.services.TrackpointService
import com.example.kotlinapp.model.Trackpoint
import kotlinx.coroutines.flow.Flow
import kotlinx.coroutines.flow.map

class TrackpointRepository(
    private val api: TrackpointService,
    private val dao: TrackpointDao
) {
    fun getTrackpoints(): Flow<List<Trackpoint>> = dao.getAll()
        .map { list -> list.map { it.toDomain() } }

    suspend fun insertTrackpoint(trackpoint: Trackpoint) {
        dao.insert(trackpoint.toEntity())
    }

    suspend fun syncTrackpoints() {
        val response = api.findAll()
        Log.d("TRACKPOINTS", "code=${response.code()} body=${response.body()}")
        if (response.isSuccessful) {
            response.body()?.let { points ->
                dao.insertAll(points.map { it.toEntity() })
            }
        }
    }
}
