using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN3_Morana_POO.EJ16
{
    public class SaldoInsuficienteException : Exception // Clase personalizada que hereda de Exception  
    {
        // Llama al constructor de la clase base (Exception) con el mensaje personalizado.
        public SaldoInsuficienteException(string mensaje) : base(mensaje) 
        {
        }
    }
}
