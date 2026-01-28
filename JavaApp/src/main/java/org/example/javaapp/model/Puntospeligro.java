package org.example.javaapp.model;

import jakarta.persistence.*;

@Entity
@Table(name = "puntospeligro", schema = "retadb")
public class Puntospeligro {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "idPuntospeligro", nullable = false)
    private Integer id;

    @Column(name = "nombre", nullable = false, length = 40)
    private String nombre;

    @Column(name = "latitud", nullable = false)
    private Double latitud;

    @Column(name = "longitud", nullable = false)
    private Double longitud;

    @Column(name = "elevacion", nullable = false)
    private Double elevacion;

    @Column(name = "kilometros")
    private Double kilometros;

    @Column(name = "gravedad")
    private Byte gravedad;

    @Column(name = "posicion")
    private Integer posicion;

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

    public Double getKilometros() {
        return kilometros;
    }

    public void setKilometros(Double kilometros) {
        this.kilometros = kilometros;
    }

    public Byte getGravedad() {
        return gravedad;
    }

    public void setGravedad(Byte gravedad) {
        this.gravedad = gravedad;
    }

    public Integer getPosicion() {
        return posicion;
    }

    public void setPosicion(Integer posicion) {
        this.posicion = posicion;
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