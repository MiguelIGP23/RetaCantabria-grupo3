package org.example.javaapp.service;

import org.example.javaapp.model.Usuario;
import org.example.javaapp.repository.UsuarioRepository;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Service;

@Service
public class ServiceLogin {

    private final UsuarioRepository usuarioRepository;
    private final PasswordEncoder passwordEncoder;

    public ServiceLogin(UsuarioRepository usuarioRepository, PasswordEncoder passwordEncoder) {
        this.usuarioRepository = usuarioRepository;
        this.passwordEncoder = passwordEncoder;
    }

    public Usuario validarLogin(String email, String password) {
        Usuario usuario = usuarioRepository.findByEmail(email).orElse(null);
        if (usuario == null) return null;

        boolean ok = passwordEncoder.matches(password, usuario.getPassword());
        if (!passwordEncoder.matches(password, usuario.getPassword())) return null;

        return usuario; // login correcto
    }
}
