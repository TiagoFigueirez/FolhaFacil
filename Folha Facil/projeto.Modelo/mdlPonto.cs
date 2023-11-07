using projeto.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Modelo
{
    public class mdlPonto
    {
        public DateTime data { get; set; }
        public DateTime entrada { get; set; }
        public DateTime ida { get; set; }
        public DateTime volta { get; set; }
        public DateTime saida { get; set; }
        public double horasTrabalhadas { get; set; }
    }
}
