using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseFramework.Clase2
{
    internal class Oficial : Persona
    {
        private int cantidadClientesActivos;

        public void MostrarInfo()
        {
            Console.WriteLine("Soy un oficial del banco");
        }

        public void MostrarCantidadClientesActivos()
        {
            Console.WriteLine("La cantidad de clientes activos es: " + cantidadClientesActivos);
        }

        override public string ToString()
        {
            return $"Soy un oficial";
        }

    }
}
