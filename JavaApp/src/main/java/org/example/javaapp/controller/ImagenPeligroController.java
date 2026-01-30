package org.example.javaapp.controller;

import org.example.javaapp.model.ImagenesPeligro;
import org.example.javaapp.service.ServiceImagenPeligro;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("api/reta3/imagenespeligro")
public class ImagenPeligroController {

    private final ServiceImagenPeligro service;

    public ImagenPeligroController(ServiceImagenPeligro service) {
        this.service = service;
    }

    @PostMapping()
    public ImagenesPeligro insert(@RequestBody ImagenesPeligro imagenespeligro) {
        return service.insert(imagenespeligro);
    }

    @GetMapping()
    public List<ImagenesPeligro> getAll() {
        return service.findAll();
    }

    @GetMapping("/{id}")
    public ImagenesPeligro getById(@PathVariable int id) {
        return service.findById(id);
    }

    @DeleteMapping("/{id}")
    public void delete(@PathVariable int id) {
        service.delete(id);
    }

    @PutMapping("/{id}")
    public ImagenesPeligro update(@PathVariable int id, @RequestBody ImagenesPeligro imagenespeligro) {
        return service.update(id, imagenespeligro);
    }
}
