using classesDeControle;
using Projeto.Modelo;
using Projeto_Controle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoRH.Usuarios
{
    public partial class frmDeletarLogin : Form
    {

        private mdlLogin _mdlLogin = new mdlLogin();

        public frmDeletarLogin(mdlLogin _mdlLogin)
        {
            InitializeComponent();
            this._mdlLogin = _mdlLogin;
        }

        private void frmDeletarLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = _mdlLogin.usuario;
            txtSenha.Text = _mdlLogin.senha;
            txtConfirmarSenha.Text = _mdlLogin.senha;
            cbNivel.Text = (_mdlLogin.administrador) ? "Administrador" : "Comum";
            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;
            cbNivel.Enabled = false;
            txtConfirmarSenha.Enabled = false;
        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            if(ctlLogin.ExcluirUsuario(_mdlLogin))
            {
                this.Close();
            }
        }

    }


    
}
