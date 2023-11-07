using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Modelo;
using System.Windows.Forms;

namespace Projeto_Controle
{
    public class ctlLogin
    {
        public static bool VerificarLogin(mdlLogin login, out mdlLogin loginAcessado)
        {

            loginAcessado = new mdlLogin();

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_pim;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);
            
            try
            {
                connection.Open();

                string sqlQuery = "SELECT * FROM Login WHERE usuario = @usuario AND senha COLLATE Latin1_General_BIN = @senha";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                var pmtUsuario = command.CreateParameter();
                pmtUsuario.ParameterName = "@usuario";
                pmtUsuario.DbType = DbType.String;
                pmtUsuario.Value = login.usuario;
                command.Parameters.Add(pmtUsuario);

                var pmtSenha = command.CreateParameter();
                pmtSenha.ParameterName = "@senha";
                pmtSenha.DbType = DbType.String;
                pmtSenha.Value = login.senha;
                command.Parameters.Add(pmtSenha);

                SqlDataReader cursor = command.ExecuteReader();

                if (cursor.HasRows)
                {
                    if (cursor.Read())
                    {
                        loginAcessado.idLogin = Convert.ToInt32(cursor["idLogin"]);
                        loginAcessado.usuario = cursor["usuario"].ToString();
                        loginAcessado.senha = cursor["senha"].ToString();
                        loginAcessado.administrador = Convert.ToBoolean(cursor["administrador"]);
                        return true;
                    }
                }
                MostrarMensagemDeErro("Login inválido!");
                return false;
            }
            catch (Exception e)
            {
                MostrarMensagemDeErro("Erro ao conectar ao banco de dados: " + e.Message);
                return false;
            }
            
        }

