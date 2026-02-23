using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN2_Morana_POO.EJ2
{
    public abstract class Persona
    {
        private int legajo;

        public int Legajo //solo lectura, no se puede modificar el legajo una vez asignado
        {
            get { return legajo; }
        }

        private string nombre;

        public string Nombre //lectura-escritura, se puede modificar el nombre después de asignarlo
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public Persona(int legajo, string nombre, string apellido)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }
}
