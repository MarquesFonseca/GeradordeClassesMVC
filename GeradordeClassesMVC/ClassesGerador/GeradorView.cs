using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GeradorView
{
    public enum TipoDeViews { List, Details, Edit, Create }
    public enum ModeloDeViews { Modelo1, Modelo2, Modelo3, Modelo4 }
    /// <summary>
    /// Classe VO
    /// Criador: Marques Silva Fonseca
    /// Criada em 22/03/2012
    /// Contato: marques-fonseca@hotmail.com
    /// </summary>
    public class GeradorView
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
        public GeradorView()
        {
            strData = DateTime.Today.ToShortDateString() + " às " + DateTime.Now.ToShortTimeString();
            s = " ";
            tb = "      ";

        }

        // Metodos
        public StringBuilder GeraCodigoView(TipoDeViews tipoDeView, ModeloDeViews modeloDeViews, string _tabela, string _conexao, string _banco)
        {
            string strTabela = _tabela;
            string tabelaFormatada = strTabela.Replace("_", "").Replace("-", "");
            objCodigo = new StringBuilder();

            #region ModeloViews Modelo 1
            if (modeloDeViews == ModeloDeViews.Modelo1)
            {
                objCodigo = new StringBuilder();
                int nunrec = 0;
                string nomePrimeiroCampo = string.Empty;
                string nomeCampoAtual = string.Empty;

                #region TipoViews List
                if (tipoDeView == TipoDeViews.List)
                {
                    #region Antes do Loop Colunas

                    objCodigo.AppendLine("@model IEnumerable<DTO.Tab" + tabelaFormatada + ">                                                                                                                                                                        ");
                    objCodigo.AppendLine("                                                                                                                                                                                                               ");
                    objCodigo.AppendLine("@{                                                                                                                                                                                                             ");
                    objCodigo.AppendLine("    ViewBag.Title = \"Relatório - " + tabelaFormatada + "\";                                                                                                                                                               ");
                    objCodigo.AppendLine("    Layout = \"~/Views/Shared/_Layout.cshtml\";                                                                                                                                                 ");
                    objCodigo.AppendLine("}                                                                                                                                                                                                              ");
                    objCodigo.AppendLine("                                                                                                                                                                                                               ");
                    objCodigo.AppendLine("<!-- MAIN CONTENT -->                                                                                                                                                                                          ");
                    objCodigo.AppendLine("<div id=\"content\">                                                                                                                                                                                             ");
                    objCodigo.AppendLine("    <div class=\"row\">                                                                                                                                                                                          ");
                    objCodigo.AppendLine("        <div class=\"col-xs-12 col-sm-7 col-md-7 col-lg-4\">                                                                                                                                                     ");
                    objCodigo.AppendLine("            <h1 class=\"page-title txt-color-blueDark\">                                                                                                                                                         ");
                    objCodigo.AppendLine("                <i class=\"fa fa-table fa-fw \"></i>                                                                                                                                                             ");
                    objCodigo.AppendLine("                Relatórios <span>                                                                                                                                                                              ");
                    objCodigo.AppendLine("                    > " + tabelaFormatada + "                                                                                                                                                                            ");
                    objCodigo.AppendLine("                </span>                                                                                                                                                                                        ");
                    objCodigo.AppendLine("            </h1>                                                                                                                                                                                              ");
                    objCodigo.AppendLine("        </div>                                                                                                                                                                                                 ");
                    objCodigo.AppendLine("        <div class=\"col-xs-12 col-sm-5 col-md-5 col-lg-8\">                                                                                                                                                     ");
                    objCodigo.AppendLine("            <ul id=\"sparks\" class=\"\">                                                                                                                                                                          ");
                    objCodigo.AppendLine("                <li class=\"sparks-info\">                                                                                                                                                                       ");
                    objCodigo.AppendLine("                    @Html.ActionLink(\"Novo\", \"create\", new { /*id = Model.ColunaId*/ }, new { @class = \"btn btn-default\" })                                                                          ");
                    objCodigo.AppendLine("                </li>                                                                                                                                                                                          ");
                    objCodigo.AppendLine("            </ul>                                                                                                                                                                                              ");
                    objCodigo.AppendLine("        </div>                                                                                                                                                                                                 ");
                    objCodigo.AppendLine("    </div>                                                                                                                                                                                                     ");
                    objCodigo.AppendLine("    <!-- widget grid -->                                                                                                                                                                                       ");
                    objCodigo.AppendLine("    <section id=\"widget-grid\" class=\"\">                                                                                                                                                                        ");
                    objCodigo.AppendLine("        <!-- row -->                                                                                                                                                                                           ");
                    objCodigo.AppendLine("        <div class=\"row\">                                                                                                                                                                                      ");
                    objCodigo.AppendLine("            <!-- NEW WIDGET START -->                                                                                                                                                                          ");
                    objCodigo.AppendLine("            <article class=\"col-xs-12 col-sm-12 col-md-12 col-lg-12\">                                                                                                                                          ");
                    objCodigo.AppendLine("                <!-- Widget ID (each widget will need unique ID)-->                                                                                                                                            ");
                    objCodigo.AppendLine("                <div class=\"jarviswidget jarviswidget-color-blueDark\" id=\"wid-id-3\" data-widget-editbutton=\"false\">                                                                                            ");
                    objCodigo.AppendLine("                    <!-- widget options:                                                                                                                                                                       ");
                    objCodigo.AppendLine("                    usage: <div class=\"jarviswidget\" id=\"wid-id-0\" data-widget-editbutton=\"false\">                                                                                                             ");
                    objCodigo.AppendLine("                                                                                                                                                                                                               ");
                    objCodigo.AppendLine("                    data-widget-colorbutton=\"false\"                                                                                                                                                            ");
                    objCodigo.AppendLine("                    data-widget-editbutton=\"false\"                                                                                                                                                             ");
                    objCodigo.AppendLine("                    data-widget-togglebutton=\"false\"                                                                                                                                                           ");
                    objCodigo.AppendLine("                    data-widget-deletebutton=\"false\"                                                                                                                                                           ");
                    objCodigo.AppendLine("                    data-widget-fullscreenbutton=\"false\"                                                                                                                                                       ");
                    objCodigo.AppendLine("                    data-widget-custombutton=\"false\"                                                                                                                                                           ");
                    objCodigo.AppendLine("                    data-widget-collapsed=\"true\"                                                                                                                                                               ");
                    objCodigo.AppendLine("                    data-widget-sortable=\"false\"                                                                                                                                                               ");
                    objCodigo.AppendLine("                                                                                                                                                                                                               ");
                    objCodigo.AppendLine("                    -->                                                                                                                                                                                        ");
                    objCodigo.AppendLine("                    <header>                                                                                                                                                                                   ");
                    objCodigo.AppendLine("                        <span class=\"widget-icon\"> <i class=\"fa fa-table\"></i> </span>                                                                                                                         ");
                    objCodigo.AppendLine("                        <h2>Todos os " + tabelaFormatada + "</h2>                                                                                                                                                              ");
                    objCodigo.AppendLine("                    </header>                                                                                                                                                                                  ");
                    objCodigo.AppendLine("                    <!-- widget div-->                                                                                                                                                                         ");
                    objCodigo.AppendLine("                    <div>                                                                                                                                                                                      ");
                    objCodigo.AppendLine("                        <!-- widget edit box -->                                                                                                                                                               ");
                    objCodigo.AppendLine("                        <div class=\"jarviswidget-editbox\">                                                                                                                                                     ");
                    objCodigo.AppendLine("                            <!-- This area used as dropdown edit box -->                                                                                                                                       ");
                    objCodigo.AppendLine("                        </div>                                                                                                                                                                                 ");
                    objCodigo.AppendLine("                        <!-- end widget edit box -->                                                                                                                                                           ");
                    objCodigo.AppendLine("                        <!-- widget content -->                                                                                                                                                                ");
                    objCodigo.AppendLine("                        <div class=\"widget-body no-padding\">                                                                                                                                                   ");
                    objCodigo.AppendLine("                            <table id=\"datatable_tabletools\" class=\"table table-striped table-bordered table-hover\" width=\"100%\">                                                                              ");
                    objCodigo.AppendLine("                                <thead>                                                                                                                                                                        ");
                    objCodigo.AppendLine("                                    <tr>                                                                                                                                                                       ");
                    #endregion

                    #region Loop Colunas
                    // Abre conexão com o banco
                    objBanco = new Banco.Banco(_conexao);
                    // Cria o objeto da classe Library
                    objLib = new Library.Library();
                    // Faz a leitura de todas as colunas da tabela
                    objDr = objBanco.QueryConsulta("SELECT * FROM " + strTabela);
                    // Conta o número de colunas
                    nunrec = objDr.FieldCount;

                    for (int i = 0; i < nunrec; i++)
                    {
                        nomeCampoAtual = objDr.GetName(i);
                        if (i == 0)//pega o 1º
                        {
                            nomePrimeiroCampo = objDr.GetName(i);
                            objCodigo.AppendLine("@foreach (var itemColunas in Model)");
                            objCodigo.AppendLine("{");
                            objCodigo.AppendLine("<th style=\"max-width: 55px;\">[&nbsp;&nbsp;Ações&nbsp;&nbsp;]</th>");
                            continue;
                        }

                        if (i == 1)//pega o 2º
                        {
                            objCodigo.AppendLine("<th>@Html.LabelFor(m => itemColunas." + objDr.GetName(i) + ")</th>");
                            continue;
                        }

                        objCodigo.AppendLine("<th data-hide=\"phone,tablet\">@Html.LabelFor(m => itemColunas." + objDr.GetName(i) + ")</th>");

                        if (i == nunrec - 1)//pega o ultimo
                        {
                            objCodigo.AppendLine("<th style=\"max-width: 20px;\"></th>");
                            objCodigo.AppendLine("break;");
                            objCodigo.AppendLine("}");
                            continue;
                        }
                    }

                    // fecha conexão
                    objBanco.CloseConn();
                    objLib = null;

                    objCodigo.AppendLine("</tr>");
                    objCodigo.AppendLine("</thead>");

                    #endregion

                    #region Loop Linhas
                    // Abre conexão com o banco
                    objBanco = new Banco.Banco(_conexao);
                    // Cria o objeto da classe Library
                    objLib = new Library.Library();
                    // Faz a leitura de todas as colunas da tabela
                    objDr = objBanco.QueryConsulta("SELECT * FROM " + strTabela);
                    // Conta o número de colunas
                    nunrec = objDr.FieldCount;


                    for (int i = 0; i < nunrec; i++)
                    {
                        nomeCampoAtual = objDr.GetName(i);
                        if (i == 0)//pega 0 1º
                        {
                            nomePrimeiroCampo = objDr.GetName(i);
                            objCodigo.AppendLine("<tbody>                                                                                                                                                                        ");
                            objCodigo.AppendLine("                                    @foreach (var item in Model)                                                                                                                                               ");
                            objCodigo.AppendLine("                                    {                                                                                                                                                                          ");
                            objCodigo.AppendLine("                                        <tr>                                                                                                                                                                   ");
                            objCodigo.AppendLine("                                            <td>                                                                                                                                                               ");
                            objCodigo.AppendLine("                                                <div>                                                                                                                                                          ");
                            objCodigo.AppendLine("                                                    <a title=\"Ver detalhes\" href=\"@Url.Action(\"Details\", \"" + tabelaFormatada + "\",  new { id = item." + nomePrimeiroCampo + " })\" class=\"btn btn-default btn-xs fa fa-reorder\"></a> ");
                            objCodigo.AppendLine("                                                    <a title=\"Editar registro\" href=\"@Url.Action(\"Edit\", \"" + tabelaFormatada + "\", new { id = item." + nomePrimeiroCampo + " })\" class=\"btn btn-default btn-xs fa fa-edit\"></a>     ");
                            objCodigo.AppendLine("                                                </div>                                                                                                                                                         ");
                            objCodigo.AppendLine("                                            </td>                                                                                                                                                              ");
                            continue;
                        }

                        objCodigo.AppendLine("<td>@Html.DisplayFor(modelItem => item." + objDr.GetName(i) + ")</td>");

                        if (i == nunrec - 1)//pega o ultimo
                        {
                            objCodigo.AppendLine("                                            <td><a title=\"Remover registro\" href=\"@Url.Action(\"Delete\", \"" + tabelaFormatada + "\", new { id = item." + nomePrimeiroCampo + " })\" class=\"btn btn-default btn-xs fa fa-times\"></a></td>");
                            objCodigo.AppendLine("                                        </tr>                                                                                                                                                                  ");
                            objCodigo.AppendLine("                                    }                                                                                                                                                                          ");
                            objCodigo.AppendLine("                                </tbody>                                                                                                                                                                       ");
                            objCodigo.AppendLine("                            </table>                                                                                                                                                                           ");
                            objCodigo.AppendLine("                        </div>                                                                                                                                                                                 ");
                            objCodigo.AppendLine("                        <!-- end widget content -->                                                                                                                                                            ");
                            objCodigo.AppendLine("                    </div>                                                                                                                                                                                     ");
                            objCodigo.AppendLine("                    <!-- end widget div -->                                                                                                                                                                    ");
                            objCodigo.AppendLine("                </div>                                                                                                                                                                                         ");
                            objCodigo.AppendLine("                <!-- end widget -->                                                                                                                                                                            ");
                            objCodigo.AppendLine("            </article>                                                                                                                                                                                         ");
                            objCodigo.AppendLine("            <!-- WIDGET END -->                                                                                                                                                                                ");
                            objCodigo.AppendLine("        </div>                                                                                                                                                                                                 ");
                            objCodigo.AppendLine("        <!-- end row -->                                                                                                                                                                                       ");
                            objCodigo.AppendLine("        <!-- end row -->                                                                                                                                                                                       ");
                            objCodigo.AppendLine("    </section>                                                                                                                                                                                                 ");
                            objCodigo.AppendLine("    <!-- end widget grid -->                                                                                                                                                                                   ");
                            objCodigo.AppendLine("</div>                                                                                                                                                                                                         ");
                            objCodigo.AppendLine("<!-- END MAIN CONTENT -->                                                                                                                                                                                      ");
                            continue;
                        }
                    }

                    // fecha conexão
                    objBanco.CloseConn();
                    objLib = null;
                    #endregion

                    #region javascripts
                    objCodigo.AppendLine("");
                    objCodigo.AppendLine("@section pagespecific {                                                                                                                                                          ");
                    objCodigo.AppendLine("    <script type=\"text/javascript\">                                                                                                                                              ");
                    objCodigo.AppendLine("        $(document).ready(function () {                                                                                                                                          ");
                    objCodigo.AppendLine("            /* BASIC ;*/                                                                                                                                                         ");
                    objCodigo.AppendLine("            var responsiveHelper_dt_basic = undefined;                                                                                                                           ");
                    objCodigo.AppendLine("            var responsiveHelper_datatable_fixed_column = undefined;                                                                                                             ");
                    objCodigo.AppendLine("            var responsiveHelper_datatable_col_reorder = undefined;                                                                                                              ");
                    objCodigo.AppendLine("            var responsiveHelper_datatable_tabletools = undefined;                                                                                                               ");
                    objCodigo.AppendLine("                                                                                                                                                                                 ");
                    objCodigo.AppendLine("            var breakpointDefinition = {                                                                                                                                         ");
                    objCodigo.AppendLine("                tablet: 1024,                                                                                                                                                    ");
                    objCodigo.AppendLine("                phone: 480                                                                                                                                                       ");
                    objCodigo.AppendLine("            };                                                                                                                                                                   ");
                    objCodigo.AppendLine("                                                                                                                                                                                 ");
                    objCodigo.AppendLine("            $('#dt_basic').dataTable({                                                                                                                                           ");
                    objCodigo.AppendLine("                \"sDom\": \"<'dt-toolbar'<'col-xs-12 col-sm-6'f><'col-sm-6 col-xs-12 hidden-xs'l>r>\" +                                                                              ");
                    objCodigo.AppendLine("                    \"t\" +                                                                                                                                                        ");
                    objCodigo.AppendLine("                    \"<'dt-toolbar-footer'<'col-sm-6 col-xs-12 hidden-xs'i><'col-xs-12 col-sm-6'p>>\",                                                                             ");
                    objCodigo.AppendLine("                \"autoWidth\": true,                                                                                                                                               ");
                    objCodigo.AppendLine("                \"preDrawCallback\": function () {                                                                                                                                 ");
                    objCodigo.AppendLine("                    // Initialize the responsive datatables helper once.                                                                                                         ");
                    objCodigo.AppendLine("                    if (!responsiveHelper_dt_basic) {                                                                                                                            ");
                    objCodigo.AppendLine("                        responsiveHelper_dt_basic = new ResponsiveDatatablesHelper($('#dt_basic'), breakpointDefinition);                                                        ");
                    objCodigo.AppendLine("                    }                                                                                                                                                            ");
                    objCodigo.AppendLine("                },                                                                                                                                                               ");
                    objCodigo.AppendLine("                \"rowCallback\": function (nRow) {                                                                                                                                 ");
                    objCodigo.AppendLine("                    responsiveHelper_dt_basic.createExpandIcon(nRow);                                                                                                            ");
                    objCodigo.AppendLine("                },                                                                                                                                                               ");
                    objCodigo.AppendLine("                \"drawCallback\": function (oSettings) {                                                                                                                           ");
                    objCodigo.AppendLine("                    responsiveHelper_dt_basic.respond();                                                                                                                         ");
                    objCodigo.AppendLine("                }                                                                                                                                                                ");
                    objCodigo.AppendLine("            });                                                                                                                                                                  ");
                    objCodigo.AppendLine("            /* END BASIC */                                                                                                                                                      ");
                    objCodigo.AppendLine("                                                                                                                                                                                 ");
                    objCodigo.AppendLine("            /* COLUMN FILTER  */                                                                                                                                                 ");
                    objCodigo.AppendLine("            var otable = $('#datatable_fixed_column').DataTable({                                                                                                                ");
                    objCodigo.AppendLine("                \"sDom\": \"<'dt-toolbar'<'col-xs-12 col-sm-6 hidden-xs'f><'col-sm-6 col-xs-12 hidden-xs'<'toolbar'>>r>\" +                                                          ");
                    objCodigo.AppendLine("                        \"t\" +                                                                                                                                                    ");
                    objCodigo.AppendLine("                        \"<'dt-toolbar-footer'<'col-sm-6 col-xs-12 hidden-xs'i><'col-xs-12 col-sm-6'p>>\",                                                                         ");
                    objCodigo.AppendLine("                \"autoWidth\": true,                                                                                                                                               ");
                    objCodigo.AppendLine("                \"preDrawCallback\": function () {                                                                                                                                 ");
                    objCodigo.AppendLine("                    // Initialize the responsive datatables helper once.                                                                                                         ");
                    objCodigo.AppendLine("                    if (!responsiveHelper_datatable_fixed_column) {                                                                                                              ");
                    objCodigo.AppendLine("                        responsiveHelper_datatable_fixed_column = new ResponsiveDatatablesHelper($('#datatable_fixed_column'), breakpointDefinition);                            ");
                    objCodigo.AppendLine("                    }                                                                                                                                                            ");
                    objCodigo.AppendLine("                },                                                                                                                                                               ");
                    objCodigo.AppendLine("                \"rowCallback\": function (nRow) {                                                                                                                                 ");
                    objCodigo.AppendLine("                    responsiveHelper_datatable_fixed_column.createExpandIcon(nRow);                                                                                              ");
                    objCodigo.AppendLine("                },                                                                                                                                                               ");
                    objCodigo.AppendLine("                \"drawCallback\": function (oSettings) {                                                                                                                           ");
                    objCodigo.AppendLine("                    responsiveHelper_datatable_fixed_column.respond();                                                                                                           ");
                    objCodigo.AppendLine("                }                                                                                                                                                                ");
                    objCodigo.AppendLine("            });                                                                                                                                                                  ");
                    objCodigo.AppendLine("                                                                                                                                                                                 ");
                    objCodigo.AppendLine("            // custom toolbar                                                                                                                                                    ");
                    objCodigo.AppendLine("            $(\"div.toolbar\").html('<div class=\"text-right\"><img src=\"/Content/img/logo.png\" alt=\"SmartAdmin\" style=\"width: 111px; margin-top: 3px; margin-right: 10px;\"></div>');");
                    objCodigo.AppendLine("                                                                                                                                                                                 ");
                    objCodigo.AppendLine("            // Apply the filter                                                                                                                                                  ");
                    objCodigo.AppendLine("            $(\"#datatable_fixed_column thead th input[type=text]\").on('keyup change', function () {                                                                              ");
                    objCodigo.AppendLine("                                                                                                                                                                                 ");
                    objCodigo.AppendLine("                otable                                                                                                                                                           ");
                    objCodigo.AppendLine("                    .column($(this).parent().index() + ':visible')                                                                                                               ");
                    objCodigo.AppendLine("                    .search(this.value)                                                                                                                                          ");
                    objCodigo.AppendLine("                    .draw();                                                                                                                                                     ");
                    objCodigo.AppendLine("            });                                                                                                                                                                  ");
                    objCodigo.AppendLine("            /* END COLUMN FILTER */                                                                                                                                              ");
                    objCodigo.AppendLine("                                                                                                                                                                                 ");
                    objCodigo.AppendLine("            /* COLUMN SHOW - HIDE */                                                                                                                                             ");
                    objCodigo.AppendLine("            $('#datatable_col_reorder').dataTable({                                                                                                                              ");
                    objCodigo.AppendLine("                \"sDom\": \"<'dt-toolbar'<'col-xs-12 col-sm-6'f><'col-sm-6 col-xs-6 hidden-xs'C>r>\" +                                                                               ");
                    objCodigo.AppendLine("                        \"t\" +                                                                                                                                                    ");
                    objCodigo.AppendLine("                        \"<'dt-toolbar-footer'<'col-sm-6 col-xs-12 hidden-xs'i><'col-sm-6 col-xs-12'p>>\",                                                                         ");
                    objCodigo.AppendLine("                \"autoWidth\": true,                                                                                                                                               ");
                    objCodigo.AppendLine("                \"preDrawCallback\": function () {                                                                                                                                 ");
                    objCodigo.AppendLine("                    // Initialize the responsive datatables helper once.                                                                                                         ");
                    objCodigo.AppendLine("                    if (!responsiveHelper_datatable_col_reorder) {                                                                                                               ");
                    objCodigo.AppendLine("                        responsiveHelper_datatable_col_reorder = new ResponsiveDatatablesHelper($('#datatable_col_reorder'), breakpointDefinition);                              ");
                    objCodigo.AppendLine("                    }                                                                                                                                                            ");
                    objCodigo.AppendLine("                },                                                                                                                                                               ");
                    objCodigo.AppendLine("                \"rowCallback\": function (nRow) {                                                                                                                                 ");
                    objCodigo.AppendLine("                    responsiveHelper_datatable_col_reorder.createExpandIcon(nRow);                                                                                               ");
                    objCodigo.AppendLine("                },                                                                                                                                                               ");
                    objCodigo.AppendLine("                \"drawCallback\": function (oSettings) {                                                                                                                           ");
                    objCodigo.AppendLine("                    responsiveHelper_datatable_col_reorder.respond();                                                                                                            ");
                    objCodigo.AppendLine("                }                                                                                                                                                                ");
                    objCodigo.AppendLine("            });                                                                                                                                                                  ");
                    objCodigo.AppendLine("            /* END COLUMN SHOW - HIDE */                                                                                                                                         ");
                    objCodigo.AppendLine("                                                                                                                                                                                 ");
                    objCodigo.AppendLine("            /* TABLETOOLS */                                                                                                                                                     ");
                    objCodigo.AppendLine("            $('#datatable_tabletools').dataTable({                                                                                                                               ");
                    objCodigo.AppendLine("                \"sDom\": \"<'dt-toolbar'<'col-xs-12 col-sm-6'f><'col-sm-6 col-xs-6 hidden-xs'T>r>\" +                                                                               ");
                    objCodigo.AppendLine("                        \"t\" +                                                                                                                                                    ");
                    objCodigo.AppendLine("                        \"<'dt-toolbar-footer'<'col-sm-6 col-xs-12 hidden-xs'i><'col-sm-6 col-xs-12'p>>\",                                                                         ");
                    objCodigo.AppendLine("                \"oTableTools\": {                                                                                                                                                 ");
                    objCodigo.AppendLine("                    \"aButtons\": [                                                                                                                                                ");
                    objCodigo.AppendLine("                    \"copy\",                                                                                                                                                      ");
                    objCodigo.AppendLine("                    \"csv\",                                                                                                                                                       ");
                    objCodigo.AppendLine("                    \"xls\",                                                                                                                                                       ");
                    objCodigo.AppendLine("                       {                                                                                                                                                         ");
                    objCodigo.AppendLine("                           \"sExtends\": \"pdf\",                                                                                                                                    ");
                    objCodigo.AppendLine("                           \"sTitle\": \"SmartAdmin_PDF\",                                                                                                                           ");
                    objCodigo.AppendLine("                           \"sPdfMessage\": \"SmartAdmin PDF Export\",                                                                                                               ");
                    objCodigo.AppendLine("                           \"sPdfSize\": \"letter\"                                                                                                                                  ");
                    objCodigo.AppendLine("                       },                                                                                                                                                        ");
                    objCodigo.AppendLine("                       {                                                                                                                                                         ");
                    objCodigo.AppendLine("                           \"sExtends\": \"print\",                                                                                                                                  ");
                    objCodigo.AppendLine("                           \"sMessage\": \"Generated by SmartAdmin <i>(press Esc to close)</i>\"                                                                                     ");
                    objCodigo.AppendLine("                       }                                                                                                                                                         ");
                    objCodigo.AppendLine("                    ],                                                                                                                                                           ");
                    objCodigo.AppendLine("                    \"sSwfPath\": \"/Scripts/plugin/datatables/swf/copy_csv_xls_pdf.swf\"                                                                                            ");
                    objCodigo.AppendLine("                },                                                                                                                                                               ");
                    objCodigo.AppendLine("                \"autoWidth\": true,                                                                                                                                               ");
                    objCodigo.AppendLine("                \"preDrawCallback\": function () {                                                                                                                                 ");
                    objCodigo.AppendLine("                    // Initialize the responsive datatables helper once.                                                                                                         ");
                    objCodigo.AppendLine("                    if (!responsiveHelper_datatable_tabletools) {                                                                                                                ");
                    objCodigo.AppendLine("                        responsiveHelper_datatable_tabletools = new ResponsiveDatatablesHelper($('#datatable_tabletools'), breakpointDefinition);                                ");
                    objCodigo.AppendLine("                    }                                                                                                                                                            ");
                    objCodigo.AppendLine("                },                                                                                                                                                               ");
                    objCodigo.AppendLine("                \"rowCallback\": function (nRow) {                                                                                                                                 ");
                    objCodigo.AppendLine("                    responsiveHelper_datatable_tabletools.createExpandIcon(nRow);                                                                                                ");
                    objCodigo.AppendLine("                },                                                                                                                                                               ");
                    objCodigo.AppendLine("                \"drawCallback\": function (oSettings) {                                                                                                                           ");
                    objCodigo.AppendLine("                    responsiveHelper_datatable_tabletools.respond();                                                                                                             ");
                    objCodigo.AppendLine("                }                                                                                                                                                                ");
                    objCodigo.AppendLine("            });                                                                                                                                                                  ");
                    objCodigo.AppendLine("            /* END TABLETOOLS */                                                                                                                                                 ");
                    objCodigo.AppendLine("        })                                                                                                                                                                       ");
                    objCodigo.AppendLine("                                                                                                                                                                                 ");
                    objCodigo.AppendLine("    </script>                                                                                                                                                                    ");
                    objCodigo.AppendLine("}                                                                                                                                                                                ");
                    objCodigo.AppendLine("");
                    #endregion
                }
                #endregion

                #region TipoViews Details
                if (tipoDeView == TipoDeViews.Details)
                {
                    #region Antes do Loop Colunas
                    objCodigo.AppendLine("@model DTO.Tab" + tabelaFormatada + "                                                                                                                                             ");
                    objCodigo.AppendLine("@{                                                                                                                                                                                            ");
                    objCodigo.AppendLine("    ViewBag.Title = \"Detalhes do cadastro de " + tabelaFormatada + "\";                                                                                                                                  ");
                    objCodigo.AppendLine("    Layout = \"~/Views/Shared/_Layout.cshtml\";                                                                                                                                               ");
                    objCodigo.AppendLine("}                                                                                                                                                                                             ");
                    objCodigo.AppendLine("<!-- MAIN CONTENT -->                                                                                                                                                                         ");
                    objCodigo.AppendLine("<div id=\"content\">                                                                                                                                                                          ");
                    objCodigo.AppendLine("    <div class=\"row\">                                                                                                                                                                       ");
                    objCodigo.AppendLine("        <div class=\"col-sm-12 col-md-12 col-lg-12\">                                                                                                                                         ");
                    objCodigo.AppendLine("            <h1 class=\"page-title txt-color-blueDark\">                                                                                                                                      ");
                    objCodigo.AppendLine("                <i class=\"fa fa-edit fa-fw \"></i>                                                                                                                                           ");
                    objCodigo.AppendLine("                Cadastros <span> Detalhes do cadastro de " + tabelaFormatada + " </span>                                                                                                                 ");
                    objCodigo.AppendLine("            </h1>                                                                                                                                                                             ");
                    objCodigo.AppendLine("        </div>                                                                                                                                                                                ");
                    objCodigo.AppendLine("    </div>                                                                                                                                                                                    ");
                    objCodigo.AppendLine("    <!-- widget grid -->                                                                                                                                                                      ");
                    objCodigo.AppendLine("    <section id=\"widget-grid\" class=\"\">                                                                                                                                                   ");
                    objCodigo.AppendLine("        <!-- NEW ROW -->                                                                                                                                                                      ");
                    objCodigo.AppendLine("        <div class=\"row\">                                                                                                                                                                   ");
                    objCodigo.AppendLine("            <!-- NEW COL START -->                                                                                                                                                            ");
                    objCodigo.AppendLine("            <article class=\"col-sm-12 col-md-12 col-lg-12\">                                                                                                                                 ");
                    objCodigo.AppendLine("                <!-- Widget ID (each widget will need unique ID)-->                                                                                                                           ");
                    objCodigo.AppendLine("                <div class=\"jarviswidget jarviswidget-color-blueDark\" id=\"wid-id-3\" data-widget-colorbutton=\"false\" data-widget-editbutton=\"false\" data-widget-custombutton=\"false\">");
                    objCodigo.AppendLine("                    <header>                                                                                                                                                                  ");
                    objCodigo.AppendLine("                        <span class=\"widget-icon\"> <i class=\"fa fa-edit\"></i> </span>                                                                                                     ");
                    objCodigo.AppendLine("                        <h2>Formulário de cadastro</h2>                                                                                                                                       ");
                    objCodigo.AppendLine("                    </header>                                                                                                                                                                 ");
                    objCodigo.AppendLine("                    <!-- widget div-->                                                                                                                                                        ");
                    objCodigo.AppendLine("                    <div>                                                                                                                                                                     ");
                    objCodigo.AppendLine("                        <!-- widget edit box -->                                                                                                                                              ");
                    objCodigo.AppendLine("                        <div class=\"jarviswidget-editbox\">                                                                                                                                  ");
                    objCodigo.AppendLine("                            <!-- This area used as dropdown edit box -->                                                                                                                      ");
                    objCodigo.AppendLine("                        </div>                                                                                                                                                                ");
                    objCodigo.AppendLine("                        <!-- end widget edit box -->                                                                                                                                          ");
                    objCodigo.AppendLine("                        <!-- widget content -->                                                                                                                                               ");
                    objCodigo.AppendLine("                        <div class=\"widget-body no-padding\">                                                                                                                                ");
                    objCodigo.AppendLine("                            <div class=\"smart-form\">                                                                                                                                        ");
                    objCodigo.AppendLine("                                <header>Detalhes do cadastro de " + tabelaFormatada + "</header>                                                                                                     ");
                    objCodigo.AppendLine("                                @Html.AntiForgeryToken()                                                                                                                                      ");
                    objCodigo.AppendLine("                                <fieldset>                                                                                                                                                    ");
                    objCodigo.AppendLine("                                    @Html.ValidationBootstrap()                                                                                                                               ");

                    #endregion


                    #region Loop Colunas
                    // Abre conexão com o banco
                    objBanco = new Banco.Banco(_conexao);
                    // Cria o objeto da classe Library
                    objLib = new Library.Library();
                    // Faz a leitura de todas as colunas da tabela
                    objDr = objBanco.QueryConsulta("SELECT * FROM " + strTabela);
                    // Conta o número de colunas
                    nunrec = objDr.FieldCount;
                    for (int i = 0; i < nunrec; i++)
                    {
                        bool EforengKey = RetornaSeEForengKey(nomeTabela: strTabela, nomeColuna: objDr.GetName(i));
                        nomeCampoAtual = objDr.GetName(i);

                        if (i == 0)//pega o 1º
                        {
                            nomePrimeiroCampo = objDr.GetName(i);
                        }
                        if (objDr.GetDataTypeName(i) == "bit")
                        {
                            objCodigo.AppendLine("                                        <section class=\"col col-3\">                                                                                      ");
                            objCodigo.AppendLine("                                            <div>                                                                                                        ");
                            objCodigo.AppendLine("                                                <label class=\"checkbox-inline\">                                                                          ");
                            objCodigo.AppendLine("                                                    @Html.CheckBoxFor(m => Model." + objDr.GetName(i) + ", new { @class = \"style-0\", disabled = \"disabled\" })      ");
                            objCodigo.AppendLine("                                                    @Html.LabelFor(m => Model." + objDr.GetName(i) + ", new { @class = \"label\" })                                  ");
                            objCodigo.AppendLine("                                                </label>                                                                                                 ");
                            objCodigo.AppendLine("                                            </div>                                                                                                       ");
                            objCodigo.AppendLine("                                        </section>                                                                                                ");
                            continue;
                        }

                        objCodigo.AppendLine("                                        <section class=\"col col-3\">                                                                                                                                             ");
                        objCodigo.AppendLine("                                            @Html.LabelFor(m => Model." + objDr.GetName(i) + ", new { @class = \"label\" })                                                                   ");
                        objCodigo.AppendLine("                                            <label class=\"input\">                                                                                                                          ");
                        objCodigo.AppendLine("                                                <i class=\"icon-append fa fa-question-circle\"></i>                                                                                           ");
                        objCodigo.AppendLine("                                                Informe o @Html.TextBoxFor(m => Model." + objDr.GetName(i) + ", new { placeholder = @ClassesAdicionais.Utils.SubstituiAcentoHTML(@Html.DisplayNameFor(m => m." + objDr.GetName(i) + ").ToString()), disabled = \"disabled\" })");
                        objCodigo.AppendLine("                                            </label>                                                                                              ");
                        objCodigo.AppendLine("                                        </section>                                                                                                ");
                        continue;
                    }

                    // fecha conexão
                    objBanco.CloseConn();
                    objLib = null;

                    #endregion


                    #region Depois das colunas
                    objCodigo.AppendLine("                                </fieldset>                                                                                                                                                   ");
                    objCodigo.AppendLine("                                <footer>                                                                                                                                                      ");
                    objCodigo.AppendLine("                                    @Html.ActionLink(\"Alterar\", \"edit\", new { id = Model." + nomePrimeiroCampo + " }, new { @class = \"btn btn-primary\" })                                          ");
                    objCodigo.AppendLine("                                    @Html.ActionLink(\"Relatório\", \"index\", new { /*id = Model." + nomePrimeiroCampo + "*/ }, new { @class = \"btn btn-default\" })                                   ");
                    objCodigo.AppendLine("                                    @Html.ActionLink(\"Novo\", \"create\", new { /*id = Model." + nomePrimeiroCampo + "*/ }, new { @class = \"btn btn-default\" })                                       ");
                    objCodigo.AppendLine("                                    <button type=\"button\" class=\"btn btn-default\" onclick=\"window.history.back();\"> Voltar </button>                                                    ");
                    objCodigo.AppendLine("                                </footer>                                                                                                                                                     ");
                    objCodigo.AppendLine("                            </div>                                                                                                                                                            ");
                    objCodigo.AppendLine("                        </div>                                                                                                                                                                ");
                    objCodigo.AppendLine("                        <!-- end widget content -->                                                                                                                                           ");
                    objCodigo.AppendLine("                    </div>                                                                                                                                                                    ");
                    objCodigo.AppendLine("                    <!-- end widget div -->                                                                                                                                                   ");
                    objCodigo.AppendLine("                </div>                                                                                                                                                                        ");
                    objCodigo.AppendLine("                <!-- end widget -->                                                                                                                                                           ");
                    objCodigo.AppendLine("            </article>                                                                                                                                                                        ");
                    objCodigo.AppendLine("            <!-- END COL -->                                                                                                                                                                  ");
                    objCodigo.AppendLine("        </div>                                                                                                                                                                                ");
                    objCodigo.AppendLine("        <!-- END ROW-->                                                                                                                                                                       ");
                    objCodigo.AppendLine("    </section>                                                                                                                                                                                ");
                    objCodigo.AppendLine("    <!-- end widget grid -->                                                                                                                                                                  ");
                    objCodigo.AppendLine("</div>                                                                                                                                                                                        ");
                    objCodigo.AppendLine("<!-- END MAIN CONTENT -->                                                                                                                                                                     ");

                    #endregion
                }
                #endregion

                #region TipoViews Edit
                if (tipoDeView == TipoDeViews.Edit)
                {
                    #region Antes do Loop Colunas
                    objCodigo.AppendLine("@model DTO.Tab" + tabelaFormatada + "                                                                                                                                             ");
                    objCodigo.AppendLine("                                                                                                                                                                                              ");
                    objCodigo.AppendLine("@{                                                                                                                                                                                            ");
                    objCodigo.AppendLine("    ViewBag.Title = \"Alteração do cadastro " + tabelaFormatada + "\";                                                                                                                                  ");
                    objCodigo.AppendLine("    Layout = \"~/Views/Shared/_Layout.cshtml\";                                                                                                                                               ");
                    objCodigo.AppendLine("}                                                                                                                                                                                             ");
                    objCodigo.AppendLine("<!-- MAIN CONTENT -->                                                                                                                                                                         ");
                    objCodigo.AppendLine("<div id=\"content\">                                                                                                                                                                          ");
                    objCodigo.AppendLine("    <div class=\"row\">                                                                                                                                                                       ");
                    objCodigo.AppendLine("        <div class=\"col-sm-12 col-md-12 col-lg-12\">                                                                                                                                         ");
                    objCodigo.AppendLine("            <h1 class=\"page-title txt-color-blueDark\">                                                                                                                                      ");
                    objCodigo.AppendLine("                <i class=\"fa fa-edit fa-fw \"></i>                                                                                                                                           ");
                    objCodigo.AppendLine("                Cadastros <span> > Alteração do cadastro " + tabelaFormatada + "</span>                                                                                                                       ");
                    objCodigo.AppendLine("            </h1>                                                                                                                                                                             ");
                    objCodigo.AppendLine("        </div>                                                                                                                                                                                ");
                    objCodigo.AppendLine("    </div>                                                                                                                                                                                    ");
                    objCodigo.AppendLine("    <!-- widget grid -->                                                                                                                                                                      ");
                    objCodigo.AppendLine("    <section id=\"widget-grid\" class=\"\">                                                                                                                                                   ");
                    objCodigo.AppendLine("        <!-- NEW ROW -->                                                                                                                                                                      ");
                    objCodigo.AppendLine("        <div class=\"row\">                                                                                                                                                                   ");
                    objCodigo.AppendLine("            <!-- NEW COL START -->                                                                                                                                                            ");
                    objCodigo.AppendLine("            <article class=\"col-sm-12 col-md-12 col-lg-12\">                                                                                                                                 ");
                    objCodigo.AppendLine("                <!-- Widget ID (each widget will need unique ID)-->                                                                                                                           ");
                    objCodigo.AppendLine("                <div class=\"jarviswidget jarviswidget-color-blueDark\" id=\"wid-id-3\" data-widget-colorbutton=\"false\" data-widget-editbutton=\"false\" data-widget-custombutton=\"false\">");
                    objCodigo.AppendLine("                    <header>                                                                                                                                                                  ");
                    objCodigo.AppendLine("                        <span class=\"widget-icon\"> <i class=\"fa fa-edit\"></i> </span>                                                                                                     ");
                    objCodigo.AppendLine("                        <h2>Formulário de cadastro</h2>                                                                                                                                       ");
                    objCodigo.AppendLine("                    </header>                                                                                                                                                                 ");
                    objCodigo.AppendLine("                    <!-- widget div-->                                                                                                                                                        ");
                    objCodigo.AppendLine("                    <div>                                                                                                                                                                     ");
                    objCodigo.AppendLine("                        <!-- widget edit box -->                                                                                                                                              ");
                    objCodigo.AppendLine("                        <div class=\"jarviswidget-editbox\">                                                                                                                                  ");
                    objCodigo.AppendLine("                            <!-- This area used as dropdown edit box -->                                                                                                                      ");
                    objCodigo.AppendLine("                        </div>                                                                                                                                                                ");
                    objCodigo.AppendLine("                        <!-- end widget edit box -->                                                                                                                                          ");
                    objCodigo.AppendLine("                        <!-- widget content -->                                                                                                                                               ");
                    objCodigo.AppendLine("                        <div class=\"widget-body no-padding\">                                                                                                                                ");
                    objCodigo.AppendLine("                            <form action=\"@Url.Action(\"edit\", \"" + tabelaFormatada + "\")\" method=\"POST\" class=\"smart-form\">                                                                  ");
                    objCodigo.AppendLine("                                <header>Alteração do cadastro " + tabelaFormatada + "</header>                                                                                                                 ");
                    objCodigo.AppendLine("                                @Html.AntiForgeryToken()                                                                                                                                      ");
                    objCodigo.AppendLine("                                <fieldset>                                                                                                                                                    ");
                    objCodigo.AppendLine("                                    @Html.ValidationBootstrap()                                                                                                                               ");
                    #endregion

                    #region Loop Colunas
                    // Abre conexão com o banco
                    objBanco = new Banco.Banco(_conexao);
                    // Cria o objeto da classe Library
                    objLib = new Library.Library();
                    // Faz a leitura de todas as colunas da tabela
                    objDr = objBanco.QueryConsulta("SELECT * FROM " + strTabela);
                    // Conta o número de colunas
                    nunrec = objDr.FieldCount;

                    for (int i = 0; i < nunrec; i++)
                    {
                        bool EforengKey = RetornaSeEForengKey(nomeTabela: strTabela, nomeColuna: objDr.GetName(i));
                        nomeCampoAtual = objDr.GetName(i);
                        if (i == 0)//pega o 1º
                        {
                            continue;
                        }
                        if (objDr.GetName(i).ToString().ToUpper() == "DATACADASTRO")//pega o DataCadastro
                        {
                            continue;
                        }
                        if (EforengKey)
                        {
                            objCodigo.AppendLine("                                        <section class=\"col col-3\" " + (i == 1 ? "autofocus" : "") + ">                                                                                                                                             ");
                            objCodigo.AppendLine("                                            @Html.LabelFor(m => Model." + objDr.GetName(i) + ", new { @class = \"label\" })                                                                   ");
                            objCodigo.AppendLine("                                            <label class=\"select\">                                                                                                                          ");
                            objCodigo.AppendLine("                                                <i class=\"icon-append fa fa-question-circle\"></i>                                                                                           ");
                            objCodigo.AppendLine("                                                @Html.DropDownList(\"" + objDr.GetName(i) + "\", null, @Html.DisplayNameFor(m => m." + objDr.GetName(i) + "))<i></i>");
                            objCodigo.AppendLine("                                            </label>                                                                                              ");
                            objCodigo.AppendLine("                                        </section>                                                                                                ");
                            continue;
                        }
                        if (objDr.GetDataTypeName(i) == "bit")
                        {
                            objCodigo.AppendLine("                                        <section class=\"col col-3\">                                                  ");
                            objCodigo.AppendLine("                                            @Html.LabelFor(m => Model." + objDr.GetName(i) + ", new { @class = \"label\" })                             ");
                            objCodigo.AppendLine("                                            @Html.CheckBoxFor(m => Model." + objDr.GetName(i) + ", new { @class = \"style-0\", @checked = \"checked\" })");
                            objCodigo.AppendLine("                                        </section>                                                                                   ");
                            continue;
                        }

                        objCodigo.AppendLine("                                    <section class=\"col col-3\" " + (i == 1 ? "autofocus" : "") + ">                                                                                                                                                 ");
                        objCodigo.AppendLine("                                        @Html.LabelFor(m => Model." + objDr.GetName(i) + ", new { @class = \"label\" })                                                                                      ");
                        objCodigo.AppendLine("                                        <label class=\"input\">                                                                                                                               ");
                        objCodigo.AppendLine("                                            <i class=\"icon-append fa fa-question-circle\"></i>                                                                                               ");
                        objCodigo.AppendLine("                                            @Html.TextBoxFor(m => Model." + objDr.GetName(i) + ", new { placeholder = @ClassesAdicionais.Utils.SubstituiAcentoHTML(@Html.DisplayNameFor(m => m." + objDr.GetName(i) + ").ToString())" + (i == 1 ? ", @autofocus = \"\"" : "") + " })                    ");
                        objCodigo.AppendLine("                                            <b class=\"tooltip tooltip-bottom-right\">                                                                                                        ");
                        objCodigo.AppendLine("                                                <i class=\"fa fa-warning txt-color-teal\"></i>                                                                                                ");
                        objCodigo.AppendLine("                                                Informe o @Html.DisplayNameFor(m => m." + objDr.GetName(i) + ")                                                                                                        ");
                        objCodigo.AppendLine("                                            </b>                                                                                                                                              ");
                        objCodigo.AppendLine("                                        </label>                                                                                                                                              ");
                        objCodigo.AppendLine("                                    </section>                                                                                                                                                ");
                        continue;
                    }

                    // fecha conexão
                    objBanco.CloseConn();
                    objLib = null;

                    #endregion

                    #region Depois das colunas
                    objCodigo.AppendLine("                                </fieldset>                                                                                                                                                   ");
                    objCodigo.AppendLine("                                <footer>                                                                                                                                                      ");
                    objCodigo.AppendLine("                                    <button type=\"submit\" class=\"btn btn-primary\">                                                                                                        ");
                    objCodigo.AppendLine("                                        Gravar                                                                                                                                                ");
                    objCodigo.AppendLine("                                    </button>                                                                                                                                                 ");
                    objCodigo.AppendLine("                                    <button type=\"button\" class=\"btn btn-default\" onclick=\"window.history.back();\">                                                                     ");
                    objCodigo.AppendLine("                                        Voltar                                                                                                                                                ");
                    objCodigo.AppendLine("                                    </button>                                                                                                                                                 ");
                    objCodigo.AppendLine("                                </footer>                                                                                                                                                     ");
                    objCodigo.AppendLine("                            </form>                                                                                                                                                           ");
                    objCodigo.AppendLine("                        </div>                                                                                                                                                                ");
                    objCodigo.AppendLine("                        <!-- end widget content -->                                                                                                                                           ");
                    objCodigo.AppendLine("                    </div>                                                                                                                                                                    ");
                    objCodigo.AppendLine("                    <!-- end widget div -->                                                                                                                                                   ");
                    objCodigo.AppendLine("                </div>                                                                                                                                                                        ");
                    objCodigo.AppendLine("                <!-- end widget -->                                                                                                                                                           ");
                    objCodigo.AppendLine("            </article>                                                                                                                                                                        ");
                    objCodigo.AppendLine("            <!-- END COL -->                                                                                                                                                                  ");
                    objCodigo.AppendLine("        </div>                                                                                                                                                                                ");
                    objCodigo.AppendLine("        <!-- END ROW-->                                                                                                                                                                       ");
                    objCodigo.AppendLine("    </section>                                                                                                                                                                                ");
                    objCodigo.AppendLine("    <!-- end widget grid -->                                                                                                                                                                  ");
                    objCodigo.AppendLine("                                                                                                                                                                                              ");
                    objCodigo.AppendLine("</div>                                                                                                                                                                                        ");
                    objCodigo.AppendLine("<!-- END MAIN CONTENT -->                                                                                                                                                                     ");
                    objCodigo.AppendLine("                                                                                                                                                                                              ");
                    objCodigo.AppendLine("");
                    #endregion
                }
                #endregion

                #region TipoViews Create
                if (tipoDeView == TipoDeViews.Create)
                {
                    #region Antes do Loop Colunas
                    objCodigo.AppendLine("@model DTO.Tab" + tabelaFormatada + "                                                                                                                                             ");
                    objCodigo.AppendLine("@{                                                                                                                                                                                            ");
                    objCodigo.AppendLine("    ViewBag.Title = \"Cadastro de " + tabelaFormatada + "\";                                                                                                                                  ");
                    objCodigo.AppendLine("    Layout = \"~/Views/Shared/_Layout.cshtml\";                                                                                                                                               ");
                    objCodigo.AppendLine("}                                                                                                                                                                                             ");
                    objCodigo.AppendLine("<!-- MAIN CONTENT -->                                                                                                                                                                         ");
                    objCodigo.AppendLine("<div id=\"content\">                                                                                                                                                                          ");
                    objCodigo.AppendLine("    <div class=\"row\">                                                                                                                                                                       ");
                    objCodigo.AppendLine("        <div class=\"col-sm-12 col-md-12 col-lg-12\">                                                                                                                                         ");
                    objCodigo.AppendLine("            <h1 class=\"page-title txt-color-blueDark\">                                                                                                                                      ");
                    objCodigo.AppendLine("                <i class=\"fa fa-edit fa-fw \"></i>                                                                                                                                           ");
                    objCodigo.AppendLine("                Cadastros <span> > Cadastro de " + tabelaFormatada + "</span>                                                                                                                       ");
                    objCodigo.AppendLine("            </h1>                                                                                                                                                                             ");
                    objCodigo.AppendLine("        </div>                                                                                                                                                                                ");
                    objCodigo.AppendLine("    </div>                                                                                                                                                                                    ");
                    objCodigo.AppendLine("    <!-- widget grid -->                                                                                                                                                                      ");
                    objCodigo.AppendLine("    <section id=\"widget-grid\" class=\"\">                                                                                                                                                   ");
                    objCodigo.AppendLine("        <!-- NEW ROW -->                                                                                                                                                                      ");
                    objCodigo.AppendLine("        <div class=\"row\">                                                                                                                                                                   ");
                    objCodigo.AppendLine("            <!-- NEW COL START -->                                                                                                                                                            ");
                    objCodigo.AppendLine("            <article class=\"col-sm-12 col-md-12 col-lg-12\">                                                                                                                                 ");
                    objCodigo.AppendLine("                <!-- Widget ID (each widget will need unique ID)-->                                                                                                                           ");
                    objCodigo.AppendLine("                <div class=\"jarviswidget jarviswidget-color-blueDark\" id=\"wid-id-3\" data-widget-colorbutton=\"false\" data-widget-editbutton=\"false\" data-widget-custombutton=\"false\">");
                    objCodigo.AppendLine("                    <header>                                                                                                                                                                  ");
                    objCodigo.AppendLine("                        <span class=\"widget-icon\"> <i class=\"fa fa-edit\"></i> </span>                                                                                                     ");
                    objCodigo.AppendLine("                        <h2>Formulário de cadastro</h2>                                                                                                                                       ");
                    objCodigo.AppendLine("                    </header>                                                                                                                                                                 ");
                    objCodigo.AppendLine("                    <!-- widget div-->                                                                                                                                                        ");
                    objCodigo.AppendLine("                    <div>                                                                                                                                                                     ");
                    objCodigo.AppendLine("                        <!-- widget edit box -->                                                                                                                                              ");
                    objCodigo.AppendLine("                        <div class=\"jarviswidget-editbox\">                                                                                                                                  ");
                    objCodigo.AppendLine("                            <!-- This area used as dropdown edit box -->                                                                                                                      ");
                    objCodigo.AppendLine("                        </div>                                                                                                                                                                ");
                    objCodigo.AppendLine("                        <!-- end widget edit box -->                                                                                                                                          ");
                    objCodigo.AppendLine("                        <!-- widget content -->                                                                                                                                               ");
                    objCodigo.AppendLine("                        <div class=\"widget-body no-padding\">                                                                                                                                ");
                    objCodigo.AppendLine("                            <form action=\"@Url.Action(\"create\", \"" + tabelaFormatada + "\")\" method=\"POST\" class=\"smart-form\">                                                                  ");
                    objCodigo.AppendLine("                                <header>Cadastro de " + tabelaFormatada + "</header>                                                                                                                 ");
                    objCodigo.AppendLine("                                @Html.AntiForgeryToken()                                                                                                                                      ");
                    objCodigo.AppendLine("                                <fieldset>                                                                                                                                                    ");
                    objCodigo.AppendLine("                                    @Html.ValidationBootstrap()                                                                                                                               ");
                    #endregion

                    #region Loop Colunas
                    // Abre conexão com o banco
                    objBanco = new Banco.Banco(_conexao);
                    // Cria o objeto da classe Library
                    objLib = new Library.Library();
                    // Faz a leitura de todas as colunas da tabela
                    objDr = objBanco.QueryConsulta("SELECT * FROM " + strTabela);
                    // Conta o número de colunas
                    nunrec = objDr.FieldCount;

                    for (int i = 0; i < nunrec; i++)
                    {
                        bool EforengKey = RetornaSeEForengKey(nomeTabela: strTabela, nomeColuna: objDr.GetName(i));
                        nomeCampoAtual = objDr.GetName(i);
                        if (i == 0)//pega o 1º
                        {
                            continue;
                        }
                        if (objDr.GetName(i).ToString().ToUpper() == "DATACADASTRO")//pega o DataCadastro
                        {
                            continue;
                        }
                        if (EforengKey)
                        {
                            objCodigo.AppendLine("                                        <section class=\"col col-3\" " + (i == 1 ? "autofocus" : "") + ">                                                                                                                                             ");
                            objCodigo.AppendLine("                                            @Html.LabelFor(m => Model." + objDr.GetName(i) + ", new { @class = \"label\" })                                                                   ");
                            objCodigo.AppendLine("                                            <label class=\"select\">                                                                                                                          ");
                            objCodigo.AppendLine("                                                <i class=\"icon-append fa fa-question-circle\"></i>                                                                                           ");
                            objCodigo.AppendLine("                                                @Html.DropDownList(\"" + objDr.GetName(i) + "\", null, @Html.DisplayNameFor(m => m." + objDr.GetName(i) + "))<i></i>");
                            objCodigo.AppendLine("                                            </label>                                                                                              ");
                            objCodigo.AppendLine("                                        </section>                                                                                                ");
                            continue;
                        }
                        if (objDr.GetDataTypeName(i) == "bit")
                        {
                            objCodigo.AppendLine("                                        <section class=\"col col-3\">                                                  ");
                            objCodigo.AppendLine("                                            @Html.LabelFor(m => Model." + objDr.GetName(i) + ", new { @class = \"label\" })                             ");
                            objCodigo.AppendLine("                                            @Html.CheckBoxFor(m => Model." + objDr.GetName(i) + ", new { @class = \"style-0\", @checked = \"checked\" })");
                            objCodigo.AppendLine("                                        </section>                                                                                   ");
                            continue;
                        }

                        objCodigo.AppendLine("                                    <section class=\"col col-3\" " + (i == 1 ? "autofocus" : "") + ">                                                                                                                                                 ");
                        objCodigo.AppendLine("                                        @Html.LabelFor(m => Model." + objDr.GetName(i) + ", new { @class = \"label\" })                                                                                      ");
                        objCodigo.AppendLine("                                        <label class=\"input\">                                                                                                                               ");
                        objCodigo.AppendLine("                                            <i class=\"icon-append fa fa-question-circle\"></i>                                                                                               ");
                        objCodigo.AppendLine("                                            @Html.TextBoxFor(m => Model." + objDr.GetName(i) + ", new { placeholder = @ClassesAdicionais.Utils.SubstituiAcentoHTML(@Html.DisplayNameFor(m => m." + objDr.GetName(i) + ").ToString())" + (i == 1 ? ", @autofocus = \"\"" : "") + " })                    ");
                        objCodigo.AppendLine("                                            <b class=\"tooltip tooltip-bottom-right\">                                                                                                        ");
                        objCodigo.AppendLine("                                                <i class=\"fa fa-warning txt-color-teal\"></i>                                                                                                ");
                        objCodigo.AppendLine("                                                Informe o @Html.DisplayNameFor(m => m." + objDr.GetName(i) + ")                                                                                                        ");
                        objCodigo.AppendLine("                                            </b>                                                                                                                                              ");
                        objCodigo.AppendLine("                                        </label>                                                                                                                                              ");
                        objCodigo.AppendLine("                                    </section>                                                                                                                                                ");
                        continue;
                    }

                    // fecha conexão
                    objBanco.CloseConn();
                    objLib = null;

                    #endregion

                    #region Depois das colunas
                    objCodigo.AppendLine("                                </fieldset>                                                                                                                                                   ");
                    objCodigo.AppendLine("                                <footer>                                                                                                                                                      ");
                    objCodigo.AppendLine("                                    <button type=\"submit\" class=\"btn btn-primary\">                                                                                                        ");
                    objCodigo.AppendLine("                                        Gravar                                                                                                                                                ");
                    objCodigo.AppendLine("                                    </button>                                                                                                                                                 ");
                    objCodigo.AppendLine("                                    <button type=\"button\" class=\"btn btn-default\" onclick=\"window.history.back();\">                                                                     ");
                    objCodigo.AppendLine("                                        Voltar                                                                                                                                                ");
                    objCodigo.AppendLine("                                    </button>                                                                                                                                                 ");
                    objCodigo.AppendLine("                                </footer>                                                                                                                                                     ");
                    objCodigo.AppendLine("                            </form>                                                                                                                                                           ");
                    objCodigo.AppendLine("                        </div>                                                                                                                                                                ");
                    objCodigo.AppendLine("                        <!-- end widget content -->                                                                                                                                           ");
                    objCodigo.AppendLine("                    </div>                                                                                                                                                                    ");
                    objCodigo.AppendLine("                    <!-- end widget div -->                                                                                                                                                   ");
                    objCodigo.AppendLine("                </div>                                                                                                                                                                        ");
                    objCodigo.AppendLine("                <!-- end widget -->                                                                                                                                                           ");
                    objCodigo.AppendLine("            </article>                                                                                                                                                                        ");
                    objCodigo.AppendLine("            <!-- END COL -->                                                                                                                                                                  ");
                    objCodigo.AppendLine("        </div>                                                                                                                                                                                ");
                    objCodigo.AppendLine("        <!-- END ROW-->                                                                                                                                                                       ");
                    objCodigo.AppendLine("    </section>                                                                                                                                                                                ");
                    objCodigo.AppendLine("    <!-- end widget grid -->                                                                                                                                                                  ");
                    objCodigo.AppendLine("                                                                                                                                                                                              ");
                    objCodigo.AppendLine("</div>                                                                                                                                                                                        ");
                    objCodigo.AppendLine("<!-- END MAIN CONTENT -->                                                                                                                                                                     ");
                    objCodigo.AppendLine("                                                                                                                                                                                              ");
                    objCodigo.AppendLine("");
                    #endregion
                }
                #endregion
            }
            #endregion

            #region ModeloViews Modelo 2
            if (modeloDeViews == ModeloDeViews.Modelo2)
            {

            }
            #endregion


            return objCodigo;
        }

        private bool RetornaSeEForengKey(string nomeTabela, string nomeColuna)
        {
            string sql = string.Format(@"
            IF(EXISTS(
            SELECT  
                1
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
            WHERE KCU1.TABLE_NAME = '{0}' AND KCU1.COLUMN_NAME = '{1}'
            ))
            SELECT 1
            ELSE SELECT 0
            ", nomeTabela, nomeColuna);

            bool retorno = Convert.ToBoolean(objBanco.RetornaValor(sql, new System.Collections.ArrayList() { }, new System.Collections.ArrayList { }));
            return retorno;
        }
    }
}
