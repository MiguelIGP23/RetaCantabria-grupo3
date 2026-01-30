package org.example.javaapp.controller;


import org.example.javaapp.model.Ruta;
import org.example.javaapp.service.ServiceRuta;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/reta3/rutas")
public class RutaController {

    private final ServiceRuta service;

    public RutaController(ServiceRuta service){
        this.service=service;
    }

    @PostMapping()
    public Ruta insert(@RequestBody Ruta ruta){
        return service.insert(ruta);
    }

    @GetMapping()
    public List<Ruta> getAll(){
        return service.findAll();
    }

    @GetMapping("/{id}")
    public Ruta getById(@PathVariable int id){
        return service.findById(id);
    }

    @DeleteMapping("/{id}")
    public void delete(@PathVariable int id){
        service.delete(id);
    }

    @PutMapping("/{id}")
    public Ruta update(@PathVariable int id, @RequestBody Ruta ruta){
        return service.update(id, ruta);
    }
}


