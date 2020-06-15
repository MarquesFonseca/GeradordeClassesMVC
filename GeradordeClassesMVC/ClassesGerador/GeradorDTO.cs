using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GeradorDTO
{
    /// <summary>
    /// Classe VO
    /// Criador: Marques Silva Fonseca
    /// Criada em 22/03/2012
    /// Contato: marques-fonseca@hotmail.com
    /// </summary>
    public class GeradorDTO
    {
        // Atributos
        public string strData = null;
        public string[] arrTabelas = null;
        public string s = null;
        public string tb = null;
        public StringBuilder objCodigo = null;
        public Banco.Banco objBanco = null;
        public SqlDataReader objDr = null;
        private Library.Library objLib = null;

        // Contrutor
        public GeradorDTO()
        {
            strData = DateTime.Today.ToShortDateString() + " às " + DateTime.Now.ToShortTimeString();
            s = " ";
            tb = "      ";

        }

        // Metodos
        public StringBuilder GeraCodigoDto(string _tabela, string _conexao, string _banco)
        {
            string strTabela = _tabela;

            objCodigo = new StringBuilder();

            objCodigo.AppendLine("using System;");
            objCodigo.AppendLine("using System.Collections.Generic;");
            objCodigo.AppendLine("using System.ComponentModel.DataAnnotations;");
            objCodigo.AppendLine("using System.Text;");
            objCodigo.AppendLine();
            objCodigo.AppendLine("namespace DTO");
            objCodigo.AppendLine("{");

            string tabelaFormatada = strTabela.Replace("_", "").Replace("-", "");
            // Abre conexão com o banco
            objBanco = new Banco.Banco(_conexao);
            // Cria o objeto da classe Library
            objLib = new Library.Library();

            //objCodigo.AppendLine();
            objCodigo.AppendLine(tb + "/// <summary>");
            objCodigo.AppendLine(tb + "/// Classe DTO gerada automática: Tab" + strTabela);
            if (Environment.MachineName == "MARQUESNOTE-PC")
                objCodigo.AppendLine(tb + "/// Criador: Marques Silva Fonseca");
            else objCodigo.AppendLine(tb + "/// Criador: " + Environment.UserName);
            objCodigo.AppendLine(tb + "/// Criada em " + strData);
            //objCodigo.AppendLine(tb + "/// Contato: marques-fonseca@hotmail.com");
            objCodigo.AppendLine(tb + "/// </summary>");
            objCodigo.AppendLine(tb + "public class Tab" + tabelaFormatada);
            objCodigo.AppendLine(tb + "{");
            objCodigo.AppendLine(tb + tb + "// Atributos");

            // Faz a leitura de todas as colunas da tabela
            objDr = objBanco.QueryConsulta("SELECT * FROM " + strTabela);
            // Conta o número de colunas
            int nunrec = objDr.FieldCount;

            for (int i = 0; i < nunrec; i++)
            {
                #region modelo1
                var ColunaIsNullable = objBanco.RetornaValor("IF(EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + strTabela + "' AND COLUMN_NAME = '" + objDr.GetName(i) + "' AND IS_NULLABLE = 'YES')) SELECT 1 IsNullable ELSE SELECT 0 IsNullable", new System.Collections.ArrayList() { }, new System.Collections.ArrayList { });
                string tipoObjeto = objLib.DefineTipo(objDr.GetDataTypeName(i).ToString());
                // o campo aceita nullo
                if (Convert.ToBoolean(ColunaIsNullable) && tipoObjeto == "DateTime")
                    objCodigo.AppendLine(tb + tb + "private " + tipoObjeto + "?" + " _" + objDr.GetName(i) + ";");
                // o campo aceita nullo
                else
                    objCodigo.AppendLine(tb + tb + "private " + objLib.DefineTipo(objDr.GetDataTypeName(i).ToString()) + " _" + objDr.GetName(i) + ";");
                #endregion
            }

            objCodigo.AppendLine();
            objCodigo.AppendLine(tb + tb + "// Propriedades");

            for (int i = 0; i < nunrec; i++)
            {
                #region modelo1
                objCodigo.AppendLine(tb + tb + "#region " + objDr.GetName(i) + "");
                                
                var ColunaIsNullable = objBanco.RetornaValor("IF(EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + strTabela + "' AND COLUMN_NAME = '" + objDr.GetName(i) + "' AND IS_NULLABLE = 'YES')) SELECT 1 IsNullable ELSE SELECT 0 IsNullable", new System.Collections.ArrayList() { }, new System.Collections.ArrayList { });
                string tipoObjeto = objLib.DefineTipo(objDr.GetDataTypeName(i).ToString());
                // o campo aceita nullo
                if (Convert.ToBoolean(ColunaIsNullable))
                {
                    //objCodigo.AppendLine(tb + tb + "[Atributos(ChavePrimaria = false, DescricaoCampo = \"\", ChaveEstrangeira = false, ClasseChaveEstrangeira = \"\", DescricaoExibirChaveEstrangeira = \"\", RelacionarChaveEstrangeiraNovoCadastro = true)]");
                    objCodigo.AppendLine(tb + tb + "//[Required(ErrorMessage = \"Informe o campo " + objDr.GetName(i) + "\")]");
                    objCodigo.AppendLine(tb + tb + "[Display(Name = \"" + objDr.GetName(i) + "\")]");

                    if (tipoObjeto == "DateTime")
                    {
                        objCodigo.AppendLine(tb + tb + "public " + objLib.DefineTipo(objDr.GetDataTypeName(i).ToString()) + "?" + " " + objDr.GetName(i) + "{" + "get { return _" + objDr.GetName(i) + "; }" + "set { _" + objDr.GetName(i) + " = value; }" + " }");
                    }
                    else
                    {
                        objCodigo.AppendLine(tb + tb + "public " + objLib.DefineTipo(objDr.GetDataTypeName(i).ToString()) + " " + objDr.GetName(i) + "{" + "get { return _" + objDr.GetName(i) + "; }" + "set { _" + objDr.GetName(i) + " = value; }" + " }");
                    }
                }
                else
                {
                    //objCodigo.AppendLine(tb + tb + "[Atributos(ChavePrimaria = false, DescricaoCampo = \"\", ChaveEstrangeira = false, ClasseChaveEstrangeira = \"\", DescricaoExibirChaveEstrangeira = \"\", RelacionarChaveEstrangeiraNovoCadastro = true)]");
                    objCodigo.AppendLine(tb + tb + "[Required(ErrorMessage = \"Informe o campo " + objDr.GetName(i) + "\")]");
                    objCodigo.AppendLine(tb + tb + "[Display(Name = \"" + objDr.GetName(i) + "\")]");

                    objCodigo.AppendLine(tb + tb + "public " + objLib.DefineTipo(objDr.GetDataTypeName(i).ToString()) + " " + objDr.GetName(i) + "{" + "get { return _" + objDr.GetName(i) + "; }" + "set { _" + objDr.GetName(i) + " = value; }" + " }");
                }

                objCodigo.AppendLine(tb + tb + "#endregion");
                objCodigo.AppendLine("");
                #endregion



                #region modelo2
                //objCodigo.AppendLine(tb + tb + "#region " + objDr.GetName(i) + "");
                ////objCodigo.AppendLine(tb + tb + "[Atributos(ChavePrimaria = false, DescricaoCampo = \"\", ChaveEstrangeira = false, ClasseChaveEstrangeira = \"\", DescricaoExibirChaveEstrangeira = \"\", RelacionarChaveEstrangeiraNovoCadastro = true)]");
                //objCodigo.AppendLine(tb + tb + "[Display(Name = \"" + objDr.GetName(i) + "\")]");
                //objCodigo.AppendLine(tb + tb + "[Required(ErrorMessage = \"Informe o campo " + objDr.GetName(i) + "\")]");
                //var ColunaIsNullable = objBanco.RetornaValor("IF(EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + strTabela + "' AND COLUMN_NAME = '" + objDr.GetName(i) + "' AND IS_NULLABLE = 'YES')) SELECT 1 IsNullable ELSE SELECT 0 IsNullable", new System.Collections.ArrayList() { }, new System.Collections.ArrayList { });
                //string tipoObjeto = objLib.DefineTipo(objDr.GetDataTypeName(i).ToString());
                //// o campo aceita nullo
                //if (Convert.ToBoolean(ColunaIsNullable) && tipoObjeto == "DateTime")
                //    objCodigo.AppendLine(tb + tb + "public " + tipoObjeto + "?" + " " + objDr.GetName(i) + " { get; set; }");
                //else
                //    objCodigo.AppendLine(tb + tb + "public " + objLib.DefineTipo(objDr.GetDataTypeName(i).ToString()) + " " + objDr.GetName(i) + " { get; set; }");
                //objCodigo.AppendLine(tb + tb + "#endregion");
                //objCodigo.AppendLine("");
                #endregion
            }
            objCodigo.AppendLine(tb + "}");
            // fecha conexão
            objBanco.CloseConn();
            objLib = null;

            objCodigo.AppendLine("}");

            return objCodigo;
        }
    }
}
