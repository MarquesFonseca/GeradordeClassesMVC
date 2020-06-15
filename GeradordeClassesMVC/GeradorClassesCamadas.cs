using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Collections;
using System.Linq;
using GeradorClasses;
using GeradorView;

namespace Gen
{
    public partial class GeradorClassesCamadas : Form
    {
        public GeradorDO.GeradorDAL objGeradorDO = null;
        public GeradorDTO.GeradorDTO objGeradorVO = null;
        public GeradorBLL.GeradorBLL objGeradorBO = null;
        public GeradorController.GeradorController objGeradorController = null;
        public GeradorView.GeradorView objGeradorView = null;
        public SqlDataReader dr = null;
        public StringBuilder strConnstring = null;
        public string arrTabela = null;
        public Banco.Banco objBanco = null;

        public BindingSource _bindingsourceMapeamento = new BindingSource();
        private BindingSource _bindingsourceTabelas;
        private string classeSelecionada = string.Empty;
        private List<string> listaTabelasGeral = new List<string>();
        //private int indiceListaSelecionada = 0;
        //indice da linha, Valor do campo TabelaChaveEstrangeira
        //private Dictionary<int, string> campoTabelaChaveEstrangeira;

        public GeradorClassesCamadas()
        {
            InitializeComponent();
        }

        private void GeradorClassesCamadas_Load(object sender, EventArgs e)
        {
            dataGridViewMapeamento.DataSource = _bindingsourceMapeamento;
            lstTabelas.DataSource = _bindingsourceTabelas;
            LblMensagemTabela.Text = "&Tabelas - Qtd.: " + lstTabelas.Items.Count.ToString();

            RetornaConfig();

            btnLerBanco_Click(null, null);
        }

        private void ListaTabelas()
        {
            //for (int i = 0; i < lstTabelas.Items.Count; i++)
            //{
            //    lstTabelas.Items.RemoveAt();
            //}
            //lstTabelas.Items.Clear();
            listaTabelasGeral = new List<string>();
            _bindingsourceTabelas = new BindingSource();

            if ((txtServidor.Text.Trim() != "") || (txtBanco.Text.Trim() != ""))
            {
                // Monta a string de conexão
                strConnstring = new StringBuilder();
                strConnstring.Append("Data Source=" + txtServidor.Text.Replace("'", "") + ";");
                strConnstring.Append("Initial Catalog=" + txtBanco.Text.Replace("'", "") + ";");

                if ((ckAutentica.Checked == false) && (txtUsuario.Text.Trim() != ""))
                {
                    strConnstring.Append("User ID=" + txtUsuario.Text.Replace("'", "") + ";");
                    strConnstring.Append("Password=" + txtSenha.Text.Replace("'", "") + ";");
                }
                else
                {
                    // Usar autenticação segura
                    strConnstring.Append("Integrated Security=True;");
                }

                // Conecta com o banco
                try
                {
                    objBanco = new Banco.Banco(strConnstring.ToString());

                    try
                    {
                        // Ler as tabelas                        
                        dr = objBanco.QueryConsulta("SELECT NAME, TYPE FROM SYSOBJECTS WHERE (TYPE = 'U' OR TYPE = 'V') AND name <> 'sysdiagrams' ORDER BY NAME");
                        while (dr.Read())
                        {
                            lstTabelas.Items.Add(dr["NAME"].ToString());
                            listaTabelasGeral.Add(dr["NAME"].ToString());
                        }
                        // Ler as tabelas
                        //listaTabelasGeral = tabelas.AsEnumerable().Select(M => M[0].ToString()).ToList();
                        _bindingsourceTabelas.DataSource = listaTabelasGeral;
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Erro ao ler o banco de dados.");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro encontrado.");
                    }
                }
                catch (SqlException sqlerr)
                {
                    MessageBox.Show(sqlerr.ToString());
                }
                finally
                {
                    lblConnstring.Text = strConnstring.ToString();
                }
            }
            else
            {
                MessageBox.Show("Informe a string de conexão com o banco.");
            }
        }

