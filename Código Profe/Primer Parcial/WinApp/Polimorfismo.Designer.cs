namespace WinApp
{
    partial class Polimorfismo
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
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.btnRectangulo = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnMostrarDibujo = new System.Windows.Forms.Button();
            this.dgvFiguras = new System.Windows.Forms.DataGridView();
            this.btnMostrarStatic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiguras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.Location = new System.Drawing.Point(65, 72);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(128, 48);
            this.btnTriangulo.TabIndex = 0;
            this.btnTriangulo.Text = "Triangulo";
            this.btnTriangulo.UseVisualStyleBackColor = true;
            this.btnTriangulo.Click += new System.EventHandler(this.btnTriangulo_Click);
            // 
            // btnRectangulo
            // 
            this.btnRectangulo.Location = new System.Drawing.Point(65, 159);
            this.btnRectangulo.Name = "btnRectangulo";
            this.btnRectangulo.Size = new System.Drawing.Size(128, 48);
            this.btnRectangulo.TabIndex = 1;
            this.btnRectangulo.Text = "Rectangulo";
            this.btnRectangulo.UseVisualStyleBackColor = true;
            this.btnRectangulo.Click += new System.EventHandler(this.btnRectangulo_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(467, 72);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(187, 48);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar Figuras";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnMostrarDibujo
            // 
            this.btnMostrarDibujo.Location = new System.Drawing.Point(467, 170);
            this.btnMostrarDibujo.Name = "btnMostrarDibujo";
            this.btnMostrarDibujo.Size = new System.Drawing.Size(345, 48);
            this.btnMostrarDibujo.TabIndex = 3;
            this.btnMostrarDibujo.Text = "Mostrar Dibujo (Triangulos)";
            this.btnMostrarDibujo.UseVisualStyleBackColor = true;
            this.btnMostrarDibujo.Click += new System.EventHandler(this.btnMostrarDibujo_Click);
            // 
            // dgvFiguras
            // 
            this.dgvFiguras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiguras.Location = new System.Drawing.Point(467, 256);
            this.dgvFiguras.Name = "dgvFiguras";
            this.dgvFiguras.RowHeadersWidth = 72;
            this.dgvFiguras.RowTemplate.Height = 31;
            this.dgvFiguras.Size = new System.Drawing.Size(989, 374);
            this.dgvFiguras.TabIndex = 4;
            // 
            // btnMostrarStatic
            // 
            this.btnMostrarStatic.Location = new System.Drawing.Point(718, 72);
            this.btnMostrarStatic.Name = "btnMostrarStatic";
            this.btnMostrarStatic.Size = new System.Drawing.Size(363, 48);
            this.btnMostrarStatic.TabIndex = 5;
            this.btnMostrarStatic.Text = "Mostrar miembros de clase";
            this.btnMostrarStatic.UseVisualStyleBackColor = true;
            this.btnMostrarStatic.Click += new System.EventHandler(this.btnMostrarStatic_Click);
            // 
            // Polimorfismo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 727);
            this.Controls.Add(this.btnMostrarStatic);
            this.Controls.Add(this.dgvFiguras);
            this.Controls.Add(this.btnMostrarDibujo);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnRectangulo);
            this.Controls.Add(this.btnTriangulo);
            this.Name = "Polimorfismo";
            this.Text = "Polimorfismo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiguras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.Button btnRectangulo;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnMostrarDibujo;
        private System.Windows.Forms.DataGridView dgvFiguras;
        private System.Windows.Forms.Button btnMostrarStatic;
    }
}