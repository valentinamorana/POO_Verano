using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN3_Morana_POO.EJ16
{
    public static class PruebaErrorPersonalizado
    {
        public static string Ejecutar() // Método que realiza la prueba del error personalizado
        {
            try
            {
                CuentaBancaria cuenta = new CuentaBancaria(100); // crea una cuenta con un saldo inicial de 100

                cuenta.Retirar(200); // fuerza el error

                return "Operación realizada correctamente.";
            }

            catch (SaldoInsuficienteException ex) // captura la excepción personalizada
            {
                return ex.Message;
            }
        }
    }
}
