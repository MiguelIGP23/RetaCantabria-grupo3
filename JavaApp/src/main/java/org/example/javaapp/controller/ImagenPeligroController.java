package org.example.javaapp.controller;

import org.example.javaapp.model.Imagenespeligro;
import org.example.javaapp.model.Ruta;
import org.example.javaapp.service.ServiceImagenPeligro;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("api/reta3/imagenespeligro")
public class ImagenPeligroController {
    ServiceImagenPeligro service;

    public ImagenPeligroController(ServiceImagenPeligro service) {
        this.service = service;
    }

    @PostMapping()
    public Imagenespeligro insert(@RequestBody Imagenespeligro imagenespeligro) {
        return service.insert(imagenespeligro);
    }

    @GetMapping()
    public List<Imagenespeligro> getAll() {
        return service.findAll();
    }

    @GetMapping("/{id}")
    public Imagenespeligro getById(@PathVariable int id) {
        return service.findById(id);
    }

    @DeleteMapping("/{id}")
    public void delete(@PathVariable int id) {
        service.delete(id);
    }

    @PutMapping("/{id}")
    public Imagenespeligro update(@PathVariable int id, @RequestBody Imagenespeligro imagenespeligro) {
        return service.update(id, imagenespeligro);
    }
}
