namespace TP_UN6_Morana_POO.EJ24
{
    partial class FormServidor
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lstMensajes = new System.Windows.Forms.ListBox();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.btnDetener = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(56, 43);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(12, 80);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 1;
            this.lblEstado.Text = "Estado";
            this.lblEstado.Click += new System.EventHandler(this.lblEstado_Click);
            // 
            // lstMensajes
            // 
            this.lstMensajes.FormattingEnabled = true;
            this.lstMensajes.Location = new System.Drawing.Point(15, 103);
            this.lstMensajes.Name = "lstMensajes";
            this.lstMensajes.Size = new System.Drawing.Size(271, 121);
            this.lstMensajes.TabIndex = 2;
            this.lstMensajes.SelectedIndexChanged += new System.EventHandler(this.lstMensajes_SelectedIndexChanged);
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(56, 17);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(156, 20);
            this.txtPuerto.TabIndex = 3;
            this.txtPuerto.TextChanged += new System.EventHandler(this.txtPuerto_TextChanged);
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(137, 43);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(75, 23);
            this.btnDetener.TabIndex = 4;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Puerto";
            // 
            // FormServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 236);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.lstMensajes);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnIniciar);
            this.Name = "FormServidor";
            this.Text = "FormServidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ListBox lstMensajes;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Label label2;
    }
}