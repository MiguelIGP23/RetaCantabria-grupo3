package org.example.javaapp.model;

import jakarta.persistence.*;

@Entity
@Table(name = "imagenespeligro", schema = "retadb")
public class ImagenesPeligro {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "idimagenespeligro", nullable = false)
    private Integer id;

    @Column(name = "url", nullable = false)
    private String url;

    @Column(name = "descripcion")
    private String descripcion;

    @ManyToOne(fetch = FetchType.LAZY, optional = false)
    @JoinColumn(name = "puntospeligro_idPuntospeligro", nullable = false)
    private PuntosPeligro puntosPeligro;

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    public String getUrl() {
        return url;
    }

    public void setUrl(String url) {
        this.url = url;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public void setPuntosPeligro(PuntosPeligro puntospeligro) {
        this.puntosPeligro = puntospeligro;
    }

    public PuntosPeligro getPuntosPeligro() {
        return puntosPeligro;
    }

}