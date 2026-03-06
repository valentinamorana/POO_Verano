using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseFramework.Clase2
{
    //Todas las clases dentro de .NET son derivadas de la clase Object
    //internal class Cajero : Object
    
    internal class Cajero : Persona
    {
        private decimal maximoMontoAtencion = 10000; //Esto está mal, lo corregimos luego

        public void MostrarMontoMaximo()
        {
            Console.WriteLine("El monto máximo de atención es: " + maximoMontoAtencion);
        }

        public void MostrarInfo()
        {
            Console.WriteLine("Soy un cajero y atiendo en las cajas del banco");
            Algo();
        }

        /// <summary>
        /// Hacemos override del método ToString() para mostrar el estado interno del objeto Cajero
        /// </summary>
        /// <returns></returns>
        override public string ToString()
        {
            return $"Soy un cajero" ;
        }
    }
}
