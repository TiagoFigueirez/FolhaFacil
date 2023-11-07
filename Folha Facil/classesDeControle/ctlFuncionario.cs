using projeto.Modelo;
using Projeto.Modelo;
using Projeto_Controle;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace classesDeControle
{
    public class ctlFuncionario
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_pim;Integrated Security=True";

        public static bool incluirFuncionario(mdlFuncionario _mdlFuncionario)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                string query = "INSERT INTO Funcionario (nome, cpf, rg, matricula, departamento, cargo, salarioHora, carteiraTrabalho, pis, dataAdmissao, cargaHorariaSemanal, dataNascimento, ativo, telefone, endereco, email, senha, idEmpresa) VALUES (@NomeFuncionario, @Cpf, @Rg, @Matricula, @Departamento, @Cargo, @salarioHora, @CarteiraTrabalho, @Pis, @DataAdmissao, @CargaHorariaSemanal, @DataNascimento, @ativo, @Telefone, @Endereco, @Email, @Senha, (SELECT idEmpresa FROM Empresa WHERE nome = @NomeEmpresa))";
                SqlCommand cmd = new SqlCommand(query, connection);

                var pmtNome = cmd.CreateParameter();
                pmtNome.ParameterName = "@NomeFuncionario";
                pmtNome.DbType = DbType.String;
                pmtNome.Value = _mdlFuncionario.nome;
                cmd.Parameters.Add(pmtNome);

                var pmtCpf = cmd.CreateParameter();
                pmtCpf.ParameterName = "@Cpf";
                pmtCpf.DbType = DbType.String;
                pmtCpf.Value = _mdlFuncionario.cpf;
                cmd.Parameters.Add(pmtCpf);

                var pmtRg = cmd.CreateParameter();
                pmtRg.ParameterName = "@Rg";
                pmtRg.DbType = DbType.String;
                pmtRg.Value = _mdlFuncionario.rg;
                cmd.Parameters.Add(pmtRg);

                var pmtMatricula = cmd.CreateParameter();
                pmtMatricula.ParameterName = "@Matricula";
                pmtMatricula.DbType = DbType.Int32;
                pmtMatricula.Value = _mdlFuncionario.matricula;
                cmd.Parameters.Add(pmtMatricula);

                var pmtDepartamento = cmd.CreateParameter();
                pmtDepartamento.ParameterName = "@Departamento";
                pmtDepartamento.DbType = DbType.String;
                pmtDepartamento.Value = _mdlFuncionario.departamento;
                cmd.Parameters.Add(pmtDepartamento);

                var pmtCargo = cmd.CreateParameter();
                pmtCargo.ParameterName = "@Cargo";
                pmtCargo.DbType = DbType.String;
                pmtCargo.Value = _mdlFuncionario.cargo;
                cmd.Parameters.Add(pmtCargo);

                var pmtSalarioBruto = cmd.CreateParameter();
                pmtSalarioBruto.ParameterName = "@salarioHora";
                pmtSalarioBruto.DbType = DbType.Double;
                pmtSalarioBruto.Value = _mdlFuncionario.salarioHora;
                cmd.Parameters.Add(pmtSalarioBruto);

                var pmtCarteiraTrabalho = cmd.CreateParameter();
                pmtCarteiraTrabalho.ParameterName = "@CarteiraTrabalho";
                pmtCarteiraTrabalho.DbType = DbType.String;
                pmtCarteiraTrabalho.Value = _mdlFuncionario.carteiraTrabalho;
                cmd.Parameters.Add(pmtCarteiraTrabalho);

                var pmtPis = cmd.CreateParameter();
                pmtPis.ParameterName = "@Pis";
                pmtPis.DbType = DbType.String;
                pmtPis.Value = _mdlFuncionario.pis;
                cmd.Parameters.Add(pmtPis);

                var pmtDataAdmissao = cmd.CreateParameter();
                pmtDataAdmissao.ParameterName = "@DataAdmissao";
                pmtDataAdmissao.DbType = DbType.DateTime;
                pmtDataAdmissao.Value = _mdlFuncionario.dataAdmissao;
                cmd.Parameters.Add(pmtDataAdmissao);

                var pmtCargaHorariaSemanal = cmd.CreateParameter();
                pmtCargaHorariaSemanal.ParameterName = "@CargaHorariaSemanal";
                pmtCargaHorariaSemanal.DbType = DbType.Int32;
                pmtCargaHorariaSemanal.Value = _mdlFuncionario.cargaHorariaSemanal;
                cmd.Parameters.Add(pmtCargaHorariaSemanal);

                var pmtDataNascimento = cmd.CreateParameter();
                pmtDataNascimento.ParameterName = "@DataNascimento";
                pmtDataNascimento.DbType = DbType.DateTime;
                pmtDataNascimento.Value = _mdlFuncionario.dataNascimento;
                cmd.Parameters.Add(pmtDataNascimento);

                var pmtStatus = cmd.CreateParameter();
                pmtStatus.ParameterName = "@ativo";
                pmtStatus.DbType = DbType.Boolean;
                pmtStatus.Value = _mdlFuncionario.ativo;
                cmd.Parameters.Add(pmtStatus);

                var pmtTelefone = cmd.CreateParameter();
                pmtTelefone.ParameterName = "@Telefone";
                pmtTelefone.DbType = DbType.String;
                pmtTelefone.Value = _mdlFuncionario.telefone;
                cmd.Parameters.Add(pmtTelefone);

                var pmtEndereco = cmd.CreateParameter();
                pmtEndereco.ParameterName = "@Endereco";
                pmtEndereco.DbType = DbType.String;
                pmtEndereco.Value = _mdlFuncionario.endereco;
                cmd.Parameters.Add(pmtEndereco);

                var pmtEmail = cmd.CreateParameter();
                pmtEmail.ParameterName = "@Email";
                pmtEmail.DbType = DbType.String;
                pmtEmail.Value = _mdlFuncionario.email;
                cmd.Parameters.Add(pmtEmail);

                var pmtSenha = cmd.CreateParameter();
                pmtSenha.ParameterName = "@Senha";
                pmtSenha.DbType = DbType.String;
                pmtSenha.Value = _mdlFuncionario.senha;
                cmd.Parameters.Add(pmtSenha);

                var pmtNomeEmpresa = cmd.CreateParameter();
                pmtNomeEmpresa.ParameterName = "@nomeEmpresa";
                pmtNomeEmpresa.DbType = DbType.String;
                pmtNomeEmpresa.Value = _mdlFuncionario.empresa.nome;
                cmd.Parameters.Add(pmtNomeEmpresa);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    connection.Close();
                    MessageBox.Show("Funcionário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    connection.Close();
                    return false;
                }

            }
            catch (Exception e)
            {
                connection.Close();
                MostrarMensagemDeErro("Erro: " + e.Message);
                return false;
            }
        }

        public bool removerFuncionario(mdlFuncionario _mdlFuncionario)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_pim;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                string query = "DELETE FROM Funcionario WHERE idFuncionario = @idFuncionario;";

                SqlCommand command = new SqlCommand(query, connection);

                var pmtIdFuncionario = command.CreateParameter();
                pmtIdFuncionario.ParameterName = "@idFuncionario";
                pmtIdFuncionario.DbType = DbType.Int32;
                pmtIdFuncionario.Value = _mdlFuncionario.idFuncionario;
                command.Parameters.Add(pmtIdFuncionario);

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


        public bool EditarFuncionario(mdlFuncionario _mdlFuncionario)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_pim;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                string query = "UPDATE Funcionario SET nome = @NomeFuncionario, cpf = @Cpf, rg = @Rg, matricula = @Matricula, departamento = @Departamento, cargo = @Cargo, salarioHora = @salarioHora, carteiraTrabalho = @CarteiraTrabalho, pis = @Pis, dataAdmissao = @DataAdmissao, cargaHorariaSemanal = @CargaHorariaSemanal, dataNascimento = @DataNascimento, ativo = @ativo, telefone = @Telefone, endereco = @Endereco,  email =  @Email, senha = @Senha, idEmpresa = (SELECT idEmpresa FROM Empresa WHERE nome = @NomeEmpresa) WHERE idFuncionario = @IdFuncionario";

                SqlCommand cmd = new SqlCommand(query, connection);

                var pmtIdFuncionario = cmd.CreateParameter();
                pmtIdFuncionario.ParameterName = "@IdFuncionario";
                pmtIdFuncionario.DbType = DbType.Int32;
                pmtIdFuncionario.Value = _mdlFuncionario.idFuncionario;
                cmd.Parameters.Add(pmtIdFuncionario);

                var pmtNome = cmd.CreateParameter();
                pmtNome.ParameterName = "@NomeFuncionario";
                pmtNome.DbType = DbType.String;
                pmtNome.Value = _mdlFuncionario.nome;
                cmd.Parameters.Add(pmtNome);

                var pmtCpf = cmd.CreateParameter();
                pmtCpf.ParameterName = "@Cpf";
                pmtCpf.DbType = DbType.String;
                pmtCpf.Value = _mdlFuncionario.cpf;
                cmd.Parameters.Add(pmtCpf);

                var pmtRg = cmd.CreateParameter();
                pmtRg.ParameterName = "@Rg";
                pmtRg.DbType = DbType.String;
                pmtRg.Value = _mdlFuncionario.rg;
                cmd.Parameters.Add(pmtRg);

                var pmtMatricula = cmd.CreateParameter();
                pmtMatricula.ParameterName = "@Matricula";
                pmtMatricula.DbType = DbType.Int32;
                pmtMatricula.Value = _mdlFuncionario.matricula;
                cmd.Parameters.Add(pmtMatricula);

                var pmtDepartamento = cmd.CreateParameter();
                pmtDepartamento.ParameterName = "@Departamento";
                pmtDepartamento.DbType = DbType.String;
                pmtDepartamento.Value = _mdlFuncionario.departamento;
                cmd.Parameters.Add(pmtDepartamento);

                var pmtCargo = cmd.CreateParameter();
                pmtCargo.ParameterName = "@Cargo";
                pmtCargo.DbType = DbType.String;
                pmtCargo.Value = _mdlFuncionario.cargo;
                cmd.Parameters.Add(pmtCargo);

                var pmtSalarioBruto = cmd.CreateParameter();
                pmtSalarioBruto.ParameterName = "@salarioHora";
                pmtSalarioBruto.DbType = DbType.Double;
                pmtSalarioBruto.Value = _mdlFuncionario.salarioHora;
                cmd.Parameters.Add(pmtSalarioBruto);

                var pmtCarteiraTrabalho = cmd.CreateParameter();
                pmtCarteiraTrabalho.ParameterName = "@CarteiraTrabalho";
                pmtCarteiraTrabalho.DbType = DbType.String;
                pmtCarteiraTrabalho.Value = _mdlFuncionario.carteiraTrabalho;
                cmd.Parameters.Add(pmtCarteiraTrabalho);

                var pmtPis = cmd.CreateParameter();
                pmtPis.ParameterName = "@Pis";
                pmtPis.DbType = DbType.String;
                pmtPis.Value = _mdlFuncionario.pis;
                cmd.Parameters.Add(pmtPis);

                var pmtDataAdmissao = cmd.CreateParameter();
                pmtDataAdmissao.ParameterName = "@DataAdmissao";
                pmtDataAdmissao.DbType = DbType.DateTime;
                pmtDataAdmissao.Value = _mdlFuncionario.dataAdmissao;
                cmd.Parameters.Add(pmtDataAdmissao);

                var pmtCargaHorariaSemanal = cmd.CreateParameter();
                pmtCargaHorariaSemanal.ParameterName = "@CargaHorariaSemanal";
                pmtCargaHorariaSemanal.DbType = DbType.Int32;
                pmtCargaHorariaSemanal.Value = _mdlFuncionario.cargaHorariaSemanal;
                cmd.Parameters.Add(pmtCargaHorariaSemanal);

                var pmtDataNascimento = cmd.CreateParameter();
                pmtDataNascimento.ParameterName = "@DataNascimento";
                pmtDataNascimento.DbType = DbType.DateTime;
                pmtDataNascimento.Value = _mdlFuncionario.dataNascimento;
                cmd.Parameters.Add(pmtDataNascimento);

                var pmtStatus = cmd.CreateParameter();
                pmtStatus.ParameterName = "@ativo";
                pmtStatus.DbType = DbType.Boolean;
                pmtStatus.Value = _mdlFuncionario.ativo;
                cmd.Parameters.Add(pmtStatus);

                var pmtTelefone = cmd.CreateParameter();
                pmtTelefone.ParameterName = "@Telefone";
                pmtTelefone.DbType = DbType.String;
                pmtTelefone.Value = _mdlFuncionario.telefone;
                cmd.Parameters.Add(pmtTelefone);

                var pmtEndereco = cmd.CreateParameter();
                pmtEndereco.ParameterName = "@Endereco";
                pmtEndereco.DbType = DbType.String;
                pmtEndereco.Value = _mdlFuncionario.endereco;
                cmd.Parameters.Add(pmtEndereco);

                var pmtEmail = cmd.CreateParameter();
                pmtEmail.ParameterName = "@Email";
                pmtEmail.DbType = DbType.String;
                pmtEmail.Value = _mdlFuncionario.email;
                cmd.Parameters.Add(pmtEmail);

                var pmtSenha = cmd.CreateParameter();
                pmtSenha.ParameterName = "@Senha";
                pmtSenha.DbType = DbType.String;
                pmtSenha.Value = _mdlFuncionario.senha;
                cmd.Parameters.Add(pmtSenha);

                var pmtNomeEmpresa = cmd.CreateParameter();
                pmtNomeEmpresa.ParameterName = "@NomeEmpresa";
                pmtNomeEmpresa.DbType = DbType.String;
                pmtNomeEmpresa.Value = _mdlFuncionario.empresa.nome;
                cmd.Parameters.Add(pmtNomeEmpresa); ;

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    MostrarMensagemDeErro("Erro");
                    return false;
                }
            }
            catch (Exception e)
            {
                MostrarMensagemDeErro("Erro ao conectar ao banco de dados: " + e.Message);
                return false;
            }
        }

        public static bool verificarLoginFuncionario(mdlFuncionario _mdlFuncionario, out mdlFuncionario funcionarioAcessado)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            funcionarioAcessado = new mdlFuncionario();

            try
            {
                connection.Open();

                string sqlQuery = "SELECT * FROM Funcionario where email = @email AND senha COLLATE Latin1_General_BIN = @senha";

                SqlCommand command  = new SqlCommand(sqlQuery, connection);

                var pmtEmail = command.CreateParameter();
                pmtEmail.ParameterName = "@email";
                pmtEmail.DbType = DbType.String;
                pmtEmail.Value = _mdlFuncionario.email;
                command.Parameters.Add(pmtEmail);

                var pmtSenha = command.CreateParameter();
                pmtSenha.ParameterName = "@senha";
                pmtSenha.DbType = DbType.String;
                pmtSenha.Value = _mdlFuncionario.senha;
                command.Parameters.Add(pmtSenha);

                SqlDataReader cursor = command.ExecuteReader();

                if (cursor.HasRows) 
                {
                    if(cursor.Read())
                    {
                        funcionarioAcessado.idFuncionario = Convert.ToInt32(cursor["idFuncionario"]);
                        funcionarioAcessado.nome = cursor["nome"].ToString();
                        return true;
                    }

                }
                
               
                    return false;
                                 

            }catch(Exception ex)
            {
                connection.Close();
                throw new Exception("Erro:"+ ex.Message);
            }
        }

        public static List<mdlFuncionario> PesquisarFuncionarioPeloNome(mdlFuncionario _mdlFuncionario)
        {

            List<mdlFuncionario> listFuncionario = new List<mdlFuncionario>();

            string[] nomeSeparado = _mdlFuncionario.nome.Split();
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

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                string sqlQuery = "";
                if (parametrosNome.Length > 0)
                {
                    sqlQuery = $"SELECT * FROM Funcionario WHERE {parametrosNome} AND idEmpresa = (SELECT idEmpresa FROM Empresa WHERE nome = @nomeEmpresa)";
                }
                else
                {
                    sqlQuery = $"SELECT * FROM Funcionario WHERE idEmpresa = (SELECT idEmpresa FROM Empresa WHERE nome = @nomeEmpresa)";
                }

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                var pmtNomeEmpresa = command.CreateParameter();
                pmtNomeEmpresa.ParameterName = "@nomeEmpresa";
                pmtNomeEmpresa.DbType = DbType.String;
                pmtNomeEmpresa.Value = _mdlFuncionario.empresa.nome;
                command.Parameters.Add(pmtNomeEmpresa);

                SqlDataReader cursor = command.ExecuteReader();

                if (cursor.HasRows)
                {
                    while (cursor.Read())
                    {
                        mdlFuncionario funcionario = new mdlFuncionario();
                        funcionario.idFuncionario = Convert.ToInt32(cursor["idFuncionario"]);
                        funcionario.nome = cursor["nome"].ToString();
                        funcionario.cpf = cursor["cpf"].ToString();
                        funcionario.rg = cursor["rg"].ToString();
                        funcionario.matricula = Convert.ToInt32(cursor["matricula"]);
                        funcionario.departamento = cursor["departamento"].ToString();
                        funcionario.cargo = cursor["cargo"].ToString();
                        funcionario.salarioHora = Convert.ToDouble(cursor["salarioHora"]);
                        funcionario.carteiraTrabalho = cursor["carteiraTrabalho"].ToString();
                        funcionario.pis = cursor["pis"].ToString();
                        funcionario.dataAdmissao = Convert.ToDateTime(cursor["dataAdmissao"]);
                        funcionario.cargaHorariaSemanal = Convert.ToInt32(cursor["cargaHorariaSemanal"]);
                        funcionario.dataNascimento = Convert.ToDateTime(cursor["dataNascimento"]);
                        funcionario.ativo = Convert.ToBoolean(cursor["ativo"]);
                        funcionario.telefone = cursor["telefone"].ToString();
                        funcionario.endereco = cursor["endereco"].ToString();
                        funcionario.email = cursor["email"].ToString();
                        funcionario.senha = cursor["senha"].ToString();
                        mdlEmpresa mdlEmpresa = new mdlEmpresa();
                        mdlEmpresa.idEmpresa = Convert.ToInt32(cursor["idEmpresa"]);
                        funcionario.empresa = ctlEmpresa.BuscarEmpresaPeloID(mdlEmpresa);
                        listFuncionario.Add(funcionario);
                    }
                }

                return listFuncionario;

            }
            catch (Exception e)
            {
                MostrarMensagemDeErro("Erro ao conectar ao banco de dados: " + e.Message);
                return listFuncionario;
            }
        }

        public static List<mdlFuncionario> PesquisarFuncionarioPeloCPF(mdlFuncionario _mdlFuncionario)
        {
            List<mdlFuncionario> listFuncionario = new List<mdlFuncionario>();

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                string sqlQuery = "SELECT * FROM Funcionario WHERE cpf LIKE @cpf AND idEmpresa = (SELECT idEmpresa FROM Empresa WHERE nome = @nomeEmpresa) ";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                var pmtCPF = command.CreateParameter();
                pmtCPF.ParameterName = "@cpf";
                pmtCPF.DbType = DbType.String;
                pmtCPF.Value = $"{_mdlFuncionario.cpf}%";
                command.Parameters.Add(pmtCPF);

                var pmtNomeEmpresa = command.CreateParameter();
                pmtNomeEmpresa.ParameterName = "@nomeEmpresa";
                pmtNomeEmpresa.DbType = DbType.String;
                pmtNomeEmpresa.Value = _mdlFuncionario.empresa.nome;
                command.Parameters.Add(pmtNomeEmpresa);

                SqlDataReader cursor = command.ExecuteReader();

                if (cursor.HasRows)
                {
                    while (cursor.Read())
                    {
                        mdlFuncionario funcionario = new mdlFuncionario();
                        funcionario.idFuncionario = Convert.ToInt32(cursor["idFuncionario"]);
                        funcionario.nome = cursor["nome"].ToString();
                        funcionario.cpf = cursor["cpf"].ToString();
                        funcionario.rg = cursor["rg"].ToString();
                        funcionario.matricula = Convert.ToInt32(cursor["matricula"]);
                        funcionario.departamento = cursor["departamento"].ToString();
                        funcionario.cargo = cursor["cargo"].ToString();
                        funcionario.salarioHora = Convert.ToDouble(cursor["salarioHora"]);
                        funcionario.carteiraTrabalho = cursor["carteiraTrabalho"].ToString();
                        funcionario.pis = cursor["pis"].ToString();
                        funcionario.dataAdmissao = Convert.ToDateTime(cursor["dataAdmissao"]);
                        funcionario.cargaHorariaSemanal = Convert.ToInt32(cursor["cargaHorariaSemanal"]);
                        funcionario.dataNascimento = Convert.ToDateTime(cursor["dataNascimento"]);
                        funcionario.ativo = Convert.ToBoolean(cursor["ativo"]);
                        funcionario.telefone = cursor["telefone"].ToString();
                        funcionario.endereco = cursor["endereco"].ToString();
                        funcionario.email = cursor["email"].ToString();
                        funcionario.senha = cursor["senha"].ToString();
                        mdlEmpresa mdlEmpresa = new mdlEmpresa();
                        mdlEmpresa.idEmpresa = Convert.ToInt32(cursor["idEmpresa"]);
                        funcionario.empresa = ctlEmpresa.BuscarEmpresaPeloID(mdlEmpresa);
                        listFuncionario.Add(funcionario);
                    }
                }

                return listFuncionario;

            }
            catch (Exception e)
            {
                MostrarMensagemDeErro("Erro ao conectar ao banco de dados: " + e.Message);
                return listFuncionario;
            }
        }

        public static List<mdlFuncionario> PesquisarFuncionarioPeloRG(mdlFuncionario _mdlFuncionario)
        {
            List<mdlFuncionario> listFuncionario = new List<mdlFuncionario>();

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                string sqlQuery = "SELECT * FROM Funcionario WHERE rg LIKE @rg AND idEmpresa = (SELECT idEmpresa FROM Empresa WHERE nome = @nomeEmpresa) ";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                var pmtRG = command.CreateParameter();
                pmtRG.ParameterName = "@rg";
                pmtRG.DbType = DbType.String;
                pmtRG.Value = $"{_mdlFuncionario.rg}%";
                command.Parameters.Add(pmtRG);

                var pmtNomeEmpresa = command.CreateParameter();
                pmtNomeEmpresa.ParameterName = "@nomeEmpresa";
                pmtNomeEmpresa.DbType = DbType.String;
                pmtNomeEmpresa.Value = _mdlFuncionario.empresa.nome;
                command.Parameters.Add(pmtNomeEmpresa);

                SqlDataReader cursor = command.ExecuteReader();

                if (cursor.HasRows)
                {
                    while (cursor.Read())
                    {
                        mdlFuncionario funcionario = new mdlFuncionario();
                        funcionario.idFuncionario = Convert.ToInt32(cursor["idFuncionario"]);
                        funcionario.nome = cursor["nome"].ToString();
                        funcionario.cpf = cursor["cpf"].ToString();
                        funcionario.rg = cursor["rg"].ToString();
                        funcionario.matricula = Convert.ToInt32(cursor["matricula"]);
                        funcionario.departamento = cursor["departamento"].ToString();
                        funcionario.cargo = cursor["cargo"].ToString();
                        funcionario.salarioHora = Convert.ToDouble(cursor["salarioHora"]);
                        funcionario.carteiraTrabalho = cursor["carteiraTrabalho"].ToString();
                        funcionario.pis = cursor["pis"].ToString();
                        funcionario.dataAdmissao = Convert.ToDateTime(cursor["dataAdmissao"]);
                        funcionario.cargaHorariaSemanal = Convert.ToInt32(cursor["cargaHorariaSemanal"]);
                        funcionario.dataNascimento = Convert.ToDateTime(cursor["dataNascimento"]);
                        funcionario.ativo = Convert.ToBoolean(cursor["ativo"]);
                        funcionario.telefone = cursor["telefone"].ToString();
                        funcionario.endereco = cursor["endereco"].ToString();
                        funcionario.email = cursor["email"].ToString();
                        funcionario.senha = cursor["senha"].ToString();
                        mdlEmpresa mdlEmpresa = new mdlEmpresa();
                        mdlEmpresa.idEmpresa = Convert.ToInt32(cursor["idEmpresa"]);
                        funcionario.empresa = ctlEmpresa.BuscarEmpresaPeloID(mdlEmpresa);
                        listFuncionario.Add(funcionario);
                    }
                }

                return listFuncionario;

            }
            catch (Exception e)
            {
                MostrarMensagemDeErro("Erro ao conectar ao banco de dados: " + e.Message);
                return listFuncionario;
            }
        }

        public static List<mdlFuncionario> PesquisarFuncionarioPelaMatricula(mdlFuncionario _mdlFuncionario)
        {
            List<mdlFuncionario> listFuncionario = new List<mdlFuncionario>();

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                string sqlQuery = "SELECT * FROM Funcionario WHERE matricula = @matricula AND idEmpresa = (SELECT idEmpresa FROM Empresa WHERE nome = @nomeEmpresa) ";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                var pmtMatricula = command.CreateParameter();
                pmtMatricula.ParameterName = "@matricula";
                pmtMatricula.DbType = DbType.Int32;
                pmtMatricula.Value = _mdlFuncionario.matricula;
                command.Parameters.Add(pmtMatricula);

                var pmtNomeEmpresa = command.CreateParameter();
                pmtNomeEmpresa.ParameterName = "@nomeEmpresa";
                pmtNomeEmpresa.DbType = DbType.String;
                pmtNomeEmpresa.Value = _mdlFuncionario.empresa.nome;
                command.Parameters.Add(pmtNomeEmpresa);

                SqlDataReader cursor = command.ExecuteReader();

                if (cursor.HasRows)
                {
                    while (cursor.Read())
                    {
                        mdlFuncionario funcionario = new mdlFuncionario();
                        funcionario.idFuncionario = Convert.ToInt32(cursor["idFuncionario"]);
                        funcionario.nome = cursor["nome"].ToString();
                        funcionario.cpf = cursor["cpf"].ToString();
                        funcionario.rg = cursor["rg"].ToString();
                        funcionario.matricula = Convert.ToInt32(cursor["matricula"]);
                        funcionario.departamento = cursor["departamento"].ToString();
                        funcionario.cargo = cursor["cargo"].ToString();
                        funcionario.salarioHora = Convert.ToDouble(cursor["salarioHora"]);
                        funcionario.carteiraTrabalho = cursor["carteiraTrabalho"].ToString();
                        funcionario.pis = cursor["pis"].ToString();
                        funcionario.dataAdmissao = Convert.ToDateTime(cursor["dataAdmissao"]);
                        funcionario.cargaHorariaSemanal = Convert.ToInt32(cursor["cargaHorariaSemanal"]);
                        funcionario.dataNascimento = Convert.ToDateTime(cursor["dataNascimento"]);
                        funcionario.ativo = Convert.ToBoolean(cursor["ativo"]);
                        funcionario.telefone = cursor["telefone"].ToString();
                        funcionario.endereco = cursor["endereco"].ToString();
                        funcionario.email = cursor["email"].ToString();
                        funcionario.senha = cursor["senha"].ToString();
                        mdlEmpresa _mdlEmpresa = new mdlEmpresa();
                        _mdlEmpresa.idEmpresa = Convert.ToInt32(cursor["idEmpresa"]);
                        funcionario.empresa = ctlEmpresa.BuscarEmpresaPeloID(_mdlEmpresa);
                        listFuncionario.Add(funcionario);
                    }
                }

                return listFuncionario;

            }
            catch (Exception e)
            {
                MostrarMensagemDeErro("Erro ao conectar ao banco de dados: " + e.Message);
                return listFuncionario;
            }
        }

        public static mdlFuncionario BuscarFuncionarioPeloID(mdlFuncionario _mdlFuncionario)
        {
            mdlFuncionario funcionario = new mdlFuncionario();

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                string sqlQuery = "SELECT * FROM Funcionario WHERE idFuncionario = @idFuncionario";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                var pmtIdFuncionario = command.CreateParameter();
                pmtIdFuncionario.ParameterName = "@idFuncionario";
                pmtIdFuncionario.DbType = DbType.Int32;
                pmtIdFuncionario.Value = _mdlFuncionario.idFuncionario;
                command.Parameters.Add(pmtIdFuncionario);

                SqlDataReader cursor = command.ExecuteReader();

                if (cursor.HasRows)
                {
                    if (cursor.Read())
                    {
                        funcionario.idFuncionario = Convert.ToInt32(cursor["idFuncionario"]);
                        funcionario.nome = cursor["nome"].ToString();
                        funcionario.cpf = cursor["cpf"].ToString();
                        funcionario.rg = cursor["rg"].ToString();
                        funcionario.matricula = Convert.ToInt32(cursor["matricula"]);
                        funcionario.departamento = cursor["departamento"].ToString();
                        funcionario.cargo = cursor["cargo"].ToString();
                        funcionario.salarioHora = Convert.ToDouble(cursor["salarioHora"]);
                        funcionario.carteiraTrabalho = cursor["carteiraTrabalho"].ToString();
                        funcionario.pis = cursor["pis"].ToString();
                        funcionario.dataAdmissao = Convert.ToDateTime(cursor["dataAdmissao"]);
                        funcionario.cargaHorariaSemanal = Convert.ToInt32(cursor["cargaHorariaSemanal"]);
                        funcionario.dataNascimento = Convert.ToDateTime(cursor["dataNascimento"]);
                        funcionario.ativo = Convert.ToBoolean(cursor["ativo"]);
                        funcionario.telefone = cursor["telefone"].ToString();
                        funcionario.endereco = cursor["endereco"].ToString();
                        funcionario.email = cursor["email"].ToString();
                        funcionario.senha = cursor["senha"].ToString();
                        mdlEmpresa mdlEmpresa = new mdlEmpresa();
                        mdlEmpresa.idEmpresa = Convert.ToInt32(cursor["idEmpresa"]);
                        funcionario.empresa = ctlEmpresa.BuscarEmpresaPeloID(mdlEmpresa);
                    }
                }

                return funcionario;

            }
            catch (Exception e)
            {
                MostrarMensagemDeErro("Erro ao conectar ao banco de dados: " + e.Message);
                return funcionario;
            }
        }

        public static List<string> ListarFuncionarioPonto(mdlFuncionario _mdlFuncionario)
        {
            List<string> listFuncionario = new List<string>();

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                string sqlQuery = "SELECT * FROM Funcionario WHERE idEmpresa = (SELECT idEmpresa FROM Empresa WHERE nome = @nomeEmpresa) ";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

               
                var pmtNomeEmpresa = command.CreateParameter();
                pmtNomeEmpresa.ParameterName = "@nomeEmpresa";
                pmtNomeEmpresa.DbType = DbType.String;
                pmtNomeEmpresa.Value = _mdlFuncionario.empresa.nome;
                command.Parameters.Add(pmtNomeEmpresa);

                SqlDataReader cursor = command.ExecuteReader();

                if (cursor.HasRows)
                {
                    while (cursor.Read())
                    {
                        string funcionario = cursor["matricula"].ToString() + " - " + cursor["nome"].ToString();
                        listFuncionario.Add(funcionario);
                    }
                }

                return listFuncionario;

            }
            catch (Exception e)
            {
                MostrarMensagemDeErro("Erro ao conectar ao banco de dados: " + e.Message);
                return listFuncionario;
            }
        }

        private static void MostrarMensagemDeErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
