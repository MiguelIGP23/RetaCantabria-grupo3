package org.example.javaapp.controller;

import org.example.javaapp.dto.DtoCalendario;
import org.example.javaapp.dto.MapperCalendario;
import org.example.javaapp.model.Calendario;
import org.example.javaapp.model.Ruta;
import org.example.javaapp.model.Usuario;
import org.example.javaapp.service.ServiceCalendario;
import org.example.javaapp.service.ServiceRuta;
import org.example.javaapp.service.ServiceUsuario;
import org.springframework.http.HttpStatus;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.server.ResponseStatusException;

import java.time.LocalDate;
import java.time.YearMonth;
import java.util.List;

@RestController
@RequestMapping("/api/reta3")
public class CalendarioController {

    private final ServiceCalendario serviceCalen;
    private final ServiceUsuario serviceUsu;
    private final ServiceRuta serviceRuta;

    public CalendarioController(ServiceCalendario service, ServiceUsuario serviceUsu, ServiceRuta serviceRuta) {
        this.serviceCalen = service;
        this.serviceUsu = serviceUsu;
        this.serviceRuta = serviceRuta;
    }


    @GetMapping("/calendario/fecha/{fecha}")
    public List<DtoCalendario> buscarPorDia(@PathVariable String fecha) {
        LocalDate dia = LocalDate.parse(fecha);
        return serviceCalen.findByFecha(dia).stream()
                .map(MapperCalendario::toDto)
                .toList();
    }

    @PostMapping("/calendario/{idUsuario}/{idRuta}")
    public DtoCalendario insertar(@PathVariable int idUsuario,
                                  @PathVariable int idRuta,
                                  @RequestBody DtoCalendario dto) {

        if (dto.usuarioId() == null) throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Falta usuarioId en el body");
        if (dto.rutaId() == null) throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Falta id de ruta en el body");
        if (idUsuario != dto.usuarioId()) throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "usuarioId no coincide con el path");
        if (idRuta != dto.rutaId()) throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "rutaId no coincide con el path");

        Usuario usu = serviceUsu.findById(idUsuario);
        if (usu == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Usuario no encontrado");

        Ruta ruta = serviceRuta.findById(idRuta);
        if (ruta == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Ruta no encontrada");

        Calendario nuevo = serviceCalen.insert(MapperCalendario.toEntity(dto, ruta, usu));
        return MapperCalendario.toDto(nuevo);
    }

    @GetMapping("/calendario/rutasmes/{ym}")
    public List<LocalDate> diasConRutasEnMes(@PathVariable String ym) {
        return serviceCalen.diasConRutasEnMes(YearMonth.parse(ym)); // "2026-02"
    }


    @PutMapping("/calendario/{idCalendario}")
    public DtoCalendario editar(@PathVariable Integer idCalendario,
                                @RequestBody DtoCalendario dto) {

        if (dto.id() == null) throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Falta id en el body");
        if (!idCalendario.equals(dto.id())) throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "id no coincide con el path");

        Calendario actualizado = MapperCalendario.toEntity(dto, null, null);
        Calendario guardado = serviceCalen.update(idCalendario, actualizado);

        if (guardado == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Calendario no encontrado");
        return MapperCalendario.toDto(guardado);
    }



}
