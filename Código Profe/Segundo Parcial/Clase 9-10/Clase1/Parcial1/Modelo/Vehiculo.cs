using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1.Modelo
{
    public abstract class Vehiculo
    {
        private string patente;

        private double precioBase;

        public string Patente { get { return patente; } }
        public double PrecioBase { get { return precioBase; } }

        protected Vehiculo(string patente, double precioBase)
        {
            this.patente = patente;
            this.precioBase = precioBase;
        }

        public abstract double CalcularCosto(int dias);
    }
}
