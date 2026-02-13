package org.example.javaapp.security;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.core.convert.converter.Converter;
import org.springframework.http.HttpMethod;
import org.springframework.security.authentication.AbstractAuthenticationToken;
import org.springframework.security.config.annotation.web.builders.HttpSecurity;
import org.springframework.security.config.annotation.web.configuration.EnableWebSecurity;
import org.springframework.security.config.http.SessionCreationPolicy;
import org.springframework.security.core.authority.SimpleGrantedAuthority;
import org.springframework.security.oauth2.jwt.Jwt;
import org.springframework.security.oauth2.server.resource.authentication.JwtAuthenticationToken;
import org.springframework.security.web.SecurityFilterChain;

import java.util.List;

@Configuration
@EnableWebSecurity
public class SecurityConfig {

    @Bean
    public SecurityFilterChain securityFilterChain(HttpSecurity http) throws Exception {
        http
                .csrf(csfr -> csfr.disable())
                .sessionManagement(sm -> sm.sessionCreationPolicy(SessionCreationPolicy.STATELESS))
                .authorizeHttpRequests(auth -> auth

                        // ================= AUTH =================
                        .requestMatchers(HttpMethod.POST, "/api/reta3/auth/login").permitAll()

                        // ================= USUARIOS =================
                        .requestMatchers(HttpMethod.POST, "/api/reta3/usuarios").permitAll()
                        .requestMatchers(HttpMethod.PUT, "/api/reta3/usuarios/**").hasRole("ADMINISTRADOR")

                        // ================= CATÁLOGO PÚBLICO (SIN REGISTRO) =================
                        .requestMatchers(HttpMethod.GET, "/api/reta3/rutas/validadas").permitAll()
                        .requestMatchers(HttpMethod.GET, "/api/reta3/rutas/validadas/**").permitAll()

                        // puntos (interés y peligro) públicos
                        .requestMatchers(HttpMethod.GET, "/api/reta3/rutas/*/puntosinteres/**").permitAll()
                        .requestMatchers(HttpMethod.GET, "/api/reta3/rutas/*/puntospeligro/**").permitAll()

                        // imágenes (interés y peligro) públicas (lista + detalle)
                        .requestMatchers(HttpMethod.GET, "/api/reta3/rutas/*/puntosinteres/*/imagenes/**").permitAll()
                        .requestMatchers(HttpMethod.GET, "/api/reta3/rutas/*/puntospeligro/*/imagenes/**").permitAll()

                        // ✅ valoraciones públicas (lista + detalle)
                        .requestMatchers(HttpMethod.GET, "/api/reta3/rutas/*/valoraciones/**").permitAll()

                        // ✅ actividades públicas (lista + detalle)
                        .requestMatchers(HttpMethod.GET, "/api/reta3/rutas/*/actividades/**").permitAll()

                        // ================= ALUMNO (REGISTRADO) =================
                        // Crear imágenes interés/peligro: ALUMNO y superiores
                        .requestMatchers(HttpMethod.POST, "/api/reta3/rutas/*/puntosinteres/*/imagenes")
                        .hasAnyRole("ALUMNO", "DISENADOR", "PROFESOR", "ADMINISTRADOR")

                        .requestMatchers(HttpMethod.POST, "/api/reta3/rutas/*/puntospeligro/*/imagenes")
                        .hasAnyRole("ALUMNO", "DISENADOR", "PROFESOR", "ADMINISTRADOR")

                        // Crear valoraciones: ALUMNO y superiores
                        .requestMatchers(HttpMethod.POST, "/api/reta3/rutas/*/valoraciones")
                        .hasAnyRole("ALUMNO", "DISENADOR", "PROFESOR", "ADMINISTRADOR")

                        // Editar / borrar valoraciones: SOLO ADMIN
                        .requestMatchers(HttpMethod.PUT, "/api/reta3/rutas/*/valoraciones/**")
                        .hasRole("ADMINISTRADOR")
                        .requestMatchers(HttpMethod.DELETE, "/api/reta3/rutas/*/valoraciones/**")
                        .hasRole("ADMINISTRADOR")

                        // Editar / borrar imágenes (interés y peligro): SOLO ADMIN
                        .requestMatchers(HttpMethod.PUT, "/api/reta3/rutas/*/puntosinteres/*/imagenes/**")
                        .hasRole("ADMINISTRADOR")
                        .requestMatchers(HttpMethod.DELETE, "/api/reta3/rutas/*/puntosinteres/*/imagenes/**")
                        .hasRole("ADMINISTRADOR")

                        .requestMatchers(HttpMethod.PUT, "/api/reta3/rutas/*/puntospeligro/*/imagenes/**")
                        .hasRole("ADMINISTRADOR")
                        .requestMatchers(HttpMethod.DELETE, "/api/reta3/rutas/*/puntospeligro/*/imagenes/**")
                        .hasRole("ADMINISTRADOR")

                        // ================= DISENADOR / PROFESOR / ADMIN =================

                        // rutas/gpx admin + diseñador + profesor
                        .requestMatchers(HttpMethod.POST, "/api/reta3/rutas/gpx")
                        .hasAnyRole("DISENADOR", "PROFESOR", "ADMINISTRADOR")

                        // Crear rutas y datos bajo /rutas/**
                        .requestMatchers(HttpMethod.POST, "/api/reta3/rutas/**")
                        .hasAnyRole("DISENADOR", "PROFESOR", "ADMINISTRADOR")

                        // Descargar fichas
                        .requestMatchers(HttpMethod.GET, "/api/reta3/rutas/*/fichas/**")
                        .hasAnyRole("DISENADOR", "PROFESOR", "ADMINISTRADOR")

                        // Confirmar borrador (diseñador/profesor/admin)
                        .requestMatchers(HttpMethod.PUT, "/api/reta3/rutas/*/confirmar")
                        .hasAnyRole("DISENADOR", "PROFESOR", "ADMINISTRADOR")

                        // Cancelar borrador (diseñador/profesor/admin)
                        .requestMatchers(HttpMethod.DELETE, "/api/reta3/rutas/*/borrador")
                        .hasAnyRole("DISENADOR", "PROFESOR", "ADMINISTRADOR")

                        // Modificar / borrar rutas: SOLO ADMIN
                        .requestMatchers(HttpMethod.PUT, "/api/reta3/rutas/**")
                        .hasRole("ADMINISTRADOR")
                        .requestMatchers(HttpMethod.DELETE, "/api/reta3/rutas/**")
                        .hasRole("ADMINISTRADOR")

                        .requestMatchers(HttpMethod.PUT, "/api/reta3/rutas/*/validar")
                        .hasRole("ADMINISTRADOR")

                        // ================= RESTO =================
                        .anyRequest().authenticated()
                )
                .oauth2ResourceServer(oauth -> oauth
                        .jwt(jwt -> jwt.jwtAuthenticationConverter(jwtAuthenticationConverter()))
                );

        return http.build();
    }

    @Bean
    public Converter<Jwt, ? extends AbstractAuthenticationToken> jwtAuthenticationConverter() {
        return jwt -> {
            String rol = jwt.getClaimAsString("rol");
            var authorities = List.of(new SimpleGrantedAuthority("ROLE_" + rol));
            return new JwtAuthenticationToken(jwt, authorities);
        };
    }
}
