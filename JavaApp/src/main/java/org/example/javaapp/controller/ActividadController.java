package org.example.javaapp.controller;

import org.example.javaapp.model.Actividad;
import org.example.javaapp.service.ServiceActividad;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/reta3/actividades")
public class ActividadController {

    private ServiceActividad service;

    public ActividadController(ServiceActividad service){
        this.service=service;
    }

    @PostMapping()
    public Actividad insert(@RequestBody Actividad actividad){
        return service.insert(actividad);
    }

    @GetMapping()
    public List<Actividad> getAll(){
        return service.findAll();
    }

    @GetMapping("/{id}")
    public Actividad getById(@PathVariable int id){
        return service.findById(id);
    }

    @DeleteMapping("/{id}")
    public void delete(@PathVariable int id){
        service.delete(id);
    }

    @PutMapping("/{id}")
    public Actividad update(@PathVariable int id, @RequestBody Actividad actividad){
        return service.update(id, actividad);
    }
}
