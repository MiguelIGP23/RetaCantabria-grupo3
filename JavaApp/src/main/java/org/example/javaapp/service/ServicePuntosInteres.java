package org.example.javaapp.service;

import org.example.javaapp.model.Puntosintere;
import org.example.javaapp.model.Usuario;
import org.example.javaapp.persistence.PuntosInteresRepository;
import org.example.javaapp.persistence.UsuarioRepository;

import java.util.List;

public class ServicePuntosInteres implements IServicePuntosInteres{

    private PuntosInteresRepository  repo;

    public ServicePuntosInteres(PuntosInteresRepository repo) {
        this.repo = repo;
    }

    @Override
    public Puntosintere insert(Puntosintere puntosintere) {
        return null;
    }

    @Override
    public Puntosintere update(int id, Puntosintere puntosintere) {
        return null;
    }

    @Override
    public void delete(int id) {

    }

    @Override
    public Puntosintere findById(int id) {
        return null;
    }

    public List<Puntosintere> findAll(){
        return repo.findAll();
    }
}
