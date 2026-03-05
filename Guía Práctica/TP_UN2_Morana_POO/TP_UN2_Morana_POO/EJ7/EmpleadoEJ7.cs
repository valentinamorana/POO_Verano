using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_UN2_Morana_POO.EJ7;

namespace TP_UN2_Morana_POO.EJ7
{
    public class EmpleadoEJ7 : PersonaEJ7
    {
        private int salario;

        public int Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        private string cargo;

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        private Departamento departamento;

        public Departamento Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }

        public string NombreDepartamento
        {
            get
            {
                return departamento != null ? departamento.NombreDepartamento : "";
            }
        }

        private double porcentajeComision;

        public double PorcentajeComision // solo escritura, no se puede leer el porcentaje de comisión una vez asignado
        {
            set { porcentajeComision = value; }
        }

        // Lista de bonos para usar con indexador
        private List<double> bonos = new List<double>();

        public EmpleadoEJ7(int legajo, string nombre, string apellido, int salario, string cargo)
            : base(legajo, nombre, apellido)
        {
            this.salario = salario;
            this.cargo = cargo;
        }

        public void AgregarBono(double bono) // Método para agregar un bono a la lista de bonos
        {
            bonos.Add(bono);
        }

        // PROPIEDAD CON ARGUMENTOS + PROPIEDAD PREDETERMINADA
        // Esto es un indexador: permite usar empleado[0], empleado[1], etc.
        public double this[int index]
        {
            get { return bonos[index]; }
            set { bonos[index] = value; }
        }

        // Método para calcular salario total con todos los bonos cargados
        public double CalcularSalarioTotal()
        {
            double totalBonos = 0;

            foreach (double b in bonos)
                totalBonos += b;

            return salario + totalBonos;
        }

        public override string ToString()
        {
            return $"{Legajo} - {Nombre} {Apellido} - Salario: {Salario}";
        }
    }
}
