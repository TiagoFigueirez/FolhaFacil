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

namespace PrototipoRH.Apontamento_de_Horas
{
    public partial class frmApontamentoHoras : Form
    {
        public frmApontamentoHoras()
        {
            InitializeComponent();
        }

        private void frmApontamentoHoras_Load(object sender, EventArgs e)
        {
            comboBox_Empresa.DataSource = ctlEmpresa.listarEmpresa();
            comboBox_Empresa.Text = "[Selecionar]";

            mdlEmpresa mdlEmpresa = new mdlEmpresa();

            mdlEmpresa.nome = comboBox_Empresa.Text;

        }

        private void button_Consultar_Click(object sender, EventArgs e)
        {
            int matricula = Convert.ToInt32(comboBox_Funcionario.Text.Split(' ')[0]);

            mdlFuncionario _mdlFuncionario = new mdlFuncionario();

            _mdlFuncionario.matricula = matricula;
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();
            _mdlEmpresa.nome = comboBox_Empresa.Text;

            _mdlFuncionario.empresa = _mdlEmpresa;

            dataGridView_Consulta.DataSource = ctlPonto.ListarPontosFuncionario(_mdlFuncionario);

            
        }
        

        private void comboBox_Empresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            mdlEmpresa mdlEmpresa = new mdlEmpresa();

            mdlEmpresa.nome = comboBox_Empresa.Text;

            mdlFuncionario _mdlFuncionario =  new mdlFuncionario();

            _mdlFuncionario.empresa = mdlEmpresa;

            comboBox_Funcionario.DataSource = ctlFuncionario.ListarFuncionarioPonto(_mdlFuncionario);

            comboBox_Funcionario.Text = "[Selecionar]";
        }

        private static void MostrarMensagemDeErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

