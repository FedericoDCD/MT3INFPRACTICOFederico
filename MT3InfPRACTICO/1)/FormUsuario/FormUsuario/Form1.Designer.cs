namespace FormUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.BttnMostrar = new System.Windows.Forms.Button();
            this.TxtEdadUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cálculo de edad de usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(193, 129);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(100, 20);
            this.TxtNom.TabIndex = 3;
            this.TxtNom.TextChanged += new System.EventHandler(this.TxtNom_TextChanged);
            // 
            // BttnMostrar
            // 
            this.BttnMostrar.Enabled = false;
            this.BttnMostrar.Location = new System.Drawing.Point(317, 126);
            this.BttnMostrar.Name = "BttnMostrar";
            this.BttnMostrar.Size = new System.Drawing.Size(172, 52);
            this.BttnMostrar.TabIndex = 5;
            this.BttnMostrar.Text = "Mostrar";
            this.BttnMostrar.UseVisualStyleBackColor = true;
            this.BttnMostrar.Click += new System.EventHandler(this.BttnMostrar_Click);
            // 
            // TxtEdadUsuario
            // 
            this.TxtEdadUsuario.Location = new System.Drawing.Point(193, 157);
            this.TxtEdadUsuario.Name = "TxtEdadUsuario";
            this.TxtEdadUsuario.Size = new System.Drawing.Size(100, 20);
            this.TxtEdadUsuario.TabIndex = 6;
            this.TxtEdadUsuario.TextChanged += new System.EventHandler(this.TxtEdadUsuario_TextChanged);
            this.TxtEdadUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEdadUsuario_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 315);
            this.Controls.Add(this.TxtEdadUsuario);
            this.Controls.Add(this.BttnMostrar);
            this.Controls.Add(this.TxtNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.Button BttnMostrar;
        private System.Windows.Forms.TextBox TxtEdadUsuario;
    }
}

