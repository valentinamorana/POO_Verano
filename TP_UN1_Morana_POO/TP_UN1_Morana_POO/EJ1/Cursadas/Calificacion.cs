using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_UN1_Morana_POO.EJ1.Personas;

namespace TP_UN1_Morana_POO.EJ1.Cursadas
{
    public class Calificacion
    {
        private float nota;

        public float Nota
        {
            get { return nota; }
            set { nota = value; }
        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private string observacion;

        public string Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }

        public Calificacion(float nota, DateTime fecha, string observacion)
        {
            this.Nota = nota;
            this.Fecha = fecha;
            this.Observacion = observacion;
        }

        public bool Aprobo()
        {
            return this.Nota >= 4;
        }
    }
}
