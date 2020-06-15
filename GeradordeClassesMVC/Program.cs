using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeradorClasseMVC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new GeradorDAO());
            Application.Run(new GeradorClassesCamadas());
        }
    }
}