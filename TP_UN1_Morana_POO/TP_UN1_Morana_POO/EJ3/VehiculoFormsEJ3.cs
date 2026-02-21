using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_UN1_Morana_POO.EJ4;

namespace TP_UN1_Morana_POO.EJ3
{
    public partial class VehiculoFormsEJ3 : Form
    {
        public VehiculoFormsEJ3()
        {
            InitializeComponent();
        }

        private List<Vehiculo> vehiculos = new List<Vehiculo>();

        private void VehiculoFormsEJ3_Load(object sender, EventArgs e) // Al cargar el formulario, se ejecuta este método para inicializar cosas.
        {
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Auto");
            cmbTipo.Items.Add("Moto");
            cmbTipo.Items.Add("Camion");
            cmbTipo.SelectedIndex = 0;

            lblEspecifico.Text = "Puertas:";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string marca = txtMarca.Text.Trim();
            string modelo = txtModelo.Text.Trim();

            if (string.IsNullOrEmpty(marca) || string.IsNullOrEmpty(modelo))
            {
                MessageBox.Show("Completá marca y modelo.");
                return;
            }

            int anio;
            if (!int.TryParse(txtAnio.Text, out anio))
            {
                MessageBox.Show("Año inválido.");
                return;
            }

            string tipo = cmbTipo.SelectedItem.ToString();

            Vehiculo v = null;

            // Específico
            if (tipo == "Auto")
            {
                int puertas;
                if (!int.TryParse(txtEspecifico.Text, out puertas))
                {
                    MessageBox.Show("Puertas inválidas.");
                    return;
                }

                v = new Auto(marca, modelo, anio, puertas);
            }
            else if (tipo == "Moto")
            {
                int cilindrada;
                if (!int.TryParse(txtEspecifico.Text, out cilindrada))
                {
                    MessageBox.Show("Cilindrada inválida.");
                    return;
                }

                v = new Moto(marca, modelo, anio, cilindrada);
            }
            else if (tipo == "Camion")
            {
                decimal capacidad;
                if (!decimal.TryParse(txtEspecifico.Text, out capacidad))
                {
                    MessageBox.Show("Capacidad inválida.");
                    return;
                }

                v = new Camion(marca, modelo, anio, capacidad);
            }

            vehiculos.Add(v);

            lstVehiculos.Items.Add($"{tipo} - {marca} {modelo} ({anio})");
            MessageBox.Show("Vehículo agregado.");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int km;
            if (!int.TryParse(txtKm.Text, out km))
            {
                MessageBox.Show("Kilómetros inválidos.");
                return;
            }

            if (vehiculos.Count == 0)
            {
                MessageBox.Show("No hay vehículos cargados.");
                return;
            }

            lstSalida.Items.Clear();

            // POLIMORFISMO: lista de Vehiculo, pero ejecuta override según el tipo real
            foreach (Vehiculo v in vehiculos)
            {
                decimal costo = v.CalcularCostoViaje(km);
                lstSalida.Items.Add($"{v.Marca} {v.Modelo} -> Costo {km} km: {costo}");
            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cmbTipo.SelectedItem.ToString();

            if (tipo == "Auto") lblEspecifico.Text = "Puertas:";
            else if (tipo == "Moto") lblEspecifico.Text = "Cilindrada:";
            else if (tipo == "Camion") lblEspecifico.Text = "Capacidad carga:";
        }
    }
}
