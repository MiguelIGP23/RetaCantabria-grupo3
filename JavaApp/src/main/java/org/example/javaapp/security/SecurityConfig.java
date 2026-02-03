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
                        // ===== AUTH =====
                        .requestMatchers(HttpMethod.POST, "/api/reta3/auth/login").permitAll()

                        // ===== RUTAS (PUBLICO) =====
                        // Catálogo público: SOLO validadas
                        .requestMatchers(HttpMethod.GET, "/api/reta3/rutas/validadas").permitAll()
                        .requestMatchers(HttpMethod.GET, "/api/reta3/rutas/validadas/*").permitAll()

                        // ===== RUTAS (INTERNAS) =====
                        // Ver NO validadas  -> registrados
                        .requestMatchers(HttpMethod.GET, "/api/reta3/rutas/pendientes")
                        .hasAnyRole("DISENADOR","PROFESOR","ADMINISTRADOR")

                        // Descargar listado/archivo de validadas -> registrados
                        .requestMatchers(HttpMethod.GET, "/api/reta3/rutas/validadas/descargar")
                        .hasAnyRole("DISENADOR","PROFESOR","ADMINISTRADOR")

                        // Fichas -> registrados
                        .requestMatchers(HttpMethod.GET, "/api/reta3/rutas/*/fichas/**")
                        .hasAnyRole("DISENADOR","PROFESOR","ADMINISTRADOR")

                        // Crear rutas -> registrados
                        .requestMatchers(HttpMethod.POST, "/api/reta3/rutas/**")
                        .hasAnyRole("DISENADOR","PROFESOR","ADMINISTRADOR")

                        // Modificar / Borrar / Validar -> SOLO admin
                        .requestMatchers(HttpMethod.PUT, "/api/reta3/rutas/**")
                        .hasRole("ADMINISTRADOR")
                        .requestMatchers(HttpMethod.DELETE, "/api/reta3/rutas/**")
                        .hasRole("ADMINISTRADOR")
                        .requestMatchers(HttpMethod.POST, "/api/reta3/rutas/*/validar")
                        .hasRole("ADMINISTRADOR")

                        // ===== VALORACIONES =====
                        .requestMatchers("/api/reta3/valoraciones/**")
                        .hasAnyRole("ALUMNO","DISENADOR","PROFESOR","ADMINISTRADOR")

                        // Eliminar reseñas -> admin
                        .requestMatchers(HttpMethod.DELETE, "/api/reta3/resenas/**")
                        .hasRole("ADMINISTRADOR")

                        // Resto de peticiones autenticadas
                        .anyRequest().authenticated()
                )
                .oauth2ResourceServer(oauth -> oauth
                        .jwt(jwt -> jwt.jwtAuthenticationConverter(jwtAuthenticationConverter())));
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
