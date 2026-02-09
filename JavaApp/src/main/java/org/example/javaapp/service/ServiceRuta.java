package org.example.javaapp.service;

import org.example.javaapp.model.Ruta;
import org.example.javaapp.model.Trackpoint;
import org.example.javaapp.repository.RutaRepository;
import org.example.javaapp.repository.TrackpointRepository;
import org.springframework.http.HttpStatus;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;
import org.springframework.web.multipart.MultipartFile;
import org.springframework.web.server.ResponseStatusException;

import java.io.IOException;
import java.util.Base64;
import java.util.List;

@Service
public class ServiceRuta implements IServiceRuta {

    private final RutaRepository repoRuta;
    private final TrackpointRepository repoTrack;

    public ServiceRuta(RutaRepository repoRuta, TrackpointRepository repoTrack) {
        this.repoRuta = repoRuta;
        this.repoTrack = repoTrack;
    }

    @Override
    public Ruta insert(Ruta ruta) {
        return repoRuta.save(ruta);
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
            buscada.setNivelRiesgo(ruta.getNivelRiesgo());
            buscada.setNivelEsfuerzo(ruta.getNivelEsfuerzo());
            buscada.setMediaEstrellas(ruta.getMediaEstrellas());
            buscada.setUsuario(ruta.getUsuario());
            repoRuta.save(buscada);
        }
        return buscada;
    }

    @Override
    public void delete(Integer id) {
        repoRuta.deleteById(id);
    }

    @Override
    public Ruta findById(Integer id) {
        return repoRuta.findById(id).orElse(null);
    }

    @Override
    public List<Ruta> findAll() {
        return repoRuta.findAll();
    }


    // Parte de ruta validadas

    public List<Ruta> findValidadas(){
        return repoRuta.findByEstadoRuta((byte) 1);
    }

    public Ruta validar(Integer id){
        Ruta ruta = findById(id);
        if(ruta == null) return null;
        byte estado = (ruta.getEstadoRuta() == ((byte)0)) ? ((byte) 1) : ((byte)0);
        ruta.setEstadoRuta(estado);
        return repoRuta.save(ruta);
    }

    //Parte de gpx
    @Transactional
    public void subirGpxYGenerarTrackpoints(int idRuta, MultipartFile file) {

        Ruta ruta = repoRuta.findById(idRuta).orElseThrow(() -> new ResponseStatusException(HttpStatus.NOT_FOUND, "Ruta no encontrada"));

        try {
            byte[] bytes = file.getBytes();
            String gpxBase64 = Base64.getEncoder().encodeToString(bytes);

            ruta.setArchivoGPX(gpxBase64);
            repoRuta.save(ruta);

            // ahora generas trackpoints
            List<Trackpoint> puntos = parsearTrackpoints(bytes, ruta);

            // si quieres reemplazar los anteriores:
            repoTrack.deleteById_IdRuta(idRuta);
            repoTrack.saveAll(puntos);

        } catch (IOException e) {
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "No se pudo leer el GPX", e);
        }
    }

}
