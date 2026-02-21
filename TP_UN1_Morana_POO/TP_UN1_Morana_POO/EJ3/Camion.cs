using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN1_Morana_POO.EJ3
{
    public class Camion : Vehiculo
    {
        private decimal capacidadCarga;

        public decimal CapacidadCarga
        {
            get { return capacidadCarga; }
            set { capacidadCarga = value; }
        }

        public Camion(string marca, string modelo, int anio, decimal capacidad)
            : base(marca, modelo, anio)
        {
            capacidadCarga = capacidad;
        }

        public override decimal CalcularCostoViaje(int kilometros)
        {
            return kilometros * 20;
        }
    }
}
