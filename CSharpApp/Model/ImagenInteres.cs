using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Model
{
    public class ImagenInteres
    {
        [JsonPropertyName("idimagenesinteres")]
        public int Idimagenesinteres { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("descripcion")]
        public string? Descripcion { get; set; }

        [JsonPropertyName("puntosInteresId")]
        public int PuntosInteresId { get; set; }

        [JsonPropertyName("rutaId")]
        public int RutaId { get; set; }


        public ImagenInteres() { }

        public ImagenInteres(int idimagenesinteres, string url, string descripcion, int puntosInteresId, int rutaId)
        {
            Idimagenesinteres = idimagenesinteres;
            Url = url;
            Descripcion = descripcion;
            PuntosInteresId = puntosInteresId;
            RutaId = rutaId;
        }
    }
}
