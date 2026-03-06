using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_UN6_Morana_POO.EJ25
{
    public partial class FormServidor2 : Form
    {
        ChatServer servidor = new ChatServer();

        public FormServidor2()
        {
            InitializeComponent();
            servidor.OnMessage += MostrarMensaje;

        }
        void MostrarMensaje(string msg)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(MostrarMensaje), msg);
                return;
            }

            lstMensajes.Items.Add(msg);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            servidor.Iniciar(5000);
        }

        private void lstMensajes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormServidor2_Load(object sender, EventArgs e)
        {
            foreach (IPAddress ip in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    MessageBox.Show("IP del servidor: " + ip.ToString());
                    break;
                }
            }
        }
    }
}
