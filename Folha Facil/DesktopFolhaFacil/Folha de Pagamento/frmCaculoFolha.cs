using Projeto.Modelo;
using System;
using System.Windows.Forms;

namespace PrototipoRH.Folha_de_Pagamento
{
    public partial class frmCaculoFolha : Form
    {

        mdlFuncionario _mdlFuncionario = new mdlFuncionario();
        double horasTotais = 0.0;

        public frmCaculoFolha(mdlFuncionario _mdlFuncionario, double horasTotais)
        {
            InitializeComponent();
            this._mdlFuncionario = _mdlFuncionario;
            this.horasTotais = horasTotais;
        }

        private void frmCaculoFolha_Load(object sender, EventArgs e)
        {
            lblNomeEmpresa.Text = _mdlFuncionario.empresa.nome;
            lblCNPJ.Text = _mdlFuncionario.empresa.cnpj;
            lblNomeFuncionario.Text = _mdlFuncionario.nome;
            lblCargo.Text = _mdlFuncionario.cargo;
            lblDataAdmissao.Text = _mdlFuncionario.dataAdmissao.ToString("dd/MM/yyyy");
            lblHorasTrabalhadas.Text = horasTotais.ToString("N2");
            lblSalarioBruto.Text = (_mdlFuncionario.salarioHora * horasTotais).ToString("N2");
            lblTotalVencimento.Text = lblSalarioBruto.Text;

            double salarioBruto = Convert.ToDouble(lblSalarioBruto.Text);

            // Simples cálculo de INSS
            if (salarioBruto <= 1100.00) { 
                lblPorcentagemINSS.Text = 7.5.ToString("N2");
                lblDescontoINSS.Text = (salarioBruto * 0.075).ToString("N2");
            }
            else if (salarioBruto <= 2203.48)
            {
                lblPorcentagemINSS.Text = 9.ToString("N2");
                lblDescontoINSS.Text = (salarioBruto * 0.09).ToString("N2");
            }
            else if (salarioBruto <= 3305.22)
            {          
                lblPorcentagemINSS.Text = 12.ToString("N2");
                lblDescontoINSS.Text = (salarioBruto * 0.12).ToString("N2");
            }
            else if (salarioBruto <= 6433.57)
            { 
                lblPorcentagemINSS.Text = 14.ToString("N2");
                lblDescontoINSS.Text = (salarioBruto * 0.14).ToString("N2");
            }
            else
            {
                lblPorcentagemINSS.Text = 14.ToString("N2");
                lblDescontoINSS.Text = (6433.57 * 0.14).ToString("N2"); // Valor máximo de contribuição
            }
 
            // Simples cálculo de IR
            if (salarioBruto <= 1903.98)
            {
                lblIRPorcentagem.Text = 0.ToString("N2");
                lblIRDesconto.Text = 0.0.ToString("N2"); 
            }                
            else if (salarioBruto <= 2826.65)
            {
                lblIRPorcentagem.Text = 7.5.ToString("N2");
                lblIRDesconto.Text = ((salarioBruto * 0.075) - 142.80).ToString("N2");
            }               
            else if (salarioBruto <= 3751.05)
            {
                lblIRPorcentagem.Text = 15.ToString("N2");
                lblIRDesconto.Text = ((salarioBruto * 0.15) - 354.80).ToString("N2");
            }               
            else if (salarioBruto <= 4664.68)
            {
                lblIRPorcentagem.Text = 22.5.ToString("N2");
                lblIRDesconto.Text = ((salarioBruto * 0.225) - 636.13).ToString("N2");
            }                
            else
            {
                lblIRPorcentagem.Text = 27.5.ToString("N2");
                lblIRDesconto.Text = ((salarioBruto * 0.275) - 869.36).ToString("N2");
            }

            lblTotalDescontos.Text = (Convert.ToDouble(lblDescontoINSS.Text) + Convert.ToDouble(lblIRDesconto.Text)).ToString("N2");

            lblValorLiquido.Text = (Convert.ToDouble(lblTotalVencimento.Text) - Convert.ToDouble(lblTotalDescontos.Text)).ToString("N2");

        }

    }
}

