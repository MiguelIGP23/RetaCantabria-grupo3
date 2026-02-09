package org.example.javaapp.controller;

import org.example.javaapp.dto.DtoValoraciones;
import org.example.javaapp.dto.MapperValoraciones;
import org.example.javaapp.model.Ruta;
import org.example.javaapp.model.Usuario;
import org.example.javaapp.model.Valoracion;
import org.example.javaapp.service.ServiceRuta;
import org.example.javaapp.service.ServiceUsuario;
import org.example.javaapp.service.ServiceValoracion;
import org.springframework.http.HttpStatus;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.server.ResponseStatusException;

import java.util.List;

@RestController
@RequestMapping("/api/reta3/rutas")
public class ValoracionController {

    private final ServiceValoracion serviceValoracion;
    private final ServiceRuta serviceRuta;
    private final ServiceUsuario serviceUsuario;

    public ValoracionController(ServiceValoracion serviceValoracion, ServiceRuta serviceRuta, ServiceUsuario serviceUsuario) {
        this.serviceValoracion = serviceValoracion;
        this.serviceRuta = serviceRuta;
        this.serviceUsuario = serviceUsuario;
    }

    @PostMapping("/{idRuta}/valoraciones")
    public DtoValoraciones insert(@PathVariable int idRuta, @RequestBody DtoValoraciones dto) {

        Ruta ruta = serviceRuta.findById(idRuta);
        if (ruta == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Ruta no encontrada");

        if (dto.rutaId() == null || dto.rutaId() != idRuta)
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Id de ruta incorrecto");

        if (dto.usuarioId() == null)
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Id de usuario incorrecto");

        Usuario usuario = serviceUsuario.findById(dto.usuarioId());
        if (usuario == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Usuario no encontrado");

        Valoracion entidad = MapperValoraciones.toEntity(dto, usuario, ruta);
        entidad.setId(null);

        Valoracion nueva = serviceValoracion.insertInRuta(idRuta, entidad);
        if (nueva == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Valoración no encontrada");

        return MapperValoraciones.toDto(nueva);
    }

    @GetMapping("/{idRuta}/valoraciones/{idValoracion}")
    public DtoValoraciones findById(@PathVariable int idValoracion, @PathVariable int idRuta) {
        return serviceValoracion.findByRutaAndId(idValoracion, idRuta)
                .map(MapperValoraciones::toDto)
                .orElseThrow(() -> new ResponseStatusException(HttpStatus.NOT_FOUND, "Valoración no encontrada"));
    }

    @GetMapping("/{idRuta}/valoraciones")
    public List<DtoValoraciones> findAll(@PathVariable int idRuta) {
        return serviceValoracion.findAllByRuta(idRuta)
                .stream()
                .map(MapperValoraciones::toDto)
                .toList();
    }

    @DeleteMapping("/{idRuta}/valoraciones/{idValoracion}")
    public void delete(@PathVariable int idRuta, @PathVariable int idValoracion) {
        serviceValoracion.deleteFromRuta(idValoracion, idRuta);
    }

    @PutMapping("/{idRuta}/valoraciones/{idValoracion}")
    public DtoValoraciones update(@PathVariable int idValoracion, @PathVariable int idRuta, @RequestBody DtoValoraciones dto) {

        Ruta ruta = serviceRuta.findById(idRuta);
        if (ruta == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Ruta no encontrada");

        if (dto.rutaId() == null || dto.rutaId() != idRuta)
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Id de ruta incorrecto");

        if (dto.id() == null || dto.id() != idValoracion)
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Id de valoración incorrecto");

        if (dto.usuarioId() == null)
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Id de usuario incorrecto");

        Usuario usuario = serviceUsuario.findById(dto.usuarioId());
        if (usuario == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Usuario no encontrado");

        Valoracion entidad = MapperValoraciones.toEntity(dto, usuario, ruta);

        Valoracion nueva = serviceValoracion.updateInRuta(idValoracion, idRuta, entidad);
        if (nueva == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Valoración no encontrada");

        return MapperValoraciones.toDto(nueva);
    }
}
