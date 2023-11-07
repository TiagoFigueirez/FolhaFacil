using projeto.Modelo;
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

namespace PrototipoRH.Empresas
{
    public partial class frmAtualizarEmpresa : Form
    {
        private mdlEmpresa _mdlEmpresa = new mdlEmpresa();
        private ctlEmpresa ctlEmpresa = new ctlEmpresa();
        public frmAtualizarEmpresa(mdlEmpresa _mdlEmpresa)
        {
            InitializeComponent();
            this._mdlEmpresa = _mdlEmpresa;
        }

        private void frmAtualizarEmpresa_Load(object sender, EventArgs e)
        {
            txtEmpresa.Text = _mdlEmpresa.nome;
            mskCnpj.Text = _mdlEmpresa.cnpj;
            msktxtTelefone.Text = _mdlEmpresa.telefone;
            txtEmail.Text = _mdlEmpresa.email;
            txtEndereco.Text = _mdlEmpresa.endereco;
        }
        
        private void btnAtualizarEmpresa_Click(object sender, EventArgs e)
        {
            if(validarCampos(txtEmpresa.Text,mskCnpj.Text,msktxtTelefone.Text,txtEmail.Text,txtEndereco.Text))
            { 
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();

            _mdlEmpresa.idEmpresa = this._mdlEmpresa.idEmpresa;
            _mdlEmpresa.nome = txtEmpresa.Text;
            _mdlEmpresa.cnpj = mskCnpj.Text;
            _mdlEmpresa.telefone = msktxtTelefone.Text;
            _mdlEmpresa.email = txtEmail.Text;
            _mdlEmpresa.endereco = txtEndereco.Text;

                if (ctlEmpresa.EditarEmpresa(_mdlEmpresa))
                 {
                MessageBox.Show("Editado com Sucesso");
                 }
            }
        }
        private bool validarCampos(string txtEmpresa, string mskCnpj, string msktxtTelefone, string txtEmail, string txtEndereco)
        {
            if (String.IsNullOrEmpty(txtEmpresa))
            {
                MostrarMensagemDeErro("O campo Empresa não pode estar vazio");
                return false;
            }
            else if (mskCnpj.Length<14 || String.IsNullOrEmpty(mskCnpj))
            {
                MostrarMensagemDeErro("CNPJ inválido");
                return false;
            }
            else if (msktxtTelefone.Length<11 || String.IsNullOrEmpty(msktxtTelefone))
            {
                MostrarMensagemDeErro("Telefone inválido");
                return false;
            }
            else if (String.IsNullOrEmpty(txtEmail))
            {
                MostrarMensagemDeErro("O campo Email não pode estar vazio");
                return false;
            }
            else if (String.IsNullOrEmpty(txtEndereco))
            {
                MostrarMensagemDeErro("O campo Endereço não pode estar vazio");
                return false;
            }

            return true;
        }



        private static void MostrarMensagemDeErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnLimparEmpresa_Click(object sender, EventArgs e)
        {
            txtEmpresa.Text = "";
            mskCnpj.Text = "";
            msktxtTelefone.Text = "";
            txtEmail.Text = "";
            txtEndereco.Text = "";
        }
    }
}
