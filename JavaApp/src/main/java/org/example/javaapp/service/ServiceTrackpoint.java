package org.example.javaapp.service;

import org.example.javaapp.model.Ruta;
import org.example.javaapp.model.Trackpoint;
import org.example.javaapp.model.TrackpointId;
import org.example.javaapp.repository.RutaRepository;
import org.example.javaapp.repository.TrackpointRepository;
import org.springframework.http.HttpStatus;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;
import org.springframework.web.server.ResponseStatusException;

import java.util.List;
import java.util.Optional;

@Service
public class ServiceTrackpoint {

    private final TrackpointRepository repoTrackpoint;
    private final RutaRepository repoRuta;

    public ServiceTrackpoint(TrackpointRepository repoTrackpoint, RutaRepository repoRuta) {
        this.repoTrackpoint = repoTrackpoint;
        this.repoRuta = repoRuta;
    }

    // ---------------------------
    // CRUD genérico
    // ---------------------------

    public Trackpoint insert(Trackpoint trackpoint) {
        return repoTrackpoint.save(trackpoint);
    }

    public Trackpoint update(TrackpointId id, Trackpoint trackpoint) {
        Trackpoint buscado = findById(id);
        if (buscado != null) {
            buscado.setLatitud(trackpoint.getLatitud());
            buscado.setLongitud(trackpoint.getLongitud());
            repoTrackpoint.save(buscado);
        }
        return buscado;
    }

    public void delete(TrackpointId id) {
        repoTrackpoint.deleteById(id);
    }

    public Trackpoint findById(TrackpointId id) {
        return repoTrackpoint.findById(id).orElse(null);
    }

    public List<Trackpoint> findAll() {
        return repoTrackpoint.findAll();
    }

    // ---------------------------
    // CRUD dependiente de Ruta
    // ---------------------------

    private TrackpointId buildId(Integer idRuta, Integer posicion) {
        TrackpointId id = new TrackpointId();
        id.setIdRuta(idRuta);
        id.setPosicion(posicion);
        return id;
    }

    public List<Trackpoint> findAllByRuta(int idRuta) {
        return repoTrackpoint.findById_IdRuta(idRuta);
    }

    public Optional<Trackpoint> findByRutaAndPosicion(int idRuta, int posicion) {
        return repoTrackpoint.findById_IdRutaAndId_Posicion(idRuta, posicion);
    }

    public Trackpoint insertInRuta(int idRuta, Trackpoint trackpoint) {
        Ruta ruta = repoRuta.findById(idRuta).orElse(null);
        if (ruta == null) return null;

        if (trackpoint.getId() == null) trackpoint.setId(new TrackpointId());

        // PK compuesta: posicion obligatoria
        Integer posicion = trackpoint.getId().getPosicion();
        if (posicion == null) return null;

        // fijar idRuta de la PK
        trackpoint.getId().setIdRuta(idRuta);

        // evitar duplicado
        if (repoTrackpoint.existsById_IdRutaAndId_Posicion(idRuta, posicion)) {
            throw new ResponseStatusException(HttpStatus.CONFLICT,
                    "Ya existe trackpoint en ruta " + idRuta + " en posición " + posicion);
        }

        // @MapsId: asignar la ruta
        trackpoint.setIdRuta(ruta);

        return repoTrackpoint.save(trackpoint);
    }

    public Trackpoint updateInRuta(int idRuta, int posicion, Trackpoint trackpoint) {
        Optional<Trackpoint> opt = repoTrackpoint.findById_IdRutaAndId_Posicion(idRuta, posicion);
        if (opt.isEmpty()) return null;

        Trackpoint buscado = opt.get();
        buscado.setLatitud(trackpoint.getLatitud());
        buscado.setLongitud(trackpoint.getLongitud());
        return repoTrackpoint.save(buscado);
    }

    @Transactional
    public void deleteFromRuta(int idRuta, int posicion) {
        repoTrackpoint.deleteById_IdRutaAndId_Posicion(idRuta, posicion);
    }
}
