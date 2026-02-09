package org.example.javaapp.service;

import org.example.javaapp.model.PuntosInteres;
import org.example.javaapp.model.Ruta;
import org.example.javaapp.repository.PuntosInteresRepository;
import org.example.javaapp.repository.RutaRepository;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

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

        pi.setId(null);
        pi.setRuta(ruta);
        return repoPuntos.save(pi);
    }

    public PuntosInteres updateInRuta(Integer idPunto, Integer idRuta, PuntosInteres datos) {
        Optional<PuntosInteres> opt = repoPuntos.findByIdAndRuta_Id(idPunto, idRuta);
        if (opt.isEmpty()) return null;

        PuntosInteres p = opt.get();
        p.setNombre(datos.getNombre());
        p.setLatitud(datos.getLatitud());
        p.setLongitud(datos.getLongitud());
        p.setElevacion(datos.getElevacion());
        p.setCaracteristicas(datos.getCaracteristicas());
        p.setTipo(datos.getTipo());
        p.setDescripcion(datos.getDescripcion());
        p.setTimestamp(datos.getTimestamp());
        return repoPuntos.save(p);
    }

    @Transactional
    public void deleteFromRuta(Integer idPunto, Integer idRuta) {
        repoPuntos.deleteByIdAndRuta_Id(idPunto, idRuta);
    }

    public Optional<PuntosInteres> findByRutaAndId(Integer idPunto, Integer idRuta) {
        return repoPuntos.findByIdAndRuta_Id(idPunto, idRuta);
    }

    public List<PuntosInteres> findAllByRuta(Integer idRuta) {
        return repoPuntos.findByRuta_Id(idRuta);
    }
}
