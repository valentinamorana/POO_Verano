using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN6_Morana_POO.EJ26
{
    public static class PruebaPuertoParalelo
    {
        public static string Ejecutar(byte valor)
        {
            PuertoParaleloEmulado p = new PuertoParaleloEmulado();

            p.EnviarDatos(valor);
            var entradas = p.LeerEntradas();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DATA enviado (8 bits): " + valor);
            sb.AppendLine("STATUS leído: " + entradas);

            return sb.ToString();
        }
    }
}
