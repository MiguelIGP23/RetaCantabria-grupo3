package org.example.javaapp.service;

import org.example.javaapp.model.Ruta;
import org.example.javaapp.model.Usuario;
import org.example.javaapp.model.Valoracion;
import org.example.javaapp.repository.RutaRepository;
import org.example.javaapp.repository.UsuarioRepository;
import org.example.javaapp.repository.ValoracionRepository;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.List;
import java.util.Optional;

@Service
public class ServiceValoracion implements IServiceValoracion {

    private final ValoracionRepository repoValoracion;
    private final RutaRepository repoRuta;
    private final UsuarioRepository repoUsuario;

    public ServiceValoracion(ValoracionRepository repoValoracion, RutaRepository repoRuta, UsuarioRepository repoUsuario) {
        this.repoValoracion = repoValoracion;
        this.repoRuta = repoRuta;
        this.repoUsuario = repoUsuario;
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
    public List<Valoracion> findAll() {
        return repoValoracion.findAll();
    }


    //CRUD dependiente de ruta

    public Valoracion insertInRuta(int idRuta, Valoracion valoracion) {
        Ruta ruta = repoRuta.findById(idRuta).orElse(null);
        if (ruta == null) return null;

        Usuario usuario = valoracion.getUsuario();
        if (usuario == null || usuario.getId() == null) return null;

        Usuario nuevo = repoUsuario.findById(usuario.getId()).orElse(null);
        if (nuevo == null) return null;

        valoracion.setId(null);
        valoracion.setRuta(ruta);
        valoracion.setUsuario(nuevo);

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

        if (valoracion.getUsuario() != null && valoracion.getUsuario().getId() != null) {
            Usuario usuPersist = repoUsuario.findById(valoracion.getUsuario().getId()).orElse(null);
            if (usuPersist == null) return null;
            buscada.setUsuario(usuPersist);
        }
        return repoValoracion.save(buscada);
    }

    @Transactional
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
