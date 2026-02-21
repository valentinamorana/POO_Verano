namespace TP_UN1_Morana_POO.EJ1
{
    partial class UniversidadForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbAlumno = new System.Windows.Forms.ComboBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.btnGuardarCalificacion = new System.Windows.Forms.Button();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.dgvCursadas = new System.Windows.Forms.DataGridView();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursadas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAlumno
            // 
            this.cmbAlumno.FormattingEnabled = true;
            this.cmbAlumno.Location = new System.Drawing.Point(61, 61);
            this.cmbAlumno.Name = "cmbAlumno";
            this.cmbAlumno.Size = new System.Drawing.Size(170, 21);
            this.cmbAlumno.TabIndex = 0;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(61, 140);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(170, 20);
            this.txtNota.TabIndex = 1;
            // 
            // btnGuardarCalificacion
            // 
            this.btnGuardarCalificacion.Location = new System.Drawing.Point(15, 285);
            this.btnGuardarCalificacion.Name = "btnGuardarCalificacion";
            this.btnGuardarCalificacion.Size = new System.Drawing.Size(88, 23);
            this.btnGuardarCalificacion.TabIndex = 2;
            this.btnGuardarCalificacion.Text = "Guardar Calificacion";
            this.btnGuardarCalificacion.UseVisualStyleBackColor = true;
            this.btnGuardarCalificacion.Click += new System.EventHandler(this.btnGuardarCalificacion_Click);
            // 
            // btnInscribir
            // 
            this.btnInscribir.Location = new System.Drawing.Point(109, 285);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(103, 23);
            this.btnInscribir.TabIndex = 3;
            this.btnInscribir.Text = "Inscribir";
            this.btnInscribir.UseVisualStyleBackColor = true;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // dgvCursadas
            // 
            this.dgvCursadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursadas.Location = new System.Drawing.Point(253, 61);
            this.dgvCursadas.Name = "dgvCursadas";
            this.dgvCursadas.Size = new System.Drawing.Size(690, 264);
            this.dgvCursadas.TabIndex = 4;
            // 
            // cmbMateria
            // 
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(61, 88);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(170, 21);
            this.cmbMateria.TabIndex = 5;
            // 
            // txtComision
            // 
            this.txtComision.Location = new System.Drawing.Point(61, 166);
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(170, 20);
            this.txtComision.TabIndex = 6;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(12, 209);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 7;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(85, 239);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(127, 20);
            this.txtObs.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Alumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Materia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Comisión";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nota";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Observación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(276, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sistema de Calificación UAI";
            // 
            // UniversidadForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 349);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtComision);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.dgvCursadas);
            this.Controls.Add(this.btnInscribir);
            this.Controls.Add(this.btnGuardarCalificacion);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.cmbAlumno);
            this.Name = "UniversidadForms";
            this.Text = "Universidad";
            this.Load += new System.EventHandler(this.UniversidadForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAlumno;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Button btnGuardarCalificacion;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.DataGridView dgvCursadas;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.TextBox txtComision;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}