using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN5_Morana_POO.EJ21
{
    // Clase genérica que puede almacenar cualquier tipo de dato.
    public class ContenedorGenerico<T>
    {
        private T valor; // Campo genérico

        public ContenedorGenerico(T valor) // Constructor genérico
        {
            this.valor = valor;
        }

        // Método genérico 1
        public void MostrarValor()
        {
            Console.WriteLine("Valor almacenado: " + valor);
        }

        // Método genérico 2
        public T ObtenerValor()
        {
            return valor;
        }

        // Método genérico adicional
        public void CambiarValor(T nuevoValor)
        {
            valor = nuevoValor;
        }
    }
}
