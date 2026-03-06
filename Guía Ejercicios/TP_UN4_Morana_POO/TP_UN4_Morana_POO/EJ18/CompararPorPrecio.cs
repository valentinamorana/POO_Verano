using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN4_Morana_POO.EJ18
{
    public class CompararPorPrecio : IComparer<Producto>
    {
        public int Compare(Producto x, Producto y)
        {
            return x.Precio.CompareTo(y.Precio);
        }
    }
}
