package org.example.javaapp.service;

import org.example.javaapp.model.PuntosInteres;
import org.example.javaapp.repository.PuntosInteresRepository;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class ServicePuntosInteres implements IServicePuntosInteres{

    private final PuntosInteresRepository repo;

    public ServicePuntosInteres(PuntosInteresRepository repo) {
        this.repo = repo;
    }

    @Override
    public PuntosInteres insert(PuntosInteres puntosInteres) {
        return repo.save(puntosInteres);
    }

    @Override
    public PuntosInteres update(Integer id, PuntosInteres nuevo) {
        PuntosInteres buscado = findById(id);
        if(buscado!=null){
            buscado.setNombre(nuevo.getNombre());
            buscado.setLatitud(nuevo.getLatitud());
            buscado.setLongitud(nuevo.getLongitud());
            buscado.setElevacion(nuevo.getElevacion());
            buscado.setTipo(nuevo.getTipo());
            buscado.setDescripcion(nuevo.getDescripcion());
            buscado.setCaracteristicas(nuevo.getCaracteristicas());
            buscado.setTimestamp(nuevo.getTimestamp());
            buscado.setRuta(nuevo.getRuta());
            repo.save(buscado);
        }
        return buscado;
    }

    @Override
    public void delete(Integer id) {
        repo.deleteById(id);
    }

    @Override
    public PuntosInteres findById(Integer id) {
        return repo.findById(id).orElse(null);
    }

    @Override
    public List<PuntosInteres> findAll(){
        return repo.findAll();
    }

    public List<PuntosInteres> findByIdRuta(Integer id){
        return repo.findByRuta_Id(id);
    }
}
