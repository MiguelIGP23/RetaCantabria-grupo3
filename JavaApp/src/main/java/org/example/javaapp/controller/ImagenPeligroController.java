package org.example.javaapp.controller;

import org.example.javaapp.model.ImagenesPeligro;
import org.example.javaapp.service.ServiceImagenPeligro;
import org.springframework.security.core.parameters.P;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/reta3/rutas")
public class ImagenPeligroController {

    private final ServiceImagenPeligro service;

    public ImagenPeligroController(ServiceImagenPeligro service) {
        this.service = service;
    }

    @PostMapping("/{idRuta}/puntospeligro/{idPunto}/imagenes")
    public ImagenesPeligro insert(@PathVariable int idRuta, @PathVariable int idPunto, @RequestBody ImagenesPeligro imagenespeligro) {
        return service.insertInPunto(idRuta, idPunto, imagenespeligro);
    }

    @GetMapping("/{idRuta}/puntospeligro/{idPunto}/imagenes")
    public List<ImagenesPeligro> getAll(@PathVariable int idRuta, @PathVariable int idPunto) {
        return service.findAllByPunto(idRuta, idPunto);
    }

    @GetMapping("/{idRuta}/puntospeligro/{idPunto}/imagenes/{idImagen}")
    public ImagenesPeligro getById(@PathVariable int idRuta, @PathVariable int idPunto, @PathVariable int idImagen) {
        return service.findByPuntoAndId(idRuta, idPunto, idImagen).orElse(null);
    }

    @DeleteMapping("/{idRuta}/puntospeligro/{idPunto}/imagenes/{idImagen}")
    public void delete(@PathVariable int idRuta, @PathVariable int idPunto, @PathVariable int idImagen) {
        service.deleteFromPunto(idRuta, idPunto, idImagen);
    }

    @PutMapping("/{idRuta}/puntospeligro/{idPunto}/imagenes/{idImagen}")
    public ImagenesPeligro update(@PathVariable int idRuta, @PathVariable int idPunto, @PathVariable int idImagen, @RequestBody ImagenesPeligro imagenespeligro) {
        return service.updateInPunto(idRuta, idPunto, idImagen, imagenespeligro);
    }
}
