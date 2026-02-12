package org.example.javaapp.repository;

import org.example.javaapp.model.Actividad;
import org.example.javaapp.model.Valoracion;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;
import java.util.Optional;

public interface ValoracionRepository extends JpaRepository<Valoracion, Integer> {

    List<Valoracion> findByRuta_Id(Integer idRuta);
    Optional<Valoracion> findByIdAndRuta_Id(Integer idValoracion, Integer idRuta);
    void deleteByIdAndRuta_Id(Integer idValoracion, Integer idRuta);
}
