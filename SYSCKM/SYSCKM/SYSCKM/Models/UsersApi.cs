using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SYSCKM.Models
{
    public class UsersApi
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        //[JsonProperty("APELLIDO 1")]
        public string Apellido_1 { get; set; }
        //[JsonProperty("APELLIDO 2")]
        public string Apellido_2 { get; set; }
        public string Usuario { get; set; }
        public string clave { get; set; }
    }
}
