package org.example.javaapp.dto;

import com.fasterxml.jackson.annotation.JsonProperty;

public record DtoPuntosPeligro(
        @JsonProperty("id") Integer id,
        @JsonProperty("nombre") String nombre,
        @JsonProperty("latitud") Double latitud,
        @JsonProperty("longitud") Double longitud,
        @JsonProperty("elevacion") Double elevacion,
        @JsonProperty("kilometros") Double kilometros,
        @JsonProperty("gravedad") Byte gravedad,
        @JsonProperty("posicion") Integer posicion,
        @JsonProperty("descripcion") String descripcion,
        @JsonProperty("timestamp") Integer timestamp,
        @JsonProperty("rutaId") Integer rutaId
) {
}
