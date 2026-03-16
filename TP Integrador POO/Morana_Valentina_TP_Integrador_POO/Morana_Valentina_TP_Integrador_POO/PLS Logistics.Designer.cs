namespace Morana_Valentina_TP_Integrador_POO
{
    partial class PLSLogisticsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvEnvios = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRecorrerCodigo = new System.Windows.Forms.Button();
            this.btnClonar = new System.Windows.Forms.Button();
            this.txtCodigoClon = new System.Windows.Forms.TextBox();
            this.txtDestinoClon = new System.Windows.Forms.TextBox();
            this.lstPartesCodigo = new System.Windows.Forms.ListBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblValidacionCodigo = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbOrdenCampo = new System.Windows.Forms.ComboBox();
            this.txtPrioridad = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtPrioridadClon = new System.Windows.Forms.TextBox();
            this.txtPesoClon = new System.Windows.Forms.TextBox();
            this.Código = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lstClones = new System.Windows.Forms.ListBox();
            this.btnGuardarClon = new System.Windows.Forms.Button();
            this.rbAscendente = new System.Windows.Forms.RadioButton();
            this.rbDescendente = new System.Windows.Forms.RadioButton();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnModificarClon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnvios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEnvios
            // 
            this.dgvEnvios.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvEnvios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnvios.Location = new System.Drawing.Point(301, 61);
            this.dgvEnvios.Name = "dgvEnvios";
            this.dgvEnvios.Size = new System.Drawing.Size(762, 265);
            this.dgvEnvios.TabIndex = 0;
            this.dgvEnvios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnvios_CellClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(33, 339);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(33, 376);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRecorrerCodigo
            // 
            this.btnRecorrerCodigo.Location = new System.Drawing.Point(301, 354);
            this.btnRecorrerCodigo.Name = "btnRecorrerCodigo";
            this.btnRecorrerCodigo.Size = new System.Drawing.Size(183, 25);
            this.btnRecorrerCodigo.TabIndex = 3;
            this.btnRecorrerCodigo.Text = "Recorrer Código";
            this.btnRecorrerCodigo.UseVisualStyleBackColor = true;
            this.btnRecorrerCodigo.Click += new System.EventHandler(this.btnRecorrerCodigo_Click);
            // 
            // btnClonar
            // 
            this.btnClonar.Location = new System.Drawing.Point(126, 376);
            this.btnClonar.Name = "btnClonar";
            this.btnClonar.Size = new System.Drawing.Size(75, 23);
            this.btnClonar.TabIndex = 4;
            this.btnClonar.Text = "Clonar";
            this.btnClonar.UseVisualStyleBackColor = true;
            this.btnClonar.Click += new System.EventHandler(this.btnClonar_Click);
            // 
            // txtCodigoClon
            // 
            this.txtCodigoClon.Location = new System.Drawing.Point(565, 380);
            this.txtCodigoClon.Name = "txtCodigoClon";
            this.txtCodigoClon.Size = new System.Drawing.Size(154, 20);
            this.txtCodigoClon.TabIndex = 5;
            // 
            // txtDestinoClon
            // 
            this.txtDestinoClon.Location = new System.Drawing.Point(565, 406);
            this.txtDestinoClon.Name = "txtDestinoClon";
            this.txtDestinoClon.Size = new System.Drawing.Size(154, 20);
            this.txtDestinoClon.TabIndex = 6;
            // 
            // lstPartesCodigo
            // 
            this.lstPartesCodigo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstPartesCodigo.FormattingEnabled = true;
            this.lstPartesCodigo.Location = new System.Drawing.Point(301, 385);
            this.lstPartesCodigo.Name = "lstPartesCodigo";
            this.lstPartesCodigo.Size = new System.Drawing.Size(183, 186);
            this.lstPartesCodigo.TabIndex = 7;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(84, 98);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(171, 20);
            this.txtCodigo.TabIndex = 8;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lblValidacionCodigo
            // 
            this.lblValidacionCodigo.AutoSize = true;
            this.lblValidacionCodigo.Location = new System.Drawing.Point(29, 129);
            this.lblValidacionCodigo.Name = "lblValidacionCodigo";
            this.lblValidacionCodigo.Size = new System.Drawing.Size(92, 13);
            this.lblValidacionCodigo.TabIndex = 9;
            this.lblValidacionCodigo.Text = "Validación Código";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(84, 152);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(100, 20);
            this.txtDestino.TabIndex = 10;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(84, 180);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 11;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(30, 247);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 12;
            this.lblEstado.Text = "Estado";
            // 
            // cmbOrdenCampo
            // 
            this.cmbOrdenCampo.FormattingEnabled = true;
            this.cmbOrdenCampo.Location = new System.Drawing.Point(34, 442);
            this.cmbOrdenCampo.Name = "cmbOrdenCampo";
            this.cmbOrdenCampo.Size = new System.Drawing.Size(121, 21);
            this.cmbOrdenCampo.TabIndex = 13;
            // 
            // txtPrioridad
            // 
            this.txtPrioridad.Location = new System.Drawing.Point(84, 212);
            this.txtPrioridad.Name = "txtPrioridad";
            this.txtPrioridad.Size = new System.Drawing.Size(100, 20);
            this.txtPrioridad.TabIndex = 14;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(126, 339);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtPrioridadClon
            // 
            this.txtPrioridadClon.Location = new System.Drawing.Point(564, 463);
            this.txtPrioridadClon.Name = "txtPrioridadClon";
            this.txtPrioridadClon.Size = new System.Drawing.Size(155, 20);
            this.txtPrioridadClon.TabIndex = 18;
            // 
            // txtPesoClon
            // 
            this.txtPesoClon.Location = new System.Drawing.Point(565, 434);
            this.txtPesoClon.Name = "txtPesoClon";
            this.txtPesoClon.Size = new System.Drawing.Size(154, 20);
            this.txtPesoClon.TabIndex = 17;
            // 
            // Código
            // 
            this.Código.AutoSize = true;
            this.Código.Location = new System.Drawing.Point(30, 101);
            this.Código.Name = "Código";
            this.Código.Size = new System.Drawing.Size(40, 13);
            this.Código.TabIndex = 19;
            this.Código.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Destino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Peso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Prioridad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(25, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 31);
            this.label4.TabIndex = 23;
            this.label4.Text = "PLS Logistics";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Prioridad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(510, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Peso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(510, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Destino";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(510, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Código";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(510, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "CLON";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 426);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Ordenar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(28, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "DATOS ENVÍO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "-------------------------------------------------------------";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(31, 313);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "ACCIONES";
            // 
            // lstClones
            // 
            this.lstClones.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstClones.FormattingEnabled = true;
            this.lstClones.Location = new System.Drawing.Point(725, 380);
            this.lstClones.Name = "lstClones";
            this.lstClones.Size = new System.Drawing.Size(338, 199);
            this.lstClones.TabIndex = 33;
            // 
            // btnGuardarClon
            // 
            this.btnGuardarClon.Location = new System.Drawing.Point(513, 496);
            this.btnGuardarClon.Name = "btnGuardarClon";
            this.btnGuardarClon.Size = new System.Drawing.Size(203, 26);
            this.btnGuardarClon.TabIndex = 34;
            this.btnGuardarClon.Text = "Guardar Clon";
            this.btnGuardarClon.UseVisualStyleBackColor = true;
            this.btnGuardarClon.Click += new System.EventHandler(this.btnGuardarClon_Click);
            // 
            // rbAscendente
            // 
            this.rbAscendente.AutoSize = true;
            this.rbAscendente.Location = new System.Drawing.Point(37, 469);
            this.rbAscendente.Name = "rbAscendente";
            this.rbAscendente.Size = new System.Drawing.Size(82, 17);
            this.rbAscendente.TabIndex = 35;
            this.rbAscendente.TabStop = true;
            this.rbAscendente.Text = "Ascendente";
            this.rbAscendente.UseVisualStyleBackColor = true;
            // 
            // rbDescendente
            // 
            this.rbDescendente.AutoSize = true;
            this.rbDescendente.Location = new System.Drawing.Point(37, 492);
            this.rbDescendente.Name = "rbDescendente";
            this.rbDescendente.Size = new System.Drawing.Size(89, 17);
            this.rbDescendente.TabIndex = 36;
            this.rbDescendente.TabStop = true;
            this.rbDescendente.Text = "Descendente";
            this.rbDescendente.UseVisualStyleBackColor = true;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(34, 522);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(121, 23);
            this.btnOrdenar.TabIndex = 37;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(988, 32);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 38;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(722, 355);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "CLONES GUARDADOS";
            // 
            // btnModificarClon
            // 
            this.btnModificarClon.Location = new System.Drawing.Point(512, 532);
            this.btnModificarClon.Name = "btnModificarClon";
            this.btnModificarClon.Size = new System.Drawing.Size(204, 42);
            this.btnModificarClon.TabIndex = 40;
            this.btnModificarClon.Text = "Comparar Clon con Envío Original";
            this.btnModificarClon.UseVisualStyleBackColor = true;
            this.btnModificarClon.Click += new System.EventHandler(this.btnModificarClon_Click);
            // 
            // PLSLogisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1076, 595);
            this.Controls.Add(this.btnModificarClon);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.rbDescendente);
            this.Controls.Add(this.rbAscendente);
            this.Controls.Add(this.btnGuardarClon);
            this.Controls.Add(this.lstClones);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Código);
            this.Controls.Add(this.txtPesoClon);
            this.Controls.Add(this.txtPrioridadClon);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtPrioridad);
            this.Controls.Add(this.cmbOrdenCampo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.lblValidacionCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lstPartesCodigo);
            this.Controls.Add(this.txtDestinoClon);
            this.Controls.Add(this.txtCodigoClon);
            this.Controls.Add(this.btnClonar);
            this.Controls.Add(this.btnRecorrerCodigo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvEnvios);
            this.Name = "PLSLogisticsForm";
            this.Text = "PLS Logistics";
            this.Load += new System.EventHandler(this.PLSLogisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnvios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEnvios;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRecorrerCodigo;
        private System.Windows.Forms.Button btnClonar;
        private System.Windows.Forms.TextBox txtCodigoClon;
        private System.Windows.Forms.TextBox txtDestinoClon;
        private System.Windows.Forms.ListBox lstPartesCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblValidacionCodigo;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbOrdenCampo;
        private System.Windows.Forms.TextBox txtPrioridad;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtPrioridadClon;
        private System.Windows.Forms.TextBox txtPesoClon;
        private System.Windows.Forms.Label Código;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lstClones;
        private System.Windows.Forms.Button btnGuardarClon;
        private System.Windows.Forms.RadioButton rbAscendente;
        private System.Windows.Forms.RadioButton rbDescendente;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnModificarClon;
    }
}