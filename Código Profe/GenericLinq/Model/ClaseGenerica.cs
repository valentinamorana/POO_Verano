using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLinq.Model
{
    //Ejemplo de más de un valor "Tipo T"
    //internal class ClaseGenerica<T, X, Z>
    internal class ClaseGenerica<T> 
    {
        //Generic como campo
        private T variable;

        //private X value2;

        //private Z value3;

        //public ClaseGenerica(T valor, X value2, Z value3)
        //{
        //    this.variable = valor;
        //    this.value2 = value2;
        //    this.value3 = value3;
        //}

        public ClaseGenerica(T value)
        {
            this.variable = value;
        }

        public T Variable
        {
            get { return variable; }
            set { variable = value; }
        }

        public void MostrarGenerico(T valor) {

            Console.WriteLine($"Valor recibido por constructor {variable}");
            Console.WriteLine($"Valor recibido por argumento de método: {typeof(T).ToString()}, valor: {valor}");        
        }

        public T GetGenerico() { return variable; }

    }
}
