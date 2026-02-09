package org.example.javaapp.service;

import org.example.javaapp.model.PuntosPeligro;
import org.example.javaapp.model.Ruta;
import org.example.javaapp.repository.PuntosPeligroRepository;
import org.example.javaapp.repository.RutaRepository;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.List;
import java.util.Optional;

@Service
public class ServicePuntosPeligro implements IServicePuntosPeligro{

    private final PuntosPeligroRepository repoPunto;
    private final RutaRepository repoRuta;

    public ServicePuntosPeligro(PuntosPeligroRepository repo, RutaRepository repoRuta){
        this.repoPunto =repo;
        this.repoRuta = repoRuta;
    }


    //CRUD genérico

    @Override
    public PuntosPeligro insert(PuntosPeligro puntospeligro) {
        return repoPunto.save(puntospeligro);
    }

    @Override
    public PuntosPeligro update(Integer id, PuntosPeligro puntospeligro) {
        PuntosPeligro buscado = findById(id);
        if(buscado!=null){
            buscado.setNombre(puntospeligro.getNombre());
            buscado.setLatitud(puntospeligro.getLatitud());
            buscado.setLongitud(puntospeligro.getLongitud());
            buscado.setElevacion(puntospeligro.getElevacion());
            buscado.setKilometros(puntospeligro.getKilometros());
            buscado.setGravedad(puntospeligro.getGravedad());
            buscado.setPosicion(puntospeligro.getPosicion());
            buscado.setDescripcion(puntospeligro.getDescripcion());
            buscado.setTimestamp(puntospeligro.getTimestamp());
            buscado.setRuta(puntospeligro.getRuta());
            repoPunto.save(buscado);
        }
        return buscado;
    }

    @Override
    public void delete(Integer id) {
        repoPunto.deleteById(id);
    }

    @Override
    public PuntosPeligro findById(Integer id) {
        return repoPunto.findById(id).orElse(null);
    }

    @Override
    public List<PuntosPeligro> findAll() {
        return repoPunto.findAll();
    }

    public List<PuntosPeligro> findByIdruta(Integer id){
        return repoPunto.findByRuta_Id(id);
    }


    //CRUD dependiente de ruta

    public PuntosPeligro insertInRuta(int idRuta, PuntosPeligro puntosPeligro) {
        Ruta ruta = repoRuta.findById(idRuta).orElse(null);
        if (ruta == null) return null;

        puntosPeligro.setId(null);
        puntosPeligro.setRuta(ruta);
        return repoPunto.save(puntosPeligro);
    }

    public PuntosPeligro updateInRuta(int idPuntoPeligro, int idRuta, PuntosPeligro puntosPeligro) {
        Optional<PuntosPeligro> opt = repoPunto.findByIdAndRuta_Id(idPuntoPeligro, idRuta);
        if (opt.isEmpty()) return null;

        PuntosPeligro buscado = opt.get();
        buscado.setNombre(puntosPeligro.getNombre());
        buscado.setLatitud(puntosPeligro.getLatitud());
        buscado.setLongitud(puntosPeligro.getLongitud());
        buscado.setElevacion(puntosPeligro.getElevacion());
        buscado.setKilometros(puntosPeligro.getKilometros());
        buscado.setGravedad(puntosPeligro.getGravedad());
        buscado.setPosicion(puntosPeligro.getPosicion());
        buscado.setDescripcion(puntosPeligro.getDescripcion());
        buscado.setTimestamp(puntosPeligro.getTimestamp());
        return repoPunto.save(buscado);
    }

    @Transactional
    public void deleteFromRuta(int idPuntoPeligro, int idRuta) {
        repoPunto.deleteByIdAndRuta_Id(idPuntoPeligro, idRuta);
    }

    public List<PuntosPeligro> findAllByRuta(int idRuta) {
        return repoPunto.findByRuta_Id(idRuta);
    }

    public Optional<PuntosPeligro> findByRutaAndId(int idPuntoPeligro, int idRuta) {
        return repoPunto.findByIdAndRuta_Id(idPuntoPeligro, idRuta);
    }
}
