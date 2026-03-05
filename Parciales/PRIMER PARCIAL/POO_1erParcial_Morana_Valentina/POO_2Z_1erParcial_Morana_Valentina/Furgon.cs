using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2Z_1erParcial_Morana_Valentina
{
    public class Furgon : Vehiculo
    {
        #region enunciado
        
        /* Furgon (Clase Hija):

        Atributo Adicional: CapacidadCarga (int).
        Cálculo de Costo: (PrecioBase * dias) + 1000. (Tiene un recargo fijo de $1000 por ser vehículo de carga).*/
        
        #endregion

        // Atributo adicional
        private int capacidadCarga;

        public int CapacidadCarga
        {
			get { return capacidadCarga; }
			set { capacidadCarga = value; }
		}

        // Constructor que recibe patente, precio base y capacidad de carga, y llama al constructor de la clase base para inicializar los atributos heredados
        public Furgon(string patente, double precioBase, int capacidadCarga) : base(patente, precioBase)
		{
			this.capacidadCarga = capacidadCarga;
        }

        // Método que calcula el costo de alquiler del furgón
        public override double CalcularCosto(int dias) // sobrescribe un método abstracto heredado de la clase base
        {
            return (PrecioBase * dias) + 1000; //hardcode
        }
    }
}