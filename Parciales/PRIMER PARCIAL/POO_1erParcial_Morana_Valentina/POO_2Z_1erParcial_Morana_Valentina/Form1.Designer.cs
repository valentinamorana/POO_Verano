namespace POO_2Z_1erParcial_Morana_Valentina
{
    partial class Form1
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
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.cmbSelectorVehiculo = new System.Windows.Forms.ComboBox();
            this.btnVerResumen = new System.Windows.Forms.Button();
            this.btnAgregarVehiculo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecioBase = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCapacidadCarga = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(12, 72);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(127, 20);
            this.txtPatente.TabIndex = 0;
            // 
            // cmbSelectorVehiculo
            // 
            this.cmbSelectorVehiculo.FormattingEnabled = true;
            this.cmbSelectorVehiculo.Location = new System.Drawing.Point(12, 156);
            this.cmbSelectorVehiculo.Name = "cmbSelectorVehiculo";
            this.cmbSelectorVehiculo.Size = new System.Drawing.Size(121, 21);
            this.cmbSelectorVehiculo.TabIndex = 1;
            this.cmbSelectorVehiculo.SelectedIndexChanged += new System.EventHandler(this.cmbSelectorVehiculo_SelectedIndexChanged);
            // 
            // btnVerResumen
            // 
            this.btnVerResumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerResumen.Location = new System.Drawing.Point(300, 133);
            this.btnVerResumen.Name = "btnVerResumen";
            this.btnVerResumen.Size = new System.Drawing.Size(127, 65);
            this.btnVerResumen.TabIndex = 2;
            this.btnVerResumen.Text = "Ver Resumen";
            this.btnVerResumen.UseVisualStyleBackColor = true;
            this.btnVerResumen.Click += new System.EventHandler(this.btnVerResumen_Click);
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(149, 154);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(134, 23);
            this.btnAgregarVehiculo.TabIndex = 3;
            this.btnAgregarVehiculo.Text = "Agregar Vehiculo";
            this.btnAgregarVehiculo.UseVisualStyleBackColor = true;
            this.btnAgregarVehiculo.Click += new System.EventHandler(this.btnAgregarVehiculo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rent-a-Car";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Patente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio Base";
            // 
            // txtPrecioBase
            // 
            this.txtPrecioBase.Location = new System.Drawing.Point(156, 72);
            this.txtPrecioBase.Name = "txtPrecioBase";
            this.txtPrecioBase.Size = new System.Drawing.Size(127, 20);
            this.txtPrecioBase.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Capacidad de Carga";
            // 
            // txtCapacidadCarga
            // 
            this.txtCapacidadCarga.Location = new System.Drawing.Point(300, 72);
            this.txtCapacidadCarga.Name = "txtCapacidadCarga";
            this.txtCapacidadCarga.Size = new System.Drawing.Size(127, 20);
            this.txtCapacidadCarga.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Elegir Vehículo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(478, 239);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCapacidadCarga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecioBase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarVehiculo);
            this.Controls.Add(this.btnVerResumen);
            this.Controls.Add(this.cmbSelectorVehiculo);
            this.Controls.Add(this.txtPatente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.ComboBox cmbSelectorVehiculo;
        private System.Windows.Forms.Button btnVerResumen;
        private System.Windows.Forms.Button btnAgregarVehiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecioBase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCapacidadCarga;
        private System.Windows.Forms.Label label5;
    }
}

