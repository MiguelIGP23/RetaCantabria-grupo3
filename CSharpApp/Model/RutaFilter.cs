using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class RutaFilter
    {
        public string? Nombre { get; set; }
        public int? PuntuacionMin { get; set; }
        public int? PuntuacionMax { get; set; }
        public double? DistanciaMin { get; set; }
        public double? DistanciaMax { get; set; }
        public TimeSpan? DuracionMin { get; set; }
        public TimeSpan? DuracionMax { get; set; }
        public EnumClasificaciones? Clasificaciones { get; set; }
        public int? EsfuerzoMin { get; set; }
        public int? EsfuerzoMax { get; set; }
        public int? RiesgoMin { get; set; }
        public int? RiesgoMax { get; set; }
        public string? Temporada {  get; set; }
        public bool? Accesible { get; set; }
        public bool? Familiar {  get; set; }

    }
}
