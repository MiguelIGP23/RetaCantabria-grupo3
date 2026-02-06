package org.example.javaapp.export;

import org.example.javaapp.model.PuntosPeligro;
import org.example.javaapp.model.Ruta;

import java.nio.charset.StandardCharsets;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.util.List;
import java.util.Locale;

public class FichaSeguridadGenerator {

    public byte[] generar(Ruta ruta, List<PuntosPeligro> puntosPeligro) {
        StringBuilder sb = new StringBuilder();

        sb.append("\t--FICHA DE SEGURIDAD--\n");

        LocalDateTime ahora = LocalDateTime.now();
        DateTimeFormatter formato = DateTimeFormatter.ofPattern("dd/MM/yyyy HH:mm:ss");
        sb.append("\t\t").append(ahora.format(formato)).append("\n\n");

        sb.append("-Nombre de la ruta: ").append(safe(ruta.getNombre())).append("\n");

        // En tu entidad actual esto se llama recomendacionesEquipo, no recomendaciones
        String reco = ruta.getRecomendacionesEquipo();
        if (reco == null || reco.isBlank()) {
            sb.append("-Recomendaciones: ninguna recomendacion\n");
        } else {
            sb.append("-Recomendaciones: ").append(reco).append("\n");
        }

        // riesgo/esfuerzo: si es null o 0 -> "sin especificar"
        String nr = (ruta.getNivelRiesgo() == null || ruta.getNivelRiesgo() == 0)
                ? "sin especificar"
                : String.valueOf(ruta.getNivelRiesgo());

        String ne = (ruta.getNivelEsfuerzo() == null || ruta.getNivelEsfuerzo() == 0)
                ? "sin especificar"
                : String.valueOf(ruta.getNivelEsfuerzo());

        sb.append("-Dificultad:\n")
                .append("\t-Nivel de riesgo: ").append(nr).append("\n")
                .append("\t-Nivel de esfuerzo: ").append(ne).append("\n\n");

        sb.append("-- PUNTOS DE PELIGRO --\n\n");

        if (puntosPeligro == null || puntosPeligro.isEmpty()) {
            sb.append("No hay puntos de peligro registrados.\n");
            return sb.toString().getBytes(StandardCharsets.UTF_8);
        }

        int cont = 1;
        for (PuntosPeligro aux : puntosPeligro) {
            sb.append("-Punto ").append(cont++).append(": ").append(safe(aux.getNombre())).append("\n");

            String lat = format4(aux.getLatitud());
            String lon = format4(aux.getLongitud());
            sb.append("\t-Coordenadas:\n")
                    .append("\t\t->Latitud: ").append(lat).append("\n")
                    .append("\t\t->Longitud: ").append(lon).append("\n");

            String kilo = (aux.getKilometros() == null || aux.getKilometros() == 0)
                    ? "sin especificar"
                    : String.valueOf(aux.getKilometros());
            sb.append("\t-Kilometro de ruta: ").append(kilo).append("\n");

            String gr = (aux.getGravedad() == null || aux.getGravedad() == 0)
                    ? "sin especificar"
                    : String.valueOf(aux.getGravedad());
            sb.append("\t-Nivel de gravedad [1-5]: ").append(gr).append("\n");

            sb.append("\t-Descripcion: ").append(safe(aux.getDescripcion())).append("\n");

            // timestamp: en tu clase antigua era minutos. Aquí asumo Integer/Long minutos.
            sb.append("\t-Duracion estimada: ").append(safeNum(aux.getTimestamp())).append(" minutos\n\n");
        }

        return sb.toString().getBytes(StandardCharsets.UTF_8);
    }

    public String nombreArchivo(Ruta ruta) {
        String nombreRuta = safe(ruta.getNombre()).replaceAll("[^a-zA-Z0-9_\\- ]", "_");
        return "ficha-seguridad_" + nombreRuta + ".txt";
    }

    private String safe(String s) {
        return s == null ? "" : s;
    }

    private String safeNum(Object n) {
        return n == null ? "sin especificar" : String.valueOf(n);
    }

    // Formatea a 4 decimales y pone . como separador
    private String format4(Double d) {
        if (d == null) return "sin especificar";
        return String.format(Locale.US, "%.4f", d);
    }
}
