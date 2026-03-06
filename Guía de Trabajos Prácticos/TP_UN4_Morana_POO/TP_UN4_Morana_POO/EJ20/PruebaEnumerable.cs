using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN4_Morana_POO.EJ20
{
    public static class PruebaEnumerable
    {
        public static string Ejecutar() // Método para ejecutar la prueba de IEnumerable
        {
            // Crear un arreglo de alumnos con sus nombres y notas
            Alumno[] datos =
            {
                new Alumno("Ana",8),
                new Alumno("Carlos",6),
                new Alumno("Lucia",9),
                new Alumno("Pedro",7)
            };

            ListaAlumnos lista = new ListaAlumnos(datos); 

            StringBuilder resultado = new StringBuilder();

            resultado.AppendLine("Listado de alumnos:"); 

            foreach (Alumno a in lista) // Iterar sobre la lista de alumnos utilizando IEnumerable
            {
                resultado.AppendLine(a.ToString()); // Agregar la representación en cadena de cada alumno al resultado
            }

            return resultado.ToString();
        }
    }
}
