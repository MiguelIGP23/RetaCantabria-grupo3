package org.example.javaapp.controller;

import org.example.javaapp.dto.DtoTrackpoints;
import org.example.javaapp.dto.MapperTrackpoints;
import org.example.javaapp.model.Ruta;
import org.example.javaapp.model.Trackpoint;
import org.example.javaapp.service.ServiceRuta;
import org.example.javaapp.service.ServiceTrackpoint;
import org.springframework.http.HttpStatus;
import org.springframework.security.core.annotation.AuthenticationPrincipal;
import org.springframework.security.oauth2.jwt.Jwt;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.server.ResponseStatusException;

import java.util.List;

@RestController
@RequestMapping("/api/reta3/rutas")
public class TrackpointController {

    private final ServiceTrackpoint serviceTrackpoint;
    private final ServiceRuta serviceRuta;

    public TrackpointController(ServiceTrackpoint serviceTrackpoint, ServiceRuta serviceRuta) {
        this.serviceTrackpoint = serviceTrackpoint;
        this.serviceRuta = serviceRuta;
    }

    @PostMapping("/{idRuta}/trackpoints")
    public DtoTrackpoints insert(@PathVariable int idRuta, @RequestBody DtoTrackpoints dto) {

        Ruta ruta = serviceRuta.findById(idRuta);
        if (ruta == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Ruta no encontrada");

        if (dto.idRuta() == null || dto.idRuta() != idRuta)
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Id de ruta incorrecto");

        if (dto.posicion() == null)
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Posición incorrecta");

        Trackpoint entidad = MapperTrackpoints.toEntity(dto, ruta);

        Trackpoint nuevo = serviceTrackpoint.insertInRuta(idRuta, entidad);
        if (nuevo == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Trackpoint no encontrado");

        return MapperTrackpoints.toDto(nuevo);
    }

    @GetMapping("/{idRuta}/trackpoints")
    public List<DtoTrackpoints> findAll(@PathVariable int idRuta) {
        return serviceTrackpoint.findAllByRuta(idRuta).stream().map(MapperTrackpoints::toDto).toList();
    }

    @GetMapping("/{idRuta}/trackpoints/{posicion}")
    public DtoTrackpoints findById(@PathVariable int idRuta, @PathVariable int posicion) {
        return serviceTrackpoint.findByRutaAndPosicion(idRuta, posicion)
                .map(MapperTrackpoints::toDto)
                .orElseThrow(() -> new ResponseStatusException(HttpStatus.NOT_FOUND, "Trackpoint no encontrado"));
    }

    @DeleteMapping("/{idRuta}/trackpoints/{posicion}")
    public void delete(@PathVariable int idRuta, @PathVariable int posicion) {
        serviceTrackpoint.deleteFromRuta(idRuta, posicion);
    }

    @PutMapping("/{idRuta}/trackpoints/{posicion}")
    public DtoTrackpoints update(@PathVariable int idRuta, @PathVariable int posicion, @RequestBody DtoTrackpoints dto) {

        Ruta ruta = serviceRuta.findById(idRuta);
        if (ruta == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Ruta no encontrada");

        if (dto.idRuta() == null || dto.idRuta() != idRuta)
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Id de ruta incorrecto");

        if (dto.posicion() == null || dto.posicion() != posicion)
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Posición incorrecta");

        Trackpoint entidad = MapperTrackpoints.toEntity(dto, ruta);

        Trackpoint nuevo = serviceTrackpoint.updateInRuta(idRuta, posicion, entidad);
        if (nuevo == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Trackpoint no encontrado");

        return MapperTrackpoints.toDto(nuevo);
    }
}
