using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN2_Morana_POO.EJ12
{
    public class Factura : Documento
    {
        private decimal importe;

        public decimal Importe
        {
            get { return importe; }
            set { importe = value; }
        }

        public Factura(string numero, decimal importe) : base(numero)
        {
            this.importe = importe;
        }

        // CUMPLE: Sobrescritura de método virtual
        public override string ObtenerResumen()
        {
            return $"Factura N° {Numero} - Importe: {importe}";
        }
    }
}
