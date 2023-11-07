using classesDeControle;
using projeto.Modelo;
using Projeto.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoRH.Ferias
{
    public partial class frmAtribuirFerias : Form
    {

      mdlFerias _mdlFerias = new mdlFerias();

        public frmAtribuirFerias(mdlFerias mdlFerias)
        {
            InitializeComponent();
            this._mdlFerias = mdlFerias;

           
        }

        private void btnAtribuir_Click(object sender, EventArgs e)
        {
            DateTime dataInicio;
            DateTime datafim;

            if(mskDataInicio.Text == "00/00/0000" && mskFimFerias.Text == "00/00/0000")
            {
                MostrarMenssagemErro("Insira uma data valida!");
                return;
            }

            DateTime.TryParse(mskDataInicio.Text.ToString(), out dataInicio);
            _mdlFerias.periodoInicio = dataInicio;

            DateTime.TryParse(mskFimFerias.Text.ToString(), out datafim);
            _mdlFerias.periodoFim = datafim;

            if(datafim >= dataInicio || dataInicio == datafim)
            {
                MostrarMenssagemErro("data do fim das ferias maior que data inicio ou são iguais, coloque uma data valida!");
                return;
            }

            
            if (ctlFerias.AtribuirFerias(_mdlFerias))
            {
                MessageBox.Show("Ferias Atribuidas!");
                this.Close();
            }

        }

        private void frmAtribuirFerias_Load(object sender, EventArgs e)
        {
            mskDataVencimento.Text = _mdlFerias.periodoDataVencimento.ToString("dd-MM-yyyy");

            if (_mdlFerias.periodoInicio.ToString("dd-MM-yyyy") == "01-01-0001" && _mdlFerias.periodoFim.ToString("dd-MM-yyyy") == "01-01-0001")
            {
                mskDataInicio.Text = "000000000";
                mskFimFerias.Text = "00000000";
            }
            else {           
            mskDataInicio.Text = _mdlFerias.periodoInicio.ToString("dd-MM-yyyy");
            mskFimFerias.Text = _mdlFerias.periodoFim.ToString("dd-MM-yyyy");

            }

            if (_mdlFerias.vencido== true)
            {
                txtVencimento.Text = "Vencido";
            }
            else
            {
                txtVencimento.Text = "A vencer";
            }
            
        }

        public static void MostrarMenssagemErro(string mensagem)
        {
            MessageBox.Show(mensagem,"erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
