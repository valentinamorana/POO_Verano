using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLinq.Model
{
    internal class ProductoMemoria : IPersistenciaMemoria<Producto>
    {
        private List<Producto> productos = new List<Producto>();
        public void Actualizar(Producto valor)
        {
            Producto productoReferencia = this.Obtener(valor.Codigo);
            productoReferencia.Descripcion = valor.Descripcion;
            productoReferencia.Precio = valor.Precio;
        }

        public void Eliminar(int id)
        {
            Producto productoReferencia = this.Obtener(id);
            productos.Remove(productoReferencia);
        }

        public void Guardar(Producto valor)
        {
            productos.Add(valor);
        }

        public Producto Obtener(int id)
        {
            foreach (var item in productos)
            {
                if (item.Codigo == id && item.Descripcion.StartsWith("a"))
                {
                    return item;
                }
            }
            throw new Exception("Acá debería tener una excepción personalizada");
        }

        public List<Producto> TraerTodos()
        {
            return productos;
        }


        public IEnumerable<Producto> TraerPorPrecioMayor(decimal precio)
        {
            return productos.Where(o => o.Precio >= precio);
        }

        public List<Producto> TraerPorPrecioMenor(decimal precio)
        {
            return null;
        }

        public List<Producto> TraerProductosFechaVencimientoDesdeHasta(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Producto> resultado = new List<Producto>();

            resultado = productos.Where(o => o.FechaVencimiento >= fechaDesde && o.FechaVencimiento <= fechaHasta).ToList();

            return resultado;
        }

        public List<Producto> TraerProductosPorDescripcionOrderBy(string descripcion, bool asc)
        {
            //List<Producto> resultado = new List<Producto>();

            //resultado = productos.Where(o => o.Descripcion.ToLower().Contains(descripcion.ToLower())).ToList();

            //if (asc)
            //{
            //    resultado = resultado.OrderBy(o => o.Precio).ToList();
            //}
            //else
            //{
            //    resultado = resultado.OrderByDescending(o => o.Precio).ToList();
            //}

            List<Producto> resultado = new List<Producto>();

            if (asc)
            {
                resultado = resultado.Where(o => o.Descripcion.ToLower().Contains(descripcion.ToLower())).OrderBy(o => o.Precio).ToList();
            }
            else
            {
                resultado = resultado.Where(o => o.Descripcion.ToLower().Contains(descripcion.ToLower())).OrderByDescending(o => o.Precio).ToList();
            }

            return resultado;
        }

        public List<Producto> TraerProductosOrdenados(bool asc = true)
        {
            List<Producto> resultado = new List<Producto>();

            if (asc)
            {
                resultado = productos.OrderBy(o => o.Precio).ToList();
            }
            else
            {
                resultado = productos.OrderByDescending(o => o.Precio).ToList();
            }

            return resultado;
        }

        public Producto PrimerElemento()
        {
            return productos.FirstOrDefault();
        }

        public List<Producto> Take(int count)
        {
            return productos.Take(count).ToList();
        }

        public decimal PrecioTotal()
        {
            return productos.Sum(o => o.Precio);
        }
    }
}
