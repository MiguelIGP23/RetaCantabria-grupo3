package org.example.javaapp.controller;

import org.example.javaapp.dto.LoginRequest;
import org.example.javaapp.dto.LoginResponse;
import org.example.javaapp.model.Usuario;
import org.example.javaapp.service.ServiceLogin;
import org.springframework.http.ResponseEntity;
import org.springframework.security.core.Authentication;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/api/reta3/auth")
public class LoginController {

    private final ServiceLogin service;

    public LoginController(ServiceLogin service) {
        this.service=service;
    }


    @PostMapping("/login")
    public ResponseEntity<LoginResponse> login(@RequestBody LoginRequest loginRequest){
        Usuario usuario = service.validarLogin(loginRequest.getEmail(), loginRequest.getPassword());

        if(usuario==null){
            return ResponseEntity.status(401).build();
        }

        String token = service.generarToken(usuario);
        return ResponseEntity.ok(new LoginResponse(token, usuario.getRol().name(), usuario.getId()));
    }

}
