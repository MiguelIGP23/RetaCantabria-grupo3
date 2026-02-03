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

                        // Público
                        .requestMatchers(HttpMethod.POST, "/api/reta3/auth/login").permitAll()

                        // ===== RUTAS =====
                        // Ver rutas: todos los roles
                        .requestMatchers(HttpMethod.GET, "/api/reta3/rutas/**").permitAll()

                        // Crear rutas: disenador, profesor, admin
                        .requestMatchers(HttpMethod.POST, "/api/reta3/rutas/**")
                        .hasAnyRole("DISENADOR","PROFESOR","ADMINISTRADOR")

                        // Modificar rutas: admin
                        .requestMatchers(HttpMethod.PUT, "/api/reta3/rutas/**")
                        .hasRole("ADMINISTRADOR")
                        .requestMatchers(HttpMethod.PATCH, "/api/reta3/rutas/**")
                        .hasRole("ADMINISTRADOR")

                        // Borrar rutas: admin
                        .requestMatchers(HttpMethod.DELETE, "/api/reta3/rutas/**")
                        .hasRole("ADMINISTRADOR")

                        // Validar rutas: admin (endpoint específico recomendado)
                        .requestMatchers(HttpMethod.POST, "/api/reta3/rutas/*/validar")
                        .hasRole("ADMINISTRADOR")

                        // Descargar fichero rutas validadas: disenador/profesor/admin
                        .requestMatchers(HttpMethod.GET, "/api/reta3/rutas/validadas/descargar")
                        .hasAnyRole("DISENADOR","PROFESOR","ADMINISTRADOR")

                        // ===== VALORACIONES =====
                        .requestMatchers("/api/reta3/valoraciones/**")
                        .hasAnyRole("ALUMNO","DISENADOR","PROFESOR","ADMINISTRADOR")


                        // Eliminar reseñas: admin
                        .requestMatchers(HttpMethod.DELETE, "/api/reta3/resenas/**")
                        .hasRole("ADMINISTRADOR")

//                        // ===== CALENDARIO =====
//                        // cuando exista:
//                        .requestMatchers("/api/reta3/calendario/**")
//                        .hasRole("PROFESOR")

                        // Resto: autenticado
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
