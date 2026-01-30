package org.example.javaapp.service;

import org.example.javaapp.model.Usuario;
import org.example.javaapp.repository.UsuarioRepository;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
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
    public Usuario update(Integer id, Usuario nuevo) {
        Usuario buscado = findById(id);
        if(buscado!=null){
            buscado.setNombre(nuevo.getNombre());
            buscado.setApellido(nuevo.getApellido());
            buscado.setEmail(nuevo.getEmail());
            buscado.setPassword(nuevo.getPassword());
            buscado.setRol(nuevo.getRol());
            repo.save(buscado);
        }
        return buscado;
    }

    @Override
    public void delete(Integer id) {
        repo.deleteById(id);
    }

    @Override
    public Usuario findById(Integer id) {
        return repo.findById(id).orElse(null);
    }

    @Override
    public List<Usuario> findAll(){
        return repo.findAll();
    }
}
