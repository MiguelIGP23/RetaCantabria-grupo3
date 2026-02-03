package org.example.javaapp.export;

import org.example.javaapp.model.Ruta;

import java.nio.charset.StandardCharsets;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;

public class FichaOrganizacionGenerator {

    public byte[] generar(Ruta ruta) {
        StringBuilder sb = new StringBuilder();
        LocalDateTime ahora = LocalDateTime.now();
        DateTimeFormatter formato = DateTimeFormatter.ofPattern("dd/MM/yyyy HH:mm:ss");

        sb.append("\t--FICHA DE ORGANIZACION--\n");
        sb.append("\t\t").append(ahora.format(formato)).append("\n\n");
        sb.append("-Nombre de la ruta: ").append(safe(ruta.getNombre())).append("\n");
        sb.append("-Coordenadas iniciales:\n\t-Latitud: ").append(ruta.getLatitudInicial())
                .append("\n\t-Longitud: ").append(ruta.getLongitudInicial()).append("\n");
        sb.append("-Coordenadas finales:\n\t-Latitud: ").append(ruta.getLatitudFinal())
                .append("\n\t-Longitud: ").append(ruta.getLongitudFinal()).append("\n");
        sb.append("-Dificultad:\n\t-Nivel de riesgo: ").append(ruta.getNivelRiesgo())
                .append("\n\t-Nivel de esfuerzo: ").append(ruta.getNivelEsfuerzo()).append("\n");
        sb.append("-Inicio de la ruta: ").append(safe(ruta.getNombreInicioruta())).append("\n");
        sb.append("-Fin de la ruta: ").append(safe(ruta.getNombreFinalruta())).append("\n");

        return sb.toString().getBytes(StandardCharsets.UTF_8);
    }

    public String nombreArchivo(Ruta ruta) {
        String nombreRuta = safe(ruta.getNombre()).replaceAll("[^a-zA-Z0-9_\\- ]", "_");
        return "ficha-organizacion_" + nombreRuta + ".txt";
    }

    private String safe(String s) {
        return s != null ? s : "";
    }
}
