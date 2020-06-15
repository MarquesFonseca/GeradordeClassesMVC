namespace GeradorClasseMVC
{
    partial class Sobre
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
            this.tabCtrlSobre = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtVerssao = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.tabCtrlSobre.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrlSobre
            // 
            this.tabCtrlSobre.Controls.Add(this.tabPage1);
            this.tabCtrlSobre.Controls.Add(this.tabPage2);
            this.tabCtrlSobre.Location = new System.Drawing.Point(13, 11);
            this.tabCtrlSobre.Name = "tabCtrlSobre";
            this.tabCtrlSobre.SelectedIndex = 0;
            this.tabCtrlSobre.Size = new System.Drawing.Size(267, 215);
            this.tabCtrlSobre.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtVerssao);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(259, 189);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Versão";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtVerssao
            // 
            this.txtVerssao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVerssao.Location = new System.Drawing.Point(7, 28);
            this.txtVerssao.Multiline = true;
            this.txtVerssao.Name = "txtVerssao";
            this.txtVerssao.Size = new System.Drawing.Size(246, 123);
            this.txtVerssao.TabIndex = 0;
            this.txtVerssao.Text = " Gerador DAO.\r\n\r\nGerador de Classes de Acesso a Banco de Dados\r\nSQL Server.\r\n\r\nLi" +
                "nguagem C# .NET\r\n\r\nVersão: 1.0";
            this.txtVerssao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtAutor);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(259, 189);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Autor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtAutor
            // 
            this.txtAutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAutor.Location = new System.Drawing.Point(7, 47);
            this.txtAutor.Multiline = true;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(246, 84);
            this.txtAutor.TabIndex = 0;
            this.txtAutor.Text = "Marques Silva Fonseca \r\n\r\nmarques-fonseca@hotmail.com \r\n\r\nBrasília DF";
            // 
            // Sobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 237);
            this.Controls.Add(this.tabCtrlSobre);
            this.Name = "Sobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            this.tabCtrlSobre.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlSobre;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtVerssao;
        private System.Windows.Forms.TextBox txtAutor;
    }
}