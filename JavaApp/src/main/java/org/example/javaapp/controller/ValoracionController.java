package org.example.javaapp.controller;

import org.example.javaapp.model.Valoracion;
import org.example.javaapp.service.ServiceValoracion;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("api/reta3/valoraciones")
public class ValoracionController {

    private final ServiceValoracion service;

    public ValoracionController(ServiceValoracion service) {
        this.service = service;
    }

    @PostMapping
    public Valoracion insert(@RequestBody Valoracion valoracion) {
        return service.insert(valoracion);
    }

    @DeleteMapping("/{id}")
    public void delete(@PathVariable int id) {
        service.delete(id);
    }

    @PutMapping("/{id}")
    public Valoracion update(@PathVariable int id, @RequestBody Valoracion valoracion) {
        return service.update(id, valoracion);
    }

    @GetMapping("/{id}")
    public Valoracion findById(@PathVariable int id){
        return service.findById(id);
    }

    @GetMapping
    public List<Valoracion> findAll() {
        return service.findAll();
    }

}
