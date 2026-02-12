using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Model
{
    public class Calendario
    {

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("fecha")]
        public DateOnly Fecha { get; set; }

        [JsonPropertyName("hora_inicio")]
        public TimeSpan HoraInicio { get; set; }

        [JsonPropertyName("info")]
        public string Info { get; set; }

        [JsonPropertyName("rutaId")]
        public int RutaId { get; set; }

        [JsonPropertyName("usuarioId")]
        public int UsuarioId { get; set; }


        public Calendario() { }

        public Calendario(int id, DateOnly fecha, TimeSpan hora, string info, int rutaId, int usuarioId)
        {
            Id = id;
            Fecha = fecha;
            HoraInicio = hora;
            Info = info;
            RutaId = rutaId;
            UsuarioId = usuarioId;
        }
    }
}
