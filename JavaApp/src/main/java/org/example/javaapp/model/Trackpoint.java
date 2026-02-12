package org.example.javaapp.model;

import jakarta.persistence.*;
import org.hibernate.annotations.OnDelete;
import org.hibernate.annotations.OnDeleteAction;

import java.time.LocalTime;

@Entity
@Table(name = "trackpoints", schema = "retadb")
public class Trackpoint {
    @EmbeddedId
    private TrackpointId id;

    @MapsId("idRuta")
    @ManyToOne(fetch = FetchType.LAZY, optional = false)
    @OnDelete(action = OnDeleteAction.CASCADE)
    @JoinColumn(name = "idRuta", nullable = false)
    private Ruta idRuta;

    @Column(name = "latitud", nullable = false)
    private Double latitud;

    @Column(name = "longitud", nullable = false)
    private Double longitud;

    @Column(name = "elevacion", nullable = false)
    private Double elevacion;

    @Column(name = "time", nullable = false)
    private LocalTime time;

    public TrackpointId getId() {
        return id;
    }

    public void setId(TrackpointId id) {
        this.id = id;
    }

    public Ruta getRuta() {
        return idRuta;
    }

    public void setIdRuta(Ruta idRuta) {
        this.idRuta = idRuta;
    }

    public Double getLatitud() {
        return latitud;
    }

    public void setLatitud(Double latitud) {
        this.latitud = latitud;
    }

    public Double getLongitud() {
        return longitud;
    }

    public void setLongitud(Double longitud) {
        this.longitud = longitud;
    }

    public Double getElevacion() {
        return elevacion;
    }

    public void setElevacion(Double elevacion) {
        this.elevacion = elevacion;
    }

    public LocalTime getTime() {
        return time;
    }

    public void setTime(LocalTime time) {
        this.time = time;
    }
}