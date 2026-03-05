using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN2_Morana_POO.EJ12
{
    public sealed class FacturaElectronica : Factura // Clase sellada (sealed) que no puede ser heredada
    {
        private string cae; // Código de Autorización Electrónico

        public string Cae
        {
            get { return cae; }
            set { cae = value; }
        }

        public FacturaElectronica(string numero, decimal importe, string cae)
            : base(numero, importe)
        {
            this.cae = cae;
        }

        public override string ObtenerResumen() // Sobrescritura de método virtual
        {
            return base.ObtenerResumen() + $" - CAE: {cae}";
        }
    }
}
