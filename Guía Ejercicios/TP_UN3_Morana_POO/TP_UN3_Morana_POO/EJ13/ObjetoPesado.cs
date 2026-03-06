using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN3_Morana_POO.EJ13
{
    public class ObjetoPesado
    {
        private byte[] buffer; // simula un objeto que ocupa memoria

        public ObjetoPesado(int kb) // recibe el tamaño en KB
        {
            // kb * 1024 bytes
            buffer = new byte[kb * 1024];
        }
    }
}
