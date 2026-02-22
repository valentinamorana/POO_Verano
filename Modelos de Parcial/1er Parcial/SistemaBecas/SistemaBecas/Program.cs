using System;
using System.Windows.Forms;

namespace SistemaBecas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada de la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Iniciar la aplicación con el formulario principal
            Application.Run(new Form1());
        }
    }
}
