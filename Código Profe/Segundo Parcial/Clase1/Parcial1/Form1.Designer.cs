namespace Parcial1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPatente = new TextBox();
            txtPrecio = new TextBox();
            txtCarga = new TextBox();
            rbAuto = new RadioButton();
            rbFurgon = new RadioButton();
            btnAgregar = new Button();
            btnResumen = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(235, 92);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(175, 35);
            txtPatente.TabIndex = 0;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(235, 176);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(175, 35);
            txtPrecio.TabIndex = 1;
            // 
            // txtCarga
            // 
            txtCarga.Location = new Point(235, 266);
            txtCarga.Name = "txtCarga";
            txtCarga.Size = new Size(175, 35);
            txtCarga.TabIndex = 2;
            // 
            // rbAuto
            // 
            rbAuto.AutoSize = true;
            rbAuto.Location = new Point(235, 348);
            rbAuto.Name = "rbAuto";
            rbAuto.Size = new Size(83, 34);
            rbAuto.TabIndex = 3;
            rbAuto.TabStop = true;
            rbAuto.Text = "Auto";
            rbAuto.UseVisualStyleBackColor = true;
            // 
            // rbFurgon
            // 
            rbFurgon.AutoSize = true;
            rbFurgon.Location = new Point(235, 416);
            rbFurgon.Name = "rbFurgon";
            rbFurgon.Size = new Size(103, 34);
            rbFurgon.TabIndex = 4;
            rbFurgon.TabStop = true;
            rbFurgon.Text = "Furgón";
            rbFurgon.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(182, 507);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(131, 40);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnResumen
            // 
            btnResumen.Location = new Point(386, 507);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(131, 40);
            btnResumen.TabIndex = 6;
            btnResumen.Text = "Resumen";
            btnResumen.UseVisualStyleBackColor = true;
            btnResumen.Click += btnResumen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 95);
            label1.Name = "label1";
            label1.Size = new Size(83, 30);
            label1.TabIndex = 7;
            label1.Text = "Patente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 179);
            label2.Name = "label2";
            label2.Size = new Size(70, 30);
            label2.TabIndex = 8;
            label2.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 269);
            label3.Name = "label3";
            label3.Size = new Size(67, 30);
            label3.TabIndex = 9;
            label3.Text = "Carga";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 587);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnResumen);
            Controls.Add(btnAgregar);
            Controls.Add(rbFurgon);
            Controls.Add(rbAuto);
            Controls.Add(txtCarga);
            Controls.Add(txtPrecio);
            Controls.Add(txtPatente);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCarga;
        private RadioButton rbAuto;
        private RadioButton rbFurgon;
        private Button btnAgregar;
        private Button btnResumen;
        private TextBox txtPatente;
        private TextBox txtPrecio;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
