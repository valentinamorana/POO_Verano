using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN4_Morana_POO.EJ17
{
    public class PersonaEJ17 : IComparable
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public PersonaEJ17(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        // Implementación de IComparable
        public int CompareTo(object obj)
        {
            PersonaEJ17 otra = (PersonaEJ17)obj; 

            // Ordena por edad
            return this.Edad.CompareTo(otra.Edad);
        }

        public override string ToString() // Para mostrar la información de la persona1
        {
            return Nombre + " - Edad: " + Edad;
        }
    }
}
