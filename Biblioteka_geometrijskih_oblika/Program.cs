using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Biblioteka_geometrijskih_oblika
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
            Application.Run(new Biblioteka_abstraktinih_geometrijskih_oblika());
        }
    }
}
