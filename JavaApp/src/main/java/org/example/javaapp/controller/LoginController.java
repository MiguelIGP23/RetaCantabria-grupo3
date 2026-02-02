package org.example.javaapp.controller;

import org.example.javaapp.dto.LoginRequest;
import org.example.javaapp.model.Usuario;
import org.example.javaapp.repository.UsuarioRepository;
import org.example.javaapp.service.ServiceLogin;
import org.springframework.http.ResponseEntity;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/api/reta3/auth/")
public class LoginController {

    private final ServiceLogin service;

    public LoginController(ServiceLogin service) {
        this.service=service;
    }


    @PostMapping("/login")
    public ResponseEntity<String> login(@RequestBody LoginRequest request){
        Usuario usuario = service.validarLogin(request.getEmail(), request.getPassword());

        if(usuario==null){
            return ResponseEntity.status(401).body("Credenciales incorrectas");
        }

        return ResponseEntity.ok(("LOGIN OK -> rol: "+usuario.getRol()));
    }
}
