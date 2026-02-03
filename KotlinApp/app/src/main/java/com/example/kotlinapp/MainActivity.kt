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
import com.example.kotlinapp.navigation.NavManager

class MainActivity : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContent {
            Scaffold { padding ->
                MainScreen(modifier = Modifier.padding(padding))
            }
        }
    }
}


@Composable
fun MainScreen(modifier: Modifier) {
    NavManager()
}
