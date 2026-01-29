package org.example.javaapp.repository;

import org.example.javaapp.model.Imagenespeligro;
import org.springframework.data.jpa.repository.JpaRepository;

public interface ImagenPeligroRepository extends JpaRepository<Imagenespeligro,Integer> {
}
