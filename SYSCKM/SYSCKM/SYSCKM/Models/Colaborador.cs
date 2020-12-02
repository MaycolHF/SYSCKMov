using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SYSCKM.Models
{
    public /*partial*/ class Colaborador
    {
        //[JsonProperty("COD_EMPRESA")]
        public int Cod_Empresa { get; set; }

        //[JsonProperty("COD_FUNCIONARIO")]
        public string Cod_Funcionario { get; set; }

        //[JsonProperty("NOME")]
        public string Nome { get; set; }
    }
    /*public partial class Colaborador
    {
        public static Colaborador[] FromJson(string json) => JsonConvert.DeserializeObject<Colaborador[]>(json, CottonKnitMovil.Models.Converter.Settings);
    }
    public static class Serialize
    {
        public static string ToJson(this Colaborador[] self) => JsonConvert.SerializeObject(self, CottonKnitMovil.Models.Converter.Settings);
    }
    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }*/
}
