using System;
using System.Collections.Generic;
using System.Text;

namespace SYSCKM.Models
{
    public class Stikers
    {
        public string ordem_producao { get; set; }
        public string ordem_confeccao { get; set; }
        public string fecha { get; set; }

        public string seq_operacao { get; set; }
        public string codigo_operacao { get; set; }
        public string des_oper { get; set; }
        public string minutos_utilitario { get; set; }
        public string pecas_hora { get; set; }
        public string codigo_operador { get; set; }
        public string ntrab { get; set; }
        public string data_baixa { get; set; }
        public string situacao { get; set; }

    }
}
