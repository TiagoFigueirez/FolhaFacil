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

namespace PrototipoRH.Funcionarios
{
    public partial class frmUpdateFuncionario : Form
    {

        private mdlFuncionario _mdlFuncionario = new mdlFuncionario();
        private ctlFuncionario ctlFuncionario = new ctlFuncionario();
        public frmUpdateFuncionario(mdlFuncionario _mdlFuncionario)
        {
            InitializeComponent();
            this._mdlFuncionario = _mdlFuncionario;
        }

        private void frmUpdateFuncionario_Load(object sender, EventArgs e)
        {
            _mdlFuncionario.idFuncionario = this._mdlFuncionario.idFuncionario;
            txtNomeFuncionario.Text = _mdlFuncionario.nome;
            txtEnderecoFuncionario.Text = _mdlFuncionario.endereco;
            txtRg.Text = _mdlFuncionario.rg;
            mskCpf.Text = _mdlFuncionario.cpf;
            txtMatriculaFuncionario.Text = Convert.ToInt32(_mdlFuncionario.matricula).ToString();
            txtEMail.Text = _mdlFuncionario.email;
            mskTelefoneFunc.Text = _mdlFuncionario.telefone;
            txtDataNascimento.Text = _mdlFuncionario.dataNascimento.ToString("dd/MM/yyyy");
            txtSenha.Text = _mdlFuncionario.senha;
            cbEmpresa.Text = _mdlFuncionario.empresa.ToString();
            txtPis.Text = _mdlFuncionario.pis;
            mskCarteiraTrabalho.Text = _mdlFuncionario.carteiraTrabalho;
            txtSalarioHora.Text = _mdlFuncionario.salarioHora.ToString();
            mskDataAdmissao.Text = _mdlFuncionario.dataAdmissao.ToString("dd/MM/yyyy");
            txtDepartamento.Text = _mdlFuncionario.departamento;
            txtCargaHorariaSemanal.Text = _mdlFuncionario.cargaHorariaSemanal.ToString();
            txtCargoFunc.Text = _mdlFuncionario.cargo;
            cboStatus.Text = _mdlFuncionario.ativo.ToString();
            cbEmpresa.DataSource = ctlEmpresa.listarEmpresa();
            cbEmpresa.Text = _mdlFuncionario.empresa.nome;
            cboStatus.DataSource = getListStatus();

        }

        private static List<string> getListStatus()
        {
            List<string> list = new List<string>();
            list.Add("ATIVO");
            list.Add("DESLIGADO");
            return list;
        }

        private void btnAddFuncionario_Click(object sender, EventArgs e)
        {
            if (ValidarCampos(txtNomeFuncionario.Text, mskCpf.Text, txtRg.Text, txtMatriculaFuncionario.Text, txtDepartamento.Text, txtCargoFunc.Text, txtSalarioHora.Text, mskCarteiraTrabalho.Text, txtPis.Text, mskDataAdmissao.Text, txtCargaHorariaSemanal.Text, txtDataNascimento.Text, cboStatus.Text, mskTelefoneFunc.Text, txtEnderecoFuncionario.Text, txtEMail.Text, txtSenha.Text, cbEmpresa.Text))
            { 
                mdlFuncionario _mdlFuncionario = new mdlFuncionario();
            _mdlFuncionario.idFuncionario = this._mdlFuncionario.idFuncionario;
            _mdlFuncionario.nome = txtNomeFuncionario.Text;
            _mdlFuncionario.cpf = mskCpf.Text;
            _mdlFuncionario.rg = txtRg.Text;
            _mdlFuncionario.matricula = Convert.ToInt32(txtMatriculaFuncionario.Text);
            _mdlFuncionario.departamento = txtDepartamento.Text;
            _mdlFuncionario.cargo = txtCargoFunc.Text;
            _mdlFuncionario.salarioHora = Convert.ToDouble(txtSalarioHora.Text);
            _mdlFuncionario.carteiraTrabalho = mskCarteiraTrabalho.Text;
            _mdlFuncionario.pis = txtPis.Text;
            DateTime dataAdmissao;
            DateTime.TryParse(mskDataAdmissao.Text.ToString(), out dataAdmissao);
            _mdlFuncionario.dataAdmissao = dataAdmissao;
            _mdlFuncionario.cargaHorariaSemanal = Convert.ToInt32(txtCargaHorariaSemanal.Text);
            DateTime dataNascimento;
            DateTime.TryParse(txtDataNascimento.Text.ToString(), out dataNascimento);
            _mdlFuncionario.dataNascimento = dataNascimento;
            if (cboStatus.Text == "ATIVO")
            { _mdlFuncionario.ativo = true; }
            else 
            {
                _mdlFuncionario.ativo = false;
            }
            _mdlFuncionario.telefone = mskTelefoneFunc.Text;
            _mdlFuncionario.endereco = txtEnderecoFuncionario.Text;
            _mdlFuncionario.email = txtEMail.Text;
            _mdlFuncionario.senha = txtSenha.Text;
            mdlEmpresa _mdlEmpresa = new mdlEmpresa();
            _mdlEmpresa.nome = cbEmpresa.Text;
            _mdlFuncionario.empresa = _mdlEmpresa;


            if (ctlFuncionario.EditarFuncionario(_mdlFuncionario))
            {
                MessageBox.Show("Editado com Sucesso");
                this.Close();
            }
         }
    }

