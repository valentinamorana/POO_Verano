using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN4_Morana_POO.EJ19
{
    public class PersonaEJ19 : ICloneable
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public PersonaEJ19(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        // Implementación de ICloneable
        public object Clone()
        {
            return new PersonaEJ19(this.Nombre, this.Edad);
        }

        public override string ToString()
        {
            return $"{Nombre} - Edad: {Edad}";
        }
    }
}
