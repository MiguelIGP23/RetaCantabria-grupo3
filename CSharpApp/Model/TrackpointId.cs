using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Model
{
    public class TrackpointId
    {
        [JsonPropertyName("idRuta")]
        public int IdRuta { get; set; }

        [JsonPropertyName("posicion")]
        public int Posicion { get; set; }

        public TrackpointId() { }

        public TrackpointId(int idRuta, int posicion)
        {
            IdRuta = idRuta;
            Posicion = posicion;
        }
    }
}
