package org.example.javaapp.service;

import org.example.javaapp.model.PuntosInteres;
import org.example.javaapp.model.Ruta;
import org.example.javaapp.repository.PuntosInteresRepository;
import org.example.javaapp.repository.RutaRepository;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class ServicePuntosInteres implements IServicePuntosInteres{

    private final PuntosInteresRepository repoPuntos;
    private final RutaRepository repoRuta;

    public ServicePuntosInteres(PuntosInteresRepository repo, RutaRepository repoRuta) {
        this.repoPuntos = repo;
        this.repoRuta = repoRuta;
    }


    // CRUD genérico

    @Override
    public PuntosInteres insert(PuntosInteres puntosInteres) {
        return repoPuntos.save(puntosInteres);
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
            repoPuntos.save(buscado);
        }
        return buscado;
    }

    @Override
    public void delete(Integer id) {
        repoPuntos.deleteById(id);
    }

    @Override
    public PuntosInteres findById(Integer id) {
        return repoPuntos.findById(id).orElse(null);
    }

    @Override
    public List<PuntosInteres> findAll(){
        return repoPuntos.findAll();
    }

    public List<PuntosInteres> findByIdRuta(Integer id){
        return repoPuntos.findByRuta_Id(id);
    }


    // CRUD dependiente de Ruta

    public PuntosInteres insertInRuta(int idRuta, PuntosInteres pi) {
        Ruta ruta = repoRuta.findById(idRuta).orElse(null);
        if (ruta == null) return null;

        pi.setRuta(ruta);
        return repoPuntos.save(pi);
    }

    public PuntosInteres updateInRuta(int idPuntoInteres, int idRuta, PuntosInteres pi) {
        Optional<PuntosInteres> opt = repoPuntos.findByIdAndRuta_Id(idPuntoInteres, idRuta);
        if (opt.isEmpty()) return null;
        PuntosInteres buscado = opt.get();

        buscado.setNombre(pi.getNombre());
        buscado.setLatitud(pi.getLatitud());
        buscado.setLongitud(pi.getLongitud());
        buscado.setElevacion(pi.getElevacion());
        buscado.setTipo(pi.getTipo());
        buscado.setDescripcion(pi.getDescripcion());
        buscado.setCaracteristicas(pi.getCaracteristicas());
        buscado.setTimestamp(pi.getTimestamp());
        buscado.setRuta(pi.getRuta());
        return repoPuntos.save(buscado);
    }

    public void deleteFromRuta(int idPuntoInteres, int idRuta) {
        repoPuntos.deleteByIdAndRuta_Id(idPuntoInteres, idRuta);
    }

    public List<PuntosInteres> findAllByRuta(int idRuta) {
        return repoPuntos.findByRuta_Id(idRuta);
    }

    public Optional<PuntosInteres> findByRutaAndId(int idPuntoInteres, int idRuta) {
        return repoPuntos.findByIdAndRuta_Id(idPuntoInteres, idRuta);
    }
}
