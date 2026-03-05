namespace SistemaBecas.Dominio
{
    /// <summary>
    /// Alumno de tipo Ingresante. Beneficio del 10% sobre el valor neto.
    /// Hereda de Alumno y sobreescribe el cálculo del beneficio (polimorfismo).
    /// </summary>
    public class AlumnoIngresante : Alumno
    {
        public AlumnoIngresante(string legajo, string nombre, string apellido, string dni)
            : base(legajo, nombre, apellido, dni)
        {
            // Llama al constructor de la clase base con todos los datos
        }

        // Override del método abstracto — retorna 10% para ingresantes
        public override double CalcularPorcentajeBeneficio()
        {
            return 10.0;
        }

        // Propiedad que identifica el tipo de alumno
        public override string TipoAlumno
        {
            get { return "Ingresante"; }
        }
    }
}
