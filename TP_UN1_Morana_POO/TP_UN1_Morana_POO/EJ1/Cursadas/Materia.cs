using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN1_Morana_POO.EJ1.Cursadas
{
    public class Materia
    {
        private string codigo;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string nombreMateria;

        public string NombreMateria
        {
            get { return nombreMateria; }
            set { nombreMateria = value; }
        }

        private int anio;

        public int Anio
        {
            get { return anio; }
            set { anio = value; }
        }

        private int cuatrimestre;

        public int Cuatrimestre
        {
            get { return cuatrimestre; }
            set { cuatrimestre = value; }
        }

        public Materia(string codigo, string nombre, int anio, int cuatrimestre)
        {
            this.Codigo = codigo;
            this.NombreMateria = nombre;
            this.Anio = anio;
            this.Cuatrimestre = cuatrimestre;
        }
    }
}
