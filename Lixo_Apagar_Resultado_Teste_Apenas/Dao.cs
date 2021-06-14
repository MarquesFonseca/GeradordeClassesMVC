using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
      /// <summary>
      /// Classe DAL gerada automática
      /// Criador: MARQUES
      /// Criada em 11/06/2021 às 13:08
      /// </summary>
      public class Dao
      {
            // Atributos
            private SqlConnection oConnection = null;
            private string connectionString = null;
            private SqlDataAdapter oDataAdapter = null;
            private SqlCommand oCommand = null;
            private DataSet oDataSet = null;
            //private string strServidor = null;

            //Construtor
            public Dao()
            {
            //connectionString = @"Data Source=subtuum.ddns.net;Initial Catalog=camara;User ID=sa;Password=s3nh406#;
            //connectionString = @"Data Source=192.168.0.200;Initial Catalog=camara;User ID=sa;Password=s3nh406#;
                  connectionString = @"Data Source=MARQUES-PC\SQLEXPRESS;Initial Catalog=MASTER;Integrated Security=True;";
                  oConnection = new SqlConnection(connectionString);
            }

            public string RetornaStringConexao()
            {
                  return connectionString;
            }

            //Métodos
            /// <summary>
            /// Executa comandos sql e retorna o número de linhas afetadas.
            /// </summary>
            /// <param name="sSQL">Comando sql</param>
            /// <returns>int regAffect</returns>
            /// <returns>int regAffect</returns>
            public int ExecutaQuery(string sSQL)
            {
                  int regAffect = 0;
                  try
                  {
                        oCommand = new SqlCommand(sSQL, oConnection);
                        oConnection.Open();
                        if (regAffect == 0)
                        {
                              throw new Exception("Ocorreu um erro, entre em contato com o administrador do sistema.");
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

            /// <summary>
            /// Retorna um data set apartir de um comando sql
            /// </summary>
            /// <param name="command">Comando sql</param>
            /// <param name="table">Nome da tabela</param>
            /// <returns>DataSet oDataSet</returns>
            public DataSet GetDataSet(string command, string table)
            {
                  try
                  {
                        oConnection.Open();
                        oCommand = new SqlCommand(command, oConnection);
                        oDataAdapter = new SqlDataAdapter(oCommand);
                        oDataSet = new DataSet();
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

            /// <summary>
            /// Executa select no _banco
            /// </summary>
            /// <param name="command"></param>
            /// <returns>DataReader oCommand.ExecuteReader()</returns>
            public SqlDataReader QueryConsulta(string command)
            {
                  try
                  {
                        oConnection.Open();
                        oCommand = new SqlCommand(command, oConnection);
                        return oCommand.ExecuteReader();
                  }
                  catch (Exception err)
                  {
                        throw err;
                  }
                  finally
                  {
                        //oConnection.Dispose();
                        //oCommand.Dispose();
                  }
            }

            /// <summary>
            /// Retorna um valor
            /// </summary>
            /// <param name="Query">Instrução Scalar T-SQL</param>
            /// <returns>Object com o valor de retorna ExeculteScalar</returns>
            public object ExecultarScript(string Query)
            {
                System.Collections.ArrayList NomeParametro = new System.Collections.ArrayList() { };
                System.Collections.ArrayList ValorParametro = new System.Collections.ArrayList() { };
            
                System.Data.SqlClient.SqlConnection con = oConnection;
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(Query, con);
            
                if (NomeParametro != null || ValorParametro != null)
                {
                    for (int i = 0; i < NomeParametro.Count; i++)
                    {
                        cmd.Parameters.AddWithValue(NomeParametro[i].ToString(), ValorParametro[i]);
                        //Console.Write("{0} ", lista[i]); 
                    }
                }
                try
                {
                    con.Open();
                    object temp = cmd.ExecuteScalar();
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
            
            /// <summary>
            /// Retorna um valor
            /// </summary>
            /// <param name="Query">Instrução Scalar T-SQL</param>
            /// <param name="NomeParametro">Informe o nome da lista de parametros.</param>
            /// <param name="ValorParametro">Informe o valor da lista de parametros.</param>
            /// <returns>Object com o valor de retorna ExeculteScalar</returns>
            public object ExecultarScript(string Query, System.Collections.ArrayList NomeParametro, System.Collections.ArrayList ValorParametro)
            {
                System.Data.SqlClient.SqlConnection con = oConnection;
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(Query, con);
            
                if (NomeParametro != null || ValorParametro != null)
                {
                    for (int i = 0; i < NomeParametro.Count; i++)
                    {
                        cmd.Parameters.AddWithValue(NomeParametro[i].ToString(), ValorParametro[i]);
                        //Console.Write("{0} ", lista[i]); 
                    }
                }
                try
                {
                    object temp = cmd.ExecuteScalar();
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
            
            /// <summary>
            /// Retorna um valor
            /// </summary>
            /// <param name="Query">Instrução Scalar T-SQL</param>
            /// <param name="NomeParametro">Informe o nome da lista de parametros.</param>
            /// <param name="ValorParametro">Informe o valor da lista de parametros.</param>
            /// <param name="_StringConexao">Informe a string de conexão atual.</param>
            /// <returns>Object com o valor de retorna ExeculteScalar</returns>
            public object ExecultarScript(string Query, System.Collections.ArrayList NomeParametro, System.Collections.ArrayList ValorParametro, string _StringConexao)
            {
                System.Data.SqlClient.SqlConnection con = oConnection;
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(Query, con);
            
                if (NomeParametro != null || ValorParametro != null)
                {
                    for (int i = 0; i < NomeParametro.Count; i++)
                    {
                        cmd.Parameters.AddWithValue(NomeParametro[i].ToString(), ValorParametro[i]);
                        //Console.Write("{0} ", lista[i]); 
                    }
                }
                try
                {
                    object temp = cmd.ExecuteScalar();
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

            public void CloseConn()
            {
                  oConnection.Dispose();
            }
      }

      /// <summary>
      /// Classe DAL "Genérica" gerada automática 
      /// Criador: Marques Silva Fonseca
      /// Criada em 11/06/2021 às 13:08
      /// Contato: marques-fonseca@hotmail.com
      /// </summary>
      public class Dao<T>
      {
            // Atributos
            private SqlConnection oConnection = null;
            private string connectionString = null;
            private SqlCommand oCommand = null;
            
            //Construtor
            public Dao()
            {
                  connectionString = new Dao().RetornaStringConexao();
                  oConnection = new SqlConnection(connectionString);
            }

            public IEnumerable<T> RetornaLista(string commandText, IEnumerable<T> lista)
            {
                  oCommand = new SqlCommand(commandText, oConnection);
                  oConnection.Open();
                  SqlDataReader reader = oCommand.ExecuteReader();
                  List<T> lstResult = new List<T>();

                  try
                  {
                        if (reader.HasRows)
                  {
                  //lista.FromDataReader(reader);

                  //Instance reflec object from Reflection class coded above
                  Reflection reflec = new Reflection();
                  //Declare one "instance" object of Object type and an object list
                  Object instance;
                  List<Object> lstObj = new List<Object>();

                  //dataReader loop
                  while (reader.Read())
                  {
                        //Create an instance of the object needed.
                        //The instance is created by obtaining the object type T of the object
                        //list, which is the object that calls the extension method
                        //Type T is inferred and is instantiated
                        instance = Activator.CreateInstance(lista.GetType().GetGenericArguments()[0]);
                        
                        // Loop all the fields of each row of dataReader, and through the object
                        // reflector (first step method) fill the object instance with the datareader values
                        foreach (System.Data.DataRow drow in reader.GetSchemaTable().Rows)
                        {
                              reflec.FillObjectWithProperty(ref instance,
                              drow.ItemArray[0].ToString(), reader[drow.ItemArray[0].ToString()]);
                        }
                        
                        //Add object instance to list
                        lstObj.Add(instance);
                  }
                  
                  foreach (Object item in lstObj)
                  {
                  lstResult.Add((T)Convert.ChangeType(item, typeof(T)));
                  }
                  }
                  else
                  {
                        //Console.WriteLine("No rows found.");
                  }
                  
                  }
                  catch (Exception err)
                  {
                        throw err;
                  }
                  finally
                  {
                        reader.Close();
                        oConnection.Dispose();
                        oCommand.Dispose();
                  }
                  
                  return lstResult;
            }
      }

      public class Reflection
      {
            public void FillObjectWithProperty(ref object objectTo, string propertyName, object propertyValue)
            {
                  Type tOb2 = objectTo.GetType();
                  if (propertyValue == DBNull.Value)
                        propertyValue = null;
                  tOb2.GetProperty(propertyName).SetValue(objectTo, propertyValue, new object[] { });
            }
      }
}
