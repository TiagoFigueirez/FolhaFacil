using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.Modelo
{
    public class mdlEmpresa
    {
        public int idEmpresa { get; set; }
        public string nome { get; set; }
        public string cnpj { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string endereco { get; set; }

        public override string ToString()
        {
            return this.nome;
        }
    }
}
