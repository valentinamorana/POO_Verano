using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_UN6_Morana_POO.EJ24;
using TP_UN6_Morana_POO.EJ25;
using TP_UN6_Morana_POO.EJ26;

namespace TP_UN6_Morana_POO
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

            // EJ24
            FormServidor servidor = new FormServidor();
            FormCliente cliente = new FormCliente();

            servidor.Show();              // abre el servidor
            Application.Run(cliente);     // arranca la app con el cliente como form principal

            // EJ25
            /* FormServidor2 servidor = new FormServidor2();
            FormCliente2 cliente = new FormCliente2();

            servidor.Show();              // abre el servidor
            Application.Run(cliente);     // corre el cliente */

            // EJ26
            //Application.Run(new FormPuertoParalelo());
        }
    }
}
