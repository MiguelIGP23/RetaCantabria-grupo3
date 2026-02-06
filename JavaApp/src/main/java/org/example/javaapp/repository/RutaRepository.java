package org.example.javaapp.repository;

import org.example.javaapp.model.Ruta;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface RutaRepository extends JpaRepository<Ruta, Integer> {

    List<Ruta> findByEstadoRuta(Byte estadoRuta);
}
