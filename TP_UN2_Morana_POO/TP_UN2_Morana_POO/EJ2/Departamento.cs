using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN2_Morana_POO.EJ2
{
    public class Departamento
    {
        private string nombreDepartamento;

        public string NombreDepartamento
        {
            get { return nombreDepartamento; }
            set { nombreDepartamento = value; }
        }

        public Departamento(string nombreDepartamento)
        {
            this.nombreDepartamento = nombreDepartamento;
        }
        public override string ToString()
        {
            return NombreDepartamento;
        }

        private List<Empleado> empleados = new List<Empleado>();

        public void AgregarEmpleado(Empleado e) // Método para agregar un empleado al departamento
        {
            empleados.Add(e);
        }
    }
}