        public static List<mdlLogin> pesquisarUsuario(mdlLogin _mdlLogin)
        {

            List<mdlLogin> listLogin = new List<mdlLogin>();

            string[] nomeSeparado = _mdlLogin.usuario.Split();
            string parametrosUsuario = "";
            for(int i = 0; i < nomeSeparado.Length;i++)
            {
                if(i == 0)
                {
                    parametrosUsuario += $"usuario LIKE '%{nomeSeparado[i]}%";
                } else
                {
                    parametrosUsuario += $"%{nomeSeparado[i]}%";
                }          
            }
            if(parametrosUsuario.Length > 0)
            {
                parametrosUsuario += "'";
            }
            

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_pim;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                string sqlQuery = "";
                if (parametrosUsuario.Length > 0) {
                    sqlQuery = $"SELECT * FROM Login WHERE {parametrosUsuario};";
                    } else
                {
                    sqlQuery = $"SELECT * FROM Login;";
                }

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                SqlDataReader cursor = command.ExecuteReader();

                if (cursor.HasRows)
                {
                    while(cursor.Read())
                    {
                        mdlLogin login = new mdlLogin();
                        login.idLogin = Convert.ToInt32(cursor["idLogin"]);
                        login.usuario = cursor["usuario"].ToString();
                        login.senha = cursor["senha"].ToString();
                        login.administrador = ((Convert.ToInt32(cursor["administrador"]) == 1) ? true : false);
                        listLogin.Add(login);
                    } 
                }

                    return listLogin;
            } catch (Exception e)
            {
                MostrarMensagemDeErro("Erro ao conectar ao banco de dados: " + e.Message);
                return listLogin;
            }
        }

        public static bool VerificarUsuario(string usuario)
        {

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_pim;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string sqlQuery = "SELECT * FROM Login WHERE usuario = @usuario";

            SqlCommand command = new SqlCommand(sqlQuery, connection);

            var pmtUsuario = command.CreateParameter();
            pmtUsuario.ParameterName = "@usuario";
            pmtUsuario.DbType = DbType.String;
            pmtUsuario.Value = usuario;
            command.Parameters.Add(pmtUsuario);

            SqlDataReader cursor = command.ExecuteReader();

            if (cursor.HasRows)
            {
                cursor.Close();
                connection.Close();
                return true;
            }
            else
            {
                cursor.Close();
                connection.Close();
                return false;
            }
            
        }

        public static bool adicionarUsuario(mdlLogin _mdlLogin)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_pim;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {

                string nomeUsuario = "";
                if (VerificarUsuario(_mdlLogin.usuario))
                {
                    
                    int i = 0;
                    do
                    {
                        i++;
                        nomeUsuario = $"{_mdlLogin.usuario}{i}";
                    } while (VerificarUsuario(nomeUsuario));

                    DialogResult questionRename = MessageBox.Show($"O usuário '{_mdlLogin.usuario}' já foi cadastrado, poderia ser '{nomeUsuario}'?", "Usuário já existente", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if(questionRename == DialogResult.No)
                    {
                        return false;
                    }

                    _mdlLogin.usuario = nomeUsuario;

                }
                connection.Open();

                DialogResult questionConfirm = MessageBox.Show($"Confirma o cadastro do usuário '{_mdlLogin.usuario}'?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (questionConfirm == DialogResult.No)
                {
                    return false;
                }

                string sqlQuery = "INSERT INTO Login (usuario, senha, administrador) VALUES (@usuario, @senha, @administrador);";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                var pmtUsuario = command.CreateParameter();
                pmtUsuario.ParameterName = "@usuario";
                pmtUsuario.DbType = DbType.String;
                pmtUsuario.Value = _mdlLogin.usuario;
                command.Parameters.Add(pmtUsuario);

                var pmtSenha = command.CreateParameter();
                pmtSenha.ParameterName = "@senha";
                pmtSenha.DbType = DbType.String;
                pmtSenha.Value = _mdlLogin.senha;
                command.Parameters.Add(pmtSenha);

                var pmtNivel = command.CreateParameter();
                pmtNivel.ParameterName = "@administrador";
                pmtNivel.DbType = DbType.Boolean;
                pmtNivel.Value = _mdlLogin.administrador;
                command.Parameters.Add(pmtNivel);

                if(command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Login cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    return false;
                }
                
            } catch (Exception e)
            {
                MostrarMensagemDeErro("Erro ao conectar ao banco de dados: " + e.Message);
                return false;
            }
        }

        public static mdlLogin BuscarLoginPeloID(mdlLogin _mdlLogin)
        {
            mdlLogin login = new mdlLogin();

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_pim;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                string sqlQuery = "SELECT * FROM Login WHERE idLogin = @idLogin";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                var pmtIdLogin = command.CreateParameter();
                pmtIdLogin.ParameterName = "@idLogin";
                pmtIdLogin.DbType = DbType.Int32;
                pmtIdLogin.Value = _mdlLogin.idLogin;
                command.Parameters.Add(pmtIdLogin);

                SqlDataReader cursor = command.ExecuteReader();

                if (cursor.HasRows)
                {
                    if (cursor.Read())
                    {
                        login.idLogin = Convert.ToInt32(cursor["idLogin"]);
                        login.usuario = cursor["usuario"].ToString();
                        login.senha = cursor["senha"].ToString();
                        login.administrador = Convert.ToBoolean(cursor["administrador"]);
                    }
                }
                return login;
            }
            catch (Exception e)
            {
                MostrarMensagemDeErro("Erro ao conectar ao banco de dados: " + e.Message);
                return login;
            }
        }

        public static bool EditarUsuario(mdlLogin _mdlLogin, string nomeAtual)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_pim;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {

                string nomeUsuario = "";
                if (VerificarUsuario(_mdlLogin.usuario) && _mdlLogin.usuario != nomeAtual)
                {

                    int i = 0;
                    do
                    {
                        i++;
                        nomeUsuario = $"{_mdlLogin.usuario}{i}";
                    } while (VerificarUsuario(nomeUsuario));

                    DialogResult questionRename = MessageBox.Show($"O usuário '{_mdlLogin.usuario}' já foi cadastrado, poderia ser '{nomeUsuario}'?", "Usuário já existente", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (questionRename == DialogResult.No)
                    {
                        return false;
                    }

                    _mdlLogin.usuario = nomeUsuario;

                }
                connection.Open();

                DialogResult questionConfirm = MessageBox.Show($"Confirma a edição do usuário '{nomeAtual}'?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (questionConfirm == DialogResult.No)
                {
                    return false;
                }

                string sqlQuery = "UPDATE Login SET usuario = @usuario, senha = @senha, administrador = @administrador WHERE idLogin = @idLogin;";

                SqlCommand command = new SqlCommand(sqlQuery, connection);


                var pmtIdLogin = command.CreateParameter();
                pmtIdLogin.ParameterName = "@idLogin";
                pmtIdLogin.DbType = DbType.Int32;
                pmtIdLogin.Value = _mdlLogin.idLogin;
                command.Parameters.Add(pmtIdLogin);

                var pmtUsuario = command.CreateParameter();
                pmtUsuario.ParameterName = "@usuario";
                pmtUsuario.DbType = DbType.String;
                pmtUsuario.Value = _mdlLogin.usuario;
                command.Parameters.Add(pmtUsuario);

                var pmtSenha = command.CreateParameter();
                pmtSenha.ParameterName = "@senha";
                pmtSenha.DbType = DbType.String;
                pmtSenha.Value = _mdlLogin.senha;
                command.Parameters.Add(pmtSenha);

                var pmtNivel = command.CreateParameter();
                pmtNivel.ParameterName = "@administrador";
                pmtNivel.DbType = DbType.Boolean;
                pmtNivel.Value = _mdlLogin.administrador;
                command.Parameters.Add(pmtNivel);

                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Login editado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public static bool ExcluirUsuario(mdlLogin _mdlLogin)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_pim;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                DialogResult questionConfirm = MessageBox.Show($"Confirma a exclusão do usuário '{_mdlLogin.usuario}'?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (questionConfirm == DialogResult.No)
                {
                    return false;
                }

                string sqlQuery = "DELETE FROM Login WHERE idLogin = @idLogin;";

                SqlCommand command = new SqlCommand(sqlQuery, connection);


                var pmtIdLogin = command.CreateParameter();
                pmtIdLogin.ParameterName = "@idLogin";
                pmtIdLogin.DbType = DbType.Int32;
                pmtIdLogin.Value = _mdlLogin.idLogin;
                command.Parameters.Add(pmtIdLogin);

                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Login excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
