package org.example.javaapp.dto;

import com.fasterxml.jackson.annotation.JsonProperty;

import java.time.LocalTime;

public record DtoTrackpoints(
        @JsonProperty("idRuta") Integer idRuta,
        @JsonProperty("posicion") Integer posicion,
        @JsonProperty("latitud") Double latitud,
        @JsonProperty("longitud") Double longitud,
        @JsonProperty("elevacion") Double elevacion,
        @JsonProperty("time") LocalTime time
) {
}
