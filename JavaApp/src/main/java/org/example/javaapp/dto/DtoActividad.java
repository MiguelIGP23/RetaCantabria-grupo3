package org.example.javaapp.dto;

import com.fasterxml.jackson.annotation.JsonProperty;

public record DtoActividad(

        @JsonProperty("id")
        Integer id,

        @JsonProperty("nombre")
        String nombre,

        @JsonProperty("rutaId")
        Integer rutaId
        ) {
}
