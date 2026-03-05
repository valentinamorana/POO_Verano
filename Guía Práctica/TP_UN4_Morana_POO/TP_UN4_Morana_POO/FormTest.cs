using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_UN4_Morana_POO.EJ17;
using TP_UN4_Morana_POO.EJ18;
using TP_UN4_Morana_POO.EJ19;
using TP_UN4_Morana_POO.EJ20;

namespace TP_UN4_Morana_POO
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

        private void btnEJ17_Click(object sender, EventArgs e)
        {
            MessageBox.Show(PruebaOrdenamiento.Ejecutar());
        }

        private void btnEJ18_Click(object sender, EventArgs e)
        {
            MessageBox.Show(PruebaArray.Ejecutar());
        }

        private void btnEJ19_Click(object sender, EventArgs e)
        {
            MessageBox.Show(PruebaClone.Ejecutar());
        }

        private void btnEJ20_Click(object sender, EventArgs e)
        {
            MessageBox.Show(PruebaEnumerable.Ejecutar());
        }
    }
}
