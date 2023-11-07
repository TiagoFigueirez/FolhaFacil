using classesDeControle;
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

namespace PrototipoRH.Folha_de_Pagamento
{
    public partial class frmFolhaPagamento : Form
    {
        public frmFolhaPagamento()
        {
            InitializeComponent();
        }

        //ALTEREI~
        private void frmFolhaPagamento_Load(object sender, EventArgs e)
        {
            comboBox_Empresa.DataSource = ctlEmpresa.listarEmpresa();
            comboBox_Empresa.Text = "[Selecionar]";
            radioButton_Nome.Checked = true;
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

        private void btnVisualizarHolerite_Click(object sender, EventArgs e)
        {

            if (DgvFuncionario.SelectedCells.Count > 0)
            {
                int id = Convert.ToInt32(DgvFuncionario.SelectedCells[0].Value.ToString());
                mdlFuncionario _mdlFuncionario = new mdlFuncionario();
                _mdlFuncionario.idFuncionario = id;
                _mdlFuncionario = ctlFuncionario.BuscarFuncionarioPeloID(_mdlFuncionario);

                if (ValidarCampos(maskedTextBox_DataInicio.Text, maskedTextBox_DataFim.Text))
                {
                    DateTime dataInicio;
                    DateTime dataFim;

                    DateTime.TryParse(maskedTextBox_DataInicio.Text.ToString(), out dataInicio);
                    DateTime.TryParse(maskedTextBox_DataFim.Text.ToString(), out dataFim);

                    double horasTotais = ctlPonto.HorasTotaisTrabalhadas(_mdlFuncionario, dataInicio, dataFim);

                    if(horasTotais == 0.0)
                    {
                        return;
                    }

                    frmCaculoFolha _frmCaculoFolha = new frmCaculoFolha(_mdlFuncionario, horasTotais);

                    _frmCaculoFolha.ShowDialog();
                }
            } else
            {
                MostrarMensagemDeErro("Selecione um registro antes de visualizar o holerite!");
            }

        }

        private static bool ValidarCampos(string maskedTextBox_DataInicio, string maskedTextBox_DataFim)
        {
            if(maskedTextBox_DataInicio.Length != 10)
            {
                MostrarMensagemDeErro("O campo de data início está incompleto!");
                return false;
            } else if (maskedTextBox_DataFim.Length != 10)
            {
                MostrarMensagemDeErro("O campo de data fim está incompleto!");
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
