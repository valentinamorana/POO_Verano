using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN5_Morana_POO.EJ22
{
    public static class PruebaLINQ
    {
        // Este método demuestra el uso de LINQ para realizar consultas sobre una lista de productos.
        public static string Ejecutar()
        {
            List<Producto> productos = new List<Producto>() // Creamos una lista de productos con algunos datos de ejemplo
            {
                new Producto(1,"Mouse",25,10),
                new Producto(2,"Teclado",40,5),
                new Producto(3,"Monitor",200,3),
                new Producto(4,"Notebook",900,2),
                new Producto(5,"Auriculares",50,8)
            };

            StringBuilder resultado = new StringBuilder();

            // Consulta 1: productos con precio mayor a 50
            var caros = from p in productos
                        where p.Precio > 50
                        select p;

            resultado.AppendLine("Productos con precio > 50:");

            foreach (var p in caros)
                resultado.AppendLine(p.ToString());

            resultado.AppendLine();

            // Consulta 2: ordenar por precio
            var ordenados = from p in productos
                            orderby p.Precio
                            select p;

            resultado.AppendLine("Productos ordenados por precio:");
          
            // Recorremos la lista de productos ordenados y los agregamos al resultado
            foreach (var p in ordenados)
                resultado.AppendLine(p.ToString());

            resultado.AppendLine();

            // Consulta 3: solo nombres
            var nombres = from p in productos
                          select p.Nombre;

            resultado.AppendLine("Solo nombres:");

            // Recorremos la lista de nombres y los agregamos al resultado
            foreach (var n in nombres) 
                resultado.AppendLine(n);

            return resultado.ToString();
        }
    }
}
