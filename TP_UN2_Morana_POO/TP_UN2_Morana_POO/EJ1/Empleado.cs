using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN2_Morana_POO.EJ1
{
    public class Empleado : Persona
    {
		private int salario;

		public int Salario
		{
			get { return salario; }
			set { salario = value; }
		}

        // 1 Constructor
        public Empleado() : base() // Llamamos al constructor por defecto de la clase base (Persona).
		{
			salario = 0; // Asignamos un valor por defecto al atributo salario.
        }

		// 2 Constructor sobrecargado
		public Empleado(int legajo, string nombre, string apellido, int salario) : base(legajo, nombre, apellido)
		{
			this.salario = salario; // Inicializamos el atributo salario con el valor pasado como parámetro.
        }

        // 1 Método sobrecargado (mismo nombre, sin parámetros)
        // Interpreto "CalcularSalario" como salario mensual
        public double CalcularSalario()
        {
            return salario;
        }

        // 1 Método sobrecargado (mismo nombre, con bono)
        // Devuelve salario mensual + bono
        public double CalcularSalario(double bono)
        {
            return salario + bono;
        }

        public double CalcularSalarioAnual()
        {
            return salario * 12;
        }

        // Para que el ListBox muestre lindo el empleado
        public override string ToString()
        {
            return $"{Legajo} - {Nombre} {Apellido} - Salario: {Salario}";
        }
    }
}