        private void btnLerBanco_Click(object sender, EventArgs e)
        {
            btnLerBanco.Enabled = false;
            ListaTabelas();
            txtPesquisarTabelas.Focus();
            if (lstTabelas.Items.Count > 0)
                //lstTabelas.SelectedIndex = 0;
                GravaConfiguracoes();
            btnLerBanco.Enabled = true;




            // Faz a leitura de todas as colunas com seus atributos
            //_bindingsourceMapeamento.DataSource = ExecutorSql.ExecultarSelect_GerarMapeamento(lstTabelas.SelectedItem.ToString());
            //classeSelecionada = lstTabelas.SelectedItem.ToString();
            //campoTabelaChaveEstrangeira = new Dictionary<int, string>();
            //dataGridViewMapeamento.Columns[1].Frozen = true;

            //LblMensagemTabela.Text = "&Propriedades da tabela: " + classeSelecionada;
        }

        private void RetornaConfig()
        {
            #region Aba Conexao
            txtServidor.Text = Arquivos.Registro.Registro.LerRegistro(Arquivos.Registro.Registro.RaizRegistro.HKEY_CURRENT_CONFIG, "Software\\TinsWeb\\GeradorClasses", "txtServidor");
            txtBanco.Text = Arquivos.Registro.Registro.LerRegistro(Arquivos.Registro.Registro.RaizRegistro.HKEY_CURRENT_CONFIG, "Software\\TinsWeb\\GeradorClasses", "txtBanco");
            txtUsuario.Text = Arquivos.Registro.Registro.LerRegistro(Arquivos.Registro.Registro.RaizRegistro.HKEY_CURRENT_CONFIG, "Software\\TinsWeb\\GeradorClasses", "txtUsuario");
            txtSenha.Text = Arquivos.Registro.Registro.LerRegistro(Arquivos.Registro.Registro.RaizRegistro.HKEY_CURRENT_CONFIG, "Software\\TinsWeb\\GeradorClasses", "txtSenha");
            string ckAutenticaRetornado = Arquivos.Registro.Registro.LerRegistro(Arquivos.Registro.Registro.RaizRegistro.HKEY_CURRENT_CONFIG, "Software\\TinsWeb\\GeradorClasses", "ckAutentica");
            if (ckAutenticaRetornado == "" || ckAutenticaRetornado == "0")
                ckAutentica.Checked = false;
            if (ckAutenticaRetornado == "1")
                ckAutentica.Checked = true;
            #endregion

            #region Aba DAL
            TxtDiretorioDal.Text = Arquivos.Registro.Registro.LerRegistro(Arquivos.Registro.Registro.RaizRegistro.HKEY_CURRENT_CONFIG, "Software\\TinsWeb\\GeradorClasses", "TxtDiretorioDal");
            #endregion

            #region Aba DTO
            TxtDiretorioDto.Text = Arquivos.Registro.Registro.LerRegistro(Arquivos.Registro.Registro.RaizRegistro.HKEY_CURRENT_CONFIG, "Software\\TinsWeb\\GeradorClasses", "TxtDiretorioDto");
            #endregion

            #region Aba BLL
            TxtDiretorioBll.Text = Arquivos.Registro.Registro.LerRegistro(Arquivos.Registro.Registro.RaizRegistro.HKEY_CURRENT_CONFIG, "Software\\TinsWeb\\GeradorClasses", "TxtDiretorioBll");
            #endregion

            #region Aba View
            TxtDiretorioView.Text = Arquivos.Registro.Registro.LerRegistro(Arquivos.Registro.Registro.RaizRegistro.HKEY_CURRENT_CONFIG, "Software\\TinsWeb\\GeradorClasses", "TxtDiretorioView");
            #endregion

            #region Aba Controller
            TxtDiretorioControlller.Text = Arquivos.Registro.Registro.LerRegistro(Arquivos.Registro.Registro.RaizRegistro.HKEY_CURRENT_CONFIG, "Software\\TinsWeb\\GeradorClasses", "TxtDiretorioControlller");
            TxtNameSpaceProjeto.Text = Arquivos.Registro.Registro.LerRegistro(Arquivos.Registro.Registro.RaizRegistro.HKEY_CURRENT_CONFIG, "Software\\TinsWeb\\GeradorClasses", "TxtNameSpaceProjeto");
            #endregion
        }

