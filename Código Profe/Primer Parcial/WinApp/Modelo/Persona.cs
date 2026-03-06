using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp.Modelo
{
    internal class Persona
    {
        public string Dni { get; set; }

        public DateTime FechaAlta { get; set; }

        /// <summary>
        /// Una persona sí o sí requiere un dni para su creación
        /// </summary>
        /// <param name="dni">Enviar DNI argentino</param>
        public Persona(string dni)
        {
            this.Dni = dni;
        }

        public Persona(string dni, DateTime fechaAlta) : this(dni)
        {
            this.FechaAlta = fechaAlta;
        }

        //public Persona()
        //{

        //}
    }
}
