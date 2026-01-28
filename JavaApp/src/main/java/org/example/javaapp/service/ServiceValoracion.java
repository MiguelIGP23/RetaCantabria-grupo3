package org.example.javaapp.service;

import org.example.javaapp.model.Valora;
import org.example.javaapp.persistence.ValoracionRepository;
import org.springframework.stereotype.Service;

@Service
public class ServiceValoracion implements IServiceValoracion{
    private ValoracionRepository repo;

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
            aModificar.setReseña(valora.getReseña());
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
}
