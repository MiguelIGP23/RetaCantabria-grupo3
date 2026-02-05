package org.example.javaapp.repository;

import org.example.javaapp.model.PuntosPeligro;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;
import java.util.Optional;

public interface PuntosPeligroRepository extends JpaRepository<PuntosPeligro, Integer> {
    List<PuntosPeligro> findByRuta_Id(Integer id);
    Optional<PuntosPeligro> findByIdAndRuta_Id(Integer idPunto, Integer idRuta);
    void deleteByIdAndRuta_Id(Integer idPunto, Integer idRuta);
}
