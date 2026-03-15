using GenericLinq.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Uso de interfaces con generics
            ProductoMemoria productoMemoria = new ProductoMemoria();

            Producto productoA = new Producto() { Codigo = 1, Descripcion = "Producto A", Precio = 10.0m };
            Producto productoB = new Producto() { Codigo = 2, Descripcion = "Producto B", Precio = 20.0m };
            Producto productoC = new Producto() { Codigo = 3, Descripcion = "Producto C", Precio = 30.0m };
            Producto productoD = new Producto() { Codigo = 4, Descripcion = "Producto D", Precio = 40.0m };


            productoMemoria.Guardar(productoA);
            productoMemoria.Guardar(productoB);
            productoMemoria.Guardar(productoC);
            productoMemoria.Guardar(productoD);

            foreach (var item in productoMemoria.TraerPorPrecioMayor(20.0m))
            {
                Console.WriteLine($"Codigo: {item.Codigo} - Descripcion: {item.Descripcion} - Precio: {item.Precio}");
            }

            Producto primerProduto = productoMemoria.PrimerElemento();

            Console.WriteLine(primerProduto);

            foreach (var item in productoMemoria.TraerTodos())
            {
                Console.WriteLine($"Codigo: {item.Codigo} - Descripcion: {item.Descripcion} - Precio: {item.Precio}");
            }

            productoMemoria.Eliminar(1);

            foreach (var item in productoMemoria.TraerTodos())
            {
                Console.WriteLine($"Codigo: {item.Codigo} - Descripcion: {item.Descripcion} - Precio: {item.Precio}");
            }

            productoB.Descripcion = "Producto Z";
            productoMemoria.Actualizar(productoB);

            foreach (var item in productoMemoria.TraerTodos())
            {
                Console.WriteLine($"Codigo: {item.Codigo} - Descripcion: {item.Descripcion} - Precio: {item.Precio}");
            }






            //ClaseGenerica<string,int, double> claseGenerica = new ClaseGenerica<string, int, double>("valor constructor", 0, 0.0);

            ClaseGenerica<string> claseGenerica = new ClaseGenerica<string>("valor constructor");
            claseGenerica.MostrarGenerico("valor metodo");
            claseGenerica.Variable = "valor propiedad";
            Console.WriteLine($"Mostrando valor de propiedad {claseGenerica.Variable}");
            string returnString = claseGenerica.GetGenerico();
            Console.WriteLine(returnString);


            ClaseGenerica<bool> claseGenericaBool = new ClaseGenerica<bool>(true);
            claseGenericaBool.Variable = false;
            claseGenericaBool.MostrarGenerico(true);

            ClaseGenerica<List<string>> claseGenericaList = new ClaseGenerica<List<string>>(new List<string>() { "valor1", "valor2" });
            claseGenericaList.MostrarGenerico(new List<string>() { "valor3", "valor4" });







        }
    }
}
