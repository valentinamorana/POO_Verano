using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_UN5_Morana_POO.EJ21;
using TP_UN5_Morana_POO.EJ22;
using TP_UN5_Morana_POO.EJ23;

namespace TP_UN5_Morana_POO
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

        private void btnEJ21_Click(object sender, EventArgs e)
        {
            MessageBox.Show(PruebaGenericos.Ejecutar());
        }

        private void btnEJ22_Click(object sender, EventArgs e)
        {
            MessageBox.Show(PruebaLINQ.Ejecutar());
        }

        private void btnEJ23_Click(object sender, EventArgs e)
        {
            MessageBox.Show(PruebaLambda.Ejecutar());
        }
    }
}
