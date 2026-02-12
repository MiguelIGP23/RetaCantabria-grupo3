package org.example.javaapp.dto;

import com.fasterxml.jackson.annotation.JsonProperty;

import java.time.LocalDate;
import java.time.LocalTime;

public record DtoCalendario(
        @JsonProperty("id") Integer id,
        @JsonProperty("fecha") LocalDate fecha,
        @JsonProperty("hora_inicio") LocalTime horaInicio,
        @JsonProperty("info") String info,
        @JsonProperty("rutaId") Integer rutaId,
        @JsonProperty("usuarioId") Integer usuarioId
) {}
