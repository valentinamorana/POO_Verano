using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN5_Morana_POO.EJ21
{
    public static class PruebaGenericos
    {
        // Este método demuestra el uso de la clase genérica ContenedorGenerico con diferentes tipos de datos.
        public static string Ejecutar()
        {
            StringBuilder resultado = new StringBuilder();

            // Uso con int
            ContenedorGenerico<int> contInt = new ContenedorGenerico<int>(10);
            resultado.AppendLine("Valor int: " + contInt.ObtenerValor());

            // Uso con string
            ContenedorGenerico<string> contString = new ContenedorGenerico<string>("Hola");
            resultado.AppendLine("Valor string: " + contString.ObtenerValor());

            // Cambiar valor
            contInt.CambiarValor(50);
            resultado.AppendLine("Nuevo valor int: " + contInt.ObtenerValor());

            return resultado.ToString();
        }
    }
}
