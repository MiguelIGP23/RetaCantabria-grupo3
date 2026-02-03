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
        [JsonPropertyName("idimagenes_peligro")]
        public int Idimagenes_peligro { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("descripcion")]
        public string? Descripcion { get; set; }

        [JsonPropertyName("puntospeligro_idPuntosinteres")]
        public int Puntospeligro_idPuntosinteres { get; set; }

        // Constructor por defecto (one-line)
        public ImagenPeligro() { }

        // Constructor completo (firma one-line)
        public ImagenPeligro(int idimagenes_peligro, string url, string descripcion, int puntospeligro_idPuntosinteres)
        {
            Idimagenes_peligro = idimagenes_peligro;
            Url = url;
            Descripcion = descripcion;
            Puntospeligro_idPuntosinteres = puntospeligro_idPuntosinteres;
        }
    }
}
