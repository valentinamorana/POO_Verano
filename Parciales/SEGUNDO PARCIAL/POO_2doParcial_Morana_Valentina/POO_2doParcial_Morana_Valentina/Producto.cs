using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2doParcial_Morana_Valentina
{
    public class Producto
    {
        /// <summary>
        /// Clase producto con sus propiedades, constructor sin parámetros y constructor con parámetros.
        /// </summary>

        private int id;  
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string categoria;
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        private decimal precio;
        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        private bool activo;
        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        public Producto() // Constructor sin parámetros para poder crear objetos vacíos y asignar sus propiedades posteriormente
        {
        }

        public Producto(int id, string nombre, string categoria, decimal precio, bool activo) // Constructor con parámetros
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Categoria = categoria;
            this.Precio = precio;
            this.Activo = activo;
        }
    }
}
