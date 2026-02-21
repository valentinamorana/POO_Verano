using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_UN1_Morana_POO.EJ1.Personas;
using TP_UN1_Morana_POO.EJ1.Universidades;

namespace TP_UN1_Morana_POO.EJ1.Cursadas
{
    public class Cursada
    {
        private Materia materia;

        public Materia Materia
        {
            get { return materia; }
            set { materia = value; }
        }

        private string comision;

        public string Comision
        {
            get { return comision; }
            set { comision = value; }
        }

        private Calificacion calificacion;

        public Calificacion Calificacion
        {
            get { return calificacion; }
            set { calificacion = value; }
        }

        public Cursada(Materia materia, string comision)
        {
            this.Materia = materia;
            this.Comision = comision;
            this.Calificacion = null;
        }

        public bool Aprobo()
        {
            if (Calificacion == null)
                return false;

            return Calificacion.Aprobo();
        }
    }
}
