using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinApp.Modelo;

namespace WinApp
{
    public partial class Principal : Form
    {
        //Demo de una instancia
        private Cliente cliente = new Cliente();

        private Cliente cliente2 = new Cliente("n", "a");

        private Cliente cliente3 = new Cliente("a", "b", DateTime.Now );

        private Proveedor proveedor = new Proveedor("12345678", DateTime.Now, "Proveedor S.A.");

        private ClaseIndizada claseIndizada = new ClaseIndizada();

        //Demo de múltiples instancias de la clase Cliente
        List<Cliente> clientes = new List<Cliente>();

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            cliente.Nombre = "Test Nombre";
            cliente.Apellido = "Test Apellido";
            MessageBox.Show("Setemos de manera temprano el estado del único objeto cliente");
            MessageBox.Show(cliente.ToString());

            //Mostramos el estado también en los textboxs
            this.txtNombre.Text = cliente.Nombre;
            this.txtApellido.Text = cliente.Apellido;

            //Generamos datos seed para testing
            for (int i = 0; i < 10; i++)
            {
                claseIndizada[i] = (i * 2).ToString();
            }

            using (Proveedor proveedor = new Proveedor("321", "Pepe"))
            {
                //Lo utilizo para los fines que deseo...
                MessageBox.Show($"Proveedor creado: {proveedor.ToString()}");
            }//Se liberan los recursos de manera temprana... (Para desarrollos de ultra-performance)

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            cliente.Nombre = this.txtNombre.Text;
            cliente.Apellido = this.txtApellido.Text;

            MessageBox.Show("Mostramos el nuevo estado del único objeto cliente");
            MessageBox.Show(cliente.ToString());
        }

        private void btnClaseIndice_Click(object sender, EventArgs e)
        {
            int indice = (int)this.numIndice.Value;
            MessageBox.Show($"El valor del índice {indice} es {claseIndizada[indice]}");

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            //Debemos ir creando nuevas instancias cada vez que tenemos un cliente nuevo
            Cliente cliente = new Cliente();

            cliente.Nombre = this.txtNombre.Text;
            cliente.Apellido = this.txtApellido.Text;

            //Vamos a agregar la nueva instancia en nuestra lista temporal
            clientes.Add(cliente);
            RefrescarGrilla();
        }


        private void RefrescarGrilla()
        {
            //Obliga a limpiar el control
            dgvClientes.DataSource = null;
            //Obligamos a redibujar el control con la nueva lista de clientes
            dgvClientes.DataSource = clientes;
        }

        private void btnMostrarObjetoFila_Click(object sender, EventArgs e)
        {
            int indice = (int)this.numIndice.Value;

            if(indice >=0 && indice < dgvClientes.Rows.Count)
            {
                //Podemos buscar el objeto Cliente asociado a la fila seleccionada
                DataGridViewRow fila = dgvClientes.Rows[indice];

                //De esta forma, obtengo la instancia del cliente que está en esa fila
                Cliente cliente = (Cliente)fila.DataBoundItem;

                MessageBox.Show($"El cliente en la fila {indice} es: {cliente.ToString()}");

                //cliente.Nombre = "Pepe";
                //cliente.Apellido = "Argento";   
            }
            else
            {
                MessageBox.Show("Índice fuera de rango.");
            }

            //RefrescarGrilla();
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInscribir_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Principal_MouseMove(object sender, MouseEventArgs e)
        {
            //btnAgregarCliente.Location = new Point(e.X, 300);
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            Eventos formEventos = new Eventos();

            this.Hide();
            if(formEventos.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("El formulario Eventos se cerró con OK");
            }
            else
            {
                MessageBox.Show("El formulario Eventos se cerró con Cancel");
            }
            this.Show();
        }

        private void btnPolimorfismo_Click(object sender, EventArgs e)
        {
            this.Hide();

            Polimorfismo formPolimorfismo = new Polimorfismo();

            if (formPolimorfismo.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("El formulario Eventos se cerró con OK");
            }
            else
            {
                MessageBox.Show("El formulario Eventos se cerró con Cancel");
            }
            this.Show();
        }
    }
}
