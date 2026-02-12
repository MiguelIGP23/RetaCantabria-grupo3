package org.example.javaapp.service;

import org.example.javaapp.model.ImagenesPeligro;
import org.example.javaapp.model.PuntosPeligro;
import org.example.javaapp.repository.ImagenPeligroRepository;
import org.example.javaapp.repository.PuntosPeligroRepository;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

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

    public ImagenesPeligro insertInPunto(int idRuta, int idPuntoPeligro, ImagenesPeligro img) {
        PuntosPeligro punto = repoPunto.findByIdAndRuta_Id(idPuntoPeligro, idRuta).orElse(null);
        if (punto == null) return null;

        img.setId(null);
        img.setPuntosPeligro(punto);
        return repoImagen.save(img);
    }

    public ImagenesPeligro updateInPunto(int idRuta, int idPuntoPeligro, int idImagen, ImagenesPeligro img) {
        Optional<ImagenesPeligro> opt =
                repoImagen.findByIdAndPuntosPeligro_IdAndPuntosPeligro_Ruta_Id(idImagen, idPuntoPeligro, idRuta);

        if (opt.isEmpty()) return null;

        ImagenesPeligro buscada = opt.get();
        buscada.setUrl(img.getUrl());
        buscada.setDescripcion(img.getDescripcion());
        return repoImagen.save(buscada);
    }

    @Transactional
    public void deleteFromPunto(int idRuta, int idPuntoPeligro, int idImagen) {
        repoImagen.deleteByIdAndPuntosPeligro_IdAndPuntosPeligro_Ruta_Id(idImagen, idPuntoPeligro, idRuta);
    }

    public List<ImagenesPeligro> findAllByPunto(int idRuta, int idPuntoPeligro) {
        return repoImagen.findByPuntosPeligro_IdAndPuntosPeligro_Ruta_Id(idPuntoPeligro, idRuta);
    }

    public Optional<ImagenesPeligro> findByPuntoAndId(int idRuta, int idPuntoPeligro, int idImagen) {
        return repoImagen.findByIdAndPuntosPeligro_IdAndPuntosPeligro_Ruta_Id(idImagen, idPuntoPeligro, idRuta);
    }

}
























