using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_UN2_Morana_POO.EJ6;
using TP_UN2_Morana_POO.EJ7;
using TP_UN2_Morana_POO.EJ8;
using TP_UN2_Morana_POO.EJ9;
using TP_UN2_Morana_POO.EJ10;
using TP_UN2_Morana_POO.EJ11;
using TP_UN2_Morana_POO.EJ12;

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
            Application.Run(new FormEJ6()); //Ejercicio 6
            //Application.Run(new FormEJ7()); //Ejercicio 7
            //Application.Run(new FormTest()); //Ejercicio 8, 9, 10, 11 y 12 (en el mismo form para probar todo junto) 
        }
    }
}
