using System;
using System.Linq;
using System.Windows.Forms;

namespace YoutubeTool
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Count<string>() == 0)
            {
                Application.Run(new frmMainFrame());
                return;
            }

            //Preprocess args then perform
        }
    }
}