        private void GravaConfiguracoes()
        {
            //Grava o diretorio para gerar as classes.
            #region Aba Conexao

            //Arquivos.Registro.Registro.LerRegistro(Arquivos.Registro.Registro.RaizRegistro.HKEY_CURRENT_CONFIG, "Software\\TinsWeb\\GeradorClasses", "
            //Arquivos.Registro.Registro.CriarChaveRegedit(Arquivos.Registro.Registro.RaizRegistro.HKEY_CURRENT_CONFIG, "Software\\TinsWeb\\GeradorClasses", "txtServidor", "");
            Arquivos.Registro.Registro.CriarChaveRegedit(Arquivos.Registro.Registro.RaizRegistro.HKEY_CURRENT_CONFIG, "Software\\TinsWeb\\GeradorClasses", "txtServidor", txtServidor.Text);
            Arquivos.Registro.Registro.CriarChaveRegedit(Arquivos.Registro.Registro.RaizRegistro.HKEY_CURRENT_CONFIG, "Software\\TinsWeb\\GeradorClasses", "txtBanco", txtBanco.Text);
            Arquivos.Registro.Registro.CriarChaveRegedit(Arquivos.Registro.Registro.RaizRegistro.HKEY_CURRENT_CONFIG, "Software\\TinsWeb\\GeradorClasses", "txtUsuario", txtUsuario.Text);
            Arquivos.Registro.Registro.CriarChaveRegedit(Arquivos.Registro.Registro.RaizRegistro.HKEY_CURRENT_CONFIG, "Software\\TinsWeb\\GeradorClasses", "txtSenha", txtSenha.Text);
            if (ckAutentica.Checked == false)
                Arquivos.Registro.Registro.CriarChaveRegedit(Arquivos.Registro.Registro.RaizRegistro.HKEY_CURRENT_CONFIG, "Software\\TinsWeb\\GeradorClasses", "ckAutentica", "0");
            if (ckAutentica.Checked == true)
                Arquivos.Registro.Registro.CriarChaveRegedit(Arquivos.Registro.Registro.RaizRegistro.HKEY_CURRENT_CONFIG, "Software\\TinsWeb\\GeradorClasses", "ckAutentica", "1");
            #endregion

            #region Aba DAL
            Arquivos.Registro.Registro.CriarChaveRegedit(Arquivos.Registro.Registro.RaizRegistro.HKEY_CURRENT_CONFIG, "Software\\TinsWeb\\GeradorClasses", "TxtDiretorioDal", TxtDiretorioDal.Text);
            #endregion

            #region Aba DTO
            Arquivos.Registro.Registro.CriarChaveRegedit(Arquivos.Registro.Registro.RaizRegistro.HKEY_CURRENT_CONFIG, "Software\\TinsWeb\\GeradorClasses", "TxtDiretorioDto", TxtDiretorioDto.Text);
            #endregion

            #region Aba BLL
            Arquivos.Registro.Registro.CriarChaveRegedit(Arquivos.Registro.Registro.RaizRegistro.HKEY_CURRENT_CONFIG, "Software\\TinsWeb\\GeradorClasses", "TxtDiretorioBll", TxtDiretorioBll.Text);
            #endregion

            #region Aba View
            Arquivos.Registro.Registro.CriarChaveRegedit(Arquivos.Registro.Registro.RaizRegistro.HKEY_CURRENT_CONFIG, "Software\\TinsWeb\\GeradorClasses", "TxtDiretorioView", TxtDiretorioView.Text);
            #endregion

            #region Aba Controller
            Arquivos.Registro.Registro.CriarChaveRegedit(Arquivos.Registro.Registro.RaizRegistro.HKEY_CURRENT_CONFIG, "Software\\TinsWeb\\GeradorClasses", "TxtDiretorioControlller", TxtDiretorioControlller.Text);
            Arquivos.Registro.Registro.CriarChaveRegedit(Arquivos.Registro.Registro.RaizRegistro.HKEY_CURRENT_CONFIG, "Software\\TinsWeb\\GeradorClasses", "TxtNameSpaceProjeto", TxtNameSpaceProjeto.Text);
            #endregion
        }

