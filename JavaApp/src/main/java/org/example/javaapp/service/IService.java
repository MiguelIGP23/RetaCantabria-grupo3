package org.example.javaapp.service;

import java.util.List;

public interface IService<T, Integer>{

    T insert(T t);
    T update(int id, T t);
    void delete(int id);
    T findById(int id);
    List<T> findAll();
}
