package org.example.javaapp.dto;

import org.example.javaapp.model.PuntosPeligro;
import org.example.javaapp.model.Ruta;

public class MapperPuntosPeligro {

    private MapperPuntosPeligro() {}

    public static DtoPuntosPeligro toDto(PuntosPeligro pp) {
        return new DtoPuntosPeligro(
                pp.getId(),
                pp.getNombre(),
                pp.getLatitud(),
                pp.getLongitud(),
                pp.getElevacion(),
                pp.getKilometros(),
                pp.getGravedad(),
                pp.getPosicion(),
                pp.getDescripcion(),
                pp.getTimestamp(),
                pp.getRuta().getId()
        );
    }

    public static PuntosPeligro toEntity(DtoPuntosPeligro dto, Ruta ruta) {
        PuntosPeligro pp = new PuntosPeligro();
        pp.setId(dto.id());
        pp.setNombre(dto.nombre());
        pp.setLatitud(dto.latitud());
        pp.setLongitud(dto.longitud());
        pp.setElevacion(dto.elevacion());
        pp.setKilometros(dto.kilometros());
        pp.setGravedad(dto.gravedad());
        pp.setPosicion(dto.posicion());
        pp.setDescripcion(dto.descripcion());
        pp.setTimestamp(dto.timestamp());
        pp.setRuta(ruta);
        return pp;
    }
}
