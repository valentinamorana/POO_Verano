namespace TP_UN5_Morana_POO
{
    partial class FormTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEJ21 = new System.Windows.Forms.Button();
            this.btnEJ22 = new System.Windows.Forms.Button();
            this.btnEJ23 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test Funcionamiento Ejercicios";
            // 
            // btnEJ21
            // 
            this.btnEJ21.Location = new System.Drawing.Point(49, 97);
            this.btnEJ21.Name = "btnEJ21";
            this.btnEJ21.Size = new System.Drawing.Size(75, 23);
            this.btnEJ21.TabIndex = 1;
            this.btnEJ21.Text = "EJ21";
            this.btnEJ21.UseVisualStyleBackColor = true;
            this.btnEJ21.Click += new System.EventHandler(this.btnEJ21_Click);
            // 
            // btnEJ22
            // 
            this.btnEJ22.Location = new System.Drawing.Point(148, 97);
            this.btnEJ22.Name = "btnEJ22";
            this.btnEJ22.Size = new System.Drawing.Size(75, 23);
            this.btnEJ22.TabIndex = 2;
            this.btnEJ22.Text = "EJ22";
            this.btnEJ22.UseVisualStyleBackColor = true;
            this.btnEJ22.Click += new System.EventHandler(this.btnEJ22_Click);
            // 
            // btnEJ23
            // 
            this.btnEJ23.Location = new System.Drawing.Point(250, 97);
            this.btnEJ23.Name = "btnEJ23";
            this.btnEJ23.Size = new System.Drawing.Size(75, 23);
            this.btnEJ23.TabIndex = 3;
            this.btnEJ23.Text = "EJ23";
            this.btnEJ23.UseVisualStyleBackColor = true;
            this.btnEJ23.Click += new System.EventHandler(this.btnEJ23_Click);
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 165);
            this.Controls.Add(this.btnEJ23);
            this.Controls.Add(this.btnEJ22);
            this.Controls.Add(this.btnEJ21);
            this.Controls.Add(this.label1);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEJ21;
        private System.Windows.Forms.Button btnEJ22;
        private System.Windows.Forms.Button btnEJ23;
    }
}

