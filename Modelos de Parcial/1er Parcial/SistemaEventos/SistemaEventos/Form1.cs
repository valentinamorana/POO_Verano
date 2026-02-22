using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SistemaEventos.Dominio;

namespace SistemaEventos
{
    public partial class Form1 : Form
    {
        // ===== LISTA EN MEMORIA — Agregación: el Form administra la lista de Persona =====
        private List<Persona> listaPersonas = new List<Persona>();

        // ===== REFERENCIAS A CONTROLES =====
        private DataGridView dgvTodos;
        private DataGridView dgvCategoria;

        private TextBox   txtLegajo, txtNombre, txtApellido, txtHoras, txtEventos;
        private ComboBox  cmbTipo, cmbFiltroCategoria;
        private Button    btnAgregar, btnModificar, btnEliminar, btnLimpiar;
        private Button    btnCalcularTodo;

        // Labels para mostrar los resultados del panel de estadísticas
        private Label lblMasEventos, lblRecaudacionTotal;
        private Label lblPctModelo, lblPctPublicitario, lblPctPresentador;

        public Form1()
        {
            InitializeComponent();
            this.Text            = "Sistema de Personal para Eventos";
            this.Size            = new Size(1100, 870);
            this.MinimumSize     = new Size(1100, 870);
            this.StartPosition   = FormStartPosition.CenterScreen;

            // Construir la UI completamente por código
            CrearUI();
        }

