using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseFramework.Clase2
{
    internal class Persona
    {
        private string nombre;

        private string apellido;

        /// <summary>
        /// Miembros de tipo protected pueden ser accedidos por clases derivadas
        /// Se comportan como private para las demás clases
        /// </summary>
        protected DateTime fechaNacimiento;

        public void MostrarInfo()
        {
            Console.WriteLine("Soy una persona");
        }

        public void MostrarInfoPersona()
        {
            Console.WriteLine("Nombre: " + this.nombre);
            Console.WriteLine("Apellido: " + this.apellido);
            Console.WriteLine("Fecha de Nacimiento: " + this.fechaNacimiento.ToShortDateString());
        }

        protected void Algo()
        {
            //Método protegido
        }

        public override string ToString()
        {
            return "Soy un tipo Persona";
        }
    }
}
