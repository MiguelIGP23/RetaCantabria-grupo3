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
    public SecurityFilterChain securityFilterChain(HttpSecurity http) throws Exception{
        http
                .csrf(csfr -> csfr.disable())
                .sessionManagement(sm -> sm.sessionCreationPolicy(SessionCreationPolicy.STATELESS))
                .authorizeHttpRequests(auth -> auth
                        // ================= AUTH =================
                        .requestMatchers(HttpMethod.POST, "/api/reta3/auth/login").permitAll()

                        // ================= CATALOGO PUBLICO (SIN REGISTRO) =================
                        .requestMatchers(HttpMethod.GET, "/api/reta3/rutas/validadas").permitAll()
                        .requestMatchers(HttpMethod.GET, "/api/reta3/rutas/validadas/**").permitAll()

                        .requestMatchers(HttpMethod.GET, "/api/reta3/rutas/*/puntosinteres/**").permitAll()
                        .requestMatchers(HttpMethod.GET, "/api/reta3/rutas/*/puntospeligro/**").permitAll()
                        .requestMatchers(HttpMethod.GET, "/api/reta3/rutas/*/imagenesinteres/**").permitAll()
                        .requestMatchers(HttpMethod.GET, "/api/reta3/rutas/*/imagenespeligro/**").permitAll()

                        .requestMatchers(HttpMethod.GET, "/api/reta3/valoraciones/**").permitAll()
                        .requestMatchers(HttpMethod.GET, "/api/reta3/actividades/**").permitAll()

                        // ================= ALUMNO (REGISTRADO) =================
                        .requestMatchers(HttpMethod.POST, "/api/reta3/valoraciones/**")
                        .hasAnyRole("ALUMNO","DISENADOR","PROFESOR","ADMINISTRADOR")

                        // ================= DISENADOR / PROFESOR =================

                        //rutas/gpx admin + diseñador + profesor
                        .requestMatchers(HttpMethod.POST, "/api/reta3/rutas/gpx")
                        .hasAnyRole("DISENADOR","PROFESOR","ADMINISTRADOR")

                        // Crear rutas y datos bajo /rutas/**
                        .requestMatchers(HttpMethod.POST, "/api/reta3/rutas/**")
                        .hasAnyRole("DISENADOR","PROFESOR","ADMINISTRADOR")

                        // Descargar fichas
                        .requestMatchers(HttpMethod.GET, "/api/reta3/rutas/*/fichas/**")
                        .hasAnyRole("DISENADOR","PROFESOR","ADMINISTRADOR")

                        // Confirmar borrador (diseñador/profesor/admin)
                        .requestMatchers(HttpMethod.PUT, "/api/reta3/rutas/*/confirmar")
                        .hasAnyRole("DISENADOR","PROFESOR","ADMINISTRADOR")

                        // Cancelar borrador (diseñador/profesor/admin)
                        .requestMatchers(HttpMethod.DELETE, "/api/reta3/rutas/*/borrador")
                        .hasAnyRole("DISENADOR","PROFESOR","ADMINISTRADOR")

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
