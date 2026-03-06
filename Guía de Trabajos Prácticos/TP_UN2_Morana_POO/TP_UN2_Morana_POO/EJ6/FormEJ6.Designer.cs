namespace TP_UN2_Morana_POO.EJ6
{
    partial class FormEJ6
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
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtBono = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnCargarEmpleado = new System.Windows.Forms.Button();
            this.btnCalcularSalario = new System.Windows.Forms.Button();
            this.btnCalcularBono = new System.Windows.Forms.Button();
            this.lstEmpleados = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(12, 30);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(163, 20);
            this.txtNombreEmpleado.TabIndex = 0;
            // 
            // txtBono
            // 
            this.txtBono.Location = new System.Drawing.Point(540, 30);
            this.txtBono.Name = "txtBono";
            this.txtBono.Size = new System.Drawing.Size(170, 20);
            this.txtBono.TabIndex = 1;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(361, 30);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(166, 20);
            this.txtSalario.TabIndex = 2;
            // 
            // btnCargarEmpleado
            // 
            this.btnCargarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarEmpleado.Location = new System.Drawing.Point(11, 70);
            this.btnCargarEmpleado.Name = "btnCargarEmpleado";
            this.btnCargarEmpleado.Size = new System.Drawing.Size(338, 39);
            this.btnCargarEmpleado.TabIndex = 3;
            this.btnCargarEmpleado.Text = "Cargar Empleado";
            this.btnCargarEmpleado.UseVisualStyleBackColor = true;
            this.btnCargarEmpleado.Click += new System.EventHandler(this.btnCargarEmpleado_Click);
            // 
            // btnCalcularSalario
            // 
            this.btnCalcularSalario.Location = new System.Drawing.Point(361, 76);
            this.btnCalcularSalario.Name = "btnCalcularSalario";
            this.btnCalcularSalario.Size = new System.Drawing.Size(166, 27);
            this.btnCalcularSalario.TabIndex = 4;
            this.btnCalcularSalario.Text = "Calcular Salario";
            this.btnCalcularSalario.UseVisualStyleBackColor = true;
            this.btnCalcularSalario.Click += new System.EventHandler(this.btnCalcularSalario_Click);
            // 
            // btnCalcularBono
            // 
            this.btnCalcularBono.Location = new System.Drawing.Point(540, 76);
            this.btnCalcularBono.Name = "btnCalcularBono";
            this.btnCalcularBono.Size = new System.Drawing.Size(170, 27);
            this.btnCalcularBono.TabIndex = 5;
            this.btnCalcularBono.Text = "Sumar Bono";
            this.btnCalcularBono.UseVisualStyleBackColor = true;
            this.btnCalcularBono.Click += new System.EventHandler(this.btnCalcularBono_Click);
            // 
            // lstEmpleados
            // 
            this.lstEmpleados.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lstEmpleados.FormattingEnabled = true;
            this.lstEmpleados.Location = new System.Drawing.Point(11, 128);
            this.lstEmpleados.Name = "lstEmpleados";
            this.lstEmpleados.Size = new System.Drawing.Size(699, 238);
            this.lstEmpleados.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Salario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Apellido Empleado";
            // 
            // txtApellidoEmpleado
            // 
            this.txtApellidoEmpleado.Location = new System.Drawing.Point(186, 30);
            this.txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            this.txtApellidoEmpleado.Size = new System.Drawing.Size(163, 20);
            this.txtApellidoEmpleado.TabIndex = 10;
            // 
            // FormEJ6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 401);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellidoEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstEmpleados);
            this.Controls.Add(this.btnCalcularBono);
            this.Controls.Add(this.btnCalcularSalario);
            this.Controls.Add(this.btnCargarEmpleado);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtBono);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Name = "FormEJ6";
            this.Text = "FormEJ6";
            this.Load += new System.EventHandler(this.FormEJ6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtBono;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btnCargarEmpleado;
        private System.Windows.Forms.Button btnCalcularSalario;
        private System.Windows.Forms.Button btnCalcularBono;
        private System.Windows.Forms.ListBox lstEmpleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidoEmpleado;
    }
}