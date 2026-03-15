using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp.Modelo.Interfaces
{
    internal class Drone : Robot, IVolador, ICloneable
    {
        public int Codigo { get; set; }

        public int Potencia { get; set; }

        public Fabricante Fabricante { get; set; }

        public object Clone()
        {
            //Forma superficial de clonar un objeto, es decir, se clona el objeto pero no sus referencias
            //return this.MemberwiseClone();

            //Mejora para clonación profunda
            var droneClonado = (Drone)this.MemberwiseClone();

            //Clonamos el objeto Fabricante para que el nuevo drone tenga su propia instancia de Fabricante
            if(Fabricante != null)
            {
                droneClonado.Fabricante = (Fabricante)Fabricante.Clone();
            }
            return droneClonado;
        }

        public void Volar()
        {
            Console.WriteLine("Soy un robot de tipo drone y estoy volando...");
        }
    }
}

//objetoA -> Drone 123, 3000, Objeto: Fabricante (4, "DJI")

//De manera nativa cuando hacemos una asignación entre objetos, lo que se asigna es la referencia, no el valor.
//Es decir, ambos objetos apuntan a la misma dirección de memoria.
//Por lo tanto, si modificamos uno de los objetos, el otro también se verá afectado,
//ya que ambos están referenciando el mismo objeto en memoria.
//objetoB = objetoA


//CLONACIÓN DE OBJETOS