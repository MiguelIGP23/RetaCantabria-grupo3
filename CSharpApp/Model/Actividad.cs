using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Model
{
    public class Actividad
    {
        [JsonPropertyName("id")]
        public int IdActividad { get; set; }

        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }

        [JsonPropertyName("rutaId")]
        public int RutaId { get; set; }

        public Actividad() { }

        public Actividad(int idActividad, string nombre, int rutas_idRuta)
        {
            IdActividad = idActividad;
            Nombre = nombre;
            RutaId = rutas_idRuta;
        }
    }
}
