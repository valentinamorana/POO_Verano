namespace SistemaBecas.Dominio
{
    /// <summary>
    /// Alumno de Grado. Beneficio del 5% sobre el valor neto.
    /// </summary>
    public class AlumnoGrado : Alumno
    {
        public AlumnoGrado(string legajo, string nombre, string apellido, string dni)
            : base(legajo, nombre, apellido, dni)
        {
        }

        // Override del método abstracto — 5% para alumnos de grado
        public override double CalcularPorcentajeBeneficio()
        {
            return 5.0;
        }

        public override string TipoAlumno
        {
            get { return "Grado"; }
        }
    }
}
