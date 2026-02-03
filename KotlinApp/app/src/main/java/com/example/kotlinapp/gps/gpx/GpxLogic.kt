package com.example.kotlinapp.gps.gpx

import android.content.Context
import android.util.Log
import androidx.activity.compose.rememberLauncherForActivityResult
import androidx.activity.result.contract.ActivityResultContracts
import androidx.compose.runtime.Composable
import androidx.compose.runtime.snapshots.SnapshotStateList
import com.example.kotlinapp.model.Ruta
import com.example.kotlinapp.model.Trackpoint
import com.example.kotlinapp.model.Waypoint
import kotlin.collections.forEach

fun generateGpx(
    ruta: Ruta,
    trackpoints: List<Trackpoint>,
    waypoints: List<Waypoint>
): String {
    val sb = StringBuilder()
    sb.append("""<?xml version="1.0" encoding="UTF-8"?>""")
    sb.append("\n<gpx version=\"1.1\" creator=\"KotlinApp\">\n")

    // Metadata
    sb.append("  <metadata>\n")
    sb.append("    <name>${ruta.nombre}</name>\n")
    sb.append("    <desc>${ruta.recomendacionesEquipo ?: "No hay recomendaciones"}</desc>\n")
    sb.append("    <author>${ruta.usuario ?: "Desconocido"}</author>\n")
    sb.append("    <time>${trackpoints.firstOrNull()?.time?.let { epochToIso(it) } ?: ""}</time>\n")
    sb.append("  </metadata>\n")

    // Trackpoints
    sb.append("  <trk>\n")
    sb.append("    <name>${ruta.nombre}</name>\n")
    sb.append("    <trkseg>\n")
    trackpoints.forEachIndexed { index, tp ->
        sb.append("      <trkpt lat=\"${tp.latitud}\" lon=\"${tp.longitud}\">\n")
        sb.append("        <ele>${tp.altitud}</ele>\n")
        sb.append("        <time>${epochToIso(tp.time)}</time>\n")
        sb.append("        <name>Trackpoint ${index + 1}</name>\n")
        sb.append("      </trkpt>\n")
    }
    sb.append("    </trkseg>\n")
    sb.append("  </trk>\n")

    // Waypoints
    waypoints.forEach { wp ->
        sb.append("  <wpt lat=\"${wp.lat}\" lon=\"${wp.lon}\">\n")
        sb.append("    <ele>${wp.elevation ?: 0.0}</ele>\n")
        sb.append("    <name>${wp.title}</name>\n")
        sb.append("    <desc>${wp.description} (${wp.type})</desc>\n")
        wp.photoPath?.let { sb.append("    <link href=\"$it\" />\n") }
        sb.append("  </wpt>\n")
    }

    // Extensiones
    sb.append("  <extensions>\n")
    sb.append("    <nivelEsfuerzo>${ruta.nivelEsfuerzo ?: 0}</nivelEsfuerzo>\n")
    sb.append("    <nivelRiesgo>${ruta.nivelRiesgo ?: 0}</nivelRiesgo>\n")
    sb.append("    <tipoTerreno>${ruta.tipoTerreno ?: 0}</tipoTerreno>\n")
    sb.append("    <temporada>${ruta.temporadas ?: "No especificada"}</temporada>\n")
    sb.append("    <accesibilidad>${ruta.accesibilidad ?: false}</accesibilidad>\n")
    sb.append("    <rutaFamiliar>${ruta.rutaFamiliar ?: false}</rutaFamiliar>\n")
    sb.append("  </extensions>\n")

    sb.append("</gpx>")
    return sb.toString()
}

// Función para convertir milisegundos a ISO 8601
fun epochToIso(time: Long): String {
    val instant = java.time.Instant.ofEpochMilli(time)
    return java.time.format.DateTimeFormatter.ISO_INSTANT.format(instant)
}

@Composable
fun createGpxLauncher(
    context: Context,
    gpxContent: String
) = rememberLauncherForActivityResult(
    contract = ActivityResultContracts.CreateDocument("application/gpx+xml")
) { uri ->
    if (uri != null) {
        try {
            context.contentResolver.openOutputStream(uri)?.use { output ->
                output.write(gpxContent.toByteArray())
            }
            Log.d("GPX", "GPX guardado correctamente")
        } catch (e: Exception) {
            Log.e("GPX", "Error guardando GPX", e)
        }
    }
}