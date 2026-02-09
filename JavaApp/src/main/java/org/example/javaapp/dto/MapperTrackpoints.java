package org.example.javaapp.dto;

import org.example.javaapp.model.Ruta;
import org.example.javaapp.model.Trackpoint;
import org.example.javaapp.model.TrackpointId;

public class MapperTrackpoints {

    private MapperTrackpoints() {}

    public static DtoTrackpoints toDto(Trackpoint tp) {
        return new DtoTrackpoints(
                tp.getId().getIdRuta(),
                tp.getId().getPosicion(),
                tp.getLatitud(),
                tp.getLongitud()
        );
    }

    public static Trackpoint toEntity(DtoTrackpoints dto, Ruta ruta) {
        Trackpoint tp = new Trackpoint();

        TrackpointId id = new TrackpointId();
        id.setIdRuta(dto.idRuta());
        id.setPosicion(dto.posicion());

        tp.setId(id);
        tp.setIdRuta(ruta); // @MapsId("idRuta")
        tp.setLatitud(dto.latitud());
        tp.setLongitud(dto.longitud());

        return tp;
    }
}
