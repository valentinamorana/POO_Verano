using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN2_Morana_POO.EJ8
{
    public class GestorRecurso
    {
        private Recurso recurso;

        public GestorRecurso(string nombreRecurso)
        {
            // Se instancia el objeto dentro del constructor
            recurso = new Recurso(nombreRecurso);
        }

        public void UsarRecurso() // Método para usar el recurso
        {
            recurso.MostrarEstado();
        }

        ~GestorRecurso() // Destructor que se ejecutará cuando el objeto sea recolectado por el GC
        {
            Console.WriteLine("Gestor finalizado.");
        }
    }
}
