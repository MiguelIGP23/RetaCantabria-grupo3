package org.example.javaapp.service;

import org.example.javaapp.model.ImagenesInteres;
import org.example.javaapp.model.PuntosInteres;
import org.example.javaapp.repository.ImagenInteresRepository;
import org.example.javaapp.repository.PuntosInteresRepository;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class ServiceImagenInteres implements IServiceImagenInteres {

    private final ImagenInteresRepository repoImagen;
    private final PuntosInteresRepository repoPuntos;


    public ServiceImagenInteres(ImagenInteresRepository repo, PuntosInteresRepository repoPuntos) {
        this.repoImagen = repo;
        this.repoPuntos = repoPuntos;
    }


    //CRUD genérico

    @Override
    public ImagenesInteres insert(ImagenesInteres imagenesInteres) {
        return repoImagen.save(imagenesInteres);
    }

    @Override
    public ImagenesInteres update(Integer id, ImagenesInteres imagenesInteres) {
        ImagenesInteres imagen = findById(id);
        if (imagen != null) {
            imagen.setDescripcion(imagenesInteres.getDescripcion());
            imagen.setUrl(imagenesInteres.getUrl());
            imagen.setPuntosInteres(imagen.getPuntosInteres());
            repoImagen.save(imagen);
        }
        return imagen;
    }

    @Override
    public void delete(Integer id) {
        repoImagen.deleteById(id);
    }

    @Override
    public ImagenesInteres findById(Integer id) {
        return repoImagen.findById(id).orElse(null);
    }

    @Override
    public List<ImagenesInteres> findAll() {
        return repoImagen.findAll();
    }


    //CRUD dependiente de ruta + punto de interés

    public ImagenesInteres insertInPunto(int idRuta, int idPunto, ImagenesInteres img) {
        PuntosInteres punto = repoPuntos.findByIdAndRuta_Id(idPunto, idRuta).orElse(null);
        if (punto == null) return null;
        img.setPuntosInteres(punto);
        return repoImagen.save(img);
    }

    public List<ImagenesInteres> findAllByPunto(int idRuta, int idPunto) {
        if (repoPuntos.findByIdAndRuta_Id(idPunto, idRuta).isEmpty()) {
            return List.of();
        }
        return repoImagen.findByPuntosInteres_Id(idPunto);
    }

    public Optional<ImagenesInteres> findByPuntoAndId(int idRuta, int idPunto, int idImagen) {
        if (repoPuntos.findByIdAndRuta_Id(idPunto, idRuta).isEmpty()) {
            return Optional.empty();
        }
        return repoImagen.findByIdAndPuntosInteres_Id(idImagen, idPunto);
    }

    public ImagenesInteres updateInPunto(int idRuta, int idPunto, int idImagen, ImagenesInteres nueva) {
        PuntosInteres punto = repoPuntos.findByIdAndRuta_Id(idPunto, idRuta).orElse(null);
        if (punto == null) return null;

        Optional<ImagenesInteres> opt = repoImagen.findByIdAndPuntosInteres_Id(idImagen, idPunto);
        if (opt.isEmpty()) return null;

        ImagenesInteres img = opt.get();
        img.setDescripcion(nueva.getDescripcion());
        img.setUrl(nueva.getUrl());
        img.setPuntosInteres(punto);

        return repoImagen.save(img);
    }

    public void deleteFromPunto(int idRuta, int idPunto, int idImagen) {
        if (repoPuntos.findByIdAndRuta_Id(idPunto, idRuta).isEmpty()) return;
        repoImagen.deleteByIdAndPuntosInteres_Id(idImagen, idPunto);
    }

}


















