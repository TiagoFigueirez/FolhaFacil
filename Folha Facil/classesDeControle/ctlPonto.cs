using Projeto.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classesDeControle
{
    public class ctlPonto
    {

        //metodos de verificar ponto
        public static bool validarEntrada(mdlFuncionario _mdlFuncionario)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_pim;Integrated Security=True";
            SqlConnection connectionBd = new SqlConnection(connectionString);

            try
            {
                connectionBd.Open();

                string sqlQuery = "SELECT * FROM Ponto WHERE idFuncionario = @idFuncionario AND data = CAST(GETDATE() AS DATE) AND entrada IS NOT NULL ";

                SqlCommand command = new SqlCommand(sqlQuery, connectionBd);

                var pmtIdFuncionario = command.CreateParameter();
                pmtIdFuncionario.ParameterName = "@idFuncionario";
                pmtIdFuncionario.DbType = DbType.Int32;
                pmtIdFuncionario.Value = _mdlFuncionario.idFuncionario;
                command.Parameters.Add( pmtIdFuncionario );

                SqlDataReader cursor = command.ExecuteReader();

                if(!cursor.HasRows)
                {
                    return true;
                }

                return false;

            }
            catch (Exception ex)
            {
                throw new Exception ("Erro ao Executar" + ex.Message);
                
                
            }

        }

        public static bool validarIda(mdlFuncionario _mdlFuncionario)
        {
            string conectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_pim;Integrated Security=True";
            SqlConnection conectionBd = new SqlConnection(conectionString);

            try
            {
                conectionBd.Open();

                string sqlQuey = "SELECT * FROM Ponto WHERE idFuncionario = @idFuncionario AND data = CAST(GETDATE() AS DATE) AND ida IS NULL";

                SqlCommand command = new SqlCommand( sqlQuey, conectionBd);

                var pmtIdFuncionario = command.CreateParameter();
                pmtIdFuncionario.ParameterName = "@idFuncionario";
                pmtIdFuncionario.DbType = DbType.Int32;
                pmtIdFuncionario.Value = _mdlFuncionario.idFuncionario;
                command.Parameters.Add(pmtIdFuncionario);

                SqlDataReader cursor = command.ExecuteReader();

                if(cursor.HasRows)
                {
                    return true;
                }

                return false;
            }catch(Exception ex)
            {
                throw new Exception("Erro ao Executar" + ex.Message);
            }
        }

        public static bool validarVolta(mdlFuncionario _mdlFuncionario)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_pim;Integrated Security=True";

            SqlConnection connectionBd = new SqlConnection(connectionString);

            try
            {
                connectionBd.Open();

                string sqlQuery = "SELECT * FROM Ponto WHERE idFuncionario = @idFuncionario AND data = CAST(GETDATE() AS DATE) AND volta IS NULL";

                SqlCommand command = new SqlCommand( sqlQuery, connectionBd);

                var pmtIdFuncionario = command.CreateParameter();
                pmtIdFuncionario.ParameterName = "@idFuncionario";
                pmtIdFuncionario .DbType = DbType.Int32;
                pmtIdFuncionario.Value = _mdlFuncionario.idFuncionario;
                command.Parameters.Add(pmtIdFuncionario );

                SqlDataReader cursor = command.ExecuteReader();

                if(cursor.HasRows)
                {
                    return true;
                }

                return false;

            }
            catch (Exception ex) 
            {
                throw new Exception("Erro ao Executar" + ex.Message);
            }
        }

        public static bool validarSaida(mdlFuncionario _mdlFuncionario)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_pim;Integrated Security=True";

            SqlConnection connectionBd = new SqlConnection(connectionString);

            try
            {
                connectionBd.Open();

                string sqlQuery = "SELECT * FROM Ponto WHERE idFuncionario = @idFuncionario AND data = CAST(GETDATE() AS DATE) AND saida IS NULL";

                SqlCommand command = new SqlCommand(sqlQuery, connectionBd);

                var pmtIdFuncionario = command.CreateParameter();
                pmtIdFuncionario.ParameterName = "@idFuncionario";
                pmtIdFuncionario.DbType = DbType.Int32;
                pmtIdFuncionario.Value = _mdlFuncionario.idFuncionario;
                command.Parameters.Add(pmtIdFuncionario);

                SqlDataReader cursor = command.ExecuteReader();

                if (cursor.HasRows)
                {
                    return true;
                }

                return false;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Executar" + ex.Message);
            }
        }

        //meotodo de incluir ponto

        public static bool incluirPonto(mdlFuncionario _mdlFuncionario)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_pim;Integrated Security=True";
            SqlConnection connectionBd = new SqlConnection( connectionString);

            try
            {
                connectionBd.Open();

                if(validarEntrada(_mdlFuncionario))
                {
                    string sqlQuery = "INSERT INTO Ponto(data, entrada, idFuncionario) VALUES (CAST(GETDATE() AS DATE), CAST(GETDATE() AS TIME), @idFuncionario)";

                    SqlCommand command = new SqlCommand(sqlQuery, connectionBd);

                    var pmtIdFuncionario = command.CreateParameter();
                    pmtIdFuncionario.ParameterName = "@idFuncionario";
                    pmtIdFuncionario.DbType = DbType.Int32;
                    pmtIdFuncionario.Value = _mdlFuncionario.idFuncionario;
                    command.Parameters.Add(pmtIdFuncionario);

                    if(command.ExecuteNonQuery() > 0)
                    {
                        connectionBd.Close();
                        return true;
                    }
                    else
                    {
                        connectionBd.Close();
                        return false;
                    }
                    
                }else if (validarIda(_mdlFuncionario))
                {
                    string sqlQuery = "UPDATE Ponto SET ida = CAST(GETDATE() AS TIME)  WHERE idFuncionario = @idFuncionario AND data = CAST(GETDATE() AS DATE) ";

                    SqlCommand command = new SqlCommand(sqlQuery, connectionBd);

                    var pmtIdFuncionario = command.CreateParameter();
                    pmtIdFuncionario.ParameterName = "@idFuncionario";
                    pmtIdFuncionario.DbType = DbType.Int32;
                    pmtIdFuncionario.Value = _mdlFuncionario.idFuncionario;
                    command.Parameters.Add(pmtIdFuncionario);

                    if(command.ExecuteNonQuery() > 0)
                    {
                        connectionBd.Close();
                        return true;
                    }else 
                    {
                        connectionBd.Close(); 
                        
                        return false; 
                    }
                }else if(validarVolta(_mdlFuncionario))
                {
                    string sqlQuery = "UPDATE Ponto SET volta = CAST(GETDATE() AS TIME) WHERE idFuncionario = @idFuncionario AND data = CAST(GETDATE() AS DATE)";

                    SqlCommand command = new SqlCommand( sqlQuery, connectionBd);

                    var pmtIdFuncionario = command.CreateParameter() ;
                    pmtIdFuncionario.ParameterName = "@idFuncionario";
                    pmtIdFuncionario.DbType = DbType.Int32;
                    pmtIdFuncionario.Value = _mdlFuncionario.idFuncionario;
                    command.Parameters.Add(pmtIdFuncionario);

                    if(command.ExecuteNonQuery() > 0 )
                    {
                        connectionBd.Close();
                        return true;
                    }
                    else
                    {
                        connectionBd.Close();
                        return false;
                    }
                }else if (validarSaida(_mdlFuncionario))
                {
                    string sqlQuery = "UPDATE Ponto SET saida = CAST(GETDATE() AS TIME) WHERE idFuncionario = @idFuncionario AND data = CAST(GETDATE() AS DATE)";

                    SqlCommand command = new SqlCommand(sqlQuery, connectionBd);

                    var pmtIdFuncionario = command.CreateParameter();
                    pmtIdFuncionario.ParameterName = "@idFuncionario";
                    pmtIdFuncionario.DbType = DbType.Int32;
                    pmtIdFuncionario.Value = _mdlFuncionario.idFuncionario;
                    command.Parameters.Add(pmtIdFuncionario);

                    if(command.ExecuteNonQuery() > 0)
                    {
                        connectionBd.Close();
                        return true;
                    }
                    else
                    {
                        connectionBd.Close();
                    }
                }

                return false;
                

            }catch (Exception ex)
            {
                throw new Exception("Error ao executar" + ex.Message);
            }
        }
        
        public static List<mdlPonto> carregarTabelaPonto(mdlFuncionario _mdlFuncionario)
        {

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_pim;Integrated Security=True";

            SqlConnection connctionBd = new SqlConnection(connectionString);
            List<mdlPonto> listPonto = new List<mdlPonto>();

            try
            {
                connctionBd.Open();

                string sqlQuery = "SELECT TOP 5 * FROM Ponto WHERE idFuncionario = @idFuncionario ORDER BY data DESC";

                SqlCommand command = new SqlCommand( sqlQuery, connctionBd);

                var pmtIdFuncionario = command.CreateParameter();
                pmtIdFuncionario.ParameterName = "@idFuncionario";
                pmtIdFuncionario.DbType = DbType.Int32;
                pmtIdFuncionario.Value = _mdlFuncionario.idFuncionario;
                command.Parameters.Add (pmtIdFuncionario);

                SqlDataReader cursor = command.ExecuteReader();

                if(cursor.HasRows)
                {
                    while (cursor.Read())
                    {
                        
                        mdlPonto ponto = new mdlPonto();
                        ponto.data = Convert.ToDateTime(cursor["data"]);

                        if (!cursor.IsDBNull(cursor.GetOrdinal("entrada")))
                        {
                            TimeSpan horarioEntrada = (TimeSpan)cursor["entrada"];
                            ponto.entrada = new DateTime(ponto.data.Year, ponto.data.Month, ponto.data.Day, horarioEntrada.Hours, horarioEntrada.Minutes, horarioEntrada.Seconds);
                        } else
                        {
                            ponto.entrada = new DateTime(ponto.data.Year, ponto.data.Month, ponto.data.Day, 0, 0, 0);
                        }

                        if (!cursor.IsDBNull(cursor.GetOrdinal("ida")))
                        {
                            TimeSpan horarioIda = (TimeSpan)cursor["ida"];
                            ponto.ida = new DateTime(ponto.data.Year, ponto.data.Month, ponto.data.Day, horarioIda.Hours, horarioIda.Minutes, horarioIda.Seconds);
                        } else
                        {
                            ponto.ida = new DateTime(ponto.data.Year, ponto.data.Month, ponto.data.Day, 0, 0, 0);
                        }

                        if (!cursor.IsDBNull(cursor.GetOrdinal("volta")))
                        {
                            TimeSpan horarioVolta = (TimeSpan)cursor["volta"];
                            ponto.volta = new DateTime(ponto.data.Year, ponto.data.Month, ponto.data.Day, horarioVolta.Hours, horarioVolta.Minutes, horarioVolta.Seconds);
                        } else
                        {
                            ponto.volta = new DateTime(ponto.data.Year, ponto.data.Month, ponto.data.Day, 0, 0, 0);
                        }

                        if (!cursor.IsDBNull(cursor.GetOrdinal("saida")))
                        {
                            TimeSpan horarioSaida = (TimeSpan)cursor["saida"];
                            ponto.saida = new DateTime(ponto.data.Year, ponto.data.Month, ponto.data.Day, horarioSaida.Hours, horarioSaida.Minutes, horarioSaida.Seconds);
                        } else
                        {
                            ponto.saida = new DateTime(ponto.data.Year, ponto.data.Month, ponto.data.Day, 0, 0, 0);
                        }
                       
                        listPonto.Add(ponto);
                    }

                   
                }
                return listPonto;                

            }catch (Exception ex) 
            {
                throw new Exception ("Erro ao Carregar" + ex.Message);
            }
            finally
            {
                connctionBd.Close();
            }
        }

        public static double HorasTotaisTrabalhadas(mdlFuncionario _mdlFuncionario, DateTime dataInicial, DateTime dataFinal)
        {

            double total = 0.0;

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_pim;Integrated Security=True";
            SqlConnection connectionBd = new SqlConnection(connectionString);

            try
            {
                connectionBd.Open();

                string sqlQuery = "SELECT SUM(horasTrabalhadas) AS total FROM Ponto WHERE idFuncionario = @idFuncionario AND data BETWEEN @dataInicial AND @dataFinal";

                SqlCommand command = new SqlCommand(sqlQuery, connectionBd);

                var pmtIdFuncionario = command.CreateParameter();
                pmtIdFuncionario.ParameterName = "@idFuncionario";
                pmtIdFuncionario.DbType = DbType.Int32;
                pmtIdFuncionario.Value = _mdlFuncionario.idFuncionario;
                command.Parameters.Add(pmtIdFuncionario);

                var pmtDataInicial = command.CreateParameter();
                pmtDataInicial.ParameterName = "@dataInicial";
                pmtDataInicial.DbType = DbType.Date;
                pmtDataInicial.Value = dataInicial.ToString("yyyy-MM-dd");
                command.Parameters.Add(pmtDataInicial);

                var pmtDataFinal = command.CreateParameter();
                pmtDataFinal.ParameterName = "@dataFinal";
                pmtDataFinal.DbType = DbType.Date;
                pmtDataFinal.Value = dataFinal.ToString("yyyy-MM-dd");
                command.Parameters.Add(pmtDataFinal);

                SqlDataReader cursor = command.ExecuteReader();

                if (cursor.HasRows)
                {
                    if (cursor.Read())
                    {
                        if (!cursor.IsDBNull(cursor.GetOrdinal("total")))
                        {
                            total = Convert.ToInt32(cursor["total"]);
                        }
                        else
                        {
                            throw new Exception("O funcionário não possui horas trabalhadas entre estas datas!");
                        }

                    }
                }

                return total;

            }
            catch (Exception ex)
            {
                MostrarMensagemDeErro("Erro ao Executar: " + ex.Message);
                return total;
            }

        }

       public static List<mdlPonto> ListarPontosFuncionario(mdlFuncionario _mdlFuncionario)
        {
            List<mdlPonto> _mdlPonto = new List<mdlPonto>();

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_pim;Integrated Security=True";

            SqlConnection ConectionDb = new SqlConnection(connectionString);

            try
            {
                ConectionDb.Open();
                string sqlQuery = "SELECT * FROM Ponto WHERE idFuncionario = (SELECT idFuncionario FROM Funcionario WHERE " +
                    "matricula = @matricula AND idEmpresa = (SELECT idEmpresa FROM Empresa WHERE nome= @nome))";

                SqlCommand command = new SqlCommand(sqlQuery, ConectionDb);

                var pmtMatricula = command.CreateParameter();
                pmtMatricula.ParameterName = "@matricula";
                pmtMatricula.DbType = DbType.Int32;
                pmtMatricula.Value = _mdlFuncionario.matricula;
                command.Parameters.Add(pmtMatricula);

                var pmtNome = command.CreateParameter();
                pmtNome.ParameterName = "@nome";
                pmtNome.DbType = DbType.String;
                pmtNome.Value = _mdlFuncionario.empresa.nome;
                command.Parameters.Add(pmtNome);

                SqlDataReader cursor = command.ExecuteReader();

                if(cursor.HasRows) 
                {
                    while (cursor.Read())
                    {
                        mdlPonto ponto = new mdlPonto();
                        ponto.data = Convert.ToDateTime(cursor["data"]);

                        if (!cursor.IsDBNull(cursor.GetOrdinal("entrada")))
                        {
                            TimeSpan horarioEntrada = (TimeSpan)cursor["entrada"];
                            ponto.entrada = new DateTime(ponto.data.Year, ponto.data.Month, ponto.data.Day, horarioEntrada.Hours, horarioEntrada.Minutes, horarioEntrada.Seconds);
                        }
                        else
                        {
                            ponto.entrada = new DateTime(ponto.data.Year, ponto.data.Month, ponto.data.Day, 0, 0, 0);
                        }

                        if (!cursor.IsDBNull(cursor.GetOrdinal("ida")))
                        {
                            TimeSpan horarioIda = (TimeSpan)cursor["ida"];
                            ponto.ida = new DateTime(ponto.data.Year, ponto.data.Month, ponto.data.Day, horarioIda.Hours, horarioIda.Minutes, horarioIda.Seconds);
                        }
                        else
                        {
                            ponto.ida = new DateTime(ponto.data.Year, ponto.data.Month, ponto.data.Day, 0, 0, 0);
                        }

                        if (!cursor.IsDBNull(cursor.GetOrdinal("volta")))
                        {
                            TimeSpan horarioVolta = (TimeSpan)cursor["volta"];
                            ponto.volta = new DateTime(ponto.data.Year, ponto.data.Month, ponto.data.Day, horarioVolta.Hours, horarioVolta.Minutes, horarioVolta.Seconds);
                        }
                        else
                        {
                            ponto.volta = new DateTime(ponto.data.Year, ponto.data.Month, ponto.data.Day, 0, 0, 0);
                        }

                        if (!cursor.IsDBNull(cursor.GetOrdinal("saida")))
                        {
                            TimeSpan horarioSaida = (TimeSpan)cursor["saida"];
                            ponto.saida = new DateTime(ponto.data.Year, ponto.data.Month, ponto.data.Day, horarioSaida.Hours, horarioSaida.Minutes, horarioSaida.Seconds);
                        }
                        else
                        {
                            ponto.saida = new DateTime(ponto.data.Year, ponto.data.Month, ponto.data.Day, 0, 0, 0);
                        }
                        if (!cursor.IsDBNull(cursor.GetOrdinal("horasTrabalhadas")))
                        {
                            ponto.horasTrabalhadas = Convert.ToDouble(cursor["horasTrabalhadas"]);
                        }
                        else
                        {
                            ponto.horasTrabalhadas = 0.0;
                        }
           
                        _mdlPonto.Add(ponto);
                    }
                   
                }
                return _mdlPonto;
            }
            catch(Exception er)
            {
                ConectionDb.Close();
                MostrarMensagemDeErro("Erro ao Consultar dados " + er.Message);
                return _mdlPonto;
            }

        }

        private static void MostrarMensagemDeErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
