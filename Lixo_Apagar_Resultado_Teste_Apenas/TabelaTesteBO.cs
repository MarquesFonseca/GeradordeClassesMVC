using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAL;

namespace BLL
{
      /// <summary>
      /// Classe da BLL gerada automática: TabelaTeste
      /// Criador: MARQUES
      /// Criada em 14/06/2021 às 18:07
      /// </summary>
      public class TabelaTesteBO<T>
      {
            // Atributos
            private DAL.Dao objDO = null;
            private StringBuilder strSql = null;

            //Métodos
            /// <summary>
            /// Seleciona todos os registros e retorna um DataSet.
            /// </summary>
            /// <returns>DataSet</returns>
            public IEnumerable<TabTabelaTeste> FindAllLista()
            {
                  try
                  {
                        strSql = new StringBuilder();
                        strSql.Append(" SELECT "); 
                        strSql.Append(" Codigo, Descricao, CampoUm, CampoDois, CampoTres, CampoQuatro, CampoBool, CampoData  "); 
                        strSql.Append(" FROM  TabelaTeste  ");
                        string sql = strSql.ToString();

                        IEnumerable<TabTabelaTeste> lista = new DAL.Dao<TabTabelaTeste>().RetornaLista(strSql.ToString(), new List<TabTabelaTeste>());

                        // retorna lista do tipo do objeto
                        return lista;
                  }
                  catch (Exception er)
                  {
                        throw new Exception("Aconteceu um erro:" + er.Message.ToString()); 
                  }
                  finally
                  {
                        strSql = null;
                  }
            }

            //Métodos
            /// <summary>
            /// Seleciona todos os registros e retorna um DataSet.
            /// </summary>
            /// <returns>DataSet</returns>
            public IEnumerable<TabTabelaTeste> FindAllLista(string _filtro)
            {
                  try
                  {
                        strSql = new StringBuilder();
                        strSql.Append(" SELECT "); 
                        strSql.Append(" Codigo, Descricao, CampoUm, CampoDois, CampoTres, CampoQuatro, CampoBool, CampoData  "); 
                        strSql.Append(" FROM  TabelaTeste  ");
                        strSql.Append(" WHERE ( " + _filtro + " ) ");
                        string sql = strSql.ToString();

                        IEnumerable<TabTabelaTeste> lista = new DAL.Dao<TabTabelaTeste>().RetornaLista(strSql.ToString(), new List<TabTabelaTeste>());

                        // retorna lista do tipo do objeto
                        return lista;
                  }
                  catch (Exception er)
                  {
                        throw new Exception("Aconteceu um erro:" + er.Message.ToString()); 
                  }
                  finally
                  {
                        strSql = null;
                  }
            }

            //Métodos
            /// <summary>
            /// Seleciona todos os registros e retorna um DataSet.
            /// </summary>
            /// <returns>DataSet</returns>
            public DataSet FindAll()
            {
                  try
                  {
                        strSql = new StringBuilder();
                        strSql.Append(" SELECT "); 
                        strSql.Append(" Codigo, Descricao, CampoUm, CampoDois, CampoTres, CampoQuatro, CampoBool, CampoData  "); 
                        strSql.Append(" FROM  TabelaTeste  ");
                        string sql = strSql.ToString();

                        objDO = new DAL.Dao();

                        // executa consulta e retorna um DataSet
                        return objDO.GetDataSet(strSql.ToString(), "TabelaTeste");
                  }
                  catch (Exception er)
                  {
                        throw new Exception("Aconteceu um erro:" + er.Message.ToString()); 
                  }
                  finally
                  {
                        strSql = null;
                  }
            }

            /// <summary>
            /// Seleciona todos os registros com ordenação e retorna um DataSet.
            /// </summary>
            /// <param name="_orderby">campo de ordenação</param>
            /// <returns>DataSet</returns>
            public DataSet FindAll(string _orderby)
            {
                  try
                  {
                        strSql = new StringBuilder();
                        strSql.Append(" SELECT "); 
                        strSql.Append(" Codigo, Descricao, CampoUm, CampoDois, CampoTres, CampoQuatro, CampoBool, CampoData  "); 
                        strSql.Append(" FROM  TabelaTeste  ");
                        strSql.Append(" ORDER BY " + _orderby);
                        string sql = strSql.ToString();

                        objDO = new DAL.Dao();

                        // executa consulta e retorna um DataSet
                        return objDO.GetDataSet(strSql.ToString(), "TabelaTeste");
                  }
                  catch (Exception er)
                  {
                        throw new Exception("Aconteceu um erro:" + er.Message.ToString()); 
                  }
                  finally
                  {
                        strSql = null;
                  }
            }

