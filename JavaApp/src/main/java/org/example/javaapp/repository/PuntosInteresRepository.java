package org.example.javaapp.repository;

import org.example.javaapp.model.PuntosInteres;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface PuntosInteresRepository extends JpaRepository<PuntosInteres, Integer> {
    List<PuntosInteres> findByIdRuta(Integer id);
}
