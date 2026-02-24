using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp.Modelo.Miembros_de_clase
{
    static class Configuration
    {
        //Cuando la clase es static, tosos los miembros son static
        public static int MaxUsers { get; private set; }

        public static int MinUsers { get; private set; }

        //Constructor estático, se ejecuta una sola vez, la primera vez que se accede a la clase, y se utiliza para inicializar los miembros estáticos de la clase
        static Configuration()
        {
            //Asignar todas las variables static que quedarán públicas para mi aplicación
            MaxUsers = 100;
            MinUsers = 1;
        }

        public static void Mostrar()
        {
            MessageBox.Show($"Máximos usuario: {Configuration.MaxUsers}");
        }
    }
}
