using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDelegados.Interfaces.Framework
{
    internal class Contador : IEnumerable, IEnumerator
    {
        private int actual = 0;
        public int Current => actual;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            actual++;
            //Establecer algún mecanismo de corte
            //Otra opción es pasar como argumento tel Top del contador
            return actual <= 3;
        }

        public void Reset()
        {
            actual = 0;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }
    }
}
