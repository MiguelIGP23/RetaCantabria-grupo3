package org.example.javaapp.service;

import org.example.javaapp.model.ImagenesInteres;
import org.example.javaapp.repository.ImagenInteresRepository;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class ServiceImagenInteres implements IServiceImagenInteres {

    ImagenInteresRepository repo;
    public ServiceImagenInteres(ImagenInteresRepository repo) {
        this.repo = repo;
    }

    @Override
    public ImagenesInteres insert(ImagenesInteres imagenesInteres) {
        return repo.save(imagenesInteres);
    }

    @Override
    public ImagenesInteres update(Integer id, ImagenesInteres imagenesInteres) {
        ImagenesInteres imagen = findById(id);
        if (imagen != null) {
            imagen.setDescripcion(imagenesInteres.getDescripcion());
            imagen.setUrl(imagenesInteres.getUrl());
            imagen.setPuntosInteres(imagen.getPuntosInteres());
            repo.save(imagen);
        }
        return imagen;
    }

    @Override
    public void delete(Integer id) {
        repo.deleteById(id);
    }

    @Override
    public ImagenesInteres findById(Integer id) {
        return repo.findById(id).orElse(null);
    }

    @Override
    public List<ImagenesInteres> findAll() {
        return repo.findAll();
    }
}
