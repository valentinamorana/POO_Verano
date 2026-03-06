using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_UN6_Morana_POO.EJ25
{
    public partial class FormCliente2 : Form
    {
        ChatClient cliente = new ChatClient();

        public FormCliente2()
        {
            InitializeComponent();
            cliente.OnMessage += MostrarMensaje;
        }

        private void FormCliente2_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            cliente.Conectar(txtIP.Text, 5000);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtMensaje.Text != "")
            {
                cliente.Enviar("Cliente: " + txtMensaje.Text);
                txtMensaje.Clear();
            }
        }
        private void txtMensaje_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEnviar_Click(null, null);
            }
        }

        void MostrarMensaje(string msg)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(MostrarMensaje), msg);
                return;
            }

            lstChat.Items.Add(msg);
        }
    }
}
