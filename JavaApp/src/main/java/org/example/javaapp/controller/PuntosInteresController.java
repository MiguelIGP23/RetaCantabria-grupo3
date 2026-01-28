package org.example.javaapp.controller;

import org.example.javaapp.model.Puntosintere;
import org.example.javaapp.model.Usuario;
import org.example.javaapp.service.ServicePuntosInteres;
import org.example.javaapp.service.ServiceUsuario;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/puntosinteres")
public class PuntosInteresController {

    private ServicePuntosInteres service;

    public PuntosInteresController(ServicePuntosInteres service){
        this.service=service;
    }

    @PostMapping
    public Puntosintere insert(@RequestBody Puntosintere puntosInteres){
        return service.insert(puntosInteres);
    }

    @DeleteMapping("/{id}")
    public void delete(@PathVariable int id){
        service.delete(id);
    }

    @PutMapping("/{id}")
    public Puntosintere update(@PathVariable int id, @RequestBody Puntosintere puntosintere){
        return service.update(id, puntosintere);
    }

    @GetMapping("/{id}")
    public Puntosintere findById(@PathVariable int id){
        return service.findById(id);
    }

    @GetMapping
    public List<Puntosintere> findAll(){
        return service.findAll();
    }
}
