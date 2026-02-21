namespace TP_UN1_Morana_POO.EJ4
{
    partial class VehiculoFormsEJ4
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
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnConducir = new System.Windows.Forms.Button();
            this.btnVolar = new System.Windows.Forms.Button();
            this.lstSalida = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(12, 29);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(152, 20);
            this.txtModelo.TabIndex = 0;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(170, 27);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(116, 23);
            this.btnCrear.TabIndex = 1;
            this.btnCrear.Text = "Crear Modelo";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnConducir
            // 
            this.btnConducir.Location = new System.Drawing.Point(12, 80);
            this.btnConducir.Name = "btnConducir";
            this.btnConducir.Size = new System.Drawing.Size(131, 23);
            this.btnConducir.TabIndex = 2;
            this.btnConducir.Text = "Conducir";
            this.btnConducir.UseVisualStyleBackColor = true;
            this.btnConducir.Click += new System.EventHandler(this.btnConducir_Click);
            // 
            // btnVolar
            // 
            this.btnVolar.Location = new System.Drawing.Point(149, 80);
            this.btnVolar.Name = "btnVolar";
            this.btnVolar.Size = new System.Drawing.Size(136, 23);
            this.btnVolar.TabIndex = 3;
            this.btnVolar.Text = "Volar";
            this.btnVolar.UseVisualStyleBackColor = true;
            this.btnVolar.Click += new System.EventHandler(this.btnVolar_Click);
            // 
            // lstSalida
            // 
            this.lstSalida.FormattingEnabled = true;
            this.lstSalida.Location = new System.Drawing.Point(12, 109);
            this.lstSalida.Name = "lstSalida";
            this.lstSalida.Size = new System.Drawing.Size(273, 121);
            this.lstSalida.TabIndex = 4;
            // 
            // VehiculoForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 236);
            this.Controls.Add(this.lstSalida);
            this.Controls.Add(this.btnVolar);
            this.Controls.Add(this.btnConducir);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtModelo);
            this.Name = "VehiculoForms";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnConducir;
        private System.Windows.Forms.Button btnVolar;
        private System.Windows.Forms.ListBox lstSalida;
    }
}