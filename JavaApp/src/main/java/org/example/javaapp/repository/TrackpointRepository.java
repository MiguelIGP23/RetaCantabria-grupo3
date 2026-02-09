package org.example.javaapp.repository;

import org.example.javaapp.model.Trackpoint;
import org.example.javaapp.model.TrackpointId;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;
import java.util.Optional;

public interface TrackpointRepository extends JpaRepository<Trackpoint, TrackpointId> {

    List<Trackpoint> findById_IdRuta(Integer idRuta);

    Optional<Trackpoint> findById_IdRutaAndId_Posicion(Integer idRuta, Integer posicion);

    void deleteById_IdRutaAndId_Posicion(Integer idRuta, Integer posicion);

    boolean existsById_IdRutaAndId_Posicion(Integer idRuta, Integer posicion);
}
