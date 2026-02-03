package com.example.kotlinapp

import android.os.Build
import android.os.Bundle
import com.example.kotlinapp.views.ListView
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.annotation.RequiresApi
import androidx.compose.foundation.layout.*
import androidx.compose.material3.*
import androidx.compose.runtime.*
import androidx.compose.ui.Modifier
import com.example.kotlinapp.data.AuthRepository
import com.example.kotlinapp.data.ServiceFactory
import com.example.kotlinapp.data.SessionDataStore
import com.example.kotlinapp.navigation.NavManager

class MainActivity : ComponentActivity() {
    private lateinit var session : SessionDataStore
    private lateinit var authRepository: AuthRepository

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        session = SessionDataStore(this)
        val authRepository = AuthRepository(
            api = ServiceFactory.auth(),
            session = session
        )
        setContent {
            Scaffold { padding ->
                MainScreen(modifier = Modifier.padding(padding),authRepository)
            }
        }
    }
}


@Composable
fun MainScreen(modifier: Modifier,authRepository: AuthRepository) {
    NavManager(authRepository)
}
