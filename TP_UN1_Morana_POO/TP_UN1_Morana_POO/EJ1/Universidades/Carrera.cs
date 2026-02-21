using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_UN1_Morana_POO.EJ1.Cursadas;

namespace TP_UN1_Morana_POO.EJ1.Universidades
{
    public class Carrera
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int duracionAnios;

        public int DuracionAnios
        {
            get { return duracionAnios; }
            set { duracionAnios = value; }
        }

        private List<Materia> materias;

        public List<Materia> Materias
        {
            get { return materias; }
        }

        public Carrera(string nombre, int duracionAnios)
        {
            this.Nombre = nombre;
            this.DuracionAnios = duracionAnios;
            this.materias = new List<Materia>();
        }

        public void AgregarMateria(Materia materia)
        {
            materias.Add(materia);
        }

        public Materia BuscarMateriaPorCodigo(string codigo)
        {
            foreach (Materia m in materias)
            {
                if (m.Codigo == codigo)
                    return m;
            }
            return null;
        }
    }
}