            /// <summary>
            /// Seleciona todos os registros com filtro.
            /// </summary>
            /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
            /// <returns>DataSet</returns>
            public DataSet FindByWhere(string _filtro)
            {
                  try
                  {
                        strSql = new StringBuilder();
                        strSql.Append(" SELECT "); 
                        strSql.Append(" Codigo, Descricao, CampoUm, CampoDois, CampoTres, CampoQuatro, CampoBool, CampoData  "); 
                        strSql.Append(" FROM  TabelaTeste  ");
                        strSql.Append(" WHERE ( " + _filtro + " ) ");
                        string sql = strSql.ToString();

                        objDO = new DAL.Dao();

                        // executa consulta e retorna um DataSet
                        return objDO.GetDataSet(strSql.ToString(), "TabelaTeste");
                  }
                  catch (Exception er)
                  {
                        throw new Exception("Aconteceu um erro:" + er.Message.ToString()); 
                  }
                  finally
                  {
                        strSql = null;
                  }
            }

            /// <summary>
            /// Seleciona todos os registros com filtro e ordenação.
            /// </summary>
            /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
            /// <param name="_orderby">campo de ordenação</param>
            /// <returns>DataSet</returns>
            public DataSet FindByWhere(string _filtro, string _orderby)
            {
                  try
                  {
                        strSql = new StringBuilder();
                        strSql.Append(" SELECT "); 
                        strSql.Append(" Codigo, Descricao, CampoUm, CampoDois, CampoTres, CampoQuatro, CampoBool, CampoData  "); 
                        strSql.Append(" FROM  TabelaTeste  ");
                        strSql.Append(" WHERE ( " + _filtro + " ) ");
                        strSql.Append(" ORDER BY " + _orderby);
                        string sql = strSql.ToString();

                        objDO = new DAL.Dao();

                        // executa consulta e retorna um DataSet
                        return objDO.GetDataSet(strSql.ToString(), "TabelaTeste");
                  }
                  catch (Exception er)
                  {
                        throw new Exception("Aconteceu um erro:" + er.Message.ToString()); 
                  }
                  finally
                  {
                        strSql = null;
                  }
            }

            /// <summary>
            /// Seleciona todos os registros por Codigo.
            /// </summary>
            /// <param name="_Codigo">filtro da consulta</param>
            /// <returns>DataSet</returns>
            public DataSet FindBy_Codigo(int _Codigo)
            {
                  try
                  {
                        strSql = new StringBuilder();
                        strSql.Append(" SELECT "); 
                        strSql.Append(" Codigo, Descricao, CampoUm, CampoDois, CampoTres, CampoQuatro, CampoBool, CampoData  "); 
                        strSql.Append(" FROM  TabelaTeste  ");
                        strSql.Append(" WHERE (  Codigo =   " + _Codigo + "  ) ");
                        string sql = strSql.ToString();

                        objDO = new DAL.Dao();

                        // executa consulta e retorna um DataSet
                        return objDO.GetDataSet(strSql.ToString(), "TabelaTeste");
                  }
                  catch (Exception er)
                  {
                        throw new Exception("Aconteceu um erro:" + er.Message.ToString()); 
                  }
                  finally
                  {
                        strSql = null;
                  }
            }

            /// <summary>
            /// Seleciona todos os registros por Codigo.
            /// </summary>
            /// <param name="_Codigo">filtro da consulta</param>
            /// <param name="_orderby">campo de ordenação</param>
            /// <returns>DataSet</returns>
            public DataSet FindBy_Codigo(int _Codigo, string _orderby)
            {
                  try
                  {
                        strSql = new StringBuilder();
                        strSql.Append(" SELECT "); 
                        strSql.Append(" Codigo, Descricao, CampoUm, CampoDois, CampoTres, CampoQuatro, CampoBool, CampoData  "); 
                        strSql.Append(" FROM  TabelaTeste  ");
                        strSql.Append(" WHERE (  Codigo =   " + _Codigo + "  ) ");
                        strSql.Append(" ORDER BY " + _orderby);
                        string sql = strSql.ToString();

                        objDO = new DAL.Dao();

                        // executa consulta e retorna um DataSet
                        return objDO.GetDataSet(strSql.ToString(), "TabelaTeste");
                  }
                  catch (Exception er)
                  {
                        throw new Exception("Aconteceu um erro:" + er.Message.ToString()); 
                  }
                  finally
                  {
                        strSql = null;
                  }
            }

