using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GeradorBLL
{
    public class GeradorBLL
    {
        // Atributos
        public string strData = null;
        public string[] arrTabelas = null;
        public string s = null;
        public string tb = null;
        public StringBuilder objCodigo = null;
        public Banco.Banco objBanco = null;
        public SqlDataReader objDr = null;
        private int nunrec = 0;
        private Library.Library objLib = null;

        // Construtor
        public GeradorBLL()
        {
            strData = DateTime.Today.ToShortDateString() + " às " + DateTime.Now.ToShortTimeString();
            s = " ";
            tb = "      ";
        }

        // Metodos
        public StringBuilder GeraCodigoBLL(string _tabela, string _conexao, string _banco, bool chkAtualizarCampoDataCadastro = true)
        {
            string strTabela = _tabela;

            objCodigo = new StringBuilder();

            objCodigo.AppendLine("using System;");
            objCodigo.AppendLine("using System.Collections.Generic;");
            objCodigo.AppendLine("using System.Text;");
            objCodigo.AppendLine("using System.Data;");
            objCodigo.AppendLine("using System.Data.SqlClient;");
            objCodigo.AppendLine("using DTO;");
            objCodigo.AppendLine("using DAL;");
            objCodigo.AppendLine();
            objCodigo.AppendLine("namespace BLL");
            objCodigo.AppendLine("{");

            string tabelaFormatada = strTabela.Replace("_", "").Replace("-", "");
            //objCodigo.AppendLine();
            objCodigo.AppendLine(tb + "/// <summary>");
            objCodigo.AppendLine(tb + "/// Classe da BLL gerada automática: " + strTabela);
            if (Environment.MachineName == "MARQUESNOTE-PC")
                objCodigo.AppendLine(tb + "/// Criador: Marques Silva Fonseca");
            else objCodigo.AppendLine(tb + "/// Criador: " + Environment.UserName);
            objCodigo.AppendLine(tb + "/// Criada em " + strData);
            //objCodigo.AppendLine(tb + "/// Contato: marques-fonseca@hotmail.com");
            objCodigo.AppendLine(tb + "/// </summary>");
            objCodigo.AppendLine(tb + "public class " + tabelaFormatada + "BO<T>");
            objCodigo.AppendLine(tb + "{");
            objCodigo.AppendLine(tb + tb + "// Atributos");
            // atributos
            objCodigo.AppendLine(tb + tb + "private DAL.Dao objDO = null;");
            objCodigo.AppendLine(tb + tb + "private StringBuilder strSql = null;");


            #region metodo FindAllGenerico
            // metodo FindAll--------------------------------
            objCodigo.AppendLine();
            objCodigo.AppendLine(tb + tb + "//Métodos");
            objCodigo.AppendLine(tb + tb + "/// <summary>");
            objCodigo.AppendLine(tb + tb + "/// Seleciona todos os registros e retorna um DataSet.");
            objCodigo.AppendLine(tb + tb + "/// </summary>");
            objCodigo.AppendLine(tb + tb + "/// <returns>DataSet</returns>");
            objCodigo.AppendLine(tb + tb + "public IEnumerable<Tab" + tabelaFormatada + "> FindAllLista()");
            objCodigo.AppendLine(tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + "try");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql = new StringBuilder();");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" SELECT \"); ");
            //objCodigo.AppendLine(tb + tb + tb + tb + "// colunas");
            objCodigo.Append(tb + tb + tb + tb + "strSql.Append(\" ");

            // pega todas as colunas da tabela

            // Abre conexão
            objBanco = new Banco.Banco(_conexao);
            // Faz a leitura de todas as colunas da tabela
            objDr = objBanco.QueryConsulta("SELECT * FROM " + strTabela);

            nunrec = objDr.FieldCount;

            for (int i = 0; i < nunrec - 1; i++)
            {
                // lista as colunas
                objCodigo.Append(objDr.GetName(i) + ", ");
            }

            // lista a última coluna sem a virgula
            objCodigo.Append(objDr.GetName(nunrec - 1) + " ");

            // Fecha conexão
            objBanco.CloseConn();
            objBanco = null;

            objCodigo.AppendLine(" \"); ");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" FROM  " + strTabela + "  \");");
            objCodigo.AppendLine(tb + tb + tb + tb + "string sql = strSql.ToString();");
            objCodigo.AppendLine();
            objCodigo.AppendLine(tb + tb + tb + tb + "IEnumerable<Tab" + tabelaFormatada + "> lista = new DAL.Dao<Tab" + tabelaFormatada + ">().RetornaLista(strSql.ToString(), new List<Tab" + tabelaFormatada + ">());");
            objCodigo.AppendLine();
            objCodigo.AppendLine(tb + tb + tb + tb + "// retorna lista do tipo do objeto");
            objCodigo.AppendLine(tb + tb + tb + tb + "return lista;");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "catch (Exception er)");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "throw new Exception(\"Aconteceu um erro:\" + er.Message.ToString()); ");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "finally");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql = null;");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + "}");
            objCodigo.AppendLine();
            #endregion

            #region metodo FindAllGenerico com where
            // metodo FindAll--------------------------------
            objCodigo.AppendLine(tb + tb + "//Métodos");
            objCodigo.AppendLine(tb + tb + "/// <summary>");
            objCodigo.AppendLine(tb + tb + "/// Seleciona todos os registros e retorna um DataSet.");
            objCodigo.AppendLine(tb + tb + "/// </summary>");
            objCodigo.AppendLine(tb + tb + "/// <returns>DataSet</returns>");
            objCodigo.AppendLine(tb + tb + "public IEnumerable<Tab" + tabelaFormatada + "> FindAllLista(string _filtro)");
            objCodigo.AppendLine(tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + "try");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql = new StringBuilder();");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" SELECT \"); ");
            //objCodigo.AppendLine(tb + tb + tb + tb + "// colunas");
            objCodigo.Append(tb + tb + tb + tb + "strSql.Append(\" ");

            // pega todas as colunas da tabela

            // Abre conexão
            objBanco = new Banco.Banco(_conexao);
            // Faz a leitura de todas as colunas da tabela
            objDr = objBanco.QueryConsulta("SELECT * FROM " + strTabela);

            nunrec = objDr.FieldCount;

            for (int i = 0; i < nunrec - 1; i++)
            {
                // lista as colunas
                objCodigo.Append(objDr.GetName(i) + ", ");
            }

            // lista a última coluna sem a virgula
            objCodigo.Append(objDr.GetName(nunrec - 1) + " ");

            // Fecha conexão
            objBanco.CloseConn();
            objBanco = null;

            objCodigo.AppendLine(" \"); ");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" FROM  " + strTabela + "  \");");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" WHERE ( \" + _filtro + \" ) \");");
            objCodigo.AppendLine(tb + tb + tb + tb + "string sql = strSql.ToString();");
            objCodigo.AppendLine();
            objCodigo.AppendLine(tb + tb + tb + tb + "IEnumerable<Tab" + tabelaFormatada + "> lista = new DAL.Dao<Tab" + tabelaFormatada + ">().RetornaLista(strSql.ToString(), new List<Tab" + tabelaFormatada + ">());");
            objCodigo.AppendLine();
            objCodigo.AppendLine(tb + tb + tb + tb + "// retorna lista do tipo do objeto");
            objCodigo.AppendLine(tb + tb + tb + tb + "return lista;");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "catch (Exception er)");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "throw new Exception(\"Aconteceu um erro:\" + er.Message.ToString()); ");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "finally");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql = null;");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + "}");
            objCodigo.AppendLine();
            #endregion


            // metodo FindAll--------------------------------
            objCodigo.AppendLine(tb + tb + "//Métodos");
            objCodigo.AppendLine(tb + tb + "/// <summary>");
            objCodigo.AppendLine(tb + tb + "/// Seleciona todos os registros e retorna um DataSet.");
            objCodigo.AppendLine(tb + tb + "/// </summary>");
            objCodigo.AppendLine(tb + tb + "/// <returns>DataSet</returns>");
            objCodigo.AppendLine(tb + tb + "public DataSet FindAll()");
            objCodigo.AppendLine(tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + "try");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql = new StringBuilder();");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" SELECT \"); ");
            //objCodigo.AppendLine(tb + tb + tb + tb + "// colunas");
            objCodigo.Append(tb + tb + tb + tb + "strSql.Append(\" ");

            // pega todas as colunas da tabela

            // Abre conexão
            objBanco = new Banco.Banco(_conexao);
            // Faz a leitura de todas as colunas da tabela
            objDr = objBanco.QueryConsulta("SELECT * FROM " + strTabela);

            nunrec = objDr.FieldCount;

            for (int i = 0; i < nunrec - 1; i++)
            {
                // lista as colunas
                objCodigo.Append(objDr.GetName(i) + ", ");
            }

            // lista a última coluna sem a virgula
            objCodigo.Append(objDr.GetName(nunrec - 1) + " ");

            // Fecha conexão
            objBanco.CloseConn();
            objBanco = null;

            objCodigo.AppendLine(" \"); ");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" FROM  " + strTabela + "  \");");
            objCodigo.AppendLine(tb + tb + tb + tb + "string sql = strSql.ToString();");
            objCodigo.AppendLine();
            objCodigo.AppendLine(tb + tb + tb + tb + "objDO = new DAL.Dao();");
            objCodigo.AppendLine();
            objCodigo.AppendLine(tb + tb + tb + tb + "// executa consulta e retorna um DataSet");
            objCodigo.AppendLine(tb + tb + tb + tb + "return objDO.GetDataSet(strSql.ToString(), \"" + strTabela + "\");");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "catch (Exception er)");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "throw new Exception(\"Aconteceu um erro:\" + er.Message.ToString()); ");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "finally");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql = null;");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + "}");
            objCodigo.AppendLine();

            // metodo FindAll com orderby--------------------------------
            objCodigo.AppendLine(tb + tb + "/// <summary>");
            objCodigo.AppendLine(tb + tb + "/// Seleciona todos os registros com ordenação e retorna um DataSet.");
            objCodigo.AppendLine(tb + tb + "/// </summary>");
            objCodigo.AppendLine(tb + tb + "/// <param name=\"_orderby\">campo de ordenação</param>");
            objCodigo.AppendLine(tb + tb + "/// <returns>DataSet</returns>");
            objCodigo.AppendLine(tb + tb + "public DataSet FindAll(string _orderby)");
            objCodigo.AppendLine(tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + "try");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql = new StringBuilder();");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" SELECT \"); ");
            //objCodigo.AppendLine(tb + tb + tb + tb + "// colunas");
            objCodigo.Append(tb + tb + tb + tb + "strSql.Append(\" ");

            // pega todas as colunas da tabela

            // Abre conexão
            objBanco = new Banco.Banco(_conexao);
            // Faz a leitura de todas as colunas da tabela
            objDr = objBanco.QueryConsulta("SELECT * FROM " + strTabela);

            nunrec = objDr.FieldCount;

            for (int i = 0; i < nunrec - 1; i++)
            {
                // lista as colunas
                objCodigo.Append(objDr.GetName(i) + ", ");
            }

            // lista a última coluna sem a virgula

            objCodigo.Append(objDr.GetName(nunrec - 1) + " ");

            // Fecha conexão
            objBanco.CloseConn();
            objBanco = null;

            objCodigo.AppendLine(" \"); ");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" FROM  " + strTabela + "  \");");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" ORDER BY \" + _orderby);");
            objCodigo.AppendLine(tb + tb + tb + tb + "string sql = strSql.ToString();");
            objCodigo.AppendLine();
            objCodigo.AppendLine(tb + tb + tb + tb + "objDO = new DAL.Dao();");
            objCodigo.AppendLine();
            objCodigo.AppendLine(tb + tb + tb + tb + "// executa consulta e retorna um DataSet");
            objCodigo.AppendLine(tb + tb + tb + tb + "return objDO.GetDataSet(strSql.ToString(), \"" + strTabela + "\");");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "catch (Exception er)");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "throw new Exception(\"Aconteceu um erro:\" + er.Message.ToString()); ");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "finally");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql = null;");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + "}");
            objCodigo.AppendLine();

            // metodo FindAllByWhere--------------------------------
            objCodigo.AppendLine(tb + tb + "/// <summary>");
            objCodigo.AppendLine(tb + tb + "/// Seleciona todos os registros com filtro.");
            objCodigo.AppendLine(tb + tb + "/// </summary>");
            objCodigo.AppendLine(tb + tb + "/// <param name=\"_filtro (\"id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'\")\">filtro da consulta</param>");
            objCodigo.AppendLine(tb + tb + "/// <returns>DataSet</returns>");
            objCodigo.AppendLine(tb + tb + "public DataSet FindByWhere(string _filtro)");
            objCodigo.AppendLine(tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + "try");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql = new StringBuilder();");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" SELECT \"); ");
            //objCodigo.AppendLine(tb + tb + tb + tb + "// colunas");
            objCodigo.Append(tb + tb + tb + tb + "strSql.Append(\" ");

            // pega todas as colunas da tabela

            // Abre conexão
            objBanco = new Banco.Banco(_conexao);
            // Faz a leitura de todas as colunas da tabela
            objDr = objBanco.QueryConsulta("SELECT * FROM " + strTabela);

            nunrec = objDr.FieldCount;

            for (int i = 0; i < nunrec - 1; i++)
            {
                // lista as colunas
                objCodigo.Append(objDr.GetName(i) + ", ");
            }

            // lista a última coluna sem a virgula

            objCodigo.Append(objDr.GetName(nunrec - 1) + " ");

            // Fecha conexão
            objBanco.CloseConn();
            objBanco = null;

            objCodigo.AppendLine(" \"); ");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" FROM  " + strTabela + "  \");");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" WHERE ( \" + _filtro + \" ) \");");
            objCodigo.AppendLine(tb + tb + tb + tb + "string sql = strSql.ToString();");
            objCodigo.AppendLine();
            objCodigo.AppendLine(tb + tb + tb + tb + "objDO = new DAL.Dao();");
            objCodigo.AppendLine();
            objCodigo.AppendLine(tb + tb + tb + tb + "// executa consulta e retorna um DataSet");
            objCodigo.AppendLine(tb + tb + tb + tb + "return objDO.GetDataSet(strSql.ToString(), \"" + strTabela + "\");");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "catch (Exception er)");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "throw new Exception(\"Aconteceu um erro:\" + er.Message.ToString()); ");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "finally");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql = null;");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + "}");
            objCodigo.AppendLine();

            // metodo FindAllByWhere com ordenação--------------------------------
            objCodigo.AppendLine(tb + tb + "/// <summary>");
            objCodigo.AppendLine(tb + tb + "/// Seleciona todos os registros com filtro e ordenação.");
            objCodigo.AppendLine(tb + tb + "/// </summary>");
            objCodigo.AppendLine(tb + tb + "/// <param name=\"_filtro (\"id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'\")\">filtro da consulta</param>");
            objCodigo.AppendLine(tb + tb + "/// <param name=\"_orderby\">campo de ordenação</param>");
            objCodigo.AppendLine(tb + tb + "/// <returns>DataSet</returns>");
            objCodigo.AppendLine(tb + tb + "public DataSet FindByWhere(string _filtro, string _orderby)");
            objCodigo.AppendLine(tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + "try");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql = new StringBuilder();");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" SELECT \"); ");
            //objCodigo.AppendLine(tb + tb + tb + tb + "// colunas");
            objCodigo.Append(tb + tb + tb + tb + "strSql.Append(\" ");

            // pega todas as colunas da tabela

            // Abre conexão
            objBanco = new Banco.Banco(_conexao);
            // Faz a leitura de todas as colunas da tabela
            objDr = objBanco.QueryConsulta(" SELECT * FROM " + strTabela);

            nunrec = objDr.FieldCount;

            for (int i = 0; i < nunrec - 1; i++)
            {
                // lista as colunas
                objCodigo.Append(objDr.GetName(i) + ", ");
            }

            // lista a última coluna sem a virgula

            objCodigo.Append(objDr.GetName(nunrec - 1) + " ");

            // Fecha conexão
            objBanco.CloseConn();
            objBanco = null;

            objCodigo.AppendLine(" \"); ");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" FROM  " + strTabela + "  \");");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" WHERE ( \" + _filtro + \" ) \");");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" ORDER BY \" + _orderby);");
            objCodigo.AppendLine(tb + tb + tb + tb + "string sql = strSql.ToString();");
            objCodigo.AppendLine();
            objCodigo.AppendLine(tb + tb + tb + tb + "objDO = new DAL.Dao();");
            objCodigo.AppendLine();
            objCodigo.AppendLine(tb + tb + tb + tb + "// executa consulta e retorna um DataSet");
            objCodigo.AppendLine(tb + tb + tb + tb + "return objDO.GetDataSet(strSql.ToString(), \"" + strTabela + "\");");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "catch (Exception er)");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "throw new Exception(\"Aconteceu um erro:\" + er.Message.ToString()); ");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "finally");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql = null;");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + "}");
            objCodigo.AppendLine();

            // MÉTODOS DE SELEÇÃO INDIVIDUAL
            // faz um método de filtro para cada coluna da tabela

            // pega todas as colunas da tabela

            // Abre conexão
            objBanco = new Banco.Banco(_conexao);
            // Faz a leitura de todas as colunas da tabela
            objDr = objBanco.QueryConsulta("SELECT * FROM " + strTabela);
            // Objeto da clase library
            objLib = new Library.Library();
            nunrec = objDr.FieldCount;

            for (int i = 0; i < nunrec; i++)
            {
                // lista as colunas
                // metodo FindAllBy "campo" --------------------------------
                objCodigo.AppendLine(tb + tb + "/// <summary>");
                objCodigo.AppendLine(tb + tb + "/// Seleciona todos os registros por " + objDr.GetName(i) + ".");
                objCodigo.AppendLine(tb + tb + "/// </summary>");
                objCodigo.AppendLine(tb + tb + "/// <param name=\"_" + objDr.GetName(i) + "\">filtro da consulta</param>");
                objCodigo.AppendLine(tb + tb + "/// <returns>DataSet</returns>");
                objCodigo.AppendLine(tb + tb + "public DataSet FindBy_" + objDr.GetName(i) + "(" + objLib.DefineTipo(objDr.GetDataTypeName(i).ToString()) + " _" + objDr.GetName(i) + ")");
                objCodigo.AppendLine(tb + tb + "{");
                objCodigo.AppendLine(tb + tb + tb + "try");
                objCodigo.AppendLine(tb + tb + tb + "{");
                objCodigo.AppendLine(tb + tb + tb + tb + "strSql = new StringBuilder();");
                objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" SELECT \"); ");
                //objCodigo.AppendLine(tb + tb + tb + tb + "// colunas");
                objCodigo.Append(tb + tb + tb + tb + "strSql.Append(\" ");

                for (int j = 0; j < nunrec - 1; j++)
                {
                    // lista as colunas
                    objCodigo.Append(objDr.GetName(j) + ", ");
                }

                // lista a última coluna sem a virgula
                objCodigo.Append(objDr.GetName(nunrec - 1) + " ");

                objCodigo.AppendLine(" \"); ");
                objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" FROM  " + strTabela + "  \");");
                objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" WHERE ( " + objLib.SelectParam(objDr.GetName(i).ToString(), objDr.GetDataTypeName(i).ToString()) + " ) \");");
                objCodigo.AppendLine(tb + tb + tb + tb + "string sql = strSql.ToString();");
                objCodigo.AppendLine();
                objCodigo.AppendLine(tb + tb + tb + tb + "objDO = new DAL.Dao();");
                objCodigo.AppendLine();
                objCodigo.AppendLine(tb + tb + tb + tb + "// executa consulta e retorna um DataSet");
                objCodigo.AppendLine(tb + tb + tb + tb + "return objDO.GetDataSet(strSql.ToString(), \"" + strTabela + "\");");
                objCodigo.AppendLine(tb + tb + tb + "}");
                objCodigo.AppendLine(tb + tb + tb + "catch (Exception er)");
                objCodigo.AppendLine(tb + tb + tb + "{");
                objCodigo.AppendLine(tb + tb + tb + tb + "throw new Exception(\"Aconteceu um erro:\" + er.Message.ToString()); ");
                objCodigo.AppendLine(tb + tb + tb + "}");
                objCodigo.AppendLine(tb + tb + tb + "finally");
                objCodigo.AppendLine(tb + tb + tb + "{");
                objCodigo.AppendLine(tb + tb + tb + tb + "strSql = null;");
                objCodigo.AppendLine(tb + tb + tb + "}");
                objCodigo.AppendLine(tb + tb + "}");
                objCodigo.AppendLine();

                // lista as colunas
                // metodo FindAllBy "campo" --------------------------------
                objCodigo.AppendLine(tb + tb + "/// <summary>");
                objCodigo.AppendLine(tb + tb + "/// Seleciona todos os registros por " + objDr.GetName(i) + ".");
                objCodigo.AppendLine(tb + tb + "/// </summary>");
                objCodigo.AppendLine(tb + tb + "/// <param name=\"_" + objDr.GetName(i) + "\">filtro da consulta</param>");
                objCodigo.AppendLine(tb + tb + "/// <param name=\"_orderby\">campo de ordenação</param>");
                objCodigo.AppendLine(tb + tb + "/// <returns>DataSet</returns>");
                objCodigo.AppendLine(tb + tb + "public DataSet FindBy_" + objDr.GetName(i) + "(" + objLib.DefineTipo(objDr.GetDataTypeName(i).ToString()) + " _" + objDr.GetName(i) + ", string _orderby)");
                objCodigo.AppendLine(tb + tb + "{");
                objCodigo.AppendLine(tb + tb + tb + "try");
                objCodigo.AppendLine(tb + tb + tb + "{");
                objCodigo.AppendLine(tb + tb + tb + tb + "strSql = new StringBuilder();");
                objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" SELECT \"); ");
                //objCodigo.AppendLine(tb + tb + tb + tb + "// colunas");
                objCodigo.Append(tb + tb + tb + tb + "strSql.Append(\" ");

                for (int j = 0; j < nunrec - 1; j++)
                {
                    // lista as colunas
                    objCodigo.Append(objDr.GetName(j) + ", ");
                }

                // lista a última coluna sem a virgula
                objCodigo.Append(objDr.GetName(nunrec - 1) + " ");

                objCodigo.AppendLine(" \"); ");
                objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" FROM  " + strTabela + "  \");");
                objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" WHERE ( " + objLib.SelectParam(objDr.GetName(i).ToString(), objDr.GetDataTypeName(i).ToString()) + " ) \");");
                objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" ORDER BY \" + _orderby);");
                objCodigo.AppendLine(tb + tb + tb + tb + "string sql = strSql.ToString();");
                objCodigo.AppendLine();
                objCodigo.AppendLine(tb + tb + tb + tb + "objDO = new DAL.Dao();");
                objCodigo.AppendLine();
                objCodigo.AppendLine(tb + tb + tb + tb + "// executa consulta e retorna um DataSet");
                objCodigo.AppendLine(tb + tb + tb + tb + "return objDO.GetDataSet(strSql.ToString(), \"" + strTabela + "\");");
                objCodigo.AppendLine(tb + tb + tb + "}");
                objCodigo.AppendLine(tb + tb + tb + "catch (Exception er)");
                objCodigo.AppendLine(tb + tb + tb + "{");
                objCodigo.AppendLine(tb + tb + tb + tb + "throw new Exception(\"Aconteceu um erro:\" + er.Message.ToString()); ");
                objCodigo.AppendLine(tb + tb + tb + "}");
                objCodigo.AppendLine(tb + tb + tb + "finally");
                objCodigo.AppendLine(tb + tb + tb + "{");
                objCodigo.AppendLine(tb + tb + tb + tb + "strSql = null;");
                objCodigo.AppendLine(tb + tb + tb + "}");
                objCodigo.AppendLine(tb + tb + "}");
                objCodigo.AppendLine();


            }

            // lista a última coluna sem a virgula

            // Fecha conexão
            objBanco.CloseConn();
            objBanco = null;

            // fazer toda validação dos campos
            // metodo Insert--------------------------------
            objCodigo.AppendLine(tb + tb + "/// <summary>");
            objCodigo.AppendLine(tb + tb + "/// Insere os registros do banco e retorna o número de linhas afetadas.");
            objCodigo.AppendLine(tb + tb + "/// </summary>");
            objCodigo.AppendLine(tb + tb + "/// <param name=\"tab\">objetos vo do banco</param>");
            objCodigo.AppendLine(tb + tb + "/// <returns>int</returns>");
            objCodigo.AppendLine(tb + tb + "public int Insert(Tab" + tabelaFormatada + " tab)");
            objCodigo.AppendLine(tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + "try");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql = new StringBuilder();");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" INSERT INTO  " + strTabela + "  \"); ");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" (\"); ");

            // pega todas as colunas da tabela

            // Abre conexão
            objBanco = new Banco.Banco(_conexao);
            // Faz a leitura de todas as colunas da tabela
            objDr = objBanco.QueryConsulta("SELECT * FROM " + strTabela);

            nunrec = objDr.FieldCount;

            for (int i = 0; i < nunrec - 1; i++)
            {
                // lista as colunas
                objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" " + objDr.GetName(i) + ", \"); ");
            }

            // lista a última coluna sem a virgula
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" " + objDr.GetName(nunrec - 1) + " \"); ");

            objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" ) \"); ");

            // Valores
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" VALUES (\"); ");

            // objeto da classe Libary
            objLib = new Library.Library();

            for (int i = 0; i < nunrec - 1; i++)
            {
                object valorDefaultColuna = objBanco.RetornaValor("SELECT COLUMN_DEFAULT FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @Tabela AND COLUMN_NAME = @Coluna ",
                new System.Collections.ArrayList() { "@Tabela", "@Coluna" }, new System.Collections.ArrayList() { strTabela, objDr.GetName(i).ToString() });
                if (valorDefaultColuna != DBNull.Value)
                    objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" " + "DEFAULT" + ", \"); ");
                else
                    // lista as colunas
                    objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" " + objLib.InsertParam(objDr.GetName(i).ToString(), objDr.GetDataTypeName(i).ToString()).Replace("_vo", "tab") + ", \"); ");
            }

            object valorDefaultColuna2 = objBanco.RetornaValor("SELECT COLUMN_DEFAULT FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @Tabela AND COLUMN_NAME = @Coluna ",
                new System.Collections.ArrayList() { "@Tabela", "@Coluna" }, new System.Collections.ArrayList() { strTabela, objDr.GetName(nunrec - 1).ToString() });
            if (valorDefaultColuna2 != DBNull.Value)
                objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" " + "DEFAULT" + " )\"); ");
            else
                // lista a última coluna sem a virgula
                objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" " + objLib.InsertParam(objDr.GetName(nunrec - 1).ToString(), objDr.GetDataTypeName(nunrec - 1).ToString()).Replace("_vo", "tab") + " )\"); ");

            //objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" ) \"); ");

            // Fecha conexão
            objBanco.CloseConn();
            objBanco = null;

            objCodigo.AppendLine(tb + tb + tb + tb + "objDO = new DAL.Dao();");
            objCodigo.AppendLine();
            objCodigo.AppendLine(tb + tb + tb + tb + "// executa comando e retorna o número de linhas afetadas.");
            objCodigo.AppendLine(tb + tb + tb + tb + "object retorno = objDO.ExecultarScript(strSql.ToString());");
            objCodigo.AppendLine(tb + tb + tb + tb + "return Convert.ToInt32(retorno.ToString() == \"\" ? 1 : 0 );");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "catch (Exception er)");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "throw new Exception(\"Aconteceu um erro:\" + er.Message.ToString()); ");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "finally");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql = null;");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + "}");
            objCodigo.AppendLine();


            // metodo Update--------------------------------
            objCodigo.AppendLine(tb + tb + "/// <summary>");
            objCodigo.AppendLine(tb + tb + "/// Atualiza os registros do banco e retorna o número de linhas afetadas.");
            objCodigo.AppendLine(tb + tb + "/// </summary>");
            objCodigo.AppendLine(tb + tb + "/// <param name=\"tab\">objetos vo do banco</param>");
            objCodigo.AppendLine(tb + tb + "/// <returns>int</returns>");
            objCodigo.AppendLine(tb + tb + "public int Update(Tab" + tabelaFormatada + " tab)");
            objCodigo.AppendLine(tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + "try");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql = new StringBuilder();");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" UPDATE  " + strTabela + "  \"); ");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" SET \"); ");

            // Abre conexão
            objBanco = new Banco.Banco(_conexao);
            // Faz a leitura de todas as colunas da tabela
            objDr = objBanco.QueryConsulta("SELECT * FROM " + strTabela);
            // Cria o objeto da classe Library
            objLib = new Library.Library();

            nunrec = objDr.FieldCount;

            for (int i = 0; i < nunrec; i++)
            {
                if (i == 0)//1º linha
                {
                    if (objDr.GetName(i).ToString() == "DataCadastro")
                    {
                        if (chkAtualizarCampoDataCadastro)
                        {
                            //sem virgula
                            objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" " + objLib.UpdateParam(objDr.GetName(i).ToString(), objDr.GetDataTypeName(i).ToString()) + " " + " \"); ");
                        }
                        if (!chkAtualizarCampoDataCadastro)
                        {
                            objCodigo.AppendLine(tb + tb + tb + tb + "//strSql.Append(\" " + objLib.UpdateParam(objDr.GetName(i).ToString(), objDr.GetDataTypeName(i).ToString()) + " " + " \"); ");
                        }
                    }
                    else
                    {
                        //sem virgula
                        objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" " + objLib.UpdateParam(objDr.GetName(i).ToString(), objDr.GetDataTypeName(i).ToString()) + " " + " \"); ");
                    }
                }
                else
                {
                    if (objDr.GetName(i).ToString() == "DataCadastro")
                    {
                        if (chkAtualizarCampoDataCadastro)
                        {
                            //com virgula
                            objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\"," + objLib.UpdateParam(objDr.GetName(i).ToString(), objDr.GetDataTypeName(i).ToString()) + " " + " \"); ");
                        }
                        if (!chkAtualizarCampoDataCadastro)
                        {
                            objCodigo.AppendLine(tb + tb + tb + tb + "//strSql.Append(\"," + objLib.UpdateParam(objDr.GetName(i).ToString(), objDr.GetDataTypeName(i).ToString()) + " " + " \"); ");
                        }
                    }
                    else
                    {
                        //com virgula
                        objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\"," + objLib.UpdateParam(objDr.GetName(i).ToString(), objDr.GetDataTypeName(i).ToString()) + " " + " \"); ");
                    }
                }
            }

            objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" WHERE (" + objLib.UpdateParam(objDr.GetName(0).ToString(), objDr.GetDataTypeName(0).ToString()) + " ) \");");

            // Fecha conexão
            objBanco.CloseConn();
            objBanco = null;
            objLib = null;

            objCodigo.AppendLine();
            objCodigo.AppendLine(tb + tb + tb + tb + "objDO = new DAL.Dao();");
            objCodigo.AppendLine();
            objCodigo.AppendLine(tb + tb + tb + tb + "// executa comando e retorna o número de linhas afetadas.");
            objCodigo.AppendLine(tb + tb + tb + tb + "object retorno = objDO.ExecultarScript(strSql.ToString());");
            objCodigo.AppendLine(tb + tb + tb + tb + "return Convert.ToInt32(retorno.ToString() == \"\" ? 1 : 0 );");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "catch (Exception er)");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "throw new Exception(\"Aconteceu um erro:\" + er.Message.ToString()); ");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "finally");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql = null;");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + "}");
            objCodigo.AppendLine();

            // metodo Delete--------------------------------
            objCodigo.AppendLine(tb + tb + "/// <summary>");
            objCodigo.AppendLine(tb + tb + "/// Deleta os registros do banco e retorna o número de linhas afetadas.");
            objCodigo.AppendLine(tb + tb + "/// </summary>");
            objCodigo.AppendLine(tb + tb + "/// <param name=\"tab\">objetos vo do banco</param>");
            objCodigo.AppendLine(tb + tb + "/// <returns>int</returns>");
            objCodigo.AppendLine(tb + tb + "public int Delete(Tab" + tabelaFormatada + " tab)");
            objCodigo.AppendLine(tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + "try");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql = new StringBuilder();");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" DELETE FROM " + strTabela + "  \"); ");

            // Abre conexão
            objBanco = new Banco.Banco(_conexao);
            // Faz a leitura de todas as colunas da tabela
            objDr = objBanco.QueryConsulta("SELECT * FROM " + strTabela);

            objCodigo.AppendLine(tb + tb + tb + tb + "strSql.Append(\" WHERE ( " + objDr.GetName(0).ToString() + " = '\" + tab." + objDr.GetName(0).ToString() + " + \"' ) \");");

            // Fecha conexão
            objBanco.CloseConn();
            objBanco = null;

            objCodigo.AppendLine();
            objCodigo.AppendLine(tb + tb + tb + tb + "objDO = new DAL.Dao();");
            objCodigo.AppendLine();
            objCodigo.AppendLine(tb + tb + tb + tb + "// executa comando e retorna o número de linhas afetadas.");
            objCodigo.AppendLine(tb + tb + tb + tb + "object retorno = objDO.ExecultarScript(strSql.ToString());");
            objCodigo.AppendLine(tb + tb + tb + tb + "return Convert.ToInt32(retorno.ToString() == \"\" ? 1 : 0 );");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "catch (Exception er)");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "throw new Exception(\"Aconteceu um erro:\" + er.Message.ToString()); ");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "finally");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "strSql = null;");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + "}");
            objCodigo.AppendLine();



            // Fim dos métodos BO
            objCodigo.AppendLine(tb + "}");
            objCodigo.AppendLine();

            objCodigo.AppendLine("}");

            return objCodigo;
        }


    }
}
