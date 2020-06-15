using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Library
    {
        private string strParam = null;
        private string strTipo = null;

        
        /// <summary>
        /// Define qual o tipo a variável do banco de dados vai ter
        /// </summary>
        /// <param name="_coluna">string</param>
        /// <param name="_tipo">string</param>
        /// <returns></returns>
        public string UpdateParam(string _coluna, string _tipo)
        {
            // Define qual o tipo da coluna setar o tipo do atributo
            switch (_tipo)
            {
                case "bigint":
                    strParam = " " + _coluna + " = " + "  \" + tab." + _coluna + " + \" ";
                    break;
                case "binary":
                    strParam = " " + _coluna + " = " + "  \" + tab." + _coluna + " + \" ";
                    break;
                case "bit":
                    strParam = " " + _coluna + " = " + "  '\" + tab." + _coluna + " + \"' ";
                    break;
                case "char":
                    strParam = " " + _coluna + " = " + " '\" + tab." + _coluna + " + \"' ";
                    break;
                case "datetime":
                    strParam = " " + _coluna + " = CONVERT(DATETIME, '" + "\" + tab." + _coluna + " + \"' , 103) ";
                    break;
                case "decimal":
                    strParam = " " + _coluna + " = " + "  \" + tab." + _coluna + " + \" ";
                    break;
                case "float":
                    strParam = " " + _coluna + " = " + "  \" + tab." + _coluna + " + \" ";
                    break;
                case "image":
                    strParam = " " + _coluna + " = " + " '\" + tab." + _coluna + " + \"' ";
                    break;
                case "int":
                    strParam = " " + _coluna + " = " + "  \" + tab." + _coluna + " + \" ";
                    break;
                case "money":
                    strParam = " " + _coluna + " = " + "  \" + tab." + _coluna + " + \" ";
                    break;
                case "nchar":
                    strParam = " " + _coluna + " = " + " '\" + tab." + _coluna + " + \"' ";
                    break;
                case "ntext":
                    strParam = " " + _coluna + " = " + " '\" + tab." + _coluna + " + \"' ";
                    break;
                case "numeric":
                    strParam = " " + _coluna + " = " + "  \" + tab." + _coluna + " + \" ";
                    break;
                case "nvarchar":
                    strParam = " " + _coluna + " = " + " '\" + tab." + _coluna + " + \"' ";
                    break;
                case "real":
                    strParam = " " + _coluna + " = " + "  \" + tab." + _coluna + " + \" ";
                    break;
                case "smalldatetime":
                    strParam = " " + _coluna + " = " + " '\" + tab." + _coluna + " + \"' ";
                    break;
                case "smallint":
                    strParam = " " + _coluna + " = " + "  \" + tab." + _coluna + " + \" ";
                    break;
                case "smallmoney":
                    strParam = " " + _coluna + " = " + "  \" + tab." + _coluna + " + \" ";
                    break;
                case "text":
                    strParam = " " + _coluna + " = " + " '\" + tab." + _coluna + " + \"' ";
                    break;
                case "tinyint":
                    strParam = " " + _coluna + " = " + "  \" + tab." + _coluna + " + \" ";
                    break;
                case "varbinary":
                    strParam = " " + _coluna + " = " + "  \" + tab." + _coluna + " + \" ";
                    break;
                case "varchar":
                    strParam = " " + _coluna + " = " + " '\" + tab." + _coluna + " + \"' ";
                    break;
                default:
                    strParam = " " + _coluna + " = " + " '\" + tab." + _coluna + " + \"' ";
                    break;
            }
            return strParam;
        }

        /// <summary>
        /// Define qual o tipo a variável do banco de dados vai ter
        /// </summary>
        /// <param name="_coluna">string</param>
        /// <param name="_tipo">string</param>
        /// <returns></returns>
        public string SelectParam(string _coluna, string _tipo)
        {
            // Define qual o tipo da coluna setar o tipo do atributo
            switch (_tipo)
            {
                case "bigint":
                    strParam = " " + _coluna + " = " + "  \" + _" + _coluna + " + \" ";
                    break;
                case "binary":
                    strParam = " " + _coluna + " = " + "  \" + _" + _coluna + " + \" ";
                    break;
                case "bit":
                    strParam = " " + _coluna + " = " + "  \" + _" + _coluna + " + \" ";
                    break;
                case "char":
                    strParam = " " + _coluna + " = " + " '\" + _" + _coluna + " + \"' ";
                    break;
                case "datetime":
                    strParam = " " + _coluna + " = CONVERT(DATETIME, '" + "\" + _" + _coluna + " + \"', 103) ";
                    break;
                case "decimal":
                    strParam = " " + _coluna + " = " + "  \" + _" + _coluna + " + \" ";
                    break;
                case "float":
                    strParam = " " + _coluna + " = " + "  \" + _" + _coluna + " + \" ";
                    break;
                case "image":
                    strParam = String.Format(" {0} =  '\" + _{0} + \"' ", _coluna);
                    break;
                case "int":
                    strParam = " " + _coluna + " = " + "  \" + _" + _coluna + " + \" ";
                    break;
                case "money":
                    strParam = " " + _coluna + " = " + "  \" + _" + _coluna + " + \" ";
                    break;
                case "nchar":
                    strParam = " " + _coluna + " = " + " '\" + _" + _coluna + " + \"' ";
                    break;
                case "ntext":
                    strParam = " " + _coluna + " = " + " '\" + _" + _coluna + " + \"' ";
                    break;
                case "numeric":
                    strParam = " " + _coluna + " = " + "  \" + _" + _coluna + " + \" ";
                    break;
                case "nvarchar":
                    strParam = " " + _coluna + " = " + " '\" + _" + _coluna + " + \"' ";
                    break;
                case "real":
                    strParam = " " + _coluna + " = " + "  \" + _" + _coluna + " + \" ";
                    break;
                case "smalldatetime":
                    strParam = " " + _coluna + " = " + " '\" + _" + _coluna + " + \"' ";
                    break;
                case "smallint":
                    strParam = " " + _coluna + " = " + "  \" + _" + _coluna + " + \" ";
                    break;
                case "smallmoney":
                    strParam = " " + _coluna + " = " + "  \" + _" + _coluna + " + \" ";
                    break;
                case "text":
                    strParam = " " + _coluna + " = " + " '\" + _" + _coluna + " + \"' ";
                    break;
                case "tinyint":
                    strParam = " " + _coluna + " = " + "  \" + _" + _coluna + " + \" ";
                    break;
                case "varbinary":
                    strParam = " " + _coluna + " = " + "  \" + _" + _coluna + " + \" ";
                    break;
                case "varchar":
                    strParam = " " + _coluna + " = " + " '\" + _" + _coluna + " + \"' ";
                    break;
                default:
                    strParam = " " + _coluna + " = " + " '\" + _" + _coluna + " + \"' ";
                    break;
            }
            return strParam;
        }

        /// <summary>
        /// Define qual o tipo a variável do banco de dados vai ter
        /// </summary>
        /// <param name="_coluna">string</param>
        /// <param name="_tipo">string</param>
        /// <returns></returns>
        public string InsertParam(string _coluna, string _tipo)
        {
            // Define qual o tipo da coluna setar o tipo do atributo
            switch (_tipo)
            {
                case "bigint":
                    strParam =  "\" + _vo." + _coluna + " + \" ";
                    break;
                case "binary":
                    strParam =  "\" + _vo." + _coluna + " + \" ";
                    break;
                case "bit":
                    strParam =  " '\" + _vo." + _coluna + " + \"' ";
                    break;
                case "char":
                    strParam =  " '\" + _vo." + _coluna + " + \"' ";
                    break;
                case "datetime":
                    strParam = " CONVERT(DATETIME, '" + "\" + _vo." + _coluna + " + \"', 103) ";
                    break;
                case "decimal":
                    strParam =  "\" + _vo." + _coluna + " + \" ";
                    break;
                case "float":
                    strParam =  "\" + _vo." + _coluna + " + \" ";
                    break;
                case "image":
                    strParam =  " '\" + _vo." + _coluna + " + \"' ";
                    break;
                case "int":
                    strParam =  "\" + _vo." + _coluna + " + \" ";
                    break;
                case "money":
                    strParam =  "\" + _vo." + _coluna + " + \" ";
                    break;
                case "nchar":
                    strParam =  " '\" + _vo." + _coluna + " + \"' ";
                    break;
                case "ntext":
                    strParam =  " '\" + _vo." + _coluna + " + \"' ";
                    break;
                case "numeric":
                    strParam =  "\" + _vo." + _coluna + " + \" ";
                    break;
                case "nvarchar":
                    strParam =  " '\" + _vo." + _coluna + " + \"' ";
                    break;
                case "real":
                    strParam =  "\" + _vo." + _coluna + " + \" ";
                    break;
                case "smalldatetime":
                    strParam =  " '\" + _vo." + _coluna + " + \"' ";
                    break;
                case "smallint":
                    strParam =  "\" + _vo." + _coluna + " + \" ";
                    break;
                case "smallmoney":
                    strParam =  "\" + _vo." + _coluna + " + \" ";
                    break;
                case "text":
                    strParam =  " '\" + _vo." + _coluna + " + \"' ";
                    break;
                case "tinyint":
                    strParam =  "\" + _vo." + _coluna + " + \" ";
                    break;
                case "varbinary":
                    strParam =  "\" + _vo." + _coluna + " + \" ";
                    break;
                case "varchar":
                    strParam =  " '\" + _vo." + _coluna + " + \"' ";
                    break;
                default:
                    strParam =  " '\" + _vo." + _coluna + " + \"' ";
                    break;
            }
            return strParam;
        }

        /// <summary>
        /// Define qual o tipo a variável do banco de dados vai ter
        /// </summary>
        /// <param name="_coluna">string</param>
        /// <param name="_tipo">string</param>
        /// <returns></returns>
        public string RetornaConvertParam(string _coluna, string _tipo)
        {
            // Define qual o tipo da coluna setar o tipo do atributo
            switch (_tipo)
            {
                //string.Format("dsRetornado.Tables[0].Rows[0][\"{0}\"]", _coluna);;
                case "bigint":
                    strParam = string.Format("Convert.ToInt32(dsRetornado.Tables[0].Rows[0][\"{0}\"])", _coluna);
                    break;
                case "binary":
                    strParam = string.Format("Convert.ToBoolean(dsRetornado.Tables[0].Rows[0][\"{0}\"].ToString().Split(',')[0])", _coluna);
                    break;
                case "bit":
                    strParam = string.Format("Convert.ToBoolean(dsRetornado.Tables[0].Rows[0][\"{0}\"].ToString().Split(',')[0])", _coluna);
                    break;
                case "char":
                    strParam = string.Format("Convert.ToString(dsRetornado.Tables[0].Rows[0][\"{0}\"])", _coluna);
                    break;
                case "datetime":
                    strParam = string.Format("Convert.ToDateTime(dsRetornado.Tables[0].Rows[0][\"{0}\"])", _coluna);
                    break;
                case "decimal":
                    strParam = string.Format("Convert.ToDecimal(dsRetornado.Tables[0].Rows[0][\"{0}\"])", _coluna);
                    break;
                case "float":
                    strParam = string.Format("Convert.ToDouble(dsRetornado.Tables[0].Rows[0][\"{0}\"])", _coluna);
                    break;
                case "image":
                    strParam = string.Format("Convert.ToString(dsRetornado.Tables[0].Rows[0][\"{0}\"])", _coluna);
                    break;
                case "int":
                    strParam = string.Format("Convert.ToInt32(dsRetornado.Tables[0].Rows[0][\"{0}\"])", _coluna);
                    break;
                case "money":
                    strParam = string.Format("Convert.ToDecimal(dsRetornado.Tables[0].Rows[0][\"{0}\"].ToString(), 18, 2)", _coluna);
                    break;
                case "nchar":
                    strParam = string.Format("Convert.ToString(dsRetornado.Tables[0].Rows[0][\"{0}\"])", _coluna);
                    break;
                case "ntext":
                    strParam = string.Format("Convert.ToString(dsRetornado.Tables[0].Rows[0][\"{0}\"])", _coluna);
                    break;
                case "numeric":
                    strParam = string.Format("Convert.ToDecimal(dsRetornado.Tables[0].Rows[0][\"{0}\"])", _coluna);
                    break;
                case "nvarchar":
                    strParam = string.Format("Convert.ToString(dsRetornado.Tables[0].Rows[0][\"{0}\"])", _coluna);
                    break;
                case "real":
                    strParam = string.Format("Convert.ToDecimal(dsRetornado.Tables[0].Rows[0][\"{0}\"])", _coluna);
                    break;
                case "smalldatetime":
                    strParam = string.Format("Convert.ToDateTime(dsRetornado.Tables[0].Rows[0][\"{0}\"])", _coluna);
                    break;
                case "smallint":
                    strParam = string.Format("Convert.ToInt32(dsRetornado.Tables[0].Rows[0][\"{0}\"])", _coluna);
                    break;
                case "smallmoney":
                    strParam = string.Format("Convert.ToDecimal(dsRetornado.Tables[0].Rows[0][\"{0}\"])", _coluna);
                    break;
                case "text":
                    strParam = string.Format("Convert.ToString(dsRetornado.Tables[0].Rows[0][\"{0}\"])", _coluna);
                    break;
                case "tinyint":
                    strParam = string.Format("Convert.ToInt32(dsRetornado.Tables[0].Rows[0][\"{0}\"])", _coluna);
                    break;
                case "varbinary":
                    strParam = string.Format("Convert.ToBoolean(dsRetornado.Tables[0].Rows[0][\"{0}\"].ToString().Split(',')[0])", _coluna);
                    break;
                case "varchar":
                    strParam = string.Format("Convert.ToString(dsRetornado.Tables[0].Rows[0][\"{0}\"])", _coluna);
                    break;
                case "uniqueidentifier":
                    strParam = string.Format("new {0}(dsRetornado.Tables[0].Rows[0][\"{1}\"].ToString())", "Guid", _coluna);
                    break;
                default:
                    strParam = string.Format("Convert.ToString(dsRetornado.Tables[0].Rows[0][\"{0}\"])", _coluna);
                    break;
            }
            return strParam;
        }

        /// <summary>
        /// Define qual o tipo a variável do banco de dados vai ter
        /// </summary>
        /// <param name="_coluna">string</param>
        /// <param name="_tipo">string</param>
        /// <returns></returns>
        public string RetornaConvertCollectionsForm(string _coluna, string _tipo)
        {
            // Define qual o tipo da coluna setar o tipo do atributo
            switch (_tipo)
            {
                //string.Format("collection[\"{0}\"]", _coluna);;
                case "bigint":
                    strParam = string.Format("Convert.ToInt32(tab.{0})", _coluna);
                    break;
                case "binary":
                    strParam = string.Format("Convert.ToBoolean(tab.{0}.ToString().Split(',')[0])", _coluna);
                    break;
                case "bit":
                    strParam = string.Format("Convert.ToBoolean(tab.{0}.ToString().Split(',')[0])", _coluna);
                    break;
                case "char":
                    strParam = string.Format("Convert.ToString(tab.{0})", _coluna);
                    break;
                case "datetime":
                    strParam = string.Format("Convert.ToDateTime(tab.{0})", _coluna);
                    break;
                case "decimal":
                    strParam = string.Format("Convert.ToDecimal(tab.{0})", _coluna);
                    break;
                case "float":
                    strParam = string.Format("Convert.ToDouble(tab.{0})", _coluna);
                    break;
                case "image":
                    strParam = string.Format("Convert.ToString(tab.{0})", _coluna);
                    break;
                case "int":
                    strParam = string.Format("Convert.ToInt32(tab.{0})", _coluna);
                    break;
                case "money":
                    strParam = string.Format("Convert.ToDecimal(tab.{0}., 18, 2)", _coluna);
                    break;
                case "nchar":
                    strParam = string.Format("Convert.ToString(tab.{0})", _coluna);
                    break;
                case "ntext":
                    strParam = string.Format("Convert.ToString(tab.{0})", _coluna);
                    break;
                case "numeric":
                    strParam = string.Format("Convert.ToDecimal(tab.{0})", _coluna);
                    break;
                case "nvarchar":
                    strParam = string.Format("Convert.ToString(tab.{0})", _coluna);
                    break;
                case "real":
                    strParam = string.Format("Convert.ToDecimal(tab.{0})", _coluna);
                    break;
                case "smalldatetime":
                    strParam = string.Format("Convert.ToDateTime(tab.{0})", _coluna);
                    break;
                case "smallint":
                    strParam = string.Format("Convert.ToInt32(tab.{0})", _coluna);
                    break;
                case "smallmoney":
                    strParam = string.Format("Convert.ToDecimal(tab.{0})", _coluna);
                    break;
                case "text":
                    strParam = string.Format("Convert.ToString(tab.{0})", _coluna);
                    break;
                case "tinyint":
                    strParam = string.Format("Convert.ToInt32(tab.{0})", _coluna);
                    break;
                case "varbinary":
                    strParam = string.Format("Convert.ToBoolean(tab.{0}.ToString().Split(',')[0])", _coluna);
                    break;
                case "varchar":
                    strParam = string.Format("Convert.ToString(tab.{0})", _coluna);
                    break;
                case "uniqueidentifier":
                    strParam = string.Format("new {0}(tab.{0})", "Guid", _coluna);
                    break;
                default:
                    strParam = string.Format("Convert.ToString(tab.{0})", _coluna);
                    break;
            }
            return strParam;
        }


        /// <summary>
        /// Define qual o tipo a variável do banco de dados vai ter
        /// </summary>
        /// <param name="_tipo"></param>
        /// <returns></returns>
        public string DefineTipo(string _tipo)
        {
            // Define qual o tipo da coluna setar o tipo do atributo
            switch (_tipo)
            {
                case "bigint":
                    strTipo = "Int64";
                    break;
                case "binary":
                    strTipo = "bool";
                    break;
                case "bit":
                    strTipo = "bool";
                    break;
                case "char":
                    strTipo = "char";
                    break;
                case "datetime":
                    strTipo = "DateTime";
                    break;
                case "decimal":
                    strTipo = "decimal";
                    break;
                case "float":
                    strTipo = "float";
                    break;
                case "image":
                    strTipo = "Buffer";
                    break;
                case "int":
                    strTipo = "int";
                    break;
                case "money":
                    strTipo = "Decimal";
                    break;
                case "nchar":
                    strTipo = "string";
                    break;
                case "ntext":
                    strTipo = "StringBuilder";
                    break;
                case "numeric":
                    strTipo = "Int64";
                    break;
                case "nvarchar":
                    strTipo = "string";
                    break;
                case "real":
                    strTipo = "float";
                    break;
                case "smalldatetime":
                    strTipo = "DateTime";
                    break;
                case "smallint":
                    strTipo = "Int32";
                    break;
                case "smallmoney":
                    strTipo = "Decimal";
                    break;
                case "text":
                    strTipo = "StringBuilder";
                    break;
                case "tinyint":
                    strTipo = "int";
                    break;
                case "varbinary":
                    strTipo = "bool[]";
                    break;
                case "varchar":
                    strTipo = "string";
                    break;
                case "uniqueidentifier":
                    strTipo = "Guid";
                    break;
                default:
                    strTipo = "string";
                    break;
            }
            return strTipo;
        }
    }
}
