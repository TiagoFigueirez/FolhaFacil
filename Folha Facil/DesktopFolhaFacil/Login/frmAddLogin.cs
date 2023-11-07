using classesDeControle;
using projeto.Modelo;
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
    public partial class frmAddLogin : Form
    {
        public frmAddLogin()
        {
            InitializeComponent();
        }

        private void frmAddLogin_Load(object sender, EventArgs e)
        {
            cbNivel.DataSource = getListNivel();          
        }

        private static List<string> getListNivel()
        {
            List<string> list = new List<string>();

            list.Add("Comum");
            list.Add("Administrador");

            return list;
        }

        private void btnAddUsuario_Click(object sender, EventArgs e)
        {
            
            if (validarCampos(txtUsuario.Text, txtSenha.Text, txtConfirmarSenha.Text, cbNivel.Text))
            {

                mdlLogin _mdlLogin = new mdlLogin();

                _mdlLogin.usuario = txtUsuario.Text;
                _mdlLogin.senha = txtSenha.Text;
                _mdlLogin.administrador = cbNivel.Text == "Administrador";

                if (ctlLogin.adicionarUsuario(_mdlLogin))
                {
                    this.Close();
                }
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtConfirmarSenha.Text = "";
            cbNivel.Text = cbNivel.Items[0].ToString();
            txtUsuario.Focus();
        }

        private bool validarCampos(string txtUsuario, string txtSenha, string txtConfirmarSenha, string cbNivel)
        {
            if(String.IsNullOrEmpty(txtUsuario))
            {
                MostrarMensagemDeErro("Nome de usuário não pode estar em branco!");
                return false;
            } else if(String.IsNullOrEmpty(txtSenha))
            {
                MostrarMensagemDeErro("A senha não pode estar em branco!");
                return false;
            } else if(txtSenha.Length < 8)
            {
                MostrarMensagemDeErro("A senha deve ter no mínimo 8 digitos!");
                return false;
            } else if(txtSenha != txtConfirmarSenha)
            {
                MostrarMensagemDeErro("A senha e a confirmação da senha não se coincidem!");
                return false;
            } else if(!(cbNivel == "Comum" || cbNivel == "Administrador"))
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
