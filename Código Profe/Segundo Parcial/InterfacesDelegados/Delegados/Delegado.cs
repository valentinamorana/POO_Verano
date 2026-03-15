using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDelegados.Delegados
{
    internal class Delegado
    {
        public delegate int Operacion(int a, int b);
        public Delegado() { }

        public int Sumar(int a, int b)
        {
            return a + b;
        }

        public int Restar(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Dividir(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("No se puede dividir por cero.");
            return a / b;
        }

        public void Operar(Operacion operacion, int a, int b)
        {
            int resultado = operacion(a, b);
            Console.WriteLine($"El resultado de la operación es: {resultado}");
        }
    }
}

