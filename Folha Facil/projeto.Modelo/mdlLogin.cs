using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Modelo
{
    public class mdlLogin
    {
        public int idLogin { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public bool administrador { get; set; }

        public override string ToString()
        {
            return usuario;
        }
    }
}
