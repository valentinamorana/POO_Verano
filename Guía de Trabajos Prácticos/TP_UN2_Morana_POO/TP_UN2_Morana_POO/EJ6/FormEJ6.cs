using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_UN2_Morana_POO.EJ6
{
    public partial class FormEJ6 : Form
    {
        // Guarda el último empleado cargado
        private EmpleadoEJ6 empleado;

        // Para que el legajo no sea siempre 1
        private int siguienteLegajo = 1;

        public FormEJ6()
        {
            InitializeComponent();
        }

        private void btnCalcularSalario_Click(object sender, EventArgs e)
        {
            if (empleado == null)
            {
                MessageBox.Show("Primero debe cargar un empleado.");
                return;
            }

            // Método sobrecargado #1 (sin parámetros)
            double total = empleado.CalcularSalario();
            lstEmpleados.Items.Add("Salario (sin bono): " + total);
        }

        private void btnCalcularBono_Click(object sender, EventArgs e)
        {
            if (empleado == null)
            {
                MessageBox.Show("Primero debe cargar un empleado.");
                return;
            }

            double bono;
            if (!double.TryParse(txtBono.Text.Trim(), out bono))
            {
                MessageBox.Show("El bono debe ser numérico.");
                return;
            }

            // Método sobrecargado #2 (con bono)
            double total = empleado.CalcularSalario(bono);
            lstEmpleados.Items.Add("Salario (con bono): " + total);
        }

        private void btnCargarEmpleado_Click(object sender, EventArgs e)
        {
            // Validación de nombre y apellido
            if (string.IsNullOrWhiteSpace(txtNombreEmpleado.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoEmpleado.Text))
            {
                MessageBox.Show("Por favor, ingrese nombre y apellido.");
                return;
            }

            // Validación del salario
            int salario;
            if (!int.TryParse(txtSalario.Text.Trim(), out salario))
            {
                MessageBox.Show("Por favor, ingrese un salario válido.");
                return;
            }

            // Constructor sobrecargado
            empleado = new EmpleadoEJ6(
                siguienteLegajo,
                txtNombreEmpleado.Text.Trim(),
                txtApellidoEmpleado.Text.Trim(),
                salario
            );

            siguienteLegajo++; // para el próximo empleado

            lstEmpleados.Items.Add("Empleado cargado:");
            lstEmpleados.Items.Add(empleado.ToString());
        }

        private void FormEJ6_Load(object sender, EventArgs e)
        {
        }
    }
}