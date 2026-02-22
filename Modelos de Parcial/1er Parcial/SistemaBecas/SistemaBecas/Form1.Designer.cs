namespace SistemaBecas
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        // InitializeComponent solo configura lo básico del Form.
        // Todos los controles se crean en el método CrearUI() de Form1.cs
        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 912);
            this.Name = "Form1";
            this.Text = "Sistema de Becas";
            this.ResumeLayout(false);
        }
    }
}
