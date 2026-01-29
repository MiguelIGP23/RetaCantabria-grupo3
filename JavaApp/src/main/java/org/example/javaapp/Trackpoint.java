package org.example.javaapp;

import jakarta.persistence.*;
import org.example.javaapp.model.Ruta;
import org.hibernate.annotations.OnDelete;
import org.hibernate.annotations.OnDeleteAction;

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

    public TrackpointId getId() {
        return id;
    }

    public void setId(TrackpointId id) {
        this.id = id;
    }

    public Ruta getIdRuta() {
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

}