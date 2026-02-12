package com.example.kotlinapp.data.room.daos

import androidx.room.Dao
import androidx.room.Insert
import androidx.room.OnConflictStrategy
import androidx.room.Query
import com.example.kotlinapp.data.room.entity.RutaEntity
import kotlinx.coroutines.flow.Flow

@Dao
interface RutaDao {

    @Query("SELECT * FROM rutas")
    fun getAll(): Flow<List<RutaEntity>>

    @Query("SELECT * FROM rutas WHERE estadoRuta = 1")
    fun getAllValidated(): Flow<List<RutaEntity>>

    @Query("SELECT * FROM rutas WHERE idRuta = :id")
    suspend fun getById(id: Int): RutaEntity?

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    suspend fun insertAll(rutas: List<RutaEntity>)

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    suspend fun insert(rutas: RutaEntity)

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    suspend fun insertOrUpdate(rutas: RutaEntity)

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    suspend fun insertOrUpdate(rutas: List<RutaEntity>)

    @Query("DELETE FROM rutas WHERE idRuta = :id")
    suspend fun clear(id: Int)

    @Query("DELETE FROM rutas")
    suspend fun clearAll()
}