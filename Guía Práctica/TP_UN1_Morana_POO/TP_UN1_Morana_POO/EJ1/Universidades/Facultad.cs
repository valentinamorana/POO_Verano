using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN1_Morana_POO.EJ1.Universidades
{
    public class Facultad
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private List<Carrera> carreras; // Lista de carreras que ofrece la facultad.

        public List<Carrera> Carreras
        {
            get { return carreras; }
        }

        public Facultad(string nombre)
        {
            this.Nombre = nombre;
            this.carreras = new List<Carrera>();
        }

        public void AgregarCarrera(Carrera carrera) // Agrega una carrera a la lista de carreras de la facultad.
        {
            carreras.Add(carrera);
        }

        public Carrera BuscarCarreraPorNombre(string nombreCarrera)
        {
            foreach (Carrera c in carreras) // Recorre la lista de carreras: "Buscá dentro de la facultad una carrera que tenga este nombre y devolvela."
            {
                if (c.Nombre == nombreCarrera)
                    return c;
            }
            return null;
        }

    }
}
