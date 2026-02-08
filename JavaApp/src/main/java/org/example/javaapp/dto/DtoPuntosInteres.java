package org.example.javaapp.dto;

import com.fasterxml.jackson.annotation.JsonProperty;
import org.example.javaapp.model.TipoPunto;

public record DtoPuntosInteres(

        @JsonProperty("id")
        Integer id,

        @JsonProperty("nombre")
        String nombre,

        @JsonProperty("latitud")
        Double latitud,

        @JsonProperty("longitud")
        Double longitud,

        @JsonProperty("elevacion")
        Double elevacion,

        @JsonProperty("caracteristicas")
        String caracteristicas,

        @JsonProperty("tipo")
        TipoPunto tipo,

        @JsonProperty("descripcion")
        String descripcion,

        @JsonProperty("timestamp")
        Integer timestamp,

        @JsonProperty("rutaId")
        Integer rutaId
) {}
