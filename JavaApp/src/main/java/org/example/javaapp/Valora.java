package org.example.javaapp;

import jakarta.persistence.*;

import java.time.LocalDate;

@Entity
@Table(name = "valora", schema = "retadb")
public class Valora {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "idValora", nullable = false)
    private Integer id;

    @Column(name = "dificultad", nullable = false)
    private Byte dificultad;

    @Column(name = "fecha", nullable = false)
    private LocalDate fecha;

    @Column(name = "estrellas", nullable = false)
    private Byte estrellas;

    @Column(name = "interesCultural", nullable = false)
    private Byte interesCultural;

    @Column(name = "belleza", nullable = false)
    private Byte belleza;

    @Lob
    @Column(name = "valoracionTecnica")
    private String valoracionTecnica;

    @Lob
    @Column(name = "`reseña`")
    private String reseña;

    @ManyToOne(fetch = FetchType.LAZY, optional = false)
    @JoinColumn(name = "usuario_idUsuario", nullable = false)
    private Usuario usuarioIdusuario;

    @ManyToOne(fetch = FetchType.LAZY, optional = false)
    @JoinColumn(name = "rutas_idRuta", nullable = false)
    private Ruta rutasIdruta;

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    public Byte getDificultad() {
        return dificultad;
    }

    public void setDificultad(Byte dificultad) {
        this.dificultad = dificultad;
    }

    public LocalDate getFecha() {
        return fecha;
    }

    public void setFecha(LocalDate fecha) {
        this.fecha = fecha;
    }

    public Byte getEstrellas() {
        return estrellas;
    }

    public void setEstrellas(Byte estrellas) {
        this.estrellas = estrellas;
    }

    public Byte getInteresCultural() {
        return interesCultural;
    }

    public void setInteresCultural(Byte interesCultural) {
        this.interesCultural = interesCultural;
    }

    public Byte getBelleza() {
        return belleza;
    }

    public void setBelleza(Byte belleza) {
        this.belleza = belleza;
    }

    public String getValoracionTecnica() {
        return valoracionTecnica;
    }

    public void setValoracionTecnica(String valoracionTecnica) {
        this.valoracionTecnica = valoracionTecnica;
    }

    public String getReseña() {
        return reseña;
    }

    public void setReseña(String reseña) {
        this.reseña = reseña;
    }

    public Usuario getUsuarioIdusuario() {
        return usuarioIdusuario;
    }

    public void setUsuarioIdusuario(Usuario usuarioIdusuario) {
        this.usuarioIdusuario = usuarioIdusuario;
    }

    public Ruta getRutasIdruta() {
        return rutasIdruta;
    }

    public void setRutasIdruta(Ruta rutasIdruta) {
        this.rutasIdruta = rutasIdruta;
    }

}