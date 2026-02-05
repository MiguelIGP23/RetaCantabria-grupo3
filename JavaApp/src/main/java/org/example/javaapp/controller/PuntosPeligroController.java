package org.example.javaapp.controller;

import org.example.javaapp.model.PuntosPeligro;
import org.example.javaapp.service.ServicePuntosPeligro;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/reta3/rutas")
public class PuntosPeligroController {

    private final ServicePuntosPeligro service;

    public PuntosPeligroController(ServicePuntosPeligro service){
        this.service=service;
    }

    @PostMapping("/{idRuta}/puntospeligro")
    public PuntosPeligro insert(@PathVariable int idRuta, @RequestBody PuntosPeligro puntospeligro){
        return service.insertInRuta(idRuta, puntospeligro);
    }

    @DeleteMapping("/{idRuta}/puntospeligro/{idPunto}")
    public void delete(@PathVariable int idPunto, @PathVariable int idRuta){
        service.deleteFromRuta(idPunto, idRuta);
    }

    @PutMapping("/{idRuta}/puntospeligro/{idPunto}")
    public PuntosPeligro update(@PathVariable int idPunto, @PathVariable int idRuta, @RequestBody PuntosPeligro puntospeligro){
        return service.updateInRuta(idPunto, idRuta, puntospeligro);
    }

    @GetMapping("/{idRuta}/puntospeligro/{idPunto}")
    public PuntosPeligro findById(@PathVariable int idPunto, @PathVariable int idRuta){
        return service.findByRutaAndId(idPunto, idRuta).orElse(null);
    }

    @GetMapping("/{idRuta}/puntospeligro")
    public List<PuntosPeligro> findAll(@PathVariable int idRuta){
        return service.findAllByRuta(idRuta);
    }


}
