using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Banco
{
    public class Banco
    {
        // Atributos
        private string connectionString = null;
        private SqlConnection oConnection = null;

        public TipoBanco TipoBanco { get; set; }

        //Construtor
        public Banco(TipoBanco TipoBD, string strConn)
        {
            TipoBanco = TipoBD;
            #region SqlServer
            if (TipoBD == TipoBanco.SqlServer)
            {
                connectionString = strConn;
                try
                {
                    oConnection = new SqlConnection(connectionString);
                }
                catch
                {
                    throw new Exception("Erro ao conectar com o banco. Verifica a string de conexão.");
                }
            }
            #endregion
        }

        //Métodos

        /// <summary>
        /// Executa comandos sql e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="sSQL">Comando sql</param>
        /// <returns>int regAffect</returns>
        public int ExecutaQuery(string sSQL)
        {
            int regAffect = 0;

            #region SqlServer
            if (this.TipoBanco == TipoBanco.SqlServer)
            {
                SqlCommand oCommand = new SqlCommand(sSQL, oConnection);
                try
                {
                    if (oConnection.State == ConnectionState.Closed)
                        oConnection.Open();
                    regAffect = oCommand.ExecuteNonQuery();
                    if (regAffect == 0)
                    {
                        throw new Exception("Ocorreu um erro no comando sql, entre em contato com o administrador do sistema.");
                    }
                    else
                    {
                        return regAffect;
                    }

                }
                catch (Exception err)
                {
                    throw err;
                }
                finally
                {
                    oConnection.Dispose();
                    oCommand.Dispose();
                }
            }
            #endregion

            return regAffect;
        }

        /// <summary>
        /// Retorna um valor
        /// </summary>
        /// <param name="Query">Instrução Scalar T-SQL</param>
        /// <returns>Object com o valor de retorna ExeculteScalar</returns>
        public object ExecultarScript(string Query)
        {
            object temp = "";
            System.Collections.ArrayList NomeParametro = new System.Collections.ArrayList() { };
            System.Collections.ArrayList ValorParametro = new System.Collections.ArrayList() { };

            #region SqlServer
            if (TipoBanco == TipoBanco.SqlServer)
            {
                SqlConnection con = oConnection;
                SqlCommand cmd = new System.Data.SqlClient.SqlCommand(Query, con);
                try
                {
                    if (NomeParametro != null || ValorParametro != null)
                    {
                        for (int i = 0; i < NomeParametro.Count; i++)
                        {
                            cmd.Parameters.AddWithValue(NomeParametro[i].ToString(), ValorParametro[i]);
                            //Console.Write("{0} ", lista[i]); 
                        }
                    }

                    con.Open();
                    temp = cmd.ExecuteScalar();
                    if (temp == null)
                    {
                        return "";
                    }
                    else
                    {
                        return temp;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(" Problemas ao executar instrução T-SQL. " + ex.Message);
                }
                finally
                {
                    con.Close();
                    con.Dispose();
                    cmd.Dispose();
                }
            }
            #endregion

            return temp;
        }

        /// <summary>
        /// Retorna um data set apartir de um comando sql
        /// </summary>
        /// <param name="command">Comando sql</param>
        /// <param name="table">Nome da tabela</param>
        /// <returns>DataSet oDataSet</returns>
        public DataSet GetDataSet(string command, string table)
        {
            DataSet oDataSet = new DataSet();

            #region SqlServer
            if (TipoBanco == TipoBanco.SqlServer)
            {
                oConnection.Open();
                SqlCommand oCommand = new SqlCommand(command, oConnection);
                SqlDataAdapter oDataAdapter = new SqlDataAdapter(oCommand);
                try
                {
                    oDataAdapter.Fill(oDataSet, table);
                    return oDataSet;
                }
                catch (SqlException err)
                {
                    throw err;
                }
                finally
                {
                    oConnection.Dispose();
                    oCommand.Dispose();
                    oDataAdapter.Dispose();
                }
            }
            #endregion

            return oDataSet;
        }

        /// <summary>
        /// Executa select no banco
        /// </summary>
        /// <param name="command"></param>
        /// <returns>DataReader oCommand.ExecuteReader()</returns>
        public SqlDataReader QueryConsulta(string command)
        {
            SqlCommand oCommand = new SqlCommand(command, oConnection);

            #region SqlServer
            if (TipoBanco == TipoBanco.SqlServer)
            {
                try
                {
                    oConnection.Open();
                    return oCommand.ExecuteReader();
                }
                catch (Exception err)
                {
                    return oCommand.ExecuteReader();
                    //throw err;
                }
                finally
                {
                    //oConnection.Dispose();
                    //oCommand.Dispose();
                }
            }
            #endregion

            return oCommand.ExecuteReader();
        }

        public void CloseConn()
        {
            oConnection.Dispose();
        }

        public object RetornaValor(string Query, System.Collections.ArrayList NomeParametro, System.Collections.ArrayList ValorParametro, string StringConexao)
        {
            object Retorno = "";

            #region SqlServer
            if (TipoBanco == TipoBanco.SqlServer)
            {
                SqlConnection con = new SqlConnection(StringConexao);
                SqlCommand cmd = new SqlCommand(Query, con);
                for (int i = 0; i < NomeParametro.Count; i++)
                {
                    cmd.Parameters.AddWithValue(NomeParametro[i].ToString(), ValorParametro[i]);
                    //Console.Write("{0} ", lista[i]); 
                }
                try
                {
                    con.Open();

                    Retorno = cmd.ExecuteScalar();
                }
                finally
                {
                    con.Close();
                    con.Dispose();
                    cmd.Dispose();
                }
            }
            #endregion

            return Retorno;
        }

        public object RetornaValor(string Query, System.Collections.ArrayList NomeParametro, System.Collections.ArrayList ValorParametro)
        {
            object Retorno = "";

            #region SqlServer
            if (TipoBanco == TipoBanco)
            {
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(Query, con);
                for (int i = 0; i < NomeParametro.Count; i++)
                {
                    cmd.Parameters.AddWithValue(NomeParametro[i].ToString(), ValorParametro[i]);
                    //Console.Write("{0} ", lista[i]); 
                }
                try
                {
                    con.Open();

                    Retorno = cmd.ExecuteScalar();
                }
                finally
                {
                    con.Close();
                    con.Dispose();
                    cmd.Dispose();
                }
            }
            #endregion

            return Retorno;
        }
    }
}
