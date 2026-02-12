package org.example.javaapp.controller;

import org.example.javaapp.dto.DtoPuntosPeligro;
import org.example.javaapp.dto.MapperPuntosPeligro;
import org.example.javaapp.model.PuntosPeligro;
import org.example.javaapp.model.Ruta;
import org.example.javaapp.service.ServicePuntosPeligro;
import org.example.javaapp.service.ServiceRuta;
import org.springframework.http.HttpStatus;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.server.ResponseStatusException;

import java.util.List;

@RestController
@RequestMapping("/api/reta3/rutas")
public class PuntosPeligroController {

    private final ServicePuntosPeligro servicePuntosPeligro;
    private final ServiceRuta serviceRuta;

    public PuntosPeligroController(ServicePuntosPeligro servicePuntosPeligro, ServiceRuta serviceRuta) {
        this.servicePuntosPeligro = servicePuntosPeligro;
        this.serviceRuta = serviceRuta;
    }

    @PostMapping("/{idRuta}/puntospeligro")
    public DtoPuntosPeligro insert(@PathVariable int idRuta, @RequestBody DtoPuntosPeligro dto) {
        Ruta ruta = serviceRuta.findById(idRuta);
        if (ruta == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Ruta no encontrada");

        if (dto.rutaId() == null || dto.rutaId() != idRuta)
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Id de ruta incorrecto");

        PuntosPeligro entidad = MapperPuntosPeligro.toEntity(dto, ruta);
        entidad.setId(null);

        PuntosPeligro nuevo = servicePuntosPeligro.insertInRuta(idRuta, entidad);
        if (nuevo == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Punto de peligro no encontrado");

        return MapperPuntosPeligro.toDto(nuevo);
    }

    @GetMapping("/{idRuta}/puntospeligro/{idPuntoPeligro}")
    public DtoPuntosPeligro findById(@PathVariable int idPuntoPeligro, @PathVariable int idRuta) {
        return servicePuntosPeligro.findByRutaAndId(idPuntoPeligro, idRuta)
                .map(MapperPuntosPeligro::toDto)
                .orElseThrow(() -> new ResponseStatusException(HttpStatus.NOT_FOUND, "Punto de peligro no encontrado"));
    }

    @GetMapping("/{idRuta}/puntospeligro")
    public List<DtoPuntosPeligro> findAll(@PathVariable int idRuta) {
        return servicePuntosPeligro.findAllByRuta(idRuta)
                .stream()
                .map(MapperPuntosPeligro::toDto)
                .toList();
    }

    @DeleteMapping("/{idRuta}/puntospeligro/{idPuntoPeligro}")
    public void delete(@PathVariable int idRuta, @PathVariable int idPuntoPeligro) {
        servicePuntosPeligro.deleteFromRuta(idPuntoPeligro, idRuta);
    }

    @PutMapping("/{idRuta}/puntospeligro/{idPuntoPeligro}")
    public DtoPuntosPeligro update(@PathVariable int idPuntoPeligro,
                                   @PathVariable int idRuta,
                                   @RequestBody DtoPuntosPeligro dto) {

        Ruta ruta = serviceRuta.findById(idRuta);
        if (ruta == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Ruta no encontrada");

        if (dto.rutaId() == null || dto.rutaId() != idRuta)
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Id de ruta incorrecto");

        if (dto.id() == null || dto.id() != idPuntoPeligro)
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Id de punto de peligro incorrecto");

        PuntosPeligro entidad = MapperPuntosPeligro.toEntity(dto, ruta);

        PuntosPeligro nuevo = servicePuntosPeligro.updateInRuta(idPuntoPeligro, idRuta, entidad);
        if (nuevo == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Punto de peligro no encontrado");

        return MapperPuntosPeligro.toDto(nuevo);
    }
}
