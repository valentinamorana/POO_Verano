using Parcial1.Modelo;
using System.Runtime.InteropServices;

namespace Parcial1
{
    public partial class Form1 : Form
    {
        private List<Vehiculo> flota = new List<Vehiculo>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string patente = txtPatente.Text;
                double precio = Convert.ToDouble(txtPrecio.Text);

                Vehiculo vehiculo;

                if (rbAuto.Checked)
                {
                    vehiculo = new Auto(patente, precio);
                    //flota.Add(new Auto(patente, precio));
                }
                else
                {
                    int carga = Convert.ToInt32(txtCarga.Text);
                    vehiculo = new Furgon(patente, precio, carga);
                    //flota.Add(new Furgon(patente, precio, carga));
                }

                flota.Add(vehiculo);

                MessageBox.Show("Vehículo registrado!");

                Limpiar();
            }
            catch { MessageBox.Show("Error en los datos ingresados"); }
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (Vehiculo v in flota)
            {
                total += v.CalcularCosto(1); // POLIMORFISMO
            }
            MessageBox.Show($"Recaudación Total: ${total}\nVehículos: {flota.Count}");
        }

        private void Limpiar()
        {
            txtPatente.Clear(); 
            txtPrecio.Clear(); 
            txtCarga.Clear();
        }
    }
}
