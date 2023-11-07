using projeto.Modelo;
using Projeto.Modelo;
using Projeto_Controle;
using PrototipoRH.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoRH.Empresas
{
    public partial class frmEmpresa : Form
    {
        public frmEmpresa()
        {
            InitializeComponent();
            //LoadGataGridView();
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            RbtnNomeEmpresa.Checked = true;
        }

        private void btnPesquisarEmpresa_Click_1(object sender, EventArgs e)
        {
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();         
            if (RbtnNomeEmpresa.Checked == true)
            {
                _mdlEmpresa.nome = TxtPesquisarEmpresa.Text;
                dgvEmpresa.DataSource = ctlEmpresa.pesquisarEmpresaPeloNome(_mdlEmpresa);
            }

            if(RbtnCnpjEmpresa.Checked == true)
            {
                _mdlEmpresa.cnpj = TxtPesquisarEmpresa.Text;
                dgvEmpresa.DataSource = ctlEmpresa.pesquisarEmpresaPeloCNPJ(_mdlEmpresa);
            }
        }

        private void BtnAddEmpresa_Click_1(object sender, EventArgs e)
        {
            frmAddEmpresa frmAddempresa = new frmAddEmpresa();
            frmAddempresa.ShowDialog();
        }


        private void BtnExcluirEmpresa_Click_1(object sender, EventArgs e)
        {
            if (dgvEmpresa.SelectedCells.Count > 0)
            {
                int id = Convert.ToInt32(dgvEmpresa.SelectedCells[0].Value.ToString());

                mdlEmpresa _mdlEmpresa = new mdlEmpresa();
                _mdlEmpresa.idEmpresa = id;

                string nomeEmpresa = ctlEmpresa.BuscarEmpresaPeloID(_mdlEmpresa).nome;

                DialogResult confirmResult = MessageBox.Show($"Tem certeza que deseja excluir a empresa '{nomeEmpresa}'?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    ctlEmpresa _ctlEmpresa = new ctlEmpresa();
                    bool sucesso = _ctlEmpresa.ExcluirEmpresa(id);

                    if (sucesso)
                    {
                        MessageBox.Show("Empresa excluída com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível excluir a empresa. Verifique se a empresa foi selecionada corretamente.");
                    }
                }
            }
            else
            {
                MostrarMensagemDeErro("Selecione um registro antes de excluir!");
            }
        }
        private static void MostrarMensagemDeErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnEditarEmpresa_Click(object sender, EventArgs e)
        {

            if (dgvEmpresa.SelectedCells.Count > 0)
            {
                int id = Convert.ToInt32(dgvEmpresa.SelectedCells[0].Value.ToString());
                mdlEmpresa _mdlEmpresa = new mdlEmpresa();
                _mdlEmpresa.idEmpresa = id;
                frmAtualizarEmpresa _frmAtualizarEmpresa = new frmAtualizarEmpresa(ctlEmpresa.BuscarEmpresaPeloID(_mdlEmpresa));
                _frmAtualizarEmpresa.ShowDialog();
            }
            else
            {
                MostrarMensagemDeErro("Selecione um registro antes de editar!");
            }

        }
    }
}

