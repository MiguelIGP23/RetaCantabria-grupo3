package org.example.javaapp;

import jakarta.persistence.*;
import org.hibernate.annotations.ColumnDefault;

@Entity
@Table(name = "puntosinteres", schema = "retadb")
public class Puntosintere {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "idPuntosinteres", nullable = false)
    private Integer id;

    @Column(name = "nombre", nullable = false, length = 40)
    private String nombre;

    @Column(name = "latitud", nullable = false)
    private Double latitud;

    @Column(name = "longitud", nullable = false)
    private Double longitud;

    @Column(name = "elevacion", nullable = false)
    private Double elevacion;

    @Lob
    @Column(name = "caracteristicas")
    private String caracteristicas;

    @ColumnDefault("'mirador'")
    @Lob
    @Column(name = "tipo")
    private String tipo;

    @Lob
    @Column(name = "descripcion")
    private String descripcion;

    @Column(name = "timestamp")
    private Integer timestamp;

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
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

    public String getCaracteristicas() {
        return caracteristicas;
    }

    public void setCaracteristicas(String caracteristicas) {
        this.caracteristicas = caracteristicas;
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public Integer getTimestamp() {
        return timestamp;
    }

    public void setTimestamp(Integer timestamp) {
        this.timestamp = timestamp;
    }

}