            /// <summary>
            /// Seleciona todos os registros por Descricao.
            /// </summary>
            /// <param name="_Descricao">filtro da consulta</param>
            /// <returns>DataSet</returns>
            public DataSet FindBy_Descricao(string _Descricao)
            {
                  try
                  {
                        strSql = new StringBuilder();
                        strSql.Append(" SELECT "); 
                        strSql.Append(" Codigo, Descricao, CampoUm, CampoDois, CampoTres, CampoQuatro, CampoBool, CampoData  "); 
                        strSql.Append(" FROM  TabelaTeste  ");
                        strSql.Append(" WHERE (  Descricao =  '" + _Descricao + "'  ) ");
                        string sql = strSql.ToString();

                        objDO = new DAL.Dao();

                        // executa consulta e retorna um DataSet
                        return objDO.GetDataSet(strSql.ToString(), "TabelaTeste");
                  }
                  catch (Exception er)
                  {
                        throw new Exception("Aconteceu um erro:" + er.Message.ToString()); 
                  }
                  finally
                  {
                        strSql = null;
                  }
            }

            /// <summary>
            /// Seleciona todos os registros por Descricao.
            /// </summary>
            /// <param name="_Descricao">filtro da consulta</param>
            /// <param name="_orderby">campo de ordenação</param>
            /// <returns>DataSet</returns>
            public DataSet FindBy_Descricao(string _Descricao, string _orderby)
            {
                  try
                  {
                        strSql = new StringBuilder();
                        strSql.Append(" SELECT "); 
                        strSql.Append(" Codigo, Descricao, CampoUm, CampoDois, CampoTres, CampoQuatro, CampoBool, CampoData  "); 
                        strSql.Append(" FROM  TabelaTeste  ");
                        strSql.Append(" WHERE (  Descricao =  '" + _Descricao + "'  ) ");
                        strSql.Append(" ORDER BY " + _orderby);
                        string sql = strSql.ToString();

                        objDO = new DAL.Dao();

                        // executa consulta e retorna um DataSet
                        return objDO.GetDataSet(strSql.ToString(), "TabelaTeste");
                  }
                  catch (Exception er)
                  {
                        throw new Exception("Aconteceu um erro:" + er.Message.ToString()); 
                  }
                  finally
                  {
                        strSql = null;
                  }
            }

            /// <summary>
            /// Seleciona todos os registros por CampoUm.
            /// </summary>
            /// <param name="_CampoUm">filtro da consulta</param>
            /// <returns>DataSet</returns>
            public DataSet FindBy_CampoUm(string _CampoUm)
            {
                  try
                  {
                        strSql = new StringBuilder();
                        strSql.Append(" SELECT "); 
                        strSql.Append(" Codigo, Descricao, CampoUm, CampoDois, CampoTres, CampoQuatro, CampoBool, CampoData  "); 
                        strSql.Append(" FROM  TabelaTeste  ");
                        strSql.Append(" WHERE (  CampoUm =  '" + _CampoUm + "'  ) ");
                        string sql = strSql.ToString();

                        objDO = new DAL.Dao();

                        // executa consulta e retorna um DataSet
                        return objDO.GetDataSet(strSql.ToString(), "TabelaTeste");
                  }
                  catch (Exception er)
                  {
                        throw new Exception("Aconteceu um erro:" + er.Message.ToString()); 
                  }
                  finally
                  {
                        strSql = null;
                  }
            }

