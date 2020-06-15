using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GeradorClasseMVC
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeradorDAO ofrm = new GeradorDAO();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre ofrm = new Sobre();
            ofrm.MdiParent = this;
            ofrm.Show();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}