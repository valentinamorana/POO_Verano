using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN3_Morana_POO.EJ13
{
    public static class PruebaGC
    {
        public static string Ejecutar(int cantidad, int kbPorObjeto)
        {
            long antes = GC.GetTotalMemory(true); // true: fuerza una recolección “suave” antes de medir

            // Creamos muchas instancias
            List<ObjetoPesado> lista = new List<ObjetoPesado>();
            for (int i = 0; i < cantidad; i++)
            {
                lista.Add(new ObjetoPesado(kbPorObjeto));
            }

            long despuesCrear = GC.GetTotalMemory(false);

            // “Soltamos” referencias (clave para que el GC pueda liberar)
            lista = null;

            // Forzamos GC
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            long despuesGC = GC.GetTotalMemory(false);

            return
                $"Antes: {BytesAMb(antes):0.00} MB\n" +
                $"Después de crear: {BytesAMb(despuesCrear):0.00} MB\n" +
                $"Después de GC: {BytesAMb(despuesGC):0.00} MB";
        }
        private static double BytesAMb(long bytes) // Convierte bytes a megabytes
        {
            return bytes / 1024.0 / 1024.0;
        }
    }
}