            /// <summary>
            /// Seleciona todos os registros por CampoUm.
            /// </summary>
            /// <param name="_CampoUm">filtro da consulta</param>
            /// <param name="_orderby">campo de ordenação</param>
            /// <returns>DataSet</returns>
            public DataSet FindBy_CampoUm(string _CampoUm, string _orderby)
            {
                  try
                  {
                        strSql = new StringBuilder();
                        strSql.Append(" SELECT "); 
                        strSql.Append(" Codigo, Descricao, CampoUm, CampoDois, CampoTres, CampoQuatro, CampoBool, CampoData  "); 
                        strSql.Append(" FROM  TabelaTeste  ");
                        strSql.Append(" WHERE (  CampoUm =  '" + _CampoUm + "'  ) ");
                        strSql.Append(" ORDER BY " + _orderby);
                        string sql = strSql.ToString();

                        objDO = new DAL.Dao();

                        // executa consulta e retorna um DataSet
                        return objDO.GetDataSet(strSql.ToString(), "TabelaTeste");
                  }
                  catch (Exception er)
                  {
                        throw new Exception("Aconteceu um erro:" + er.Message.ToString()); 
                  }
                  finally
                  {
                        strSql = null;
                  }
            }

            /// <summary>
            /// Seleciona todos os registros por CampoDois.
            /// </summary>
            /// <param name="_CampoDois">filtro da consulta</param>
            /// <returns>DataSet</returns>
            public DataSet FindBy_CampoDois(string _CampoDois)
            {
                  try
                  {
                        strSql = new StringBuilder();
                        strSql.Append(" SELECT "); 
                        strSql.Append(" Codigo, Descricao, CampoUm, CampoDois, CampoTres, CampoQuatro, CampoBool, CampoData  "); 
                        strSql.Append(" FROM  TabelaTeste  ");
                        strSql.Append(" WHERE (  CampoDois =  '" + _CampoDois + "'  ) ");
                        string sql = strSql.ToString();

                        objDO = new DAL.Dao();

                        // executa consulta e retorna um DataSet
                        return objDO.GetDataSet(strSql.ToString(), "TabelaTeste");
                  }
                  catch (Exception er)
                  {
                        throw new Exception("Aconteceu um erro:" + er.Message.ToString()); 
                  }
                  finally
                  {
                        strSql = null;
                  }
            }

            /// <summary>
            /// Seleciona todos os registros por CampoDois.
            /// </summary>
            /// <param name="_CampoDois">filtro da consulta</param>
            /// <param name="_orderby">campo de ordenação</param>
            /// <returns>DataSet</returns>
            public DataSet FindBy_CampoDois(string _CampoDois, string _orderby)
            {
                  try
                  {
                        strSql = new StringBuilder();
                        strSql.Append(" SELECT "); 
                        strSql.Append(" Codigo, Descricao, CampoUm, CampoDois, CampoTres, CampoQuatro, CampoBool, CampoData  "); 
                        strSql.Append(" FROM  TabelaTeste  ");
                        strSql.Append(" WHERE (  CampoDois =  '" + _CampoDois + "'  ) ");
                        strSql.Append(" ORDER BY " + _orderby);
                        string sql = strSql.ToString();

                        objDO = new DAL.Dao();

                        // executa consulta e retorna um DataSet
                        return objDO.GetDataSet(strSql.ToString(), "TabelaTeste");
                  }
                  catch (Exception er)
                  {
                        throw new Exception("Aconteceu um erro:" + er.Message.ToString()); 
                  }
                  finally
                  {
                        strSql = null;
                  }
            }

            /// <summary>
            /// Seleciona todos os registros por CampoTres.
            /// </summary>
            /// <param name="_CampoTres">filtro da consulta</param>
            /// <returns>DataSet</returns>
            public DataSet FindBy_CampoTres(string _CampoTres)
            {
                  try
                  {
                        strSql = new StringBuilder();
                        strSql.Append(" SELECT "); 
                        strSql.Append(" Codigo, Descricao, CampoUm, CampoDois, CampoTres, CampoQuatro, CampoBool, CampoData  "); 
                        strSql.Append(" FROM  TabelaTeste  ");
                        strSql.Append(" WHERE (  CampoTres =  '" + _CampoTres + "'  ) ");
                        string sql = strSql.ToString();

                        objDO = new DAL.Dao();

                        // executa consulta e retorna um DataSet
                        return objDO.GetDataSet(strSql.ToString(), "TabelaTeste");
                  }
                  catch (Exception er)
                  {
                        throw new Exception("Aconteceu um erro:" + er.Message.ToString()); 
                  }
                  finally
                  {
                        strSql = null;
                  }
            }

