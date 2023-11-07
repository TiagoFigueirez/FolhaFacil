using classesDeControle;
using projeto.Modelo;
using Projeto.Modelo;
using Projeto_Controle;
using PrototipoRH.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoRH.Usuarios
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
            //LoadDataGridView();
        }

        private void btnAddUsuario_Click(object sender, EventArgs e)
        {
            frmAddLogin _frmAddLogin = new frmAddLogin();
            _frmAddLogin.ShowDialog();
        }

        private void BtnPesquisarUsuario_Click(object sender, EventArgs e)
        {
            mdlLogin _mdlLogin = new mdlLogin();
            _mdlLogin.usuario = txtPesUsuario.Text;
            dgvUsuario.DataSource = ctlLogin.pesquisarUsuario(_mdlLogin);
        }

        private void BtnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.SelectedCells.Count > 0)
            {
                int id = Convert.ToInt32(dgvUsuario.SelectedCells[0].Value.ToString());
                mdlLogin _mdlLogin = new mdlLogin();
                _mdlLogin.idLogin = id;
                frmEditarLogin _frmDeletarUsuario = new frmEditarLogin(ctlLogin.BuscarLoginPeloID(_mdlLogin));
                _frmDeletarUsuario.ShowDialog();
            }
            else
            {
                MostrarMensagemDeErro("Selecione um registro antes de editar!");
            }
        }

        private void btnExcluFuncionario_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.SelectedCells.Count > 0)
            {
                int id = Convert.ToInt32(dgvUsuario.SelectedCells[0].Value.ToString());
                if (FrmPrincipal.loginAcessado.idLogin != id)
                {
                    mdlLogin _mdlLogin = new mdlLogin();
                    _mdlLogin.idLogin = id;
                    frmDeletarLogin _frmDeletarLogin = new frmDeletarLogin(ctlLogin.BuscarLoginPeloID(_mdlLogin));
                    _frmDeletarLogin.ShowDialog();
                } else
                {
                    MostrarMensagemDeErro("Você não pode excluir o login que você está usando!");
                }
            } else
            {
                MostrarMensagemDeErro("Selecione um registro antes de excluir!");
            }
        }

        private void btnRefreshUsuario_Click_1(object sender, EventArgs e)
        {
            //LoadDataGridView();
        }

        public void LoadDataGridView()
        {/*
            string conexaoSQL = @"Data Source=DESKTOP-NH2G201\SQLEXPRESS;Initial Catalog=BdFolhaFacil;Integrated Security=True";
            SqlConnection conexadoBd = new SqlConnection(conexaoSQL);

            try
            {
                conexadoBd.Open();
                string query = @"SELECT*FROM TBusuario";

                SqlDataAdapter da = new SqlDataAdapter(query, conexaoSQL);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvUsuario.DataSource = dt;

                foreach (DataGridViewColumn colunas in dgvUsuario.Columns)
                {
                    colunas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                conexadoBd.Close();
                throw new Exception("Falha ao Pesquisar: " + ex.Message);
            }*/
        }

        private static void MostrarMensagemDeErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }


}

