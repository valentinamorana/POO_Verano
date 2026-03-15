using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseFramework.Clase2
{
    internal class Cliente : Persona
    {
        private int numeroCliente;

        public void MostrarInfo()
        {
            Console.WriteLine("Soy un cliente del banco");
        }

        public void MostrarNumeroCliente()
        {
            Console.WriteLine("El número de cliente es: " + numeroCliente);
        }

        override public string ToString()
        {
            return $"Soy un cliente";
        }

    }
}
