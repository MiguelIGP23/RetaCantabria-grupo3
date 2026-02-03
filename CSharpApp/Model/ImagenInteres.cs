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

        [JsonPropertyName("puntosinteres_idPuntosinteres")]
        public int Puntosinteres_idPuntosinteres { get; set; }

        public ImagenInteres() { }

        public ImagenInteres(int idimagenesinteres, string url, string descripcion, int puntosinteres_idPuntosinteres)
        {
            Idimagenesinteres = idimagenesinteres;
            Url = url;
            Descripcion = descripcion;
            Puntosinteres_idPuntosinteres = puntosinteres_idPuntosinteres;
        }
    }
}
