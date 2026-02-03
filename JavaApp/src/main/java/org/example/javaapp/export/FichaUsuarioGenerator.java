package org.example.javaapp.export;

import org.example.javaapp.model.PuntosInteres;
import org.example.javaapp.model.PuntosPeligro;
import org.example.javaapp.model.Ruta;
import org.example.javaapp.model.TipoPunto;

import java.nio.charset.StandardCharsets;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.util.List;
import java.util.Locale;

public class FichaUsuarioGenerator {

    public byte[] generar(Ruta ruta,
                          List<PuntosInteres> puntosInteres,
                          List<PuntosPeligro> puntosPeligro) {

        StringBuilder sb = new StringBuilder();

        sb.append("\t--FICHA DE USUARIO--\n");

        LocalDateTime ahora = LocalDateTime.now();
        DateTimeFormatter formato = DateTimeFormatter.ofPattern("dd/MM/yyyy HH:mm:ss");
        sb.append("\t\t").append(ahora.format(formato)).append("\n\n");

        sb.append("-Nombre de ruta: ").append(safe(ruta.getNombre())).append("\n");
        sb.append("-Inicio de la ruta: ").append(safe(ruta.getNombreInicioruta())).append("\n");
        sb.append("-Fin de la ruta: ").append(safe(ruta.getNombreFinalruta())).append("\n");

        sb.append("-Coordenadas iniciales:\n\t-Latitud: ").append(num(ruta.getLatitudInicial()))
                .append("\n\t-Longitud: ").append(num(ruta.getLongitudInicial())).append("\n");

        sb.append("-Coordenadas finales:\n\t-Latitud: ").append(num(ruta.getLatitudFinal()))
                .append("\n\t-Longitud: ").append(num(ruta.getLongitudFinal())).append("\n");

        sb.append("-Duracion estimada: ").append(formatDuracion(ruta)).append("\n");
        sb.append("-Distancia : ").append(num(ruta.getDistancia())).append(" km\n");

        // En tu modelo actual temporadas es String
        String temporadas = ruta.getTemporadas();
        if (temporadas == null || temporadas.isBlank()) {
            sb.append("-Temporadas: no especificadas\n");
        } else {
            sb.append("-Temporadas: ").append(temporadas).append("\n");
        }

        sb.append("-Accesible: ").append(siNoByte(ruta.getAccesibilidad())).append("\n");
        sb.append("-Familiar: ").append(siNoByte(ruta.getRutaFamiliar())).append("\n");

        // En tu modelo actual recomendaciones es recomendacionesEquipo
        String recom = ruta.getRecomendacionesEquipo();
        if (recom == null || recom.isBlank()) {
            sb.append("-Recomendaciones: ninguna recomendacion\n");
        } else {
            sb.append("-Recomendaciones: ").append(recom).append("\n");
        }

        sb.append("\n-- PUNTOS DE INTERES --\n\n");

        if (puntosInteres == null || puntosInteres.isEmpty()) {
            sb.append("No hay puntos de interes registrados.\n\n");
        } else {
            int cont = 1;
            for (PuntosInteres aux : puntosInteres) {
                sb.append("*Punto ").append(cont++).append(": ").append(safe(aux.getNombre())).append("\n");

                sb.append("\t-Coordenadas:\n")
                        .append("\t\t-Latitud: ").append(format4(aux.getLatitud())).append("\n")
                        .append("\t\t-Longitud: ").append(format4(aux.getLongitud())).append("\n");

                String carac = aux.getCaracteristicas();
                sb.append("\t-Caracteristicas: ")
                        .append((carac == null || carac.isBlank()) ? "ninguna indicada" : carac)
                        .append("\n");

                // tipo: depende de tu modelo (enum o String). Si no existe, quita este bloque.
                TipoPunto tipo = aux.getTipo();
                sb.append("\t-Tipo: ")
                        .append(tipo == null ? "no indicado" : String.valueOf(tipo))
                        .append("\n");

                sb.append("\t-Descripcion: ").append(safe(aux.getDescripcion())).append("\n");
                sb.append("\t-Elevacion: ").append(num(aux.getElevacion())).append(" metros\n");

                // timestamp llegada aproximada (min)
                Integer ts = aux.getTimestamp();
                sb.append("\t-Llegada aproximada: ")
                        .append((ts == null || ts == 0) ? "no indicado" : (ts + " min"))
                        .append("\n\n");
            }
        }

        sb.append("-- PUNTOS DE PELIGRO --\n\n");

        if (puntosPeligro == null || puntosPeligro.isEmpty()) {
            sb.append("No hay puntos de peligro registrados.\n");
        } else {
            int cont = 1;
            for (PuntosPeligro aux : puntosPeligro) {
                sb.append("-Punto ").append(cont++).append(": ").append(safe(aux.getNombre())).append("\n");

                sb.append("\t-Coordenadas:\n")
                        .append("\t\t->Latitud: ").append(format4(aux.getLatitud())).append("\n")
                        .append("\t\t->Longitud: ").append(format4(aux.getLongitud())).append("\n\n");

                Double km = aux.getKilometros();
                sb.append("\t-Longitud de la ruta: ")
                        .append((km == null || km == 0) ? "sin especificar" : (km + " km"))
                        .append("\n");

                Byte grav = aux.getGravedad();
                sb.append("\t-Nivel de gravedad [1-5]: ")
                        .append((grav == null || grav == 0) ? "sin especificar" : grav)
                        .append("\n");

                sb.append("\t-Descripcion: ").append(safe(aux.getDescripcion())).append("\n");

                Integer dur = aux.getTimestamp();
                sb.append("\t-Duracion estimada: ")
                        .append((dur == null || dur == 0) ? "sin especificar" : (dur + " minutos"))
                        .append("\n\n");
            }
        }

        return sb.toString().getBytes(StandardCharsets.UTF_8);
    }

    public String nombreArchivo(Ruta ruta) {
        String nombreRuta = safe(ruta.getNombre()).replaceAll("[^a-zA-Z0-9_\\- ]", "_");
        return "ficha-usuario_" + nombreRuta + ".txt";
    }

    // ===== Formateo de texto =====

    private String safe(String s) { return s == null ? "" : s; }

    private String num(Object n) { return n == null ? "sin especificar" : String.valueOf(n); }

    private String siNoByte(Byte b) {
        if (b == null) return "no especificado";
        return (b != 0) ? "si" : "no";
    }

    private String format4(Double d) {
        if (d == null) return "sin especificar";
        return String.format(Locale.US, "%.4f", d);
    }

    private String formatDuracion(Ruta ruta) {
        if (ruta.getDuracion() == null) return "sin especificar";
        int horas = ruta.getDuracion().getHour();
        int minutos = ruta.getDuracion().getMinute();
        if (horas == 0) return minutos + " min";
        return horas + " h, " + minutos + " min";
    }
}
