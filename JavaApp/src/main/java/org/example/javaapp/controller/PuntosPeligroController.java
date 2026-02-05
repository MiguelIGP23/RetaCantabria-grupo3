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

    @PostMapping
    public PuntosPeligro insert(@RequestBody PuntosPeligro puntospeligro){
        return service.insert(puntospeligro);
    }

    @DeleteMapping("/{id}")
    public void delete(@PathVariable int id){
        service.delete(id);
    }

    @PutMapping("/{id}")
    public PuntosPeligro update(@PathVariable int id, @RequestBody PuntosPeligro puntospeligro){
        return service.update(id, puntospeligro);
    }

//    @GetMapping("/{id}")
//    public PuntosPeligro findById(@PathVariable int id){
//        return service.findById(id);
//    }

    @GetMapping("/{id}/puntospeligro")
    public List<PuntosPeligro> findAll(@PathVariable int id){
        return service.findByIdruta(id);
    }


}
