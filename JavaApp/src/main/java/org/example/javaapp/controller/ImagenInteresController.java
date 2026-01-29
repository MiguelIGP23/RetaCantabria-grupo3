package org.example.javaapp.controller;

import org.example.javaapp.model.Imagenesintere;
import org.example.javaapp.model.Imagenespeligro;
import org.example.javaapp.service.ServiceImagenInteres;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("api/reta3/imagenesinteres")
public class ImagenInteresController {
    ServiceImagenInteres service;

    public ImagenInteresController(ServiceImagenInteres service) {
        this.service = service;
    }

    @PostMapping()
    public Imagenesintere insert(@RequestBody Imagenesintere imagenesintere) {
        return service.insert(imagenesintere);
    }

    @GetMapping()
    public List<Imagenesintere> getAll() {
        return service.findAll();
    }

    @GetMapping("/{id}")
    public Imagenesintere getById(@PathVariable int id) {
        return service.findById(id);
    }

    @DeleteMapping("/{id}")
    public void delete(@PathVariable int id) {
        service.delete(id);
    }

    @PutMapping("/{id}")
    public Imagenesintere update(@PathVariable int id, @RequestBody Imagenesintere imagenesintere) {
        return service.update(id, imagenesintere);
    }

}
