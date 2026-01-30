package org.example.javaapp.service;

import java.util.List;

public interface IService<T, ID>{

    T insert(T t);
    T update(ID id, T t);
    void delete(ID id);
    T findById(ID id);
    List<T> findAll();
}
