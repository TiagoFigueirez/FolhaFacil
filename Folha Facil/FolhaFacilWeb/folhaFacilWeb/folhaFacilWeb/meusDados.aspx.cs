using classesDeControle;
using projeto.Modelo;
using Projeto.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace folhaFacilWeb
{
    public partial class meusDados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mdlFerias _mdlFerias = new mdlFerias();

            lblNome.Text = login.funcionarioAcessado.nome;
            
           _mdlFerias =  ctlFerias.PuxarFerias(login.funcionarioAcessado);

            if(_mdlFerias.periodoInicio.ToString("dd-MM-yyyy") == "01-01-0001" && _mdlFerias.periodoFim.ToString("dd-MM-yyyy") == "01-01-0001")
            {
                lblPeriodoFerias.Text = " Não possui ferias atribuidas";
            }
            else
            {
                lblPeriodoFerias.Text = $"{_mdlFerias.periodoInicio.ToString("dd-MM-yyyy")} a {_mdlFerias.periodoFim.ToString("dd-MM-yyyy")}";

            }


            if (_mdlFerias.vencido)
            {
                lblStatusFerias.Text = "Vencido";
            }
            else
            {
                lblStatusFerias.Text = "A vencer";
            }
            
        }
    }
}