namespace eKino.WinUI.Pretplate
{
    partial class frmPretplatePrikaz
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrojPretplacenih = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbZanrovi = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPretplate = new System.Windows.Forms.DataGridView();
            this.Zanr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gledalac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPretplate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Otkazana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretplate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtBrojPretplacenih);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbZanrovi);
            this.groupBox2.Location = new System.Drawing.Point(-1, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(802, 121);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Broj pretplaćenih gledalaca na odabrani žanr";
            // 
            // txtBrojPretplacenih
            // 
            this.txtBrojPretplacenih.Location = new System.Drawing.Point(468, 73);
            this.txtBrojPretplacenih.Name = "txtBrojPretplacenih";
            this.txtBrojPretplacenih.ReadOnly = true;
            this.txtBrojPretplacenih.Size = new System.Drawing.Size(289, 22);
            this.txtBrojPretplacenih.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odaberite žanr";
            // 
            // cmbZanrovi
            // 
            this.cmbZanrovi.FormattingEnabled = true;
            this.cmbZanrovi.Location = new System.Drawing.Point(6, 73);
            this.cmbZanrovi.Name = "cmbZanrovi";
            this.cmbZanrovi.Size = new System.Drawing.Size(180, 24);
            this.cmbZanrovi.TabIndex = 0;
            this.cmbZanrovi.SelectedIndexChanged += new System.EventHandler(this.cmbZanrovi_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPretplate);
            this.groupBox1.Location = new System.Drawing.Point(-1, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 310);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretplate";
            // 
            // dgvPretplate
            // 
            this.dgvPretplate.AllowUserToAddRows = false;
            this.dgvPretplate.AllowUserToDeleteRows = false;
            this.dgvPretplate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPretplate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Zanr,
            this.Gledalac,
            this.DatumPretplate,
            this.Otkazana});
            this.dgvPretplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPretplate.Location = new System.Drawing.Point(3, 18);
            this.dgvPretplate.Name = "dgvPretplate";
            this.dgvPretplate.ReadOnly = true;
            this.dgvPretplate.RowHeadersWidth = 51;
            this.dgvPretplate.Size = new System.Drawing.Size(763, 289);
            this.dgvPretplate.TabIndex = 0;
            // 
            // Zanr
            // 
            this.Zanr.DataPropertyName = "Zanr";
            this.Zanr.HeaderText = "Žanr";
            this.Zanr.MinimumWidth = 6;
            this.Zanr.Name = "Zanr";
            this.Zanr.ReadOnly = true;
            this.Zanr.Width = 125;
            // 
            // Gledalac
            // 
            this.Gledalac.DataPropertyName = "Gledalac";
            this.Gledalac.HeaderText = "Gledalac";
            this.Gledalac.MinimumWidth = 6;
            this.Gledalac.Name = "Gledalac";
            this.Gledalac.ReadOnly = true;
            this.Gledalac.Width = 125;
            // 
            // DatumPretplate
            // 
            this.DatumPretplate.DataPropertyName = "DatumPretplate";
            this.DatumPretplate.HeaderText = "Datum pretplate";
            this.DatumPretplate.MinimumWidth = 6;
            this.DatumPretplate.Name = "DatumPretplate";
            this.DatumPretplate.ReadOnly = true;
            this.DatumPretplate.Width = 125;
            // 
            // Otkazana
            // 
            this.Otkazana.DataPropertyName = "OtkazanaString";
            this.Otkazana.HeaderText = "Otkazana";
            this.Otkazana.MinimumWidth = 6;
            this.Otkazana.Name = "Otkazana";
            this.Otkazana.ReadOnly = true;
            this.Otkazana.Width = 125;
            // 
            // frmPretplatePrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPretplatePrikaz";
            this.Text = "frmPretplatePrikaz";
            this.Load += new System.EventHandler(this.frmPretplatePrikaz_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretplate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPretplate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrojPretplacenih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbZanrovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zanr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gledalac;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPretplate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Otkazana;
    }
}