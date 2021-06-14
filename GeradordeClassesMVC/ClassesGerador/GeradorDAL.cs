using System;
using System.Collections.Generic;
using System.Text;

namespace GeradorDO
{
    /// <summary>
    /// Classe DO
    /// Criador: Marques Silva Fonseca
    /// Criada em 22/03/2012
    /// Contato: marques-fonseca@hotmail.com
    /// </summary>
    /// 
    public class GeradorDAL
    {
        // atributos
        public string strData = null;
        public string s = null;
        public string tb = null;
        public StringBuilder objCodigo = null;

        // construtor
        public GeradorDAL()
        {
            strData = DateTime.Today.ToShortDateString() + " às " + DateTime.Now.ToShortTimeString();
            s = " ";
            tb = "      ";

        }

        // metodos
        public StringBuilder GeraCodigoDAL(string _banco, string _conexao)
        {
            objCodigo = new StringBuilder();

            objCodigo.AppendLine("using System;");
            objCodigo.AppendLine("using System.Collections.Generic;");
            objCodigo.AppendLine("using System.Text;");
            objCodigo.AppendLine("using System.Data;");
            objCodigo.AppendLine("using System.Data.SqlClient;");
            objCodigo.AppendLine();
            objCodigo.AppendLine("namespace DAL");
            objCodigo.AppendLine("{");

            objCodigo.AppendLine(tb + "/// <summary>");
            objCodigo.AppendLine(tb + "/// Classe DAL gerada automática");
            if (Environment.MachineName == "MARQUESNOTE-PC")
                objCodigo.AppendLine(tb + "/// Criador: Marques Silva Fonseca");
            else objCodigo.AppendLine(tb + "/// Criador: " + Environment.UserName);
            objCodigo.AppendLine(tb + "/// Criada em " + strData);
            //objCodigo.AppendLine(tb + "/// Contato: marques-fonseca@hotmail.com");
            objCodigo.AppendLine(tb + "/// </summary>");
            objCodigo.AppendLine(tb + "public class Dao");
            objCodigo.AppendLine(tb + "{");
            objCodigo.AppendLine(tb + tb + "// Atributos");
            objCodigo.AppendLine(tb + tb + "private SqlConnection oConnection = null;");
            objCodigo.AppendLine(tb + tb + "private string connectionString = null;");
            objCodigo.AppendLine(tb + tb + "private SqlDataAdapter oDataAdapter = null;");
            objCodigo.AppendLine(tb + tb + "private SqlCommand oCommand = null;");
            objCodigo.AppendLine(tb + tb + "private DataSet oDataSet = null;");
            objCodigo.AppendLine(tb + tb + "//private string strServidor = null;");
            objCodigo.AppendLine();
            //construtor
            objCodigo.AppendLine(tb + tb + "//Construtor");
            objCodigo.AppendLine(tb + tb + "public Dao()");
            objCodigo.AppendLine(tb + tb + "{");
            objCodigo.AppendLine(tb + tb + "//connectionString = @\"Data Source=subtuum.ddns.net;Initial Catalog=camara;User ID=sa;Password=s3nh406#;");
            objCodigo.AppendLine(tb + tb + "//connectionString = @\"Data Source=192.168.0.200;Initial Catalog=camara;User ID=sa;Password=s3nh406#;");
            objCodigo.AppendLine(tb + tb + tb + "connectionString = @\"" + _conexao + "\";");
            objCodigo.AppendLine(tb + tb + tb + "oConnection = new SqlConnection(connectionString);");
            objCodigo.AppendLine(tb + tb + "}");
            objCodigo.AppendLine();
            objCodigo.AppendLine(tb + tb + "public string RetornaStringConexao()");
            objCodigo.AppendLine(tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + "return connectionString;");
            objCodigo.AppendLine(tb + tb + "}");
            objCodigo.AppendLine();
            //Metodos
            objCodigo.AppendLine(tb + tb + "//Métodos");
            objCodigo.AppendLine(tb + tb + "/// <summary>");
            objCodigo.AppendLine(tb + tb + "/// Executa comandos sql e retorna o número de linhas afetadas.");
            objCodigo.AppendLine(tb + tb + "/// </summary>");
            objCodigo.AppendLine(tb + tb + "/// <param name=\"sSQL\">Comando sql</param>");
            objCodigo.AppendLine(tb + tb + "/// <returns>int regAffect</returns>");
            objCodigo.AppendLine(tb + tb + "/// <returns>int regAffect</returns>");
            objCodigo.AppendLine(tb + tb + "public int ExecutaQuery(string sSQL)");
            objCodigo.AppendLine(tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + "int regAffect = 0;");
            objCodigo.AppendLine(tb + tb + tb + "try");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "oCommand = new SqlCommand(sSQL, oConnection);");
            objCodigo.AppendLine(tb + tb + tb + tb + "oConnection.Open();");
            objCodigo.AppendLine(tb + tb + tb + tb + "if (regAffect == 0)");
            objCodigo.AppendLine(tb + tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + tb + "throw new Exception(\"Ocorreu um erro, entre em contato com o administrador do sistema.\");");
            objCodigo.AppendLine(tb + tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + tb + "else");
            objCodigo.AppendLine(tb + tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + tb + "return regAffect;");
            objCodigo.AppendLine(tb + tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "catch (Exception err)");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "throw err;");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "finally");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "oConnection.Dispose();");
            objCodigo.AppendLine(tb + tb + tb + tb + "oCommand.Dispose();");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + "}");
            objCodigo.AppendLine();
            objCodigo.AppendLine(tb + tb + "/// <summary>");
            objCodigo.AppendLine(tb + tb + "/// Retorna um data set apartir de um comando sql");
            objCodigo.AppendLine(tb + tb + "/// </summary>");
            objCodigo.AppendLine(tb + tb + "/// <param name=\"command\">Comando sql</param>");
            objCodigo.AppendLine(tb + tb + "/// <param name=\"table\">Nome da tabela</param>");
            objCodigo.AppendLine(tb + tb + "/// <returns>DataSet oDataSet</returns>");
            objCodigo.AppendLine(tb + tb + "public DataSet GetDataSet(string command, string table)");
            objCodigo.AppendLine(tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + "try");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "oConnection.Open();");
            objCodigo.AppendLine(tb + tb + tb + tb + "oCommand = new SqlCommand(command, oConnection);");
            objCodigo.AppendLine(tb + tb + tb + tb + "oDataAdapter = new SqlDataAdapter(oCommand);");
            objCodigo.AppendLine(tb + tb + tb + tb + "oDataSet = new DataSet();");
            objCodigo.AppendLine(tb + tb + tb + tb + "oDataAdapter.Fill(oDataSet, table);");
            objCodigo.AppendLine(tb + tb + tb + tb + "return oDataSet;");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "catch (SqlException err)");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "throw err;");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "finally");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "oConnection.Dispose();");
            objCodigo.AppendLine(tb + tb + tb + tb + "oCommand.Dispose();");
            objCodigo.AppendLine(tb + tb + tb + tb + "oDataAdapter.Dispose();");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + "}");
            objCodigo.AppendLine();
            objCodigo.AppendLine(tb + tb + "/// <summary>");
            objCodigo.AppendLine(tb + tb + "/// Executa select no _banco");
            objCodigo.AppendLine(tb + tb + "/// </summary>");
            objCodigo.AppendLine(tb + tb + "/// <param name=\"command\"></param>");
            objCodigo.AppendLine(tb + tb + "/// <returns>DataReader oCommand.ExecuteReader()</returns>");
            objCodigo.AppendLine(tb + tb + "public SqlDataReader QueryConsulta(string command)");
            objCodigo.AppendLine(tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + "try");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "oConnection.Open();");
            objCodigo.AppendLine(tb + tb + tb + tb + "oCommand = new SqlCommand(command, oConnection);");
            objCodigo.AppendLine(tb + tb + tb + tb + "return oCommand.ExecuteReader();");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "catch (Exception err)");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "throw err;");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "finally");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "//oConnection.Dispose();");
            objCodigo.AppendLine(tb + tb + tb + tb + "//oCommand.Dispose();");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + "}");
            objCodigo.AppendLine();


            objCodigo.AppendLine(tb + tb + "/// <summary>");
            objCodigo.AppendLine(tb + tb + "/// Retorna um valor");
            objCodigo.AppendLine(tb + tb + "/// </summary>");
            objCodigo.AppendLine(tb + tb + "/// <param name=\"Query\">Instrução Scalar T-SQL</param>");
            objCodigo.AppendLine(tb + tb + "/// <returns>Object com o valor de retorna ExeculteScalar</returns>");
            objCodigo.AppendLine(tb + tb + "public object ExecultarScript(string Query)");
            objCodigo.AppendLine(tb + tb + "{");
            objCodigo.AppendLine(tb + tb + "    System.Collections.ArrayList NomeParametro = new System.Collections.ArrayList() { };");
            objCodigo.AppendLine(tb + tb + "    System.Collections.ArrayList ValorParametro = new System.Collections.ArrayList() { };");
            objCodigo.AppendLine(tb + tb + "");
            objCodigo.AppendLine(tb + tb + "    System.Data.SqlClient.SqlConnection con = oConnection;");
            objCodigo.AppendLine(tb + tb + "    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(Query, con);");
            objCodigo.AppendLine(tb + tb + "");
            objCodigo.AppendLine(tb + tb + "    if (NomeParametro != null || ValorParametro != null)");
            objCodigo.AppendLine(tb + tb + "    {");
            objCodigo.AppendLine(tb + tb + "        for (int i = 0; i < NomeParametro.Count; i++)");
            objCodigo.AppendLine(tb + tb + "        {");
            objCodigo.AppendLine(tb + tb + "            cmd.Parameters.AddWithValue(NomeParametro[i].ToString(), ValorParametro[i]);");
            objCodigo.AppendLine(tb + tb + "            //Console.Write(\"{0} \", lista[i]); ");
            objCodigo.AppendLine(tb + tb + "        }");
            objCodigo.AppendLine(tb + tb + "    }");
            objCodigo.AppendLine(tb + tb + "    try");
            objCodigo.AppendLine(tb + tb + "    {");
            objCodigo.AppendLine(tb + tb + "        con.Open();");
            objCodigo.AppendLine(tb + tb + "        object temp = cmd.ExecuteScalar();");
            objCodigo.AppendLine(tb + tb + "        if (temp == null)");
            objCodigo.AppendLine(tb + tb + "        {");
            objCodigo.AppendLine(tb + tb + "            return \"\";");
            objCodigo.AppendLine(tb + tb + "        }");
            objCodigo.AppendLine(tb + tb + "        else");
            objCodigo.AppendLine(tb + tb + "        {");
            objCodigo.AppendLine(tb + tb + "            return temp;");
            objCodigo.AppendLine(tb + tb + "        }");
            objCodigo.AppendLine(tb + tb + "    }");
            objCodigo.AppendLine(tb + tb + "    catch (Exception ex)");
            objCodigo.AppendLine(tb + tb + "    {");
            objCodigo.AppendLine(tb + tb + "        throw new Exception(\" Problemas ao executar instrução T-SQL. \" + ex.Message);");
            objCodigo.AppendLine(tb + tb + "    }");
            objCodigo.AppendLine(tb + tb + "    finally");
            objCodigo.AppendLine(tb + tb + "    {");
            objCodigo.AppendLine(tb + tb + "        con.Close();");
            objCodigo.AppendLine(tb + tb + "        con.Dispose();");
            objCodigo.AppendLine(tb + tb + "        cmd.Dispose();");
            objCodigo.AppendLine(tb + tb + "    }");
            objCodigo.AppendLine(tb + tb + "}");
            objCodigo.AppendLine(tb + tb + "");
            objCodigo.AppendLine(tb + tb + "/// <summary>");
            objCodigo.AppendLine(tb + tb + "/// Retorna um valor");
            objCodigo.AppendLine(tb + tb + "/// </summary>");
            objCodigo.AppendLine(tb + tb + "/// <param name=\"Query\">Instrução Scalar T-SQL</param>");
            objCodigo.AppendLine(tb + tb + "/// <param name=\"NomeParametro\">Informe o nome da lista de parametros.</param>");
            objCodigo.AppendLine(tb + tb + "/// <param name=\"ValorParametro\">Informe o valor da lista de parametros.</param>");
            objCodigo.AppendLine(tb + tb + "/// <returns>Object com o valor de retorna ExeculteScalar</returns>");
            objCodigo.AppendLine(tb + tb + "public object ExecultarScript(string Query, System.Collections.ArrayList NomeParametro, System.Collections.ArrayList ValorParametro)");
            objCodigo.AppendLine(tb + tb + "{");
            objCodigo.AppendLine(tb + tb + "    System.Data.SqlClient.SqlConnection con = oConnection;");
            objCodigo.AppendLine(tb + tb + "    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(Query, con);");
            objCodigo.AppendLine(tb + tb + "");
            objCodigo.AppendLine(tb + tb + "    if (NomeParametro != null || ValorParametro != null)");
            objCodigo.AppendLine(tb + tb + "    {");
            objCodigo.AppendLine(tb + tb + "        for (int i = 0; i < NomeParametro.Count; i++)");
            objCodigo.AppendLine(tb + tb + "        {");
            objCodigo.AppendLine(tb + tb + "            cmd.Parameters.AddWithValue(NomeParametro[i].ToString(), ValorParametro[i]);");
            objCodigo.AppendLine(tb + tb + "            //Console.Write(\"{0} \", lista[i]); ");
            objCodigo.AppendLine(tb + tb + "        }");
            objCodigo.AppendLine(tb + tb + "    }");
            objCodigo.AppendLine(tb + tb + "    try");
            objCodigo.AppendLine(tb + tb + "    {");
            objCodigo.AppendLine(tb + tb + "        object temp = cmd.ExecuteScalar();");
            objCodigo.AppendLine(tb + tb + "        if (temp == null)");
            objCodigo.AppendLine(tb + tb + "        {");
            objCodigo.AppendLine(tb + tb + "            return \"\";");
            objCodigo.AppendLine(tb + tb + "        }");
            objCodigo.AppendLine(tb + tb + "        else");
            objCodigo.AppendLine(tb + tb + "        {");
            objCodigo.AppendLine(tb + tb + "            return temp;");
            objCodigo.AppendLine(tb + tb + "        }");
            objCodigo.AppendLine(tb + tb + "    }");
            objCodigo.AppendLine(tb + tb + "    catch (Exception ex)");
            objCodigo.AppendLine(tb + tb + "    {");
            objCodigo.AppendLine(tb + tb + "        throw new Exception(\" Problemas ao executar instrução T-SQL. \" + ex.Message);");
            objCodigo.AppendLine(tb + tb + "    }");
            objCodigo.AppendLine(tb + tb + "    finally");
            objCodigo.AppendLine(tb + tb + "    {");
            objCodigo.AppendLine(tb + tb + "        con.Close();");
            objCodigo.AppendLine(tb + tb + "        con.Dispose();");
            objCodigo.AppendLine(tb + tb + "        cmd.Dispose();");
            objCodigo.AppendLine(tb + tb + "    }");
            objCodigo.AppendLine(tb + tb + "}");
            objCodigo.AppendLine(tb + tb + "");
            objCodigo.AppendLine(tb + tb + "/// <summary>");
            objCodigo.AppendLine(tb + tb + "/// Retorna um valor");
            objCodigo.AppendLine(tb + tb + "/// </summary>");
            objCodigo.AppendLine(tb + tb + "/// <param name=\"Query\">Instrução Scalar T-SQL</param>");
            objCodigo.AppendLine(tb + tb + "/// <param name=\"NomeParametro\">Informe o nome da lista de parametros.</param>");
            objCodigo.AppendLine(tb + tb + "/// <param name=\"ValorParametro\">Informe o valor da lista de parametros.</param>");
            objCodigo.AppendLine(tb + tb + "/// <param name=\"_StringConexao\">Informe a string de conexão atual.</param>");
            objCodigo.AppendLine(tb + tb + "/// <returns>Object com o valor de retorna ExeculteScalar</returns>");
            objCodigo.AppendLine(tb + tb + "public object ExecultarScript(string Query, System.Collections.ArrayList NomeParametro, System.Collections.ArrayList ValorParametro, string _StringConexao)");
            objCodigo.AppendLine(tb + tb + "{");
            objCodigo.AppendLine(tb + tb + "    System.Data.SqlClient.SqlConnection con = oConnection;");
            objCodigo.AppendLine(tb + tb + "    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(Query, con);");
            objCodigo.AppendLine(tb + tb + "");
            objCodigo.AppendLine(tb + tb + "    if (NomeParametro != null || ValorParametro != null)");
            objCodigo.AppendLine(tb + tb + "    {");
            objCodigo.AppendLine(tb + tb + "        for (int i = 0; i < NomeParametro.Count; i++)");
            objCodigo.AppendLine(tb + tb + "        {");
            objCodigo.AppendLine(tb + tb + "            cmd.Parameters.AddWithValue(NomeParametro[i].ToString(), ValorParametro[i]);");
            objCodigo.AppendLine(tb + tb + "            //Console.Write(\"{0} \", lista[i]); ");
            objCodigo.AppendLine(tb + tb + "        }");
            objCodigo.AppendLine(tb + tb + "    }");
            objCodigo.AppendLine(tb + tb + "    try");
            objCodigo.AppendLine(tb + tb + "    {");
            objCodigo.AppendLine(tb + tb + "        object temp = cmd.ExecuteScalar();");
            objCodigo.AppendLine(tb + tb + "        if (temp == null)");
            objCodigo.AppendLine(tb + tb + "        {");
            objCodigo.AppendLine(tb + tb + "            return \"\";");
            objCodigo.AppendLine(tb + tb + "        }");
            objCodigo.AppendLine(tb + tb + "        else");
            objCodigo.AppendLine(tb + tb + "        {");
            objCodigo.AppendLine(tb + tb + "            return temp;");
            objCodigo.AppendLine(tb + tb + "        }");
            objCodigo.AppendLine(tb + tb + "    }");
            objCodigo.AppendLine(tb + tb + "    catch (Exception ex)");
            objCodigo.AppendLine(tb + tb + "    {");
            objCodigo.AppendLine(tb + tb + "        throw new Exception(\" Problemas ao executar instrução T-SQL. \" + ex.Message);");
            objCodigo.AppendLine(tb + tb + "    }");
            objCodigo.AppendLine(tb + tb + "    finally");
            objCodigo.AppendLine(tb + tb + "    {");
            objCodigo.AppendLine(tb + tb + "        con.Close();");
            objCodigo.AppendLine(tb + tb + "        con.Dispose();");
            objCodigo.AppendLine(tb + tb + "        cmd.Dispose();");
            objCodigo.AppendLine(tb + tb + "    }");
            objCodigo.AppendLine(tb + tb + "}");

            objCodigo.AppendLine();
            objCodigo.AppendLine(tb + tb + "public void CloseConn()");
            objCodigo.AppendLine(tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + "oConnection.Dispose();");
            objCodigo.AppendLine(tb + tb + "}");
            objCodigo.AppendLine(tb + "}");

            #region Classe Generica
            objCodigo.AppendLine();
            objCodigo.AppendLine(tb + "/// <summary>");
            objCodigo.AppendLine(tb + "/// Classe DAL \"Genérica\" gerada automática ");
            objCodigo.AppendLine(tb + "/// Criador: Marques Silva Fonseca");
            objCodigo.AppendLine(tb + "/// Criada em " + strData);
            objCodigo.AppendLine(tb + "/// Contato: marques-fonseca@hotmail.com");
            objCodigo.AppendLine(tb + "/// </summary>");
            objCodigo.AppendLine(tb + "public class Dao<T>");
            objCodigo.AppendLine(tb + "{");
            objCodigo.AppendLine(tb + tb + "// Atributos");
            objCodigo.AppendLine(tb + tb + "private SqlConnection oConnection = null;");
            objCodigo.AppendLine(tb + tb + "private string connectionString = null;");
            //objCodigo.AppendLine(tb + tb + "private SqlDataAdapter oDataAdapter = null;");
            objCodigo.AppendLine(tb + tb + "private SqlCommand oCommand = null;");
            //objCodigo.AppendLine(tb + tb + "private DataSet oDataSet = null;");
            //objCodigo.AppendLine(tb + tb + "private string strServidor = null;");
            objCodigo.AppendLine(tb + tb + "");
            objCodigo.AppendLine(tb + tb + "//Construtor");
            objCodigo.AppendLine(tb + tb + "public Dao()");
            objCodigo.AppendLine(tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + "connectionString = new Dao().RetornaStringConexao();");
            objCodigo.AppendLine(tb + tb + tb + "oConnection = new SqlConnection(connectionString);");
            objCodigo.AppendLine(tb + tb + "}");
            objCodigo.AppendLine();
            objCodigo.AppendLine(tb + tb + "public IEnumerable<T> RetornaLista(string commandText, IEnumerable<T> lista)");
            objCodigo.AppendLine(tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + "oCommand = new SqlCommand(commandText, oConnection);");
            objCodigo.AppendLine(tb + tb + tb + "oConnection.Open();");
            objCodigo.AppendLine(tb + tb + tb + "SqlDataReader reader = oCommand.ExecuteReader();");
            objCodigo.AppendLine(tb + tb + tb + "List<T> lstResult = new List<T>();");
            objCodigo.AppendLine();
            objCodigo.AppendLine(tb + tb + tb + "try");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "if (reader.HasRows)");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + "//lista.FromDataReader(reader);");
            objCodigo.AppendLine();
            objCodigo.AppendLine(tb + tb + tb + "//Instance reflec object from Reflection class coded above");
            objCodigo.AppendLine(tb + tb + tb + "Reflection reflec = new Reflection();");
            objCodigo.AppendLine(tb + tb + tb + "//Declare one \"instance\" object of Object type and an object list");
            objCodigo.AppendLine(tb + tb + tb + "Object instance;");
            objCodigo.AppendLine(tb + tb + tb + "List<Object> lstObj = new List<Object>();");
            objCodigo.AppendLine();
            objCodigo.AppendLine(tb + tb + tb + "//dataReader loop");
            objCodigo.AppendLine(tb + tb + tb + "while (reader.Read())");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "//Create an instance of the object needed.");
            objCodigo.AppendLine(tb + tb + tb + tb + "//The instance is created by obtaining the object type T of the object");
            objCodigo.AppendLine(tb + tb + tb + tb + "//list, which is the object that calls the extension method");
            objCodigo.AppendLine(tb + tb + tb + tb + "//Type T is inferred and is instantiated");
            objCodigo.AppendLine(tb + tb + tb + tb + "instance = Activator.CreateInstance(lista.GetType().GetGenericArguments()[0]);");
            objCodigo.AppendLine(tb + tb + tb + tb + "");
            objCodigo.AppendLine(tb + tb + tb + tb + "// Loop all the fields of each row of dataReader, and through the object");
            objCodigo.AppendLine(tb + tb + tb + tb + "// reflector (first step method) fill the object instance with the datareader values");
            objCodigo.AppendLine(tb + tb + tb + tb + "foreach (System.Data.DataRow drow in reader.GetSchemaTable().Rows)");
            objCodigo.AppendLine(tb + tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + tb + "reflec.FillObjectWithProperty(ref instance,");
            objCodigo.AppendLine(tb + tb + tb + tb + tb + "drow.ItemArray[0].ToString(), reader[drow.ItemArray[0].ToString()]);");
            objCodigo.AppendLine(tb + tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + tb + "");
            objCodigo.AppendLine(tb + tb + tb + tb + "//Add object instance to list");
            objCodigo.AppendLine(tb + tb + tb + tb + "lstObj.Add(instance);");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "");
            objCodigo.AppendLine(tb + tb + tb + "foreach (Object item in lstObj)");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + "lstResult.Add((T)Convert.ChangeType(item, typeof(T)));");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "else");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "//Console.WriteLine(\"No rows found.\");");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "catch (Exception err)");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "throw err;");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "finally");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "reader.Close();");
            objCodigo.AppendLine(tb + tb + tb + tb + "oConnection.Dispose();");
            objCodigo.AppendLine(tb + tb + tb + tb + "oCommand.Dispose();");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "");
            objCodigo.AppendLine(tb + tb + tb + "return lstResult;");
            objCodigo.AppendLine(tb + tb + "}");
            objCodigo.AppendLine(tb + "}");
            objCodigo.AppendLine();

            objCodigo.AppendLine(tb + "public class Reflection");
            objCodigo.AppendLine(tb + "{");
            objCodigo.AppendLine(tb + tb + "public void FillObjectWithProperty(ref object objectTo, string propertyName, object propertyValue)");
            objCodigo.AppendLine(tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + "Type tOb2 = objectTo.GetType();");
            objCodigo.AppendLine(tb + tb + tb + "if (propertyValue == DBNull.Value)");
            objCodigo.AppendLine(tb + tb + tb + tb + "propertyValue = null;");
            objCodigo.AppendLine(tb + tb + tb + "tOb2.GetProperty(propertyName).SetValue(objectTo, propertyValue, new object[] { });");
            objCodigo.AppendLine(tb + tb + "}");
            objCodigo.AppendLine(tb + "}");

            #endregion




            objCodigo.AppendLine("}");

            return objCodigo;
        }
    }
}
