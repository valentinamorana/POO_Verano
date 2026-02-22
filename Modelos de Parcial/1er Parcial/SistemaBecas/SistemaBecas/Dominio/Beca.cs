using System;

namespace SistemaBecas.Dominio
{
    /// <summary>
    /// Representa una beca universitaria otorgada en pesos.
    /// Una beca existe de forma independiente y puede asignarse a un alumno.
    /// </summary>
    public class Beca
    {
        // Campos privados — propfull explícito (no auto-properties)
        private string _codigo;
        private DateTime _fechaOtorgamiento;
        private decimal _importe;

        // Propiedad: código único de 6 caracteres (4 nums + 2 letras)
        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        // Propiedad: fecha en que fue otorgada la beca
        public DateTime FechaOtorgamiento
        {
            get { return _fechaOtorgamiento; }
            set { _fechaOtorgamiento = value; }
        }

        // Propiedad: importe en pesos, no puede ser negativo
        public decimal Importe
        {
            get { return _importe; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("El importe no puede ser negativo.");
                _importe = value;
            }
        }

        /// <summary>
        /// Constructor principal de la beca.
        /// </summary>
        public Beca(string codigo, DateTime fechaOtorgamiento, decimal importe)
        {
            _codigo = codigo;
            _fechaOtorgamiento = fechaOtorgamiento;
            // Uso de la propiedad para aprovechar la validación
            Importe = importe;
        }

        // Representación en texto de la beca
        public override string ToString()
        {
            return $"{_codigo} - ${_importe:F2}";
        }
    }
}
