namespace TP_UN2_Morana_POO.EJ7
{
    partial class FormEJ7
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
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSetComision = new System.Windows.Forms.Button();
            this.btnCalcularTotal = new System.Windows.Forms.Button();
            this.btnCargarEmpleado = new System.Windows.Forms.Button();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.btnAgregarBono = new System.Windows.Forms.Button();
            this.btnMostrarBono = new System.Windows.Forms.Button();
            this.btnCrearDepartamento = new System.Windows.Forms.Button();
            this.btnAgregarAlDepartamento = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.txtBono = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(17, 276);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(865, 321);
            this.dgvEmpleados.TabIndex = 3;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Apellido Empleado";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(355, 34);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(163, 20);
            this.txtApellido.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(521, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cargo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(697, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Salario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nombre Empleado";
            // 
            // btnSetComision
            // 
            this.btnSetComision.Location = new System.Drawing.Point(187, 137);
            this.btnSetComision.Name = "btnSetComision";
            this.btnSetComision.Size = new System.Drawing.Size(107, 25);
            this.btnSetComision.TabIndex = 17;
            this.btnSetComision.Text = "Asignar Comisión";
            this.btnSetComision.UseVisualStyleBackColor = true;
            this.btnSetComision.Click += new System.EventHandler(this.btnSetComision_Click);
            // 
            // btnCalcularTotal
            // 
            this.btnCalcularTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularTotal.Location = new System.Drawing.Point(423, 69);
            this.btnCalcularTotal.Name = "btnCalcularTotal";
            this.btnCalcularTotal.Size = new System.Drawing.Size(443, 39);
            this.btnCalcularTotal.TabIndex = 16;
            this.btnCalcularTotal.Text = "Calcular Total";
            this.btnCalcularTotal.UseVisualStyleBackColor = true;
            this.btnCalcularTotal.Click += new System.EventHandler(this.btnCalcularTotal_Click);
            // 
            // btnCargarEmpleado
            // 
            this.btnCargarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarEmpleado.Location = new System.Drawing.Point(16, 69);
            this.btnCargarEmpleado.Name = "btnCargarEmpleado";
            this.btnCargarEmpleado.Size = new System.Drawing.Size(401, 39);
            this.btnCargarEmpleado.TabIndex = 15;
            this.btnCargarEmpleado.Text = "Cargar Empleado";
            this.btnCargarEmpleado.UseVisualStyleBackColor = true;
            this.btnCargarEmpleado.Click += new System.EventHandler(this.btnCargarEmpleado_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(700, 34);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(166, 20);
            this.txtSalario.TabIndex = 14;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(524, 34);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(170, 20);
            this.txtCargo.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(186, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(163, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Legajo";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(17, 34);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(163, 20);
            this.txtLegajo.TabIndex = 23;
            // 
            // btnAgregarBono
            // 
            this.btnAgregarBono.Location = new System.Drawing.Point(188, 181);
            this.btnAgregarBono.Name = "btnAgregarBono";
            this.btnAgregarBono.Size = new System.Drawing.Size(95, 25);
            this.btnAgregarBono.TabIndex = 25;
            this.btnAgregarBono.Text = "Agregar Bono";
            this.btnAgregarBono.UseVisualStyleBackColor = true;
            this.btnAgregarBono.Click += new System.EventHandler(this.btnAgregarBono_Click);
            // 
            // btnMostrarBono
            // 
            this.btnMostrarBono.Location = new System.Drawing.Point(369, 140);
            this.btnMostrarBono.Name = "btnMostrarBono";
            this.btnMostrarBono.Size = new System.Drawing.Size(176, 44);
            this.btnMostrarBono.TabIndex = 26;
            this.btnMostrarBono.Text = "Mostrar Bono";
            this.btnMostrarBono.UseVisualStyleBackColor = true;
            this.btnMostrarBono.Click += new System.EventHandler(this.btnMostrarBono_Click);
            // 
            // btnCrearDepartamento
            // 
            this.btnCrearDepartamento.Location = new System.Drawing.Point(188, 223);
            this.btnCrearDepartamento.Name = "btnCrearDepartamento";
            this.btnCrearDepartamento.Size = new System.Drawing.Size(116, 27);
            this.btnCrearDepartamento.TabIndex = 27;
            this.btnCrearDepartamento.Text = "Crear Departamento";
            this.btnCrearDepartamento.UseVisualStyleBackColor = true;
            this.btnCrearDepartamento.Click += new System.EventHandler(this.btnCrearDepartamento_Click);
            // 
            // btnAgregarAlDepartamento
            // 
            this.btnAgregarAlDepartamento.Location = new System.Drawing.Point(369, 190);
            this.btnAgregarAlDepartamento.Name = "btnAgregarAlDepartamento";
            this.btnAgregarAlDepartamento.Size = new System.Drawing.Size(176, 41);
            this.btnAgregarAlDepartamento.TabIndex = 28;
            this.btnAgregarAlDepartamento.Text = "Agregar Al Departamento";
            this.btnAgregarAlDepartamento.UseVisualStyleBackColor = true;
            this.btnAgregarAlDepartamento.Click += new System.EventHandler(this.btnAgregarAlDepartamento_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(815, 243);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(67, 27);
            this.btnLimpiar.TabIndex = 29;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtComision
            // 
            this.txtComision.Location = new System.Drawing.Point(16, 140);
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(163, 20);
            this.txtComision.TabIndex = 30;
            // 
            // txtBono
            // 
            this.txtBono.Location = new System.Drawing.Point(16, 183);
            this.txtBono.Name = "txtBono";
            this.txtBono.Size = new System.Drawing.Size(163, 20);
            this.txtBono.TabIndex = 31;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(16, 227);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(163, 20);
            this.txtDepartamento.TabIndex = 32;
            // 
            // FormEJ7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 622);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.txtBono);
            this.Controls.Add(this.txtComision);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregarAlDepartamento);
            this.Controls.Add(this.btnCrearDepartamento);
            this.Controls.Add(this.btnMostrarBono);
            this.Controls.Add(this.btnAgregarBono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSetComision);
            this.Controls.Add(this.btnCalcularTotal);
            this.Controls.Add(this.btnCargarEmpleado);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dgvEmpleados);
            this.Name = "FormEJ7";
            this.Text = "FormEJ7";
            this.Load += new System.EventHandler(this.FormEJ7_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSetComision;
        private System.Windows.Forms.Button btnCalcularTotal;
        private System.Windows.Forms.Button btnCargarEmpleado;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Button btnAgregarBono;
        private System.Windows.Forms.Button btnMostrarBono;
        private System.Windows.Forms.Button btnCrearDepartamento;
        private System.Windows.Forms.Button btnAgregarAlDepartamento;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtComision;
        private System.Windows.Forms.TextBox txtBono;
        private System.Windows.Forms.TextBox txtDepartamento;
    }
}