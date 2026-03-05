using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN2_Morana_POO.EJ11
{
    public abstract class PersonaEJ11
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        // CONSTRUCTOR BASE
        public PersonaEJ11(string nombre)
        {
            this.nombre = nombre;
            Console.WriteLine($"[BASE CTOR] Persona creada: {this.nombre}");
        }

        // FINALIZADOR (DESTRUCTOR) BASE
        ~PersonaEJ11()
        {
            Console.WriteLine($"[BASE FINALIZER] Persona finalizada: {nombre}");
        }

        public virtual string Describir()
        {
            return $"Persona: {nombre}";
        }
    }
}
