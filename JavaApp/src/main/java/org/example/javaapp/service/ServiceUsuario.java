package org.example.javaapp.service;

import org.example.javaapp.model.Rol;
import org.example.javaapp.model.Usuario;
import org.example.javaapp.repository.UsuarioRepository;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class ServiceUsuario implements IServiceUsuario{

    private final UsuarioRepository repo;
    private final PasswordEncoder encoder;

    public ServiceUsuario(UsuarioRepository repo, PasswordEncoder encoder) {
        this.repo = repo;
        this.encoder = encoder;
    }

    @Override
    public Usuario insert(Usuario usuario) {
        Usuario nuevo= new Usuario();
        nuevo.setEmail(usuario.getEmail());
        nuevo.setRol(usuario.getRol());
        nuevo.setPassword(encoder.encode(usuario.getPassword()));  //Cifrado por BCrypt
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
