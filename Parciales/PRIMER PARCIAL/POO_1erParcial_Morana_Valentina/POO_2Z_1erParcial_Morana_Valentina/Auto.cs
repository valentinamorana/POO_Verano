using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2Z_1erParcial_Morana_Valentina
{
    public class Auto : Vehiculo
    {
        #region
        /*Auto (Clase Hija):

        Cálculo de Costo: PrecioBase * dias.*/
        #endregion
       
        // Constructor que recibe patente y precio base, y llama al constructor de la clase base para inicializar los atributos heredados
        public Auto(string patente, double precioBase) : base(patente, precioBase)
        {
        }

        // Método que calcula el costo de alquiler del auto
        public override double CalcularCosto(int dias)
        {
            return PrecioBase * dias;
        }
    }
}
