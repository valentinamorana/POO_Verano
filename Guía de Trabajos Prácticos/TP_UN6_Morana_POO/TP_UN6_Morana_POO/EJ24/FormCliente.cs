using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_UN6_Morana_POO.EJ24
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }
        private SocketCliente client = new SocketCliente();

        private void btnConectar_Click(object sender, EventArgs e)
        {
            client.Conectar(txtIP.Text.Trim(), int.Parse(txtPuerto.Text));
            MessageBox.Show("Conectado.");
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            client.Enviar(txtMensaje.Text);
            txtMensaje.Clear();
            txtMensaje.Focus();
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            client.Desconectar();
            MessageBox.Show("Desconectado.");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPuerto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
