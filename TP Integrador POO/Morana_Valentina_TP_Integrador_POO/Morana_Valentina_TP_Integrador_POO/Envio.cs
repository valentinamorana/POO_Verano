using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Morana_Valentina_TP_Integrador_POO
{
    /// <summary>
    /// Representa un envío dentro del sistema logístico.
    /// Implementa IComparable, ICloneable e IEnumerable
    /// según los patrones del libro Booch-Cardacci.
    /// </summary>
    public class Envio : ICloneable, IComparable<Envio>, IEnumerable<string>
    {
        // Campos privados
        private string codigo;
        private string destino;
        private decimal pesoKg;
        private int prioridad;

        // Propiedades
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Destino
        {
            get { return destino; }
            set { destino = value; }
        }

        public decimal PesoKg
        {
            get { return pesoKg; }
            set { pesoKg = value; }
        }

        public int Prioridad
        {
            get { return prioridad; }
            set { prioridad = value; }
        }

        // Constructor vacío
        public Envio()
        {
        }

        // Constructor con parámetros
        public Envio(string codigo, string destino, decimal pesoKg, int prioridad)
        {
            this.Codigo = codigo;
            this.Destino = destino;
            this.PesoKg = pesoKg;
            this.Prioridad = prioridad;
        }

        // Validación estricta del código
        public static bool ValidarCodigo(string codigo)
        {
            // Formato requerido: ENV-AAA999-AAAA/MM/DD
            string patron = @"^ENV-[A-Z]{3}[0-9]{3}-\d{4}/\d{2}/\d{2}$";

            if (!Regex.IsMatch(codigo, patron))
                return false;

            // Valido además que la fecha exista realmente
            string[] partes = codigo.Split('-');
            string fechaTexto = partes[2];

            // Intento parsear la fecha para verificar que sea válida
            DateTime fecha; 
            return DateTime.TryParseExact( 
                fechaTexto,
                "yyyy/MM/dd",
                null,
                System.Globalization.DateTimeStyles.None,
                out fecha
            );
        }

        // Implementación de ICloneable
        public object Clone()
        {
            return new Envio(this.Codigo, this.Destino, this.PesoKg, this.Prioridad);
        }

        // Implementación de IComparable
        // Orden natural: por Código ascendente
        public int CompareTo(Envio other)
        {
            if (other == null)
                return 1;

            return this.Codigo.CompareTo(other.Codigo);
        }

        // Implementación de IEnumerable<string>
        // Devuelve las partes del código:
        // ENV / AAA999 / AAAA/MM/DD
        public IEnumerator<string> GetEnumerator()
        {
            string[] partes = this.Codigo.Split('-');

            yield return partes[0]; // ENV
            yield return partes[1]; // AAA999
            yield return partes[2]; // fecha
        }

        // Implementación explícita de IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator(); // Delegamos a la implementación genérica
        }

        public override string ToString() // Para mostrar el envío de forma legible
        { 
            return Codigo + " - " + Destino + " - " + PesoKg + " kg - Prioridad " + Prioridad; // Ejemplo: ENV-ABC123-2024/06/15 - Buenos Aires - 10.5 kg - Prioridad 2
        }
    }
}
