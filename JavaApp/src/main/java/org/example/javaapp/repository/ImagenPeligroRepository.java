package org.example.javaapp.repository;

import org.example.javaapp.model.ImagenesPeligro;
import org.springframework.data.jpa.repository.JpaRepository;

public interface ImagenPeligroRepository extends JpaRepository<ImagenesPeligro,Integer> {
}
