using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Library.Connection
{
    class Backup
    {
        /*---- Colocar um popup de busca de local ----*/
        string path = "C:\\MySqlLibraryDump.sql";
        string input; //mudar para dumpFile

        public void DatabaseDump()
        {
            try
            {
                StreamWriter file = new StreamWriter(path);

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysqldump";
                psi.RedirectStandardInput = false;
                psi.RedirectStandardOutput = true;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                    "root", "rachel", "localhost", "newlibrary");
                psi.UseShellExecute = false;

                Process process = Process.Start(psi);

                file.WriteLine(process.StandardOutput.ReadToEnd());
                process.WaitForExit();
                file.Close();
                process.Close();

            }
            catch(IOException ex)
            {
                MessageBox.Show("Error , unable to backup!");
            }
        }

        public void DatabaseRestore()
        {
            try
            {
                StreamReader file = new StreamReader(path);
                input = file.ReadToEnd();
                file.Close();

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysql";
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = false;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                    "root", "rachel", "localhost", "newlibrary");
                psi.UseShellExecute = false;

                Process process = Process.Start(psi);
                process.StandardInput.WriteLine(input);
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            }catch(IOException ex)
            {
                MessageBox.Show("Error , unable to Restore!");
            }
        }
    }
}
