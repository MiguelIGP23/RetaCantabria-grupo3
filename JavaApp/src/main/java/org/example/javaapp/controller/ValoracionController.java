package org.example.javaapp.controller;

import org.example.javaapp.model.Valoracion;
import org.example.javaapp.service.ServiceValoracion;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("api/reta3/rutas")
public class ValoracionController {

    private final ServiceValoracion service;

    public ValoracionController(ServiceValoracion service) {
        this.service = service;
    }



    @PostMapping("/{idRuta}/valoraciones")
    public Valoracion insert(@PathVariable int idRuta, @RequestBody Valoracion valoracion) {
        return service.insertInRuta(idRuta, valoracion);
    }

    @DeleteMapping("/{idRuta}/valoraciones/{idValoracion}")
    public void delete(@PathVariable int idValoracion, @PathVariable int idRuta) {
        service.deleteFromRuta(idValoracion, idRuta);
    }

    @PutMapping("/{idRuta}/valoraciones/{idValoracion}")
    public Valoracion update(@PathVariable int idValoracion, @PathVariable int idRuta, @RequestBody Valoracion valoracion) {
        return service.updateInRuta(idValoracion, idRuta, valoracion);
    }

    @GetMapping("/{idRuta}/valoraciones/{idValoracion}")
    public Valoracion findById(@PathVariable int idValoracion, @PathVariable int idRuta){
        return service.findByRutaAndId(idValoracion, idRuta).orElse(null);
    }

    @GetMapping("/{idRuta}/valoraciones")
    public List<Valoracion> findAll(@PathVariable int idRuta) {
        return service.findAllByRuta(idRuta);
    }

}
