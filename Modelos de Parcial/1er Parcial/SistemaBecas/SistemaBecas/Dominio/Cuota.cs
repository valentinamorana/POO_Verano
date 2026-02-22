using System;

namespace SistemaBecas.Dominio
{
    /// <summary>
    /// Representa una cuota mensual pagada por un alumno.
    /// Es creada y administrada internamente por el Alumno (composición).
    /// </summary>
    public class Cuota
    {
        // Campos privados — propfull
        private int _id;
        private int _mes;
        private int _anio;
        private DateTime _fechaPago;
        private decimal _valor;

        // ID único numérico de la cuota
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        // Mes al que corresponde la cuota (1-12)
        public int Mes
        {
            get { return _mes; }
            set
            {
                if (value < 1 || value > 12)
                    throw new ArgumentException("El mes debe ser entre 1 y 12.");
                _mes = value;
            }
        }

        // Año al que corresponde la cuota
        public int Anio
        {
            get { return _anio; }
            set { _anio = value; }
        }

        // Fecha en que se realizó el pago
        public DateTime FechaPago
        {
            get { return _fechaPago; }
            set { _fechaPago = value; }
        }

        // Valor original de la cuota antes de descuentos
        public decimal Valor
        {
            get { return _valor; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El valor de la cuota debe ser mayor a cero.");
                _valor = value;
            }
        }

        /// <summary>
        /// Constructor de la cuota con todos sus datos.
        /// </summary>
        public Cuota(int id, int mes, int anio, DateTime fechaPago, decimal valor)
        {
            _id = id;
            // Usando propiedades para que se ejecuten las validaciones
            Mes = mes;
            _anio = anio;
            _fechaPago = fechaPago;
            Valor = valor;
        }
    }
}
