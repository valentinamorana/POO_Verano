using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN4_Morana_POO.EJ18
{
    public static class PruebaArray
    {
        public static string Ejecutar() // Método para ejecutar la prueba de ordenamiento de productos
        {
            // Crear un array de productos con diferentes atributos
            Producto[] productos =
            {
                new Producto("Mouse", 25, 10, 1001, "Perifericos"),
                new Producto("Teclado", 40, 5, 1002, "Perifericos"),
                new Producto("Monitor", 200, 3, 1003, "Pantallas"),
                new Producto("Notebook", 900, 2, 1004, "Computadoras"),
                new Producto("Auriculares", 50, 8, 1005, "Audio")
            };

            string resultado = "";

            // Orden por nombre
            Array.Sort(productos, new CompararPorNombre());
            resultado += "Orden por Nombre:\n";
            foreach (var p in productos) resultado += p + "\n";

            resultado += "\n";

            // Orden por precio
            Array.Sort(productos, new CompararPorPrecio());
            resultado += "Orden por Precio:\n";
            foreach (var p in productos) resultado += p + "\n";

            resultado += "\n";

            // Orden por stock
            Array.Sort(productos, new CompararPorStock());
            resultado += "Orden por Stock:\n";
            foreach (var p in productos) resultado += p + "\n";

            resultado += "\n";

            // Orden por código
            Array.Sort(productos, new CompararPorCodigo());
            resultado += "Orden por Codigo:\n";
            foreach (var p in productos) resultado += p + "\n";

            resultado += "\n";

            // Orden por categoría
            Array.Sort(productos, new CompararPorCategoria());
            resultado += "Orden por Categoria:\n";
            foreach (var p in productos) resultado += p + "\n";

            return resultado;
        }
    }
}
