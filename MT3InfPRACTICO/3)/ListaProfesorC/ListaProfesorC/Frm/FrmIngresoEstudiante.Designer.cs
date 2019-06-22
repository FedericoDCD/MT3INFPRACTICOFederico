namespace ListaProfesorC.Frm
{
    partial class FrmIngresoEstudiante
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
            this.BttnGuardar = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DGEstudiantes = new System.Windows.Forms.DataGridView();
            this.CBIngresoExist = new System.Windows.Forms.CheckBox();
            this.BttnEliminar = new System.Windows.Forms.Button();
            this.LblTxtID = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // BttnGuardar
            // 
            this.BttnGuardar.Enabled = false;
            this.BttnGuardar.Location = new System.Drawing.Point(382, 121);
            this.BttnGuardar.Name = "BttnGuardar";
            this.BttnGuardar.Size = new System.Drawing.Size(109, 51);
            this.BttnGuardar.TabIndex = 0;
            this.BttnGuardar.Text = "Guardar";
            this.BttnGuardar.UseVisualStyleBackColor = true;
            this.BttnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Location = new System.Drawing.Point(379, 28);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(112, 13);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Ingreso de estudiante:";
            this.LblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(382, 76);
            this.TxtNom.MaxLength = 50;
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(109, 20);
            this.TxtNom.TabIndex = 2;
            this.TxtNom.TextChanged += new System.EventHandler(this.TxtNom_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // DGEstudiantes
            // 
            this.DGEstudiantes.AllowUserToAddRows = false;
            this.DGEstudiantes.AllowUserToDeleteRows = false;
            this.DGEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGEstudiantes.Location = new System.Drawing.Point(-1, 0);
            this.DGEstudiantes.Name = "DGEstudiantes";
            this.DGEstudiantes.ReadOnly = true;
            this.DGEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGEstudiantes.Size = new System.Drawing.Size(324, 343);
            this.DGEstudiantes.TabIndex = 4;
            this.DGEstudiantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGEstudiantes_CellClick);
            this.DGEstudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGEstudiantes_CellContentClick);
            // 
            // CBIngresoExist
            // 
            this.CBIngresoExist.AutoSize = true;
            this.CBIngresoExist.Location = new System.Drawing.Point(372, 102);
            this.CBIngresoExist.Name = "CBIngresoExist";
            this.CBIngresoExist.Size = new System.Drawing.Size(135, 17);
            this.CBIngresoExist.TabIndex = 5;
            this.CBIngresoExist.Text = "Estudiante ya existente";
            this.CBIngresoExist.UseVisualStyleBackColor = true;
            this.CBIngresoExist.CheckedChanged += new System.EventHandler(this.CBIngresoExist_CheckedChanged);
            // 
            // BttnEliminar
            // 
            this.BttnEliminar.Enabled = false;
            this.BttnEliminar.Location = new System.Drawing.Point(382, 178);
            this.BttnEliminar.Name = "BttnEliminar";
            this.BttnEliminar.Size = new System.Drawing.Size(109, 51);
            this.BttnEliminar.TabIndex = 6;
            this.BttnEliminar.Text = "Eliminar";
            this.BttnEliminar.UseVisualStyleBackColor = true;
            this.BttnEliminar.Visible = false;
            this.BttnEliminar.Click += new System.EventHandler(this.BttnEliminar_Click);
            // 
            // LblTxtID
            // 
            this.LblTxtID.AutoSize = true;
            this.LblTxtID.Location = new System.Drawing.Point(402, 51);
            this.LblTxtID.Name = "LblTxtID";
            this.LblTxtID.Size = new System.Drawing.Size(21, 13);
            this.LblTxtID.TabIndex = 7;
            this.LblTxtID.Text = "ID:";
            this.LblTxtID.Visible = false;
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.BackColor = System.Drawing.SystemColors.Control;
            this.LblID.Font = new System.Drawing.Font("Chaparral Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblID.Location = new System.Drawing.Point(429, 45);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(19, 24);
            this.LblID.TabIndex = 8;
            this.LblID.Text = "?";
            this.LblID.Visible = false;
            // 
            // FrmIngresoEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 343);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.LblTxtID);
            this.Controls.Add(this.BttnEliminar);
            this.Controls.Add(this.CBIngresoExist);
            this.Controls.Add(this.DGEstudiantes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNom);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.BttnGuardar);
            this.Name = "FrmIngresoEstudiante";
            this.Text = "FrmIngresoEstudiante";
            this.Load += new System.EventHandler(this.FrmIngresoEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BttnGuardar;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGEstudiantes;
        private System.Windows.Forms.CheckBox CBIngresoExist;
        private System.Windows.Forms.Button BttnEliminar;
        private System.Windows.Forms.Label LblTxtID;
        private System.Windows.Forms.Label LblID;
    }
}