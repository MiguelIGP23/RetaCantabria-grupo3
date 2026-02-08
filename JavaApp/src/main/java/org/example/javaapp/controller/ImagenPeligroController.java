package org.example.javaapp.controller;

import org.example.javaapp.dto.DtoImagenesPeligro;
import org.example.javaapp.dto.MapperImagenesPeligro;
import org.example.javaapp.model.ImagenesPeligro;
import org.example.javaapp.model.PuntosPeligro;
import org.example.javaapp.model.Ruta;
import org.example.javaapp.service.ServiceImagenPeligro;
import org.example.javaapp.service.ServicePuntosPeligro;
import org.example.javaapp.service.ServiceRuta;
import org.springframework.http.HttpStatus;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.server.ResponseStatusException;

import java.util.List;

@RestController
@RequestMapping("api/reta3/rutas")
public class ImagenPeligroController {

    private final ServiceImagenPeligro serviceImagen;
    private final ServiceRuta serviceRuta;
    private final ServicePuntosPeligro servicePuntos;

    public ImagenPeligroController(ServiceImagenPeligro serviceImagen, ServiceRuta serviceRuta, ServicePuntosPeligro servicePuntos) {
        this.serviceImagen = serviceImagen;
        this.serviceRuta = serviceRuta;
        this.servicePuntos = servicePuntos;
    }

    @PostMapping("/{idRuta}/puntospeligro/{idPunto}/imagenes")
    public DtoImagenesPeligro insert(@PathVariable int idRuta, @PathVariable int idPunto, @RequestBody DtoImagenesPeligro dto) {

        Ruta ruta = serviceRuta.findById(idRuta);
        if (ruta == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Ruta no encontrada");

        if (dto.rutaId() == null || dto.rutaId() != idRuta)
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Id de ruta incorrecto");

        if (dto.puntosPeligroId() == null || dto.puntosPeligroId() != idPunto)
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Id de punto de peligro incorrecto");

        PuntosPeligro punto = servicePuntos.findByRutaAndId(idPunto, idRuta).orElse(null);
        if (punto == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Punto de peligro no encontrado");

        ImagenesPeligro entidad = MapperImagenesPeligro.toEntity(dto, punto);
        entidad.setId(null);

        ImagenesPeligro nueva = serviceImagen.insertInPunto(idRuta, idPunto, entidad);
        if (nueva == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Imagen no encontrada");

        return MapperImagenesPeligro.toDto(nueva);
    }

    @GetMapping("/{idRuta}/puntospeligro/{idPunto}/imagenes")
    public List<DtoImagenesPeligro> findAll(@PathVariable int idRuta, @PathVariable int idPunto) {
        return serviceImagen.findAllByPunto(idRuta, idPunto)
                .stream()
                .map(MapperImagenesPeligro::toDto)
                .toList();
    }

    @GetMapping("/{idRuta}/puntospeligro/{idPunto}/imagenes/{idImagen}")
    public DtoImagenesPeligro findById(@PathVariable int idRuta, @PathVariable int idPunto, @PathVariable int idImagen) {
        return serviceImagen.findByPuntoAndId(idRuta, idPunto, idImagen)
                .map(MapperImagenesPeligro::toDto)
                .orElseThrow(() -> new ResponseStatusException(HttpStatus.NOT_FOUND, "Imagen no encontrada"));
    }

    @DeleteMapping("/{idRuta}/puntospeligro/{idPunto}/imagenes/{idImagen}")
    public void delete(@PathVariable int idRuta, @PathVariable int idPunto, @PathVariable int idImagen) {
        serviceImagen.deleteFromPunto(idRuta, idPunto, idImagen);
    }

    @PutMapping("/{idRuta}/puntospeligro/{idPunto}/imagenes/{idImagen}")
    public DtoImagenesPeligro update(@PathVariable int idRuta,
                                     @PathVariable int idPunto,
                                     @PathVariable int idImagen,
                                     @RequestBody DtoImagenesPeligro dto) {

        Ruta ruta = serviceRuta.findById(idRuta);
        if (ruta == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Ruta no encontrada");

        if (dto.rutaId() == null || dto.rutaId() != idRuta)
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Id de ruta incorrecto");

        if (dto.puntosPeligroId() == null || dto.puntosPeligroId() != idPunto)
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Id de punto de peligro incorrecto");

        if (dto.id() == null || dto.id() != idImagen)
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Id de imagen incorrecto");

        PuntosPeligro punto = servicePuntos.findByRutaAndId(idPunto, idRuta).orElse(null);
        if (punto == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Punto de peligro no encontrado");

        ImagenesPeligro entidad = MapperImagenesPeligro.toEntity(dto, punto);

        ImagenesPeligro nueva = serviceImagen.updateInPunto(idRuta, idPunto, idImagen, entidad);
        if (nueva == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Imagen no encontrada");

        return MapperImagenesPeligro.toDto(nueva);
    }
}
