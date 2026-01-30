using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Model
{
    public class Valoracion
    {
        [JsonPropertyName("idValora")]
        public int IdValora { get; set; }

        [JsonPropertyName("dificultad")]
        public byte Dificultad { get; set; }

        [JsonPropertyName("fecha")]
        public DateTime Fecha { get; set; }

        [JsonPropertyName("estrellas")]
        public byte Estrellas { get; set; }

        [JsonPropertyName("interesCultural")]
        public bool InteresCultural { get; set; }

        [JsonPropertyName("belleza")]
        public bool Belleza { get; set; }

        [JsonPropertyName("valoracionTecnica")]
        public string ValoracionTecnica { get; set; }

        [JsonPropertyName("resena")]
        public string Resena { get; set; }

        [JsonPropertyName("usuario_idUsuario")]
        public int Usuario_idUsuario { get; set; }

        [JsonPropertyName("rutas_idRuta")]
        public int Rutas_idRuta { get; set; }

        public Valoracion() { }

        public Valoracion(int idValora, byte dificultad, DateTime fecha, byte estrellas, bool interesCultural, bool belleza, string valoracionTecnica, string resena, int usuario_idUsuario, int rutas_idRuta)
        {
            IdValora = idValora;
            Dificultad = dificultad;
            Fecha = fecha;
            Estrellas = estrellas;
            InteresCultural = interesCultural;
            Belleza = belleza;
            ValoracionTecnica = valoracionTecnica;
            Resena = resena;
            Usuario_idUsuario = usuario_idUsuario;
            Rutas_idRuta = rutas_idRuta;
        }
    }
}
