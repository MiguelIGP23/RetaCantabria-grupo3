package org.example.javaapp.service;

import org.example.javaapp.model.ImagenesInteres;
import org.example.javaapp.model.PuntosInteres;
import org.example.javaapp.repository.ImagenInteresRepository;
import org.example.javaapp.repository.PuntosInteresRepository;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

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

        img.setId(null);
        img.setPuntosInteres(punto);
        return repoImagen.save(img);
    }

    public ImagenesInteres updateInPunto(int idRuta, int idPunto, int idImagen, ImagenesInteres img) {
        Optional<ImagenesInteres> opt = repoImagen.findByIdAndPuntosInteres_IdAndPuntosInteres_Ruta_Id((idImagen), idPunto, idRuta);
        if (opt.isEmpty()) return null;

        ImagenesInteres buscada = opt.get();
        buscada.setUrl(img.getUrl());
        buscada.setDescripcion(img.getDescripcion());
        return repoImagen.save(buscada);
    }

    @Transactional
    public void deleteFromPunto(int idRuta, int idPunto, int idImagen) {
        repoImagen.deleteByIdAndPuntosInteres_IdAndPuntosInteres_Ruta_Id(idImagen, idPunto, idRuta);
    }

    public List<ImagenesInteres> findAllByPunto(int idRuta, int idPunto) {
        return repoImagen.findByPuntosInteres_IdAndPuntosInteres_Ruta_Id(idPunto, idRuta);
    }

    public Optional<ImagenesInteres> findByPuntoAndId(int idRuta, int idPunto, int idImagen) {
        return repoImagen.findByIdAndPuntosInteres_IdAndPuntosInteres_Ruta_Id(idImagen, idPunto, idRuta);
    }

}


















