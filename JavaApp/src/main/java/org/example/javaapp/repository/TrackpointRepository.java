package org.example.javaapp.repository;

import org.example.javaapp.model.Trackpoint;
import org.example.javaapp.model.TrackpointId;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface TrackpointRepository extends JpaRepository<Trackpoint, TrackpointId> {

    List<Trackpoint> findById_IdRuta(Integer idRuta);
}
