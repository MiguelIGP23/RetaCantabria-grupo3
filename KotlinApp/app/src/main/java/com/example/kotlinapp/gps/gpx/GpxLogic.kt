package com.example.kotlinapp.gps.gpx

import android.content.Context
import android.os.Environment
import android.util.Log
import com.example.kotlinapp.model.Waypoint
import java.io.File
import kotlin.collections.forEach

fun generateGpx(trackpoints: List<Pair<Double, Double>>, waypoints: List<Waypoint>): String {
    val sb = StringBuilder()
    sb.append("""<?xml version="1.0" encoding="UTF-8"?>""")
    sb.append("\n<gpx version=\"1.1\" creator=\"KotlinApp\">\n")

    trackpoints.forEachIndexed { index, (lat, lon) ->
        sb.append("    <trkpt lat=\"$lat\" lon=\"$lon\">\n")
        sb.append("        <name>Trackpoint ${index + 1}</name>\n")
        sb.append("    </trkpt>\n")
    }

    waypoints.forEach { wp ->
        sb.append("    <wpt lat=\"${wp.lat}\" lon=\"${wp.lon}\">\n")
        sb.append("        <name>${wp.title}</name>\n")
        sb.append("        <desc>${wp.description} (${wp.type})</desc>\n")
        wp.photoPath?.let { sb.append("        <link href=\"$it\" />\n") }
        sb.append("    </wpt>\n")
    }

    sb.append("</gpx>")
    return sb.toString()
}

fun saveGpx(context: Context, trackpoints: List<Pair<Double, Double>>, waypoints: List<Waypoint>, fileName: String = "mis_puntos.gpx") {
    try {
        val downloadsDir = Environment.getExternalStoragePublicDirectory(Environment.DIRECTORY_DOWNLOADS)
        if (!downloadsDir.exists()) downloadsDir.mkdirs()
        val file = File(downloadsDir, fileName)
        file.writeText(generateGpx(trackpoints,waypoints))
        Log.d("GPX", "Archivo guardado en Descargas: ${file.absolutePath}")
    } catch (e: Exception) {
        Log.e("GPX", "Error guardando GPX en Descargas", e)
    }
}