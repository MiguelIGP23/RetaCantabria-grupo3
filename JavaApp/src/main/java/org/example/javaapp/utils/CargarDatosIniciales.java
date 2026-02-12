package org.example.javaapp.utils;

import org.example.javaapp.model.Rol;
import org.example.javaapp.model.Usuario;
import org.example.javaapp.repository.UsuarioRepository;
import org.springframework.boot.CommandLineRunner;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Component;

@Component
public class CargarDatosIniciales implements CommandLineRunner {

    private final UsuarioRepository repoUsuario;
    private final PasswordEncoder passwordEncoder; // si usas Spring Security

    public CargarDatosIniciales(UsuarioRepository repoUsuario, PasswordEncoder passwordEncoder) {
        this.repoUsuario = repoUsuario;
        this.passwordEncoder = passwordEncoder;
    }

    @Override
    public void run(String... args){
        if (repoUsuario.findByEmail("admin@admin.com").isEmpty()) {
            Usuario admin = new Usuario();
            admin.setNombre("admin");
            admin.setApellido("admin");
            admin.setEmail("admin@admin.com");
            admin.setPassword(passwordEncoder.encode("admin"));
            admin.setRol(Rol.ADMINISTRADOR);
            repoUsuario.save(admin);
        }
    }
}
