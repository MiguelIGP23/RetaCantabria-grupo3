using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Model
{
    public class PuntoInteres
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }

        [JsonPropertyName("latitud")]
        public double Latitud { get; set; }

        [JsonPropertyName("longitud")]
        public double Longitud { get; set; }

        [JsonPropertyName("elevacion")]
        public double Elevacion { get; set; }

        [JsonPropertyName("caracteristicas")]
        public string? Caracteristicas { get; set; }

        [JsonPropertyName("tipo")]
        public EnumTiposPuntoInteres? Tipo { get; set; }

        [JsonPropertyName("descripcion")]
        public string? Descripcion { get; set; }

        [JsonPropertyName("timestamp")]
        public int? Timestamp { get; set; }

        [JsonPropertyName("rutaId")]
        public int RutaId { get; set; }

        public PuntoInteres() { }

        public PuntoInteres(int idPuntosinteres, string nombre, double latitud, double longitud, double elevacion, string caracteristicas, EnumTiposPuntoInteres tipo, string descripcion, int timestamp, int rutas_idRuta)
        {
            Id = idPuntosinteres;
            Nombre = nombre;
            Latitud = latitud;
            Longitud = longitud;
            Elevacion = elevacion;
            Caracteristicas = caracteristicas;
            Tipo = tipo;
            Descripcion = descripcion;
            Timestamp = timestamp;
            RutaId = rutas_idRuta;
        }
    }
}
