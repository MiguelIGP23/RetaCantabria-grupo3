using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Model
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EnumTiposPuntoInteres
    {
        HISTORICO, MIRADOR, AREA_DE_DESCANSO, PUNTO_DE_AGUA, ALOJAMIENTO, CULTURAL, GEOLOGICO, FAUNA, BOTANICO

    }
}
