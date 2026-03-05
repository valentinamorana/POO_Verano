namespace SistemaEventos.Dominio
{
    /// <summary>
    /// Tipo Modelo: plus de $20.000 siempre.
    /// Si supera las 10 horas de trabajo, recibe $35.000 adicionales.
    /// </summary>
    public class Modelo : Persona
    {
        // Plus fijo del modelo
        private const decimal PLUS_MODELO      = 20000m;
        // Bonus extra por superar las 10 horas
        private const decimal BONUS_HORAS_EXTRA = 35000m;
        // Umbral de horas para el bonus
        private const double  LIMITE_HORAS     = 10.0;

        public Modelo(int legajo, string nombre, string apellido, double horas, int cantEventos)
            : base(legajo, nombre, apellido, horas, cantEventos)
        {
            // Llama al constructor de Persona con todos los datos comunes
        }

        /// <summary>
        /// Sueldo = base + $20.000 (plus) + horas * $8.000
        /// Si horas > 10 → suma $35.000 adicionales.
        /// </summary>
        public override decimal CalcularSueldo()
        {
            // Cálculo base + plus fijo + valor de horas trabajadas
            decimal sueldo = SUELDO_BASE + PLUS_MODELO + (decimal)Horas * PRECIO_HORA;

            // Bonus extra si supera el límite de horas
            if (Horas > LIMITE_HORAS)
                sueldo += BONUS_HORAS_EXTRA;

            return sueldo;
        }

        // Identificador del tipo de persona
        public override string TipoPersona
        {
            get { return "Modelo"; }
        }
    }
}
