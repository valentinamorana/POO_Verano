using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class SaldoNegativoException : Exception
    {
        private Cuenta cuenta;

        public SaldoNegativoException(Cuenta cuenta)
        {
            this.cuenta = cuenta;
        }

        public Cuenta Cuenta
        {
            get
            {
                return cuenta;
            }
        }
        override public string Message
        {
            get
            {
                return "El saldo no puede ser negativo";
            }
        }
    }
}
