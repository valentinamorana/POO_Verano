using System;

namespace SistemaEventos.Dominio
{
    /// <summary>
    /// Clase abstracta base para todos los tipos de personal de eventos.
    /// Define los datos y comportamientos comunes. Las subclases implementan
    /// CalcularSueldo() de forma polimórfica.
    /// </summary>
    public abstract class Persona
    {
        // ===== Campos privados (propfull) =====
        private int    _legajo;
        private string _nombre;
        private string _apellido;
        private double _horas;          // Horas trabajadas en el evento
        private int    _cantEventos;    // Cantidad de eventos realizados

        // Sueldo base fijo para todos los tipos de personal
        protected const decimal SUELDO_BASE  = 18500m;
        // Precio por hora trabajada
        protected const decimal PRECIO_HORA  = 8000m;

        // ===== Propiedades públicas =====

        public int Legajo
        {
            get { return _legajo; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El legajo debe ser un número positivo.");
                _legajo = value;
            }
        }

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío.");
                _nombre = value;
            }
        }

        public string Apellido
        {
            get { return _apellido; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El apellido no puede estar vacío.");
                _apellido = value;
            }
        }

        // Horas trabajadas, no pueden ser negativas
        public double Horas
        {
            get { return _horas; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Las horas no pueden ser negativas.");
                _horas = value;
            }
        }

        // Cantidad de eventos en los que participó la persona
        public int CantEventos
        {
            get { return _cantEventos; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("La cantidad de eventos no puede ser negativa.");
                _cantEventos = value;
            }
        }

        /// <summary>
        /// Constructor de la clase base Persona.
        /// </summary>
        public Persona(int legajo, string nombre, string apellido, double horas, int cantEventos)
        {
            // Usando las propiedades para que corran las validaciones
            Legajo      = legajo;
            Nombre      = nombre;
            Apellido    = apellido;
            Horas       = horas;
            CantEventos = cantEventos;
        }

        /// <summary>
        /// Método abstracto: cada subclase calcula su sueldo de forma diferente (polimorfismo).
        /// Fórmula base: sueldoBase + plus (condicional) + horas * precioHora
        /// </summary>
        public abstract decimal CalcularSueldo();

        /// <summary>
        /// Propiedad abstracta que identifica el tipo de persona.
        /// </summary>
        public abstract string TipoPersona { get; }

        // Representación en texto para usar en ComboBox, mensajes, etc.
        public override string ToString()
        {
            return $"[{_legajo}] {_apellido}, {_nombre} ({TipoPersona})";
        }
    }
}
