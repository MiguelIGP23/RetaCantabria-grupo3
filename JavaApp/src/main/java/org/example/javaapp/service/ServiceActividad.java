package org.example.javaapp.service;

import org.example.javaapp.model.Actividad;
import org.example.javaapp.model.Ruta;
import org.example.javaapp.repository.ActividadRepository;
import org.example.javaapp.repository.RutaRepository;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.List;
import java.util.Optional;

@Service
public class ServiceActividad implements IServiceActividad {

    private final ActividadRepository repoActividad;
    private final RutaRepository repoRuta;

    public ServiceActividad(ActividadRepository repo, RutaRepository repoRuta) {
        this.repoActividad = repo;
        this.repoRuta = repoRuta;
    }


    //CRUD genérico

    @Override
    public Actividad insert(Actividad actividad) {
        return repoActividad.save(actividad);
    }

    @Override
    public Actividad update(Integer id, Actividad actividad) {
        Actividad buscada = findById(id);
        if (buscada != null) {
            buscada.setNombre(actividad.getNombre());
            buscada.setRuta(actividad.getRuta());
            repoActividad.save(buscada);
        }
        return buscada;
    }

    @Override
    public void delete(Integer id) {
        repoActividad.deleteById(id);
    }

    @Override
    public Actividad findById(Integer id) {
        return repoActividad.findById(id).orElse(null);
    }

    @Override
    public List<Actividad> findAll() {
        return repoActividad.findAll();
    }



    //CRUD dependiente de ruta

    public Actividad insertInRuta(int idRuta, Actividad actividad) {
        Ruta ruta = repoRuta.findById(idRuta).orElse(null);
        if (ruta == null) return null;

        actividad.setId(null);
        actividad.setRuta(ruta);
        return repoActividad.save(actividad);
    }

    public Actividad updateInRuta(int idActividad, int idRuta, Actividad actividad) {
        Optional<Actividad> act = repoActividad.findByIdAndRuta_Id(idActividad, idRuta);
        if (act.isEmpty()) return null;
        Actividad buscada= act.get();
        buscada.setNombre(actividad.getNombre());
        return repoActividad.save(buscada);
    }

    @Transactional
    public void deleteFromRuta(int idActividad, int idRuta) {
        repoActividad.deleteByIdAndRuta_Id(idActividad, idRuta);
    }

    public List<Actividad> findAllByRuta(int idRuta) {
        return repoActividad.findByRuta_Id(idRuta);
    }

    public Optional<Actividad> findByRutaAndId(int idActividad, int idRuta) {
        return repoActividad.findByIdAndRuta_Id(idActividad, idRuta);
    }



}
