using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_UN1_Morana_POO.EJ5.Dominio;

namespace TP_UN1_Morana_POO.EJ5.Clasificacion
{
    public class ClasificacionPrototipica : IClasificador
    {
        // Prototipo: Auto
        public string Nombre => "Prototípica: Parecido a Auto";

        public bool Pertenece(MedioTransporte m)
        {
            // Ejemplo didáctico:
            // - Auto => sí
            // - otros motorizados => "se parecen" (moto)
            // - no motorizados => no
            if (m is Auto) return true;
            if (m.EsMotorizado) return true;  // parecido 
            return false;
        }
    }
}
