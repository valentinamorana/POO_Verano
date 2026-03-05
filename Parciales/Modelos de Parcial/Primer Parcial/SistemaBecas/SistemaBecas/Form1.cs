using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SistemaBecas.Dominio;

namespace SistemaBecas
{
    public partial class Form1 : Form
    {
        // ===== LISTAS EN MEMORIA =====
        private List<Alumno> listaAlumnos = new List<Alumno>();
        private List<Beca> listaBecas = new List<Beca>();
        private int contadorIdCuota = 1; // Auto-incremento para IDs de cuota

        // ===== REFERENCIAS A CONTROLES =====

        // Grillas
        private DataGridView dgvAlumnos;
        private DataGridView dgvBecas;
        private DataGridView dgvBecasAlumno;
        private DataGridView dgvCuotas;

        // Campos del alumno
        private TextBox txtLegajo, txtNombre, txtApellido, txtDni;
        private ComboBox cmbTipoAlumno;
        private Button btnAgregarAlumno, btnModificarAlumno, btnEliminarAlumno, btnLimpiarAlumno;

        // Campos de la beca
        private TextBox txtCodigoBeca, txtImporteBeca;
        private DateTimePicker dtpFechaBeca;
        private Button btnAgregarBeca, btnAsignarBeca, btnQuitarBeca;

        // Campos de la cuota
        private TextBox txtMesCuota, txtAnioCuota, txtValorCuota;
        private Button btnPagarCuota;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Sistema de Becas Universitarias — UAI";
            this.Size = new Size(1100, 950);
            this.MinimumSize = new Size(1100, 950);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Construir toda la UI programáticamente
            CrearUI();
        }

        // ========================================================
        //   CONSTRUCCIÓN DE LA INTERFAZ
        // ========================================================