        private void txtPesquisarTabelas_TextChanged(object sender, EventArgs e)
        {
            if (listaTabelasGeral.Count > 0)
            {
                if (string.IsNullOrEmpty(txtPesquisarTabelas.Text))
                {
                    lstTabelas.DataSource = listaTabelasGeral;
                    lstTabelas.Update();
                    lstTabelas.Refresh();

                    LblMensagemTabela.Text = "&Tabelas - Qtd.: " + lstTabelas.Items.Count.ToString();
                }
                else
                {
                    List<string> novaLista = listaTabelasGeral.Cast<string>().Where(M => M.ToString().ToUpper().Contains(txtPesquisarTabelas.Text.ToUpper())).ToList();
                    BindingList<string> filtro = new BindingList<string>(novaLista);

                    lstTabelas.DataSource = filtro;
                    lstTabelas.Update();
                    lstTabelas.Refresh();

                    LblMensagemTabela.Text = string.Format("&Filtro: %{0}%, Qtd.: {1}", txtPesquisarTabelas.Text, lstTabelas.Items.Count);
                }
            }
        }

        private bool ChecaLeitura()
        {
            if (strConnstring == null)
            {
                MessageBox.Show("Faça a leitura do banco.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnConfiguracoesDal_Click(object sender, EventArgs e)
        {
            if (ChecaLeitura())
            {
                if (txtBanco.Text.Trim() != "")
                {
                    objGeradorDO = new GeradorDO.GeradorDAL();
                    string classeGerada = objGeradorDO.GeraCodigoDAL(txtBanco.Text.Trim(), strConnstring.ToString()).ToString();
                    GeradorClasses.Arquivos.CriarArquivo(TxtDiretorioDal.Text, "Dao", "cs", classeGerada);
                    GravaConfiguracoes();
                    MessageBox.Show("Classe DAL gerada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Informe o nome do banco.");
                }
            }
        }

        private void btnConfiguracoesDto_Click(object sender, EventArgs e)
        {
            if (ChecaLeitura())
            {
                if (lstTabelas.SelectedItems.Count != 0)
                {
                    arrTabela = "";

                    for (int i = 0; i < lstTabelas.SelectedItems.Count; i++)
                    {
                        arrTabela = lstTabelas.SelectedItems[i].ToString();

                        objGeradorVO = new GeradorDTO.GeradorDTO();
                        string classeGerada = objGeradorVO.GeraCodigoDto(arrTabela, strConnstring.ToString(), txtBanco.Text.Trim()).ToString();
                        string tabelaFormatada = "Tab" + arrTabela.Replace("_", "").Replace("-", "");
                        GeradorClasses.Arquivos.CriarArquivo(TxtDiretorioDto.Text, tabelaFormatada, "cs", classeGerada);
                    }

                    GravaConfiguracoes();
                    MessageBox.Show("Classe DTO gerada com sucesso!\nTotal geradas: " + lstTabelas.SelectedItems.Count.ToString());
                }
                else
                {
                    MessageBox.Show("Selecione pelo menos uma tabela.");
                }
            }
        }

        private void btnConfiguracoesBll_Click(object sender, EventArgs e)
        {
            if (ChecaLeitura())
            {
                if (lstTabelas.SelectedItems.Count != 0)
                {
                    arrTabela = "";

                    for (int i = 0; i < lstTabelas.SelectedItems.Count; i++)
                    {
                        arrTabela = lstTabelas.SelectedItems[i].ToString();
                        objGeradorBO = new GeradorBLL.GeradorBLL();
                        string classeGerada = objGeradorBO.GeraCodigoBLL(arrTabela, strConnstring.ToString(), txtBanco.Text.Trim(), chkAtualizarCampoDataCadastro.Checked).ToString();
                        string tabelaFormatada = arrTabela.Replace("_", "").Replace("-", "") + "BO";
                        GeradorClasses.Arquivos.CriarArquivo(TxtDiretorioBll.Text, tabelaFormatada, "cs", classeGerada);
                    }

                    GravaConfiguracoes();
                    MessageBox.Show("Classe BLL gerada com sucesso!\nTotal geradas: " + lstTabelas.SelectedItems.Count.ToString());
                }
                else
                {
                    MessageBox.Show("Selecione pelo menos uma tabela.");
                }
            }
        }

        private void BtnConfiguracoesController_Click(object sender, EventArgs e)
        {
            if (ChecaLeitura())
            {
                if (lstTabelas.SelectedItems.Count != 0)
                {
                    arrTabela = "";

                    for (int i = 0; i < lstTabelas.SelectedItems.Count; i++)
                    {
                        arrTabela = lstTabelas.SelectedItems[i].ToString();
                        objGeradorController = new GeradorController.GeradorController();
                        string classeGerada = objGeradorController.GeraCodigoController(TxtNameSpaceProjeto.Text, arrTabela, strConnstring.ToString(), txtBanco.Text.Trim()).ToString();
                        string tabelaFormatada = string.Format("{0}Controller", arrTabela.Replace("_", "").Replace("-", ""));
                        GeradorClasses.Arquivos.CriarArquivo(TxtDiretorioControlller.Text, tabelaFormatada, "cs", classeGerada);
                    }

                    GravaConfiguracoes();
                    MessageBox.Show("Classe Controller gerada com sucesso!\nTotal geradas: " + lstTabelas.SelectedItems.Count.ToString());
                }
                else
                {
                    MessageBox.Show("Selecione pelo menos uma tabela.");
                }
            }
        }

        private void radioButtonConfiguracaoViewModelo1_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxGerarViewModelo1List.Checked =
            checkBoxGerarViewModelo1Details.Checked =
            checkBoxGerarViewModelo1Edit.Checked =
            checkBoxGerarViewModelo1Create.Checked = radioButtonConfiguracaoViewModelo1.Checked;
        }

        private void btnConfiguracoesViews_Click(object sender, EventArgs e)
        {
            if (ChecaLeitura())
            {
                if (lstTabelas.SelectedItems.Count != 0)
                {
                    arrTabela = "";
                    int count = 0;
                    for (int i = 0; i < lstTabelas.SelectedItems.Count; i++)
                    {
                        arrTabela = lstTabelas.SelectedItems[i].ToString();
                        string diretorioAtualView = RetornaCaminhoCompleto(TxtDiretorioView.Text, arrTabela);


                        objGeradorView = new GeradorView.GeradorView();

                        if (checkBoxGerarViewModelo1List.Checked)
                        {
                            string classeGerada = objGeradorView.GeraCodigoView(TipoDeViews.List, ModeloDeViews.Modelo1, arrTabela, strConnstring.ToString(), txtBanco.Text.Trim()).ToString();
                            GeradorClasses.Arquivos.CriarArquivo(diretorioAtualView, "Index", "cshtml", classeGerada);
                            count++;
                        }
                        if (checkBoxGerarViewModelo1Details.Checked)
                        {
                            string classeGerada = objGeradorView.GeraCodigoView(TipoDeViews.Details, ModeloDeViews.Modelo1, arrTabela, strConnstring.ToString(), txtBanco.Text.Trim()).ToString();
                            GeradorClasses.Arquivos.CriarArquivo(diretorioAtualView, "Details", "cshtml", classeGerada);
                            count++;
                        }
                        if (checkBoxGerarViewModelo1Edit.Checked)
                        {
                            string classeGerada = objGeradorView.GeraCodigoView(TipoDeViews.Edit, ModeloDeViews.Modelo1, arrTabela, strConnstring.ToString(), txtBanco.Text.Trim()).ToString();
                            GeradorClasses.Arquivos.CriarArquivo(diretorioAtualView, "Edit", "cshtml", classeGerada);
                            count++;
                        }
                        if (checkBoxGerarViewModelo1Create.Checked)
                        {
                            string classeGerada = objGeradorView.GeraCodigoView(TipoDeViews.Create, ModeloDeViews.Modelo1, arrTabela, strConnstring.ToString(), txtBanco.Text.Trim()).ToString();
                            GeradorClasses.Arquivos.CriarArquivo(diretorioAtualView, "Create", "cshtml", classeGerada);
                            count++;
                        }
                    }

                    GravaConfiguracoes();
                    MessageBox.Show("Classes Views geradas com sucesso!\nTotal geradas: " + count.ToString());
                }
                else
                {
                    MessageBox.Show("Selecione pelo menos uma tabela.");
                }
            }
        }

        private string RetornaCaminhoCompleto(string dirViews, string tabela)
        {
            string retorno = "";

            if (!dirViews.Substring(dirViews.Length - 1, 0).Contains("\\"))
                dirViews = dirViews + "\\";

            if (!GeradorClasses.Arquivos.Existe(dirViews, true))
                GeradorClasses.Arquivos.CriarDiretorio(dirViews);

            retorno = string.Format("{0}{1}", dirViews, tabela);

            return retorno;
        }

        private void lstTabelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selecionado = lstTabelas.SelectedItem;
        }

        private void lstTabelas_Click(object sender, EventArgs e)
        {
            object selecionado = lstTabelas.SelectedItem;
        }
    }
}
