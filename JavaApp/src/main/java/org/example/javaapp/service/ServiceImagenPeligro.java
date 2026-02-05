package org.example.javaapp.service;

import org.example.javaapp.model.ImagenesPeligro;
import org.example.javaapp.model.PuntosPeligro;
import org.example.javaapp.repository.ImagenPeligroRepository;
import org.example.javaapp.repository.PuntosPeligroRepository;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class ServiceImagenPeligro implements IService<ImagenesPeligro,Integer> {

    private final ImagenPeligroRepository repoImagen;
    private final PuntosPeligroRepository repoPunto;

    public ServiceImagenPeligro(ImagenPeligroRepository repo, PuntosPeligroRepository repoPunto){
        this.repoImagen =repo;
        this.repoPunto = repoPunto;
    }


    //CRUD genérico

    @Override
    public ImagenesPeligro insert(ImagenesPeligro imagenespeligro) {
        return repoImagen.save(imagenespeligro);
    }

    @Override
    public ImagenesPeligro update(Integer id, ImagenesPeligro imagenespeligro) {
        ImagenesPeligro imagen = findById(id);
        if (imagen!=null){
            imagen.setDescripcion(imagenespeligro.getDescripcion());
            imagen.setUrl(imagenespeligro.getUrl());
            imagen.setPuntosPeligro(imagenespeligro.getPuntosPeligro());
            repoImagen.save(imagen);
        }
        return imagen;
    }

    @Override
    public void delete(Integer id) {
        repoImagen.deleteById(id);
    }

    @Override
    public ImagenesPeligro findById(Integer id) {
        return repoImagen.findById(id).orElse(null);
    }

    @Override
    public List<ImagenesPeligro> findAll() {
        return repoImagen.findAll();
    }


    //CRUD dependiente de ruta + punto peligro

    public ImagenesPeligro insertInPunto(int idRuta, int idPunto, ImagenesPeligro img) {
        PuntosPeligro punto = repoPunto.findByIdAndRuta_Id(idPunto, idRuta).orElse(null);
        if (punto == null) return null;
        img.setPuntosPeligro(punto);
        return repoImagen.save(img);
    }

    public List<ImagenesPeligro> findAllByPunto(int idRuta, int idPunto) {
        if (repoPunto.findByIdAndRuta_Id(idPunto, idRuta).isEmpty()) return List.of();
        return repoImagen.findByPuntosPeligro_Id(idPunto);
    }

    public Optional<ImagenesPeligro> findByPuntoAndId(int idRuta, int idPunto, int idImagen) {
        if (repoPunto.findByIdAndRuta_Id(idPunto, idRuta).isEmpty()) return Optional.empty();
        return repoImagen.findByIdAndPuntosPeligro_Id(idImagen, idPunto);
    }

    public ImagenesPeligro updateInPunto(int idRuta, int idPunto, int idImagen, ImagenesPeligro nueva) {
        PuntosPeligro punto = repoPunto.findByIdAndRuta_Id(idPunto, idRuta).orElse(null);
        if (punto == null) return null;

        Optional<ImagenesPeligro> opt = repoImagen.findByIdAndPuntosPeligro_Id(idImagen, idPunto);
        if (opt.isEmpty()) return null;

        ImagenesPeligro img = opt.get();
        img.setDescripcion(nueva.getDescripcion());
        img.setUrl(nueva.getUrl());
        img.setPuntosPeligro(punto);
        return repoImagen.save(img);
    }

    public void deleteFromPunto(int idRuta, int idPunto, int idImagen) {
        if (repoPunto.findByIdAndRuta_Id(idPunto, idRuta).isEmpty()) return;
        repoImagen.deleteByIdAndPuntosPeligro_Id(idImagen, idPunto);
    }

}
























