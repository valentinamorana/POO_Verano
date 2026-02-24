using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace WinApp.Modelo.Polimorfismo
{
    internal class Rectangulo : Figura
    {
        public double Base { get; set; }

        public double Altura { get; set; }

        public Rectangulo(int x, int y, int _base, int altura) : base(x, y)
        {
            this.Base = _base;
            this.Altura = altura;
        }
        public override double Area()
        {
            return this.Base * this.Altura;
        }

        public override int Perimetro()
        {
            return (int)(Base * 2) + (int)(Altura * 2);
        }
    }
}
