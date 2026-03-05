using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_UN1_Morana_POO.EJ5.Dominio;

namespace TP_UN1_Morana_POO.EJ5.Clasificacion
{
    public class ClasificacionConceptual : IClasificador
    {
        // Para el ejemplo: "Urbano individual" (moto, bicicleta, monopatin)
        public string Nombre => "Conceptual: Urbano individual";

        public bool Pertenece(MedioTransporte m)
        {
            return (m is Moto) || (m is Bicicleta) || (m is Monopatin);
        }
    }
}
