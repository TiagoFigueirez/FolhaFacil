using classesDeControle;
using projeto.Modelo;
using Projeto.Modelo;
using Projeto_Controle;
using PrototipoRH.Funcionarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoRH.Empresas
{
    public partial class frmAddEmpresa : Form
    {
        public frmAddEmpresa()
        {
            InitializeComponent();
        }

    //metodo que pega o valor no re
    public void GetEmpresa(int id)
        {/*
            
            string conexaoSql = @"Data Source=DESKTOP-NH2G201\SQLEXPRESS;Initial Catalog=BdFolhaFacil;Integrated Security=True";

            SqlConnection conexaoBd = new SqlConnection(conexaoSql);


            try
            {
                string query = @"SELECT*FROM TBempresa WHERE idEmpresa =" + id;
                SqlCommand cmd = new SqlCommand(query, conexaoBd);

                conexaoBd.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if(dr.Read())
                    {
                        txtEmpresa.Text = dr["nomeEmpresa"].ToString();
                        mskCnpj.Text = dr["cnpj"].ToString();
                        txtEndereco.Text = dr["logradouro"].ToString();
                        msktxtTelefone.Text = dr["telefone"].ToString();
                        txtEmail.Text = dr["email"].ToString();

                        btnLimparEmpresa.Visible = false;
                        btnCadstrarEmpresa.Text = "Salvar";
                    }
                }

            }catch(Exception ex)
            {
                conexaoBd.Close();
                throw new Exception("Erro não foi possivel abrir os dados da Empresa" + ex.Message);
            }*/
        }

        //Botão para quando o usuraio clicar em adicionar
        public void btnCadstrarEmpresa_Click(object sender, EventArgs e)
        {
            if (validarCampos(txtEmpresa.Text, mskCnpj.Text, txtEmail.Text, msktxtTelefone.Text, txtEndereco.Text))
            { 
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();
            ctlEmpresa _ctlEmpresa = new ctlEmpresa();

            _mdlEmpresa.nome = txtEmpresa.Text;
            _mdlEmpresa.cnpj = mskCnpj.Text;
            _mdlEmpresa.email = txtEmail.Text;
            _mdlEmpresa.telefone = msktxtTelefone.Text;
            _mdlEmpresa.endereco = txtEndereco.Text;

            bool insercaoBemSucedida = _ctlEmpresa.IncluirEmpresa(_mdlEmpresa);

                if (insercaoBemSucedida)
                {
                    MessageBox.Show("Empresa Cadastrada com Sucesso!");
                    this.Close();
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
            else if (mskCnpj.Length < 14 || String.IsNullOrEmpty(mskCnpj))
            {
                MostrarMensagemDeErro("CNPJ inválido");
                return false;
            }
            else if (msktxtTelefone.Length < 11 || String.IsNullOrEmpty(msktxtTelefone))
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
        //botão disponivel quando o formulario for de adicionar, limpa os dados 
        private void btnLimparEmpresa_Click(object sender, EventArgs e)
        {
            txtEmpresa.Text = "";
            mskCnpj.Text = "";
            msktxtTelefone.Text = "";
            txtEmail.Text = "";            
            txtEndereco.Text = "";       
        }

        private static void MostrarMensagemDeErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
