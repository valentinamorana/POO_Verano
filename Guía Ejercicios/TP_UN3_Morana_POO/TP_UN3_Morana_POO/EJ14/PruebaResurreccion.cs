using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_UN3_Morana_POO.EJ14;

namespace TP_UN3_Morana_POO.EJ14
{
    public static class PruebaResurreccion // Clase de prueba para demostrar resurrección
    {
        public static string Ejecutar() // Método que realiza la prueba de resurrección
        {
            Zombie.Resucitado = null;  

            Zombie z = new Zombie("Valentina");
            Guid idAntes = z.Id;

            z = null;

            // Forzar la recolección de basura para intentar resucitar el objeto
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            Zombie recuperado = Zombie.Resucitado;

            if (recuperado == null)
                return "No se logró resucitar el objeto.";

            Guid idDespues = recuperado.Id;

            // Demostración: puedo volver a usar el mismo objeto
            recuperado.Saludar();

            return "Objeto resucitado.\nMismo objeto (Id): " + (idAntes == idDespues);
        }
    }
}
