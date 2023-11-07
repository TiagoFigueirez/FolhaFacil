using projeto.Modelo;
using Projeto.Modelo;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto_Controle
{
    public class ctlEmpresa
    {
        public static List<mdlEmpresa> listarEmpresa()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_pim;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);

            List<mdlEmpresa> empresas = new List<mdlEmpresa>();

            try
            {
                connection.Open();

                string sqlQuery = "SELECT * FROM Empresa;";
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                SqlDataReader cursor = command.ExecuteReader();

                if (cursor.HasRows)
                {
                    while (cursor.Read())
                    {
                        mdlEmpresa empresa = new mdlEmpresa();
                        empresa.idEmpresa = Convert.ToInt32(cursor["idEmpresa"]);
                        empresa.nome = cursor["nome"].ToString();
                        empresa.cnpj = cursor["cnpj"].ToString();
                        empresa.telefone = cursor["telefone"].ToString();
                        empresa.email = cursor["email"].ToString();
                        empresa.endereco = cursor["endereco"].ToString();
                        empresas.Add(empresa);
                    }
                }
            }
            catch (Exception e)
            {
                MostrarMensagemDeErro("Erro ao conectar ao banco de dados: " + e.Message);
            }
            return empresas;
        }

        public static List<mdlEmpresa> pesquisarEmpresaPeloNome(mdlEmpresa _mdlEmpresa)
        {

            List<mdlEmpresa> listEmpresa = new List<mdlEmpresa>();

            string[] nomeSeparado = _mdlEmpresa.nome.Split();
            string parametrosNome = "";
            for (int i = 0; i < nomeSeparado.Length; i++)
            {
                if (i == 0)
                {
                    parametrosNome += $"nome LIKE '%{nomeSeparado[i]}%";
                }
                else
                {
                    parametrosNome += $"%{nomeSeparado[i]}%";
                }
            }
            if (parametrosNome.Length > 0)
            {
                parametrosNome += "'";
            }

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_pim;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                string sqlQuery = "";
                if (parametrosNome.Length > 0)
                {
                    sqlQuery = $"SELECT * FROM Empresa WHERE {parametrosNome};";
                }
                else
                {
                    sqlQuery = $"SELECT * FROM Empresa;";
                }

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                SqlDataReader cursor = command.ExecuteReader();

                if (cursor.HasRows)
                {
                    while (cursor.Read())
                    {
                        mdlEmpresa empresa = new mdlEmpresa();
                        empresa.idEmpresa = Convert.ToInt32(cursor["idEmpresa"]);
                        empresa.nome = cursor["nome"].ToString();
                        empresa.cnpj = cursor["cnpj"].ToString();
                        empresa.telefone = cursor["telefone"].ToString();
                        empresa.email = cursor["email"].ToString();
                        empresa.endereco = cursor["endereco"].ToString();
                        listEmpresa.Add(empresa);
                    }
                }

                return listEmpresa;
            }
            catch (Exception e)
            {
                MostrarMensagemDeErro("Erro ao conectar ao banco de dados: " + e.Message);
                return listEmpresa;
            }
        }

        public static List<mdlEmpresa> pesquisarEmpresaPeloCNPJ(mdlEmpresa _mdlEmpresa)
        {
            List<mdlEmpresa> listEmpresa = new List<mdlEmpresa>();

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_pim;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                string sqlQuery = "SELECT * FROM Empresa WHERE cnpj LIKE @cnpj + '%';";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                var pmtCNPJ = command.CreateParameter();
                pmtCNPJ.ParameterName = "@cnpj";
                pmtCNPJ.DbType = DbType.String;
                pmtCNPJ.Value = _mdlEmpresa.cnpj;
                command.Parameters.Add(pmtCNPJ);

                SqlDataReader cursor = command.ExecuteReader();

                if (cursor.HasRows)
                {
                    while (cursor.Read())
                    {
                        mdlEmpresa empresa = new mdlEmpresa();
                        empresa.idEmpresa = Convert.ToInt32(cursor["idEmpresa"]);
                        empresa.nome = cursor["nome"].ToString();
                        empresa.cnpj = cursor["cnpj"].ToString();
                        empresa.telefone = cursor["telefone"].ToString();
                        empresa.email = cursor["email"].ToString();
                        empresa.endereco = cursor["endereco"].ToString();
                        listEmpresa.Add(empresa);
                    }
                }
                return listEmpresa;
            }
            catch (Exception e)
            {
                MostrarMensagemDeErro("Erro ao conectar ao banco de dados: " + e.Message);
                return listEmpresa;
            }
        }

        public static mdlEmpresa BuscarEmpresaPeloID(mdlEmpresa _mdlEmpresa)
        {
            mdlEmpresa empresa = new mdlEmpresa();

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_pim;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                string sqlQuery = "SELECT * FROM Empresa WHERE idEmpresa = @idEmpresa";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                var pmtIdEmpresa = command.CreateParameter();
                pmtIdEmpresa.ParameterName = "@idEmpresa";
                pmtIdEmpresa.DbType = DbType.Int32;
                pmtIdEmpresa.Value = _mdlEmpresa.idEmpresa;
                command.Parameters.Add(pmtIdEmpresa);

                SqlDataReader cursor = command.ExecuteReader();

                if (cursor.HasRows)
                {
                    if (cursor.Read())
                    {
                        empresa.idEmpresa = Convert.ToInt32(cursor["idEmpresa"]);
                        empresa.nome = cursor["nome"].ToString();
                        empresa.cnpj = cursor["cnpj"].ToString();
                        empresa.email = cursor["email"].ToString();
                        empresa.endereco = cursor["endereco"].ToString();
                        empresa.telefone = cursor["telefone"].ToString();
                    }
                }
                return empresa;
            }
            catch (Exception e)
            {
                MostrarMensagemDeErro("Erro ao conectar ao banco de dados: " + e.Message);
                return empresa;
            }
        }

        public bool IncluirEmpresa(mdlEmpresa _mdlEmpresa)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_pim;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                string query = "INSERT INTO Empresa (nome, cnpj, telefone, email, endereco) " +
                               "VALUES (@Nome, @Cnpj, @Telefone, @Email, @Endereco)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Nome", _mdlEmpresa.nome);
                command.Parameters.AddWithValue("@Cnpj", _mdlEmpresa.cnpj);
                command.Parameters.AddWithValue("@Telefone", _mdlEmpresa.telefone);
                command.Parameters.AddWithValue("@Email", _mdlEmpresa.email);
                command.Parameters.AddWithValue("@Endereco", _mdlEmpresa.endereco);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                MostrarMensagemDeErro("Erro ao conectar ao banco de dados: " + e.Message);
                return false;
            }
        }

        public bool ExcluirEmpresa(int id)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_pim;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                string query = "DELETE FROM Empresa WHERE idEmpresa = @idEmpresa;";

                SqlCommand command = new SqlCommand(query, connection);

                var pmtIdEmpresa = command.CreateParameter();
                pmtIdEmpresa.ParameterName = "@idEmpresa";
                pmtIdEmpresa.DbType = DbType.Int32;
                pmtIdEmpresa.Value = id;
                command.Parameters.Add(pmtIdEmpresa);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                MostrarMensagemDeErro("Erro ao conectar ao banco de dados: " + e.Message);
                return false;
            }
        }

        public bool EditarEmpresa(mdlEmpresa _mdlEmpresa)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_pim;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "UPDATE Empresa SET nome = @Nome, cnpj = @Cnpj, endereco = @Endereco, telefone = @Telefone, email = @Email WHERE idEmpresa = @IdEmpresa";

                SqlCommand command = new SqlCommand(query, connection);

                var pmtIdEmpresa = command.CreateParameter();
                pmtIdEmpresa.ParameterName = "@IdEmpresa";
                pmtIdEmpresa.DbType = DbType.Int32;
                pmtIdEmpresa.Value = _mdlEmpresa.idEmpresa;
                command.Parameters.Add(pmtIdEmpresa);

                var pmtNome = command.CreateParameter();
                pmtNome.ParameterName = "@Nome";
                pmtNome.DbType = DbType.String;
                pmtNome.Value = _mdlEmpresa.nome;
                command.Parameters.Add(pmtNome);

                var pmtCnpj = command.CreateParameter();
                pmtCnpj.ParameterName = "@Cnpj";
                pmtCnpj.DbType = DbType.String;
                pmtCnpj.Value = _mdlEmpresa.cnpj;
                command.Parameters.Add(pmtCnpj);

                var pmtEndereco = command.CreateParameter();
                pmtEndereco.ParameterName = "@Endereco";
                pmtEndereco.DbType = DbType.String;
                pmtEndereco.Value = _mdlEmpresa.endereco;
                command.Parameters.Add(pmtEndereco);

                var pmtTelefone = command.CreateParameter();
                pmtTelefone.ParameterName = "@Telefone";
                pmtTelefone.DbType = DbType.String;
                pmtTelefone.Value = _mdlEmpresa.telefone;
                command.Parameters.Add(pmtTelefone);

                var pmtEmail = command.CreateParameter();
                pmtEmail.ParameterName = "@Email";
                pmtEmail.DbType = DbType.String;
                pmtEmail.Value = _mdlEmpresa.email;
                command.Parameters.Add(pmtEmail);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                MostrarMensagemDeErro("Erro ao conectar ao banco de dados: " + e.Message);
                return false;
            }
        }


        private static void MostrarMensagemDeErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
