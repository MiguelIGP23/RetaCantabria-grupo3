package org.example.javaapp.security;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.core.convert.converter.Converter;
import org.springframework.http.HttpMethod;
import org.springframework.security.authentication.AbstractAuthenticationToken;
import org.springframework.security.config.Customizer;
import org.springframework.security.config.annotation.web.builders.HttpSecurity;
import org.springframework.security.config.annotation.web.configuration.EnableWebSecurity;
import org.springframework.security.config.http.SessionCreationPolicy;
import org.springframework.security.core.authority.SimpleGrantedAuthority;
import org.springframework.security.oauth2.jwt.Jwt;
import org.springframework.security.oauth2.server.resource.authentication.JwtAuthenticationConverter;
import org.springframework.security.oauth2.server.resource.authentication.JwtAuthenticationToken;
import org.springframework.security.oauth2.server.resource.authentication.JwtGrantedAuthoritiesConverter;
import org.springframework.security.web.SecurityFilterChain;

import java.util.List;

@Configuration
@EnableWebSecurity
public class SecurityConfig {

    // Bloquea peticiones a todos los endpoints menos /api/reta3/auth/login
    @Bean
    public SecurityFilterChain securityFilterChain(HttpSecurity http) throws Exception{
        http
                .csrf(csfr -> csfr.disable())
                .sessionManagement(sm -> sm.sessionCreationPolicy(SessionCreationPolicy.STATELESS))
                .authorizeHttpRequests(auth -> auth
                        // ================= AUTH =================
                        .requestMatchers(HttpMethod.POST, "/api/reta3/auth/login").permitAll()

                        // ================= CATALOGO PUBLICO (SIN REGISTRO) =================
                        // Rutas validadas (lista + detalle)
                        .requestMatchers(HttpMethod.GET, "/api/reta3/rutas/validadas").permitAll()
                        .requestMatchers(HttpMethod.GET, "/api/reta3/rutas/validadas/**").permitAll()

                        // Datos que cuelgan del catálogo (GET públicos)
                        .requestMatchers(HttpMethod.GET, "/api/reta3/rutas/*/puntosinteres/**").permitAll()
                        .requestMatchers(HttpMethod.GET, "/api/reta3/rutas/*/puntospeligro/**").permitAll()

                        .requestMatchers(HttpMethod.GET, "/api/reta3/rutas/*/imagenesinteres/**").permitAll()
                        .requestMatchers(HttpMethod.GET, "/api/reta3/rutas/*/imagenespeligro/**").permitAll()

                        // Valoraciones (ver sin registro)
                        .requestMatchers(HttpMethod.GET, "/api/reta3/valoraciones/**").permitAll()

                        // Actividades (ver sin registro)
                        .requestMatchers(HttpMethod.GET, "/api/reta3/actividades/**").permitAll()


                        // ================= ALUMNO (REGISTRADO) =================
                        // Valorar rutas
                        .requestMatchers(HttpMethod.POST, "/api/reta3/valoraciones/**")
                        .hasAnyRole("ALUMNO","DISENADOR","PROFESOR","ADMINISTRADOR")


                        // ================= DISENADOR / PROFESOR =================
                        // Crear rutas y datos bajo /rutas/**
                        .requestMatchers(HttpMethod.POST, "/api/reta3/rutas/**")
                        .hasAnyRole("DISENADOR","PROFESOR","ADMINISTRADOR")

                        // Descargar fichas (solo diseñadores + profesores + admin)
                        .requestMatchers(HttpMethod.GET, "/api/reta3/rutas/*/fichas/**")
                        .hasAnyRole("DISENADOR","PROFESOR","ADMINISTRADOR")


                        // ================= ADMINISTRADOR =================
                        // Gestionar rutas
                        .requestMatchers(HttpMethod.PUT, "/api/reta3/rutas/**")
                        .hasRole("ADMINISTRADOR")
                        .requestMatchers(HttpMethod.DELETE, "/api/reta3/rutas/**")
                        .hasRole("ADMINISTRADOR")

                        // Validar rutas
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
