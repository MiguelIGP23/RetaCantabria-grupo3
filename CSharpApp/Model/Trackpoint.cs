using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Model
{
    public class Trackpoint
    {
        [JsonPropertyName("idRuta")]
        public TrackpointId RutaId { get; set; }

        [JsonPropertyName("latitud")]
        public double Latitud { get; set; }

        [JsonPropertyName("longitud")]
        public double Longitud { get; set; }

        public Trackpoint() { }

        public Trackpoint(TrackpointId id, double latitud, double longitud)
        {
            RutaId = id;
            Latitud = latitud;
            Longitud = longitud;
        }
    }
}
