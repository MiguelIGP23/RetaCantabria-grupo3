package org.example.javaapp.model;

import jakarta.persistence.*;

@Entity
@Table(name = "imagenespeligro", schema = "retadb")
public class Imagenespeligro {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "idimagenespeligro", nullable = false)
    private Integer id;

    @Lob
    @Column(name = "url", nullable = false)
    private String url;

    @Lob
    @Column(name = "descripcion")
    private String descripcion;

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

}