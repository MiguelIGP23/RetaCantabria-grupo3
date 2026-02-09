package org.example.javaapp.dto;

import com.fasterxml.jackson.annotation.JsonProperty;

public record DtoImagenesInteres(
        @JsonProperty("id") Integer id,
        @JsonProperty("url") String url,
        @JsonProperty("descripcion") String descripcion,
        @JsonProperty("rutaId") Integer rutaId,
        @JsonProperty("puntosInteresId") Integer puntosInteresId
) {
}
