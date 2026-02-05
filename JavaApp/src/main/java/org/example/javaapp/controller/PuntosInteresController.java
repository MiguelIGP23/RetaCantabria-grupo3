package org.example.javaapp.controller;

import org.example.javaapp.model.PuntosInteres;
import org.example.javaapp.service.ServicePuntosInteres;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/reta3/rutas")
public class PuntosInteresController {

    private final ServicePuntosInteres service;

    public PuntosInteresController(ServicePuntosInteres service){
        this.service=service;
    }

    @PostMapping(("/{idRuta}/puntosinteres"))
    public PuntosInteres insert(@PathVariable int idRuta,@RequestBody PuntosInteres puntosInteres){
        return service.insertInRuta(idRuta, puntosInteres);
    }

    @DeleteMapping("/{idRuta}/puntosinteres/{idPunto}")
    public void delete(@PathVariable int idPunto, @PathVariable int idRuta){
        service.deleteFromRuta(idPunto, idRuta);
    }

    @PutMapping("/{idRuta}/puntosinteres/{idPunto}")
    public PuntosInteres update(@PathVariable int idPunto, @PathVariable int idRuta, @RequestBody PuntosInteres puntosInteres){
        return service.updateInRuta(idPunto, idRuta, puntosInteres);
    }

    @GetMapping("/{idRuta}/puntosinteres/{idPunto}")
    public PuntosInteres findById(@PathVariable int idPunto, @PathVariable int idRuta){
        return service.findByRutaAndId(idPunto, idRuta).orElse(null);
    }

    @GetMapping("/{idRuta}/puntosinteres")
    public List<PuntosInteres> findAll(@PathVariable int idRuta){
        return service.findAllByRuta(idRuta);
    }
}
