namespace eKino.WinUI.VrsteProjekcije
{
    partial class frmVrsteProjekcijePrikaz
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvVrsteProjekcije = new System.Windows.Forms.DataGridView();
            this.VrstaProjekcijeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrsteProjekcije)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvVrsteProjekcije);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(280, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vrste projekcije";
            // 
            // dgvVrsteProjekcije
            // 
            this.dgvVrsteProjekcije.AllowUserToAddRows = false;
            this.dgvVrsteProjekcije.AllowUserToDeleteRows = false;
            this.dgvVrsteProjekcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVrsteProjekcije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VrstaProjekcijeId,
            this.Naziv,
            this.Opis});
            this.dgvVrsteProjekcije.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVrsteProjekcije.Location = new System.Drawing.Point(2, 15);
            this.dgvVrsteProjekcije.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvVrsteProjekcije.Name = "dgvVrsteProjekcije";
            this.dgvVrsteProjekcije.ReadOnly = true;
            this.dgvVrsteProjekcije.RowHeadersWidth = 51;
            this.dgvVrsteProjekcije.RowTemplate.Height = 24;
            this.dgvVrsteProjekcije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVrsteProjekcije.Size = new System.Drawing.Size(276, 199);
            this.dgvVrsteProjekcije.TabIndex = 0;
            this.dgvVrsteProjekcije.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvVrsteProjekcije_MouseDoubleClick);
            // 
            // VrstaProjekcijeId
            // 
            this.VrstaProjekcijeId.DataPropertyName = "VrstaProjekcijeId";
            this.VrstaProjekcijeId.HeaderText = "VrstaProjekcijeId";
            this.VrstaProjekcijeId.Name = "VrstaProjekcijeId";
            this.VrstaProjekcijeId.ReadOnly = true;
            this.VrstaProjekcijeId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.MinimumWidth = 6;
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 125;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.MinimumWidth = 6;
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            this.Opis.Width = 125;
            // 
            // frmVrsteProjekcijePrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 238);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmVrsteProjekcijePrikaz";
            this.Text = "frmProjekcijePrikaz";
            this.Load += new System.EventHandler(this.frmProjekcijePrikaz_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrsteProjekcije)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvVrsteProjekcije;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaProjekcijeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
    }
}