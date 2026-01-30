package org.example.javaapp.service;

import org.example.javaapp.model.ImagenesPeligro;
import org.example.javaapp.repository.ImagenPeligroRepository;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class ServiceImagenPeligro implements IService<ImagenesPeligro,Integer> {

    ImagenPeligroRepository repo;

    public ServiceImagenPeligro(ImagenPeligroRepository repo){
        this.repo=repo;
    }

    @Override
    public ImagenesPeligro insert(ImagenesPeligro imagenespeligro) {
        return repo.save(imagenespeligro);
    }

    @Override
    public ImagenesPeligro update(int id, ImagenesPeligro imagenespeligro) {
        ImagenesPeligro imagen = imagenespeligro;
        if (imagen!=null){
            imagen.setDescripcion(imagenespeligro.getDescripcion());
            imagen.setUrl(imagenespeligro.getUrl());
            imagen.setPuntospeligro(imagenespeligro.getPuntospeligro());
            repo.save(imagen);
        }
        return imagen;
    }

    @Override
    public void delete(int id) {
        repo.deleteById(id);
    }

    @Override
    public ImagenesPeligro findById(int id) {
        return repo.findById(id).orElse(null);
    }

    @Override
    public List<ImagenesPeligro> findAll() {
        return repo.findAll();
    }
}
