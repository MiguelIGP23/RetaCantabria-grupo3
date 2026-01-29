package org.example.javaapp.service;

import org.example.javaapp.model.Imagenespeligro;
import org.example.javaapp.repository.ImagenPeligroRepository;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class ServiceImagenPeligro implements IService<Imagenespeligro,Integer> {

    ImagenPeligroRepository repo;
    @Override
    public Imagenespeligro insert(Imagenespeligro imagenespeligro) {
        return repo.save(imagenespeligro);
    }

    @Override
    public Imagenespeligro update(int id, Imagenespeligro imagenespeligro) {
        Imagenespeligro imagen = imagenespeligro;
        if (imagen!=null){
            imagen.setDescripcion(imagenespeligro.getDescripcion());
            imagen.setUrl(imagenespeligro.getUrl());
        }
        return imagen;
    }

    @Override
    public void delete(int id) {
        repo.deleteById(id);
    }

    @Override
    public Imagenespeligro findById(int id) {
        return repo.findById(id).orElse(null);
    }

    @Override
    public List<Imagenespeligro> findAll() {
        return repo.findAll();
    }
}
