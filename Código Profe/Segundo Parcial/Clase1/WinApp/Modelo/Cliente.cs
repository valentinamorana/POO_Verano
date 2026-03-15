using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp.Modelo
{
    internal class Cliente
    {
        #region Atributos
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime FechaAlta { get; set; }

        public List<string> Inscripciones { get; set; }

        #endregion

        #region constructores

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Cliente()
        {

        }

        public Cliente(string nombre)
        {
            this.Nombre = nombre;
        }

        /// <summary>
        /// Constructor que recibe argumentos
        /// </summary>
        /// <param name="Nombre">Doc</param>
        /// <param name="Apellido">Doc</param>
        public Cliente (string nombre, string apellido) : this(nombre)
        {
            this.Apellido = apellido;
        }

        public Cliente(string nombre, string apellido, DateTime fechaAlta) : this(nombre, apellido)
        {
            this.FechaAlta = fechaAlta;
        }

        #endregion


        #region sobrecarga de métodos

        /// <summary>
        /// Registers the client for the specified subject. 
        /// </summary>
        /// <remarks>If no shift is specified, the client is enrolled in the morning shift by
        /// default.</remarks>
        /// <param name="asignatura">The name of the subject to enroll in. Cannot be null or empty.</param>
        public void Inscribir(string asignatura)
        {
            //Si no se pasa el turno, se inscribe en turno mañana por defecto
            Console.WriteLine($"El cliente se inscribió en la asignatura {asignatura}");
            Inscripciones.Add(asignatura + " - Mañana");
        }

        /// <summary>
        /// Registers the client for the specified subject and shift.     
        /// </summary>
        /// <param name="asignatura">Asignatura en cuestión</param>
        /// <param name="turno">Turno en cuestión</param>
        public void Inscribir(string asignatura, string turno)
        {
            Console.WriteLine($"El cliente se inscribió en la asignatura {asignatura} en el turno {turno}");
            Inscripciones.Add(asignatura + " - " + turno);
        }

        public int CantidadInscripciones()
        {
            return Inscripciones.Count;
        }

        public int CantidadInscripciones(int comodin)
        {
            return Inscripciones.Count + comodin;
        }

        public string FullName() => $"{this.Nombre} {this.Apellido}";

        public string FullName(string middleName) => $"{this.Nombre} {middleName} {this.Apellido}";

        public void MostrarInfo() => Console.WriteLine($"Soy un alumno, mi nombre es {this.FullName()} y estoy inscripto en {this.CantidadInscripciones()} asignaturas");
        
        public void MostrarInfo(string middleName) => Console.WriteLine($"Soy un alumno, mi nombre es {this.FullName(middleName)} y estoy inscripto en {this.CantidadInscripciones()} asignaturas");

        #endregion

        override public string ToString()
        {
            return $"Nombre: {this.Nombre}, Apellido: {this.Apellido}";
        }
    }
}
