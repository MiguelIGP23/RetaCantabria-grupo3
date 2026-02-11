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
        [JsonPropertyName("id")]
        public int IdValora { get; set; }

        [JsonPropertyName("dificultad")]
        public byte Dificultad { get; set; }

        [JsonPropertyName("fecha")]
        public DateTime Fecha { get; set; }

        [JsonPropertyName("estrellas")]
        public byte Estrellas { get; set; }

        [JsonPropertyName("interesCultural")]
        public int InteresCultural { get; set; }

        [JsonPropertyName("belleza")]
        public int Belleza { get; set; }

        [JsonPropertyName("valoracionTecnica")]
        public string? ValoracionTecnica { get; set; }

        [JsonPropertyName("resena")]
        public string? Resena { get; set; }

        [JsonPropertyName("usuarioId")]
        public int UsuarioId { get; set; }

        [JsonPropertyName("rutaId")]
        public int RutaId { get; set; }

        public Valoracion() { }

        public Valoracion(int idValora, byte dificultad, DateTime fecha, byte estrellas, int interesCultural, int belleza, string valoracionTecnica, string resena, int usuario_idUsuario, int rutas_idRuta)
        {
            IdValora = idValora;
            Dificultad = dificultad;
            Fecha = fecha;
            Estrellas = estrellas;
            InteresCultural = interesCultural;
            Belleza = belleza;
            ValoracionTecnica = valoracionTecnica;
            Resena = resena;
            UsuarioId = usuario_idUsuario;
            RutaId = rutas_idRuta;
        }
    }
}
