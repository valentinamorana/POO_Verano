using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_2Z_1erParcial_Morana_Valentina
{
    public partial class Form1 : Form
    {

        List<Vehiculo> listaVehiculos = new List<Vehiculo>(); // Lista para almacenar los vehículos, polimorfismo

        public Form1() // Constructor del formulario, se ejecuta al iniciar la aplicación
        {
            InitializeComponent();

            // Agrega opciones al ComboBox para seleccionar el tipo de vehículo
            cmbSelectorVehiculo.Items.Add("Auto"); 
            cmbSelectorVehiculo.Items.Add("Furgon");
            cmbSelectorVehiculo.SelectedIndex = 0; // Selecciona la primera opción por defecto, auto
        }

        // Habilita o deshabilita el campo de capacidad de carga según el tipo de vehículo seleccionado
        private void cmbSelectorVehiculo_SelectedIndexChanged(object sender, EventArgs e) 
        {
            if (cmbSelectorVehiculo.SelectedItem.ToString() == "Furgon")
                txtCapacidadCarga.Enabled = true;
            else
            {
                txtCapacidadCarga.Enabled = false;
                txtCapacidadCarga.Text = ""; 
            }
        }

        // Agrega un nuevo vehículo a la lista según el tipo seleccionado y mostrar un mensaje de confirmación
        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            string patente = txtPatente.Text; 
            double precioBase = Convert.ToDouble(txtPrecioBase.Text); // el txt devuelve un string, necesito convertirlo a double para poder hacer maths con el precio

            if (cmbSelectorVehiculo.SelectedItem.ToString() == "Auto") // Si se selecciona "Auto", se crea un objeto Auto y se agrega a la lista
            {
                Auto a = new Auto(patente, precioBase);
                listaVehiculos.Add(a); 
            }
            else
            {
                int capacidadCarga = Convert.ToInt32(txtCapacidadCarga.Text); // Si se selecciona "Furgon", se crea un objeto Furgon y se agrega a la lista
                Furgon f = new Furgon(patente, precioBase, capacidadCarga);
                listaVehiculos.Add(f);
            }

            MessageBox.Show("Se agregó el vehículo correctamente.");

            // Limpia los campos de entrada después de agregar el vehículo
            txtPatente.Text = "";
            txtPrecioBase.Text = "";
            txtCapacidadCarga.Text = "";
        }

        // Calcula el total recaudado sumando el costo de cada vehículo para 1 dia y muestra la cantidad de vehículos y el total en un MessageBox
        private void btnVerResumen_Click(object sender, EventArgs e)
        {
            double total = 0; 

            foreach (Vehiculo v in listaVehiculos) // Itera sobre cada vehículo en la lista y suma su costo
            {
                total += v.CalcularCosto(1); // Calcula el costo para 1 día
            } //virtual otra MANERA que no es polimorfismo. 

            MessageBox.Show(
                "Cantidad de vehículos: " + listaVehiculos.Count +
                "\n\nRecaudado en total: $" + total
            );
        }

        // Lo deje para que sea más cómodo para entrar a ver el código del formulario, pero no tiene funcionalidad para este ejercicio
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
