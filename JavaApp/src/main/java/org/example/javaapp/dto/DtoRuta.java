package org.example.javaapp.dto;

import com.fasterxml.jackson.annotation.JsonProperty;
import org.example.javaapp.model.Clasificacion;

import java.time.LocalTime;

public record DtoRuta(

        @JsonProperty("id")
        Integer id,

        @JsonProperty("nombre")
        String nombre,

        @JsonProperty("nombreInicioruta")
        String nombreInicioruta,

        @JsonProperty("nombreFinalruta")
        String nombreFinalruta,

        @JsonProperty("latitudInicial")
        Double latitudInicial,

        @JsonProperty("latitudFinal")
        Double latitudFinal,

        @JsonProperty("longitudInicial")
        Double longitudInicial,

        @JsonProperty("longitudFinal")
        Double longitudFinal,

        @JsonProperty("distancia")
        Double distancia,

        @JsonProperty("duracion")
        LocalTime duracion,

        @JsonProperty("desnivelPositivo")
        Integer desnivelPositivo,

        @JsonProperty("desnivelNegativo")
        Integer desnivelNegativo,

        @JsonProperty("altitudMax")
        Double altitudMax,

        @JsonProperty("altitudMin")
        Double altitudMin,

        @JsonProperty("clasificacion")
        Clasificacion clasificacion,

        @JsonProperty("nivelEsfuerzo")
        Byte nivelEsfuerzo,

        @JsonProperty("nivelRiesgo")
        Byte nivelRiesgo,

        @JsonProperty("estadoRuta")
        Byte estadoRuta,

        @JsonProperty("tipoTerreno")
        Byte tipoTerreno,

        @JsonProperty("indicaciones")
        Byte indicaciones,

        @JsonProperty("temporadas")
        String temporadas,

        @JsonProperty("accesibilidad")
        Byte accesibilidad,

        @JsonProperty("rutaFamiliar")
        Byte rutaFamiliar,

        @JsonProperty("archivoGPX")
        String archivoGPX,

        @JsonProperty("recomendacionesEquipo")
        String recomendacionesEquipo,

        @JsonProperty("zonaGeografica")
        String zonaGeografica,

        @JsonProperty("mediaEstrellas")
        Double mediaEstrellas,

        @JsonProperty("usuarioId")
        Integer usuarioId
) {}
