package org.example.javaapp.service;

import org.example.javaapp.model.Actividad;
import org.example.javaapp.repository.ActividadRepository;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class ServiceActividad implements IServiceActividad {

    private ActividadRepository repo;

    public ServiceActividad(ActividadRepository repo){
        this.repo=repo;
    }

    @Override
    public Actividad insert(Actividad actividad) {
        return repo.save(actividad);
    }

    @Override
    public Actividad update(int id, Actividad actividad) {
        Actividad buscada = findById(id);
        if(buscada!=null){
            buscada.setNombre(actividad.getNombre());
            buscada.setRuta(actividad.getRuta());
            repo.save(buscada);
        }
        return buscada;
    }

    @Override
    public void delete(int id) {
        repo.deleteById(id);
    }

    @Override
    public Actividad findById(int id) {
        return repo.getReferenceById(id);
    }

    @Override
    public List<Actividad> findAll() {
        return repo.findAll();
    }
}