        private void CrearUI()
        {
            // Panel con scroll para que todo quepa en la ventana
            Panel panel = new Panel();
            panel.AutoScroll = true;
            panel.Dock = DockStyle.Fill;
            this.Controls.Add(panel);

            int y = 10;

            // ----- SECCIÓN 1: Datos del Alumno -----
            GroupBox grpAlumno = new GroupBox();
            grpAlumno.Text = "Datos del Alumno";
            grpAlumno.Location = new Point(10, y);
            grpAlumno.Size = new Size(1060, 100);
            panel.Controls.Add(grpAlumno);

            // Labels y TextBoxes para los datos del alumno
            Label lblLegajo = new Label() { Text = "Legajo:", Location = new Point(8, 28), AutoSize = true };
            txtLegajo = new TextBox() { Location = new Point(60, 25), Width = 75 };

            Label lblNombre = new Label() { Text = "Nombre:", Location = new Point(150, 28), AutoSize = true };
            txtNombre = new TextBox() { Location = new Point(205, 25), Width = 120 };

            Label lblApellido = new Label() { Text = "Apellido:", Location = new Point(340, 28), AutoSize = true };
            txtApellido = new TextBox() { Location = new Point(398, 25), Width = 120 };

            Label lblDni = new Label() { Text = "DNI:", Location = new Point(535, 28), AutoSize = true };
            txtDni = new TextBox() { Location = new Point(563, 25), Width = 100 };

            Label lblTipo = new Label() { Text = "Tipo:", Location = new Point(678, 28), AutoSize = true };
            cmbTipoAlumno = new ComboBox()
            {
                Location = new Point(710, 25),
                Width = 110,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            // Cargar los tipos de alumno disponibles
            cmbTipoAlumno.Items.AddRange(new string[] { "Ingresante", "Grado", "Posgrado" });
            cmbTipoAlumno.SelectedIndex = 0;

            // Botones de ABMC para alumnos
            btnAgregarAlumno   = new Button() { Text = "Agregar",   Location = new Point(8,   62), Width = 80 };
            btnModificarAlumno = new Button() { Text = "Modificar", Location = new Point(95,  62), Width = 80 };
            btnEliminarAlumno  = new Button() { Text = "Eliminar",  Location = new Point(182, 62), Width = 80 };
            btnLimpiarAlumno   = new Button() { Text = "Limpiar",   Location = new Point(269, 62), Width = 80 };

            // Asignar eventos Click
            btnAgregarAlumno.Click   += BtnAgregarAlumno_Click;
            btnModificarAlumno.Click += BtnModificarAlumno_Click;
            btnEliminarAlumno.Click  += BtnEliminarAlumno_Click;
            btnLimpiarAlumno.Click   += (s, e) => LimpiarCamposAlumno();

            grpAlumno.Controls.AddRange(new Control[] {
                lblLegajo, txtLegajo, lblNombre, txtNombre,
                lblApellido, txtApellido, lblDni, txtDni,
                lblTipo, cmbTipoAlumno,
                btnAgregarAlumno, btnModificarAlumno, btnEliminarAlumno, btnLimpiarAlumno
            });

            y += 110;

            // ----- GRILLA 1: Todos los Beneficiarios -----
            GroupBox grpG1 = new GroupBox();
            grpG1.Text = "1. Todos los Beneficiarios";
            grpG1.Location = new Point(10, y);
            grpG1.Size = new Size(1060, 175);
            panel.Controls.Add(grpG1);

            dgvAlumnos = CrearDataGridView(5, 20, 1045, 145);
            dgvAlumnos.SelectionChanged += DgvAlumnos_SelectionChanged;
            grpG1.Controls.Add(dgvAlumnos);

            // Columnas de la grilla 1
            dgvAlumnos.Columns.Add("colLegajo",   "Legajo");
            dgvAlumnos.Columns.Add("colNombre",   "Nombre");
            dgvAlumnos.Columns.Add("colApellido", "Apellido");
            dgvAlumnos.Columns.Add("colDni",      "DNI");
            dgvAlumnos.Columns.Add("colTipo",     "Tipo");
            AjustarAnchoColumnas(dgvAlumnos, 200);

            y += 185;

            // ----- SECCIÓN: Datos de la Beca -----
            GroupBox grpBeca = new GroupBox();
            grpBeca.Text = "Datos de la Beca";
            grpBeca.Location = new Point(10, y);
            grpBeca.Size = new Size(1060, 65);
            panel.Controls.Add(grpBeca);

            Label lblCod = new Label() { Text = "Código (4num+2let):", Location = new Point(8, 28), AutoSize = true };
            txtCodigoBeca = new TextBox() { Location = new Point(155, 25), Width = 75, MaxLength = 6 };
            txtCodigoBeca.CharacterCasing = CharacterCasing.Upper; // Auto mayúsculas

            Label lblFechaBeca = new Label() { Text = "Fecha:", Location = new Point(248, 28), AutoSize = true };
            dtpFechaBeca = new DateTimePicker() { Location = new Point(292, 25), Width = 140, Format = DateTimePickerFormat.Short };

            Label lblImp = new Label() { Text = "Importe $:", Location = new Point(448, 28), AutoSize = true };
            txtImporteBeca = new TextBox() { Location = new Point(515, 25), Width = 90 };

            btnAgregarBeca = new Button() { Text = "Agregar Beca",       Location = new Point(618, 23), Width = 105 };
            btnAsignarBeca = new Button() { Text = "Asignar al Alumno",  Location = new Point(730, 23), Width = 130 };
            btnQuitarBeca  = new Button() { Text = "Quitar del Alumno",  Location = new Point(868, 23), Width = 130 };

            btnAgregarBeca.Click += BtnAgregarBeca_Click;
            btnAsignarBeca.Click += BtnAsignarBeca_Click;
            btnQuitarBeca.Click  += BtnQuitarBeca_Click;

            grpBeca.Controls.AddRange(new Control[] {
                lblCod, txtCodigoBeca, lblFechaBeca, dtpFechaBeca,
                lblImp, txtImporteBeca,
                btnAgregarBeca, btnAsignarBeca, btnQuitarBeca
            });

            y += 75;

            // ----- GRILLA 2 y 3 lado a lado -----

            // GRILLA 2: Todas las becas
            GroupBox grpG2 = new GroupBox();
            grpG2.Text = "2. Todas las Becas";
            grpG2.Location = new Point(10, y);
            grpG2.Size = new Size(515, 155);
            panel.Controls.Add(grpG2);

            dgvBecas = CrearDataGridView(5, 20, 500, 125);
            grpG2.Controls.Add(dgvBecas);

            dgvBecas.Columns.Add("colCodBeca",    "Código");
            dgvBecas.Columns.Add("colFechaBeca",  "Fecha Otorgamiento");
            dgvBecas.Columns.Add("colImpBeca",    "Importe ($)");
            dgvBecas.Columns["colCodBeca"].Width   = 90;
            dgvBecas.Columns["colFechaBeca"].Width = 200;
            dgvBecas.Columns["colImpBeca"].Width   = 160;

            // GRILLA 3: Becas del alumno seleccionado
            GroupBox grpG3 = new GroupBox();
            grpG3.Text = "3. Becas del Alumno Seleccionado";
            grpG3.Location = new Point(535, y);
            grpG3.Size = new Size(535, 155);
            panel.Controls.Add(grpG3);

            dgvBecasAlumno = CrearDataGridView(5, 20, 520, 125);
            grpG3.Controls.Add(dgvBecasAlumno);

            dgvBecasAlumno.Columns.Add("colCodBecaA",   "Código");
            dgvBecasAlumno.Columns.Add("colFechaBecaA", "Fecha Otorgamiento");
            dgvBecasAlumno.Columns.Add("colImpBecaA",   "Importe ($)");
            dgvBecasAlumno.Columns["colCodBecaA"].Width   = 90;
            dgvBecasAlumno.Columns["colFechaBecaA"].Width = 200;
            dgvBecasAlumno.Columns["colImpBecaA"].Width   = 160;

            y += 165;

            // ----- SECCIÓN: Pagar Cuota -----
            GroupBox grpCuota = new GroupBox();
            grpCuota.Text = "Registrar Pago de Cuota";
            grpCuota.Location = new Point(10, y);
            grpCuota.Size = new Size(1060, 60);
            panel.Controls.Add(grpCuota);

            Label lblMes = new Label() { Text = "Mes:", Location = new Point(8, 28), AutoSize = true };
            txtMesCuota = new TextBox() { Location = new Point(43, 25), Width = 40 };

            Label lblAnio = new Label() { Text = "Año:", Location = new Point(100, 28), AutoSize = true };
            txtAnioCuota = new TextBox() { Location = new Point(135, 25), Width = 55 };

            Label lblValCuota = new Label() { Text = "Valor Cuota ($):", Location = new Point(208, 28), AutoSize = true };
            txtValorCuota = new TextBox() { Location = new Point(305, 25), Width = 90 };

            btnPagarCuota = new Button() { Text = "Registrar Pago", Location = new Point(412, 23), Width = 115 };
            btnPagarCuota.Click += BtnPagarCuota_Click;

            grpCuota.Controls.AddRange(new Control[] {
                lblMes, txtMesCuota, lblAnio, txtAnioCuota,
                lblValCuota, txtValorCuota, btnPagarCuota
            });

            y += 70;

            // ----- GRILLA 4: Cuotas del alumno -----
            GroupBox grpG4 = new GroupBox();
            grpG4.Text = "4. Cuotas Pagas del Alumno Seleccionado";
            grpG4.Location = new Point(10, y);
            grpG4.Size = new Size(1060, 190);
            panel.Controls.Add(grpG4);

            dgvCuotas = CrearDataGridView(5, 20, 1045, 160);
            grpG4.Controls.Add(dgvCuotas);

            // Columnas de la grilla 4 según el enunciado
            dgvCuotas.Columns.Add("colIdCuota",  "ID");
            dgvCuotas.Columns.Add("colMesAnio",  "Mes/Año");
            dgvCuotas.Columns.Add("colFechaPago","Fecha de Pago");
            dgvCuotas.Columns.Add("colImpCuota", "Importe Cuota");
            dgvCuotas.Columns.Add("colImpBecaC", "Importe Beca*");
            dgvCuotas.Columns.Add("colBeneficio","Beneficio");
            dgvCuotas.Columns.Add("colNeto",     "Neto a Pagar");
            AjustarAnchoColumnas(dgvCuotas, 143);

            y += 200;

            // Definir el tamaño mínimo del panel para el scroll
            panel.AutoScrollMinSize = new Size(0, y + 20);
        }

        /// <summary>
        /// Método auxiliar para crear DataGridViews con la configuración estándar.
        /// </summary>
        private DataGridView CrearDataGridView(int x, int y, int w, int h)
        {
            DataGridView dgv = new DataGridView();
            dgv.Location = new Point(x, y);
            dgv.Size = new Size(w, h);
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            return dgv;
        }

        // Ajusta el ancho de todas las columnas de una grilla al mismo valor
        private void AjustarAnchoColumnas(DataGridView dgv, int ancho)
        {
            foreach (DataGridViewColumn col in dgv.Columns)
                col.Width = ancho;
        }

        // ========================================================
        //   ACTUALIZACIÓN DE GRILLAS
        // ========================================================

        private void ActualizarGrillaAlumnos()
        {
            dgvAlumnos.Rows.Clear();
            // Recorrer todos los alumnos y agregar una fila por cada uno
            foreach (Alumno a in listaAlumnos)
                dgvAlumnos.Rows.Add(a.Legajo, a.Nombre, a.Apellido, a.Dni, a.TipoAlumno);
        }

        private void ActualizarGrillaBecas()
        {
            dgvBecas.Rows.Clear();
            // Mostrar todas las becas del sistema
            foreach (Beca b in listaBecas)
                dgvBecas.Rows.Add(b.Codigo, b.FechaOtorgamiento.ToShortDateString(), b.Importe.ToString("F2"));
        }

        private void ActualizarGrillaBecasAlumno(Alumno alumno)
        {
            dgvBecasAlumno.Rows.Clear();
            if (alumno == null) return;

            // Mostrar solo las becas del alumno seleccionado
            foreach (Beca b in alumno.Becas)
                dgvBecasAlumno.Rows.Add(b.Codigo, b.FechaOtorgamiento.ToShortDateString(), b.Importe.ToString("F2"));
        }

        private void ActualizarGrillaCuotas(Alumno alumno)
        {
            dgvCuotas.Rows.Clear();
            if (alumno == null) return;

            // Calcular la sumatoria de becas del alumno (se muestra en cada fila)
            decimal totalBecas = alumno.ObtenerTotalBecas();

            foreach (Cuota c in alumno.Cuotas)
            {
                // Calcular beneficio y neto usando polimorfismo
                decimal beneficio = alumno.CalcularBeneficio(c.Valor);
                decimal neto      = alumno.CalcularNetoPagar(c.Valor);

                dgvCuotas.Rows.Add(
                    c.Id,
                    $"{c.Mes:D2}/{c.Anio}",
                    c.FechaPago.ToShortDateString(),
                    c.Valor.ToString("F2"),
                    totalBecas.ToString("F2"),
                    beneficio.ToString("F2"),
                    neto.ToString("F2")
                );
            }
        }

        // ========================================================
        //   EVENTO: CAMBIO DE SELECCIÓN EN GRILLA 1
        // ========================================================

        private void DgvAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            // Al cambiar el alumno seleccionado, actualizar grillas 3 y 4
            Alumno seleccionado = ObtenerAlumnoSeleccionado();
            ActualizarGrillaBecasAlumno(seleccionado);
            ActualizarGrillaCuotas(seleccionado);

            // Cargar los datos del alumno en los campos para facilitar la modificación
            if (seleccionado != null)
            {
                txtLegajo.Text  = seleccionado.Legajo;
                txtNombre.Text  = seleccionado.Nombre;
                txtApellido.Text = seleccionado.Apellido;
                txtDni.Text     = seleccionado.Dni;
                cmbTipoAlumno.SelectedItem = seleccionado.TipoAlumno;
            }
        }

