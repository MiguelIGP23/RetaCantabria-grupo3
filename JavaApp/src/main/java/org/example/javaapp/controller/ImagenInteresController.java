package org.example.javaapp.controller;

import org.example.javaapp.model.ImagenesInteres;
import org.example.javaapp.service.ServiceImagenInteres;
import org.springframework.security.core.parameters.P;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("api/reta3/rutas")
public class ImagenInteresController {
    ServiceImagenInteres service;

    public ImagenInteresController(ServiceImagenInteres service) {
        this.service = service;
    }

    @PostMapping("/{idRuta}/puntosinteres/{idPunto}/imagenes")
    public ImagenesInteres insert(@PathVariable int idRuta, @PathVariable int idPunto, @RequestBody ImagenesInteres imagenesInteres) {
        return service.insertInPunto(idRuta, idPunto, imagenesInteres);
    }

    @GetMapping("/{idRuta}/puntosinteres/{idPunto}/imagenes")
    public List<ImagenesInteres> getAll(@PathVariable int idRuta, @PathVariable int idPunto) {
        return service.findAllByPunto(idRuta, idPunto);
    }

    @GetMapping("/{idRuta}/puntosinteres/{idPunto}/imagenes/{idImagen}")
    public ImagenesInteres getById(@PathVariable int idRuta, @PathVariable int idPunto, @PathVariable int idImagen) {
        return service.findByPuntoAndId(idRuta, idPunto, idImagen).orElse(null);
    }

    @DeleteMapping("/{idRuta}/puntosinteres/{idPunto}/imagenes/{idImagen}")
    public void delete(@PathVariable int idRuta, @PathVariable int idPunto, @PathVariable int idImagen) {
        service.deleteFromPunto(idRuta, idPunto, idImagen);
    }

    @PutMapping("/{idRuta}/puntosinteres/{idPunto}/imagenes/{idImagen}")
    public ImagenesInteres update(@PathVariable int idRuta, @PathVariable int idPunto, @PathVariable int idImagen, @RequestBody ImagenesInteres imagenesInteres) {
        return service.updateInPunto(idRuta, idPunto, idImagen, imagenesInteres);
    }

}
