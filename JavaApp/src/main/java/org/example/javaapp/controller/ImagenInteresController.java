package org.example.javaapp.controller;

import org.example.javaapp.model.ImagenesInteres;
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
    public ImagenesInteres insert(@RequestBody ImagenesInteres imagenesInteres) {
        return service.insert(imagenesInteres);
    }

    @GetMapping()
    public List<ImagenesInteres> getAll() {
        return service.findAll();
    }

    @GetMapping("/{id}")
    public ImagenesInteres getById(@PathVariable int id) {
        return service.findById(id);
    }

    @DeleteMapping("/{id}")
    public void delete(@PathVariable int id) {
        service.delete(id);
    }

    @PutMapping("/{id}")
    public ImagenesInteres update(@PathVariable int id, @RequestBody ImagenesInteres imagenesInteres) {
        return service.update(id, imagenesInteres);
    }

}
