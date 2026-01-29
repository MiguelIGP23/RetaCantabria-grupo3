package org.example.javaapp.service;

import org.example.javaapp.model.Imagenesintere;
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
    public Imagenesintere insert(Imagenesintere imagenesintere) {
        return repo.save(imagenesintere);
    }

    @Override
    public Imagenesintere update(int id, Imagenesintere imagenesintere) {
        Imagenesintere imagen = findById(id);
        if (imagen != null) {
            imagen.setDescripcion(imagenesintere.getDescripcion());
            imagen.setUrl(imagenesintere.getUrl());
        }
        return imagen;
    }

    @Override
    public void delete(int id) {
        repo.deleteById(id);
    }

    @Override
    public Imagenesintere findById(int id) {
        return repo.findById(id).orElse(null);
    }

    @Override
    public List<Imagenesintere> findAll() {
        return repo.findAll();
    }
}
