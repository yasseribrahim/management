using System;
using System.IO;
using System.Windows.Forms;

namespace Management
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
            string baseDir = System.IO.Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory);
            AppDomain.CurrentDomain.SetData("DataDirectory", baseDir);

            Application.Run(new Management());
        }
    }
}
