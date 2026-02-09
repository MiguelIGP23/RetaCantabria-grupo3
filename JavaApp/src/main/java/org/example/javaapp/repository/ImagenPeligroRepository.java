package org.example.javaapp.repository;

import org.example.javaapp.model.ImagenesPeligro;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;
import java.util.Optional;

public interface ImagenPeligroRepository extends JpaRepository<ImagenesPeligro,Integer> {

    List<ImagenesPeligro> findByPuntosPeligro_IdAndPuntosPeligro_Ruta_Id(Integer idPuntoPeligro, Integer idRuta);
    Optional<ImagenesPeligro> findByIdAndPuntosPeligro_IdAndPuntosPeligro_Ruta_Id(Integer idImagen, Integer idPuntoPeligro, Integer idRuta);
    void deleteByIdAndPuntosPeligro_IdAndPuntosPeligro_Ruta_Id(Integer idImagen, Integer idPuntoPeligro, Integer idRuta);
}


