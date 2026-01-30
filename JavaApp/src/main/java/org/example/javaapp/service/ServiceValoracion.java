package org.example.javaapp.service;

import org.example.javaapp.model.Valoracion;
import org.example.javaapp.repository.ValoracionRepository;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class ServiceValoracion implements IServiceValoracion{

    private final ValoracionRepository repo;

    public ServiceValoracion(ValoracionRepository repo){this.repo=repo;}

    @Override
    public Valoracion insert(Valoracion valoracion) {
        return repo.save(valoracion);
    }

    @Override
    public Valoracion update(Integer id, Valoracion valoracion) {
        Valoracion aModificar = repo.findById(id).orElse(null);
        if (aModificar != null) {
            aModificar.setBelleza(valoracion.getBelleza());
            aModificar.setDificultad(valoracion.getDificultad());
            aModificar.setEstrellas(valoracion.getEstrellas());
            aModificar.setFecha(valoracion.getFecha());
            aModificar.setResena(valoracion.getResena());
            aModificar.setInteresCultural(valoracion.getInteresCultural());
            aModificar.setRutasIdruta(valoracion.getRutasIdruta());
            aModificar.setUsuarioIdusuario(valoracion.getUsuarioIdusuario());
            aModificar.setValoracionTecnica(valoracion.getValoracionTecnica());
            repo.save(valoracion);
        }
        return aModificar;
    }

    @Override
    public void delete(Integer id) {
        repo.deleteById(id);
    }

    @Override
    public Valoracion findById(Integer id) {
        return repo.findById(id).orElse(null);
    }

    @Override
    public List<Valoracion> findAll(){
        return repo.findAll();
    }
}
