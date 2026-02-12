package org.example.javaapp.controller;

import org.example.javaapp.dto.DtoImagenesInteres;
import org.example.javaapp.dto.MapperImagenesInteres;
import org.example.javaapp.model.ImagenesInteres;
import org.example.javaapp.model.PuntosInteres;
import org.example.javaapp.model.Ruta;
import org.example.javaapp.service.ServiceImagenInteres;
import org.example.javaapp.service.ServicePuntosInteres;
import org.example.javaapp.service.ServiceRuta;
import org.springframework.http.HttpStatus;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.server.ResponseStatusException;

import java.util.List;

@RestController
@RequestMapping("api/reta3/rutas")
public class ImagenInteresController {

    private final ServiceImagenInteres serviceImagen;
    private final ServiceRuta serviceRuta;
    private final ServicePuntosInteres servicePuntos;

    public ImagenInteresController(ServiceImagenInteres serviceImagen, ServiceRuta serviceRuta, ServicePuntosInteres servicePuntos) {
        this.serviceImagen = serviceImagen;
        this.serviceRuta = serviceRuta;
        this.servicePuntos = servicePuntos;
    }



    @PostMapping("/{idRuta}/puntosinteres/{idPunto}/imagenes")
    public DtoImagenesInteres insert(@PathVariable int idRuta, @PathVariable int idPunto, @RequestBody DtoImagenesInteres dto) {

        Ruta ruta = serviceRuta.findById(idRuta);
        if (ruta == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Ruta no encontrada");

        if (dto.rutaId() == null || dto.rutaId() != idRuta)
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Id de ruta incorrecto");

        if (dto.puntosInteresId() == null || dto.puntosInteresId() != idPunto)
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Id de punto de interés incorrecto");

        PuntosInteres punto = servicePuntos.findByRutaAndId(idPunto, idRuta).orElse(null);
        if (punto == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Punto de interés no encontrado");

        ImagenesInteres entidad = MapperImagenesInteres.toEntity(dto, punto);
        entidad.setId(null);

        ImagenesInteres nueva = serviceImagen.insertInPunto(idRuta, idPunto, entidad);
        if (nueva == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Imagen no encontrada");

        return MapperImagenesInteres.toDto(nueva);
    }



    @GetMapping("/{idRuta}/puntosinteres/{idPunto}/imagenes")
    public List<DtoImagenesInteres> findAll(@PathVariable int idRuta, @PathVariable int idPunto) {
        return serviceImagen.findAllByPunto(idRuta, idPunto)
                .stream()
                .map(MapperImagenesInteres::toDto)
                .toList();
    }



    @GetMapping("/{idRuta}/puntosinteres/{idPunto}/imagenes/{idImagen}")
    public DtoImagenesInteres findById(@PathVariable int idRuta, @PathVariable int idPunto, @PathVariable int idImagen) {
        return serviceImagen.findByPuntoAndId(idRuta, idPunto, idImagen)
                .map(MapperImagenesInteres::toDto)
                .orElseThrow(() -> new ResponseStatusException(HttpStatus.NOT_FOUND, "Imagen no encontrada"));
    }



    @DeleteMapping("/{idRuta}/puntosinteres/{idPunto}/imagenes/{idImagen}")
    public void delete(@PathVariable int idRuta, @PathVariable int idPunto, @PathVariable int idImagen) {
        serviceImagen.deleteFromPunto(idRuta, idPunto, idImagen);
    }



    @PutMapping("/{idRuta}/puntosinteres/{idPunto}/imagenes/{idImagen}")
    public DtoImagenesInteres update(@PathVariable int idRuta,
                                     @PathVariable int idPunto,
                                     @PathVariable int idImagen,
                                     @RequestBody DtoImagenesInteres dto) {

        Ruta ruta = serviceRuta.findById(idRuta);
        if (ruta == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Ruta no encontrada");

        if (dto.rutaId() == null || dto.rutaId() != idRuta)
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Id de ruta incorrecto");

        if (dto.puntosInteresId() == null || dto.puntosInteresId() != idPunto)
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Id de punto de interés incorrecto");

        if (dto.id() == null || dto.id() != idImagen)
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Id de imagen incorrecto");

        PuntosInteres punto = servicePuntos.findByRutaAndId(idPunto, idRuta).orElse(null);
        if (punto == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Punto de interés no encontrado");

        ImagenesInteres entidad = MapperImagenesInteres.toEntity(dto, punto);

        ImagenesInteres nueva = serviceImagen.updateInPunto(idRuta, idPunto, idImagen, entidad);
        if (nueva == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Imagen no encontrada");

        return MapperImagenesInteres.toDto(nueva);
    }
}
