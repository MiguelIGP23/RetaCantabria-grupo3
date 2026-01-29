package org.example.javaapp.service;

import org.example.javaapp.model.PuntosInteres;
import org.example.javaapp.repository.PuntosInteresRepository;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class ServicePuntosInteres implements IServicePuntosInteres{

    private final PuntosInteresRepository repo;

    public ServicePuntosInteres(PuntosInteresRepository repo) {
        this.repo = repo;
    }

    @Override
    public PuntosInteres insert(PuntosInteres puntosInteres) {
        return repo.save(puntosInteres);
    }

    @Override
    public PuntosInteres update(int id, PuntosInteres nuevo) {
        PuntosInteres buscado = findById(id);
        if(buscado!=null){
            buscado.setNombre(nuevo.getNombre());
            buscado.setLatitud(nuevo.getLatitud());
            buscado.setLongitud(nuevo.getLongitud());
            buscado.setElevacion(nuevo.getElevacion());
            buscado.setTipo(nuevo.getTipo());
            buscado.setCaracteristicas(nuevo.getCaracteristicas());
            buscado.setTimestamp(nuevo.getTimestamp());
            buscado.setRuta(nuevo.getRuta());
            buscado = repo.save(buscado);
        }
        return buscado;
    }

    @Override
    public void delete(int id) {
        repo.deleteById(id);
    }

    @Override
    public PuntosInteres findById(int id) {
        return repo.findById(id).orElse(null);
    }

    @Override
    public List<PuntosInteres> findAll(){
        return repo.findAll();
    }
}
