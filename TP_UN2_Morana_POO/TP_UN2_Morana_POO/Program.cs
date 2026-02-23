using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_UN2_Morana_POO.EJ1;
using TP_UN2_Morana_POO.EJ2;
using TP_UN2_Morana_POO.EJ3;
using TP_UN2_Morana_POO.EJ4;
using TP_UN2_Morana_POO.EJ5;
using TP_UN2_Morana_POO.EJ6;
using TP_UN2_Morana_POO.EJ7;

namespace TP_UN2_Morana_POO
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
            //Application.Run(new FormEJ1()); //Ejercicio 1
            Application.Run(new FormEJ2()); //Ejercicio 2
        }
    }
}
