using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public static class RutaFiltering
    {
        public static Func<Ruta, bool> BuildPredicate(RutaFilter f)
        {
            return r =>
        // Nombre
        (string.IsNullOrWhiteSpace(f.Nombre) ||
            (!string.IsNullOrWhiteSpace(r.Nombre) &&
             r.Nombre.Contains(f.Nombre, StringComparison.OrdinalIgnoreCase))) &&

        // Puntuación
        (!f.PuntuacionMin.HasValue || (r.MediaEstrellas.HasValue && r.MediaEstrellas.Value >= f.PuntuacionMin.Value)) &&
        (!f.PuntuacionMax.HasValue || (r.MediaEstrellas.HasValue && r.MediaEstrellas.Value <= f.PuntuacionMax.Value)) &&

        // Distancia
        (!f.DistanciaMin.HasValue || r.Distancia >= f.DistanciaMin.Value) &&
        (!f.DistanciaMax.HasValue || r.Distancia <= f.DistanciaMax.Value) &&

        // Duración
        (!f.DuracionMin.HasValue || r.Duracion >= f.DuracionMin.Value) &&
        (!f.DuracionMax.HasValue || r.Duracion <= f.DuracionMax.Value) &&

        // Clasificación (enum)
        (!f.Clasificaciones.HasValue || (r.Clasificacion.HasValue && r.Clasificacion.Value == f.Clasificaciones.Value)) &&

        // Nivel esfuerzo (int?)
        (!f.EsfuerzoMin.HasValue || (r.NivelEsfuerzo.HasValue && r.NivelEsfuerzo.Value >= f.EsfuerzoMin.Value)) &&
        (!f.EsfuerzoMax.HasValue || (r.NivelEsfuerzo.HasValue && r.NivelEsfuerzo.Value <= f.EsfuerzoMax.Value)) &&

        // Nivel riesgo (int?)
        (!f.RiesgoMin.HasValue || (r.NivelRiesgo.HasValue && r.NivelRiesgo.Value >= f.RiesgoMin.Value)) &&
        (!f.RiesgoMax.HasValue || (r.NivelRiesgo.HasValue && r.NivelRiesgo.Value <= f.RiesgoMax.Value)) &&

        // Temporadas (string en Ruta.Temporadas)
        (string.IsNullOrWhiteSpace(f.Temporada) ||
            (!string.IsNullOrWhiteSpace(r.Temporadas) &&
             r.Temporadas.Contains(f.Temporada, StringComparison.OrdinalIgnoreCase))) &&

        // Accesible (en Ruta es Accesibilidad int? -> lo tratamos como booleano: !=0)
        (!f.Accesible.HasValue ||
            (r.Accesibilidad.HasValue && ((r.Accesibilidad.Value != 0) == f.Accesible.Value))) &&

        // Familiar (en Ruta es RutaFamiliar int? -> booleano: !=0)
        (!f.Familiar.HasValue ||
            (r.RutaFamiliar.HasValue && ((r.RutaFamiliar.Value != 0) == f.Familiar.Value)));
        }
    }
}
