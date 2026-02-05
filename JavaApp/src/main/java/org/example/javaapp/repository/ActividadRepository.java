package org.example.javaapp.repository;

import org.example.javaapp.model.Actividad;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;
import java.util.Optional;

public interface ActividadRepository extends JpaRepository<Actividad, Integer> {

    Optional<Actividad> findByIdAndRuta_Id(Integer idActividad, Integer idRuta);
    List<Actividad> findByRuta_Id(Integer idRuta);
    void deleteByIdAndRuta_Id(Integer idActividad, Integer idRuta);
}
