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
<<<<<<< HEAD
            Application.Run(new FrmPanelVotaciones());
=======
            Application.Run(new ProyectoSistemaElectoralEstudiantil.FormLogin2.FormLogin2());
>>>>>>> c1a495ac4a4f3894054a5a5df451fd58fa132b23
        }
    }
}
