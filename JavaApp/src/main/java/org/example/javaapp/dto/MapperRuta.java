package org.example.javaapp.dto;

import org.example.javaapp.model.Ruta;
import org.example.javaapp.model.Usuario;

public class MapperRuta {

    private MapperRuta() {}

    public static DtoRuta toDto(Ruta r) {
        return new DtoRuta(
                r.getId(),
                r.getNombre(),
                r.getNombreInicioruta(),
                r.getNombreFinalruta(),
                r.getLatitudInicial(),
                r.getLatitudFinal(),
                r.getLongitudInicial(),
                r.getLongitudFinal(),
                r.getDistancia(),
                r.getDuracion(),
                r.getDesnivelPositivo(),
                r.getDesnivelNegativo(),
                r.getAltitudMax(),
                r.getAltitudMin(),
                r.getClasificacion(),
                r.getNivelEsfuerzo(),
                r.getNivelRiesgo(),
                r.getEstadoRuta(),
                r.getTipoTerreno(),
                r.getIndicaciones(),
                r.getTemporadas(),
                r.getAccesibilidad(),
                r.getRutaFamiliar(),
                r.getArchivoGPX(),
                r.getRecomendacionesEquipo(),
                r.getZonaGeografica(),
                r.getMediaEstrellas(),
                r.getUsuario().getId()
        );
    }

    public static Ruta toEntity(DtoRuta dto, Usuario usuario) {
        Ruta r = new Ruta();

        r.setId(dto.id());
        r.setNombre(dto.nombre());
        r.setNombreInicioruta(dto.nombreInicioruta());
        r.setNombreFinalruta(dto.nombreFinalruta());
        r.setLatitudInicial(dto.latitudInicial());
        r.setLatitudFinal(dto.latitudFinal());
        r.setLongitudInicial(dto.longitudInicial());
        r.setLongitudFinal(dto.longitudFinal());
        r.setDistancia(dto.distancia());
        r.setDuracion(dto.duracion());
        r.setDesnivelPositivo(dto.desnivelPositivo());
        r.setDesnivelNegativo(dto.desnivelNegativo());
        r.setAltitudMax(dto.altitudMax());
        r.setAltitudMin(dto.altitudMin());
        r.setClasificacion(dto.clasificacion());
        r.setNivelEsfuerzo(dto.nivelEsfuerzo());
        r.setNivelRiesgo(dto.nivelRiesgo());
        r.setEstadoRuta(dto.estadoRuta());
        r.setTipoTerreno(dto.tipoTerreno());
        r.setIndicaciones(dto.indicaciones());
        r.setTemporadas(dto.temporadas());
        r.setAccesibilidad(dto.accesibilidad());
        r.setRutaFamiliar(dto.rutaFamiliar());
        r.setArchivoGPX(dto.archivoGPX());
        r.setRecomendacionesEquipo(dto.recomendacionesEquipo());
        r.setZonaGeografica(dto.zonaGeografica());
        r.setMediaEstrellas(dto.mediaEstrellas());

        r.setUsuario(usuario); // CLAVE: usuario gestionado
        return r;
    }
}
