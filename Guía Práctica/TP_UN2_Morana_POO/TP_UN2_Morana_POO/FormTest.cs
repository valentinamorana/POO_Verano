using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_UN2_Morana_POO.EJ8;
using TP_UN2_Morana_POO.EJ9;
using TP_UN2_Morana_POO.EJ10;
using TP_UN2_Morana_POO.EJ11;
using TP_UN2_Morana_POO.EJ12;


namespace TP_UN2_Morana_POO
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void FormTest_Load(object sender, EventArgs e) 
        {

        }

        private void btnEJ3_Click(object sender, EventArgs e) //FUNCIONA
        {
            GestorRecurso g = new GestorRecurso("Recurso Test1");
            g.UsarRecurso();
        }

        private void btnEJ4_Click(object sender, EventArgs e) //FUNCIONA
        {
            GestorPedido gp = new GestorPedido();
            gp.Probar();
        }

        private void SensorTemperatura_TemperaturaAlta(object sender, EventArgs e) // Handler para el evento de temperatura alta
        {
            MessageBox.Show("Evento: temperatura alta detectada.");
        }

        private void SensorTemperatura_SensorReiniciado(object sender, EventArgs e) // Handler para el evento de sensor reiniciado
        {
            MessageBox.Show("Evento: sensor reiniciado.");
        }
        private void btnEJ5_Click(object sender, EventArgs e) //FUNCIONA
        {
            // Suscripción a los eventos estáticos
            SensorTemperatura.TemperaturaAlta += SensorTemperatura_TemperaturaAlta;
            SensorTemperatura.SensorReiniciado += SensorTemperatura_SensorReiniciado;

            SensorTemperatura s = new SensorTemperatura("S1", 20);
            s.ActualizarTemperatura(60);
        }

        private void btnEJ6_Click(object sender, EventArgs e) //FUNCIONA
        {
            EmpleadoEJ11 emp = new EmpleadoEJ11("Valentina", 123);
            MessageBox.Show(emp.Describir());
        }

        private void btnEJ7_Click(object sender, EventArgs e) //FUNCIONA
        {
            FacturaElectronica f = new FacturaElectronica("F001", 1000, "ABC123");
            MessageBox.Show(f.ObtenerResumen());
        }
    }
}
