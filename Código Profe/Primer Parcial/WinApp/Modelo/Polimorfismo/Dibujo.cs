using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp.Modelo.Polimorfismo
{
    internal class Dibujo
    {
        public static int Contador { get; private set; }

        private List<Figura> figuras = new List<Figura>();

        public void AgregarFigura(Figura figura)
        {
            Contador++;
            figuras.Add(figura);
        }

        public void QuitarFigura(Figura figura)
        {
            figuras.Remove(figura);
        }

        public List<Figura> ObtenerFiguras()
        {
            return figuras;
        }

        //Quedaría por ver composición similar al ejemplo del Dario
        //const ~Destructor y Dispose()
    }
}
