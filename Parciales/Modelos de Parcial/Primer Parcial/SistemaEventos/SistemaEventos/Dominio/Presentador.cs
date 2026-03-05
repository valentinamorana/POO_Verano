namespace SistemaEventos.Dominio
{
    /// <summary>
    /// Tipo Presentador: plus de $12.000 siempre, sin límite de horas.
    /// </summary>
    public class Presentador : Persona
    {
        // Plus fijo del presentador, sin condición de horas
        private const decimal PLUS_PRESENTADOR = 12000m;

        public Presentador(int legajo, string nombre, string apellido, double horas, int cantEventos)
            : base(legajo, nombre, apellido, horas, cantEventos)
        {
        }

        /// <summary>
        /// Sueldo = base + $12.000 (plus, siempre) + horas * $8.000
        /// No tiene condición de horas para el plus.
        /// </summary>
        public override decimal CalcularSueldo()
        {
            // Plus siempre aplicado, sin restricción de horas
            decimal sueldo = SUELDO_BASE + PLUS_PRESENTADOR + (decimal)Horas * PRECIO_HORA;
            return sueldo;
        }

        public override string TipoPersona
        {
            get { return "Presentador"; }
        }
    }
}
