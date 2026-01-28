package org.example.javaapp.controller;

import org.example.javaapp.model.Valora;
import org.example.javaapp.service.ServiceValoracion;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("api/reta3/valora")
public class ValoracionController {

    private ServiceValoracion service;
    public ValoracionController(ServiceValoracion service) {
        this.service = service;
    }

    @PostMapping
    public Valora insert(@RequestBody Valora valora) {
        return service.insert(valora);
    }

    @DeleteMapping
    public void delete(@RequestBody int id) {
        service.delete(id);
    }
    @PutMapping("/{id}")
    public Valora update(@PathVariable int id, @RequestBody Valora valora) {
        return service.update(id,valora);
    }

    @Get
}
