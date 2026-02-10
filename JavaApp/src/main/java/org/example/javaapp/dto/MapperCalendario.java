package org.example.javaapp.dto;

import org.example.javaapp.model.Calendario;
import org.example.javaapp.model.Ruta;
import org.example.javaapp.model.Usuario;

public final class MapperCalendario {

    private MapperCalendario() {}

    public static DtoCalendario toDto(Calendario c) {
        return new DtoCalendario(
                c.getId(),
                c.getFecha(),
                c.getHoraInicio(),
                c.getInfo(),
                c.getRuta() != null ? c.getRuta().getId() : null,
                c.getUsuario() != null ? c.getUsuario().getId() : null
        );
    }

    public static Calendario toEntity(DtoCalendario dto, Ruta ruta, Usuario usuario) {
        Calendario c = new Calendario();
        c.setId(dto.id());
        c.setFecha(dto.fecha());
        c.setHoraInicio(dto.horaInicio());
        c.setInfo(dto.info());
        c.setRuta(ruta);
        c.setUsuario(usuario);
        return c;
    }
}
