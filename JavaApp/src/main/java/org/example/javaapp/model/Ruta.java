package org.example.javaapp.model;

import jakarta.persistence.*;
import org.hibernate.annotations.ColumnDefault;

import java.time.LocalTime;

@Entity
@Table(name = "rutas", schema = "retadb")
public class Ruta {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "idRuta", nullable = false)
    private Integer id;

    @Column(name = "nombre", nullable = false, length = 20)
    private String nombre;

    @Column(name = "nombre_inicioruta", nullable = false, length = 45)
    private String nombreInicioruta;

    @Column(name = "nombre_finalruta", nullable = false, length = 45)
    private String nombreFinalruta;

    @Column(name = "latitudInicial", nullable = false)
    private Double latitudInicial;

    @Column(name = "latitudFinal", nullable = false)
    private Double latitudFinal;

    @Column(name = "longitudInicial", nullable = false)
    private Double longitudInicial;

    @Column(name = "longitudFinal", nullable = false)
    private Double longitudFinal;

    @Column(name = "distancia", nullable = false)
    private Double distancia;

    @Column(name = "duracion", nullable = false)
    private LocalTime duracion;

    @Column(name = "desnivelPositivo")
    private Integer desnivelPositivo;

    @Column(name = "desnivelNegativo")
    private Integer desnivelNegativo;

    @Column(name = "altitudMax")
    private Double altitudMax;

    @Column(name = "altitudMin")
    private Double altitudMin;

    @ColumnDefault("'LINEAL'")
    @Lob
    @Column(name = "clasificacion")
    private String clasificacion;

    @Column(name = "nivelEsfuerzo")
    private Byte nivelEsfuerzo;

    @Column(name = "nivelRiesgo")
    private Byte nivelRiesgo;

    @ColumnDefault("0")
    @Column(name = "estadoRuta")
    private Byte estadoRuta;

    @Column(name = "tipoTerreno")
    private Byte tipoTerreno;

    @Column(name = "indicaciones")
    private Byte indicaciones;

    @Lob
    @Column(name = "temporadas")
    private String temporadas;

    @Column(name = "accesibilidad")
    private Byte accesibilidad;

    @Column(name = "rutaFamiliar")
    private Byte rutaFamiliar;

    @Lob
    @Column(name = "archivoGPX")
    private String archivoGPX;

    @Lob
    @Column(name = "recomendacionesEquipo")
    private String recomendacionesEquipo;

    @Column(name = "zonaGeografica", length = 45)
    private String zonaGeografica;

    @Column(name = "mediaEstrellas")
    private Double mediaEstrellas;

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getNombreInicioruta() {
        return nombreInicioruta;
    }

    public void setNombreInicioruta(String nombreInicioruta) {
        this.nombreInicioruta = nombreInicioruta;
    }

    public String getNombreFinalruta() {
        return nombreFinalruta;
    }

    public void setNombreFinalruta(String nombreFinalruta) {
        this.nombreFinalruta = nombreFinalruta;
    }

    public Double getLatitudInicial() {
        return latitudInicial;
    }

    public void setLatitudInicial(Double latitudInicial) {
        this.latitudInicial = latitudInicial;
    }

    public Double getLatitudFinal() {
        return latitudFinal;
    }

    public void setLatitudFinal(Double latitudFinal) {
        this.latitudFinal = latitudFinal;
    }

    public Double getLongitudInicial() {
        return longitudInicial;
    }

    public void setLongitudInicial(Double longitudInicial) {
        this.longitudInicial = longitudInicial;
    }

    public Double getLongitudFinal() {
        return longitudFinal;
    }

    public void setLongitudFinal(Double longitudFinal) {
        this.longitudFinal = longitudFinal;
    }

    public Double getDistancia() {
        return distancia;
    }

    public void setDistancia(Double distancia) {
        this.distancia = distancia;
    }

    public LocalTime getDuracion() {
        return duracion;
    }

    public void setDuracion(LocalTime duracion) {
        this.duracion = duracion;
    }

    public Integer getDesnivelPositivo() {
        return desnivelPositivo;
    }

    public void setDesnivelPositivo(Integer desnivelPositivo) {
        this.desnivelPositivo = desnivelPositivo;
    }

    public Integer getDesnivelNegativo() {
        return desnivelNegativo;
    }

    public void setDesnivelNegativo(Integer desnivelNegativo) {
        this.desnivelNegativo = desnivelNegativo;
    }

    public Double getAltitudMax() {
        return altitudMax;
    }

    public void setAltitudMax(Double altitudMax) {
        this.altitudMax = altitudMax;
    }

    public Double getAltitudMin() {
        return altitudMin;
    }

    public void setAltitudMin(Double altitudMin) {
        this.altitudMin = altitudMin;
    }

    public String getClasificacion() {
        return clasificacion;
    }

    public void setClasificacion(String clasificacion) {
        this.clasificacion = clasificacion;
    }

    public Byte getNivelEsfuerzo() {
        return nivelEsfuerzo;
    }

    public void setNivelEsfuerzo(Byte nivelEsfuerzo) {
        this.nivelEsfuerzo = nivelEsfuerzo;
    }

    public Byte getNivelRiesgo() {
        return nivelRiesgo;
    }

    public void setNivelRiesgo(Byte nivelRiesgo) {
        this.nivelRiesgo = nivelRiesgo;
    }

    public Byte getEstadoRuta() {
        return estadoRuta;
    }

    public void setEstadoRuta(Byte estadoRuta) {
        this.estadoRuta = estadoRuta;
    }

    public Byte getTipoTerreno() {
        return tipoTerreno;
    }

    public void setTipoTerreno(Byte tipoTerreno) {
        this.tipoTerreno = tipoTerreno;
    }

    public Byte getIndicaciones() {
        return indicaciones;
    }

    public void setIndicaciones(Byte indicaciones) {
        this.indicaciones = indicaciones;
    }

    public String getTemporadas() {
        return temporadas;
    }

    public void setTemporadas(String temporadas) {
        this.temporadas = temporadas;
    }

    public Byte getAccesibilidad() {
        return accesibilidad;
    }

    public void setAccesibilidad(Byte accesibilidad) {
        this.accesibilidad = accesibilidad;
    }

    public Byte getRutaFamiliar() {
        return rutaFamiliar;
    }

    public void setRutaFamiliar(Byte rutaFamiliar) {
        this.rutaFamiliar = rutaFamiliar;
    }

    public String getArchivoGPX() {
        return archivoGPX;
    }

    public void setArchivoGPX(String archivoGPX) {
        this.archivoGPX = archivoGPX;
    }

    public String getRecomendacionesEquipo() {
        return recomendacionesEquipo;
    }

    public void setRecomendacionesEquipo(String recomendacionesEquipo) {
        this.recomendacionesEquipo = recomendacionesEquipo;
    }

    public String getZonaGeografica() {
        return zonaGeografica;
    }

    public void setZonaGeografica(String zonaGeografica) {
        this.zonaGeografica = zonaGeografica;
    }

    public Double getMediaEstrellas() {
        return mediaEstrellas;
    }

    public void setMediaEstrellas(Double mediaEstrellas) {
        this.mediaEstrellas = mediaEstrellas;
    }

}