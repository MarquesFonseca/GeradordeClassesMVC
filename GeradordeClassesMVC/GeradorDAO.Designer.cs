namespace GeradorClasseMVC
{
    partial class GeradorDAO
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
            this.grupTabelas = new System.Windows.Forms.GroupBox();
            this.btnGerarBO = new System.Windows.Forms.Button();
            this.btnGerarVO = new System.Windows.Forms.Button();
            this.lstTabelas = new System.Windows.Forms.ListBox();
            this.grupCodigo = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.grupBanco = new System.Windows.Forms.GroupBox();
            this.lblConnstring = new System.Windows.Forms.Label();
            this.ckAutentica = new System.Windows.Forms.CheckBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.lblBanco = new System.Windows.Forms.Label();
            this.btnGerarDO = new System.Windows.Forms.Button();
            this.btnLerBanco = new System.Windows.Forms.Button();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.lblServidor = new System.Windows.Forms.Label();
            this.BtnSelecionarTudo = new System.Windows.Forms.Button();
            this.grupTabelas.SuspendLayout();
            this.grupCodigo.SuspendLayout();
            this.grupBanco.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupTabelas
            // 
            this.grupTabelas.Controls.Add(this.btnGerarBO);
            this.grupTabelas.Controls.Add(this.btnGerarVO);
            this.grupTabelas.Controls.Add(this.lstTabelas);
            this.grupTabelas.Controls.Add(this.btnGerarDO);
            this.grupTabelas.Location = new System.Drawing.Point(12, 12);
            this.grupTabelas.Name = "grupTabelas";
            this.grupTabelas.Size = new System.Drawing.Size(244, 464);
            this.grupTabelas.TabIndex = 4;
            this.grupTabelas.TabStop = false;
            this.grupTabelas.Text = "Tabelas";
            // 
            // btnGerarBO
            // 
            this.btnGerarBO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGerarBO.Location = new System.Drawing.Point(87, 432);
            this.btnGerarBO.Name = "btnGerarBO";
            this.btnGerarBO.Size = new System.Drawing.Size(75, 23);
            this.btnGerarBO.TabIndex = 9;
            this.btnGerarBO.Text = "Gerar BO";
            this.btnGerarBO.UseVisualStyleBackColor = true;
            this.btnGerarBO.Click += new System.EventHandler(this.btnGerarBO_Click);
            // 
            // btnGerarVO
            // 
            this.btnGerarVO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGerarVO.Location = new System.Drawing.Point(6, 432);
            this.btnGerarVO.Name = "btnGerarVO";
            this.btnGerarVO.Size = new System.Drawing.Size(75, 23);
            this.btnGerarVO.TabIndex = 8;
            this.btnGerarVO.Text = "Gerar VO";
            this.btnGerarVO.UseVisualStyleBackColor = true;
            this.btnGerarVO.Click += new System.EventHandler(this.btnGerarVO_Click);
            // 
            // lstTabelas
            // 
            this.lstTabelas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lstTabelas.FormattingEnabled = true;
            this.lstTabelas.Location = new System.Drawing.Point(9, 18);
            this.lstTabelas.Name = "lstTabelas";
            this.lstTabelas.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstTabelas.Size = new System.Drawing.Size(229, 407);
            this.lstTabelas.Sorted = true;
            this.lstTabelas.TabIndex = 7;
            // 
            // grupCodigo
            // 
            this.grupCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grupCodigo.AutoSize = true;
            this.grupCodigo.Controls.Add(this.txtCodigo);
            this.grupCodigo.Location = new System.Drawing.Point(262, 153);
            this.grupCodigo.Name = "grupCodigo";
            this.grupCodigo.Size = new System.Drawing.Size(518, 323);
            this.grupCodigo.TabIndex = 3;
            this.grupCodigo.TabStop = false;
            this.grupCodigo.Text = "Classes C#";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(6, 19);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCodigo.Size = new System.Drawing.Size(500, 286);
            this.txtCodigo.TabIndex = 10;
            // 
            // grupBanco
            // 
            this.grupBanco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grupBanco.Controls.Add(this.BtnSelecionarTudo);
            this.grupBanco.Controls.Add(this.lblConnstring);
            this.grupBanco.Controls.Add(this.ckAutentica);
            this.grupBanco.Controls.Add(this.txtSenha);
            this.grupBanco.Controls.Add(this.label1);
            this.grupBanco.Controls.Add(this.txtUsuario);
            this.grupBanco.Controls.Add(this.lblUsuario);
            this.grupBanco.Controls.Add(this.txtBanco);
            this.grupBanco.Controls.Add(this.lblBanco);
            this.grupBanco.Controls.Add(this.btnLerBanco);
            this.grupBanco.Controls.Add(this.txtServidor);
            this.grupBanco.Controls.Add(this.lblServidor);
            this.grupBanco.Location = new System.Drawing.Point(262, 12);
            this.grupBanco.Name = "grupBanco";
            this.grupBanco.Size = new System.Drawing.Size(518, 127);
            this.grupBanco.TabIndex = 5;
            this.grupBanco.TabStop = false;
            this.grupBanco.Text = "Banco de Dados";
            // 
            // lblConnstring
            // 
            this.lblConnstring.AutoSize = true;
            this.lblConnstring.Location = new System.Drawing.Point(10, 105);
            this.lblConnstring.Name = "lblConnstring";
            this.lblConnstring.Size = new System.Drawing.Size(103, 13);
            this.lblConnstring.TabIndex = 11;
            this.lblConnstring.Text = "String de Conexão:  ";
            // 
            // ckAutentica
            // 
            this.ckAutentica.AutoSize = true;
            this.ckAutentica.Location = new System.Drawing.Point(13, 81);
            this.ckAutentica.Name = "ckAutentica";
            this.ckAutentica.Size = new System.Drawing.Size(161, 17);
            this.ckAutentica.TabIndex = 3;
            this.ckAutentica.Text = "Usar Autenticação Windows";
            this.ckAutentica.UseVisualStyleBackColor = true;
            this.ckAutentica.Click += new System.EventHandler(this.ckAutentica_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(265, 48);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(150, 20);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.Text = "S35SUP5RSRG";
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Senha";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(265, 21);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(150, 20);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.Text = "SUPERSCERG";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(218, 24);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(61, 51);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(152, 20);
            this.txtBanco.TabIndex = 1;
            this.txtBanco.Text = "CAMARA";
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(10, 56);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(38, 13);
            this.lblBanco.TabIndex = 4;
            this.lblBanco.Text = "Banco";
            // 
            // btnGerarDO
            // 
            this.btnGerarDO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGerarDO.Location = new System.Drawing.Point(166, 432);
            this.btnGerarDO.Name = "btnGerarDO";
            this.btnGerarDO.Size = new System.Drawing.Size(69, 23);
            this.btnGerarDO.TabIndex = 7;
            this.btnGerarDO.Text = "Gerar DO";
            this.btnGerarDO.UseVisualStyleBackColor = true;
            this.btnGerarDO.Click += new System.EventHandler(this.btnGerarDO_Click);
            // 
            // btnLerBanco
            // 
            this.btnLerBanco.Location = new System.Drawing.Point(429, 20);
            this.btnLerBanco.Name = "btnLerBanco";
            this.btnLerBanco.Size = new System.Drawing.Size(77, 46);
            this.btnLerBanco.TabIndex = 6;
            this.btnLerBanco.Text = "Ler Banco";
            this.btnLerBanco.UseVisualStyleBackColor = true;
            this.btnLerBanco.Click += new System.EventHandler(this.btnLerBanco_Click);
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(61, 24);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(152, 20);
            this.txtServidor.TabIndex = 0;
            this.txtServidor.Text = "MARQUESNOTE-PC\\SQL2008";
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(7, 28);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(46, 13);
            this.lblServidor.TabIndex = 0;
            this.lblServidor.Text = "Servidor";
            // 
            // BtnSelecionarTudo
            // 
            this.BtnSelecionarTudo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSelecionarTudo.Location = new System.Drawing.Point(403, 94);
            this.BtnSelecionarTudo.Name = "BtnSelecionarTudo";
            this.BtnSelecionarTudo.Size = new System.Drawing.Size(101, 23);
            this.BtnSelecionarTudo.TabIndex = 12;
            this.BtnSelecionarTudo.Text = "Selecionar tudo";
            this.BtnSelecionarTudo.UseVisualStyleBackColor = true;
            this.BtnSelecionarTudo.Click += new System.EventHandler(this.BtnSelecionarTudo_Click);
            // 
            // GeradorDAO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(792, 479);
            this.Controls.Add(this.grupBanco);
            this.Controls.Add(this.grupTabelas);
            this.Controls.Add(this.grupCodigo);
            this.Name = "GeradorDAO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeradorDAO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GeradorDAO_Load);
            this.grupTabelas.ResumeLayout(false);
            this.grupCodigo.ResumeLayout(false);
            this.grupCodigo.PerformLayout();
            this.grupBanco.ResumeLayout(false);
            this.grupBanco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grupTabelas;
        private System.Windows.Forms.ListBox lstTabelas;
        private System.Windows.Forms.GroupBox grupCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox grupBanco;
        private System.Windows.Forms.Button btnLerBanco;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.Button btnGerarDO;
        private System.Windows.Forms.Button btnGerarBO;
        private System.Windows.Forms.Button btnGerarVO;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.CheckBox ckAutentica;
        private System.Windows.Forms.Label lblConnstring;
        private System.Windows.Forms.Button BtnSelecionarTudo;
    }
}