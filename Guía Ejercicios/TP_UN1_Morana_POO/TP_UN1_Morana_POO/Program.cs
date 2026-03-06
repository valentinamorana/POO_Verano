using System;
using System.Windows.Forms;
using TP_UN1_Morana_POO.EJ1;
using TP_UN1_Morana_POO.EJ2;
using TP_UN1_Morana_POO.EJ3;
using TP_UN1_Morana_POO.EJ4;
using TP_UN1_Morana_POO.EJ5;

namespace TP_UN1_Morana_POO
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new UniversidadForms()); //EJ1
            // Application.Run(new Banco()); //EJ2
            // Application.Run(new VehiculoFormsEJ3()); //EJ3
            // Application.Run(new VehiculoFormsEJ4()); //EJ4
            // Application.Run(new FormEJ5()); //EJ5

        }
    }
}