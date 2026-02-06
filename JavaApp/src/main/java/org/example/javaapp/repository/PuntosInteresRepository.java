package org.example.javaapp.repository;

import org.example.javaapp.model.PuntosInteres;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;
import java.util.Optional;

public interface PuntosInteresRepository extends JpaRepository<PuntosInteres, Integer> {

    List<PuntosInteres> findByRuta_Id(Integer id);
    Optional<PuntosInteres> findByIdAndRuta_Id(Integer idPunto, Integer idRuta);
    void deleteByIdAndRuta_Id(Integer idPunto, Integer idRuta);
}
