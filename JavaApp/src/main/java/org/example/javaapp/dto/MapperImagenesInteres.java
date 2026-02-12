package org.example.javaapp.dto;

import org.example.javaapp.model.ImagenesInteres;
import org.example.javaapp.model.PuntosInteres;

public class MapperImagenesInteres {

    private MapperImagenesInteres() {}

    public static DtoImagenesInteres toDto(ImagenesInteres img) {
        return new DtoImagenesInteres(
                img.getId(),
                img.getUrl(),
                img.getDescripcion(),
                img.getPuntosInteres().getRuta().getId(),
                img.getPuntosInteres().getId()
        );
    }

    public static ImagenesInteres toEntity(DtoImagenesInteres dto, PuntosInteres punto) {
        ImagenesInteres img = new ImagenesInteres();
        img.setId(dto.id());
        img.setUrl(dto.url());
        img.setDescripcion(dto.descripcion());
        img.setPuntosInteres(punto);
        return img;
    }
}
