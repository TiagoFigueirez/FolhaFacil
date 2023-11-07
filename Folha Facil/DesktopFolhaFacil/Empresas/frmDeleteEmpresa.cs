using classesDeControle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoRH.Empresas
{
    public partial class frmDeleteEmpresa : Form
    {
        //int id = 0;
        public frmDeleteEmpresa(int id)
        {/*
            InitializeComponent();
            this.id = id;
            if (id > 0)
            {
                getDeleteEmpresa(id);
            }*/
        }

        public void getDeleteEmpresa(int id)
        {
            /*
            string conexaoSQL = @"Data Source=DESKTOP-NH2G201\SQLEXPRESS;Initial Catalog=BdFolhaFacil;Integrated Security=True";

            SqlConnection conexaoBd = new SqlConnection(conexaoSQL);

            try
            {
                conexaoBd.Open();
                string query = @"SELECT*FROM TBempresa WHERE idEmpresa=" + id;
                SqlCommand cmd = new SqlCommand(query,conexaoBd);

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        txtDeleteEmpresa.Text = reader["nomeEmpresa"].ToString();
                        mskDeleteCnpj.Text = reader["cnpj"].ToString();
                        txtDeleteEndereco.Text = reader["logradouro"].ToString();
                        mskDeleteTelefone.Text = reader["telefone"].ToString() ;
                        txtDeleteEmail.Text = reader["email"].ToString();
                    }
                }

            }catch (Exception ex)
            {
                conexaoBd.Close();
                throw new Exception("Erro não foi possivel deletar: " + ex.Message);
            }*/
        }

        private void btnDeleteEmpresa_Click(object sender, EventArgs e)
        {/*
            DialogResult confirmarDelete = MessageBox.Show("Deseja realmente excluir a empresa ?", "atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (confirmarDelete == DialogResult.Yes)
            {
                cltEmpresa _cltEmpresa = new cltEmpresa();
                _cltEmpresa.deletarEmpresa(this.id);
            }*/
        }
    }
}
