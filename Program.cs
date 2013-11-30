using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickLinks
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static Form1 MainForm;
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(MainForm = new Form1());
        }
    }
}
