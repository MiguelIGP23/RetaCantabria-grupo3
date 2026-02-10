using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Dto
{
    public class DtoTrackPoint
    {
        [JsonPropertyName("idRuta")]
        public int IdRuta { get; set; }

        [JsonPropertyName("posicion")]
        public int Posicion { get; set; }

        [JsonPropertyName("latitud")]
        public double Latitud { get; set; }

        [JsonPropertyName("longitud")]
        public double Longitud { get; set; }

        [JsonPropertyName("elevacion")]
        public double? Elevacion { get; set; }

        [JsonPropertyName("time")]
        public TimeSpan? Time { get; set; }
    }
}
