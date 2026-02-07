package org.example.javaapp.dto;

import org.example.javaapp.model.PuntosInteres;

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
}
