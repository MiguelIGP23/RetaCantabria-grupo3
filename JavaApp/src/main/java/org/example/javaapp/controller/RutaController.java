package org.example.javaapp.controller;


import org.example.javaapp.dto.DtoRuta;
import org.example.javaapp.dto.MapperRuta;
import org.example.javaapp.export.FichaOrganizacionGenerator;
import org.example.javaapp.export.FichaSeguridadGenerator;
import org.example.javaapp.export.FichaUsuarioGenerator;
import org.example.javaapp.model.PuntosInteres;
import org.example.javaapp.model.PuntosPeligro;
import org.example.javaapp.model.Ruta;
import org.example.javaapp.model.Usuario;
import org.example.javaapp.service.ServicePuntosInteres;
import org.example.javaapp.service.ServicePuntosPeligro;
import org.example.javaapp.service.ServiceRuta;
import org.example.javaapp.service.ServiceUsuario;
import org.springframework.http.HttpHeaders;
import org.springframework.http.HttpStatus;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.server.ResponseStatusException;

import java.util.List;

@RestController
@RequestMapping("/api/reta3/rutas")
public class RutaController {

    private final ServiceRuta serviceRuta;
    private final ServiceUsuario serviceUsuario;
    private final ServicePuntosPeligro servicePuntoPeligro;
    private final ServicePuntosInteres servicePuntosInteres;

    public RutaController(ServiceRuta serviceRuta, ServiceUsuario serviceUsuario, ServicePuntosPeligro servicePuntoPeligro, ServicePuntosInteres servicePuntosInteres) {
        this.serviceRuta = serviceRuta;
        this.serviceUsuario = serviceUsuario;
        this.servicePuntoPeligro = servicePuntoPeligro;
        this.servicePuntosInteres = servicePuntosInteres;
    }


    // Endpoints comunes

    @PostMapping()
    public DtoRuta insert(@RequestBody DtoRuta dto) {
        Usuario usu = serviceUsuario.findById(dto.usuarioId());
        if (usu == null)
            throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Usuario no encontrado");

        Ruta entidad = MapperRuta.toEntity(dto, usu);
        entidad.setId(null);
        Ruta nueva = serviceRuta.insert(entidad);
        return MapperRuta.toDto(nueva);
    }


    @GetMapping()
    public List<DtoRuta> getAll() {
        return serviceRuta.findAll().stream().map(MapperRuta::toDto).toList();
    }


    @GetMapping("/{id}")
    public DtoRuta getById(@PathVariable int id) {
        return MapperRuta.toDto(serviceRuta.findById(id));
    }


    @DeleteMapping("/{id}")
    public void delete(@PathVariable int id) {
        serviceRuta.delete(id);
    }


    @PutMapping("/{id}")
    public DtoRuta update(@PathVariable int id, @RequestBody DtoRuta dto) {
        if (dto.usuarioId() == null)
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "usuarioId es obligatorio");

        Usuario usu = serviceUsuario.findById(dto.usuarioId());
        if (usu == null)
            throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Usuario no encontrado");

        Ruta entidad = MapperRuta.toEntity(dto, usu);
        Ruta nueva = serviceRuta.update(id, entidad);
        return MapperRuta.toDto(nueva);
    }



    // Endpoints para validar rutas y ver rutas validadas

    @PutMapping("/{id}/validar")
    public DtoRuta validar(@PathVariable int id) {
        return MapperRuta.toDto(serviceRuta.validar(id));
    }


    @GetMapping("/validadas")
    public List<DtoRuta> getValidadas() {
        return serviceRuta.findValidadas().stream().map(MapperRuta::toDto).toList();
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
















