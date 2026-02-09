using System;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Model
{
    public class Ruta
    {
        [JsonPropertyName("id")]
        public int IdRuta { get; set; }

        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }

        [JsonPropertyName("nombreInicioruta")]
        public string Nombre_inicioruta { get; set; }

        [JsonPropertyName("nombreFinalruta")]
        public string Nombre_finalruta { get; set; }

        [JsonPropertyName("latitudInicial")]
        public double LatitudInicial { get; set; }

        [JsonPropertyName("latitudFinal")]
        public double LatitudFinal { get; set; }

        [JsonPropertyName("longitudInicial")]
        public double LongitudInicial { get; set; }

        [JsonPropertyName("longitudFinal")]
        public double LongitudFinal { get; set; }

        [JsonPropertyName("distancia")]
        public double Distancia { get; set; }

        [JsonPropertyName("duracion")]
        public TimeSpan Duracion { get; set; }

        [JsonPropertyName("desnivelPositivo")]
        public int? DesnivelPositivo { get; set; }

        [JsonPropertyName("desnivelNegativo")]
        public int? DesnivelNegativo { get; set; }

        [JsonPropertyName("altitudMax")]
        public double? AltitudMax { get; set; }

        [JsonPropertyName("altitudMin")]
        public double? AltitudMin { get; set; }

        [JsonPropertyName("clasificacion")]
        public EnumClasificaciones? Clasificacion { get; set; }

        [JsonPropertyName("nivelEsfuerzo")]
        public int? NivelEsfuerzo { get; set; }

        [JsonPropertyName("nivelRiesgo")]
        public int? NivelRiesgo { get; set; }

        [JsonPropertyName("estadoRuta")]
        public int? EstadoRuta { get; set; }

        [JsonPropertyName("tipoTerreno")]
        public int? TipoTerreno { get; set; }

        [JsonPropertyName("indicaciones")]
        public int? Indicaciones { get; set; }

        [JsonPropertyName("temporadas")]
        public string? Temporadas { get; set; }

        [JsonPropertyName("accesibilidad")]
        public int? Accesibilidad { get; set; }

        [JsonPropertyName("rutaFamiliar")]
        public int? RutaFamiliar { get; set; }

        [JsonPropertyName("archivoGPX")]
        public string? ArchivoGPX { get; set; }

        [JsonPropertyName("recomendacionesEquipo")]
        public string? RecomendacionesEquipo { get; set; }

        [JsonPropertyName("zonaGeografica")]
        public string? ZonaGeografica { get; set; }

        [JsonPropertyName("mediaEstrellas")]
        public double? MediaEstrellas { get; set; }

        [JsonPropertyName("usuarioId")]
        public int UsuarioId { get; set; }


        public Ruta() { 

        }

        public Ruta(int idRuta, string nombre, string nombre_inicioruta, string nombre_finalruta, double latitudInicial, double latitudFinal, double longitudInicial, double longitudFinal, double distancia, TimeSpan duracion, int desnivelPositivo, int desnivelNegativo, double altitudMax, double altitudMin, EnumClasificaciones clasificacion, int estadoRuta, int tipoTerreno, int indicaciones, string temporadas, int accesibilidad, int rutaFamiliar, string archivoGPX, string recomendacionesEquipo, string zonaGeografica, int usuario_idUsuario)
        {
            IdRuta = idRuta;
            Nombre = nombre;
            Nombre_inicioruta = nombre_inicioruta;
            Nombre_finalruta = nombre_finalruta;
            LatitudInicial = latitudInicial;
            LatitudFinal = latitudFinal;
            LongitudInicial = longitudInicial;
            LongitudFinal = longitudFinal;
            Distancia = distancia;
            Duracion = duracion;
            DesnivelPositivo = desnivelPositivo;
            DesnivelNegativo = desnivelNegativo;
            AltitudMax = altitudMax;
            AltitudMin = altitudMin;
            Clasificacion = clasificacion;
            EstadoRuta = estadoRuta;
            TipoTerreno = tipoTerreno;
            Indicaciones = indicaciones;
            Temporadas = temporadas;
            Accesibilidad = accesibilidad;
            RutaFamiliar = rutaFamiliar;
            ArchivoGPX = archivoGPX;
            RecomendacionesEquipo = recomendacionesEquipo;
            ZonaGeografica = zonaGeografica;
            UsuarioId = usuario_idUsuario;
        }
    }
}
