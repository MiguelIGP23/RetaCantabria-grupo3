package org.example.javaapp.dto;

import org.example.javaapp.model.Actividad;
import org.example.javaapp.model.Ruta;

public class MapperActividad {

    private MapperActividad(){}

    public static DtoActividad toDto(Actividad a) {
        return new DtoActividad(
                a.getId(),
                a.getNombre(),
                a.getRuta().getId()
        );
    }

    public static Actividad toEntity(DtoActividad dto, Ruta ruta){
        Actividad act = new Actividad();

        act.setId(dto.id());
        act.setNombre(dto.nombre());
        act.setRuta(ruta);
        return act;
    }
}
