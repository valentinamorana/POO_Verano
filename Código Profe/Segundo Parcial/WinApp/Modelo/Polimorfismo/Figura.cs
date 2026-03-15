using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp.Modelo
{
    abstract class Figura
    {
        private int x; 
        
        private int y;

        public int X { get => x; }

        public int Y { get => y; }

        protected Figura(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public abstract double Area();

        public abstract int Perimetro();

        virtual public string Descripcion()
        {
            return $"Figura en posición ({x}, {y})";
        }
    }
}
