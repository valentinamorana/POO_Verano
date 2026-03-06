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

namespace TP_UN1_Morana_POO.EJ4
{
    public partial class VehiculoFormsEJ4 : Form
    {
        public VehiculoFormsEJ4()
        {
            InitializeComponent();
        }
        
        private Vehiculo vehiculo;
        private IConducible conducible;
        private IVolador volador;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            btnConducir.Enabled = false;
            btnVolar.Enabled = false;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string modelo = txtModelo.Text.Trim();

            if (string.IsNullOrEmpty(modelo))
            {
                MessageBox.Show("Ingresá un modelo.");
                return;
            }

            // Objeto real (con herencia múltiple por interfaces)
            VehiculoAccion v = new VehiculoAccion(modelo);

            // Guardamos referencias polimórficas
            vehiculo = v;       // como Vehiculo
            conducible = v;     // como IConducible
            volador = v;        // como IVolador

            btnConducir.Enabled = true;
            btnVolar.Enabled = true;

            lstSalida.Items.Add($"Vehículo creado: {vehiculo.Modelo}");
            lstSalida.Items.Add("Listo para conducir o volar.");
        }

        private void btnConducir_Click(object sender, EventArgs e)
        {
            if(conducible == null)
            {
                MessageBox.Show("Primero creá el vehículo.");
                return;
            }

            lstSalida.Items.Add(conducible.Conducir());
        }

        private void btnVolar_Click(object sender, EventArgs e)
        {
            if (volador == null)
            {
                MessageBox.Show("Primero creá el vehículo.");
                return;
            }

            lstSalida.Items.Add(volador.Volar());
        }
    }
}
