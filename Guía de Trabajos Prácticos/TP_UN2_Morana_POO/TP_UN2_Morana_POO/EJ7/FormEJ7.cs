using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_UN2_Morana_POO.EJ7;

namespace TP_UN2_Morana_POO.EJ7
{
    public partial class FormEJ7 : Form
    {
        // Lista enlazada a la grilla
        private BindingList<EmpleadoEJ7> empleados = new BindingList<EmpleadoEJ7>();

        // Departamento actual (simple, para demostrar estructura)
        private Departamento deptoActual;

        public FormEJ7()
        {
            InitializeComponent();
        }

        private EmpleadoEJ7 ObtenerSeleccionado()
        {
            if (dgvEmpleados.CurrentRow == null)
                return null;

            return dgvEmpleados.CurrentRow.DataBoundItem as EmpleadoEJ7;
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            EmpleadoEJ7 emp = ObtenerSeleccionado();

            if (emp == null)
            {
                MessageBox.Show("Seleccione un empleado en la grilla.");
                return;
            }

            // Calcula salario total (salario base + suma de bonos)
            double total = emp.CalcularSalarioTotal();
            MessageBox.Show("Salario total: " + total);
        }

        private void btnMostrarBono_Click(object sender, EventArgs e)
        {
            EmpleadoEJ7 emp = ObtenerSeleccionado();

            if (emp == null)
            {
                MessageBox.Show("Seleccione un empleado en la grilla.");
                return;
            }

            try
            {
                // Propiedad con argumentos + propiedad predeterminada: INDEXADOR emp[0]
                double bono0 = emp[0];
                MessageBox.Show("Bono [0] (indexador): " + bono0);
            }
            catch
            {
                MessageBox.Show("No existe bono en índice 0. Agregue al menos un bono.");
            }
        }

        private void btnCrearDepartamento_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDepartamento.Text))
            {
                MessageBox.Show("Ingrese el nombre del departamento.");
                return;
            }

            deptoActual = new Departamento(txtDepartamento.Text.Trim());
            MessageBox.Show("Departamento creado: " + deptoActual.NombreDepartamento);
        }

        private void btnAgregarBono_Click(object sender, EventArgs e)
        {
            EmpleadoEJ7 emp = ObtenerSeleccionado();

            if (emp == null)
            {
                MessageBox.Show("Seleccione un empleado en la grilla.");
                return;
            }

            double bono;
            if (!double.TryParse(txtBono.Text.Trim(), out bono))
            {
                MessageBox.Show("Bono inválido.");
                return;
            }

            // Agrega el bono a la lista interna del empleado
            emp.AgregarBono(bono);

            MessageBox.Show("Bono agregado correctamente.");
        }

        private void btnSetComision_Click(object sender, EventArgs e)
        {
            EmpleadoEJ7 emp = ObtenerSeleccionado();

            if (emp == null)
            {
                MessageBox.Show("Seleccione un empleado en la grilla.");
                return;
            }

            double comision;
            if (!double.TryParse(txtComision.Text.Trim(), out comision))
            {
                MessageBox.Show("Comisión inválida.");
                return;
            }

            // Propiedad SOLO ESCRITURA, se puede asignar, pero no leer (no hay get)
            emp.PorcentajeComision = comision;

            MessageBox.Show("Comisión asignada (propiedad solo escritura).");
        }

        private void btnCargarEmpleado_Click(object sender, EventArgs e)
        {
            int legajo;
            int salario;

            // Validaciones simples (nivel parcial)
            if (!int.TryParse(txtLegajo.Text.Trim(), out legajo))
            {
                MessageBox.Show("Legajo inválido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Ingrese nombre y apellido.");
                return;
            }

            if (!int.TryParse(txtSalario.Text.Trim(), out salario))
            {
                MessageBox.Show("Salario inválido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCargo.Text))
            {
                MessageBox.Show("Ingrese el cargo.");
                return;
            }

            // Creamos el empleado (Persona -> Empleado)
            EmpleadoEJ7 emp = new EmpleadoEJ7(
                legajo,
                txtNombre.Text.Trim(),
                txtApellido.Text.Trim(),
                salario,
                txtCargo.Text.Trim()
            );

            // Se agrega a la lista (aparece automáticamente en la grilla)
            empleados.Add(emp);

            // Demostración: Legajo es SOLO LECTURA (se puede leer pero no setear desde afuera)
            MessageBox.Show("Empleado agregado. Legajo (solo lectura): " + emp.Legajo);
        }

        private void btnAgregarAlDepartamento_Click(object sender, EventArgs e)
        {
            if (deptoActual == null)
            {
                MessageBox.Show("Primero cree un departamento.");
                return;
            }

            EmpleadoEJ7 emp = ObtenerSeleccionado();
            if (emp == null)
            {
                MessageBox.Show("Seleccione un empleado en la grilla.");
                return;
            }

            deptoActual.AgregarEmpleado(emp);
            emp.Departamento = deptoActual;

            // 🔥 Forzar que el DataGridView vuelva a leer las propiedades
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = empleados;

            // si ocultabas la columna Departamento, hacelo de nuevo
            if (dgvEmpleados.Columns["Departamento"] != null)
                dgvEmpleados.Columns["Departamento"].Visible = false;

            MessageBox.Show("Empleado agregado al departamento.");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpia la grilla y el estado
            empleados.Clear();
            deptoActual = null;

            // Limpia inputs
            txtLegajo.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtSalario.Clear();
            txtCargo.Clear();
            txtComision.Clear();
            txtBono.Clear();
            txtDepartamento.Clear();
        }

        private void FormEJ7_Load_1(object sender, EventArgs e)
        {
            // Vinculamos la lista de empleados al DataGridView
            dgvEmpleados.AutoGenerateColumns = true;
            dgvEmpleados.DataSource = empleados;

            // Oculta la columna del objeto
            if (dgvEmpleados.Columns["Departamento"] != null)
                dgvEmpleados.Columns["Departamento"].Visible = false;
        }
    }
}
