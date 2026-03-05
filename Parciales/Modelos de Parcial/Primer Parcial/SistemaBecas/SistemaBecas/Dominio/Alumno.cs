using System;
using System.Collections.Generic;

namespace SistemaBecas.Dominio
{
    /// <summary>
    /// Clase abstracta base para todos los tipos de alumnos.
    /// Define el contrato que deben cumplir las subclases (polimorfismo).
    /// </summary>
    public abstract class Alumno
    {
        // Campos privados — propfull
        private string _legajo;
        private string _nombre;
        private string _apellido;
        private string _dni;

        // Agregación: el alumno referencia becas que existen de forma independiente
        private List<Beca> _becas;

        // Composición: las cuotas son creadas y destruidas junto con el alumno
        private List<Cuota> _cuotas;

        // Propiedades públicas del alumno
        public string Legajo
        {
            get { return _legajo; }
            set { _legajo = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        // Acceso de solo lectura a las listas
        public List<Beca> Becas
        {
            get { return _becas; }
        }

        public List<Cuota> Cuotas
        {
            get { return _cuotas; }
        }

        /// <summary>
        /// Constructor base que inicializa los datos comunes de todo alumno.
        /// </summary>
        public Alumno(string legajo, string nombre, string apellido, string dni)
        {
            _legajo = legajo;
            _nombre = nombre;
            _apellido = apellido;
            _dni = dni;
            // Las listas se crean aquí — composición con Cuota, agregación con Beca
            _becas = new List<Beca>();
            _cuotas = new List<Cuota>();
        }

        /// <summary>
        /// Método abstracto que cada subclase debe implementar.
        /// Retorna el porcentaje de beneficio según el tipo de alumno (polimorfismo).
        /// </summary>
        public abstract double CalcularPorcentajeBeneficio();

        /// <summary>
        /// Propiedad abstracta que devuelve el nombre del tipo de alumno.
        /// </summary>
        public abstract string TipoAlumno { get; }

        /// <summary>
        /// Calcula el importe total de las becas del alumno.
        /// </summary>
        public decimal ObtenerTotalBecas()
        {
            decimal total = 0;
            foreach (Beca b in _becas)
                total += b.Importe;
            return total;
        }

        /// <summary>
        /// Calcula el beneficio adicional sobre el valor neto (cuota - becas).
        /// Usa CalcularPorcentajeBeneficio() que es polimórfico.
        /// </summary>
        public decimal CalcularBeneficio(decimal valorCuota)
        {
            // Valor neto = cuota menos el total de becas
            decimal valorNeto = valorCuota - ObtenerTotalBecas();
            if (valorNeto < 0) valorNeto = 0;

            // Aplicar el porcentaje según el tipo de alumno (polimorfismo)
            decimal beneficio = valorNeto * (decimal)CalcularPorcentajeBeneficio() / 100m;
            return beneficio;
        }

        /// <summary>
        /// Calcula cuánto debe pagar finalmente el alumno por la cuota.
        /// Fórmula: cuota - becas - beneficio
        /// </summary>
        public decimal CalcularNetoPagar(decimal valorCuota)
        {
            decimal valorNeto = valorCuota - ObtenerTotalBecas();
            if (valorNeto < 0) valorNeto = 0;

            // Restar también el beneficio al valor neto
            decimal beneficio = CalcularBeneficio(valorCuota);
            return valorNeto - beneficio;
        }

        /// <summary>
        /// Agrega una beca al alumno. Máximo permitido: 2 becas.
        /// </summary>
        public void AgregarBeca(Beca beca)
        {
            // Validar el máximo de 2 becas por alumno
            if (_becas.Count >= 2)
                throw new InvalidOperationException("El alumno ya tiene el máximo de 2 becas permitidas.");

            _becas.Add(beca);
        }

        /// <summary>
        /// Quita una beca del alumno (la beca no se elimina, solo se desasocia).
        /// </summary>
        public void QuitarBeca(Beca beca)
        {
            if (!_becas.Contains(beca))
                throw new InvalidOperationException("El alumno no tiene esa beca asignada.");

            _becas.Remove(beca);
        }

        /// <summary>
        /// Registra el pago de una cuota. La Cuota es creada internamente (composición).
        /// </summary>
        public void PagarCuota(int idCuota, int mes, int anio, decimal valor)
        {
            // La Cuota nace aquí dentro del Alumno — esto es composición
            Cuota nuevaCuota = new Cuota(idCuota, mes, anio, DateTime.Now, valor);
            _cuotas.Add(nuevaCuota);
        }

        public override string ToString()
        {
            return $"{_apellido}, {_nombre} [{_legajo}]";
        }
    }
}
