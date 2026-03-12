using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDelegados.Interfaces.Framework
{
    internal class Persona : IComparable<Persona>
    {
        public string Nombre { get; set; }

        public int Edad { get; set; }
        public int CompareTo(Persona other)
        {
            return String.Compare(this.Nombre, other.Nombre);
        }

        public class PersonaAsc : IComparer<Persona>
        {
            public int Compare(Persona x, Persona y)
            {
                return String.Compare(x.Nombre, y.Nombre);
            }
        }

        public class PersonaDesc : IComparer<Persona>
        {
            public int Compare(Persona x, Persona y)
            {
                return String.Compare(y.Nombre, x.Nombre);
            }
        }
    }
}
