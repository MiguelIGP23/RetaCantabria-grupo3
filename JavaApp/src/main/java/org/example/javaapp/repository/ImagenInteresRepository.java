package org.example.javaapp.repository;

import org.example.javaapp.model.ImagenesInteres;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;
import java.util.Optional;

public interface ImagenInteresRepository extends JpaRepository<ImagenesInteres, Integer> {

    List<ImagenesInteres> findByPuntosInteres_IdAndPuntosInteres_Ruta_Id(Integer idPunto, Integer idRuta);
    Optional<ImagenesInteres> findByIdAndPuntosInteres_IdAndPuntosInteres_Ruta_Id(Integer idImagen, Integer idPunto, Integer idRuta);
    void deleteByIdAndPuntosInteres_IdAndPuntosInteres_Ruta_Id(Integer idImagen, Integer idPunto, Integer idRuta);
}
