using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_UN1_Morana_POO.EJ1.Cursadas;
using TP_UN1_Morana_POO.EJ1.Personas;
using TP_UN1_Morana_POO.EJ1.Universidades;

namespace TP_UN1_Morana_POO.EJ1
{
    public partial class UniversidadForms : Form
    {
        private Universidad uni;
        private List<Materia> materias = new List<Materia>();

        // Para mostrar en la grilla de forma cómoda (porque Cursada tiene objetos anidados)
        private BindingList<CursadaRow> gridBinding = new BindingList<CursadaRow>();
        public UniversidadForms()
        {
            InitializeComponent();
            CargarDatos();
            InicializarUI();
        }
      
        private void CargarDatos()
        {
            // Universidad
            uni = new Universidad("UAI");

            // Hardcodeo un par de materias para ver el funcionamiento del sistema
            materias.Add(new Materia("MAT101", "Matemática", 1, 1));
            materias.Add(new Materia("PRO102", "Inglés", 1, 1));
            materias.Add(new Materia("POO201", "POO", 2, 1));
            materias.Add(new Materia("POO301", "Base de Datos", 2, 2));

            // Hardcodeo un par de alumnos para ver el funcionamiento del sistema
            uni.RegistrarAlumno(new Alumno(
                id: 1, nombre: "Valentina", apellido: "Morana", documento: 12345678, email: "valenchu@mail.com",
                legajo: "A001", fechaIngreso: new DateTime(2024, 3, 1)));

            uni.RegistrarAlumno(new Alumno(
                id: 2, nombre: "Ignacio", apellido: "Gomez", documento: 23456789, email: "ignacioxd@mail.com",
                legajo: "A002", fechaIngreso: new DateTime(2024, 3, 1)));

            uni.RegistrarAlumno(new Alumno(
               id: 2, nombre: "Pepi", apellido: "Rodriguez", documento: 23456999, email: "pepita@mail.com",
               legajo: "A003", fechaIngreso: new DateTime(2024, 3, 1)));

            uni.Alumnos[0].Inscribirse(materias[0], "1A");
            uni.Alumnos[0].Inscribirse(materias[1], "1B");
        }

        private void InicializarUI()
        {
            // Combos
            cmbAlumno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMateria.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbAlumno.DataSource = uni.Alumnos;
            cmbAlumno.DisplayMember = "Nombre"; // Alumno hereda de Persona y tiene Nombre

            cmbMateria.DataSource = materias;
            cmbMateria.DisplayMember = "NombreMateria"; // en tu ZIP se llama así

            // Grilla
            dgvCursadas.AutoGenerateColumns = true;
            dgvCursadas.DataSource = gridBinding;

            // Defaults
            dtpFecha.Value = DateTime.Today;

            // Refrescar cuando cambia el alumno
            cmbAlumno.SelectedIndexChanged += (s, e) => RefrescarGrilla();
            RefrescarGrilla();
        }

        private Alumno AlumnoSeleccionado()
        {
            return cmbAlumno.SelectedItem as Alumno;
        }

        private Materia MateriaSeleccionada()
        {
            return cmbMateria.SelectedItem as Materia;
        }

        private void RefrescarGrilla()
        {
            var a = AlumnoSeleccionado();
            if (a == null) return;

            var rows = a.Cursadas.Select(c => new CursadaRow(c)).ToList();

            gridBinding = new BindingList<CursadaRow>(rows);
            dgvCursadas.DataSource = gridBinding;
        }

        private void btnGuardarCalificacion_Click(object sender, EventArgs e)
        {
            var a = AlumnoSeleccionado();
            if (a == null) return;

            if (dgvCursadas.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná una cursada en la grilla.");
                return;
            }

            // Recupero la cursada real desde el row wrapper
            var row = dgvCursadas.CurrentRow.DataBoundItem as CursadaRow;
            if (row == null || row.Source == null)
            {
                MessageBox.Show("No se pudo obtener la cursada seleccionada.");
                return;
            }

            if (!float.TryParse(txtNota.Text, out float nota))
            {
                MessageBox.Show("Nota inválida.");
                return;
            }

            // Tu modelo: Cursada tiene una sola Calificacion
            row.Source.Calificacion = new Calificacion(nota, dtpFecha.Value, txtObs.Text);

            MessageBox.Show("Calificación guardada.");
            txtNota.Clear();
            txtObs.Clear();
            RefrescarGrilla();
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            var a = AlumnoSeleccionado();
            var m = MateriaSeleccionada();

            if (a == null || m == null)
            {
                MessageBox.Show("Seleccioná alumno y materia.");
                return;
            }

            string comision = txtComision.Text.Trim();
            if (string.IsNullOrWhiteSpace(comision))
            {
                MessageBox.Show("Ingresá una comisión.");
                return;
            }

            // Crea la cursada y la agrega al alumno
            a.Inscribirse(m, comision);

            MessageBox.Show("Inscripción realizada.");
            txtComision.Clear();
            RefrescarGrilla();
        }

        // Wrapper para DataGridView (para mostrar columnas planas)
        private class CursadaRow
        {
            public Cursada Source { get; }

            public string Materia => Source.Materia?.NombreMateria;
            public string Codigo => Source.Materia?.Codigo;
            public int Anio => Source.Materia?.Anio ?? 0;
            public int Cuatrimestre => Source.Materia?.Cuatrimestre ?? 0;

            public string Comision => Source.Comision;

            public float? Nota => Source.Calificacion?.Nota;
            public DateTime? Fecha => Source.Calificacion?.Fecha;
            public string Observacion => Source.Calificacion?.Observacion;

            public bool Aprobo => Source.Aprobo();

            public CursadaRow(Cursada c)
            {
                Source = c;
            }
        }

        private void UniversidadForms_Load(object sender, EventArgs e)
        {

        }
    }
}
