namespace WinApp
{
    partial class Principal
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnClaseIndice = new System.Windows.Forms.Button();
            this.numIndice = new System.Windows.Forms.NumericUpDown();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnMostrarObjetoFila = new System.Windows.Forms.Button();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.btnEventos = new System.Windows.Forms.Button();
            this.btnPolimorfismo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numIndice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(216, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(350, 29);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(216, 135);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(350, 29);
            this.txtApellido.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(122, 223);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(226, 46);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar Cliente";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnClaseIndice
            // 
            this.btnClaseIndice.Location = new System.Drawing.Point(122, 527);
            this.btnClaseIndice.Name = "btnClaseIndice";
            this.btnClaseIndice.Size = new System.Drawing.Size(307, 67);
            this.btnClaseIndice.TabIndex = 5;
            this.btnClaseIndice.Text = "Mostrar Clase Indice";
            this.btnClaseIndice.UseVisualStyleBackColor = true;
            this.btnClaseIndice.Click += new System.EventHandler(this.btnClaseIndice_Click);
            // 
            // numIndice
            // 
            this.numIndice.Location = new System.Drawing.Point(216, 459);
            this.numIndice.Name = "numIndice";
            this.numIndice.Size = new System.Drawing.Size(120, 29);
            this.numIndice.TabIndex = 6;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(761, 66);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 72;
            this.dgvClientes.RowTemplate.Height = 31;
            this.dgvClientes.Size = new System.Drawing.Size(859, 422);
            this.dgvClientes.TabIndex = 7;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(761, 548);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(226, 46);
            this.btnAgregarCliente.TabIndex = 8;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnMostrarObjetoFila
            // 
            this.btnMostrarObjetoFila.Location = new System.Drawing.Point(1112, 548);
            this.btnMostrarObjetoFila.Name = "btnMostrarObjetoFila";
            this.btnMostrarObjetoFila.Size = new System.Drawing.Size(340, 46);
            this.btnMostrarObjetoFila.TabIndex = 9;
            this.btnMostrarObjetoFila.Text = "Mostrar Objeto Por Pos.";
            this.btnMostrarObjetoFila.UseVisualStyleBackColor = true;
            this.btnMostrarObjetoFila.Click += new System.EventHandler(this.btnMostrarObjetoFila_Click);
            // 
            // btnInscribir
            // 
            this.btnInscribir.Location = new System.Drawing.Point(1512, 537);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(201, 68);
            this.btnInscribir.TabIndex = 10;
            this.btnInscribir.Text = "Inscribir";
            this.btnInscribir.UseVisualStyleBackColor = true;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            this.btnInscribir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnInscribir_KeyDown);
            // 
            // btnEventos
            // 
            this.btnEventos.Location = new System.Drawing.Point(1482, 719);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(214, 54);
            this.btnEventos.TabIndex = 11;
            this.btnEventos.Text = "Eventos";
            this.btnEventos.UseVisualStyleBackColor = true;
            this.btnEventos.Click += new System.EventHandler(this.btnEventos_Click);
            // 
            // btnPolimorfismo
            // 
            this.btnPolimorfismo.Location = new System.Drawing.Point(1482, 809);
            this.btnPolimorfismo.Name = "btnPolimorfismo";
            this.btnPolimorfismo.Size = new System.Drawing.Size(214, 54);
            this.btnPolimorfismo.TabIndex = 12;
            this.btnPolimorfismo.Text = "Polimorfismo";
            this.btnPolimorfismo.UseVisualStyleBackColor = true;
            this.btnPolimorfismo.Click += new System.EventHandler(this.btnPolimorfismo_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1756, 888);
            this.Controls.Add(this.btnPolimorfismo);
            this.Controls.Add(this.btnEventos);
            this.Controls.Add(this.btnInscribir);
            this.Controls.Add(this.btnMostrarObjetoFila);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.numIndice);
            this.Controls.Add(this.btnClaseIndice);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Principal_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.numIndice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnClaseIndice;
        private System.Windows.Forms.NumericUpDown numIndice;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnMostrarObjetoFila;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Button btnPolimorfismo;
    }
}