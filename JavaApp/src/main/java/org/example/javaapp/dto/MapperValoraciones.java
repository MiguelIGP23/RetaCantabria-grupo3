package org.example.javaapp.dto;

import org.example.javaapp.model.Ruta;
import org.example.javaapp.model.Usuario;
import org.example.javaapp.model.Valoracion;

public class MapperValoraciones {

    private MapperValoraciones() {}

    public static DtoValoraciones toDto(Valoracion v) {
        return new DtoValoraciones(
                v.getId(),
                v.getDificultad(),
                v.getFecha(),
                v.getEstrellas(),
                v.getInteresCultural(),
                v.getBelleza(),
                v.getValoracionTecnica(),
                v.getResena(),
                v.getUsuario().getId(),
                v.getRuta().getId()
        );
    }

    public static Valoracion toEntity(DtoValoraciones dto, Usuario usuario, Ruta ruta) {
        Valoracion v = new Valoracion();
        v.setId(dto.id());
        v.setDificultad(dto.dificultad());
        v.setFecha(dto.fecha());
        v.setEstrellas(dto.estrellas());
        v.setInteresCultural(dto.interesCultural());
        v.setBelleza(dto.belleza());
        v.setValoracionTecnica(dto.valoracionTecnica());
        v.setResena(dto.resena());
        v.setUsuario(usuario);
        v.setRuta(ruta);
        return v;
    }
}
