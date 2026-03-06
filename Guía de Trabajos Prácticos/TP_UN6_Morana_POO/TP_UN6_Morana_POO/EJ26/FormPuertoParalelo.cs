using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_UN6_Morana_POO.EJ26
{
    public partial class FormPuertoParalelo : Form
    {
        private PuertoParaleloEmulado puerto = new PuertoParaleloEmulado();

        public FormPuertoParalelo()
        {
            InitializeComponent();

            // Suscripción a eventos del emulador
            puerto.DatosEnviados += (s, data) =>
            {
                lblData.Text = "DATA: " + data;
                lstLog.Items.Add("Enviado DATA: " + data);
            };

            puerto.EntradasActualizadas += (s, st) =>
            {
                lblStatus.Text = "STATUS: " + st;
                lstLog.Items.Add("Entradas STATUS: " + st);
            };
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!byte.TryParse(txtValor.Text.Trim(), out byte valor))
            {
                MessageBox.Show("Ingrese un valor entre 0 y 255.");
                return;
            }

            puerto.EnviarDatos(valor);

            // Recolectar entradas explícitamente
            var entradas = puerto.LeerEntradas();
            lstLog.Items.Add("Lectura STATUS: " + entradas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            puerto.Reset();
            lstLog.Items.Add("Reset del puerto.");
        }
    }
}
