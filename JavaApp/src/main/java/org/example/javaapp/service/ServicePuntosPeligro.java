package org.example.javaapp.service;

import org.example.javaapp.model.PuntosPeligro;
import org.example.javaapp.model.Ruta;
import org.example.javaapp.repository.PuntosPeligroRepository;
import org.example.javaapp.repository.RutaRepository;
import org.springframework.stereotype.Service;

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

    public PuntosPeligro insertInRuta(int idRuta, PuntosPeligro punto) {
        Ruta ruta = repoRuta.findById(idRuta).orElse(null);
        if (ruta == null) return null;

        punto.setRuta(ruta);
        return repoPunto.save(punto);
    }

    public PuntosPeligro updateInRuta(int idPunto, int idRuta, PuntosPeligro punto) {
        Optional<PuntosPeligro> opt = repoPunto.findByIdAndRuta_Id(idPunto, idRuta);
        if (opt.isEmpty()) return null;
        PuntosPeligro buscado = opt.get();

        buscado.setNombre(punto.getNombre());
        buscado.setLatitud(punto.getLatitud());
        buscado.setLongitud(punto.getLongitud());
        buscado.setElevacion(punto.getElevacion());
        buscado.setKilometros(punto.getKilometros());
        buscado.setGravedad(punto.getGravedad());
        buscado.setPosicion(punto.getPosicion());
        buscado.setDescripcion(punto.getDescripcion());
        buscado.setTimestamp(punto.getTimestamp());
        buscado.setRuta(punto.getRuta());
        return repoPunto.save(buscado);
    }

    public void deleteFromRuta(int idPunto, int idRuta) {
        repoPunto.deleteByIdAndRuta_Id(idPunto, idRuta);
    }

    public List<PuntosPeligro> findAllByRuta(int idRuta) {
        return repoPunto.findByRuta_Id(idRuta);
    }

    public Optional<PuntosPeligro> findByRutaAndId(int idPunto, int idRuta) {
        return repoPunto.findByIdAndRuta_Id(idPunto, idRuta);
    }
}
