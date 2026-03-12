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
    public partial class Eventos : Form
    {
        Proveedor proveedor = new Proveedor("12345678", "");
        public Eventos()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            proveedor.RazonSocial = this.txtNombre.Text;
        }

        private void Eventos_Load(object sender, EventArgs e)
        {
            proveedor.CambioRazonSocial += Proveedor_CambioNombre;
            proveedor.CambrioRazonSocialArgs += Proveedor_CambioNombreArgs;
        }

        private void Proveedor_CambioNombreArgs(object sender, ProveedorEventArgs e)
        {
            MessageBox.Show($"(Recepción con ProveedorEventArgs) El nombre del proveedor ha cambiado a: {e.RazonSocial}");
        }

        //Generamos el event hablder personalizado para atajar
        //todos los disparos que se hagan del evento CambioNombre del proveedor, para actualizar la información en el formulario de manera automática cada vez que se cambie el nombre del proveedor.
        private void Proveedor_CambioNombre(object sender, EventArgs e)
        {
            MessageBox.Show($"(Recepción con EventArgs) El nombre del proveedor ha cambiado a: {proveedor.RazonSocial}");
        }
    }
}
