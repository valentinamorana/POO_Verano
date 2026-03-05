using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN4_Morana_POO.EJ19
{
    public static class PruebaClone
    {
        public static string Ejecutar() // Método para ejecutar la prueba de clonación de objetos
        {
            PersonaEJ19 original = new PersonaEJ19("Valentina", 23);

            // Clonamos el objeto
            PersonaEJ19 clon = (PersonaEJ19)original.Clone();

            string resultado = "";

            // Mostramos los detalles del objeto original y del objeto clonado
            resultado += "Objeto original:\n";
            resultado += original.ToString() + "\n\n";

            resultado += "Objeto clonado:\n";
            resultado += clon.ToString() + "\n\n";

            resultado += "¿Son el mismo objeto? ";

            resultado += ReferenceEquals(original, clon); // Verificamos si el objeto original y el clonado son el mismo objeto en memoria

            // son los mimsos datos pero el objeto es diferente, por lo tanto el resultado es false

            return resultado;
        }
    }
}
