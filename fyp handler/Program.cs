using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fyp_handler
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
            Application.Run(new WELCOME());
            Application.Run(new WELCOME1());
            Application.Run(new Student());
            Application.Run(new Advisor());
            Application.Run(new Evaluation());
            Application.Run(new Project());
        }
    }
}
