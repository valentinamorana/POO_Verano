using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp.Modelo.Polimorfismo
{
    internal class Triangulo : Figura
    {
        public double Lado { get; set; }
        public Triangulo(int x, int y, double lado) : base(x, y)
        {
            this.Lado = lado;   
        }

        public override double Area()
        {
            return (Lado * Lado) / 2;
        }

        public override int Perimetro()
        {
            return (int)(3 * Lado);
        }

        public override string Descripcion()
        {
            return "Soy un triángulo: " + base.Descripcion();
        }
    }
}
