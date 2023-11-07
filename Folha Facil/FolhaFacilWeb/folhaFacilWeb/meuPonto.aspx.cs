using classesDeControle;
using Projeto.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace folhaFacilWeb
{
    public partial class meuPonto : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            GvPonto.DataSource =  ctlPonto.carregarTabelaPonto(login.funcionarioAcessado);
            GvPonto.DataBind();
        }

        protected void btnInluirPonto(object sender, EventArgs e)
        {
            mdlFuncionario _mdlFuncinario = login.funcionarioAcessado;
            ctlPonto.incluirPonto(_mdlFuncinario);

            Response.Redirect(Request.RawUrl);
        }


    }
}