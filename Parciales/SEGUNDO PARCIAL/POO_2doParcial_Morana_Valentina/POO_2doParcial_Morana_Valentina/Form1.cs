using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_2doParcial_Morana_Valentina
{
    public partial class Form1 : Form
    {
        // Lista en memoria donde se guardan los productos
        private List<Producto> listaProductos;

        public Form1()
        {
            InitializeComponent();

            listaProductos = new List<Producto>();
        }

        // Precarga 
        private void Form1_Load(object sender, EventArgs e)
        {
            PrecargarProductosIniciales();
            CargarCategorias(); //LINQ para cargar categorías distintas en el ComboBox
            CargarComboOrden();
            UtilizarFiltros();

        }

        // Método para precargar algunos productos de prueba en la lista al iniciar la aplicación
        private void PrecargarProductosIniciales()
        {
            listaProductos.Clear();

            //HARDCODEO DE PRODUCTOS -------
            // Agrego algunos productos de prueba a la lista para tener datos al iniciar la aplicación. Algunos están activos y otros no
            listaProductos.Add(new Producto(1, "Hello Kitty", "Peluche", 100, true)); // Producto activo
            listaProductos.Add(new Producto(2, "Cinnamonrol", "Peluche", 150, true));
            listaProductos.Add(new Producto(3, "Abejita", "Peluche", 50, true));
            listaProductos.Add(new Producto(4, "Remera 1", "Indumentaria", 200, true));
            listaProductos.Add(new Producto(5, "Remera 2", "Indumentaria", 210, false)); // Producto inactivo para probar el filtro de solo activos
            listaProductos.Add(new Producto(6, "Remera 3", "Indumentaria", 20, false));
        }

        // Método para cargar las categorías distintas en el ComboBox de filtro utilizando LINQ
        private void CargarCategorias()
        {
            // Obtengo categorías distintas ordenadas alfabéticamente con LINQ
            var categorias = listaProductos
                                .Select(p => p.Categoria) // Toma solo la categoría de cada producto
                                .Distinct() // Elimino repetidos
                                .OrderBy(c => c) // Ordeno alfabéticamente
                                .ToList(); // Convierto el resultado en una lista 

            // Limpio el ComboBox y cargo las categorías
            cmbFiltroCategoria.Items.Clear();
            cmbFiltroCategoria.Items.Add("Todas");

            foreach (string categoria in categorias) // Agrego cada categoría al ComboBox
            {
                cmbFiltroCategoria.Items.Add(categoria);
            }

            cmbFiltroCategoria.SelectedIndex = 0;
        }

        // Método para cargar las opciones de ordenamiento en el ComboBox
        private void CargarComboOrden()
        {
            cmbOrden.Items.Clear(); // Limpio opciones anteriores
            cmbOrden.Items.Add("Nombre ascendente");
            cmbOrden.Items.Add("Nombre descendente");
            cmbOrden.Items.Add("Precio ascendente");
            cmbOrden.Items.Add("Precio descendente");
            cmbOrden.SelectedIndex = 0; // Selecciono la primera opción por defecto
        }

        // Método para mostrar los productos en el DataGridView, la cantidad total y el promedio de precios
        private void ActualizarGrilla(List<Producto> productos) // Recibo la lista filtrada y ordenada para mostrar
        {
            // Refresh DataGridView
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productos;

            // Muestro cantidad total de resultados
            lblCantidad.Text = "Cantidad de Productos: " + productos.Count.ToString();

            // Si hay productos, calculo el promedio con LINQ
            if (productos.Count > 0)
            {
                decimal promedio = productos.Average(p => p.Precio); // Promedio de precios
                lblPromedio.Text = "Promedio: $" + promedio.ToString("0.00"); // 2 decimales
            }
            else
            {
                lblPromedio.Text = "Promedio: $0"; // Si no hay productos, muestro promedio 0 para evitar error de división por cero
            }
        }

        // Evento del botón Agregar para crear un nuevo producto y agregarlo a la lista después de validar los campos
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int id; // Variable para almacenar el ID 
            decimal precio; // Variable para almacenar el precio 

            // Validaciones de campos vacíos, formato numérico y precio no negativo
            if (txtId.Text.Trim() == "" || // Verifico que ningún campo esté vacío, si alguno está vacío muestro un mensaje de error y salgo del método
                txtNombre.Text.Trim() == "" ||
                txtCategoria.Text.Trim() == "" ||
                txtPrecio.Text.Trim() == "")
            {
                MessageBox.Show("Completá todos los campos.");
                return;
            }

            if (!int.TryParse(txtId.Text.Trim(), out id)) // Intento convertir el texto del ID a entero, si falla muestro un mensaje de error
            {
                MessageBox.Show("El ID tiene que ser numérico.");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text.Trim(), out precio)) // Intento convertir el texto del precio a decimal, si falla muestro un mensaje de error
            {
                MessageBox.Show("El precio tiene que ser numérico.");
                return;
            }

            if (listaProductos.Any(p => p.Id == id)) // Verifico que no exista otro producto con el mismo ID utilizando LINQ, si ya existe muestro un mensaje de error
            {
                MessageBox.Show("Ya existe un producto con ese ID. Intentá de nuevo.");
                return;
            }

            // Si pasaron todas las validaciones, creo el nuevo producto y lo agrego a la lista
            Producto nuevo = new Producto();
            nuevo.Id = id;
            nuevo.Nombre = txtNombre.Text.Trim(); // Asigno el nombre ingresado al nuevo producto, uso Trim() para eliminar espacios al principio y al final
            nuevo.Categoria = txtCategoria.Text.Trim();
            nuevo.Precio = precio;
            nuevo.Activo = chkActivo.Checked;

            listaProductos.Add(nuevo);

            CargarCategorias();
            UtilizarFiltros();
            LimpiarCamposAlta();

            MessageBox.Show("Producto agregado.");
        }

        //  Método para limpiar los campos del formulario de alta después de agregar un producto
        private void LimpiarCamposAlta()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtCategoria.Clear();
            txtPrecio.Clear();
            chkActivo.Checked = false; // Desmarco el checkbox
        }

        // Método para aplicar los filtros y ordenamientos seleccionados por el usuario utilizando LINQ
        private void UtilizarFiltros()
        {
            /// LINQ para filtrar y ordenar la lista de productos según los criterios seleccionados por el usuario en los controles de filtro y ordenamiento. 
            /// Se van aplicando los filtros uno por uno sobre la consulta, y al final se muestra el resultado en el DataGridView 
            IEnumerable<Producto> consulta = listaProductos;

            // FILTRAR ----
            // Filtro por nombre
            if (txtBuscarNombre.Text.Trim() != "")
            {
                string textoBusqueda = txtBuscarNombre.Text.Trim().ToLower(); // Convierto el texto de búsqueda a minúsculas para hacer la comparación case-insensitive
                consulta = consulta.Where(p => p.Nombre.ToLower().Contains(textoBusqueda));
            }

            // Filtro por categoría
            if (cmbFiltroCategoria.SelectedIndex > 0)
            {
                string categoriaSeleccionada = cmbFiltroCategoria.SelectedItem.ToString(); // Obtengo la categoría seleccionada en el ComboBox
                consulta = consulta.Where(p => p.Categoria == categoriaSeleccionada);
            }

            // Solo productos activos
            if (chkSoloActivos.Checked)
            {
                consulta = consulta.Where(p => p.Activo == true);
            }


            // ORDENAR ----
            if (cmbOrden.SelectedItem != null) // Verifico que haya una opción de ordenamiento seleccionada antes de intentar ordenar
            {
                switch (cmbOrden.SelectedItem.ToString()) // Ordenamiento según la opción seleccionada
                {
                    case "Nombre ascendente":
                        consulta = consulta.OrderBy(p => p.Nombre);
                        break;

                    case "Nombre descendente":
                        consulta = consulta.OrderByDescending(p => p.Nombre);
                        break;

                    case "Precio ascendente":
                        consulta = consulta.OrderBy(p => p.Precio);
                        break;

                    case "Precio descendente":
                        consulta = consulta.OrderByDescending(p => p.Precio);
                        break;
                }
            }

            ActualizarGrilla(consulta.ToList()); // Convierto a lista para mostrar en el DataGridView
        }

        // Eventos de los controles de filtro y ordenamiento para volver a aplicar los filtros cada vez que el usuario cambie algo
        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            UtilizarFiltros(); // Cada vez que el usuario escriba o borre algo en el cuadro de búsqueda, se vuelven a aplicar los filtros para mostrar solo los productos que coincidan con el texto ingresado
        }

        private void cmbFiltroCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            UtilizarFiltros(); // Cada vez que el usuario cambie la categoría seleccionada, se vuelven a aplicar los filtros para mostrar solo los productos que pertenezcan a la categoría seleccionada (o todos si seleccionó "Todas")
        }

        private void chkSoloActivos_CheckedChanged(object sender, EventArgs e)
        {
            UtilizarFiltros(); // Cada vez que el usuario marque o desmarque la opción de "Solo activos", se vuelven a aplicar los filtros para mostrar solo los productos que estén activos (o todos si la opción está desmarcada)
        }

        private void cmbOrden_SelectedIndexChanged(object sender, EventArgs e)
        {
            UtilizarFiltros(); // Cada vez que el usuario cambie la opción de ordenamiento, se vuelven a aplicar los filtros para mostrar los productos ordenados según la opción seleccionada
        }

    }
}
