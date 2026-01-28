package org.example.javaapp.model;

import jakarta.persistence.*;
import org.hibernate.annotations.ColumnDefault;

@Entity
@Table(name = "usuario", schema = "retadb")
public class Usuario {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "idUsuario", nullable = false)
    private Integer id;

    @Column(name = "nombre", nullable = false, length = 20)
    private String nombre;

    @Column(name = "apellido", nullable = false, length = 25)
    private String apellido;

    @Column(name = "email", nullable = false, length = 30)
    private String email;

    @Column(name = "password", nullable = false, length = 32)
    private String password;

    @ColumnDefault("'alumno'")
    @Lob
    @Column(name = "rol")
    private String rol;

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

    public String getApellido() {
        return apellido;
    }

    public void setApellido(String apellido) {
        this.apellido = apellido;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public String getRol() {
        return rol;
    }

    public void setRol(String rol) {
        this.rol = rol;
    }

}