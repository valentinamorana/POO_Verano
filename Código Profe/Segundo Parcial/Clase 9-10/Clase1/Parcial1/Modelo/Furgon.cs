using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1.Modelo
{
    public class Furgon : Vehiculo
    {
        private const double CostoAdicional = 1000; //Parametrización -> A ver en un par de clases

        private int capacidadCarga;
        public int CapacidadCarga { get { return capacidadCarga; } }

        public Furgon(string patente, double precioBase, int capacidad)
            : base(patente, precioBase)
        {
            this.capacidadCarga = capacidad;
        }

        public override double CalcularCosto(int dias)
        {
            return (PrecioBase * dias) + CostoAdicional;
        }
    }
}
