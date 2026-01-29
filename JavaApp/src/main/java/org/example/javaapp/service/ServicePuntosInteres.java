package org.example.javaapp.service;

import org.example.javaapp.model.Puntosintere;
import org.example.javaapp.persistence.PuntosInteresRepository;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class ServicePuntosInteres implements IServicePuntosInteres{

    private PuntosInteresRepository  repo;

    public ServicePuntosInteres(PuntosInteresRepository repo) {
        this.repo = repo;
    }

    @Override
    public Puntosintere insert(Puntosintere puntosintere) {
        return repo.save(puntosintere);
    }

    @Override
    public Puntosintere update(int id, Puntosintere nuevo) {
        Puntosintere buscado = findById(id);
        if(buscado!=null){
            buscado.setNombre(nuevo.getNombre());
            buscado.setLatitud(nuevo.getLatitud());
            buscado.setLongitud(nuevo.getLongitud());
            buscado.setElevacion(nuevo.getElevacion());
            buscado.setTipo(nuevo.getTipo());
            buscado.setCaracteristicas(nuevo.getCaracteristicas());
            buscado.setTimestamp(nuevo.getTimestamp());
            buscado = repo.save(buscado);
        }
        return buscado;
    }

    @Override
    public void delete(int id) {
        repo.deleteById(id);
    }

    @Override
    public Puntosintere findById(int id) {
        return repo.findById(id).orElse(null);
    }

    @Override
    public List<Puntosintere> findAll(){
        return repo.findAll();
    }
}
