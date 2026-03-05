using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN4_Morana_POO.EJ20
{
    public class EnumeradorAlumnos : IEnumerator
    {
        /// Clase que implementa el enumerador para recorrer la lista de alumnos
        private Alumno[] alumnos;
        private int posicion = -1;

        // Constructor que recibe el arreglo de alumnos a enumerar
        public EnumeradorAlumnos(Alumno[] alumnos)
        {
            this.alumnos = alumnos;
        }

        public object Current // Devuelve el alumno actual en la posición del enumerador
        {
            get { return alumnos[posicion]; }
        }

        public bool MoveNext() // Avanza a la siguiente posición del enumerador y devuelve true si hay más elementos, o false si se ha llegado al final
        {
            posicion++;
            return (posicion < alumnos.Length); // Verifica si la nueva posición es válida
        }

        public void Reset() // Reinicia el enumerador a su posición inicial (antes del primer elemento)
        {
            posicion = -1;
        }
    }
}
