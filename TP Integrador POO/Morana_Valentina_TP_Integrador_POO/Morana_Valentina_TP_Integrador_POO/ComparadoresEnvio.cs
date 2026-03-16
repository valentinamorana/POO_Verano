using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morana_Valentina_TP_Integrador_POO
{
    /// <summary>
    /// Contiene las seis clases comparadoras externas que implementan IComparer de Envio.
    /// Permiten ordenar una List de Envio por distintos criterios sin modificar la clase Envio.
    /// Cada clase representa una combinación de campo y dirección de ordenamiento.
    /// </summary>

    // Compara dos envíos por su campo Codigo en orden ascendente (A → Z).
    // Implementa IComparer para ser usado con List.Sort().
    public class ComparadorCodigoAsc : IComparer<Envio>
    {
        // Compara x con y por Codigo de forma ascendente
        // Retorna negativo si x va antes, 0 si son iguales, positivo si x va después
        public int Compare(Envio x, Envio y)
        {
            return x.Codigo.CompareTo(y.Codigo);
        }
    }

    // Implementa IComparer para comparar envíos por su campo Codigo en orden descendente (Z → A)
    public class ComparadorCodigoDesc : IComparer<Envio>
    {
        public int Compare(Envio x, Envio y)
        {
            return y.Codigo.CompareTo(x.Codigo);
        }
    }

    // Implementa IComparer para comparar envíos por peso en orden ascendente
    public class ComparadorPesoAsc : IComparer<Envio>
    {
        public int Compare(Envio x, Envio y)
        {
            return x.PesoKg.CompareTo(y.PesoKg);
        }
    }

    // Implementa IComparer para comparar envíos por peso en orden descendente
    public class ComparadorPesoDesc : IComparer<Envio>
    {
        public int Compare(Envio x, Envio y)
        {
            return y.PesoKg.CompareTo(x.PesoKg);
        }
    }

    // Implementa IComparer para comparar envíos por prioridad en orden ascendente
    public class ComparadorPrioridadAsc : IComparer<Envio>
    {
        public int Compare(Envio x, Envio y)
        {
            return x.Prioridad.CompareTo(y.Prioridad);
        }
    }

    // Implementa IComparer para comparar envíos por prioridad en orden descendente
    public class ComparadorPrioridadDesc : IComparer<Envio>
    {
        public int Compare(Envio x, Envio y)
        {
            return y.Prioridad.CompareTo(x.Prioridad);
        }
    }

}
