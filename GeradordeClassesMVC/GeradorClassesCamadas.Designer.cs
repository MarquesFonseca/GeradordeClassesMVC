namespace GeradorClasseMVC
{
    partial class GeradorClassesCamadas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageConfiguracoesConexao = new System.Windows.Forms.TabPage();
            this.lblConnstring = new System.Windows.Forms.Label();
            this.ckAutentica = new System.Windows.Forms.CheckBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.lblBanco = new System.Windows.Forms.Label();
            this.btnLerBanco = new System.Windows.Forms.Button();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.lblServidor = new System.Windows.Forms.Label();
            this.tabPageConfiguracoesClasseDal = new System.Windows.Forms.TabPage();
            this.btnConfiguracoesDal = new System.Windows.Forms.Button();
            this.TxtDiretorioDal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageConfiguracoesClasseDTO = new System.Windows.Forms.TabPage();
            this.btnConfiguracoesDto = new System.Windows.Forms.Button();
            this.TxtDiretorioDto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageConfiguracoesClasseBLL = new System.Windows.Forms.TabPage();
            this.chkAtualizarCampoDataCadastro = new System.Windows.Forms.CheckBox();
            this.btnConfiguracoesBll = new System.Windows.Forms.Button();
            this.TxtDiretorioBll = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPageConfiguracoesView = new System.Windows.Forms.TabPage();
            this.btnConfiguracoesViews = new System.Windows.Forms.Button();
            this.TxtDiretorioView = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButtonConfiguracaoViewModelo2 = new System.Windows.Forms.RadioButton();
            this.radioButtonConfiguracaoViewModelo1 = new System.Windows.Forms.RadioButton();
            this.radioButtonConfiguracaoViewModelo3 = new System.Windows.Forms.RadioButton();
            this.checkBoxGerarViewModelo1List = new System.Windows.Forms.CheckBox();
            this.checkBoxGerarViewModelo3Create = new System.Windows.Forms.CheckBox();
            this.checkBoxGerarViewModelo2List = new System.Windows.Forms.CheckBox();
            this.checkBoxGerarViewModelo2Create = new System.Windows.Forms.CheckBox();
            this.checkBoxGerarViewModelo3List = new System.Windows.Forms.CheckBox();
            this.checkBoxGerarViewModelo1Create = new System.Windows.Forms.CheckBox();
            this.checkBoxGerarViewModelo1Details = new System.Windows.Forms.CheckBox();
            this.checkBoxGerarViewModelo3Edit = new System.Windows.Forms.CheckBox();
            this.checkBoxGerarViewModelo2Details = new System.Windows.Forms.CheckBox();
            this.checkBoxGerarViewModelo2Edit = new System.Windows.Forms.CheckBox();
            this.checkBoxGerarViewModelo3Details = new System.Windows.Forms.CheckBox();
            this.checkBoxGerarViewModelo1Edit = new System.Windows.Forms.CheckBox();
            this.tabPageConfiguracoesController = new System.Windows.Forms.TabPage();
            this.BtnConfiguracoesController = new System.Windows.Forms.Button();
            this.TxtNameSpaceProjeto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtDiretorioControlller = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstTabelas = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblMensagemTabela = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPesquisarTabelas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewMapeamento = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageConfiguracoesConexao.SuspendLayout();
            this.tabPageConfiguracoesClasseDal.SuspendLayout();
            this.tabPageConfiguracoesClasseDTO.SuspendLayout();
            this.tabPageConfiguracoesClasseBLL.SuspendLayout();
            this.tabPageConfiguracoesView.SuspendLayout();
            this.tabPageConfiguracoesController.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMapeamento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(855, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerador de classes camadas AspNet MVC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 327);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 162);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageConfiguracoesConexao);
            this.tabControl1.Controls.Add(this.tabPageConfiguracoesClasseDal);
            this.tabControl1.Controls.Add(this.tabPageConfiguracoesClasseDTO);
            this.tabControl1.Controls.Add(this.tabPageConfiguracoesClasseBLL);
            this.tabControl1.Controls.Add(this.tabPageConfiguracoesView);
            this.tabControl1.Controls.Add(this.tabPageConfiguracoesController);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(855, 162);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageConfiguracoesConexao
            // 
            this.tabPageConfiguracoesConexao.Controls.Add(this.lblConnstring);
            this.tabPageConfiguracoesConexao.Controls.Add(this.ckAutentica);
            this.tabPageConfiguracoesConexao.Controls.Add(this.txtSenha);
            this.tabPageConfiguracoesConexao.Controls.Add(this.label2);
            this.tabPageConfiguracoesConexao.Controls.Add(this.txtUsuario);
            this.tabPageConfiguracoesConexao.Controls.Add(this.lblUsuario);
            this.tabPageConfiguracoesConexao.Controls.Add(this.txtBanco);
            this.tabPageConfiguracoesConexao.Controls.Add(this.lblBanco);
            this.tabPageConfiguracoesConexao.Controls.Add(this.btnLerBanco);
            this.tabPageConfiguracoesConexao.Controls.Add(this.txtServidor);
            this.tabPageConfiguracoesConexao.Controls.Add(this.lblServidor);
            this.tabPageConfiguracoesConexao.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfiguracoesConexao.Name = "tabPageConfiguracoesConexao";
            this.tabPageConfiguracoesConexao.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfiguracoesConexao.Size = new System.Drawing.Size(847, 136);
            this.tabPageConfiguracoesConexao.TabIndex = 0;
            this.tabPageConfiguracoesConexao.Text = "Configuração de conexão";
            this.tabPageConfiguracoesConexao.UseVisualStyleBackColor = true;
            // 
            // lblConnstring
            // 
            this.lblConnstring.AutoSize = true;
            this.lblConnstring.Location = new System.Drawing.Point(3, 64);
            this.lblConnstring.Name = "lblConnstring";
            this.lblConnstring.Size = new System.Drawing.Size(103, 13);
            this.lblConnstring.TabIndex = 22;
            this.lblConnstring.Text = "String de Conexão:  ";
            // 
            // ckAutentica
            // 
            this.ckAutentica.AutoSize = true;
            this.ckAutentica.Location = new System.Drawing.Point(5, 44);
            this.ckAutentica.Name = "ckAutentica";
            this.ckAutentica.Size = new System.Drawing.Size(161, 17);
            this.ckAutentica.TabIndex = 15;
            this.ckAutentica.Text = "Usar Autenticação Windows";
            this.ckAutentica.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(495, 18);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(150, 20);
            this.txtSenha.TabIndex = 18;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Senha";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(339, 18);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(150, 20);
            this.txtUsuario.TabIndex = 17;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(336, 4);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 20;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(178, 19);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(152, 20);
            this.txtBanco.TabIndex = 14;
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(175, 4);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(38, 13);
            this.lblBanco.TabIndex = 16;
            this.lblBanco.Text = "Banco";
            // 
            // btnLerBanco
            // 
            this.btnLerBanco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLerBanco.Location = new System.Drawing.Point(688, 85);
            this.btnLerBanco.Name = "btnLerBanco";
            this.btnLerBanco.Size = new System.Drawing.Size(153, 46);
            this.btnLerBanco.TabIndex = 19;
            this.btnLerBanco.Text = "Ler Banco";
            this.btnLerBanco.UseVisualStyleBackColor = true;
            this.btnLerBanco.Click += new System.EventHandler(this.btnLerBanco_Click);
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(5, 18);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(164, 20);
            this.txtServidor.TabIndex = 12;
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(3, 4);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(46, 13);
            this.lblServidor.TabIndex = 13;
            this.lblServidor.Text = "Servidor";
            // 
            // tabPageConfiguracoesClasseDal
            // 
            this.tabPageConfiguracoesClasseDal.Controls.Add(this.btnConfiguracoesDal);
            this.tabPageConfiguracoesClasseDal.Controls.Add(this.TxtDiretorioDal);
            this.tabPageConfiguracoesClasseDal.Controls.Add(this.label4);
            this.tabPageConfiguracoesClasseDal.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfiguracoesClasseDal.Name = "tabPageConfiguracoesClasseDal";
            this.tabPageConfiguracoesClasseDal.Size = new System.Drawing.Size(847, 136);
            this.tabPageConfiguracoesClasseDal.TabIndex = 3;
            this.tabPageConfiguracoesClasseDal.Text = "Configurações classe DAL";
            this.tabPageConfiguracoesClasseDal.UseVisualStyleBackColor = true;
            // 
            // btnConfiguracoesDal
            // 
            this.btnConfiguracoesDal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfiguracoesDal.Location = new System.Drawing.Point(583, 86);
            this.btnConfiguracoesDal.Name = "btnConfiguracoesDal";
            this.btnConfiguracoesDal.Size = new System.Drawing.Size(153, 46);
            this.btnConfiguracoesDal.TabIndex = 22;
            this.btnConfiguracoesDal.Text = "Gerar Classe DAL";
            this.btnConfiguracoesDal.UseVisualStyleBackColor = true;
            this.btnConfiguracoesDal.Click += new System.EventHandler(this.btnConfiguracoesDal_Click);
            // 
            // TxtDiretorioDal
            // 
            this.TxtDiretorioDal.Location = new System.Drawing.Point(7, 21);
            this.TxtDiretorioDal.Name = "TxtDiretorioDal";
            this.TxtDiretorioDal.Size = new System.Drawing.Size(725, 20);
            this.TxtDiretorioDal.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Informe o destino";
            // 
            // tabPageConfiguracoesClasseDTO
            // 
            this.tabPageConfiguracoesClasseDTO.Controls.Add(this.btnConfiguracoesDto);
            this.tabPageConfiguracoesClasseDTO.Controls.Add(this.TxtDiretorioDto);
            this.tabPageConfiguracoesClasseDTO.Controls.Add(this.label5);
            this.tabPageConfiguracoesClasseDTO.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfiguracoesClasseDTO.Name = "tabPageConfiguracoesClasseDTO";
            this.tabPageConfiguracoesClasseDTO.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfiguracoesClasseDTO.Size = new System.Drawing.Size(847, 136);
            this.tabPageConfiguracoesClasseDTO.TabIndex = 1;
            this.tabPageConfiguracoesClasseDTO.Text = "Configurações classe DTO";
            this.tabPageConfiguracoesClasseDTO.UseVisualStyleBackColor = true;
            // 
            // btnConfiguracoesDto
            // 
            this.btnConfiguracoesDto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfiguracoesDto.Location = new System.Drawing.Point(583, 86);
            this.btnConfiguracoesDto.Name = "btnConfiguracoesDto";
            this.btnConfiguracoesDto.Size = new System.Drawing.Size(153, 46);
            this.btnConfiguracoesDto.TabIndex = 25;
            this.btnConfiguracoesDto.Text = "Gerar Classe DTO";
            this.btnConfiguracoesDto.UseVisualStyleBackColor = true;
            this.btnConfiguracoesDto.Click += new System.EventHandler(this.btnConfiguracoesDto_Click);
            // 
            // TxtDiretorioDto
            // 
            this.TxtDiretorioDto.Location = new System.Drawing.Point(7, 17);
            this.TxtDiretorioDto.Name = "TxtDiretorioDto";
            this.TxtDiretorioDto.Size = new System.Drawing.Size(725, 20);
            this.TxtDiretorioDto.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Informe o destino";
            // 
            // tabPageConfiguracoesClasseBLL
            // 
            this.tabPageConfiguracoesClasseBLL.Controls.Add(this.chkAtualizarCampoDataCadastro);
            this.tabPageConfiguracoesClasseBLL.Controls.Add(this.btnConfiguracoesBll);
            this.tabPageConfiguracoesClasseBLL.Controls.Add(this.TxtDiretorioBll);
            this.tabPageConfiguracoesClasseBLL.Controls.Add(this.label6);
            this.tabPageConfiguracoesClasseBLL.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfiguracoesClasseBLL.Name = "tabPageConfiguracoesClasseBLL";
            this.tabPageConfiguracoesClasseBLL.Size = new System.Drawing.Size(847, 136);
            this.tabPageConfiguracoesClasseBLL.TabIndex = 2;
            this.tabPageConfiguracoesClasseBLL.Text = "Configurações classe BLL";
            this.tabPageConfiguracoesClasseBLL.UseVisualStyleBackColor = true;
            // 
            // chkAtualizarCampoDataCadastro
            // 
            this.chkAtualizarCampoDataCadastro.AutoSize = true;
            this.chkAtualizarCampoDataCadastro.Location = new System.Drawing.Point(9, 44);
            this.chkAtualizarCampoDataCadastro.Name = "chkAtualizarCampoDataCadastro";
            this.chkAtualizarCampoDataCadastro.Size = new System.Drawing.Size(174, 17);
            this.chkAtualizarCampoDataCadastro.TabIndex = 26;
            this.chkAtualizarCampoDataCadastro.Text = "Atualizar Campo \'DataCadastro\'";
            this.chkAtualizarCampoDataCadastro.UseVisualStyleBackColor = true;
            // 
            // btnConfiguracoesBll
            // 
            this.btnConfiguracoesBll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfiguracoesBll.Location = new System.Drawing.Point(583, 86);
            this.btnConfiguracoesBll.Name = "btnConfiguracoesBll";
            this.btnConfiguracoesBll.Size = new System.Drawing.Size(153, 46);
            this.btnConfiguracoesBll.TabIndex = 25;
            this.btnConfiguracoesBll.Text = "Gerar Classe BLL";
            this.btnConfiguracoesBll.UseVisualStyleBackColor = true;
            this.btnConfiguracoesBll.Click += new System.EventHandler(this.btnConfiguracoesBll_Click);
            // 
            // TxtDiretorioBll
            // 
            this.TxtDiretorioBll.Location = new System.Drawing.Point(7, 17);
            this.TxtDiretorioBll.Name = "TxtDiretorioBll";
            this.TxtDiretorioBll.Size = new System.Drawing.Size(725, 20);
            this.TxtDiretorioBll.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Informe o destino";
            // 
            // tabPageConfiguracoesView
            // 
            this.tabPageConfiguracoesView.Controls.Add(this.btnConfiguracoesViews);
            this.tabPageConfiguracoesView.Controls.Add(this.TxtDiretorioView);
            this.tabPageConfiguracoesView.Controls.Add(this.label9);
            this.tabPageConfiguracoesView.Controls.Add(this.radioButtonConfiguracaoViewModelo2);
            this.tabPageConfiguracoesView.Controls.Add(this.radioButtonConfiguracaoViewModelo1);
            this.tabPageConfiguracoesView.Controls.Add(this.radioButtonConfiguracaoViewModelo3);
            this.tabPageConfiguracoesView.Controls.Add(this.checkBoxGerarViewModelo1List);
            this.tabPageConfiguracoesView.Controls.Add(this.checkBoxGerarViewModelo3Create);
            this.tabPageConfiguracoesView.Controls.Add(this.checkBoxGerarViewModelo2List);
            this.tabPageConfiguracoesView.Controls.Add(this.checkBoxGerarViewModelo2Create);
            this.tabPageConfiguracoesView.Controls.Add(this.checkBoxGerarViewModelo3List);
            this.tabPageConfiguracoesView.Controls.Add(this.checkBoxGerarViewModelo1Create);
            this.tabPageConfiguracoesView.Controls.Add(this.checkBoxGerarViewModelo1Details);
            this.tabPageConfiguracoesView.Controls.Add(this.checkBoxGerarViewModelo3Edit);
            this.tabPageConfiguracoesView.Controls.Add(this.checkBoxGerarViewModelo2Details);
            this.tabPageConfiguracoesView.Controls.Add(this.checkBoxGerarViewModelo2Edit);
            this.tabPageConfiguracoesView.Controls.Add(this.checkBoxGerarViewModelo3Details);
            this.tabPageConfiguracoesView.Controls.Add(this.checkBoxGerarViewModelo1Edit);
            this.tabPageConfiguracoesView.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfiguracoesView.Name = "tabPageConfiguracoesView";
            this.tabPageConfiguracoesView.Size = new System.Drawing.Size(847, 136);
            this.tabPageConfiguracoesView.TabIndex = 4;
            this.tabPageConfiguracoesView.Text = "Configurações classe VIEW";
            this.tabPageConfiguracoesView.UseVisualStyleBackColor = true;
            // 
            // btnConfiguracoesViews
            // 
            this.btnConfiguracoesViews.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfiguracoesViews.Location = new System.Drawing.Point(690, 86);
            this.btnConfiguracoesViews.Name = "btnConfiguracoesViews";
            this.btnConfiguracoesViews.Size = new System.Drawing.Size(153, 46);
            this.btnConfiguracoesViews.TabIndex = 27;
            this.btnConfiguracoesViews.Text = "Gerar Classes Views";
            this.btnConfiguracoesViews.UseVisualStyleBackColor = true;
            this.btnConfiguracoesViews.Click += new System.EventHandler(this.btnConfiguracoesViews_Click);
            // 
            // TxtDiretorioView
            // 
            this.TxtDiretorioView.Location = new System.Drawing.Point(7, 17);
            this.TxtDiretorioView.Name = "TxtDiretorioView";
            this.TxtDiretorioView.Size = new System.Drawing.Size(725, 20);
            this.TxtDiretorioView.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(357, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Informe o destino da(s) View(s) Exemplo: E:\\Projetos\\NomeProjeto\\Views\\";
            // 
            // radioButtonConfiguracaoViewModelo2
            // 
            this.radioButtonConfiguracaoViewModelo2.AutoSize = true;
            this.radioButtonConfiguracaoViewModelo2.Location = new System.Drawing.Point(157, 43);
            this.radioButtonConfiguracaoViewModelo2.Name = "radioButtonConfiguracaoViewModelo2";
            this.radioButtonConfiguracaoViewModelo2.Size = new System.Drawing.Size(129, 17);
            this.radioButtonConfiguracaoViewModelo2.TabIndex = 4;
            this.radioButtonConfiguracaoViewModelo2.TabStop = true;
            this.radioButtonConfiguracaoViewModelo2.Text = "Gerar Views Modelo 2";
            this.radioButtonConfiguracaoViewModelo2.UseVisualStyleBackColor = true;
            // 
            // radioButtonConfiguracaoViewModelo1
            // 
            this.radioButtonConfiguracaoViewModelo1.AutoSize = true;
            this.radioButtonConfiguracaoViewModelo1.Location = new System.Drawing.Point(8, 43);
            this.radioButtonConfiguracaoViewModelo1.Name = "radioButtonConfiguracaoViewModelo1";
            this.radioButtonConfiguracaoViewModelo1.Size = new System.Drawing.Size(129, 17);
            this.radioButtonConfiguracaoViewModelo1.TabIndex = 3;
            this.radioButtonConfiguracaoViewModelo1.TabStop = true;
            this.radioButtonConfiguracaoViewModelo1.Text = "Gerar Views Modelo 1";
            this.radioButtonConfiguracaoViewModelo1.UseVisualStyleBackColor = true;
            this.radioButtonConfiguracaoViewModelo1.CheckedChanged += new System.EventHandler(this.radioButtonConfiguracaoViewModelo1_CheckedChanged);
            // 
            // radioButtonConfiguracaoViewModelo3
            // 
            this.radioButtonConfiguracaoViewModelo3.AutoSize = true;
            this.radioButtonConfiguracaoViewModelo3.Location = new System.Drawing.Point(311, 43);
            this.radioButtonConfiguracaoViewModelo3.Name = "radioButtonConfiguracaoViewModelo3";
            this.radioButtonConfiguracaoViewModelo3.Size = new System.Drawing.Size(129, 17);
            this.radioButtonConfiguracaoViewModelo3.TabIndex = 5;
            this.radioButtonConfiguracaoViewModelo3.TabStop = true;
            this.radioButtonConfiguracaoViewModelo3.Text = "Gerar Views Modelo 3";
            this.radioButtonConfiguracaoViewModelo3.UseVisualStyleBackColor = true;
            // 
            // checkBoxGerarViewModelo1List
            // 
            this.checkBoxGerarViewModelo1List.AutoSize = true;
            this.checkBoxGerarViewModelo1List.Location = new System.Drawing.Point(21, 64);
            this.checkBoxGerarViewModelo1List.Name = "checkBoxGerarViewModelo1List";
            this.checkBoxGerarViewModelo1List.Size = new System.Drawing.Size(97, 17);
            this.checkBoxGerarViewModelo1List.TabIndex = 2;
            this.checkBoxGerarViewModelo1List.Text = "Gerar View List";
            this.checkBoxGerarViewModelo1List.UseVisualStyleBackColor = true;
            // 
            // checkBoxGerarViewModelo3Create
            // 
            this.checkBoxGerarViewModelo3Create.AutoSize = true;
            this.checkBoxGerarViewModelo3Create.Enabled = false;
            this.checkBoxGerarViewModelo3Create.Location = new System.Drawing.Point(325, 114);
            this.checkBoxGerarViewModelo3Create.Name = "checkBoxGerarViewModelo3Create";
            this.checkBoxGerarViewModelo3Create.Size = new System.Drawing.Size(112, 17);
            this.checkBoxGerarViewModelo3Create.TabIndex = 2;
            this.checkBoxGerarViewModelo3Create.Text = "Gerar View Create";
            this.checkBoxGerarViewModelo3Create.UseVisualStyleBackColor = true;
            this.checkBoxGerarViewModelo3Create.Visible = false;
            // 
            // checkBoxGerarViewModelo2List
            // 
            this.checkBoxGerarViewModelo2List.AutoSize = true;
            this.checkBoxGerarViewModelo2List.Enabled = false;
            this.checkBoxGerarViewModelo2List.Location = new System.Drawing.Point(171, 64);
            this.checkBoxGerarViewModelo2List.Name = "checkBoxGerarViewModelo2List";
            this.checkBoxGerarViewModelo2List.Size = new System.Drawing.Size(97, 17);
            this.checkBoxGerarViewModelo2List.TabIndex = 2;
            this.checkBoxGerarViewModelo2List.Text = "Gerar View List";
            this.checkBoxGerarViewModelo2List.UseVisualStyleBackColor = true;
            this.checkBoxGerarViewModelo2List.Visible = false;
            // 
            // checkBoxGerarViewModelo2Create
            // 
            this.checkBoxGerarViewModelo2Create.AutoSize = true;
            this.checkBoxGerarViewModelo2Create.Enabled = false;
            this.checkBoxGerarViewModelo2Create.Location = new System.Drawing.Point(171, 114);
            this.checkBoxGerarViewModelo2Create.Name = "checkBoxGerarViewModelo2Create";
            this.checkBoxGerarViewModelo2Create.Size = new System.Drawing.Size(112, 17);
            this.checkBoxGerarViewModelo2Create.TabIndex = 2;
            this.checkBoxGerarViewModelo2Create.Text = "Gerar View Create";
            this.checkBoxGerarViewModelo2Create.UseVisualStyleBackColor = true;
            this.checkBoxGerarViewModelo2Create.Visible = false;
            // 
            // checkBoxGerarViewModelo3List
            // 
            this.checkBoxGerarViewModelo3List.AutoSize = true;
            this.checkBoxGerarViewModelo3List.Enabled = false;
            this.checkBoxGerarViewModelo3List.Location = new System.Drawing.Point(325, 64);
            this.checkBoxGerarViewModelo3List.Name = "checkBoxGerarViewModelo3List";
            this.checkBoxGerarViewModelo3List.Size = new System.Drawing.Size(97, 17);
            this.checkBoxGerarViewModelo3List.TabIndex = 2;
            this.checkBoxGerarViewModelo3List.Text = "Gerar View List";
            this.checkBoxGerarViewModelo3List.UseVisualStyleBackColor = true;
            this.checkBoxGerarViewModelo3List.Visible = false;
            // 
            // checkBoxGerarViewModelo1Create
            // 
            this.checkBoxGerarViewModelo1Create.AutoSize = true;
            this.checkBoxGerarViewModelo1Create.Location = new System.Drawing.Point(21, 114);
            this.checkBoxGerarViewModelo1Create.Name = "checkBoxGerarViewModelo1Create";
            this.checkBoxGerarViewModelo1Create.Size = new System.Drawing.Size(112, 17);
            this.checkBoxGerarViewModelo1Create.TabIndex = 2;
            this.checkBoxGerarViewModelo1Create.Text = "Gerar View Create";
            this.checkBoxGerarViewModelo1Create.UseVisualStyleBackColor = true;
            // 
            // checkBoxGerarViewModelo1Details
            // 
            this.checkBoxGerarViewModelo1Details.AutoSize = true;
            this.checkBoxGerarViewModelo1Details.Location = new System.Drawing.Point(21, 80);
            this.checkBoxGerarViewModelo1Details.Name = "checkBoxGerarViewModelo1Details";
            this.checkBoxGerarViewModelo1Details.Size = new System.Drawing.Size(113, 17);
            this.checkBoxGerarViewModelo1Details.TabIndex = 2;
            this.checkBoxGerarViewModelo1Details.Text = "Gerar View Details";
            this.checkBoxGerarViewModelo1Details.UseVisualStyleBackColor = true;
            // 
            // checkBoxGerarViewModelo3Edit
            // 
            this.checkBoxGerarViewModelo3Edit.AutoSize = true;
            this.checkBoxGerarViewModelo3Edit.Enabled = false;
            this.checkBoxGerarViewModelo3Edit.Location = new System.Drawing.Point(325, 97);
            this.checkBoxGerarViewModelo3Edit.Name = "checkBoxGerarViewModelo3Edit";
            this.checkBoxGerarViewModelo3Edit.Size = new System.Drawing.Size(99, 17);
            this.checkBoxGerarViewModelo3Edit.TabIndex = 2;
            this.checkBoxGerarViewModelo3Edit.Text = "Gerar View Edit";
            this.checkBoxGerarViewModelo3Edit.UseVisualStyleBackColor = true;
            this.checkBoxGerarViewModelo3Edit.Visible = false;
            // 
            // checkBoxGerarViewModelo2Details
            // 
            this.checkBoxGerarViewModelo2Details.AutoSize = true;
            this.checkBoxGerarViewModelo2Details.Enabled = false;
            this.checkBoxGerarViewModelo2Details.Location = new System.Drawing.Point(171, 80);
            this.checkBoxGerarViewModelo2Details.Name = "checkBoxGerarViewModelo2Details";
            this.checkBoxGerarViewModelo2Details.Size = new System.Drawing.Size(113, 17);
            this.checkBoxGerarViewModelo2Details.TabIndex = 2;
            this.checkBoxGerarViewModelo2Details.Text = "Gerar View Details";
            this.checkBoxGerarViewModelo2Details.UseVisualStyleBackColor = true;
            this.checkBoxGerarViewModelo2Details.Visible = false;
            // 
            // checkBoxGerarViewModelo2Edit
            // 
            this.checkBoxGerarViewModelo2Edit.AutoSize = true;
            this.checkBoxGerarViewModelo2Edit.Enabled = false;
            this.checkBoxGerarViewModelo2Edit.Location = new System.Drawing.Point(171, 97);
            this.checkBoxGerarViewModelo2Edit.Name = "checkBoxGerarViewModelo2Edit";
            this.checkBoxGerarViewModelo2Edit.Size = new System.Drawing.Size(99, 17);
            this.checkBoxGerarViewModelo2Edit.TabIndex = 2;
            this.checkBoxGerarViewModelo2Edit.Text = "Gerar View Edit";
            this.checkBoxGerarViewModelo2Edit.UseVisualStyleBackColor = true;
            this.checkBoxGerarViewModelo2Edit.Visible = false;
            // 
            // checkBoxGerarViewModelo3Details
            // 
            this.checkBoxGerarViewModelo3Details.AutoSize = true;
            this.checkBoxGerarViewModelo3Details.Enabled = false;
            this.checkBoxGerarViewModelo3Details.Location = new System.Drawing.Point(325, 80);
            this.checkBoxGerarViewModelo3Details.Name = "checkBoxGerarViewModelo3Details";
            this.checkBoxGerarViewModelo3Details.Size = new System.Drawing.Size(113, 17);
            this.checkBoxGerarViewModelo3Details.TabIndex = 2;
            this.checkBoxGerarViewModelo3Details.Text = "Gerar View Details";
            this.checkBoxGerarViewModelo3Details.UseVisualStyleBackColor = true;
            this.checkBoxGerarViewModelo3Details.Visible = false;
            // 
            // checkBoxGerarViewModelo1Edit
            // 
            this.checkBoxGerarViewModelo1Edit.AutoSize = true;
            this.checkBoxGerarViewModelo1Edit.Location = new System.Drawing.Point(21, 97);
            this.checkBoxGerarViewModelo1Edit.Name = "checkBoxGerarViewModelo1Edit";
            this.checkBoxGerarViewModelo1Edit.Size = new System.Drawing.Size(99, 17);
            this.checkBoxGerarViewModelo1Edit.TabIndex = 2;
            this.checkBoxGerarViewModelo1Edit.Text = "Gerar View Edit";
            this.checkBoxGerarViewModelo1Edit.UseVisualStyleBackColor = true;
            // 
            // tabPageConfiguracoesController
            // 
            this.tabPageConfiguracoesController.Controls.Add(this.BtnConfiguracoesController);
            this.tabPageConfiguracoesController.Controls.Add(this.TxtNameSpaceProjeto);
            this.tabPageConfiguracoesController.Controls.Add(this.label8);
            this.tabPageConfiguracoesController.Controls.Add(this.TxtDiretorioControlller);
            this.tabPageConfiguracoesController.Controls.Add(this.label7);
            this.tabPageConfiguracoesController.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfiguracoesController.Name = "tabPageConfiguracoesController";
            this.tabPageConfiguracoesController.Size = new System.Drawing.Size(847, 136);
            this.tabPageConfiguracoesController.TabIndex = 5;
            this.tabPageConfiguracoesController.Text = "Configurações classe Controller";
            this.tabPageConfiguracoesController.UseVisualStyleBackColor = true;
            // 
            // BtnConfiguracoesController
            // 
            this.BtnConfiguracoesController.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConfiguracoesController.Location = new System.Drawing.Point(583, 86);
            this.BtnConfiguracoesController.Name = "BtnConfiguracoesController";
            this.BtnConfiguracoesController.Size = new System.Drawing.Size(153, 46);
            this.BtnConfiguracoesController.TabIndex = 28;
            this.BtnConfiguracoesController.Text = "Gerar Classe Controller";
            this.BtnConfiguracoesController.UseVisualStyleBackColor = true;
            this.BtnConfiguracoesController.Click += new System.EventHandler(this.BtnConfiguracoesController_Click);
            // 
            // TxtNameSpaceProjeto
            // 
            this.TxtNameSpaceProjeto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNameSpaceProjeto.Location = new System.Drawing.Point(8, 56);
            this.TxtNameSpaceProjeto.Name = "TxtNameSpaceProjeto";
            this.TxtNameSpaceProjeto.Size = new System.Drawing.Size(569, 20);
            this.TxtNameSpaceProjeto.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Informe o \'namespace\' do projeto";
            // 
            // TxtDiretorioControlller
            // 
            this.TxtDiretorioControlller.Location = new System.Drawing.Point(7, 19);
            this.TxtDiretorioControlller.Name = "TxtDiretorioControlller";
            this.TxtDiretorioControlller.Size = new System.Drawing.Size(725, 20);
            this.TxtDiretorioControlller.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Informe o destino";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 50);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstTabelas);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewMapeamento);
            this.splitContainer1.Size = new System.Drawing.Size(855, 277);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.TabIndex = 2;
            // 
            // lstTabelas
            // 
            this.lstTabelas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTabelas.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTabelas.FormattingEnabled = true;
            this.lstTabelas.ItemHeight = 23;
            this.lstTabelas.Location = new System.Drawing.Point(0, 76);
            this.lstTabelas.Name = "lstTabelas";
            this.lstTabelas.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstTabelas.Size = new System.Drawing.Size(270, 201);
            this.lstTabelas.Sorted = true;
            this.lstTabelas.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LblMensagemTabela);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtPesquisarTabelas);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 76);
            this.panel2.TabIndex = 2;
            // 
            // LblMensagemTabela
            // 
            this.LblMensagemTabela.AutoSize = true;
            this.LblMensagemTabela.Location = new System.Drawing.Point(6, 45);
            this.LblMensagemTabela.Name = "LblMensagemTabela";
            this.LblMensagemTabela.Size = new System.Drawing.Size(0, 13);
            this.LblMensagemTabela.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(192, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // txtPesquisarTabelas
            // 
            this.txtPesquisarTabelas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisarTabelas.Location = new System.Drawing.Point(3, 18);
            this.txtPesquisarTabelas.Name = "txtPesquisarTabelas";
            this.txtPesquisarTabelas.Size = new System.Drawing.Size(183, 20);
            this.txtPesquisarTabelas.TabIndex = 3;
            this.txtPesquisarTabelas.TextChanged += new System.EventHandler(this.txtPesquisarTabelas_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Filtrar tabelas";
            // 
            // dataGridViewMapeamento
            // 
            this.dataGridViewMapeamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMapeamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMapeamento.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMapeamento.Name = "dataGridViewMapeamento";
            this.dataGridViewMapeamento.Size = new System.Drawing.Size(581, 277);
            this.dataGridViewMapeamento.TabIndex = 0;
            // 
            // GeradorClassesCamadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 489);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(871, 527);
            this.Name = "GeradorClassesCamadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de classes camadas AspNet MVC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GeradorClassesCamadas_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageConfiguracoesConexao.ResumeLayout(false);
            this.tabPageConfiguracoesConexao.PerformLayout();
            this.tabPageConfiguracoesClasseDal.ResumeLayout(false);
            this.tabPageConfiguracoesClasseDal.PerformLayout();
            this.tabPageConfiguracoesClasseDTO.ResumeLayout(false);
            this.tabPageConfiguracoesClasseDTO.PerformLayout();
            this.tabPageConfiguracoesClasseBLL.ResumeLayout(false);
            this.tabPageConfiguracoesClasseBLL.PerformLayout();
            this.tabPageConfiguracoesView.ResumeLayout(false);
            this.tabPageConfiguracoesView.PerformLayout();
            this.tabPageConfiguracoesController.ResumeLayout(false);
            this.tabPageConfiguracoesController.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMapeamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageConfiguracoesConexao;
        private System.Windows.Forms.TabPage tabPageConfiguracoesClasseDal;
        private System.Windows.Forms.TabPage tabPageConfiguracoesClasseDTO;
        private System.Windows.Forms.TabPage tabPageConfiguracoesClasseBLL;
        private System.Windows.Forms.TabPage tabPageConfiguracoesView;
        private System.Windows.Forms.TabPage tabPageConfiguracoesController;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lstTabelas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewMapeamento;
        private System.Windows.Forms.Label LblMensagemTabela;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPesquisarTabelas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblConnstring;
        private System.Windows.Forms.CheckBox ckAutentica;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.Button btnLerBanco;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.Button btnConfiguracoesDal;
        private System.Windows.Forms.TextBox TxtDiretorioDal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfiguracoesDto;
        private System.Windows.Forms.TextBox TxtDiretorioDto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConfiguracoesBll;
        private System.Windows.Forms.TextBox TxtDiretorioBll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnConfiguracoesController;
        private System.Windows.Forms.TextBox TxtNameSpaceProjeto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtDiretorioControlller;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkAtualizarCampoDataCadastro;
        private System.Windows.Forms.RadioButton radioButtonConfiguracaoViewModelo3;
        private System.Windows.Forms.RadioButton radioButtonConfiguracaoViewModelo2;
        private System.Windows.Forms.RadioButton radioButtonConfiguracaoViewModelo1;
        private System.Windows.Forms.CheckBox checkBoxGerarViewModelo1List;
        private System.Windows.Forms.CheckBox checkBoxGerarViewModelo1Create;
        private System.Windows.Forms.CheckBox checkBoxGerarViewModelo1Edit;
        private System.Windows.Forms.CheckBox checkBoxGerarViewModelo1Details;
        private System.Windows.Forms.CheckBox checkBoxGerarViewModelo3Create;
        private System.Windows.Forms.CheckBox checkBoxGerarViewModelo2Create;
        private System.Windows.Forms.CheckBox checkBoxGerarViewModelo3Edit;
        private System.Windows.Forms.CheckBox checkBoxGerarViewModelo2Edit;
        private System.Windows.Forms.CheckBox checkBoxGerarViewModelo3Details;
        private System.Windows.Forms.CheckBox checkBoxGerarViewModelo2Details;
        private System.Windows.Forms.CheckBox checkBoxGerarViewModelo3List;
        private System.Windows.Forms.CheckBox checkBoxGerarViewModelo2List;
        private System.Windows.Forms.Button btnConfiguracoesViews;
        private System.Windows.Forms.TextBox TxtDiretorioView;
        private System.Windows.Forms.Label label9;
    }
}