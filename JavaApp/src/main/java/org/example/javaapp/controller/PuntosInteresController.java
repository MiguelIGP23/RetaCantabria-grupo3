package org.example.javaapp.controller;

import org.example.javaapp.dto.DtoPuntosInteres;
import org.example.javaapp.dto.MapperPuntosInteres;
import org.example.javaapp.model.PuntosInteres;
import org.example.javaapp.model.Ruta;
import org.example.javaapp.service.ServicePuntosInteres;
import org.example.javaapp.service.ServiceRuta;
import org.springframework.http.HttpStatus;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.server.ResponseStatusException;

import java.util.List;

@RestController
@RequestMapping("/api/reta3/rutas")
public class PuntosInteresController {

    private final ServicePuntosInteres servicePuntosInteres;
    private final ServiceRuta serviceRuta;

    public PuntosInteresController(ServicePuntosInteres servicePuntosInteres, ServiceRuta serviceRuta) {
        this.servicePuntosInteres = servicePuntosInteres;
        this.serviceRuta = serviceRuta;
    }

    @PostMapping("/{idRuta}/puntosinteres")
    public DtoPuntosInteres insert(@PathVariable int idRuta, @RequestBody DtoPuntosInteres dto) {
        Ruta ruta = serviceRuta.findById(idRuta);
        if (ruta == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Ruta no encontrada");

        if (dto.rutaId() == null || dto.rutaId() != idRuta)
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Id de ruta incorrecto");

        PuntosInteres entidad = MapperPuntosInteres.toEntity(dto, ruta);
        entidad.setId(null);

        PuntosInteres nuevo = servicePuntosInteres.insertInRuta(idRuta, entidad);
        if (nuevo == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Punto de interés no encontrado");

        return MapperPuntosInteres.toDto(nuevo);
    }

    @GetMapping("/{idRuta}/puntosinteres/{idPuntoInteres}")
    public DtoPuntosInteres findById(@PathVariable int idPuntoInteres, @PathVariable int idRuta) {
        return servicePuntosInteres.findByRutaAndId(idPuntoInteres, idRuta)
                .map(MapperPuntosInteres::toDto)
                .orElseThrow(() -> new ResponseStatusException(HttpStatus.NOT_FOUND, "Punto de interés no encontrado"));
    }

    @GetMapping("/{idRuta}/puntosinteres")
    public List<DtoPuntosInteres> findAll(@PathVariable int idRuta) {
        return servicePuntosInteres.findAllByRuta(idRuta)
                .stream()
                .map(MapperPuntosInteres::toDto)
                .toList();
    }

    @DeleteMapping("/{idRuta}/puntosinteres/{idPuntoInteres}")
    public void delete(@PathVariable int idRuta, @PathVariable int idPuntoInteres) {
        servicePuntosInteres.deleteFromRuta(idPuntoInteres, idRuta);
    }

    @PutMapping("/{idRuta}/puntosinteres/{idPuntoInteres}")
    public DtoPuntosInteres update(@PathVariable int idPuntoInteres,
                                   @PathVariable int idRuta,
                                   @RequestBody DtoPuntosInteres dto) {

        Ruta ruta = serviceRuta.findById(idRuta);
        if (ruta == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Ruta no encontrada");

        if (dto.rutaId() == null || dto.rutaId() != idRuta)
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Id de ruta incorrecto");

        if (dto.id() == null || dto.id() != idPuntoInteres)
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Id de punto de interés incorrecto");

        PuntosInteres entidad = MapperPuntosInteres.toEntity(dto, ruta);

        PuntosInteres nuevo = servicePuntosInteres.updateInRuta(idPuntoInteres, idRuta, entidad);
        if (nuevo == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Punto de interés no encontrado");

        return MapperPuntosInteres.toDto(nuevo);
    }
}
