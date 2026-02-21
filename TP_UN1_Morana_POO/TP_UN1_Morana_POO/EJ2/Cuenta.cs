using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_UN1_Morana_POO.EJ2;

namespace TP_UN1_Morana_POO.EJ2
{
    public class Cuenta
    {
        private string titular;

        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }

        private decimal saldo;

        public decimal Saldo
        {
            get { return saldo; }
            private set { saldo = value; }
        }

        public Cuenta(string titular, decimal saldoInicial) // Constructor, define el estado inicial.
        {
            this.titular = titular;
            this.saldo = saldoInicial;
        }

        // Métodos, cambio de estado.
        public void Depositar(decimal monto)
        {
            if (monto > 0)
            {
                saldo += monto;
            }
        }

        public void Extraer(decimal monto)
        {
            if (monto > 0 && saldo >= monto)
            {
                saldo -= monto;
            }
        }

        public void Transferir(Cuenta destino, decimal monto)
        {
            if (destino == null) return;
            if (monto <= 0) return;
            if (saldo < monto) return;

            saldo -= monto;
            destino.Depositar(monto);
        }

        public override string ToString() // Método para mostrar el estado de la cuenta.
        {
            return titular + " Saldo actual: " + saldo;
        }
    }
}
