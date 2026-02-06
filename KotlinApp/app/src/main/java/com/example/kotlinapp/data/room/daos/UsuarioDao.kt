package com.example.kotlinapp.data.room.daos

import androidx.room.Dao
import androidx.room.Insert
import androidx.room.OnConflictStrategy
import androidx.room.Query
import com.example.kotlinapp.data.room.entity.PuntoInteresEntity
import com.example.kotlinapp.data.room.entity.UsuarioEntity
import kotlinx.coroutines.flow.Flow

@Dao
interface UsuarioDao {

    @Query("SELECT * FROM usuario")
    fun getAll(): Flow<List<UsuarioEntity>>

    @Query("SELECT * FROM usuario WHERE idUsuario = :id")
    suspend fun getById(id: Int): UsuarioEntity?

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    suspend fun insertAll(usuario: List<UsuarioEntity>)

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    suspend fun insert(usuario: UsuarioEntity)

    @Query("DELETE FROM usuario WHERE idUsuario = :id")
    suspend fun clear(id: Int)
}