package org.example.javaapp.persistence;

import org.example.javaapp.model.Puntosintere;
import org.springframework.data.jpa.repository.JpaRepository;

public interface PuntosInteresRepository extends JpaRepository<Puntosintere, Integer> {
}
