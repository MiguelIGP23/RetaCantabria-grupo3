package org.example.javaapp.repository;

import org.example.javaapp.model.PuntosPeligro;
import org.example.javaapp.model.Ruta;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface PuntosPeligroRepository extends JpaRepository<PuntosPeligro, Integer> {
    List<PuntosPeligro> findByIdRuta(Integer id);
}
