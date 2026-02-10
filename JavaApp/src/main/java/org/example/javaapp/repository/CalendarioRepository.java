package org.example.javaapp.repository;

import org.example.javaapp.model.Calendario;
import org.springframework.data.jpa.repository.JpaRepository;

import java.time.LocalDate;
import java.util.List;

public interface CalendarioRepository extends JpaRepository<Calendario, Integer> {

    List<Calendario> findAllByFecha(LocalDate fecha);
}
