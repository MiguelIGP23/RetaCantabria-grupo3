package org.example.javaapp.service;

import org.example.javaapp.dto.DtoRutas;
import org.example.javaapp.dto.MapperRuta;
import org.example.javaapp.model.Ruta;
import org.example.javaapp.model.Trackpoint;
import org.example.javaapp.model.TrackpointId;
import org.example.javaapp.model.Usuario;
import org.example.javaapp.repository.RutaRepository;
import org.example.javaapp.repository.TrackpointRepository;
import org.example.javaapp.repository.UsuarioRepository;
import org.springframework.http.HttpStatus;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;
import org.springframework.web.multipart.MultipartFile;
import org.springframework.web.server.ResponseStatusException;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.NodeList;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import java.io.ByteArrayInputStream;
import java.time.Duration;
import java.time.LocalTime;
import java.util.ArrayList;
import java.util.Base64;
import java.util.Comparator;
import java.util.List;

@Service
public class ServiceRuta implements IServiceRuta {

    private final RutaRepository repoRuta;
    private final TrackpointRepository repoTrack;
    private final UsuarioRepository repoUsuario;

    public ServiceRuta(RutaRepository repoRuta, TrackpointRepository repoTrack, UsuarioRepository repoUsuario) {
        this.repoRuta = repoRuta;
        this.repoTrack = repoTrack;
        this.repoUsuario = repoUsuario;
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

    public List<Ruta> findValidadas() {
        return repoRuta.findByEstadoRuta((byte) 1);
    }

    public Ruta validar(Integer id) {
        Ruta ruta = findById(id);
        if (ruta == null) return null;
        byte estado = (ruta.getEstadoRuta() == ((byte) 0)) ? ((byte) 1) : ((byte) 0);
        ruta.setEstadoRuta(estado);
        return repoRuta.save(ruta);
    }

    //Crea ruta a partir de gpx y la devuelve
    @Transactional
    public Ruta crearConGpx(DtoRutas dto, MultipartFile file, int userId) {

        // Crear ruta (con lo que venga dto por defecto)
        Usuario usu = repoUsuario.findById(userId).orElse(null);
        if (usu == null) throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Usuario inexistente");

        Ruta ruta = MapperRuta.toEntity(dto, usu);
        ruta.setId(null);                       // fuerza INSERT en vez de UPDATE

        Ruta guardada = repoRuta.save(ruta);    // Ruta base ya con ID generdo

        try {
            // Guardar GPX en Base64 en la ruta
            byte[] bytes = file.getBytes();
            String gpxBase64 = Base64.getEncoder().encodeToString(bytes);

            guardada.setArchivoGPX(gpxBase64);
            repoRuta.save(guardada);

            // Parsear GPX
            List<Trackpoint> puntos = parsearTrackpoints(bytes, guardada);

            if (guardada.getId() == null) {
                throw new ResponseStatusException(HttpStatus.INTERNAL_SERVER_ERROR, "Ruta sin ID tras guardar");
            }
            if (puntos.isEmpty()) {
                throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "GPX sin trackpoints");
            }
            for (Trackpoint tp : puntos) {
                if (tp.getId() == null || tp.getId().getIdRuta() == null || tp.getId().getPosicion() == null) {
                    throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Trackpoint con PK incompleta");
                }
                if (tp.getRuta() == null) {
                    throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Trackpoint sin ruta asignada");
                }
            }
            repoTrack.saveAll(puntos);      // Guardamos lista de trackpoints en la bd

            // -- Calcular campos autogenerados de la ruta --
            double latIn = puntos.getFirst().getLatitud();
            double lonIn = puntos.getFirst().getLongitud();
            System.out.println(latIn+"   "+lonIn);

            double latFin = puntos.getLast().getLatitud();
            double lonFin = puntos.getLast().getLongitud();
            System.out.println(latFin+"   "+lonFin);

            Duration dif = Duration.between(puntos.getFirst().getTime(), puntos.getLast().getTime());
            LocalTime duracion = LocalTime.ofSecondOfDay(dif.getSeconds());

            double distancia = 0;
            for (int i = 1; i < puntos.size(); i++) {
                Trackpoint p1 = puntos.get(i - 1);
                Trackpoint p2 = puntos.get(i);
                distancia += distanciaCoordenadas(p1.getLatitud(), p1.getLongitud(), p2.getLatitud(), p2.getLongitud());
            }

            double desNeg = 0;
            for (int i = 1; i < puntos.size(); i++) {
                double eleP1 = puntos.get(i - 1).getElevacion();
                double eleP2 = puntos.get(i).getElevacion();
                if (eleP2 < eleP1) {
                    desNeg += (eleP1 - eleP2);
                }
            }

            double desPos = 0;
            for (int i = 1; i < puntos.size(); i++) {
                double eleP1 = puntos.get(i - 1).getElevacion();
                double eleP2 = puntos.get(i).getElevacion();

                if (eleP2 > eleP1) {
                    desPos += (eleP2 - eleP1);
                }
            }

            double altMax = puntos.stream()
                    .max(Comparator.comparingDouble(Trackpoint::getElevacion))
                    .get().getElevacion();

            double altMin = puntos.stream()
                    .min(Comparator.comparingDouble(Trackpoint::getElevacion))
                    .get()
                    .getElevacion();

            // Guardar campos calculados
            guardada.setEstadoRuta((byte) 0);
            guardada.setLatitudInicial(latIn);
            guardada.setLatitudFinal(latFin);
            guardada.setLongitudInicial(lonIn);
            guardada.setLongitudFinal(lonFin);
            guardada.setDuracion(duracion);
            guardada.setDistancia(distancia);
            guardada.setDesnivelNegativo((int) desNeg);
            guardada.setDesnivelPositivo((int) desPos);
            guardada.setAltitudMin(altMin);
            guardada.setAltitudMax(altMax);

            // Devolver la ruta
            return repoRuta.save(guardada);

        } catch (Exception e) {
            e.printStackTrace();
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, "Error procesando GPX", e);
        }
    }

    private List<Trackpoint> parsearTrackpoints(byte[] gpxBytes, Ruta ruta) throws Exception {

        DocumentBuilderFactory dbf = DocumentBuilderFactory.newInstance();
        dbf.setNamespaceAware(true);
        DocumentBuilder db = dbf.newDocumentBuilder();
        Document doc = db.parse(new ByteArrayInputStream(gpxBytes));

        NodeList trkpts = doc.getElementsByTagNameNS("*", "trkpt");

        List<Trackpoint> list = new ArrayList<>(trkpts.getLength());
        int pos = 1;

        for (int i = 0; i < trkpts.getLength(); i++) {
            Element e = (Element) trkpts.item(i);

            // latitud y longitud son atributos
            String latStr = e.getAttribute("lat");
            String lonStr = e.getAttribute("lon");
            if (latStr == null || lonStr == null || latStr.isBlank() || lonStr.isBlank()) continue;

            double lat = Double.parseDouble(latStr);
            double lon = Double.parseDouble(lonStr);

            // ele y time son hijos
            String eleStr = null;
            NodeList eleNodes = e.getElementsByTagNameNS("*", "ele");
            if (eleNodes.getLength() > 0) eleStr = eleNodes.item(0).getTextContent();

            String timeStr = null;
            NodeList timeNodes = e.getElementsByTagNameNS("*", "time");
            if (timeNodes.getLength() > 0) timeStr = timeNodes.item(0).getTextContent();

            // parseo con defaults
            double elevacion = (eleStr == null || eleStr.isBlank()) ? 0.0 : Double.parseDouble(eleStr.trim());

            // GPX viene con "aaaa-MM-ddTHH:MM:SSZ"
            LocalTime time = null;
            if (timeStr != null && !timeStr.isBlank()) {
                time = java.time.OffsetDateTime.parse(timeStr.trim()).toLocalTime();
            } else {
                // tiempo por defecto
                time = LocalTime.MIDNIGHT;
            }

            TrackpointId id = new TrackpointId();
            id.setIdRuta(ruta.getId());
            id.setPosicion(pos++);

            Trackpoint tp = new Trackpoint();
            tp.setId(id);
            tp.setIdRuta(ruta);
            tp.setLatitud(lat);
            tp.setLongitud(lon);
            tp.setElevacion(elevacion);
            tp.setTime(time);

            list.add(tp);
        }
        return list;
    }


    // Calcula la distancia entre coordenadas con formula de Haversine
    public static double distanciaCoordenadas(
            double lat1, double lon1,
            double lat2, double lon2
    ) {
        int radioTierra = 6371000;
        double dLat = Math.toRadians(lat2 - lat1);
        double dLon = Math.toRadians(lon2 - lon1);

        double a = Math.sin(dLat / 2) * Math.sin(dLat / 2)
                + Math.cos(Math.toRadians(lat1))
                * Math.cos(Math.toRadians(lat2))
                * Math.sin(dLon / 2) * Math.sin(dLon / 2);

        double c = 2 * Math.atan2(Math.sqrt(a), Math.sqrt(1 - a));
        return radioTierra * c;
    }
}
