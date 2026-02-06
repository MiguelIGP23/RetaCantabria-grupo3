package org.example.javaapp.controller;

import org.example.javaapp.model.Actividad;
import org.example.javaapp.service.ServiceActividad;
import org.example.javaapp.service.ServiceRuta;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/reta3/rutas")
public class ActividadController {

    private final ServiceActividad serviceActividad;

    public ActividadController(ServiceActividad serviceActividad){
        this.serviceActividad=serviceActividad;
    }

    @PostMapping("/{idRuta}/actividades")
    public Actividad insert(@PathVariable int idRuta, @RequestBody Actividad actividad){
        return serviceActividad.insertInRuta(idRuta, actividad);
    }

    @GetMapping("/{idRuta}/actividades")
    public List<Actividad> getAll(@PathVariable int idRuta){
        return serviceActividad.findAllByRuta(idRuta);
    }

    @GetMapping("/{idRuta}/actividades/{idActividad}")
    public Actividad getById(@PathVariable int idActividad, @PathVariable int idRuta){
        return serviceActividad.findByRutaAndId(idActividad, idRuta).orElse(null);
    }

    @DeleteMapping("/{idRuta}/actividades/{idActividad}")
    public void delete(@PathVariable int idRuta, @PathVariable int idActividad){
        serviceActividad.deleteFromRuta(idActividad, idRuta);
    }

    @PutMapping("/{idRuta}/actividades/{idActividad}")
    public Actividad update(@PathVariable int idRuta, @PathVariable int idActividad,@RequestBody Actividad actividad){
        return serviceActividad.updateInRuta(idActividad, idRuta, actividad);
    }
}
