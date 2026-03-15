using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 10;
                int c = a / b;
                Console.WriteLine($"La división es: {c}");

                Cuenta cuenta_a = new Cuenta();
                cuenta_a.Saldo = 100.0;
                Console.WriteLine($"Cuenta con saldo positivo ${cuenta_a.Saldo}");

                cuenta_a.Saldo -= 150.0; // Esto hará que el saldo de la cuenta sea negativo, lo que lanzará una excepción de saldo negativo

                //ExcepcionControlada();
            }
            catch(SaldoNegativoException ex)
            {
                Console.WriteLine($"Mensaje: {ex.Message}");
                Console.WriteLine($"Cuenta con saldo negativo: {ex.Cuenta.Saldo}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Mensaje: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Mensaje: {ex.Message}");
            }
            //El resto de excepciones se atajarían aquí
            catch (Exception ex)
            {
                Console.WriteLine($"Mensaje: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
            }
            finally
            {
                Console.WriteLine("Esto se ejecuta siempre. Falle o no falle el código del try");
            }
        }

		private static void ExcepcionControlada()
		{

            int a = 10;
            int b = 0;
            int c = a / b; // Esto lanzará una excepción de división por cero
            Console.WriteLine(c);
            Console.ReadLine();


            /*try
            {
                int a = 10;
                int b = 0;
                int c = a / b; // Esto lanzará una excepción de división por cero
                Console.WriteLine(c);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                //Hago un tratamiento y no la propago
                Console.WriteLine($"Mensaje en método ExcepcionControlada: {ex.Message}");
                //El throw sin argumentos vuelve a lanzar la misma excepción que se acaba de capturar, pero sin perder la información original (como el stack trace).
                //throw;
            }*/
        }
    }
}
