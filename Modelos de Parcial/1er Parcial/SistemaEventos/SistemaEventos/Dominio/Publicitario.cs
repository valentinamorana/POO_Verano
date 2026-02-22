namespace SistemaEventos.Dominio
{
    /// <summary>
    /// Tipo Publicitario: plus de $17.000, SOLO si supera las 7 horas de trabajo.
    /// </summary>
    public class Publicitario : Persona
    {
        // Plus condicional del publicitario
        private const decimal PLUS_PUBLICITARIO = 17000m;
        // Mínimo de horas para recibir el plus
        private const double  MINIMO_HORAS      = 7.0;

        public Publicitario(int legajo, string nombre, string apellido, double horas, int cantEventos)
            : base(legajo, nombre, apellido, horas, cantEventos)
        {
        }

        /// <summary>
        /// Sueldo = base + horas * $8.000
        /// Si horas > 7 → suma el plus de $17.000.
        /// </summary>
        public override decimal CalcularSueldo()
        {
            // Sueldo base + valor de las horas
            decimal sueldo = SUELDO_BASE + (decimal)Horas * PRECIO_HORA;

            // El plus solo se agrega si superó el mínimo de horas
            if (Horas > MINIMO_HORAS)
                sueldo += PLUS_PUBLICITARIO;

            return sueldo;
        }

        public override string TipoPersona
        {
            get { return "Publicitario"; }
        }
    }
}
