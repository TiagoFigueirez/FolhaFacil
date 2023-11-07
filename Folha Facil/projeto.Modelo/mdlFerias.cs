using Projeto.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.Modelo
{
    public class mdlFerias
    {
        public int idFerias { get; set; }
        public DateTime periodoDataVencimento { get; set; }
        public DateTime periodoInicio { get; set; }
        public DateTime periodoFim { get; set; }
        public bool vencido { get; set; }
        public int idFuncionario { get; set; }
    }
}
