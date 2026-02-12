using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Model
{
    public class PuntoPeligro
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

        [JsonPropertyName("kilometros")]
        public double? Kilometros { get; set; }

        [JsonPropertyName("gravedad")]
        public int? Gravedad { get; set; }

        [JsonPropertyName("posicion")]
        public int? Posicion { get; set; }

        [JsonPropertyName("descripcion")]
        public string? Descripcion { get; set; }

        [JsonPropertyName("timestamp")]
        public int? Timestamp { get; set; }

        [JsonPropertyName("rutaId")]
        public int RutaId { get; set; }


        public PuntoPeligro() { }

        public PuntoPeligro(int idPuntoPeligro, string nombre, double latitud, double longitud, double elevacion, double kilometros, byte gravedad, int posicion, string descripcion, int timestamp, int rutas_idRuta)
        {
            Id = idPuntoPeligro;
            Nombre = nombre;
            Latitud = latitud;
            Longitud = longitud;
            Elevacion = elevacion;
            Kilometros = kilometros;
            Gravedad = gravedad;
            Posicion = posicion;
            Descripcion = descripcion;
            Timestamp = timestamp;
            RutaId = rutas_idRuta;
        }
    }
}