            /// <summary>
            /// Seleciona todos os registros por CampoTres.
            /// </summary>
            /// <param name="_CampoTres">filtro da consulta</param>
            /// <param name="_orderby">campo de ordenação</param>
            /// <returns>DataSet</returns>
            public DataSet FindBy_CampoTres(string _CampoTres, string _orderby)
            {
                  try
                  {
                        strSql = new StringBuilder();
                        strSql.Append(" SELECT "); 
                        strSql.Append(" Codigo, Descricao, CampoUm, CampoDois, CampoTres, CampoQuatro, CampoBool, CampoData  "); 
                        strSql.Append(" FROM  TabelaTeste  ");
                        strSql.Append(" WHERE (  CampoTres =  '" + _CampoTres + "'  ) ");
                        strSql.Append(" ORDER BY " + _orderby);
                        string sql = strSql.ToString();

                        objDO = new DAL.Dao();

                        // executa consulta e retorna um DataSet
                        return objDO.GetDataSet(strSql.ToString(), "TabelaTeste");
                  }
                  catch (Exception er)
                  {
                        throw new Exception("Aconteceu um erro:" + er.Message.ToString()); 
                  }
                  finally
                  {
                        strSql = null;
                  }
            }

            /// <summary>
            /// Seleciona todos os registros por CampoQuatro.
            /// </summary>
            /// <param name="_CampoQuatro">filtro da consulta</param>
            /// <returns>DataSet</returns>
            public DataSet FindBy_CampoQuatro(string _CampoQuatro)
            {
                  try
                  {
                        strSql = new StringBuilder();
                        strSql.Append(" SELECT "); 
                        strSql.Append(" Codigo, Descricao, CampoUm, CampoDois, CampoTres, CampoQuatro, CampoBool, CampoData  "); 
                        strSql.Append(" FROM  TabelaTeste  ");
                        strSql.Append(" WHERE (  CampoQuatro =  '" + _CampoQuatro + "'  ) ");
                        string sql = strSql.ToString();

                        objDO = new DAL.Dao();

                        // executa consulta e retorna um DataSet
                        return objDO.GetDataSet(strSql.ToString(), "TabelaTeste");
                  }
                  catch (Exception er)
                  {
                        throw new Exception("Aconteceu um erro:" + er.Message.ToString()); 
                  }
                  finally
                  {
                        strSql = null;
                  }
            }

            /// <summary>
            /// Seleciona todos os registros por CampoQuatro.
            /// </summary>
            /// <param name="_CampoQuatro">filtro da consulta</param>
            /// <param name="_orderby">campo de ordenação</param>
            /// <returns>DataSet</returns>
            public DataSet FindBy_CampoQuatro(string _CampoQuatro, string _orderby)
            {
                  try
                  {
                        strSql = new StringBuilder();
                        strSql.Append(" SELECT "); 
                        strSql.Append(" Codigo, Descricao, CampoUm, CampoDois, CampoTres, CampoQuatro, CampoBool, CampoData  "); 
                        strSql.Append(" FROM  TabelaTeste  ");
                        strSql.Append(" WHERE (  CampoQuatro =  '" + _CampoQuatro + "'  ) ");
                        strSql.Append(" ORDER BY " + _orderby);
                        string sql = strSql.ToString();

                        objDO = new DAL.Dao();

                        // executa consulta e retorna um DataSet
                        return objDO.GetDataSet(strSql.ToString(), "TabelaTeste");
                  }
                  catch (Exception er)
                  {
                        throw new Exception("Aconteceu um erro:" + er.Message.ToString()); 
                  }
                  finally
                  {
                        strSql = null;
                  }
            }

            /// <summary>
            /// Seleciona todos os registros por CampoBool.
            /// </summary>
            /// <param name="_CampoBool">filtro da consulta</param>
            /// <returns>DataSet</returns>
            public DataSet FindBy_CampoBool(bool _CampoBool)
            {
                  try
                  {
                        strSql = new StringBuilder();
                        strSql.Append(" SELECT "); 
                        strSql.Append(" Codigo, Descricao, CampoUm, CampoDois, CampoTres, CampoQuatro, CampoBool, CampoData  "); 
                        strSql.Append(" FROM  TabelaTeste  ");
                        strSql.Append(" WHERE (  CampoBool =   " + _CampoBool + "  ) ");
                        string sql = strSql.ToString();

                        objDO = new DAL.Dao();

                        // executa consulta e retorna um DataSet
                        return objDO.GetDataSet(strSql.ToString(), "TabelaTeste");
                  }
                  catch (Exception er)
                  {
                        throw new Exception("Aconteceu um erro:" + er.Message.ToString()); 
                  }
                  finally
                  {
                        strSql = null;
                  }
            }

