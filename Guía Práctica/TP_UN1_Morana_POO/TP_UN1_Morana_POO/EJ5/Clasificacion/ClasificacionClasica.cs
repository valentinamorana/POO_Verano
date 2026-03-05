using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_UN1_Morana_POO.EJ5.Dominio;

namespace TP_UN1_Morana_POO.EJ5.Clasificacion
{
    public class ClasificacionClasica : IClasificador
    {
        public string Nombre
        {
            get { return "Clásica: Motorizados"; }
        }

        public bool Pertenece(MedioTransporte m)
        {
            return m.EsMotorizado;
        }
    }
}
