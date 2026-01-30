package org.example.javaapp.service;

import jakarta.persistence.EntityManager;
import org.example.javaapp.model.Ruta;
import org.example.javaapp.model.Trackpoint;
import org.example.javaapp.model.TrackpointId;
import org.example.javaapp.repository.TrackpointRepository;
import org.springframework.http.HttpStatus;
import org.springframework.stereotype.Service;
import org.springframework.web.server.ResponseStatusException;

import java.util.List;

@Service
public class ServiceTrackpoint implements IServiceTrackpoint{

    private final TrackpointRepository repo;
    private final EntityManager entityManager;

    public ServiceTrackpoint(TrackpointRepository repo, EntityManager entityManager){
        this.repo=repo;
        this.entityManager=entityManager;
    }

    @Override
    public Trackpoint insert(Trackpoint trackpoint) {
        if (trackpoint.getId() == null) {
            trackpoint.setId(new TrackpointId());
        }

        Integer idRuta = trackpoint.getId().getIdRuta();
        Integer posicion = trackpoint.getId().getPosicion();
        if (idRuta == null || posicion==null) {
            return null;
        }

        if(repo.existsById(trackpoint.getId())){
            throw new ResponseStatusException(HttpStatus.CONFLICT, "Ya existe trackpoint en ruta "+idRuta+" en posición "+posicion);
        }

        // Arregla error de asociación de PK en las peticiones
        trackpoint.setIdRuta(entityManager.getReference(Ruta.class, idRuta));

        return repo.save(trackpoint);
    }

    @Override
    public Trackpoint update(TrackpointId id, Trackpoint trackpoint) {
        Trackpoint buscado= findById(id);
        if(buscado!=null){
         buscado.setLatitud(trackpoint.getLatitud());
         buscado.setLongitud(trackpoint.getLongitud());
         repo.save(buscado);
        }
        return buscado;
    }

    @Override
    public void delete(TrackpointId id) {
        repo.deleteById(id);
    }

    @Override
    public Trackpoint findById(TrackpointId id) {
        return repo.findById(id).orElse(null);
    }

    @Override
    public List<Trackpoint> findAll() {
        return repo.findAll();
    }

    public List<Trackpoint> findByRuta(Integer idRuta) {
        return repo.findById_IdRuta(idRuta);
    }

    private TrackpointId buildId(Integer idRuta, Integer posicion){
        TrackpointId id = new TrackpointId();
        id.setIdRuta(idRuta);
        id.setPosicion(posicion);
        return id;
    }

    // Métodos wrapper para convertir la FK compuesta

    public Trackpoint findById(Integer idRuta, Integer posicion) {
        return findById(buildId(idRuta, posicion));
    }

    public Trackpoint insert(Integer idRuta, Trackpoint trackpoint) {
        if (trackpoint.getId() == null) trackpoint.setId(new TrackpointId());
        trackpoint.getId().setIdRuta(idRuta);
        return insert(trackpoint); // llama al insert(trackpoint) de la interfaz
    }

    public Trackpoint update(Integer idRuta, Integer posicion, Trackpoint trackpoint) {
        return update(buildId(idRuta, posicion), trackpoint);
    }

    public void delete(Integer idRuta, Integer posicion) {
        delete(buildId(idRuta, posicion));
    }


}
