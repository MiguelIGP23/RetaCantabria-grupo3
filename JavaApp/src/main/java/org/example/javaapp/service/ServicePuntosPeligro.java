package org.example.javaapp.service;

import org.example.javaapp.model.PuntosPeligro;
import org.example.javaapp.repository.PuntosPeligroRepository;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class ServicePuntosPeligro implements IServicePuntosPeligro{

    private PuntosPeligroRepository repo;

    public ServicePuntosPeligro(PuntosPeligroRepository repo){
        this.repo=repo;
    }

    @Override
    public PuntosPeligro insert(PuntosPeligro puntospeligro) {
        return repo.save(puntospeligro);
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
            repo.save(buscado);
        }
        return buscado;
    }

    @Override
    public void delete(Integer id) {
        repo.deleteById(id);
    }

    @Override
    public PuntosPeligro findById(Integer id) {
        return repo.findById(id).orElse(null);
    }

    @Override
    public List<PuntosPeligro> findAll() {
        return repo.findAll();
    }

    public List<PuntosPeligro> findByIdruta(Integer id){
        return repo.findByRuta_Id(id);
    }
}
