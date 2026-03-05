using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN3_Morana_POO.EJ15
{
    public class Calculadora
    {
        public static string Ejecutar(string textoNumero, int divisor, int indice)
        {
            string resultado = ""; // Variable para almacenar el resultado o mensaje de error.

            // El método intenta realizar varias operaciones que pueden lanzar diferentes excepciones.
            try
            {
                // 1 Posible FormatException
                int numero = int.Parse(textoNumero);

                // 2 Posible DivideByZeroException
                int division = numero / divisor;

                // 3 Posible OverflowException
                int multiplicacion = checked(numero * 1000000000);

                // 4 Posible NullReferenceException
                string texto = null;
                int largo = texto.Length;

                // 5 Posible IndexOutOfRangeException
                int[] arreglo = { 1, 2, 3 };
                int valor = arreglo[indice];

                resultado = "Resultado final: " + division;
            }

            catch (FormatException)
            {
                resultado = "Error: el valor ingresado no es un número válido.";
            }

            catch (DivideByZeroException)
            {
                resultado = "Error: no se puede dividir por cero.";
            }

            catch (OverflowException)
            {
                resultado = "Error: el número es demasiado grande.";
            }

            catch (NullReferenceException)
            {
                resultado = "Error: se intentó usar un objeto que es null.";
            }

            catch (IndexOutOfRangeException)
            {
                resultado = "Error: índice fuera de rango.";
            }

            finally // El bloque finally se ejecuta siempre, independientemente de si se lanzó una excepción o no.
            {
                resultado += "\nFinally ejecutado: limpieza o cierre de recursos.";
            }

            return resultado;
        }
    }
}
