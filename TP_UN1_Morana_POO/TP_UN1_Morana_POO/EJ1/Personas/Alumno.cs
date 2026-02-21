using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_UN1_Morana_POO.EJ1.Cursadas;

namespace TP_UN1_Morana_POO.EJ1.Personas
{
	public class Alumno : Persona
	{
		private string legajo;

		public string Legajo
		{
			get { return legajo; }
			set { legajo = value; }
		}

		private DateTime fechaIngreso;

		public DateTime FechaIngreso
		{
			get { return fechaIngreso; }
			set { fechaIngreso = value; }
		}

        private List<Cursada> cursadas; // Lista interna donde el alumno guarda todas sus materias cursadas.

        public List<Cursada> Cursadas
        {
            get { return cursadas; }
            set { cursadas = value; }
        }

		public Alumno(int id, string nombre, string apellido, int documento, string email, string legajo, DateTime fechaIngreso)	
			: base(id, nombre, apellido, documento, email)
        {
			this.Legajo = legajo;
			this.FechaIngreso = fechaIngreso;
			this.Cursadas = new List<Cursada>(); // Inicializamos la lista de cursadas vacía.
        }

        public void Inscribirse(Materia materia, string comision)
        {
            Cursada nueva = new Cursada(materia, comision);
            cursadas.Add(nueva);
        }

    }
}
