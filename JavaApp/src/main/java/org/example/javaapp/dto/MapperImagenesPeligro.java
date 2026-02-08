package org.example.javaapp.dto;

import org.example.javaapp.model.ImagenesPeligro;
import org.example.javaapp.model.PuntosPeligro;

public class MapperImagenesPeligro {

    private MapperImagenesPeligro() {}

    public static DtoImagenesPeligro toDto(ImagenesPeligro img) {
        return new DtoImagenesPeligro(
                img.getId(),
                img.getUrl(),
                img.getDescripcion(),
                img.getPuntosPeligro().getRuta().getId(),
                img.getPuntosPeligro().getId()
        );
    }

    public static ImagenesPeligro toEntity(DtoImagenesPeligro dto, PuntosPeligro punto) {
        ImagenesPeligro img = new ImagenesPeligro();
        img.setId(dto.id());
        img.setUrl(dto.url());
        img.setDescripcion(dto.descripcion());
        img.setPuntosPeligro(punto);
        return img;
    }
}
