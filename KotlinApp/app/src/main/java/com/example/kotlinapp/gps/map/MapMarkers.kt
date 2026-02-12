package com.example.kotlinapp.gps.map

import android.content.Context
import androidx.core.content.ContextCompat
import com.example.kotlinapp.R
import org.osmdroid.views.MapView
import org.osmdroid.views.overlay.Marker

fun createCurrentLocationMarker(mapView: MapView, context: Context): Marker =
    Marker(mapView).apply {
        title = "Estás aquí"
        setAnchor(Marker.ANCHOR_CENTER, Marker.ANCHOR_BOTTOM)
        val drawable = ContextCompat.getDrawable(context, R.drawable.currentlocation)
        drawable?.setBounds(0, 0, 80, 80)
        icon = drawable
    }

fun createTrackpointMarker(mapView: MapView, context: Context, title: String): Marker =
    Marker(mapView).apply {
        this.title = title
        setAnchor(Marker.ANCHOR_CENTER, Marker.ANCHOR_BOTTOM)
        val drawable = ContextCompat.getDrawable(context, R.drawable.locationicon)
        drawable?.setBounds(0, 0, 60, 60)
        icon = drawable
    }