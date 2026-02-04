package com.example.kotlinapp

import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.compose.foundation.layout.*
import androidx.compose.material3.*
import androidx.compose.runtime.*
import androidx.compose.ui.Modifier
import com.example.kotlinapp.data.AuthRepository
import com.example.kotlinapp.data.ServiceFactory
import com.example.kotlinapp.data.SessionDataStore
import com.example.kotlinapp.navigation.NavManager
import com.example.kotlinapp.viewmodels.DatabaseViewModel

class MainActivity : ComponentActivity() {
    private lateinit var session : SessionDataStore
    private lateinit var dbViewModel: DatabaseViewModel

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        session = SessionDataStore(this)
        dbViewModel = DatabaseViewModel(
            AuthRepository(
                api = ServiceFactory.auth(),
                session = session
            )
        )
        setContent {
            Scaffold { padding ->
                MainScreen(modifier = Modifier.padding(padding),dbViewModel)
            }
        }
    }
}


@Composable
fun MainScreen(modifier: Modifier,databaseViewModel: DatabaseViewModel) {
    NavManager(databaseViewModel)
}
