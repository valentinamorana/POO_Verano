using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN4_Morana_POO.EJ17
{
    public class PruebaOrdenamiento
    {
        public static string Ejecutar() // Método para ejecutar la prueba de ordenamiento
        {
            PersonaEJ17[] personas = new PersonaEJ17[] // Creamos un array de personas con diferentes edades
            {
                new PersonaEJ17("Ana", 30),
                new PersonaEJ17("Carlos", 20),
                new PersonaEJ17("Lucia", 25),
                new PersonaEJ17("Pedro", 35)
            };

            // Ordena usando IComparable
            Array.Sort(personas);

            string resultado = "Personas ordenadas por edad:\n\n";

            foreach (PersonaEJ17 p in personas)
            {
                resultado += p.ToString() + "\n";
            }

            return resultado;
        }
    }
}
