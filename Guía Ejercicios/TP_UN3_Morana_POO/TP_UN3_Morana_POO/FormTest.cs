using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_UN3_Morana_POO.EJ13;
using TP_UN3_Morana_POO.EJ14;
using TP_UN3_Morana_POO.EJ15;
using TP_UN3_Morana_POO.EJ16;

namespace TP_UN3_Morana_POO
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void btnEJ13_Click(object sender, EventArgs e) // Prueba de generación de basura y recolección en C#
        {
            // cantidad grande + tamaño moderado para que se note
            string resultado = PruebaGC.Ejecutar(cantidad: 20000, kbPorObjeto: 4);
            MessageBox.Show(resultado);
        }

        private void btnEJ14_Click(object sender, EventArgs e) // Prueba de resurrección de objetos en C#
        {
            MessageBox.Show(PruebaResurreccion.Ejecutar());
        }

        private void FormTest_Load(object sender, EventArgs e)
        {

        }

        private void btnEJ15_Click(object sender, EventArgs e) // Prueba de manejo de excepciones en la calculadora
        {
            string resultado = Calculadora.Ejecutar("abc", 0, 5); // texto no numérico, divisor 0 y un índice que no existe, para probar el manejo de excepciones
            //string resultado = Calculadora.Ejecutar("10", 0, 1); // DivideByZeroException porque el divisor es 0
            //string resultado =  Calculadora.Ejecutar("10", 2, 10); // IndexOutOfRangeException porque el índice 10 no existe en el array de operaciones
            //string resultado = Calculadora.Ejecutar("2000000000", 2, 1); //OverflowException, porque el resultado de la división es 1000000000, que es mayor que el valor máximo de un entero (2147483647)
            MessageBox.Show(resultado);
        }

        private void btnEJ16_Click(object sender, EventArgs e)
        {
            MessageBox.Show(PruebaErrorPersonalizado.Ejecutar());
        }
    }
}
