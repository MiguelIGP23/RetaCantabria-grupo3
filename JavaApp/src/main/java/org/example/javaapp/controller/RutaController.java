package org.example.javaapp.controller;


import org.example.javaapp.export.FichaOrganizacionGenerator;
import org.example.javaapp.export.FichaSeguridadGenerator;
import org.example.javaapp.model.PuntosPeligro;
import org.example.javaapp.model.Ruta;
import org.example.javaapp.service.ServicePuntosPeligro;
import org.example.javaapp.service.ServiceRuta;
import org.springframework.http.HttpHeaders;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.awt.*;
import java.util.List;

@RestController
@RequestMapping("/api/reta3/rutas")
public class RutaController {

    private final ServiceRuta service;
    private final ServicePuntosPeligro servicePuntoPeligro;

    public RutaController(ServiceRuta service, ServicePuntosPeligro servicePuntoPeligro){
        this.service=service;
        this.servicePuntoPeligro = servicePuntoPeligro;
    }

    // Endpoints comunes

    @PostMapping()
    public Ruta insert(@RequestBody Ruta ruta){
        return service.insert(ruta);
    }

    @GetMapping()
    public List<Ruta> getAll(){
        return service.findAll();
    }

    @GetMapping("/{id}")
    public Ruta getById(@PathVariable int id){
        return service.findById(id);
    }

    @DeleteMapping("/{id}")
    public void delete(@PathVariable int id){
        service.delete(id);
    }

    @PutMapping("/{id}")
    public Ruta update(@PathVariable int id, @RequestBody Ruta ruta){
        return service.update(id, ruta);
    }

    // Endpoints para validar rutas y ver rutas validadas
        @PostMapping("/{id}/validar")
    public Ruta validar(@PathVariable int id){
        return service.validar(id);
    }

    @GetMapping("/validadas")
    public List<Ruta> getValidadas(){
        return service.findValidadas();
    }

    //Endpoint para descarga de ficheros
    @GetMapping("/{id}/fichas/organizacion")
    public ResponseEntity<byte[]> descargarFichaOrganizacion(@PathVariable int id){
        Ruta ruta = service.findById(id);
        if (ruta == null) return ResponseEntity.notFound().build();
        FichaOrganizacionGenerator gen = new FichaOrganizacionGenerator();
        byte[] datos = gen.generar(ruta);
        String nombre = gen.nombreArchivo(ruta);

        return ResponseEntity.ok().header(HttpHeaders.CONTENT_DISPOSITION, "attachment; filename=\"" + nombre+ "\"")
                .contentType(MediaType.TEXT_PLAIN)
                .body(datos);
    }

    @GetMapping("/{id}/fichas/seguridad")
    public ResponseEntity<byte[]> descargarFichaSeguridad(@PathVariable int id) {
        Ruta ruta = service.findById(id);
        if (ruta == null) return ResponseEntity.notFound().build();

        List<PuntosPeligro> puntos = servicePuntoPeligro.findByIdruta(id);

        FichaSeguridadGenerator gen = new FichaSeguridadGenerator();
        byte[] bytes = gen.generar(ruta, puntos);
        String filename = gen.nombreArchivo(ruta);

        return ResponseEntity.ok()
                .header(HttpHeaders.CONTENT_DISPOSITION, "attachment; filename=\"" + filename + "\"")
                .contentType(MediaType.TEXT_PLAIN)
                .body(bytes);
    }
}
















