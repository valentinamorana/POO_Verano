using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_UN1_Morana_POO.EJ5.Dominio;

namespace TP_UN1_Morana_POO.EJ5.Clasificacion
{
    public interface IClasificador
    {
        bool Pertenece(MedioTransporte m);
        string Nombre { get; }
    }
}
