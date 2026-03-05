using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN1_Morana_POO.EJ4
{
    public class VehiculoAccion : Vehiculo, IConducible, IVolador
    {
        public VehiculoAccion(string modelo) : base(modelo)
        {
        }

        public string Conducir()
        {
            return $"{Modelo} está conduciendo en tierra.";
        }

        public string Volar()
        {
            return $"{Modelo} está volando.";
        }
    }
}
