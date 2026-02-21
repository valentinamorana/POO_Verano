using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_UN1_Morana_POO.EJ1.Personas;
using TP_UN1_Morana_POO.EJ1.Cursadas;


namespace TP_UN1_Morana_POO.EJ1.Universidades
{
    public class Comision
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private Materia materia;

        public Materia Materia
        {
            get { return materia; }
            set { materia = value; }
        }

        private Profesor profesorResponsable;

        public Profesor ProfesorResponsable
        {
            get { return profesorResponsable; }
            set { profesorResponsable = value; }
        }

        public Comision(string nombre, Materia materia, Profesor profesorResponsable)
        {
            this.Nombre = nombre;
            this.Materia = materia;
            this.ProfesorResponsable = profesorResponsable;
        }
    }
}
