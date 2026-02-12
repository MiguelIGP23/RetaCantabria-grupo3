package org.example.javaapp.utils;

import org.example.javaapp.model.Ruta;
import org.example.javaapp.repository.RutaRepository;
import org.springframework.scheduling.annotation.Scheduled;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.List;

@Service
public class MantenimientoBD {
    private final RutaRepository repoRuta;

    public MantenimientoBD(RutaRepository repoRuta) {
        this.repoRuta = repoRuta;
    }

    @Transactional
    @Scheduled(cron = "0 0 3 ? * SUN")
    public void eliminarBorradoresAntiguos() {
        List<Ruta> borradores = repoRuta.findByEstadoRuta((byte) 2);
        repoRuta.deleteAll(borradores);
        System.out.println("Borradores eliminados: " + borradores.size());
    }
}
