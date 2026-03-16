using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Morana_Valentina_TP_Integrador_POO
{
    public partial class PLSLogisticsForm : Form
    {
        private ListaEnvios listaEnvios;
        private List<Envio> listaClones;
        private Envio clonActual;
        private Timer timerMensajeClon; 

        public PLSLogisticsForm()
        {
            InitializeComponent();

            listaEnvios = new ListaEnvios(); // Inicializamos la lista de envíos al crear el formulario
            listaClones = new List<Envio>(); // Lista para llevar un registro de los clones guardados en el sistema

            timerMensajeClon = new Timer(); // Timer para mostrar un mensaje temporal cuando se guarda un clon
            timerMensajeClon.Interval = 2000;
            timerMensajeClon.Tick += timerMensajeClon_Tick;

        }

        private void PLSLogisticsForm_Load(object sender, EventArgs e)
        {
            CargarOpcionesOrden(); // Cargamos las opciones de ordenamiento en el combo al iniciar el formulario
            PrecargarEnvios(); // Agregamos algunos envíos de ejemplo para mostrar en la grilla al iniciar
            MostrarEnvios(); // Mostramos los envíos en la grilla

            rbAscendente.Checked = true;

            lblEstado.AutoSize = false;
            lblEstado.Width = 200;
            lblEstado.Height = 40;
            lblEstado.TextAlign = ContentAlignment.TopLeft;
            lblEstado.Text = "Sistema iniciado.";


            lblValidacionCodigo.Text = "";

            lstClones.DrawMode = DrawMode.OwnerDrawFixed;
            lstClones.DrawItem += LstClones_DrawItem;
        }

        /// <summary>
        /// Carga cuatro envíos de ejemplo al iniciar el formulario
        /// para facilitar la demostración de las funcionalidades.
        /// </summary>
        private void PrecargarEnvios() // Agrega algunos envíos de ejemplo a la lista para mostrar en la grilla al iniciar el formulario
        {
            listaEnvios.Agregar(new Envio("ENV-ABC123-2026/03/20", "Rosario", 12m, 3));
            listaEnvios.Agregar(new Envio("ENV-XYZ456-2026/03/18", "Córdoba", 7m, 5));
            listaEnvios.Agregar(new Envio("ENV-QWE789-2026/03/25", "Mendoza", 20m, 2));
            listaEnvios.Agregar(new Envio("ENV-AAA999-2026/02/15", "CABA", 15m, 1));
        }

        private void CargarOpcionesOrden() // Carga las opciones de ordenamiento en el combo al iniciar el formulario
        {
            cmbOrdenCampo.Items.Clear();
            cmbOrdenCampo.Items.Add("Código");
            cmbOrdenCampo.Items.Add("Peso");
            cmbOrdenCampo.Items.Add("Prioridad");
            cmbOrdenCampo.SelectedIndex = 0;
        }

        /// <summary>
        /// Refresca el DataGridView con el contenido actual de listaEnvios.
        /// Se llama después de cada operación de ABM u ordenamiento.
        /// </summary>
        private void MostrarEnvios() // Actualiza la grilla para mostrar los envíos actuales en la lista
        {
            dgvEnvios.DataSource = null;
            dgvEnvios.DataSource = listaEnvios.Envios.ToList();

            ConfigurarGrilla();
        }

        private void ConfigurarGrilla() // Configura el ancho de las columnas de la grilla para mejorar la visualización
        {
            if (dgvEnvios.Columns.Count > 0)
            {
                dgvEnvios.Columns[0].Width = 200;
                dgvEnvios.Columns[0].MinimumWidth = 200;

                if (dgvEnvios.Columns.Count > 1)
                    dgvEnvios.Columns[1].Width = 150;

                if (dgvEnvios.Columns.Count > 2)
                    dgvEnvios.Columns[2].Width = 80;

                if (dgvEnvios.Columns.Count > 3)
                    dgvEnvios.Columns[3].Width = 80;
            }
        }

        private void MostrarEstado(string mensaje) // Muestra un mensaje de estado en el label correspondiente
        {
            lblEstado.Text = mensaje;
        }

        /// <summary>
        /// Valida en tiempo real el código ingresado en txtCodigo
        /// y muestra el resultado en lblValidacionCodigo.
        /// </summary>
        private void ActualizarValidacionCodigo()
        {
            if (txtCodigo.Text.Trim() == "")
            {
                lblValidacionCodigo.Text = "Ingrese un código.";
                return;
            }

            if (Envio.ValidarCodigo(txtCodigo.Text.Trim()))
            {
                lblValidacionCodigo.Text = "Código válido.";
            }
            else
            {
                lblValidacionCodigo.Text = "Código inválido. Formato: ENV-AAA999-AAAA/MM/DD";
            }
        }

        /// <summary>
        /// Valida los campos principales del formulario (Código, Destino, Peso, Prioridad).
        /// Retorna true si todos son válidos. Retorna false y muestra un mensaje si hay error.
        /// </summary>
        /// <param name="peso">Parámetro de salida con el peso parseado.</param>
        /// <param name="prioridad">Parámetro de salida con la prioridad parseada.</param>
        private bool ValidarDatosPrincipal(out decimal peso, out int prioridad) 
        {
            peso = 0;
            prioridad = 0;

            if (txtCodigo.Text.Trim() == "" ||
                txtDestino.Text.Trim() == "" ||
                txtPeso.Text.Trim() == "" ||
                txtPrioridad.Text.Trim() == "")
            {
                MostrarEstado("Complete todos los campos.");
                MessageBox.Show("Complete todos los campos.");
                return false;
            }

            if (!Envio.ValidarCodigo(txtCodigo.Text.Trim()))
            {
                MostrarEstado("Código inválido.");
                MessageBox.Show("El código no cumple el formato ENV-AAA999-AAAA/MM/DD.");
                return false;
            }

            if (!decimal.TryParse(txtPeso.Text.Trim(), out peso))
            {
                MostrarEstado("El peso debe ser numérico.");
                MessageBox.Show("El peso debe ser numérico.");
                return false;
            }

            if (peso <= 0)
            {
                MostrarEstado("El peso debe ser mayor a 0.");
                MessageBox.Show("El peso debe ser mayor a 0.");
                return false;
            }

            if (!int.TryParse(txtPrioridad.Text.Trim(), out prioridad))
            {
                MostrarEstado("La prioridad debe ser numérica.");
                MessageBox.Show("La prioridad debe ser numérica.");
                return false;
            }

            if (prioridad < 1 || prioridad > 5)
            {
                MostrarEstado("La prioridad debe estar entre 1 y 5.");
                MessageBox.Show("La prioridad debe estar entre 1 y 5.");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Valida los campos del panel Clon (Código, Destino, Peso, Prioridad).
        /// Retorna true si todos son válidos. Retorna false y muestra un mensaje si hay error.
        /// </summary>
        /// <param name="peso">Parámetro de salida con el peso parseado.</param>
        /// <param name="prioridad">Parámetro de salida con la prioridad parseada.</param>
        private bool ValidarDatosClon(out decimal peso, out int prioridad)
        {
            peso = 0;
            prioridad = 0;

            if (txtCodigoClon.Text.Trim() == "" ||
                txtDestinoClon.Text.Trim() == "" ||
                txtPesoClon.Text.Trim() == "" ||
                txtPrioridadClon.Text.Trim() == "")
            {
                MostrarEstado("Complete los campos del clon.");
                MessageBox.Show("Complete los campos del clon.");
                return false;
            }

            if (!Envio.ValidarCodigo(txtCodigoClon.Text.Trim()))
            {
                MostrarEstado("Código del clon inválido.");
                MessageBox.Show("El código del clon no tiene formato válido.");
                return false;
            }

            if (!decimal.TryParse(txtPesoClon.Text.Trim(), out peso))
            {
                MostrarEstado("El peso del clon debe ser numérico.");
                MessageBox.Show("El peso del clon debe ser numérico.");
                return false;
            }

            if (peso <= 0)
            {
                MostrarEstado("El peso del clon debe ser mayor a 0.");
                MessageBox.Show("El peso del clon debe ser mayor a 0.");
                return false;
            }

            if (!int.TryParse(txtPrioridadClon.Text.Trim(), out prioridad))
            {
                MostrarEstado("La prioridad del clon debe ser numérica.");
                MessageBox.Show("La prioridad del clon debe ser numérica.");
                return false;
            }

            if (prioridad < 1 || prioridad > 5)
            {
                MostrarEstado("La prioridad del clon debe estar entre 1 y 5.");
                MessageBox.Show("La prioridad del clon debe estar entre 1 y 5.");
                return false;
            }

            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal peso;
            int prioridad;

            // Validamos los datos ingresados antes de intentar agregar el envío. Si hay errores, se muestra un mensaje y se detiene la ejecución.
            if (!ValidarDatosPrincipal(out peso, out prioridad)) 
                return;

            if (listaEnvios.Envios.Any(en => en.Codigo == txtCodigo.Text.Trim()))
            {
                MostrarEstado("Ya existe un envío con ese código.");
                MessageBox.Show("Ya existe un envío con ese código.");
                return;
            }

            // Si los datos son válidos y el código no existe, creamos un nuevo objeto Envio con los datos ingresados y lo agregamos a la lista.
            // Luego actualizamos la grilla, limpiamos los campos y mostramos un mensaje de éxito.
            Envio nuevo = new Envio();
            nuevo.Codigo = txtCodigo.Text.Trim();
            nuevo.Destino = txtDestino.Text.Trim();
            nuevo.PesoKg = peso;
            nuevo.Prioridad = prioridad;

            listaEnvios.Agregar(nuevo);

            MostrarEnvios();
            LimpiarCamposPrincipales();
            MostrarEstado("Envío agregado correctamente.");
            MessageBox.Show("Envío agregado correctamente.");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvEnvios.CurrentRow == null)
            {
                MostrarEstado("Seleccione un envío.");
                MessageBox.Show("Seleccione un envío.");
                return;
            }

            decimal peso;
            int prioridad;

            if (!ValidarDatosPrincipal(out peso, out prioridad))
                return;

            Envio seleccionado = (Envio)dgvEnvios.CurrentRow.DataBoundItem; // Obtenemos el envío seleccionado en la grilla para modificarlo

            // Validamos que el nuevo código ingresado no exista en otro envío diferente al seleccionado, para evitar duplicados.
            if (listaEnvios.Envios.Any(en => en.Codigo == txtCodigo.Text.Trim() && en != seleccionado))
            {
                MostrarEstado("Ya existe otro envío con ese código.");
                MessageBox.Show("Ya existe otro envío con ese código.");
                return;
            }
            // Si los datos son válidos y el código no genera duplicados, modificamos el envío seleccionado con los nuevos datos ingresados.
            seleccionado.Codigo = txtCodigo.Text.Trim();
            seleccionado.Destino = txtDestino.Text.Trim();
            seleccionado.PesoKg = peso;
            seleccionado.Prioridad = prioridad;

            MostrarEnvios();
            LimpiarCamposPrincipales();
            MostrarEstado("Envío modificado correctamente.");
            MessageBox.Show("Envío modificado correctamente.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEnvios.CurrentRow == null)
            {
                MostrarEstado("Seleccione un envío.");
                MessageBox.Show("Seleccione un envío.");
                return;
            }

            Envio envioAEliminar = (Envio)dgvEnvios.CurrentRow.DataBoundItem;
            // Antes de eliminar, pedimos una confirmación al usuario para evitar eliminaciones accidentales.
            DialogResult confirmacion = MessageBox.Show(
                "¿Eliminar el envío '" + envioAEliminar.Codigo + "'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion != DialogResult.Yes)
                return;

            listaEnvios.Eliminar(envioAEliminar);

            bool eraUnClon = listaClones.Any(c => c.Codigo == envioAEliminar.Codigo);

            if (eraUnClon)
            {
                for (int i = 0; i < lstClones.Items.Count; i++)
                {
                    if (lstClones.Items[i].ToString().StartsWith(envioAEliminar.Codigo))
                    {
                        lstClones.Items[i] =
                            "❌ " + envioAEliminar.Codigo +
                            " - " + envioAEliminar.Destino +
                            "  (eliminado del sistema)";
                        break;
                    }
                }
            }

            MostrarEnvios();
            LimpiarCamposPrincipales();
            MostrarEstado("Envío eliminado correctamente.");
        }

        private void btnClonar_Click(object sender, EventArgs e)
        {
            Envio envioSeleccionado = dgvEnvios.CurrentRow?.DataBoundItem as Envio;

            if (envioSeleccionado == null)
            {
                MostrarEstado("Seleccioná un envío para clonar.");
                MessageBox.Show("Seleccioná un envío para clonar.");
                return;
            }

            // Creamos el clon utilizando el método Clone() del envío seleccionado
            clonActual = (Envio)envioSeleccionado.Clone();

            txtCodigoClon.Text = clonActual.Codigo;
            txtDestinoClon.Text = clonActual.Destino;
            txtPesoClon.Text = clonActual.PesoKg.ToString("0.##");
            txtPrioridadClon.Text = clonActual.Prioridad.ToString();

            MostrarEstado("Clon creado. Modificá los campos del clon y presioná el botón para comparar con el original.");
            MessageBox.Show("Clon creado. Modificá los campos del clon y presioná el botón para comparar con el original.");
        }

        private void btnModificarClon_Click(object sender, EventArgs e)
        {
            if (clonActual == null)
            {
                MostrarEstado("Primero debe clonar un envío.");
                MessageBox.Show("Primero debe clonar un envío.");
                return;
            }

            decimal Vpeso;
            int Vprioridad;

            if (!ValidarDatosClon(out Vpeso, out Vprioridad))
                return;

            // Guardamos el código original ANTES de modificar 
            // porque lo necesitamos para buscar el original en la lista
            string VcodigoOriginal = clonActual.Codigo;

            // Buscamos el original en el sistema 
            Envio Voriginal = listaEnvios.Envios
                .FirstOrDefault(en => en.Codigo == VcodigoOriginal);

            // Guardamos los datos del original ANTES del cambio 
            string VdestinoOriginal = Voriginal?.Destino ?? "(no encontrado)";
            decimal VpesoOriginal = Voriginal?.PesoKg ?? 0;
            int VprioridadOriginal = Voriginal?.Prioridad ?? 0;

            // Modificamos el CLON con los campos del formulario 
            clonActual.Destino = txtDestinoClon.Text.Trim();
            clonActual.PesoKg = Vpeso;
            clonActual.Prioridad = Vprioridad;

            // Mostramos la comparación ORIGINAL vs CLON 
            string Vmensaje =
                "COMPARACIÓN DE ENVÍOS\n" +
                "═══════════════════════════════════════════════════\n\n" +
                "ORIGINAL  (sin cambios en el sistema):\n" +
                "  Código    : " + VcodigoOriginal + "\n" +
                "  Destino   : " + VdestinoOriginal + "\n" +
                "  Peso      : " + VpesoOriginal.ToString("0.##") + " kg\n" +
                "  Prioridad : " + VprioridadOriginal + "\n\n" +
                "CLON  (modificado en memoria):\n" +
                "  Código    : " + txtCodigoClon.Text.Trim() + "\n" +
                "  Destino   : " + clonActual.Destino + "\n" +
                "  Peso      : " + clonActual.PesoKg.ToString("0.##") + " kg\n" +
                "  Prioridad : " + clonActual.Prioridad + "\n\n" +
                "─────────────────────────────────────────────────\n" +
                "¿Son el mismo objeto en memoria?\n" +
                "ReferenceEquals(original, clon) = " +
                object.ReferenceEquals(Voriginal, clonActual) + 
                "  ← debería ser False";
           
            // Comparamos las referencias de memoria del original y el clon utilizando ReferenceEquals para verificar que son objetos diferentes
            
            MessageBox.Show(Vmensaje,
                "Demostración ICloneable",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            MostrarEstado("Comparación realizada. El original no fue alterado.");
        }

        private void btnGuardarClon_Click(object sender, EventArgs e)
        {
            if (clonActual == null) // Verificamos que exista un clon creado antes de intentar guardarlo como nuevo envío en el sistema
            {
                MostrarEstado("Primero debe clonar un envío.");
                MessageBox.Show("Primero debe clonar un envío.");
                return;
            }

            decimal peso;
            int prioridad;

            if (!ValidarDatosClon(out peso, out prioridad))
                return;

            // Antes de guardar el clon como nuevo envío, validamos que el nuevo código ingresado no exista en otro envío del sistema para evitar duplicados.
            string nuevoCodigo = txtCodigoClon.Text.Trim();

            if (listaEnvios.Envios.Any(en => en.Codigo == nuevoCodigo))
            {
                MostrarEstado("El código del clon ya existe en el sistema.");
                MessageBox.Show("El código del clon ya existe en el sistema.");
                return;
            }

            clonActual.Codigo = nuevoCodigo;
            clonActual.Destino = txtDestinoClon.Text.Trim();
            clonActual.PesoKg = peso;
            clonActual.Prioridad = prioridad;

            listaEnvios.Agregar(clonActual);
            listaClones.Add(clonActual);

            lstClones.Items.Add(clonActual.Codigo + " - " + clonActual.Destino);

            MostrarEnvios();
            LimpiarCamposClon();

            MostrarEstado("Clon guardado exitosamente.");
            timerMensajeClon.Start();

            MessageBox.Show("Clon guardado como nuevo envío en el sistema.");

            clonActual = null;
        }

        // Recorre el código del envío seleccionado en la grilla utilizando la implementación de IEnumerable<string> de la clase Envio y
        // muestra cada parte en la lista correspondiente.
        private void btnRecorrerCodigo_Click(object sender, EventArgs e)
        {
            Envio envioSeleccionado = dgvEnvios.CurrentRow?.DataBoundItem as Envio;

            if (envioSeleccionado == null)
            {
                MostrarEstado("Seleccione un envío para recorrer su código.");
                MessageBox.Show("Seleccione un envío para recorrer su código.");
                return;
            }

            lstPartesCodigo.Items.Clear();

            string[] etiquetas = { "Prefijo", "Alfanum.", "Fecha" };
            int posicion = 0;

            foreach (string parte in envioSeleccionado)
            {
                lstPartesCodigo.Items.Add(etiquetas[posicion] + " -> " + parte);
                posicion++;
            }

            MostrarEstado("Se recorrió el código y se mostraron sus partes en la lista.");
        }

        // Ordena la lista de envíos según el criterio seleccionado en el combo y el orden (ascendente o descendente) seleccionado en los radio buttons.
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (cmbOrdenCampo.SelectedItem == null)
            {
                MostrarEstado("Seleccione un criterio de orden.");
                return;
            }

            string campo = cmbOrdenCampo.SelectedItem.ToString();
            bool ascendente = rbAscendente.Checked;

            switch (campo)
            {
                case "Código":
                    if (ascendente)
                        listaEnvios.Envios.Sort(new ComparadorCodigoAsc());
                    else
                        listaEnvios.Envios.Sort(new ComparadorCodigoDesc());
                    break;

                case "Peso":
                    if (ascendente)
                        listaEnvios.Envios.Sort(new ComparadorPesoAsc());
                    else
                        listaEnvios.Envios.Sort(new ComparadorPesoDesc());
                    break;

                case "Prioridad":
                    if (ascendente)
                        listaEnvios.Envios.Sort(new ComparadorPrioridadAsc());
                    else
                        listaEnvios.Envios.Sort(new ComparadorPrioridadDesc());
                    break;
            }

            MostrarEnvios();
            MostrarEstado("Listado ordenado correctamente.");
        }

        // Al hacer clic en una fila de la grilla, se cargan los datos del envío seleccionado en los campos principales para poder modificarlos
        // o simplemente para mostrar su información.
        private void dgvEnvios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEnvios.CurrentRow != null)
            {
                Envio seleccionado = (Envio)dgvEnvios.CurrentRow.DataBoundItem;

                txtCodigo.Text = seleccionado.Codigo;
                txtDestino.Text = seleccionado.Destino;
                txtPeso.Text = seleccionado.PesoKg.ToString();
                txtPrioridad.Text = seleccionado.Prioridad.ToString();

                MostrarEstado("Envío seleccionado.");
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ActualizarValidacionCodigo();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCamposPrincipales();
            MostrarEstado("Campos limpiados.");
        }

        // Limpia los campos principales del formulario para ingresar un nuevo envío o modificar uno existente.
        // También limpia el mensaje de validación del código y pone el foco en el campo de código.
        private void LimpiarCamposPrincipales()
        {
            txtCodigo.Clear();
            txtDestino.Clear();
            txtPeso.Clear();
            txtPrioridad.Clear();
            lblValidacionCodigo.Text = "";
            txtCodigo.Focus();
        }

        /// <summary>
        /// Limpia los campos del panel Clon luego de guardar el clon como nuevo envío.
        /// </summary>
        private void LimpiarCamposClon()
        {
            txtCodigoClon.Clear();
            txtDestinoClon.Clear();
            txtPesoClon.Clear();
            txtPrioridadClon.Clear();
        }

        // Evento del timer para ocultar el mensaje de estado después de mostrarlo por un tiempo determinado.
        private void timerMensajeClon_Tick(object sender, EventArgs e) 
        {
            timerMensajeClon.Stop();
            lblEstado.Text = "";
        }

        // Evento para personalizar el dibujo de los ítems en la lista de clones.
        // Si un clon fue eliminado del sistema, se muestra con un texto rojo y un símbolo de "X" para indicar que ya no está disponible.
        private void LstClones_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            string texto = lstClones.Items[e.Index].ToString();

            e.DrawBackground(); // Dibuja el fondo del ítem (respetando la selección)

            // Si el texto del ítem comienza con "❌", lo consideramos como un clon eliminado y lo dibujamos en rojo. De lo contrario, lo
            Color colorTexto = texto.StartsWith("❌")
                ? Color.Red
                : Color.Black;

            // Dibujamos el texto del ítem con el color correspondiente según si el clon fue eliminado o no del sistema.
            using (SolidBrush brush = new SolidBrush(colorTexto))
            {
                e.Graphics.DrawString(
                    texto,
                    e.Font,
                    brush,
                    e.Bounds);
            }

            e.DrawFocusRectangle(); // Dibuja un rectángulo de enfoque alrededor del ítem seleccionado
        }
    }
}