using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_UN1_Morana_POO.EJ1.Personas;
using TP_UN1_Morana_POO.EJ1.Cursadas;

namespace TP_UN1_Morana_POO.EJ1.Universidades
{
    public class Universidad
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private List<Alumno> alumnos;

        public List<Alumno> Alumnos
        {
            get { return alumnos; }
        }

        private List<Profesor> profesores;

        public List<Profesor> Profesores
        {
            get { return profesores; }
        }

        // Constructor para inicializar el nombre de la universidad y las listas de alumnos y profesores.
        public Universidad(string nombre)
        {
            this.Nombre = nombre;
            this.alumnos = new List<Alumno>();
            this.profesores = new List<Profesor>();
        }

        public void RegistrarAlumno(Alumno alumno) // Método para registrar un nuevo alumno en la universidad.
        {
            alumnos.Add(alumno);
        }

        public void RegistrarProfesor(Profesor profesor)
        {
            profesores.Add(profesor);
        }

        // Métodos para buscar alumnos y profesores por sus identificadores únicos (ID, legajo, número de empleado).
        public Alumno BuscarAlumnoPorId(int id)
        {
            foreach (Alumno a in alumnos)
            {
                if (a.Id == id)
                    return a;
            }
            return null;
        }

        public Alumno BuscarAlumnoPorLegajo(string legajo)
        {
            foreach (Alumno a in alumnos)
            {
                if (a.Legajo == legajo)
                    return a;
            }
            return null;
        }

        public Profesor BuscarProfesorPorId(int id)
        {
            foreach (Profesor p in profesores)
            {
                if (p.Id == id)
                    return p;
            }
            return null;
        }

        public Profesor BuscarProfesorPorNumeroEmpleado(string numeroEmpleado)
        {
            foreach (Profesor p in profesores)
            {
                if (p.NumeroEmpleado == numeroEmpleado)
                    return p;
            }
            return null;
        }
    }
}
