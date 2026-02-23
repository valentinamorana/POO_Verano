using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN2_Morana_POO.EJ1
{
    public abstract class Persona
    {
        private int legajo;

        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }

        private string nombre;

        public string Nombre
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
        
        // Constructor 1 (por defecto)
        // Se usa cuando no tengo datos y quiero valores "iniciales"
        public Persona()
        {
            legajo = 0;
            nombre = "Sin nombre";
            apellido = "Sin apellido";
        }

        // Constructor 2 (sobrecargado)
        public Persona(int legajo, string nombre, string apellido) // Constructor para inicializar los atributos de la clase Persona.
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
        }


    }
}
