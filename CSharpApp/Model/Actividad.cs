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
        [JsonPropertyName("idActividad")]
        public int IdActividad { get; set; }

        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }

        [JsonPropertyName("rutas_idRuta")]
        public int Rutas_idRuta { get; set; }

        public Actividad() { }

        public Actividad(int idActividad, string nombre, int rutas_idRuta)
        {
            IdActividad = idActividad;
            Nombre = nombre;
            Rutas_idRuta = rutas_idRuta;
        }
    }
}
