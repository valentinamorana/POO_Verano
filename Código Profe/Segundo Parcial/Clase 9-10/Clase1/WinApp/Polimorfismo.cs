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
using WinApp.Modelo.Miembros_de_clase;
using WinApp.Modelo.Polimorfismo;

namespace WinApp
{
    public partial class Polimorfismo : Form
    {

        List<Figura> figuras = new List<Figura>();

        public Polimorfismo()
        {
            InitializeComponent();
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int valor = rnd.Next(1, 10);
            Triangulo triangulo = new Triangulo(0, 0, valor);
            figuras.Add(triangulo);
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int valor = rnd.Next(1, 10);
            Rectangulo rectangulo = new Rectangulo(0, 0, valor, valor + 2);
            figuras.Add(rectangulo);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            foreach (Figura figura in figuras)
            {
                //Método que se comporta de forma diferente dependiendo del tipo de figura que se le pase
                //Forma de visualizar el polimorfismo, ya que el método Descripcion, Area y Perimetro se comportan de forma diferente dependiendo del tipo de figura que se le pase
                MostrarFigura(figura);

                //Si quiero trabajar con un triángulo, tengo que hacer un cast, ya que el método MostrarFigura recibe una figura, pero si quiero trabajar con un triángulo, tengo que hacer un cast para poder acceder a las propiedades y métodos específicos del triángulo
                if (figura is Triangulo)
                {
                    //Primero, debo hacer el cast al tipo Triangulo, para poder acceder a las propiedades y métodos específicos del triángulo, y luego puedo llamar al método MostrarTriangulo para mostrar la información específica del triángulo
                    Triangulo triangulo = figura as Triangulo;
                    MostrarTriangulo(triangulo);
                }
            }
        }

        private void MostrarFigura(Figura figura)
        {
            MessageBox.Show($"{figura.Descripcion()} - Área: {figura.Area()} - Perímetro: {figura.Perimetro()}");
        }

        private void MostrarTriangulo(Triangulo triangulo)
        {
            MessageBox.Show($"Lado del triángulo: {triangulo.Lado}");
        }

        private void btnMostrarDibujo_Click(object sender, EventArgs e)
        {
            Dibujo dibujo = new Dibujo();
            
            foreach (Figura figura in figuras)
            {
                //Ejemplo de agregación de objetos de tipo Figura en nuestro dibujo
                dibujo.AgregarFigura(figura);
            }

            List<Figura> figurasDibujo = dibujo.ObtenerFiguras();

            //List<Triangulo> triangulos = new List<Triangulo>();

            //foreach (Figura figura in figurasDibujo)
            //{
            //    if (figura is Triangulo)
            //    {
            //        Triangulo triangulo = figura as Triangulo;
            //        triangulos.Add(triangulo);
            //    }
            //}

            //dgvFiguras.DataSource = null;
            //dgvFiguras.DataSource = triangulos;

            dgvFiguras.DataSource = null;
            dgvFiguras.DataSource = figurasDibujo;

            MessageBox.Show($"Cantidad de figuras en el dibujo: {figurasDibujo.Count} - Contador de figuras creadas: {Dibujo.Contador}");
           
        }

        private void btnMostrarStatic_Click(object sender, EventArgs e)
        {
            //definir una clase abstract o static, no permite crear instancias de esa clase, pero si permite acceder a sus miembros estáticos, como en este caso, la clase Configuration, que es una clase estática, no permite crear instancias de esa clase, pero si permite acceder a sus miembros estáticos, como en este caso, la clase Configuration, que es una clase estática, no permite crear instancias de esa clase, pero si permite acceder a sus miembros estáticos, como en este caso, la clase Configuration, que es una clase estática, no permite crear instancias de esa clase, pero si permite acceder a sus miembros estáticos, como en este caso, la clase Configuration, que es una clase estática, no permite crear instancias de esa clase, pero si permite acceder a sus miembros estáticos, como en este caso, la clase Configuration, que es una clase estática, no permite crear instancias de esa clase, pero si permite acceder a sus miembros estáticos, como en este caso, la clase Configuration, que es una clase estática, no permite crear instancias de esa clase, pero si permite acceder a sus miembros estáticos, como en este caso, la clase Configuration
            //Configuration.MaxUsers = 5;
            //Configuration.MinUsers = 0;
            Configuration.Mostrar();
            MessageBox.Show($"MaxUsers: {Configuration.MaxUsers} - MinUsers: {Configuration.MinUsers}");
        }
    }
}
