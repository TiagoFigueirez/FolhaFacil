using projeto.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Modelo
{
    public class mdlFuncionario
    {
        public int idFuncionario { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public int matricula { get; set; }
        public string departamento { get; set; }
        public string cargo { get; set; }
        public double salarioHora { get; set; }
        public string carteiraTrabalho { get; set; }
        public string pis { get; set; }
        public DateTime dataAdmissao { get; set; }
        public int cargaHorariaSemanal { get; set; }
        public DateTime dataNascimento { get; set; }
        public bool ativo { get; set; }
        public string telefone { get; set; }
        public string endereco { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public mdlEmpresa empresa { get; set; }

        public override string ToString()
        {
            return nome;
        }
    }
}
