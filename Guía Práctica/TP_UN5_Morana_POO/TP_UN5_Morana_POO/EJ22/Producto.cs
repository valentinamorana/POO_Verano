using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN5_Morana_POO.EJ22
{
    public class Producto
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }

        public Producto(int codigo, string nombre, double precio, int stock)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }

        public override string ToString() // Sobrescribe el método ToString para mostrar la información del producto de manera legible.
        {
            return $"{Codigo} - {Nombre} - ${Precio} - Stock:{Stock}";
        }
    }
}
