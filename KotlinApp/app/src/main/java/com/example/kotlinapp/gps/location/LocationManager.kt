package com.example.kotlinapp.gps.location

import android.Manifest
import android.content.Context
import android.content.pm.PackageManager
import android.os.Looper
import androidx.compose.runtime.MutableState
import androidx.core.content.ContextCompat
import com.google.android.gms.location.FusedLocationProviderClient
import com.google.android.gms.location.LocationCallback
import com.google.android.gms.location.LocationRequest

class LocationManager(
    private val client: FusedLocationProviderClient,
    private val request: LocationRequest,
    private val callback: LocationCallback,
    private val isTracking: MutableState<Boolean>
) {
    fun start(context: Context) {
        if (ContextCompat.checkSelfPermission(context, Manifest.permission.ACCESS_FINE_LOCATION) == PackageManager.PERMISSION_GRANTED) {
            client.requestLocationUpdates(request, callback, Looper.getMainLooper())
            isTracking.value = true
        }
    }

    fun stop() { client.removeLocationUpdates(callback) }
}