package org.example.javaapp.repository;

import org.example.javaapp.model.ImagenesInteres;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;
import java.util.Optional;

public interface ImagenInteresRepository extends JpaRepository<ImagenesInteres,Integer> {

    List<ImagenesInteres> findByPuntosInteres_Id(Integer idPunto);
    Optional<ImagenesInteres> findByIdAndPuntosInteres_Id(Integer idImagen, Integer idPunto);
    void deleteByIdAndPuntosInteres_Id(Integer idImagen, Integer idPunto);
}
