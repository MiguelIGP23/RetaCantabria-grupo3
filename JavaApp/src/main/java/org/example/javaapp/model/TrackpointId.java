package org.example.javaapp.model;

import jakarta.persistence.Column;
import jakarta.persistence.Embeddable;

import java.io.Serializable;
import java.util.Objects;

@Embeddable
public class TrackpointId implements Serializable {
    private static final long serialVersionUID = 6662191556273514187L;
    @Column(name = "idRuta", nullable = false)
    private Integer idRuta;

    @Column(name = "posicion", nullable = false)
    private Integer posicion;

    public Integer getIdRuta() {
        return idRuta;
    }

    public void setIdRuta(Integer idRuta) {
        this.idRuta = idRuta;
    }

    public Integer getPosicion() {
        return posicion;
    }

    public void setPosicion(Integer posicion) {
        this.posicion = posicion;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        TrackpointId entity = (TrackpointId) o;
        return Objects.equals(this.idRuta, entity.idRuta) &&
                Objects.equals(this.posicion, entity.posicion);
    }

    @Override
    public int hashCode() {
        return Objects.hash(idRuta, posicion);
    }
}