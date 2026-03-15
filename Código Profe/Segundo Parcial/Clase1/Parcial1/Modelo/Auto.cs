using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1.Modelo
{
    public class Auto : Vehiculo
    {
        public Auto(string patente, double precioBase) : base(patente, precioBase) { }

        public override double CalcularCosto(int dias)
        {
            return PrecioBase * dias;
        }
    }
}