        /// <summary>
        /// Obtiene el objeto Alumno correspondiente a la fila seleccionada en la Grilla 1.
        /// </summary>
        private Alumno ObtenerAlumnoSeleccionado()
        {
            if (dgvAlumnos.SelectedRows.Count == 0) return null;

            string legajo = dgvAlumnos.SelectedRows[0].Cells["colLegajo"].Value.ToString();
            return listaAlumnos.Find(a => a.Legajo == legajo);
        }

        // ========================================================
        //   EVENTOS CRUD ALUMNOS
        // ========================================================

        private void BtnAgregarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que todos los campos estén completos
                if (string.IsNullOrWhiteSpace(txtLegajo.Text)   ||
                    string.IsNullOrWhiteSpace(txtNombre.Text)   ||
                    string.IsNullOrWhiteSpace(txtApellido.Text) ||
                    string.IsNullOrWhiteSpace(txtDni.Text))
                {
                    MessageBox.Show("Todos los campos del alumno son obligatorios.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar que el legajo no esté repetido
                if (listaAlumnos.Exists(a => a.Legajo == txtLegajo.Text.Trim()))
                {
                    MessageBox.Show("Ya existe un alumno con ese legajo.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear el tipo de alumno correcto según la selección del ComboBox
                // Aquí se usa polimorfismo: el método devuelve un Alumno pero puede ser cualquier subtipo
                Alumno nuevo = FabricarAlumno(
                    txtLegajo.Text.Trim(),
                    txtNombre.Text.Trim(),
                    txtApellido.Text.Trim(),
                    txtDni.Text.Trim(),
                    cmbTipoAlumno.SelectedItem.ToString()
                );

                listaAlumnos.Add(nuevo);
                ActualizarGrillaAlumnos();
                LimpiarCamposAlumno();
                MessageBox.Show("Alumno agregado correctamente.", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar alumno: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno seleccionado = ObtenerAlumnoSeleccionado();
                if (seleccionado == null)
                {
                    MessageBox.Show("Primero seleccione un alumno de la grilla.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Actualizar solo nombre, apellido y DNI (el legajo y tipo no se modifican)
                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    MessageBox.Show("Nombre y Apellido son obligatorios.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                seleccionado.Nombre   = txtNombre.Text.Trim();
                seleccionado.Apellido = txtApellido.Text.Trim();
                seleccionado.Dni      = txtDni.Text.Trim();

                ActualizarGrillaAlumnos();
                MessageBox.Show("Alumno modificado correctamente.", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno seleccionado = ObtenerAlumnoSeleccionado();
                if (seleccionado == null)
                {
                    MessageBox.Show("Primero seleccione un alumno de la grilla.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Pedir confirmación antes de eliminar
                DialogResult dr = MessageBox.Show(
                    $"¿Desea eliminar al alumno {seleccionado.Apellido}, {seleccionado.Nombre}?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    listaAlumnos.Remove(seleccionado);
                    ActualizarGrillaAlumnos();
                    LimpiarCamposAlumno();
                    // Limpiar grillas dependientes
                    dgvBecasAlumno.Rows.Clear();
                    dgvCuotas.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Limpia los campos de entrada del alumno
        private void LimpiarCamposAlumno()
        {
            txtLegajo.Text   = string.Empty;
            txtNombre.Text   = string.Empty;
            txtApellido.Text = string.Empty;
            txtDni.Text      = string.Empty;
            cmbTipoAlumno.SelectedIndex = 0;
            txtLegajo.Focus();
        }

        /// <summary>
        /// Crea el tipo de alumno correcto según el parámetro tipo.
        /// Patrón simple de fábrica para aprovechar polimorfismo.
        /// </summary>
        private Alumno FabricarAlumno(string legajo, string nombre, string apellido, string dni, string tipo)
        {
            switch (tipo)
            {
                case "Ingresante": return new AlumnoIngresante(legajo, nombre, apellido, dni);
                case "Grado":      return new AlumnoGrado(legajo, nombre, apellido, dni);
                case "Posgrado":   return new AlumnoPosgrado(legajo, nombre, apellido, dni);
                default: throw new ArgumentException("Tipo de alumno no reconocido: " + tipo);
            }
        }

        // ========================================================
        //   EVENTOS BECAS
        // ========================================================

        private void BtnAgregarBeca_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigoBeca.Text.Trim().ToUpper();

                // Validar el formato del código: exactamente 4 dígitos + 2 letras
                if (!Regex.IsMatch(codigo, @"^\d{4}[A-Z]{2}$"))
                {
                    MessageBox.Show("El código debe tener 4 números seguidos de 2 letras.\nEjemplo: 1234AB",
                        "Código Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar que el código no esté repetido
                if (listaBecas.Exists(b => b.Codigo == codigo))
                {
                    MessageBox.Show("Ya existe una beca con ese código.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar el importe ingresado
                if (!decimal.TryParse(txtImporteBeca.Text, out decimal importe) || importe <= 0)
                {
                    MessageBox.Show("Ingrese un importe válido mayor a cero.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear la nueva beca y agregarla a la lista global
                Beca nuevaBeca = new Beca(codigo, dtpFechaBeca.Value.Date, importe);
                listaBecas.Add(nuevaBeca);

                ActualizarGrillaBecas();
                txtCodigoBeca.Text   = string.Empty;
                txtImporteBeca.Text  = string.Empty;
                MessageBox.Show("Beca creada correctamente.", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear beca: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAsignarBeca_Click(object sender, EventArgs e)
        {
            try
            {
                // Se necesita un alumno seleccionado (Grilla 1)
                Alumno alumno = ObtenerAlumnoSeleccionado();
                if (alumno == null)
                {
                    MessageBox.Show("Seleccione un alumno en la Grilla 1.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Se necesita una beca seleccionada (Grilla 2)
                if (dgvBecas.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una beca en la Grilla 2.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener la beca seleccionada de la lista global
                string codigoBeca = dgvBecas.SelectedRows[0].Cells["colCodBeca"].Value.ToString();
                Beca beca = listaBecas.Find(b => b.Codigo == codigoBeca);

                // Verificar que el alumno no tenga ya esa beca
                if (alumno.Becas.Contains(beca))
                {
                    MessageBox.Show("El alumno ya tiene esa beca asignada.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // AgregarBeca valida el máximo de 2 (lanza excepción si se supera)
                alumno.AgregarBeca(beca);

                ActualizarGrillaBecasAlumno(alumno);
                MessageBox.Show("Beca asignada correctamente al alumno.", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InvalidOperationException ex)
            {
                // Captura específica para el error de máximo de becas
                MessageBox.Show(ex.Message, "Límite Alcanzado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asignar beca: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnQuitarBeca_Click(object sender, EventArgs e)
        {
            try
            {
                // Alumno seleccionado en Grilla 1
                Alumno alumno = ObtenerAlumnoSeleccionado();
                if (alumno == null)
                {
                    MessageBox.Show("Seleccione un alumno en la Grilla 1.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Beca seleccionada en Grilla 3 (becas del alumno)
                if (dgvBecasAlumno.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una beca en la Grilla 3 (becas del alumno).", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string codigoBeca = dgvBecasAlumno.SelectedRows[0].Cells["colCodBecaA"].Value.ToString();
                Beca beca = listaBecas.Find(b => b.Codigo == codigoBeca);

                // Quitar la beca del alumno (la beca sigue existiendo en la lista global)
                alumno.QuitarBeca(beca);

                ActualizarGrillaBecasAlumno(alumno);
                MessageBox.Show("Beca quitada del alumno correctamente.", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al quitar beca: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ========================================================
        //   EVENTO PAGAR CUOTA
        // ========================================================

        private void BtnPagarCuota_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que haya un alumno seleccionado
                Alumno alumno = ObtenerAlumnoSeleccionado();
                if (alumno == null)
                {
                    MessageBox.Show("Seleccione un alumno en la Grilla 1.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar el mes
                if (!int.TryParse(txtMesCuota.Text, out int mes) || mes < 1 || mes > 12)
                {
                    MessageBox.Show("Ingrese un mes válido (1 a 12).", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar el año
                if (!int.TryParse(txtAnioCuota.Text, out int anio) || anio < 2000 || anio > 2100)
                {
                    MessageBox.Show("Ingrese un año válido.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar el valor de la cuota
                if (!decimal.TryParse(txtValorCuota.Text, out decimal valor) || valor <= 0)
                {
                    MessageBox.Show("Ingrese un valor de cuota válido mayor a cero.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar que las becas no superen el 100% del valor de la cuota
                decimal totalBecas = alumno.ObtenerTotalBecas();
                if (totalBecas > valor)
                {
                    MessageBox.Show("El importe de las becas no puede superar el valor de la cuota.",
                        "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Registrar el pago — PagarCuota crea la Cuota internamente (composición)
                alumno.PagarCuota(contadorIdCuota++, mes, anio, valor);

                ActualizarGrillaCuotas(alumno);
                txtMesCuota.Text  = string.Empty;
                txtAnioCuota.Text = string.Empty;
                txtValorCuota.Text = string.Empty;
                MessageBox.Show("Cuota registrada correctamente.", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar cuota: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
