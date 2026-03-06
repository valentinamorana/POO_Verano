using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN5_Morana_POO.EJ23
{
    public static class PruebaLambda
    {
        // Ejemplo de uso de expresiones lambda con LINQ
        public static string Ejecutar()
        {
            List<Numero> numeros = new List<Numero>() // Inicialización de la lista de números
            {
                new Numero(5),
                new Numero(10),
                new Numero(15),
                new Numero(20),
                new Numero(25)
            };

            StringBuilder resultado = new StringBuilder();

            // Lambda para filtrar números mayores a 10
            var mayores = numeros.Where(n => n.Valor > 10);

            resultado.AppendLine("Números mayores a 10:");

            foreach (var n in mayores)
                resultado.AppendLine(n.ToString());

            resultado.AppendLine();

            // Lambda para ordenar
            var ordenados = numeros.OrderBy(n => n.Valor);

            resultado.AppendLine("Números ordenados:");

            foreach (var n in ordenados)
                resultado.AppendLine(n.ToString());

            resultado.AppendLine();

            // Lambda para seleccionar solo los valores
            var valores = numeros.Select(n => n.Valor);

            resultado.AppendLine("Solo valores:");

            foreach (var v in valores)
                resultado.AppendLine(v.ToString());

            return resultado.ToString();
        }
    }
}
