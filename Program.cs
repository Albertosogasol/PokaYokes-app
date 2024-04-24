using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokaYokes_app
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Hasta que se añada la ventana de login, se carga directamente el formulario principal. Cuando se termine, quitar y descomentar LoginForm
            //Application.Run(new MainForm());
            Application.Run(new LoginForm()); 
        }
    }
}
