using projeto.Modelo;
using Projeto.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesDeControle
{
    public  class ctlFerias
    {

        public static mdlFerias SelecionrFerias(mdlFerias _mdlFerias)
        {
            mdlFerias ferias = new mdlFerias();
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_pim;Integrated Security=True";

            SqlConnection connectionDb = new SqlConnection(connectionString);

            try
            {
                connectionDb.Open();

                string sqlQuery = "SELECT * FROM Ferias WHERE idFuncionario = @idFuncionario";

                SqlCommand command = new SqlCommand(sqlQuery, connectionDb);

                var pmtIdFuncionario = command.CreateParameter();
                pmtIdFuncionario.ParameterName = "@idFuncionario";
                pmtIdFuncionario.DbType = DbType.Int32;
                pmtIdFuncionario.Value = _mdlFerias.idFuncionario;
                command.Parameters.Add(pmtIdFuncionario);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        ferias.idFuncionario = Convert.ToInt32(reader["idFuncionario"].ToString());
                        ferias.periodoDataVencimento = Convert.ToDateTime(reader["periodoDataVencimento"]);
                        if (!reader.IsDBNull(reader.GetOrdinal("periodoInicio")))
                        {
                            ferias.periodoInicio = Convert.ToDateTime(reader["periodoInicio"]);
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("periodoFim")))
                        {
                            ferias.periodoFim = Convert.ToDateTime(reader["periodoFim"]);
                        }
                        
                        ferias.vencido = Convert.ToBoolean(reader["vencido"]);
                        
                    }
                    
                }
                return ferias;
            }
            catch (Exception ex)
            {
                connectionDb.Close();
                throw new Exception("Erro ao Selecionar" + ex.Message);
            }
        }

        public static bool AtribuirFerias(mdlFerias mdlFerias)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_pim;Integrated Security=True";

            SqlConnection connectionDb = new SqlConnection(connectionString);

            try
            {
                connectionDb.Open();

                string sqlQuery = "UPDATE Ferias SET periodoDataVencimento = DATEADD(YEAR, 1, periodoDataVencimento), periodoInicio = @periodoInicio, " +
                    "periodoFim = @periodoFim WHERE idFuncionario = @idFuncionario";
                
                SqlCommand command = new SqlCommand(sqlQuery, connectionDb);

                var pmtPeriodoInicio = command.CreateParameter();
                pmtPeriodoInicio.ParameterName = "@periodoInicio";
                pmtPeriodoInicio.DbType = DbType.Date;
                pmtPeriodoInicio.Value = mdlFerias.periodoInicio.ToString("yyyy-MM-dd");
                command.Parameters.Add(pmtPeriodoInicio);

                var pmtPeriodoFim = command.CreateParameter();
                pmtPeriodoFim.ParameterName = "@periodoFim";
                pmtPeriodoFim.DbType = DbType.Date;
                pmtPeriodoFim.Value = mdlFerias.periodoFim.ToString("yyyy-MM-dd");
                command.Parameters.Add(pmtPeriodoFim);

                var pmtIdFuncionario = command.CreateParameter();
                pmtIdFuncionario.ParameterName = "@idFuncionario";
                pmtIdFuncionario.DbType = DbType.Int32;
                pmtIdFuncionario.Value = mdlFerias.idFuncionario;
                command.Parameters.Add(pmtIdFuncionario);

                if(command.ExecuteNonQuery() > 0)
                {
                    connectionDb.Close();
                    return true;
                }
                

            }
            catch (Exception ex)
            {
                connectionDb.Close();
                throw new Exception("Erro ao atribuir" + ex.Message);
            }
            return true;
        }

        public static mdlFerias PuxarFerias(mdlFuncionario mdlFuncionarioAcessado)
        {
            mdlFerias feriasFuncionario = new mdlFerias();

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_pim;Integrated Security=True";

            SqlConnection connectionBd = new SqlConnection(connectionString);

            try
            {
                connectionBd.Open();

                string sqlQuery = "SELECT * FROM Ferias WHERE idFuncionario = @idFuncionario";

                SqlCommand command = new SqlCommand(sqlQuery, connectionBd);

                var pmtIdFuncionario = command.CreateParameter();
                pmtIdFuncionario.ParameterName = "@idFuncionario";
                pmtIdFuncionario.DbType = DbType.Int32;
                pmtIdFuncionario.Value = mdlFuncionarioAcessado.idFuncionario;
                command.Parameters.Add(pmtIdFuncionario);

                SqlDataReader cursor = command.ExecuteReader();

                if(cursor.HasRows)
                {
                    if(cursor.Read())
                    {
                        feriasFuncionario.periodoDataVencimento = Convert.ToDateTime(cursor["periodoDataVencimento"]);
                        if (!cursor.IsDBNull(cursor.GetOrdinal("periodoInicio")))
                        {
                            feriasFuncionario.periodoInicio = Convert.ToDateTime(cursor["periodoInicio"]);
                        }
                        if (!cursor.IsDBNull(cursor.GetOrdinal("periodoFim")))
                        {
                            feriasFuncionario.periodoFim = Convert.ToDateTime(cursor["periodoFim"]);
                        }
                        feriasFuncionario.vencido = Convert.ToBoolean(cursor["vencido"]);

                    }

                }
                return feriasFuncionario;

            }
            catch (Exception ex)
            {
                connectionBd.Close();
                throw new Exception("Erro ao carregar ferias: " +ex.Message);
            }
        }
    }
}
