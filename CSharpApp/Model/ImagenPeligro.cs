using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Model
{
    public class ImagenPeligro
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("descripcion")]
        public string? Descripcion { get; set; }

        [JsonPropertyName("puntosPeligroId")]
        public int PuntosPeligroId { get; set; }

        [JsonPropertyName("rutaId")]
        public int RutaId { get; set; }



        public ImagenPeligro() { }

        public ImagenPeligro(int idimagenes_peligro, string url, string descripcion, int puntosPeligroId, int rutaId)
        {
            Id = idimagenes_peligro;
            Url = url;
            Descripcion = descripcion;
            PuntosPeligroId = puntosPeligroId;
            RutaId = rutaId;
        }
    }
}
