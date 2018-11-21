using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Forms_Retrieve;
using Library.Forms_Insert;
using Library.Form_Information;
using Library.Util;


namespace Library
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            //MessageBox.Show("Verificar a Base de Dados conectada antes de realizar testes!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Main());

        }
    }
}
