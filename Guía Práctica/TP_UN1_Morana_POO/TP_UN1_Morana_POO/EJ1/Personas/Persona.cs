using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_UN1_Morana_POO.EJ1.Cursadas;

namespace TP_UN1_Morana_POO.EJ1.Personas
{
    public abstract class Persona
    {
        /// Clase abstracta base para Profesor y Alumno, con propiedades comunes como Nombre, DNI, etc. 
        /// Abstracta porque no se pueden crear instancias de Persona, solo de sus subclases Profesor y Alumno.

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
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


        private int documento;

        public int Documento
        {
            get { return documento; }
            set { documento = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        /// Constructor para inicializar las propiedades comunes de Persona.
        public Persona(int id, string nombre, string apellido, int documento, string email)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Documento = documento;
            this.Email = email;
        }
    }
}
