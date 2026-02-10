package com.example.kotlinapp.gps.gpx

import android.content.Context
import android.content.Intent
import android.net.Uri
import android.util.Log
import androidx.activity.compose.rememberLauncherForActivityResult
import androidx.activity.result.ActivityResultLauncher
import androidx.activity.result.contract.ActivityResultContracts
import androidx.compose.runtime.Composable
import androidx.compose.runtime.snapshots.SnapshotStateList
import com.example.kotlinapp.data.IdRef
import com.example.kotlinapp.model.Ruta
import com.example.kotlinapp.model.Trackpoint
import com.example.kotlinapp.model.Waypoint
import com.example.kotlinapp.model.enums.Clasificacion
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
    sb.append("    <trkseg>\n")
    trackpoints.forEachIndexed { index, tp ->
        sb.append("      <trkpt lat=\"${tp.latitud}\" lon=\"${tp.longitud}\">\n")
        sb.append("        <ele>${tp.altitud}</ele>\n")
        sb.append("        <time>${epochToIso(tp.time)}</time>\n")
        sb.append("        <name>${index + 1}</name>\n")
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
    val sdf = java.text.SimpleDateFormat(
        "yyyy-MM-dd'T'HH:mm:ss'Z'",
        java.util.Locale.US
    )
    sdf.timeZone = java.util.TimeZone.getTimeZone("UTC")
    return sdf.format(java.util.Date(time))
}

@Composable
fun rememberGpxLauncher(
    context: Context,
    getGpxContent: () -> String // <-- pasamos una función que obtiene siempre el valor actual
): ActivityResultLauncher<String> {
    return rememberLauncherForActivityResult(
        contract = ActivityResultContracts.CreateDocument("application/gpx+xml")
    ) { uri ->
        if (uri != null) {
            try {
                context.contentResolver.openOutputStream(uri)?.use { output ->
                    output.write(getGpxContent().toByteArray())
                }
                Log.d("GPX", "GPX guardado correctamente")
            } catch (e: Exception) {
                Log.e("GPX", "Error guardando GPX", e)
            }
        }
    }
}

fun importarGpx(
    context: Context,
    uri: Uri
): Ruta? {
    context.contentResolver.takePersistableUriPermission(
        uri,
        Intent.FLAG_GRANT_READ_URI_PERMISSION
    )

    val gpxContent = context.contentResolver
        .openInputStream(uri)
        ?.bufferedReader()
        ?.use { it.readText() }
        ?: return null

    return Ruta(
        id = -1,
        nombre = "Ruta importada",
        nombreInicioruta = "Inicio GPX",
        nombreFinalruta = "Final GPX",
        latitudInicial = 0.0,
        latitudFinal = 0.0,
        longitudInicial = 0.0,
        longitudFinal = 0.0,
        distancia = 0.0,
        duracion = "",
        desnivelPositivo = 0,
        desnivelNegativo = 0,
        altitudMax = 0.0,
        altitudMin = 0.0,
        clasificacion = Clasificacion.CIRCULAR,
        nivelEsfuerzo = 0,
        nivelRiesgo = 0,
        estadoRuta = 1,
        tipoTerreno = 1,
        indicaciones = 1,
        temporadas = "",
        accesibilidad = 0,
        rutaFamiliar = 0,
        archivoGPX = gpxContent,
        recomendacionesEquipo = "",
        zonaGeografica = "",
        mediaEstrellas = 0.0,
        usuario = IdRef(1)
    )
}



