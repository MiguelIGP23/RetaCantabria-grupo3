package org.example.javaapp.dto;

public class LoginResponse {

    private String token;
    private String rol;
    private Integer id;

    public LoginResponse(){}

    public LoginResponse(String token, String rol, int id){
        this.token=token;
        this.rol=rol;
        this.id=id;
    }

    public String getToken() {
        return token;
    }

    public void setToken(String token) {
        this.token = token;
    }

    public String getRol() {
        return rol;
    }

    public void setRol(String rol) {
        this.rol = rol;
    }

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }
}
