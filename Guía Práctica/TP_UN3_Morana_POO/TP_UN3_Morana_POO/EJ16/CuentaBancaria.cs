using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN3_Morana_POO.EJ16
{
    public class CuentaBancaria
    {
        public double Saldo { get; private set; }

        public CuentaBancaria(double saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public void Retirar(double monto) // Método que intenta retirar un monto del saldo
        {
            if (monto > Saldo)
            {
                throw new SaldoInsuficienteException( // Lanza una excepción personalizada si el monto a retirar es mayor que el saldo disponible
                    "Error: saldo insuficiente para realizar la operación."
                );
            }

            Saldo -= monto; // Si el monto es menor o igual al saldo, se realiza el retiro restando el monto al saldo actual
        }
    }
}
