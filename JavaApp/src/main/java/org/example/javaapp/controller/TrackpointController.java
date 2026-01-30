package org.example.javaapp.controller;

import org.example.javaapp.model.Trackpoint;
import org.example.javaapp.model.TrackpointId;
import org.example.javaapp.service.ServiceTrackpoint;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/reta3")
public class TrackpointController {

    private final ServiceTrackpoint service;

    public TrackpointController(ServiceTrackpoint service){
        this.service=service;
    }

    @GetMapping("/trackpoints")
    public List<Trackpoint> findAll(){
        return service.findAll();
    }

    @GetMapping("/rutas/{idRuta}/trackpoints")
    public List<Trackpoint> findByRuta(@PathVariable Integer idRuta){
        return service.findByRuta(idRuta);
    }

    @GetMapping("/rutas/{idRuta}/trackpoints/{posicion}")
    public Trackpoint findByRutaAndPosition(@PathVariable Integer idRuta, @PathVariable Integer posicion){
        return service.findById(idRuta, posicion);
    }

    @PostMapping("/rutas/{idRuta}/trackpoints")
    public Trackpoint insert(@PathVariable Integer idRuta, @RequestBody Trackpoint trackpoint){
        return service.insert(idRuta, trackpoint);
    }

    @PutMapping("/rutas/{idRuta}/trackpoints/{posicion}")
    public Trackpoint update(@PathVariable Integer idRuta, @PathVariable Integer posicion, @RequestBody Trackpoint trackpoint){
        return service.update(idRuta, posicion, trackpoint);
    }

    @DeleteMapping("/rutas/{idRuta}/trackpoints/{posicion}")
    public void delete(@PathVariable Integer idRuta, @PathVariable Integer posicion){
        service.delete(idRuta, posicion);
    }


}
