using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GeradorController
{
    /// <summary>
    /// Classe VO
    /// Criador: Marques Silva Fonseca
    /// Criada em 22/03/2012
    /// Contato: marques-fonseca@hotmail.com
    /// </summary>
    public class GeradorController
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
        public string colunaPrimaria = "";

        // Contrutor
        public GeradorController()
        {
            strData = DateTime.Today.ToShortDateString() + " às " + DateTime.Now.ToShortTimeString();
            s = " ";
            tb = "      ";

        }

        // Metodos
        public StringBuilder GeraCodigoController(string _nomeNameSpaceProjeto, string _tabela, string _conexao, string _banco)
        {
            string strTabela = _tabela;

            objCodigo = new StringBuilder();

            #region Inicial...
            objCodigo.AppendLine("using System;");
            objCodigo.AppendLine("using System.Collections.Generic;");
            objCodigo.AppendLine("using System.Collections;");
            objCodigo.AppendLine("using System.Linq;");
            objCodigo.AppendLine("using System.Text;");
            objCodigo.AppendLine("using System.Web.Mvc;");
            objCodigo.AppendLine("using DTO;");
            objCodigo.AppendLine("using BLL;");
            objCodigo.AppendLine();
            objCodigo.AppendLine("/// <summary>");
            objCodigo.AppendLine("/// Classe Controller gerada automática: " + strTabela);
            if (Environment.MachineName == "MARQUESNOTE-PC")
                objCodigo.AppendLine(tb + "/// Criador: Marques Silva Fonseca");
            else objCodigo.AppendLine(tb + "/// Criador: " + Environment.UserName);
            objCodigo.AppendLine("/// Criada em " + strData);
            //objCodigo.AppendLine("/// Contato: marques-fonseca@hotmail.com");
            objCodigo.AppendLine("/// </summary>");
            objCodigo.AppendLine("namespace " + _nomeNameSpaceProjeto + ".Controllers");
            objCodigo.AppendLine("{");

            string tabelaFormatada = strTabela.Replace("_", "").Replace("-", "");

            string objtoBLLAtual = tabelaFormatada + "BO";//TabelaBO
            string objetoDTOAtual = "Tab" + tabelaFormatada;//TabTabela
            System.Globalization.CultureInfo cultureinfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            string tabelaMinusculo = tabelaFormatada.ToLower();//tabela
            string tabelaMinusculoBO = cultureinfo.TextInfo.ToTitleCase(tabelaFormatada) + "BO";//tabelaBO

            // Abre conexão com o banco
            objBanco = new Banco.Banco(_conexao);
            // Cria o objeto da classe Library
            objLib = new Library.Library();

            objCodigo.AppendLine(tb + "[Authorize]");
            objCodigo.AppendLine(tb + "public class " + tabelaFormatada + "Controller : Controller");
            objCodigo.AppendLine(tb + "{");
            if (strTabela.Substring(0, 2).ToLower() != "vw") 
                objCodigo.AppendLine(tb + tb + string.Format("//{0}<{1}> {2} = new {3}<{4}>();", "Vw" + objtoBLLAtual, "Tab" + "Vw" + tabelaFormatada, "Vw" + tabelaMinusculoBO, "Vw" + objtoBLLAtual, "Tab" + "Vw" + tabelaFormatada));
            objCodigo.AppendLine(tb + tb + string.Format("{0}<{1}> {2} = new {3}<{4}>();", objtoBLLAtual, objetoDTOAtual, tabelaMinusculoBO, objtoBLLAtual, objetoDTOAtual));
            objCodigo.AppendLine();
            #endregion


            #region Index
            objCodigo.AppendLine(tb + "// GET: " + tabelaFormatada + "");
            objCodigo.AppendLine(tb + "public ActionResult Index()");
            objCodigo.AppendLine(tb + "{");
            //objCodigo.AppendLine(tb + tb + "ViewBag.Qtd = new DAL.Dao().ExecultarScript(\"Select count(*) from Modulo\");");
            if (strTabela.Substring(0, 2).ToLower() != "vw")
                objCodigo.AppendLine(tb + tb + "//IEnumerable<" + "Tab" + "Vw" + tabelaFormatada + "> listaRetornada = " + "Vw" + tabelaMinusculoBO + ".FindAllLista().AsEnumerable<" + "Tab" + "Vw" + tabelaFormatada + ">().OrderByDescending(M => M.DataCadastro);");
            objCodigo.AppendLine(tb + tb + "IEnumerable<" + objetoDTOAtual + "> listaRetornada = " + tabelaMinusculoBO + ".FindAllLista().AsEnumerable<" + objetoDTOAtual + ">().OrderByDescending(M => M.DataCadastro);");
            objCodigo.AppendLine(tb + tb + "return View(listaRetornada);");
            objCodigo.AppendLine(tb + "}");
            objCodigo.AppendLine();
            #endregion


            #region Details
            // Abre conexão
            objBanco = new Banco.Banco(_conexao);
            // Faz a leitura de todas as colunas da tabela
            objDr = objBanco.QueryConsulta("SELECT * FROM " + strTabela);
            nunrec = objDr.FieldCount;
            // objeto da classe Libary
            objLib = new Library.Library();

            objCodigo.AppendLine(tb + "// GET: " + tabelaFormatada + "/Details/5");
            if (nunrec > 0)
            {
                string tipoParametro = objLib.DefineTipo(objDr.GetDataTypeName(0).ToString());
                if (tipoParametro == "Guid")
                {
                    objCodigo.AppendLine(tb + "public ActionResult Details(string id)");
                    objCodigo.AppendLine(tb + "{");
                    //objCodigo.AppendLine(tb + tb + "System.Data.DataSet dsRetornado = " + tabelaMinusculoBO + ".FindBy_" + tabelaFormatada + "Id(new Guid(id));");
                }
                else if (tipoParametro == "string")
                {
                    objCodigo.AppendLine(tb + "public ActionResult Details(string id)");
                    objCodigo.AppendLine(tb + "{");
                    //objCodigo.AppendLine(tb + tb + "System.Data.DataSet dsRetornado = " + tabelaMinusculoBO + ".FindBy_" + tabelaFormatada + "Id(id);");
                }
                else
                {
                    objCodigo.AppendLine(tb + "public ActionResult Details(int id)");
                    objCodigo.AppendLine(tb + "{");
                    //objCodigo.AppendLine(tb + tb + "System.Data.DataSet dsRetornado = " + tabelaMinusculoBO + ".FindBy_" + tabelaFormatada + "Id(id);");
                }
            }
            if (strTabela.Substring(0, 2).ToLower() != "vw") 
                objCodigo.AppendLine(tb + tb + "//List<" + "Tab" + "Vw" + tabelaFormatada + "> listaRetornada = " + "Vw" + tabelaMinusculoBO + ".FindAllLista(string.Format(\"" + objDr.GetName(0) + " = '{0}'\", id)).ToList();");
            objCodigo.AppendLine(tb + tb + "List<" + objetoDTOAtual + "> listaRetornada = " + tabelaMinusculoBO + ".FindAllLista(string.Format(\"" + objDr.GetName(0) + " = '{0}'\", id)).ToList();");
            objCodigo.AppendLine("");
            objCodigo.AppendLine(tb + tb + "if (listaRetornada.Count() > 0)");
            objCodigo.AppendLine(tb + tb + "{");
            objCodigo.AppendLine(tb + tb + "    return View(listaRetornada[0]);");
            objCodigo.AppendLine(tb + tb + "}");
            objCodigo.AppendLine(tb + tb + "else");
            objCodigo.AppendLine(tb + tb + "{");
            objCodigo.AppendLine(tb + tb + "    //Não retornou nenhum registro");
            objCodigo.AppendLine(tb + tb + "    return RedirectToAction(\"Index\");");
            objCodigo.AppendLine(tb + tb + "}");
            objCodigo.AppendLine(tb + "}");
            objCodigo.AppendLine("");

            // Fecha conexão
            objBanco.CloseConn();
            objBanco = null;

            #endregion


            #region Create
            objCodigo.AppendLine(tb + "// GET: " + tabelaFormatada + "/Create");
            objCodigo.AppendLine(tb + "public ActionResult Create()");
            objCodigo.AppendLine(tb + "{");
            List<string> ColunasRelacionadasForengKey = RetornaColunasRelacionadasForengKey(nomeTabela: strTabela, conexao: _conexao);
            List<string> ColunasReferenciadas = RetornaColunasReferenciadas(nomeTabela: strTabela, conexao: _conexao);
            List<string> TabelaReferenciada = RetornaTabelaReferenciadas(nomeTabela: strTabela, conexao: _conexao);
            for (int i = 0; i < ColunasRelacionadasForengKey.Count; i++)
                objCodigo.AppendLine(tb + tb + "ViewBag." + ColunasRelacionadasForengKey[i] + " = new SelectList(new " + TabelaReferenciada[i] + "BO<Tab" + TabelaReferenciada[i] + ">().FindAllLista(), \"" + ColunasReferenciadas[0] + "\", \"Descricao\");");
            objCodigo.AppendLine(tb + tb + "return View();");
            objCodigo.AppendLine(tb + "}");
            objCodigo.AppendLine();
            #endregion


            #region Create
            // Abre conexão
            objBanco = new Banco.Banco(_conexao);
            // Faz a leitura de todas as colunas da tabela
            objDr = objBanco.QueryConsulta("SELECT * FROM " + strTabela);
            nunrec = objDr.FieldCount;
            // objeto da classe Libary
            objLib = new Library.Library();

            objCodigo.AppendLine(tb + "// POST: " + tabelaFormatada + "/Create");
            objCodigo.AppendLine(tb + "[HttpPost]");
            objCodigo.AppendLine(tb + "public ActionResult Create(" + objetoDTOAtual + " tab)");
            objCodigo.AppendLine(tb + "{");
            objCodigo.AppendLine(tb + tb + "    try");
            objCodigo.AppendLine(tb + tb + "    {");
            objCodigo.AppendLine(tb + tb + "        #region Validações e regras específicas para essa operação");
            objCodigo.AppendLine(tb + tb + "        //if (string.IsNullOrEmpty(Convert.ToString(tab.Descricao)))");
            objCodigo.AppendLine(tb + tb + "        //{");
            objCodigo.AppendLine(tb + tb + "        //    ModelState.AddModelError(\"Descricao\", \"Informe uma descrição!\");");
            objCodigo.AppendLine(tb + tb + "        //}");
            objCodigo.AppendLine(tb + tb + "        #endregion");
            objCodigo.AppendLine(tb + tb + "        ");
            objCodigo.AppendLine(tb + tb + "        if (!ModelState.IsValid)");
            objCodigo.AppendLine(tb + tb + "            return Create();");
            objCodigo.AppendLine("");
            objCodigo.AppendLine("tab." + objDr.GetName(0) + " = Guid.NewGuid();");
            objCodigo.AppendLine("");
            objCodigo.AppendLine("#region modelo anterior");
            objCodigo.AppendLine(tb + tb + tb + "//" + objetoDTOAtual + " " + tabelaMinusculo + " = new " + objetoDTOAtual + "();");


            for (int i = 0; i < nunrec; i++)
            {
                //string colunaAtual = objDr.GetName(i).ToString();
                //string tipo = objLib.DefineTipo(objDr.GetDataTypeName(i).ToString());
                //colunaPrimaria = objDr.GetName(0).ToString();
                //// lista as colunas
                //if (objDr.GetName(i).ToString() == objDr.GetName(0).ToString() && objLib.DefineTipo(objDr.GetDataTypeName(0).ToString()) == "Guid")//se for a 1º linha
                //    objCodigo.AppendLine(tb + tb + tb + "" + tabelaMinusculo + "." + colunaAtual + " = Guid.NewGuid();");
                //else
                //    objCodigo.AppendLine(tb + tb + tb + "" + tabelaMinusculo + "." + colunaAtual + " = " + objLib.RetornaConvertCollectionsForm(colunaAtual, tipo) + ";");

                colunaPrimaria = objDr.GetName(0);
                string tipo = objDr.GetDataTypeName(i);
                string colunaAtual = objDr.GetName(i).ToString();
                // lista as colunas
                if (objDr.GetName(i) == objDr.GetName(0))
                {
                    //se for a 1º linha
                    if (objLib.DefineTipo(objDr.GetDataTypeName(0).ToString()) == "Guid")
                        objCodigo.AppendLine(tb + tb + tb + "//" + tabelaMinusculo + "." + colunaAtual + " = Guid.NewGuid();");
                    else if (objLib.DefineTipo(objDr.GetDataTypeName(0).ToString()) == "string")
                        objCodigo.AppendLine(tb + tb + tb + "//" + tabelaMinusculo + "." + colunaAtual + " = id;");
                    else
                        objCodigo.AppendLine(tb + tb + tb + "//" + tabelaMinusculo + "." + colunaAtual + " = " + objLib.RetornaConvertCollectionsForm(colunaAtual, tipo) + ";");
                }
                else
                {
                    objCodigo.AppendLine(tb + tb + tb + "//" + tabelaMinusculo + "." + colunaAtual + " = " + objLib.RetornaConvertCollectionsForm(colunaAtual, tipo) + ";");
                }
            }
            objCodigo.AppendLine("#endregion");
            objCodigo.AppendLine("");

            objCodigo.AppendLine(tb + tb + tb + "        int retorno = " + tabelaMinusculoBO + ".Insert(tab);");
            objCodigo.AppendLine(tb + tb + tb + "        if (retorno == 1)");
            objCodigo.AppendLine(tb + tb + tb + "            return RedirectToAction(\"Details\", new { id = tab." + colunaPrimaria + " });");
            objCodigo.AppendLine(tb + tb + tb + "        else");
            objCodigo.AppendLine(tb + tb + tb + "            {");
            objCodigo.AppendLine(tb + tb + tb + "               //Ocorreu algum erro.....");
            objCodigo.AppendLine(tb + tb + tb + "               ModelState.AddModelError(\"\", \"Ocorreu algum erro no procedimento atual. Se o problema persistir procure o administrador do sistema.\");");
            objCodigo.AppendLine(tb + tb + tb + "               return Create();");
            objCodigo.AppendLine(tb + tb + tb + "            }");
            objCodigo.AppendLine(tb + tb + "    }");
            objCodigo.AppendLine(tb + tb + "    catch (Exception ex)");
            objCodigo.AppendLine(tb + tb + "    {");
            objCodigo.AppendLine(tb + tb + "        ModelState.AddModelError(\"\", ex.Message);");
            objCodigo.AppendLine(tb + tb + "        return Create();");
            objCodigo.AppendLine(tb + tb + "    }");
            objCodigo.AppendLine(tb + tb + "}");
            objCodigo.AppendLine();

            // Fecha conexão
            objBanco.CloseConn();
            objBanco = null;

            #endregion


            #region Edit
            // Abre conexão
            objBanco = new Banco.Banco(_conexao);
            // Faz a leitura de todas as colunas da tabela
            objDr = objBanco.QueryConsulta("SELECT * FROM " + strTabela);
            nunrec = objDr.FieldCount;
            // objeto da classe Libary
            objLib = new Library.Library();

            objCodigo.AppendLine(tb + "// GET: " + tabelaFormatada + "/Edit/5");
            objCodigo.AppendLine(tb + "public ActionResult Edit(string id)");
            objCodigo.AppendLine(tb + "{");
            objCodigo.AppendLine(tb + tb + "List<" + objetoDTOAtual + "> listaRetornada = " + tabelaMinusculoBO + ".FindAllLista(string.Format(\"" + objDr.GetName(0) + " = '{0}'\", id)).ToList();");
            objCodigo.AppendLine("");
            objCodigo.AppendLine(tb + tb + "if (listaRetornada.Count() > 0)");
            objCodigo.AppendLine(tb + tb + "{");
            //List<string> ColunasRelacionadasForengKey = RetornaColunasRelacionadasForengKey(nomeTabela: strTabela, conexao: _conexao); List<string> ColunasRelacionadasForengKey = RetornaColunasRelacionadasForengKey(nomeTabela: strTabela, conexao: _conexao);
            //List<string> ColunasReferenciadas = RetornaColunasReferenciadas(nomeTabela: strTabela, conexao: _conexao);
            //List<string> TabelaReferenciada = RetornaTabelaReferenciadas(nomeTabela: strTabela, conexao: _conexao);
            for (int i = 0; i < ColunasRelacionadasForengKey.Count; i++)
                objCodigo.AppendLine(tb + tb + "ViewBag." + ColunasRelacionadasForengKey[i] + " = new SelectList(new " + TabelaReferenciada[i] + "BO<Tab" + TabelaReferenciada[i] + ">().FindAllLista(), \"" + ColunasReferenciadas[0] + "\", \"Descricao\");");
            objCodigo.AppendLine(tb + tb + "    return View(listaRetornada[0]);");
            objCodigo.AppendLine(tb + tb + "}");
            objCodigo.AppendLine(tb + tb + "else");
            objCodigo.AppendLine(tb + tb + "{");
            objCodigo.AppendLine(tb + tb + "    //Não retornou nenhum registro");
            objCodigo.AppendLine(tb + tb + "    return RedirectToAction(\"Index\");");
            objCodigo.AppendLine(tb + tb + "}");
            objCodigo.AppendLine(tb + "}");
            objCodigo.AppendLine();

            // Fecha conexão
            objBanco.CloseConn();
            objBanco = null;
            #endregion


            #region Edit
            // Abre conexão
            objBanco = new Banco.Banco(_conexao);
            // Faz a leitura de todas as colunas da tabela
            objDr = objBanco.QueryConsulta("SELECT * FROM " + strTabela);
            nunrec = objDr.FieldCount;
            // objeto da classe Libary
            objLib = new Library.Library();

            objCodigo.AppendLine(tb + "// POST: " + tabelaFormatada + "/Edit/5");
            objCodigo.AppendLine(tb + "[HttpPost]");
            if (nunrec > 0)
            {
                string tipoParametro = objLib.DefineTipo(objDr.GetDataTypeName(0).ToString());
                tipoParametro = tipoParametro == "Guid" || tipoParametro == "string" ? "string" : "int";
                objCodigo.AppendLine(tb + "public ActionResult Edit(" + tipoParametro + " id, " + objetoDTOAtual + " tab)");
            }
            objCodigo.AppendLine(tb + "{");
            objCodigo.AppendLine(tb + tb + "    try");
            objCodigo.AppendLine(tb + tb + "    {");
            objCodigo.AppendLine(tb + tb + "        #region Validações e regras específicas para essa operação");
            objCodigo.AppendLine(tb + tb + "        //if (string.IsNullOrEmpty(Convert.ToString(tab.Descricao)))");
            objCodigo.AppendLine(tb + tb + "        //{");
            objCodigo.AppendLine(tb + tb + "        //    ModelState.AddModelError(\"Descricao\", \"Informe uma descrição!\");");
            objCodigo.AppendLine(tb + tb + "        //}");
            objCodigo.AppendLine(tb + tb + "        #endregion");
            objCodigo.AppendLine(tb + tb + "        ");
            objCodigo.AppendLine(tb + tb + "        if (!ModelState.IsValid)");
            objCodigo.AppendLine(tb + tb + "            return Edit(id);");
            objCodigo.AppendLine("");
            objCodigo.AppendLine("tab." + objDr.GetName(0) + " = new Guid(id);");
            objCodigo.AppendLine("#region modelo anterior");
            objCodigo.AppendLine(tb + tb + tb + "//" + objetoDTOAtual + " " + tabelaMinusculo + " = new " + objetoDTOAtual + "();");

            for (int i = 0; i < nunrec; i++)
            {
                colunaPrimaria = objDr.GetName(0);
                string tipo = objDr.GetDataTypeName(i);
                string colunaAtual = objDr.GetName(i).ToString();
                // lista as colunas
                if (objDr.GetName(i) == objDr.GetName(0))
                {
                    //se for a 1º linha
                    if (objLib.DefineTipo(objDr.GetDataTypeName(0).ToString()) == "Guid")
                        objCodigo.AppendLine(tb + tb + tb + "//" + tabelaMinusculo + "." + colunaAtual + " = new Guid(id);");
                    else if (objLib.DefineTipo(objDr.GetDataTypeName(0).ToString()) == "string")
                        objCodigo.AppendLine(tb + tb + tb + "//" + tabelaMinusculo + "." + colunaAtual + " = id;");
                    else
                        objCodigo.AppendLine(tb + tb + tb + "//" + tabelaMinusculo + "." + colunaAtual + " = " + objLib.RetornaConvertCollectionsForm(colunaAtual, tipo) + ";");
                }
                else
                {
                    objCodigo.AppendLine(tb + tb + tb + "//" + tabelaMinusculo + "." + colunaAtual + " = " + objLib.RetornaConvertCollectionsForm(colunaAtual, tipo) + ";");
                }
            }
            objCodigo.AppendLine("#endregion");
            objCodigo.AppendLine(tb + tb + tb + "        int retorno = " + tabelaMinusculoBO + ".Update(tab);");
            objCodigo.AppendLine(tb + tb + tb + "        if (retorno == 1)");
            objCodigo.AppendLine(tb + tb + tb + "            return RedirectToAction(\"Details\", new { id = tab." + colunaPrimaria + " });");
            objCodigo.AppendLine(tb + tb + tb + "        else");
            objCodigo.AppendLine(tb + tb + tb + "            {");
            objCodigo.AppendLine(tb + tb + tb + "            //Ocorreu algum erro.....");
            objCodigo.AppendLine(tb + tb + tb + "            ModelState.AddModelError(\"\", \"Ocorreu algum erro no procedimento atual. Se o problema persistir procure o administrador do sistema.\");");
            objCodigo.AppendLine(tb + tb + tb + "            return Edit(id);");
            objCodigo.AppendLine(tb + tb + tb + "            }");
            objCodigo.AppendLine(tb + tb + "    }");
            objCodigo.AppendLine(tb + tb + "    catch (Exception ex)");
            objCodigo.AppendLine(tb + tb + "    {");
            objCodigo.AppendLine(tb + tb + "        ModelState.AddModelError(\"\", ex.Message);");
            objCodigo.AppendLine(tb + tb + "        return Edit(id);");
            objCodigo.AppendLine(tb + tb + "    }");
            objCodigo.AppendLine(tb + "}");
            objCodigo.AppendLine();

            // Fecha conexão
            objBanco.CloseConn();
            objBanco = null;
            #endregion


            #region Delete
            // Abre conexão
            objBanco = new Banco.Banco(_conexao);
            // Faz a leitura de todas as colunas da tabela
            objDr = objBanco.QueryConsulta("SELECT * FROM " + strTabela);
            nunrec = objDr.FieldCount;
            // objeto da classe Libary
            objLib = new Library.Library();

            objCodigo.AppendLine(tb + "// GET: " + tabelaFormatada + "/Delete/5");
            if (nunrec > 0)
            {
                string tipoParametro = objLib.DefineTipo(objDr.GetDataTypeName(0).ToString());
                tipoParametro = tipoParametro == "Guid" || tipoParametro == "string" ? "string" : "int";
                objCodigo.AppendLine(tb + "public ActionResult Delete(" + tipoParametro + " id)");
            }
            objCodigo.AppendLine(tb + "{");
            objCodigo.AppendLine(tb + tb + "try");
            objCodigo.AppendLine(tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + "List<" + objetoDTOAtual + "> listaRetornada = this." + tabelaMinusculoBO + ".FindAllLista(string.Format(\"" + objDr.GetName(0) + " = '{0}'\", id)).Take(1).ToList();");
            objCodigo.AppendLine("");
            objCodigo.AppendLine(tb + tb + tb + "if (listaRetornada.Count > 0)");
            objCodigo.AppendLine(tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + "int retorno = this." + tabelaMinusculoBO + ".Delete(listaRetornada[0]);");
            objCodigo.AppendLine(tb + tb + tb + tb + "if (retorno == 0)");
            objCodigo.AppendLine(tb + tb + tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + tb + tb + "//Ocorreu algum erro.....");
            objCodigo.AppendLine(tb + tb + tb + tb + tb + "return RedirectToAction(\"Index\");");
            objCodigo.AppendLine(tb + tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "}");
            objCodigo.AppendLine(tb + tb + tb + "//Não retornou nenhum registro");
            objCodigo.AppendLine(tb + tb + tb + "return RedirectToAction(\"Index\");");
            objCodigo.AppendLine(tb + tb + "}");
            objCodigo.AppendLine(tb + tb + "catch");
            objCodigo.AppendLine(tb + tb + "{");
            objCodigo.AppendLine(tb + tb + tb + "return RedirectToAction(\"Index\");");
            objCodigo.AppendLine(tb + tb + "}");
            objCodigo.AppendLine(tb + "}");
            objCodigo.AppendLine();

            // Fecha conexão
            objBanco.CloseConn();
            objBanco = null;
            #endregion


            objCodigo.AppendLine(tb + "}");

            objCodigo.AppendLine("}");

            return objCodigo;
        }

        private List<string> RetornaColunasRelacionadasForengKey(string nomeTabela, string conexao)
        {
            /*
            SELECT 
             KCU1.CONSTRAINT_NAME AS 'FK_Nome_Constraint'
             , KCU1.TABLE_NAME AS 'FK_Nome_Tabela'
             , KCU1.COLUMN_NAME AS 'FK_Nome_Coluna'
             , FK.is_disabled AS 'FK_Esta_Desativada'
             , KCU2.CONSTRAINT_NAME AS 'PK_Nome_Constraint_Referenciada'
             , KCU2.TABLE_NAME AS 'PK_Nome_Tabela_Referenciada'
             , KCU2.COLUMN_NAME AS 'PK_Nome_Coluna_Referenciada'
            FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS RC
            JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE KCU1
            ON KCU1.CONSTRAINT_CATALOG = RC.CONSTRAINT_CATALOG 
             AND KCU1.CONSTRAINT_SCHEMA = RC.CONSTRAINT_SCHEMA
             AND KCU1.CONSTRAINT_NAME = RC.CONSTRAINT_NAME
            JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE KCU2
            ON KCU2.CONSTRAINT_CATALOG = RC.UNIQUE_CONSTRAINT_CATALOG 
             AND KCU2.CONSTRAINT_SCHEMA = RC.UNIQUE_CONSTRAINT_SCHEMA
             AND KCU2.CONSTRAINT_NAME = RC.UNIQUE_CONSTRAINT_NAME
             AND KCU2.ORDINAL_POSITION = KCU1.ORDINAL_POSITION
            JOIN sys.foreign_keys FK on FK.name = KCU1.CONSTRAINT_NAME
            WHERE KCU1.TABLE_NAME = 'Permissao' AND KCU1.COLUMN_NAME = 'ModuloId'
            Order by 
            KCU1.TABLE_NAME
            */
            List<string> listaRetorno = new List<string>();

            string sql = string.Format(@"
            SELECT  
                KCU1.COLUMN_NAME
            FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS RC
            JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE KCU1
            ON KCU1.CONSTRAINT_CATALOG = RC.CONSTRAINT_CATALOG 
                AND KCU1.CONSTRAINT_SCHEMA = RC.CONSTRAINT_SCHEMA
                AND KCU1.CONSTRAINT_NAME = RC.CONSTRAINT_NAME
            JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE KCU2
            ON KCU2.CONSTRAINT_CATALOG = RC.UNIQUE_CONSTRAINT_CATALOG 
                AND KCU2.CONSTRAINT_SCHEMA = RC.UNIQUE_CONSTRAINT_SCHEMA
                AND KCU2.CONSTRAINT_NAME = RC.UNIQUE_CONSTRAINT_NAME
                AND KCU2.ORDINAL_POSITION = KCU1.ORDINAL_POSITION
            JOIN sys.foreign_keys FK on FK.name = KCU1.CONSTRAINT_NAME
            WHERE KCU1.TABLE_NAME = '{0}'
            ", nomeTabela);

            Banco.Banco objBanco = new Banco.Banco(conexao);
            DataSet retorno = objBanco.GetDataSet(sql, nomeTabela);

            for (int i = 0; i < retorno.Tables[0].Rows.Count; i++)
            {
                listaRetorno.Add(retorno.Tables[0].Rows[i][0].ToString());
            }
            objBanco.CloseConn();
            return listaRetorno;
        }

        private List<string> RetornaColunasReferenciadas(string nomeTabela, string conexao)
        {
            /*
            SELECT 
             KCU1.CONSTRAINT_NAME AS 'FK_Nome_Constraint'
             , KCU1.TABLE_NAME AS 'FK_Nome_Tabela'
             , KCU1.COLUMN_NAME AS 'FK_Nome_Coluna'
             , FK.is_disabled AS 'FK_Esta_Desativada'
             , KCU2.CONSTRAINT_NAME AS 'PK_Nome_Constraint_Referenciada'
             , KCU2.TABLE_NAME AS 'PK_Nome_Tabela_Referenciada'
             , KCU2.COLUMN_NAME AS 'PK_Nome_Coluna_Referenciada'
            FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS RC
            JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE KCU1
            ON KCU1.CONSTRAINT_CATALOG = RC.CONSTRAINT_CATALOG 
             AND KCU1.CONSTRAINT_SCHEMA = RC.CONSTRAINT_SCHEMA
             AND KCU1.CONSTRAINT_NAME = RC.CONSTRAINT_NAME
            JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE KCU2
            ON KCU2.CONSTRAINT_CATALOG = RC.UNIQUE_CONSTRAINT_CATALOG 
             AND KCU2.CONSTRAINT_SCHEMA = RC.UNIQUE_CONSTRAINT_SCHEMA
             AND KCU2.CONSTRAINT_NAME = RC.UNIQUE_CONSTRAINT_NAME
             AND KCU2.ORDINAL_POSITION = KCU1.ORDINAL_POSITION
            JOIN sys.foreign_keys FK on FK.name = KCU1.CONSTRAINT_NAME
            WHERE KCU1.TABLE_NAME = 'Permissao' AND KCU1.COLUMN_NAME = 'ModuloId'
            Order by 
            KCU1.TABLE_NAME
            */
            List<string> listaRetorno = new List<string>();

            string sql = string.Format(@"
            SELECT  
                KCU2.COLUMN_NAME
            FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS RC
            JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE KCU1
            ON KCU1.CONSTRAINT_CATALOG = RC.CONSTRAINT_CATALOG 
                AND KCU1.CONSTRAINT_SCHEMA = RC.CONSTRAINT_SCHEMA
                AND KCU1.CONSTRAINT_NAME = RC.CONSTRAINT_NAME
            JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE KCU2
            ON KCU2.CONSTRAINT_CATALOG = RC.UNIQUE_CONSTRAINT_CATALOG 
                AND KCU2.CONSTRAINT_SCHEMA = RC.UNIQUE_CONSTRAINT_SCHEMA
                AND KCU2.CONSTRAINT_NAME = RC.UNIQUE_CONSTRAINT_NAME
                AND KCU2.ORDINAL_POSITION = KCU1.ORDINAL_POSITION
            JOIN sys.foreign_keys FK on FK.name = KCU1.CONSTRAINT_NAME
            WHERE KCU1.TABLE_NAME = '{0}'
            ", nomeTabela);

            Banco.Banco objBanco = new Banco.Banco(conexao);
            DataSet retorno = objBanco.GetDataSet(sql, nomeTabela);

            for (int i = 0; i < retorno.Tables[0].Rows.Count; i++)
            {
                listaRetorno.Add(retorno.Tables[0].Rows[i][0].ToString());
            }
            objBanco.CloseConn();
            return listaRetorno;
        }
        
        private List<string> RetornaTabelaReferenciadas(string nomeTabela, string conexao)
        {
            /*
            SELECT 
             KCU1.CONSTRAINT_NAME AS 'FK_Nome_Constraint'
             , KCU1.TABLE_NAME AS 'FK_Nome_Tabela'
             , KCU1.COLUMN_NAME AS 'FK_Nome_Coluna'
             , FK.is_disabled AS 'FK_Esta_Desativada'
             , KCU2.CONSTRAINT_NAME AS 'PK_Nome_Constraint_Referenciada'
             , KCU2.TABLE_NAME AS 'PK_Nome_Tabela_Referenciada'
             , KCU2.COLUMN_NAME AS 'PK_Nome_Coluna_Referenciada'
            FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS RC
            JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE KCU1
            ON KCU1.CONSTRAINT_CATALOG = RC.CONSTRAINT_CATALOG 
             AND KCU1.CONSTRAINT_SCHEMA = RC.CONSTRAINT_SCHEMA
             AND KCU1.CONSTRAINT_NAME = RC.CONSTRAINT_NAME
            JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE KCU2
            ON KCU2.CONSTRAINT_CATALOG = RC.UNIQUE_CONSTRAINT_CATALOG 
             AND KCU2.CONSTRAINT_SCHEMA = RC.UNIQUE_CONSTRAINT_SCHEMA
             AND KCU2.CONSTRAINT_NAME = RC.UNIQUE_CONSTRAINT_NAME
             AND KCU2.ORDINAL_POSITION = KCU1.ORDINAL_POSITION
            JOIN sys.foreign_keys FK on FK.name = KCU1.CONSTRAINT_NAME
            WHERE KCU1.TABLE_NAME = 'Permissao' AND KCU1.COLUMN_NAME = 'ModuloId'
            Order by 
            KCU1.TABLE_NAME
            */
            List<string> listaRetorno = new List<string>();

            string sql = string.Format(@"
            SELECT  
                KCU2.TABLE_NAME
            FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS RC
            JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE KCU1
            ON KCU1.CONSTRAINT_CATALOG = RC.CONSTRAINT_CATALOG 
                AND KCU1.CONSTRAINT_SCHEMA = RC.CONSTRAINT_SCHEMA
                AND KCU1.CONSTRAINT_NAME = RC.CONSTRAINT_NAME
            JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE KCU2
            ON KCU2.CONSTRAINT_CATALOG = RC.UNIQUE_CONSTRAINT_CATALOG 
                AND KCU2.CONSTRAINT_SCHEMA = RC.UNIQUE_CONSTRAINT_SCHEMA
                AND KCU2.CONSTRAINT_NAME = RC.UNIQUE_CONSTRAINT_NAME
                AND KCU2.ORDINAL_POSITION = KCU1.ORDINAL_POSITION
            JOIN sys.foreign_keys FK on FK.name = KCU1.CONSTRAINT_NAME
            WHERE KCU1.TABLE_NAME = '{0}'
            ", nomeTabela);

            Banco.Banco objBanco = new Banco.Banco(conexao);
            DataSet retorno = objBanco.GetDataSet(sql, nomeTabela);

            for (int i = 0; i < retorno.Tables[0].Rows.Count; i++)
            {
                listaRetorno.Add(retorno.Tables[0].Rows[i][0].ToString());
            }
            objBanco.CloseConn();
            return listaRetorno;
        }

    }
}
