package org.example.javaapp.controller;

import org.example.javaapp.model.Usuario;
import org.example.javaapp.service.ServiceUsuario;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/reta3/usuarios")
public class UsuarioController {

    private final ServiceUsuario service;

    public UsuarioController(ServiceUsuario service){
        this.service=service;
    }

    @PostMapping
    public Usuario insert(@RequestBody Usuario usuario){
        return service.insert(usuario);
    }

    @DeleteMapping("/{id}")
    public void delete(@PathVariable int id){
        service.delete(id);
    }

    @PutMapping("/{id}")
    public Usuario update(@PathVariable int id, @RequestBody Usuario usuario){
        return service.update(id, usuario);
    }

    @GetMapping("/{id}")
    public Usuario findById(@PathVariable int id){
        return service.findById(id);
    }

    @GetMapping
    public List<Usuario> findAll(){
        return service.findAll();
    }
}
