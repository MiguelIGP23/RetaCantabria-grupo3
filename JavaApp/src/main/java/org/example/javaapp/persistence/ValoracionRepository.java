package org.example.javaapp.persistence;

import org.example.javaapp.model.Valora;
import org.springframework.data.jpa.repository.JpaRepository;

public interface ValoracionRepository extends JpaRepository<Valora, Integer> {}
