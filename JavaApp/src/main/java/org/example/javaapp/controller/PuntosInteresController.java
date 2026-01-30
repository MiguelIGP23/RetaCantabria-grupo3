package org.example.javaapp.controller;

import org.example.javaapp.model.PuntosInteres;
import org.example.javaapp.service.ServicePuntosInteres;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/reta3/puntosinteres")
public class PuntosInteresController {

    private final ServicePuntosInteres service;

    public PuntosInteresController(ServicePuntosInteres service){
        this.service=service;
    }

    @PostMapping
    public PuntosInteres insert(@RequestBody PuntosInteres puntosInteres){
        return service.insert(puntosInteres);
    }

    @DeleteMapping("/{id}")
    public void delete(@PathVariable int id){
        service.delete(id);
    }

    @PutMapping("/{id}")
    public PuntosInteres update(@PathVariable int id, @RequestBody PuntosInteres puntosInteres){
        return service.update(id, puntosInteres);
    }

    @GetMapping("/{id}")
    public PuntosInteres findById(@PathVariable int id){
        return service.findById(id);
    }

    @GetMapping
    public List<PuntosInteres> findAll(){
        return service.findAll();
    }
}
