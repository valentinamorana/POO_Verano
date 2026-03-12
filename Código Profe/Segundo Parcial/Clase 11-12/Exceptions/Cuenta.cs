using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Cuenta
    {
        private double saldo;

        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                saldo = value;
                if(saldo < 0) //Regla de negocio -> El saldo no puede ser negativo
                {
                    throw new SaldoNegativoException(this);
                }
            }
        }
    }
}
