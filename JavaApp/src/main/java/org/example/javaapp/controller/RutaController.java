package org.example.javaapp.controller;


import org.example.javaapp.export.FichaOrganizacionGenerator;
import org.example.javaapp.export.FichaSeguridadGenerator;
import org.example.javaapp.export.FichaUsuarioGenerator;
import org.example.javaapp.model.PuntosInteres;
import org.example.javaapp.model.PuntosPeligro;
import org.example.javaapp.model.Ruta;
import org.example.javaapp.service.ServicePuntosInteres;
import org.example.javaapp.service.ServicePuntosPeligro;
import org.example.javaapp.service.ServiceRuta;
import org.springframework.http.HttpHeaders;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/reta3/rutas")
public class RutaController {

    private final ServiceRuta serviceRuta;
    private final ServicePuntosPeligro servicePuntoPeligro;
    private final ServicePuntosInteres servicePuntosInteres;

    public RutaController(ServiceRuta serviceRuta, ServicePuntosPeligro servicePuntoPeligro, ServicePuntosInteres servicePuntosInteres) {
        this.serviceRuta = serviceRuta;
        this.servicePuntoPeligro = servicePuntoPeligro;
        this.servicePuntosInteres = servicePuntosInteres;
    }


    // Endpoints comunes

    @PostMapping()
    public Ruta insert(@RequestBody Ruta ruta) {
        return serviceRuta.insert(ruta);
    }

    @GetMapping()
    public List<Ruta> getAll() {
        return serviceRuta.findAll();
    }

    @GetMapping("/{id}")
    public Ruta getById(@PathVariable int id) {
        return serviceRuta.findById(id);
    }

    @DeleteMapping("/{id}")
    public void delete(@PathVariable int id) {
        serviceRuta.delete(id);
    }

    @PutMapping("/{id}")
    public Ruta update(@PathVariable int id, @RequestBody Ruta ruta) {
        return serviceRuta.update(id, ruta);
    }



    // Endpoints para validar rutas y ver rutas validadas

    @PutMapping("/{id}/validar")
    public Ruta validar(@PathVariable int id) {
        return serviceRuta.validar(id);
    }

    @GetMapping("/validadas")
    public List<Ruta> getValidadas() {
        return serviceRuta.findValidadas();
    }



    //Endpoints para descarga de ficheros

    @GetMapping("/{id}/fichas/organizacion")
    public ResponseEntity<byte[]> descargarFichaOrganizacion(@PathVariable int id) {
        Ruta ruta = serviceRuta.findById(id);
        if (ruta == null) return ResponseEntity.notFound().build();
        FichaOrganizacionGenerator gen = new FichaOrganizacionGenerator();
        byte[] datos = gen.generar(ruta);
        String nombre = gen.nombreArchivo(ruta);

        return ResponseEntity.ok().header(HttpHeaders.CONTENT_DISPOSITION, "attachment; filename=\"" + nombre + "\"")
                .contentType(MediaType.TEXT_PLAIN)
                .body(datos);
    }

    @GetMapping("/{id}/fichas/seguridad")
    public ResponseEntity<byte[]> descargarFichaSeguridad(@PathVariable int id) {
        Ruta ruta = serviceRuta.findById(id);
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

    @GetMapping("/{id}/fichas/usuario")
    public ResponseEntity<byte[]> descargarFichaUsuario(@PathVariable int id) {
        Ruta ruta = serviceRuta.findById(id);
        if (ruta == null) return ResponseEntity.notFound().build();


        List<PuntosInteres> pInteres = servicePuntosInteres.findByIdRuta(id);
        List<PuntosPeligro> pPeligro = servicePuntoPeligro.findByIdruta(id);

        FichaUsuarioGenerator gen = new FichaUsuarioGenerator();
        byte[] bytes = gen.generar(ruta, pInteres, pPeligro);
        String filename = gen.nombreArchivo(ruta);

        return ResponseEntity.ok()
                .header(HttpHeaders.CONTENT_DISPOSITION, "attachment; filename=\"" + filename + "\"")
                .contentType(MediaType.TEXT_PLAIN)
                .body(bytes);
    }

}
















