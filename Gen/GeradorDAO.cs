using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Gen
{
    public partial class GeradorDAO : Form
    {
        public GeradorDO.GeradorDAL objGeradorDO = null;
        public GeradorDTO.GeradorDTO objGeradorVO = null;
        public GeradorBLL.GeradorBLL objGeradorBO = null;
        public SqlDataReader dr = null;
        public StringBuilder strConnstring = null;
        public string arrTabela = null;
        public Banco.Banco objBanco = null;

        public GeradorDAO()
        {
            InitializeComponent();
        }

        private void GeradorDAO_Load(object sender, EventArgs e)
        {
            btnLerBanco_Click(null, null);
            lstTabelas.SelectedIndex = 0;
        }

        private void btnLerBanco_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstTabelas.Items.Count; i++)
            {
                lstTabelas.Items.RemoveAt(i);
            }

            if ((txtServidor.Text.Trim() != "") || (txtBanco.Text.Trim() != ""))
            {

                // Monta a string de conexão
                //Data Source=ELNBSBSRV12;Initial Catalog=Eletronorte;User ID=elnweb; Password=elnweb;
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
                        dr = objBanco.QueryConsulta("SELECT * FROM SYSOBJECTS WHERE TYPE = 'U' ORDER BY NAME");
                        while (dr.Read())
                        {
                            lstTabelas.Items.Add(dr["NAME"].ToString());
                        }
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

        private void ckAutentica_Click(object sender, EventArgs e)
        {
            if (ckAutentica.Checked == true)
            {
                txtSenha.Enabled = false;
                txtUsuario.Enabled = false;
            }
            else
            {
                txtSenha.Enabled = true;
                txtUsuario.Enabled = true;
            }
        }

        // Gera a classe DO
        private void btnGerarDO_Click(object sender, EventArgs e)
        {
            if (ChecaLeitura())
            {
                if (txtBanco.Text.Trim() != "")
                {
                    objGeradorDO = new GeradorDO.GeradorDAL();
                    txtCodigo.Text = objGeradorDO.GeraCodigoDAL(txtBanco.Text.Trim(), strConnstring.ToString()).ToString();
                }
                else
                {
                    MessageBox.Show("Informe o nome do banco.");
                }
            }

        }

        // Gera as classes VO
        private void btnGerarVO_Click(object sender, EventArgs e)
        {
            if (ChecaLeitura())
            {
                if (lstTabelas.SelectedItems.Count != 0)
                {
                    arrTabela = "";

                    for (int i = 0; i < lstTabelas.SelectedItems.Count; i++)
                    {
                        arrTabela = lstTabelas.SelectedItems[i].ToString();
                    }

                    objGeradorVO = new GeradorDTO.GeradorDTO();
                    txtCodigo.Text = objGeradorVO.GeraCodigoDto(arrTabela, strConnstring.ToString(), txtBanco.Text.Trim()).ToString();

                }
                else
                {
                    MessageBox.Show("Selecione pelo menos uma tabela.");
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

        private void btnGerarBO_Click(object sender, EventArgs e)
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
                        txtCodigo.Text = objGeradorBO.GeraCodigoBLL(arrTabela, strConnstring.ToString(), txtBanco.Text.Trim()).ToString();
                    }

                }
                else
                {
                    MessageBox.Show("Selecione pelo menos uma tabela.");
                }
            }

        }

        private void BtnSelecionarTudo_Click(object sender, EventArgs e)
        {
            txtCodigo.Focus();
            txtCodigo.SelectAll();
        }



    }
}