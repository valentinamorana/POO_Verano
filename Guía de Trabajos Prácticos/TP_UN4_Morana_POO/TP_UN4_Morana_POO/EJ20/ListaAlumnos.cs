using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN4_Morana_POO.EJ20
{
    // Clase que implementa IEnumerable para permitir la iteración sobre una colección de alumnos
    public class ListaAlumnos : IEnumerable
    {
        private Alumno[] alumnos;

        public ListaAlumnos(Alumno[] alumnos) // Constructor que recibe un arreglo de alumnos para inicializar la colección
        {
            this.alumnos = alumnos;
        }

        public IEnumerator GetEnumerator() // Devuelve un enumerador que permite iterar sobre la colección de alumnos
        {
            return new EnumeradorAlumnos(alumnos);
        }
    }
}
