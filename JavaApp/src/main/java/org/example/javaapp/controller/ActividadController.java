package org.example.javaapp.controller;

import org.example.javaapp.dto.DtoActividades;
import org.example.javaapp.dto.MapperActividad;
import org.example.javaapp.model.Actividad;
import org.example.javaapp.model.Ruta;
import org.example.javaapp.service.ServiceActividad;
import org.example.javaapp.service.ServiceRuta;
import org.springframework.http.HttpStatus;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.server.ResponseStatusException;

import java.util.List;

@RestController
@RequestMapping("/api/reta3/rutas")
public class ActividadController {

    private final ServiceActividad serviceActividad;
    private final ServiceRuta serviceRuta;

    public ActividadController(ServiceActividad serviceActividad, ServiceRuta serviceRuta) {
        this.serviceActividad = serviceActividad;
        this.serviceRuta = serviceRuta;
    }

    @PostMapping("/{idRuta}/actividades")
    public DtoActividades insert(@PathVariable int idRuta, @RequestBody DtoActividades dto) {
        Ruta ruta = serviceRuta.findById(idRuta);
        if (ruta == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Ruta no encontrada");

        if (dto.rutaId() == null || dto.rutaId() != idRuta)
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Id de ruta incorrecto");

        Actividad entidad = MapperActividad.toEntity(dto, ruta);
        entidad.setId(null);

        Actividad nueva = serviceActividad.insertInRuta(idRuta, entidad);
        if (nueva == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Actividad no encontrada");

        return MapperActividad.toDto(nueva);
    }


    @GetMapping("/{idRuta}/actividades/{idActividad}")
    public DtoActividades findById(@PathVariable int idActividad, @PathVariable int idRuta) {
        return serviceActividad.findByRutaAndId(idActividad, idRuta)
                .map(MapperActividad::toDto)
                .orElseThrow(() -> new ResponseStatusException(HttpStatus.NOT_FOUND, "Actividad no encontrada"));
    }

    @GetMapping("/{idRuta}/actividades")
    public List<DtoActividades> findAll(@PathVariable int idRuta) {
        return serviceActividad.findAllByRuta(idRuta).stream().map(MapperActividad::toDto).toList();
    }


    @DeleteMapping("/{idRuta}/actividades/{idActividad}")
    public void delete(@PathVariable int idRuta, @PathVariable int idActividad) {
        serviceActividad.deleteFromRuta(idActividad, idRuta);
    }


    @PutMapping("/{idRuta}/actividades/{idActividad}")
    public DtoActividades update(@PathVariable int idActividad, @PathVariable int idRuta, @RequestBody DtoActividades dto) {
        Ruta ruta = serviceRuta.findById(idRuta);
        if (ruta == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Ruta no encontrada");

        if (dto.rutaId() == null || dto.rutaId() != idRuta)
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Id de ruta incorrecto");

        if (dto.id() == null || dto.id() != idActividad)
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Id de actividad incorrecto");

        Actividad entidad = MapperActividad.toEntity(dto, ruta);
        Actividad nueva = serviceActividad.updateInRuta(idActividad, idRuta, entidad);
        if (nueva == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Actividad no encontrada");

        return MapperActividad.toDto(nueva);

    }
}
