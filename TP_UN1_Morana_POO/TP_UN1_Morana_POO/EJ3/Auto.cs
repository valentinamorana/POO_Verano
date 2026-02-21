using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN1_Morana_POO.EJ3
{
    public class Auto : Vehiculo // Auto hereda de Vehiculo, es una clase hija, una subclase.
    {
        private int cantidadPuertas;

        public int CantidadPuertas
        {
            get { return cantidadPuertas; }
            set { cantidadPuertas = value; }
        }

        public Auto(string marca, string modelo, int anio, int puertas) 
            : base(marca, modelo, anio)
        {
            cantidadPuertas = puertas;
        }

        public override decimal CalcularCostoViaje(int kilometros)
        {
            return kilometros * 10;
        }
    }
}
