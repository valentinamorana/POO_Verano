namespace SistemaBecas.Dominio
{
    /// <summary>
    /// Alumno de Posgrado. Beneficio del 1% sobre el valor neto.
    /// </summary>
    public class AlumnoPosgrado : Alumno
    {
        public AlumnoPosgrado(string legajo, string nombre, string apellido, string dni)
            : base(legajo, nombre, apellido, dni)
        {
        }

        // Override del método abstracto — 1% para alumnos de posgrado
        public override double CalcularPorcentajeBeneficio()
        {
            return 1.0;
        }

        public override string TipoAlumno
        {
            get { return "Posgrado"; }
        }
    }
}
