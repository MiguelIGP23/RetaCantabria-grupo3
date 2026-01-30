package org.example.javaapp.service;

import org.example.javaapp.model.Ruta;
import org.example.javaapp.repository.RutaRepository;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class ServiceRuta implements IServiceRuta {

    private RutaRepository repo;

    public ServiceRuta(RutaRepository repo) {
        this.repo = repo;
    }

    @Override
    public Ruta insert(Ruta ruta) {
        return repo.save(ruta);
    }

    @Override
    public Ruta update(Integer id, Ruta ruta) {
        Ruta buscada = findById(id);
        if (buscada != null) {
            buscada.setNombre(ruta.getNombre());
            buscada.setNombreInicioruta(ruta.getNombreInicioruta());
            buscada.setNombreFinalruta(ruta.getNombreFinalruta());
            buscada.setLatitudInicial(ruta.getLatitudInicial());
            buscada.setLatitudFinal(ruta.getLatitudFinal());
            buscada.setLongitudInicial(ruta.getLongitudInicial());
            buscada.setLongitudFinal(ruta.getLongitudFinal());
            buscada.setDistancia(ruta.getDistancia());
            buscada.setDuracion(ruta.getDuracion());
            buscada.setDesnivelPositivo(ruta.getDesnivelPositivo());
            buscada.setDesnivelNegativo(ruta.getDesnivelNegativo());
            buscada.setAltitudMin(ruta.getAltitudMin());
            buscada.setAltitudMax(ruta.getAltitudMax());
            buscada.setClasificacion(ruta.getClasificacion());
            buscada.setEstadoRuta(ruta.getEstadoRuta());
            buscada.setTipoTerreno(ruta.getTipoTerreno());
            buscada.setIndicaciones(ruta.getIndicaciones());
            buscada.setTemporadas(ruta.getTemporadas());
            buscada.setAccesibilidad(ruta.getAccesibilidad());
            buscada.setRutaFamiliar(ruta.getRutaFamiliar());
            buscada.setArchivoGPX(ruta.getArchivoGPX());
            buscada.setRecomendacionesEquipo(ruta.getRecomendacionesEquipo());
            buscada.setZonaGeografica(ruta.getZonaGeografica());
            buscada.setUsuario(ruta.getUsuario());
            repo.save(buscada);
        }
        return buscada;
    }

    @Override
    public void delete(Integer id) {
        repo.deleteById(id);
    }

    @Override
    public Ruta findById(Integer id) {
        return repo.findById(id).orElse(null);
    }

    @Override
    public List<Ruta> findAll() {
        return repo.findAll();
    }
}
