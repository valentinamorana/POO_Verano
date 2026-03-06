using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN1_Morana_POO.EJ3
{
    public abstract class Vehiculo
    {
		private string marca;

		public string Marca
		{
			get { return marca; }
			set { marca = value; }
		}

        private string modelo;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private int anio;
        public int Anio
        {
            get { return anio; }
            set { anio = value; }
        }

        public Vehiculo(string marca, string modelo, int anio)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Anio = anio;
        }

        public abstract decimal CalcularCostoViaje(int kilometros); // Método abstracto, sin implementación, cada clase hija lo implementará a su manera.
    }
}
