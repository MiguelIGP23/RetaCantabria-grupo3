package org.example.javaapp.service;

import org.example.javaapp.model.Usuario;
import org.example.javaapp.persistence.UsuarioRepository;

import java.util.List;

public class ServiceUsuario implements IServiceUsuario{

    private UsuarioRepository repo;

    public ServiceUsuario(UsuarioRepository repo) {
        this.repo = repo;
    }

    @Override
    public Usuario insert(Usuario usuario) {
        return repo.save(usuario);
    }

    @Override
    public Usuario update(int id, Usuario nuevo) {
        Usuario buscado = findById(id);
        if(buscado!=null){
            buscado.setNombre(nuevo.getNombre());
            buscado.setApellido(nuevo.getApellido());
            buscado.setEmail(nuevo.getEmail());
            buscado.setPassword(nuevo.getPassword());
            buscado.setRol(nuevo.getRol());
            buscado = repo.save(buscado);
        }
        return buscado;
    }

    @Override
    public void delete(int id) {
        repo.deleteById(id);
    }

    @Override
    public Usuario findById(int id) {
        return repo.findById(id).orElse(null);
    }

    public List<Usuario> findAll(){
        return repo.findAll();
    }
}
