using classesDeControle;
using projeto.Modelo;
using Projeto.Modelo;
using Projeto_Controle;
using PrototipoRH.Empresas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoRH.Funcionarios
{
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }


        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            comboBox_Empresa.DataSource = ctlEmpresa.listarEmpresa();
            comboBox_Empresa.Text = "[Selecionar]";
            radioButton_Nome.Checked = true;
        }

        private void btnAddFuncionario_Click(object sender, EventArgs e)
        {
            frmAddFuncionario _frmAddFuncionario = new frmAddFuncionario();

            _frmAddFuncionario.ShowDialog();

        }

        private void BtnPesquisarFuncionario_Click(object sender, EventArgs e)
        {
            mdlFuncionario _mdlFuncionario = new mdlFuncionario();
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();

            if (comboBox_Empresa.Text == "[Selecionar]")
            {
                MostrarMensagemDeErro("Selecione alguma empresa antes de pesquisar!");
                return;
            }

            _mdlEmpresa.nome = comboBox_Empresa.Text;
            _mdlFuncionario.empresa = _mdlEmpresa;

            if (radioButton_Nome.Checked)
            {
                _mdlFuncionario.nome = txtPesFuncionario.Text;
                DgvFuncionario.DataSource = ctlFuncionario.PesquisarFuncionarioPeloNome(_mdlFuncionario);
            }

            if (radioButton_CPF.Checked)
            {
                _mdlFuncionario.cpf = txtPesFuncionario.Text;
                DgvFuncionario.DataSource = ctlFuncionario.PesquisarFuncionarioPeloCPF(_mdlFuncionario);
            }

            if (radioButton_RG.Checked)
            {
                _mdlFuncionario.rg = txtPesFuncionario.Text;
                DgvFuncionario.DataSource = ctlFuncionario.PesquisarFuncionarioPeloCPF(_mdlFuncionario);
            }

            if (radioButton_Matrícula.Checked)
            {
                try
                {
                    _mdlFuncionario.matricula = Convert.ToInt32(txtPesFuncionario.Text);
                    DgvFuncionario.DataSource = ctlFuncionario.PesquisarFuncionarioPelaMatricula(_mdlFuncionario);
                }
                catch (Exception ex)
                {
                    string tiraWarning = ex.Message;
                    MostrarMensagemDeErro("No filtro de matrícula é obrigatório usar valores apenas numéricos!");
                }
            }
        }

        private static void MostrarMensagemDeErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnExcluFuncionario_Click(object sender, EventArgs e)
        {
            if (DgvFuncionario.SelectedCells.Count > 0)
            {
                int @idFuncionario = Convert.ToInt32(DgvFuncionario.SelectedCells[0].Value.ToString());

                mdlFuncionario _mdlFuncionario = new mdlFuncionario();
                _mdlFuncionario.idFuncionario = @idFuncionario;

                string nomeFuncionario = ctlFuncionario.BuscarFuncionarioPeloID(_mdlFuncionario).nome;

                DialogResult confirmResult = MessageBox.Show($"Tem certeza que deseja excluir '{nomeFuncionario}' ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    ctlFuncionario _ctlFuncionario = new ctlFuncionario();
                    bool sucesso = _ctlFuncionario.removerFuncionario(_mdlFuncionario);

                    if (sucesso)
                    {
                        MessageBox.Show("Funcionário excluído com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível excluir o funcionário. Verifique se o funcionário foi selecionado corretamente.");
                    }
                }
            }
            else
            {
                MostrarMensagemDeErro("Selecione um registro antes de excluir!");
            }

        }

        private void BtnEditFuncionario_Click(object sender, EventArgs e)
        {
            if (DgvFuncionario.SelectedCells.Count > 0) 
            { 
                int @idFuncionario = Convert.ToInt32(DgvFuncionario.SelectedCells[0].Value);

                mdlFuncionario _mdlFuncionario = new mdlFuncionario();
                _mdlFuncionario.idFuncionario = @idFuncionario;

                frmUpdateFuncionario _frmUpdateFuncionario = new frmUpdateFuncionario(ctlFuncionario.BuscarFuncionarioPeloID(_mdlFuncionario));
                _frmUpdateFuncionario.ShowDialog();

            }
        }
    }
}
