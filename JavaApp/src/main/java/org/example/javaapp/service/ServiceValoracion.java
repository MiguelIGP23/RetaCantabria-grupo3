package org.example.javaapp.service;

import org.example.javaapp.model.Valora;
import org.example.javaapp.repository.ValoracionRepository;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class ServiceValoracion implements IServiceValoracion{

    private final ValoracionRepository repo;

    public ServiceValoracion(ValoracionRepository repo){this.repo=repo;}

    @Override
    public Valora insert(Valora valora) {
        return repo.save(valora);
    }

    @Override
    public Valora update(int id, Valora valora) {
        Valora aModificar = repo.findById(id).orElse(null);
        if (aModificar != null) {
            aModificar.setBelleza(valora.getBelleza());
            aModificar.setDificultad(valora.getDificultad());
            aModificar.setEstrellas(valora.getEstrellas());
            aModificar.setFecha(valora.getFecha());
            aModificar.setResena(valora.getResena());
            aModificar.setInteresCultural(valora.getInteresCultural());
            aModificar.setRutasIdruta(valora.getRutasIdruta());
            aModificar.setUsuarioIdusuario(valora.getUsuarioIdusuario());
            aModificar.setValoracionTecnica(valora.getValoracionTecnica());
            repo.save(valora);
        }
        return aModificar;
    }

    @Override
    public void delete(int id) {
        repo.deleteById(id);
    }

    @Override
    public Valora findById(int id) {
        return repo.findById(id).orElse(null);
    }

    @Override
    public List<Valora> findAll(){
        return repo.findAll();
    }
}
