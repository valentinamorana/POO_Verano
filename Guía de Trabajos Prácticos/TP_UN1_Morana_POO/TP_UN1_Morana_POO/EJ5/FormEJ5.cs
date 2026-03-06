using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_UN1_Morana_POO.EJ5.Dominio;
using TP_UN1_Morana_POO.EJ5.Clasificacion;

namespace TP_UN1_Morana_POO.EJ5
{
    public partial class FormEJ5 : Form
    {
        private List<MedioTransporte> medios = new List<MedioTransporte>();
        private List<IClasificador> clasificadores = new List<IClasificador>();

        public FormEJ5()
        {
            InitializeComponent();
        }

        private void FormEJ5_Load(object sender, EventArgs e)
        {
            // Cargamos objetos reales (conjunto)
            medios.Add(new Auto());
            medios.Add(new Moto());
            medios.Add(new Bicicleta());
            medios.Add(new Monopatin());

            // Mostramos todos
            lstTodos.Items.Clear();
            foreach (var m in medios)
                lstTodos.Items.Add(m.Nombre);

            // Cargamos clasificadores (mecanismo externo)
            clasificadores.Add(new ClasificacionClasica());
            clasificadores.Add(new ClasificacionConceptual());
            clasificadores.Add(new ClasificacionPrototipica());

            cmbClasificacion.DataSource = clasificadores;
            cmbClasificacion.DisplayMember = "Nombre";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            IClasificador c = (IClasificador)cmbClasificacion.SelectedItem;

            lstResultado.Items.Clear();

            foreach (var m in medios)
            {
                if (c.Pertenece(m))
                    lstResultado.Items.Add(m.Nombre);
            }
        }
    }
}
