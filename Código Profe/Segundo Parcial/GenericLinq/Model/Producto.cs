using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLinq.Model
{
    internal class Producto
    {
        public int Codigo { get; set; }

        public string Descripcion { get; set; }

        public decimal Precio { get; set; }

        public DateTime FechaVencimiento { get; set; }
    }
}
