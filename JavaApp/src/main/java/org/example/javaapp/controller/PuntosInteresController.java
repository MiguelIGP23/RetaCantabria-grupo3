package org.example.javaapp.controller;

import org.example.javaapp.dto.DtoPuntoInteres;
import org.example.javaapp.dto.MapperPuntoInteres;
import org.example.javaapp.model.PuntosInteres;
import org.example.javaapp.service.ServicePuntosInteres;
import org.springframework.http.HttpStatus;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.server.ResponseStatusException;

import java.util.List;

@RestController
@RequestMapping("/api/reta3/rutas")
public class PuntosInteresController {

    private final ServicePuntosInteres service;

    public PuntosInteresController(ServicePuntosInteres service) {
        this.service = service;
    }

    @PostMapping(("/{idRuta}/puntosinteres"))
    public DtoPuntoInteres insert(@PathVariable int idRuta, @RequestBody PuntosInteres puntosInteres) {
        PuntosInteres entidad = service.insertInRuta(idRuta, puntosInteres);
        return MapperPuntoInteres.toDto(entidad);
    }


    @DeleteMapping("/{idRuta}/puntosinteres/{idPunto}")
    public void delete(@PathVariable int idPunto, @PathVariable int idRuta) {
        service.deleteFromRuta(idPunto, idRuta);
    }


    @PutMapping("/{idRuta}/puntosinteres/{idPunto}")
    public DtoPuntoInteres update(@PathVariable int idPunto, @PathVariable int idRuta, @RequestBody PuntosInteres puntosInteres) {
        PuntosInteres entidad = service.updateInRuta(idPunto, idRuta, puntosInteres);
        return MapperPuntoInteres.toDto(entidad);
    }


    @GetMapping("/{idRuta}/puntosinteres/{idPunto}")
    public DtoPuntoInteres findById(@PathVariable int idPunto, @PathVariable int idRuta) {
        return service.findByRutaAndId(idPunto, idRuta)
                .map(MapperPuntoInteres::toDto)
                .orElseThrow(() ->
                        new ResponseStatusException(HttpStatus.NOT_FOUND, "Punto no encontrado")
                );
    }


    @GetMapping("/{idRuta}/puntosinteres")
    public List<DtoPuntoInteres> findAll(@PathVariable int idRuta) {
        return service.findAllByRuta(idRuta)
                .stream()
                .map(MapperPuntoInteres::toDto)
                .toList();
    }
}
