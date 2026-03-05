using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_UN3_Morana_POO.EJ14
{
    public class Zombie
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        // Identificador único para demostrar que es el mismo objeto
        private Guid id;

        public Guid Id
        {
            get { return id; }
        }

        // Referencia estática usada para resucitar el objeto
        public static Zombie Resucitado;

        // Constructor
        public Zombie(string nombre)
        {
            this.nombre = nombre;
            this.id = Guid.NewGuid(); // genera identificador único
        }

        // Método normal del objeto
        public void Saludar()
        {
            MessageBox.Show("Hola, soy " + nombre);
        }

        // FINALIZADOR
        // Se ejecuta cuando el Garbage Collector intenta eliminar el objeto
        ~Zombie()
        {
            // Técnica de resurrección: guardamos la referencia del objeto
            if (Resucitado == null)
            {
                Resucitado = this;
            }
        }
    }
}