            /// <summary>
            /// Seleciona todos os registros por CampoBool.
            /// </summary>
            /// <param name="_CampoBool">filtro da consulta</param>
            /// <param name="_orderby">campo de ordenação</param>
            /// <returns>DataSet</returns>
            public DataSet FindBy_CampoBool(bool _CampoBool, string _orderby)
            {
                  try
                  {
                        strSql = new StringBuilder();
                        strSql.Append(" SELECT "); 
                        strSql.Append(" Codigo, Descricao, CampoUm, CampoDois, CampoTres, CampoQuatro, CampoBool, CampoData  "); 
                        strSql.Append(" FROM  TabelaTeste  ");
                        strSql.Append(" WHERE (  CampoBool =   " + _CampoBool + "  ) ");
                        strSql.Append(" ORDER BY " + _orderby);
                        string sql = strSql.ToString();

                        objDO = new DAL.Dao();

                        // executa consulta e retorna um DataSet
                        return objDO.GetDataSet(strSql.ToString(), "TabelaTeste");
                  }
                  catch (Exception er)
                  {
                        throw new Exception("Aconteceu um erro:" + er.Message.ToString()); 
                  }
                  finally
                  {
                        strSql = null;
                  }
            }

            /// <summary>
            /// Seleciona todos os registros por CampoData.
            /// </summary>
            /// <param name="_CampoData">filtro da consulta</param>
            /// <returns>DataSet</returns>
            public DataSet FindBy_CampoData(DateTime _CampoData)
            {
                  try
                  {
                        strSql = new StringBuilder();
                        strSql.Append(" SELECT "); 
                        strSql.Append(" Codigo, Descricao, CampoUm, CampoDois, CampoTres, CampoQuatro, CampoBool, CampoData  "); 
                        strSql.Append(" FROM  TabelaTeste  ");
                        strSql.Append(" WHERE (  CampoData = CONVERT(DATETIME, '" + _CampoData + "', 103)  ) ");
                        string sql = strSql.ToString();

                        objDO = new DAL.Dao();

                        // executa consulta e retorna um DataSet
                        return objDO.GetDataSet(strSql.ToString(), "TabelaTeste");
                  }
                  catch (Exception er)
                  {
                        throw new Exception("Aconteceu um erro:" + er.Message.ToString()); 
                  }
                  finally
                  {
                        strSql = null;
                  }
            }

            /// <summary>
            /// Seleciona todos os registros por CampoData.
            /// </summary>
            /// <param name="_CampoData">filtro da consulta</param>
            /// <param name="_orderby">campo de ordenação</param>
            /// <returns>DataSet</returns>
            public DataSet FindBy_CampoData(DateTime _CampoData, string _orderby)
            {
                  try
                  {
                        strSql = new StringBuilder();
                        strSql.Append(" SELECT "); 
                        strSql.Append(" Codigo, Descricao, CampoUm, CampoDois, CampoTres, CampoQuatro, CampoBool, CampoData  "); 
                        strSql.Append(" FROM  TabelaTeste  ");
                        strSql.Append(" WHERE (  CampoData = CONVERT(DATETIME, '" + _CampoData + "', 103)  ) ");
                        strSql.Append(" ORDER BY " + _orderby);
                        string sql = strSql.ToString();

                        objDO = new DAL.Dao();

                        // executa consulta e retorna um DataSet
                        return objDO.GetDataSet(strSql.ToString(), "TabelaTeste");
                  }
                  catch (Exception er)
                  {
                        throw new Exception("Aconteceu um erro:" + er.Message.ToString()); 
                  }
                  finally
                  {
                        strSql = null;
                  }
            }

