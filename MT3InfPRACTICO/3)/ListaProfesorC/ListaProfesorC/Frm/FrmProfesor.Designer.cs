namespace ListaProfesorC.Frm
{
    partial class FrmProfesor
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
            this.button1 = new System.Windows.Forms.Button();
            this.DGEst = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNum = new System.Windows.Forms.TextBox();
            this.BttnCol = new System.Windows.Forms.Button();
            this.DGFalta = new System.Windows.Forms.DataGridView();
            this.DTPFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtIDFalt = new System.Windows.Forms.TextBox();
            this.BttnJustificar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LblFic = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGEst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGFalta)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(360, 92);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nuevo estudiante";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DGEst
            // 
            this.DGEst.AllowUserToAddRows = false;
            this.DGEst.AllowUserToDeleteRows = false;
            this.DGEst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGEst.Location = new System.Drawing.Point(21, 138);
            this.DGEst.Name = "DGEst";
            this.DGEst.ReadOnly = true;
            this.DGEst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGEst.Size = new System.Drawing.Size(360, 223);
            this.DGEst.TabIndex = 1;
            this.DGEst.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGEst_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(563, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número de lista:";
            // 
            // TxtNum
            // 
            this.TxtNum.Enabled = false;
            this.TxtNum.Location = new System.Drawing.Point(387, 39);
            this.TxtNum.MaxLength = 8;
            this.TxtNum.Name = "TxtNum";
            this.TxtNum.Size = new System.Drawing.Size(445, 20);
            this.TxtNum.TabIndex = 3;
            this.TxtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtNum.TextChanged += new System.EventHandler(this.TxtNum_TextChanged);
            this.TxtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNum_KeyPress);
            // 
            // BttnCol
            // 
            this.BttnCol.Enabled = false;
            this.BttnCol.Location = new System.Drawing.Point(387, 110);
            this.BttnCol.Name = "BttnCol";
            this.BttnCol.Size = new System.Drawing.Size(445, 22);
            this.BttnCol.TabIndex = 4;
            this.BttnCol.Text = "Colocar falta";
            this.BttnCol.UseVisualStyleBackColor = true;
            this.BttnCol.Click += new System.EventHandler(this.button2_Click);
            // 
            // DGFalta
            // 
            this.DGFalta.AllowUserToAddRows = false;
            this.DGFalta.AllowUserToDeleteRows = false;
            this.DGFalta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGFalta.Location = new System.Drawing.Point(387, 138);
            this.DGFalta.Name = "DGFalta";
            this.DGFalta.ReadOnly = true;
            this.DGFalta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGFalta.Size = new System.Drawing.Size(445, 223);
            this.DGFalta.TabIndex = 5;
            this.DGFalta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGFalta_CellClick);
            // 
            // DTPFecha
            // 
            this.DTPFecha.Location = new System.Drawing.Point(387, 84);
            this.DTPFecha.Name = "DTPFecha";
            this.DTPFecha.Size = new System.Drawing.Size(445, 20);
            this.DTPFecha.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(893, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID de falta:";
            // 
            // TxtIDFalt
            // 
            this.TxtIDFalt.Enabled = false;
            this.TxtIDFalt.Location = new System.Drawing.Point(873, 163);
            this.TxtIDFalt.Name = "TxtIDFalt";
            this.TxtIDFalt.Size = new System.Drawing.Size(100, 20);
            this.TxtIDFalt.TabIndex = 9;
            // 
            // BttnJustificar
            // 
            this.BttnJustificar.Enabled = false;
            this.BttnJustificar.Location = new System.Drawing.Point(886, 189);
            this.BttnJustificar.Name = "BttnJustificar";
            this.BttnJustificar.Size = new System.Drawing.Size(75, 23);
            this.BttnJustificar.TabIndex = 10;
            this.BttnJustificar.Text = "Justificar";
            this.BttnJustificar.UseVisualStyleBackColor = true;
            this.BttnJustificar.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(883, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fictas:";
            // 
            // LblFic
            // 
            this.LblFic.AutoSize = true;
            this.LblFic.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFic.Location = new System.Drawing.Point(924, 57);
            this.LblFic.Name = "LblFic";
            this.LblFic.Size = new System.Drawing.Size(26, 29);
            this.LblFic.TabIndex = 12;
            this.LblFic.Text = "?";
            // 
            // FrmProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(985, 373);
            this.Controls.Add(this.LblFic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BttnJustificar);
            this.Controls.Add(this.TxtIDFalt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DTPFecha);
            this.Controls.Add(this.DGFalta);
            this.Controls.Add(this.BttnCol);
            this.Controls.Add(this.TxtNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGEst);
            this.Controls.Add(this.button1);
            this.Name = "FrmProfesor";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.FrmProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGEst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGFalta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DGEst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNum;
        private System.Windows.Forms.Button BttnCol;
        private System.Windows.Forms.DataGridView DGFalta;
        private System.Windows.Forms.DateTimePicker DTPFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtIDFalt;
        private System.Windows.Forms.Button BttnJustificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblFic;
    }
}