        private bool ValidarCampos(string nomeFuncionario, string cpf, string rg, string matriculaFuncionario, string departamento, string cargo, string salarioHora, string carteiraTrabalho, string pis, string dataAdmissao, string cargaHorariaSemanal, string dataNascimento, string status, string telefone, string endereco, string email, string senha, string empresa)
        {

            //ERRO
            if (String.IsNullOrEmpty(nomeFuncionario))
            {
                MostrarMensagemDeErro("O campo nome não pode estar vazio");
                return false;
            }
            else if (String.IsNullOrEmpty(cpf))
            {
                MostrarMensagemDeErro("O campo de CPF não pode estar vazio");
                return false;
            }
            else if (String.IsNullOrEmpty(rg))
            {
                MostrarMensagemDeErro("O campo de RG não pode estar vazio");
                return false;
            }
            else if (String.IsNullOrEmpty(matriculaFuncionario))
            {
                MostrarMensagemDeErro("O campo de matrícula não pode estar vazio");
                return false;
            }
            else if (String.IsNullOrEmpty(departamento))
            {
                MostrarMensagemDeErro("O campo de departamento não pode estar vazio");
                return false;
            }
            else if (String.IsNullOrEmpty(cargo))
            {
                MostrarMensagemDeErro("O campo de cargo não pode estar vazio");
                return false;
            }
            else if (String.IsNullOrEmpty(salarioHora))
            {
                MostrarMensagemDeErro("O campo de salário hora não pode estar vazio");
                return false;
            }
            else if (String.IsNullOrEmpty(carteiraTrabalho))
            {
                MostrarMensagemDeErro("O campo de data de admissão não pode estar vazio");
                return false;
            }
            else if (!(status == "ATIVO" || status == "DESLIGADO"))
            {
                MostrarMensagemDeErro("Opção de Status inválida");
                return false;
            }
            else if (String.IsNullOrEmpty(cargaHorariaSemanal))
            {
                MostrarMensagemDeErro("O campo de carga horaria semanal não pode estar vazio");
                return false;
            }
            else if (String.IsNullOrEmpty(dataNascimento))
            {
                MostrarMensagemDeErro("O campo de data de nascimento não pode estar vazio");
                return false;
            }
            else if (String.IsNullOrEmpty(email))
            {
                MostrarMensagemDeErro("O campo de email não pode estar vazio");
                return false;
            }
            else if (String.IsNullOrEmpty(senha))
            {
                MostrarMensagemDeErro("O campo de senha não pode estar vazio");
                return false;
            }
            else if (senha.Length < 8)
            {
                MostrarMensagemDeErro("A senha deve conter no mínimo 8 dígitos");
                return false;
            }
            else if (empresa == "[Selecionar]")
            {
                MostrarMensagemDeErro("Selecione uma empresa antes de adicionar");
                return false;
            }
            if (cpf.Length != 14)
            {
                MostrarMensagemDeErro("O CPF do funcionário deve ter 11 dígitos");
                return false;
            }
            else if (dataAdmissao.Length != 10)
            {
                MostrarMensagemDeErro("Quantidade de dígitos no campo de data de admissão inválida");
                return false;
            }
            else if (dataNascimento.Length != 10)
            {
                MostrarMensagemDeErro("Quantidade de dígitos no campo de data de nascimento inválida");
                return false;
            }

            //WARNING
            DialogResult question;
            if (String.IsNullOrEmpty(carteiraTrabalho))
            {
                question = MostrarMensagemDeAviso($"O campo de carteira de trabalho está em branco, deseja continuar?");

                if (question.Equals(DialogResult.No))
                {
                    return false;
                }
            }
            else if (String.IsNullOrEmpty(pis))
            {
                question = MostrarMensagemDeAviso($"O campo de PIS está em branco, deseja continuar?");

                if (question.Equals(DialogResult.No))
                {
                    return false;
                }
            }
            else if (rg.Length != 12)
            {
                question = MostrarMensagemDeAviso($"Há apenas {rg.Length} dígitos no campo de RG, deseja continuar?");

                if (question.Equals(DialogResult.No))
                {
                    return false;
                }
            }
            else if (String.IsNullOrEmpty(telefone))
            {
                question = MostrarMensagemDeAviso($"O campo de telefone está em branco, deseja continuar?");

                if (question.Equals(DialogResult.No))
                {
                    return false;
                }
            }
            else if (telefone.Length != 14)
            {
                question = MostrarMensagemDeAviso($"Há apenas {telefone.Length} dígitos no campo de telefone, deseja continuar?");

                if (question.Equals(DialogResult.No))
                {
                    return false;
                }
            }
            else if (String.IsNullOrEmpty(endereco))
            {
                MostrarMensagemDeErro("O campo endereço não pode estar vazio");
                return false;
            }

            return true;
        }

        private static void MostrarMensagemDeErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static DialogResult MostrarMensagemDeAviso(string mensagem)
        {
            return MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}
