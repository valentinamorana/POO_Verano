using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN2_Morana_POO.EJ7
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

        private List<EmpleadoEJ7> empleados = new List<EmpleadoEJ7>();

        public void AgregarEmpleado(EmpleadoEJ7 e) // Método para agregar un empleado al departamento
        {
            empleados.Add(e);
        }
    }
}
