using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN4_Morana_POO.EJ18
{
    public class Producto 
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public int Codigo { get; set; }
        public string Categoria { get; set; }

        public Producto(string nombre, double precio, int stock, int codigo, string categoria)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
            Codigo = codigo;
            Categoria = categoria;
        }

        public override string ToString() // Para mostrar la información del producto
        {
            return $"{Codigo} - {Nombre} - ${Precio} - Stock:{Stock} - {Categoria}";

        }
    }
}