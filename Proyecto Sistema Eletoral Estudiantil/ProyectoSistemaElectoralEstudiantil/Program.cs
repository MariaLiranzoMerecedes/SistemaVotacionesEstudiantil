using System;
using System.Windows.Forms;
using ProyectoSistemaElectoralEstudiantil;

namespace ProyectoSistemaElectoralEstudiantil
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
            Application.Run(new ProyectoSistemaElectoralEstudiantil.FormLogin2.FormLogin2());
        }
    }
}
