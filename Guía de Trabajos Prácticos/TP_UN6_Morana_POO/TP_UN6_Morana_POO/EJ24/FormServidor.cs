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
    public partial class FormServidor : Form
    {
        private SocketServidor server = new SocketServidor();

        public FormServidor()
        {
            InitializeComponent();

            server.MensajeRecibido += Server_MensajeRecibido;
            server.EstadoCambiado += Server_EstadoCambiado;
        }

        private void Server_MensajeRecibido(object sender, string msg)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => Server_MensajeRecibido(sender, msg)));
                return;
            }

            lstMensajes.Items.Add(msg);
        }

        private void Server_EstadoCambiado(object sender, string estado)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => Server_EstadoCambiado(sender, estado)));
                return;
            }

            lblEstado.Text = estado;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            server.Detener();
            base.OnFormClosing(e);
        }
        private void lstMensajes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int puerto = int.Parse(txtPuerto.Text);
            server.Iniciar(puerto);
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            server.Detener();
        }

        private void txtPuerto_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }
    }
}