        // ========================================================
        //   CONSTRUCCIÓN DE LA INTERFAZ
        // ========================================================
        private void CrearUI()
        {
            Panel panel = new Panel() { AutoScroll = true, Dock = DockStyle.Fill };
            this.Controls.Add(panel);

            int y = 10;

            // ── SECCIÓN: Alta de Personal ──────────────────────────────
            GroupBox grpAlta = new GroupBox()
            {
                Text     = "Datos del Personal",
                Location = new Point(10, y),
                Size     = new Size(1065, 100)
            };
            panel.Controls.Add(grpAlta);

            // Fila 1: campos de texto
            Label lblLeg = new Label() { Text = "Legajo:",   Location = new Point(6,  28), AutoSize = true };
            txtLegajo    = new TextBox() { Location = new Point(58,  25), Width = 60 };

            Label lblNom = new Label() { Text = "Nombre:",   Location = new Point(130, 28), AutoSize = true };
            txtNombre    = new TextBox() { Location = new Point(182, 25), Width = 115 };

            Label lblApe = new Label() { Text = "Apellido:", Location = new Point(310, 28), AutoSize = true };
            txtApellido  = new TextBox() { Location = new Point(368, 25), Width = 115 };

            Label lblHor = new Label() { Text = "Horas:",    Location = new Point(498, 28), AutoSize = true };
            txtHoras     = new TextBox() { Location = new Point(543, 25), Width = 55 };

            Label lblEv  = new Label() { Text = "Eventos:",  Location = new Point(612, 28), AutoSize = true };
            txtEventos   = new TextBox() { Location = new Point(664, 25), Width = 50 };

            Label lblTip = new Label() { Text = "Tipo:",     Location = new Point(728, 28), AutoSize = true };
            cmbTipo      = new ComboBox()
            {
                Location      = new Point(762, 25),
                Width         = 110,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbTipo.Items.AddRange(new string[] { "Modelo", "Publicitario", "Presentador" });
            cmbTipo.SelectedIndex = 0;

            // Fila 2: botones ABMC
            btnAgregar   = new Button() { Text = "Agregar",   Location = new Point(6,   63), Width = 80 };
            btnModificar = new Button() { Text = "Modificar", Location = new Point(92,  63), Width = 80 };
            btnEliminar  = new Button() { Text = "Eliminar",  Location = new Point(178, 63), Width = 80 };
            btnLimpiar   = new Button() { Text = "Limpiar",   Location = new Point(264, 63), Width = 80 };

            btnAgregar.Click   += BtnAgregar_Click;
            btnModificar.Click += BtnModificar_Click;
            btnEliminar.Click  += BtnEliminar_Click;
            btnLimpiar.Click   += (s, e) => LimpiarCampos();

            grpAlta.Controls.AddRange(new Control[] {
                lblLeg, txtLegajo, lblNom, txtNombre, lblApe, txtApellido,
                lblHor, txtHoras, lblEv, txtEventos, lblTip, cmbTipo,
                btnAgregar, btnModificar, btnEliminar, btnLimpiar
            });

            y += 110;

            // ── GRILLA 1: Todos los empleados ─────────────────────────
            GroupBox grpTodos = new GroupBox()
            {
                Text     = "Lista de Todo el Personal",
                Location = new Point(10, y),
                Size     = new Size(1065, 185)
            };
            panel.Controls.Add(grpTodos);

            dgvTodos = CrearDGV(5, 18, 1050, 158);
            dgvTodos.SelectionChanged += DgvTodos_SelectionChanged;
            grpTodos.Controls.Add(dgvTodos);

            // Columnas de la grilla principal
            dgvTodos.Columns.Add("colLeg",    "Legajo");
            dgvTodos.Columns.Add("colNom",    "Nombre");
            dgvTodos.Columns.Add("colApe",    "Apellido");
            dgvTodos.Columns.Add("colTipo",   "Tipo");
            dgvTodos.Columns.Add("colHoras",  "Horas");
            dgvTodos.Columns.Add("colEv",     "Eventos");
            dgvTodos.Columns.Add("colSueldo", "Sueldo ($)");

            // Anchos específicos para que quede legible
            dgvTodos.Columns["colLeg"].Width    = 70;
            dgvTodos.Columns["colNom"].Width    = 140;
            dgvTodos.Columns["colApe"].Width    = 140;
            dgvTodos.Columns["colTipo"].Width   = 110;
            dgvTodos.Columns["colHoras"].Width  = 70;
            dgvTodos.Columns["colEv"].Width     = 70;
            dgvTodos.Columns["colSueldo"].Width = 130;

            y += 195;

            // ── FILTRO POR CATEGORÍA + GRILLA 2 ───────────────────────
            GroupBox grpCategoria = new GroupBox()
            {
                Text     = "Lista por Categoría",
                Location = new Point(10, y),
                Size     = new Size(630, 195)
            };
            panel.Controls.Add(grpCategoria);

            Label lblCat    = new Label() { Text = "Filtrar por tipo:", Location = new Point(6, 22), AutoSize = true };
            cmbFiltroCategoria = new ComboBox()
            {
                Location      = new Point(115, 19),
                Width         = 110,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbFiltroCategoria.Items.AddRange(new string[] { "Todos", "Modelo", "Publicitario", "Presentador" });
            cmbFiltroCategoria.SelectedIndex = 0;
            // Al cambiar el filtro, actualiza la grilla automáticamente
            cmbFiltroCategoria.SelectedIndexChanged += (s, e) => ActualizarGrillaCategoria();

            grpCategoria.Controls.Add(lblCat);
            grpCategoria.Controls.Add(cmbFiltroCategoria);

            dgvCategoria = CrearDGV(5, 45, 615, 142);
            grpCategoria.Controls.Add(dgvCategoria);

            // Mismas columnas que la grilla principal
            dgvCategoria.Columns.Add("colLeg2",    "Legajo");
            dgvCategoria.Columns.Add("colNom2",    "Nombre");
            dgvCategoria.Columns.Add("colApe2",    "Apellido");
            dgvCategoria.Columns.Add("colTipo2",   "Tipo");
            dgvCategoria.Columns.Add("colHoras2",  "Horas");
            dgvCategoria.Columns.Add("colEv2",     "Eventos");
            dgvCategoria.Columns.Add("colSueldo2", "Sueldo ($)");

            dgvCategoria.Columns["colLeg2"].Width    = 60;
            dgvCategoria.Columns["colNom2"].Width    = 110;
            dgvCategoria.Columns["colApe2"].Width    = 110;
            dgvCategoria.Columns["colTipo2"].Width   = 100;
            dgvCategoria.Columns["colHoras2"].Width  = 60;
            dgvCategoria.Columns["colEv2"].Width     = 55;
            dgvCategoria.Columns["colSueldo2"].Width = 95;

            // ── PANEL DE ESTADÍSTICAS ──────────────────────────────────
            GroupBox grpStats = new GroupBox()
            {
                Text     = "Estadísticas y Recaudación",
                Location = new Point(648, y),
                Size     = new Size(427, 195)
            };
            panel.Controls.Add(grpStats);

            // Botón para calcular todas las estadísticas
            btnCalcularTodo = new Button()
            {
                Text     = "▶  Calcular Estadísticas",
                Location = new Point(8, 20),
                Width    = 200,
                Height   = 30,
                BackColor = Color.SteelBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnCalcularTodo.Click += BtnCalcularTodo_Click;
            grpStats.Controls.Add(btnCalcularTodo);

            // Labels para mostrar resultados — se actualizan al presionar el botón
            lblMasEventos = CrearLabelResultado(grpStats,    "Más eventos:",          8,  60);
            lblRecaudacionTotal = CrearLabelResultado(grpStats, "Recaudación total:", 8,  85);
            lblPctModelo        = CrearLabelResultado(grpStats, "% Modelos:",         8, 115);
            lblPctPublicitario  = CrearLabelResultado(grpStats, "% Publicitarios:",   8, 138);
            lblPctPresentador   = CrearLabelResultado(grpStats, "% Presentadores:",   8, 161);

            y += 205;
            panel.AutoScrollMinSize = new Size(0, y + 20);
        }

        // Crea un label de dos partes: título en negrita + valor a su derecha
        private Label CrearLabelResultado(GroupBox padre, string titulo, int x, int top)
        {
            Label lblTit = new Label()
            {
                Text      = titulo,
                Location  = new Point(x, top),
                AutoSize  = true,
                Font      = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            Label lblVal = new Label()
            {
                Text     = "—",
                Location = new Point(x + 145, top),
                Width    = 270,
                AutoSize = false
            };
            padre.Controls.Add(lblTit);
            padre.Controls.Add(lblVal);
            return lblVal; // Devolvemos el label de valor para poder actualizarlo
        }

        // Crea un DataGridView con configuración estándar de solo lectura
        private DataGridView CrearDGV(int x, int y, int w, int h)
        {
            return new DataGridView()
            {
                Location             = new Point(x, y),
                Size                 = new Size(w, h),
                ReadOnly             = true,
                SelectionMode        = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect          = false,
                AllowUserToAddRows   = false,
                AllowUserToDeleteRows= false,
                RowHeadersVisible    = false
            };
        }

        // ========================================================
        //   ACTUALIZACIÓN DE GRILLAS
        // ========================================================

        private void ActualizarGrillaTodos()
        {
            dgvTodos.Rows.Clear();
            // Recorrer la lista y agregar una fila por persona
            foreach (Persona p in listaPersonas)
            {
                // CalcularSueldo() usa polimorfismo — llama al método de la subclase
                decimal sueldo = p.CalcularSueldo();
                dgvTodos.Rows.Add(
                    p.Legajo, p.Nombre, p.Apellido,
                    p.TipoPersona, p.Horas, p.CantEventos,
                    sueldo.ToString("C2")
                );
            }
        }

        private void ActualizarGrillaCategoria()
        {
            dgvCategoria.Rows.Clear();
            string filtro = cmbFiltroCategoria.SelectedItem.ToString();

            // Filtrar según el tipo seleccionado en el ComboBox
            foreach (Persona p in listaPersonas)
            {
                // Si es "Todos" mostramos todos, sino solo los del tipo seleccionado
                if (filtro == "Todos" || p.TipoPersona == filtro)
                {
                    decimal sueldo = p.CalcularSueldo();
                    dgvCategoria.Rows.Add(
                        p.Legajo, p.Nombre, p.Apellido,
                        p.TipoPersona, p.Horas, p.CantEventos,
                        sueldo.ToString("C2")
                    );
                }
            }
        }

        // ========================================================
        //   EVENTO: SELECCIÓN EN GRILLA → CARGAR CAMPOS
        // ========================================================

        private void DgvTodos_SelectionChanged(object sender, EventArgs e)
        {
            Persona p = ObtenerPersonaSeleccionada();
            if (p == null) return;

            // Cargar los datos en los campos para facilitar la modificación
            txtLegajo.Text      = p.Legajo.ToString();
            txtNombre.Text      = p.Nombre;
            txtApellido.Text    = p.Apellido;
            txtHoras.Text       = p.Horas.ToString();
            txtEventos.Text     = p.CantEventos.ToString();
            cmbTipo.SelectedItem = p.TipoPersona;
        }

        private Persona ObtenerPersonaSeleccionada()
        {
            if (dgvTodos.SelectedRows.Count == 0) return null;

            // Buscar por legajo la persona en la lista
            string legajoStr = dgvTodos.SelectedRows[0].Cells["colLeg"].Value.ToString();
            int legajo = int.Parse(legajoStr);
            return listaPersonas.Find(p => p.Legajo == legajo);
        }

        // ========================================================
        //   CRUD ALUMNOS
        // ========================================================

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar y parsear todos los campos antes de crear el objeto
                if (!ValidarCampos(out int legajo, out string nombre, out string apellido,
                                   out double horas, out int eventos)) return;

                // Verificar que el legajo no esté repetido en la lista
                if (listaPersonas.Exists(p => p.Legajo == legajo))
                {
                    MessageBox.Show("Ya existe una persona con ese legajo.", "Legajo duplicado",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear la subclase correcta según el tipo seleccionado (polimorfismo)
                Persona nueva = FabricarPersona(legajo, nombre, apellido, horas, eventos,
                                               cmbTipo.SelectedItem.ToString());

                listaPersonas.Add(nueva);
                ActualizarGrillaTodos();
                ActualizarGrillaCategoria();
                LimpiarCampos();
                MessageBox.Show("Personal agregado correctamente.", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona seleccionada = ObtenerPersonaSeleccionada();
                if (seleccionada == null)
                {
                    MessageBox.Show("Seleccione una persona de la grilla.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar los campos nuevamente antes de modificar
                if (!ValidarCampos(out int legajo, out string nombre, out string apellido,
                                   out double horas, out int eventos)) return;

                // Modificar solo los datos editables (el legajo no cambia)
                seleccionada.Nombre      = nombre;
                seleccionada.Apellido    = apellido;
                seleccionada.Horas       = horas;
                seleccionada.CantEventos = eventos;

                ActualizarGrillaTodos();
                ActualizarGrillaCategoria();
                MessageBox.Show("Datos modificados correctamente.", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona seleccionada = ObtenerPersonaSeleccionada();
                if (seleccionada == null)
                {
                    MessageBox.Show("Seleccione una persona de la grilla.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirmar antes de eliminar
                DialogResult dr = MessageBox.Show(
                    $"¿Eliminar a {seleccionada.Apellido}, {seleccionada.Nombre}?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    listaPersonas.Remove(seleccionada);
                    ActualizarGrillaTodos();
                    ActualizarGrillaCategoria();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtLegajo.Text   = string.Empty;
            txtNombre.Text   = string.Empty;
            txtApellido.Text = string.Empty;
            txtHoras.Text    = string.Empty;
            txtEventos.Text  = string.Empty;
            cmbTipo.SelectedIndex = 0;
            txtLegajo.Focus();
        }

        /// <summary>
        /// Valida los campos del formulario y devuelve los valores parseados.
        /// Retorna false si algún campo es inválido.
        /// </summary>
        private bool ValidarCampos(out int legajo, out string nombre, out string apellido,
                                   out double horas, out int eventos)
        {
            legajo   = 0;
            nombre   = string.Empty;
            apellido = string.Empty;
            horas    = 0;
            eventos  = 0;

            // Validar legajo numérico
            if (!int.TryParse(txtLegajo.Text, out legajo) || legajo <= 0)
            {
                MessageBox.Show("Ingrese un legajo numérico válido (mayor a 0).", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Nombre y Apellido obligatorios
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Nombre y Apellido son obligatorios.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Horas: número positivo
            if (!double.TryParse(txtHoras.Text, out horas) || horas < 0)
            {
                MessageBox.Show("Ingrese una cantidad de horas válida (mayor o igual a 0).", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Eventos: entero no negativo
            if (!int.TryParse(txtEventos.Text, out eventos) || eventos < 0)
            {
                MessageBox.Show("Ingrese una cantidad de eventos válida (mayor o igual a 0).", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            nombre   = txtNombre.Text.Trim();
            apellido = txtApellido.Text.Trim();
            return true;
        }

        /// <summary>
        /// Crea la instancia del tipo correcto de Persona (fábrica simple).
        /// Polimorfismo: devuelve Persona pero crea la subclase adecuada.
        /// </summary>
        private Persona FabricarPersona(int legajo, string nombre, string apellido,
                                        double horas, int eventos, string tipo)
        {
            switch (tipo)
            {
                case "Modelo":       return new Modelo(legajo, nombre, apellido, horas, eventos);
                case "Publicitario": return new Publicitario(legajo, nombre, apellido, horas, eventos);
                case "Presentador":  return new Presentador(legajo, nombre, apellido, horas, eventos);
                default: throw new ArgumentException("Tipo no reconocido: " + tipo);
            }
        }

        // ========================================================
        //   ESTADÍSTICAS — Punto 1 al 4 del enunciado
        // ========================================================

        private void BtnCalcularTodo_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que haya al menos una persona registrada
                if (listaPersonas.Count == 0)
                {
                    MessageBox.Show("No hay personal registrado para calcular.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ── Punto 2: Persona con más eventos ──
                // Usar LINQ para encontrar el máximo (o hacerlo con foreach, ambos válidos)
                Persona conMasEventos = listaPersonas[0];
                foreach (Persona p in listaPersonas)
                {
                    if (p.CantEventos > conMasEventos.CantEventos)
                        conMasEventos = p;
                }
                lblMasEventos.Text = $"{conMasEventos.Apellido}, {conMasEventos.Nombre} ({conMasEventos.CantEventos} eventos)";

                // ── Punto 3: Recaudación total de todos los empleados ──
                // CalcularSueldo() es polimórfico — cada tipo calcula su sueldo diferente
                decimal recaudacionTotal = 0;
                foreach (Persona p in listaPersonas)
                    recaudacionTotal += p.CalcularSueldo();

                lblRecaudacionTotal.Text = recaudacionTotal.ToString("C2");

                // ── Punto 4: Porcentaje de recaudación por tipo ──
                // Calcular la recaudación de cada tipo de persona
                decimal recModelo        = SumaRecaudacionPorTipo("Modelo");
                decimal recPublicitario  = SumaRecaudacionPorTipo("Publicitario");
                decimal recPresentador   = SumaRecaudacionPorTipo("Presentador");

                // Calcular porcentajes sobre el total (evitar división por cero)
                if (recaudacionTotal > 0)
                {
                    double pctModelo       = (double)(recModelo       / recaudacionTotal) * 100;
                    double pctPublicitario = (double)(recPublicitario  / recaudacionTotal) * 100;
                    double pctPresentador  = (double)(recPresentador   / recaudacionTotal) * 100;

                    lblPctModelo.Text       = $"{pctModelo:F1}%  ({recModelo:C2})";
                    lblPctPublicitario.Text = $"{pctPublicitario:F1}%  ({recPublicitario:C2})";
                    lblPctPresentador.Text  = $"{pctPresentador:F1}%  ({recPresentador:C2})";
                }
                else
                {
                    lblPctModelo.Text       = "0%";
                    lblPctPublicitario.Text = "0%";
                    lblPctPresentador.Text  = "0%";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Suma el sueldo de todas las personas de un tipo dado.
        /// Usa polimorfismo: llama a CalcularSueldo() que se resuelve en cada subclase.
        /// </summary>
        private decimal SumaRecaudacionPorTipo(string tipo)
        {
            decimal suma = 0;
            foreach (Persona p in listaPersonas)
            {
                // TipoPersona también es polimórfico — cada subclase devuelve su nombre
                if (p.TipoPersona == tipo)
                    suma += p.CalcularSueldo();
            }
            return suma;
        }
    }
}
