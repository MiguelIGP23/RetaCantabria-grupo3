package org.example.javaapp.service;

import org.example.javaapp.model.Ruta;
import org.example.javaapp.model.Valoracion;
import org.example.javaapp.repository.RutaRepository;
import org.example.javaapp.repository.ValoracionRepository;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class ServiceValoracion implements IServiceValoracion{

    private final ValoracionRepository repoValoracion;
    private final RutaRepository repoRuta;

    public ServiceValoracion(ValoracionRepository repoValoracion, RutaRepository repoRuta){this.repoValoracion = repoValoracion;
        this.repoRuta = repoRuta;
    }


    //CRUD genérico

    @Override
    public Valoracion insert(Valoracion valoracion) {
        return repoValoracion.save(valoracion);
    }

    @Override
    public Valoracion update(Integer id, Valoracion valoracion) {
        Valoracion aModificar = repoValoracion.findById(id).orElse(null);
        if (aModificar != null) {
            aModificar.setBelleza(valoracion.getBelleza());
            aModificar.setDificultad(valoracion.getDificultad());
            aModificar.setEstrellas(valoracion.getEstrellas());
            aModificar.setFecha(valoracion.getFecha());
            aModificar.setResena(valoracion.getResena());
            aModificar.setInteresCultural(valoracion.getInteresCultural());
            aModificar.setRuta(valoracion.getRuta());
            aModificar.setUsuario(valoracion.getUsuario());
            aModificar.setValoracionTecnica(valoracion.getValoracionTecnica());
            repoValoracion.save(valoracion);
        }
        return aModificar;
    }

    @Override
    public void delete(Integer id) {
        repoValoracion.deleteById(id);
    }

    @Override
    public Valoracion findById(Integer id) {
        return repoValoracion.findById(id).orElse(null);
    }

    @Override
    public List<Valoracion> findAll(){
        return repoValoracion.findAll();
    }



    //CRUD dependiente de ruta

    public Valoracion insertInRuta(int idRuta, Valoracion valoracion){
        Ruta ruta = repoRuta.findById(idRuta).orElse(null);
        if(ruta==null) return null;
        valoracion.setRuta(ruta);
        return repoValoracion.save(valoracion);
    }

    public Valoracion updateInRuta(int idValoracion, int idRuta, Valoracion valoracion) {
        Optional<Valoracion> opt = repoValoracion.findByIdAndRuta_Id(idValoracion, idRuta);
        if (opt.isEmpty()) return null;
        Valoracion buscada = opt.get();
        buscada.setDificultad(valoracion.getDificultad());
        buscada.setFecha(valoracion.getFecha());
        buscada.setEstrellas(valoracion.getEstrellas());
        buscada.setInteresCultural(valoracion.getInteresCultural());
        buscada.setBelleza(valoracion.getBelleza());
        buscada.setValoracionTecnica(valoracion.getValoracionTecnica());
        buscada.setResena(valoracion.getResena());
        return repoValoracion.save(buscada);
    }

    public void deleteFromRuta(int idValoracion, int idRuta) {
        repoValoracion.deleteByIdAndRuta_Id(idValoracion, idRuta);
    }

    public List<Valoracion> findAllByRuta(int idRuta) {
        return repoValoracion.findByRuta_Id(idRuta);
    }

    public Optional<Valoracion> findByRutaAndId(int idValoracion, int idRuta) {
        return repoValoracion.findByIdAndRuta_Id(idValoracion, idRuta);
    }
}
