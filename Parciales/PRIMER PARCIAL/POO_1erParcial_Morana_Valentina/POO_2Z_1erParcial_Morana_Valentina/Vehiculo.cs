using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace POO_2Z_1erParcial_Morana_Valentina
{
    public abstract class Vehiculo // abstracta porque no se pueden crear objetos de esta clase, solo de sus clases hijas (Auto y Furgon)
    {
        #region enunciado

        /* Vehiculo(Clase Padre) :

         Atributos: Patente(string) y PrecioBase(double). Ambos deben ser privados.
         Constructor: Debe inicializar la patente y el precio base.
         Propiedades: Solo lectura (get) para ambos atributos.
         Método Abstracto: double CalcularCosto(int dias), que recibirá la cantidad de días de alquiler. */

        #endregion

        // Atributos, solo GET, propiedades de solo lectura
        private string patente;

		public string Patente
        {
			get { return patente; }
			//set { patente = value; }
		}

		private double precioBase;

		public double PrecioBase
        {
			get { return precioBase; }
			//set { precioBase = value; }
		}

        // Constructor
        public Vehiculo(string patente, double precioBase) // Inicializo la patente y el precio base
        {
			this.patente = patente;
			this.precioBase = precioBase;
        }

        // Método abstracto que va a ser implementado por las clases hijas para calcular el costo de alquiler según el tipo de vehículo
        public abstract double CalcularCosto(int dias); 


    }
}
