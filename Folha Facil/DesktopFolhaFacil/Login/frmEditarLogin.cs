using Projeto.Modelo;
using Projeto_Controle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoRH.Login
{
    public partial class frmEditarLogin : Form
    {

        private mdlLogin _mdlLogin = new mdlLogin();
        private string nomeAtual = "";

        public frmEditarLogin(mdlLogin _mdlLogin)
        {
            InitializeComponent();
            this._mdlLogin = _mdlLogin;
            this.nomeAtual = _mdlLogin.usuario;
        }

        private void frmEditarLogin_Load(object sender, EventArgs e)
        {
            cbNivel.DataSource = getListNivel();
            txtUsuario.Text = _mdlLogin.usuario;
            txtSenha.Text = _mdlLogin.senha;
            txtConfirmarSenha.Text = _mdlLogin.senha;
            cbNivel.Text = (_mdlLogin.administrador) ? "Administrador" : "Comum";

            if (FrmPrincipal.loginAcessado.idLogin == _mdlLogin.idLogin)
            {
                txtUsuario.Enabled = false;
                cbNivel.Enabled = false;

                MessageBox.Show("Ao editar o seu usuário, você apenas poderá redefinir a senha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private static List<string> getListNivel()
        {
            List<string> list = new List<string>();

            list.Add("Comum");
            list.Add("Administrador");

            return list;
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        { 
            if (validarCampos(txtUsuario.Text, txtSenha.Text, txtConfirmarSenha.Text, cbNivel.Text))
            {

                mdlLogin _mdlLogin = new mdlLogin();

                _mdlLogin.idLogin = this._mdlLogin.idLogin;
                _mdlLogin.usuario = txtUsuario.Text;
                _mdlLogin.senha = txtSenha.Text;
                _mdlLogin.administrador = cbNivel.Text == "Administrador";

                if (ctlLogin.EditarUsuario(_mdlLogin, nomeAtual))
                {
                    if(FrmPrincipal.loginAcessado.idLogin == _mdlLogin.idLogin)
                    {
                        FrmPrincipal.loginAcessado.idLogin = _mdlLogin.idLogin;
                        FrmPrincipal.loginAcessado.usuario = _mdlLogin.usuario;
                        FrmPrincipal.loginAcessado.senha = _mdlLogin.senha;
                        FrmPrincipal.loginAcessado.administrador = _mdlLogin.administrador;
                    }
                    this.Close();
                }
            }           
        }

        private bool validarCampos(string txtUsuario, string txtSenha, string txtConfirmarSenha, string cbNivel)
        {
            if (String.IsNullOrEmpty(txtUsuario))
            {
                MostrarMensagemDeErro("Nome de usuário não pode estar em branco!");
                return false;
            }
            else if (String.IsNullOrEmpty(txtSenha))
            {
                MostrarMensagemDeErro("A senha não pode estar em branco!");
                return false;
            }
            else if (txtSenha.Length < 8)
            {
                MostrarMensagemDeErro("A senha deve ter no mínimo 8 digitos!");
                return false;
            }
            else if (txtSenha != txtConfirmarSenha)
            {
                MostrarMensagemDeErro("A senha e a confirmação da senha não se coincidem!");
                return false;
            }
            else if (!(cbNivel == "Comum" || cbNivel == "Administrador"))
            {
                MostrarMensagemDeErro("Nível inválido!");
                return false;
            }

            return true;
        }

        private static void MostrarMensagemDeErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
