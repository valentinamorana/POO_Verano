using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_UN2_Morana_POO.EJ8
{
    public class Recurso
    {
        private string nombre;

        public Recurso(string nombre)
        {
            this.nombre = nombre;
        }

        public void MostrarEstado() // Método para mostrar el estado del recurso
        {
            MessageBox.Show($"Recurso activo: {nombre}");
        }

        ~Recurso() // Destructor que se ejecutará cuando el objeto sea recolectado por el GC
        {
            MessageBox.Show($"Recurso liberado: {nombre}");
        }
    }
}
