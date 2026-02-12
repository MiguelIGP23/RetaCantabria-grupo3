package org.example.javaapp.repository;

import org.example.javaapp.model.Calendario;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

import java.time.LocalDate;
import java.util.List;

public interface CalendarioRepository extends JpaRepository<Calendario, Integer> {

    List<Calendario> findAllByFecha(LocalDate fecha);

    @Query("select distinct c.fecha from Calendario c where c.fecha >= :inicio and c.fecha < :fin order by c.fecha")
    List<LocalDate> findDistinctFechasMes(@Param("inicio") LocalDate inicio, @Param("fin") LocalDate fin);

}
