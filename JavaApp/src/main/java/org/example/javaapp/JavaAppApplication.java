package org.example.javaapp;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;

@SpringBootApplication
public class JavaAppApplication {

    public static void main(String[] args) {
        SpringApplication.run(JavaAppApplication.class, args);

        // Metodo para ver el hash resultante al cifrar con BCrypt
        System.out.println(new BCryptPasswordEncoder().encode("1234"));

    }

}
