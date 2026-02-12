package org.example.javaapp.service;

import org.example.javaapp.model.Calendario;
import org.example.javaapp.repository.CalendarioRepository;
import org.springframework.stereotype.Service;

import java.time.LocalDate;
import java.time.YearMonth;
import java.util.List;
import java.util.Optional;

@Service
public class ServiceCalendario implements IServiceCalendario{
    private final CalendarioRepository calendarioRepo;

    public ServiceCalendario(CalendarioRepository calendarioRepo) {
        this.calendarioRepo = calendarioRepo;
    }

    // CRUD genérico

    @Override
    public Calendario insert(Calendario calendario) {
        calendario.setId(null);
        return calendarioRepo.save(calendario);
    }

    @Override
    public Calendario update(Integer id, Calendario nuevo) {
        Calendario buscado = findById(id);
        if(buscado!=null){
            buscado.setFecha(nuevo.getFecha());
            buscado.setInfo(nuevo.getInfo());
            calendarioRepo.save(buscado);
        }
        return buscado;
    }

    @Override
    public void delete(Integer id) {
        calendarioRepo.deleteById(id);
    }

    @Override
    public Calendario findById(Integer id) {
        return calendarioRepo.findById(id).orElse(null);
    }

    @Override
    public List<Calendario> findAll() {
        return calendarioRepo.findAll();
    }

    // CRUD específico de calendario
    public List<Calendario> findByFecha(LocalDate fecha) {
        return calendarioRepo.findAllByFecha(fecha);
    }

    public Optional<Calendario> updateCalendario(Integer id, Calendario c) {
        if (!calendarioRepo.existsById(id)) return Optional.empty();
        c.setId(id);
        return Optional.of(calendarioRepo.save(c));
    }

    public List<LocalDate> diasConRutasEnMes(YearMonth mes) {
        LocalDate inicio = mes.atDay(1);
        LocalDate fin = mes.plusMonths(1).atDay(1);
        return calendarioRepo.findDistinctFechasMes(inicio, fin);
    }

}
