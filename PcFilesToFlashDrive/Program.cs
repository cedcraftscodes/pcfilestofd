using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcFilesToFlashDrive
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string []args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length == 1)
            {

                Properties.Settings.Default.ShowOnStartup = Convert.ToBoolean(args[0]);
                Properties.Settings.Default.Save();
            }
            Application.Run(new Form1());
        }
    }
}
