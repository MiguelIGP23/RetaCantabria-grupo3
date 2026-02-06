package org.example.javaapp.repository;

import org.example.javaapp.model.ImagenesPeligro;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;
import java.util.Optional;

public interface ImagenPeligroRepository extends JpaRepository<ImagenesPeligro,Integer> {

    List<ImagenesPeligro> findByPuntosPeligro_Id(Integer idPunto);
    Optional<ImagenesPeligro> findByIdAndPuntosPeligro_Id(Integer idImagen, Integer idPunto);
    void deleteByIdAndPuntosPeligro_Id(Integer idImagen, Integer idPunto);
}

