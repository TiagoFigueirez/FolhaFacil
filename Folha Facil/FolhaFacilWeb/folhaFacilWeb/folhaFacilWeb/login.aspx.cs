using classesDeControle;
using Projeto.Modelo;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace folhaFacilWeb
{
    public partial class login : System.Web.UI.Page
    {

        public static mdlFuncionario funcionarioAcessado = new mdlFuncionario();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin(object sender, EventArgs e)
        {
            mdlFuncionario _mdlFuncionario = new mdlFuncionario();

            _mdlFuncionario.email = txtUsuario.Text;
            _mdlFuncionario.senha = txtSenha.Text;

            if (ctlFuncionario.verificarLoginFuncionario(_mdlFuncionario, out funcionarioAcessado))
            {
                //inserir cookies
                HttpCookie login = new HttpCookie("login", txtUsuario.Text);
                Response.Cookies.Add(login);
                Response.Redirect("~/index.aspx");

            }
            else
            {
                lblMensagemErro.Visible = true;
                lblMensagemErro.Text = "Usuario ou senha icorretos !";
            }

            
        }
    }
}