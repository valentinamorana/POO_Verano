using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN1_Morana_POO.EJ3
{
    public class Moto : Vehiculo
    {
        private int cilindrada;

        public int Cilindrada
        {
            get { return cilindrada; }
            set { cilindrada = value; }
        }

        public Moto(string marca, string modelo, int anio, int cilindrada)
            : base(marca, modelo, anio)
        {
            this.cilindrada = cilindrada;
        }

        public override decimal CalcularCostoViaje(int kilometros)
        {
            return kilometros * 5;
        }
    }
}
