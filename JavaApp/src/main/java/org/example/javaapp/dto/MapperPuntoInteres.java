package org.example.javaapp.dto;

import org.example.javaapp.model.PuntosInteres;
import org.example.javaapp.model.Ruta;

public class MapperPuntoInteres {

    private MapperPuntoInteres() {}

    public static DtoPuntoInteres toDto(PuntosInteres p) {
        return new DtoPuntoInteres(
                p.getId(),
                p.getNombre(),
                p.getLatitud(),
                p.getLongitud(),
                p.getElevacion(),
                p.getCaracteristicas(),
                p.getTipo(),
                p.getDescripcion(),
                p.getTimestamp(),
                p.getRuta().getId()
        );
    }

    public static PuntosInteres toEntity(DtoPuntoInteres dto, Ruta ruta) {
        PuntosInteres p = new PuntosInteres();
        p.setId(dto.id());
        p.setNombre(dto.nombre());
        p.setLatitud(dto.latitud());
        p.setLongitud(dto.longitud());
        p.setElevacion(dto.elevacion());
        p.setCaracteristicas(dto.caracteristicas());
        p.setTipo(dto.tipo());
        p.setDescripcion(dto.descripcion());
        p.setTimestamp(dto.timestamp());
        p.setRuta(ruta);
        return p;
    }
}
