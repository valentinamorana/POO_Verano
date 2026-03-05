namespace SistemaEventos
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

        // Todos los controles se crean en CrearUI() dentro de Form1.cs
        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 860);
            this.Name = "Form1";
            this.Text = "Sistema de Personal para Eventos";
            this.ResumeLayout(false);
        }
    }
}
