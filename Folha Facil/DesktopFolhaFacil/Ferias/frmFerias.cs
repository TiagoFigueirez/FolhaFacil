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

namespace PrototipoRH.Ferias
{
    public partial class frmFerias : Form
    {
        public frmFerias()
        {
            InitializeComponent();
        }

        private void frmFerias_Load(object sender, EventArgs e)
        {          
            comboBox_Empresa.DataSource = ctlEmpresa.listarEmpresa();
            comboBox_Empresa.Text = "[Selecionar]";
            radioButton_Nome.Checked = true;
        }

        private void BtnPesquisarFuncionario_Click(object sender, EventArgs e)
        {
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();
            mdlFuncionario _mdlFuncionario = new mdlFuncionario();

            if(comboBox_Empresa.Text == "[Selecionar]")
            {
                MostrarMensagemDeErro("Erro selecione alguma empresa");
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

        private void btnAtribuirFerias_Click(object sender, EventArgs e)
        {


            if (DgvFuncionario.SelectedCells.Count >0)
            {
                int id =Convert.ToInt32( DgvFuncionario.SelectedCells[0].Value.ToString());

                mdlFerias _mdlFerias = new mdlFerias();

                _mdlFerias.idFuncionario = id;
                frmAtribuirFerias _frmAtribuirFerias = new frmAtribuirFerias(ctlFerias.SelecionrFerias(_mdlFerias));                
                
                _frmAtribuirFerias.ShowDialog();


            }
            else
            {
                MostrarMensagemDeErro("Selecione uma Empresa e um funcionario !");
            }

               
        }
    }
}
