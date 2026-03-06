using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp.Modelo
{
    internal class ClaseIndizada
    {
        private string[] datos = new string[10];

        public string this[int indice]
        {
            get { 
                if (indice < 0 || indice >= datos.Length)
                {
                    throw new Exception("No se permite índice negativo o mayor o igual a 10");
                }
                return datos[indice];
            }

            set {
                if (indice < 0 || indice >= datos.Length)
                {
                    throw new Exception("No se permite índice negativo o mayor o igual a 10");
                }
                datos[indice] = value;
            }
        }
    }
}
