using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_UN1_Morana_POO.EJ1.Cursadas;

namespace TP_UN1_Morana_POO.EJ1.Personas
{
    public class Profesor : Persona
    {
		private string numeroEmpleado;

		public string NumeroEmpleado
        {
			get { return numeroEmpleado; }
			set { numeroEmpleado = value; }
		}

		private string cargoProfesor;

		public string CargoProfesor
        {
			get { return cargoProfesor; }
			set { cargoProfesor = value; }
		}

		public Profesor(int id, string nombre, string apellido, int documento, string email, string numeroEmpleado, string cargoProfesor)
			: base(id, nombre, apellido, documento, email)
		{
			this.NumeroEmpleado = numeroEmpleado;
			this.CargoProfesor = cargoProfesor;
        }

        public void AsignarCalificacion(Cursada cursada, float nota, string observacion)
        {
            cursada.Calificacion = new Calificacion(nota, DateTime.Now, observacion);
        }
    }
}