            /// <summary>
            /// Insere os registros do banco e retorna o número de linhas afetadas.
            /// </summary>
            /// <param name="tab">objetos vo do banco</param>
            /// <returns>int</returns>
            public int Insert(TabTabelaTeste tab)
            {
                  try
                  {
                        strSql = new StringBuilder();
                        strSql.Append(" INSERT INTO  TabelaTeste  "); 
                        strSql.Append(" ("); 
                        strSql.Append(" Codigo, "); 
                        strSql.Append(" Descricao, "); 
                        strSql.Append(" CampoUm, "); 
                        strSql.Append(" CampoDois, "); 
                        strSql.Append(" CampoTres, "); 
                        strSql.Append(" CampoQuatro, "); 
                        strSql.Append(" CampoBool, "); 
                        strSql.Append(" CampoData "); 
                        strSql.Append(" ) "); 
                        strSql.Append(" VALUES ("); 
                        strSql.Append(" " + tab.Codigo + " , "); 
                        strSql.Append("  '" + tab.Descricao + "' , "); 
                        strSql.Append("  '" + tab.CampoUm + "' , "); 
                        strSql.Append("  '" + tab.CampoDois + "' , "); 
                        strSql.Append("  '" + tab.CampoTres + "' , "); 
                        strSql.Append("  '" + tab.CampoQuatro + "' , "); 
                        strSql.Append("  '" + tab.CampoBool + "' , "); 
                        strSql.Append("  CONVERT(DATETIME, '" + tab.CampoData + "', 103)  )"); 
                        objDO = new DAL.Dao();

                        // executa comando e retorna o número de linhas afetadas.
                        object retorno = objDO.ExecultarScript(strSql.ToString());
                        return Convert.ToInt32(retorno.ToString() == "" ? 1 : 0 );
                  }
                  catch (Exception er)
                  {
                        throw new Exception("Aconteceu um erro:" + er.Message.ToString()); 
                  }
                  finally
                  {
                        strSql = null;
                  }
            }

            /// <summary>
            /// Atualiza os registros do banco e retorna o número de linhas afetadas.
            /// </summary>
            /// <param name="tab">objetos vo do banco</param>
            /// <returns>int</returns>
            public int Update(TabTabelaTeste tab)
            {
                  try
                  {
                        strSql = new StringBuilder();
                        strSql.Append(" UPDATE  TabelaTeste  "); 
                        strSql.Append(" SET "); 
                        strSql.Append("  Codigo =   " + tab.Codigo + "   "); 
                        strSql.Append(", Descricao =  '" + tab.Descricao + "'   "); 
                        strSql.Append(", CampoUm =  '" + tab.CampoUm + "'   "); 
                        strSql.Append(", CampoDois =  '" + tab.CampoDois + "'   "); 
                        strSql.Append(", CampoTres =  '" + tab.CampoTres + "'   "); 
                        strSql.Append(", CampoQuatro =  '" + tab.CampoQuatro + "'   "); 
                        strSql.Append(", CampoBool =   '" + tab.CampoBool + "'   "); 
                        strSql.Append(", CampoData = CONVERT(DATETIME, '" + tab.CampoData + "' , 103)   "); 
                        strSql.Append(" WHERE ( Codigo =   " + tab.Codigo + "  ) ");

                        objDO = new DAL.Dao();

                        // executa comando e retorna o número de linhas afetadas.
                        object retorno = objDO.ExecultarScript(strSql.ToString());
                        return Convert.ToInt32(retorno.ToString() == "" ? 1 : 0 );
                  }
                  catch (Exception er)
                  {
                        throw new Exception("Aconteceu um erro:" + er.Message.ToString()); 
                  }
                  finally
                  {
                        strSql = null;
                  }
            }

            /// <summary>
            /// Deleta os registros do banco e retorna o número de linhas afetadas.
            /// </summary>
            /// <param name="tab">objetos vo do banco</param>
            /// <returns>int</returns>
            public int Delete(TabTabelaTeste tab)
            {
                  try
                  {
                        strSql = new StringBuilder();
                        strSql.Append(" DELETE FROM TabelaTeste  "); 
                        strSql.Append(" WHERE ( Codigo = '" + tab.Codigo + "' ) ");

                        objDO = new DAL.Dao();

                        // executa comando e retorna o número de linhas afetadas.
                        object retorno = objDO.ExecultarScript(strSql.ToString());
                        return Convert.ToInt32(retorno.ToString() == "" ? 1 : 0 );
                  }
                  catch (Exception er)
                  {
                        throw new Exception("Aconteceu um erro:" + er.Message.ToString()); 
                  }
                  finally
                  {
                        strSql = null;
                  }
            }

      }

}
