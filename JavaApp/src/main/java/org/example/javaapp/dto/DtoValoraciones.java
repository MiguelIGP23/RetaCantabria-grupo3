package org.example.javaapp.dto;

import com.fasterxml.jackson.annotation.JsonProperty;

import java.time.LocalDate;

public record DtoValoraciones(
        @JsonProperty("id") Integer id,
        @JsonProperty("dificultad") Byte dificultad,
        @JsonProperty("fecha") LocalDate fecha,
        @JsonProperty("estrellas") Byte estrellas,
        @JsonProperty("interesCultural") Byte interesCultural,
        @JsonProperty("belleza") Byte belleza,
        @JsonProperty("valoracionTecnica") String valoracionTecnica,
        @JsonProperty("resena") String resena,
        @JsonProperty("usuarioId") Integer usuarioId,
        @JsonProperty("rutaId") Integer rutaId
) {
}
