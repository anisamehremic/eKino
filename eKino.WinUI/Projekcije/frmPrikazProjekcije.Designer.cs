namespace eKino.WinUI.Projekcije
{
    partial class frmPrikazProjekcije
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
            this.dgvProjekcije = new System.Windows.Forms.DataGridView();
            this.ProjekcijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Film = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumVrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaProjekcije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFilmovi = new System.Windows.Forms.ComboBox();
            this.cmbSale = new System.Windows.Forms.ComboBox();
            this.tnPrikazi = new System.Windows.Forms.Button();
            this.dtpDatumPrikazivanja = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjekcije)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProjekcije);
            this.groupBox1.Location = new System.Drawing.Point(15, 127);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(912, 359);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Projekcije";
            // 
            // dgvProjekcije
            // 
            this.dgvProjekcije.AllowUserToAddRows = false;
            this.dgvProjekcije.AllowUserToDeleteRows = false;
            this.dgvProjekcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjekcije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjekcijaId,
            this.Film,
            this.Sala,
            this.DatumVrijeme,
            this.VrstaProjekcije,
            this.Cijena});
            this.dgvProjekcije.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProjekcije.Location = new System.Drawing.Point(3, 17);
            this.dgvProjekcije.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProjekcije.Name = "dgvProjekcije";
            this.dgvProjekcije.ReadOnly = true;
            this.dgvProjekcije.RowHeadersWidth = 51;
            this.dgvProjekcije.RowTemplate.Height = 24;
            this.dgvProjekcije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjekcije.Size = new System.Drawing.Size(906, 340);
            this.dgvProjekcije.TabIndex = 0;
            this.dgvProjekcije.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvProjekcije_MouseDoubleClick);
            // 
            // ProjekcijaId
            // 
            this.ProjekcijaId.DataPropertyName = "ProjekcijaId";
            this.ProjekcijaId.HeaderText = "ProjekcijaId";
            this.ProjekcijaId.MinimumWidth = 6;
            this.ProjekcijaId.Name = "ProjekcijaId";
            this.ProjekcijaId.ReadOnly = true;
            this.ProjekcijaId.Visible = false;
            this.ProjekcijaId.Width = 125;
            // 
            // Film
            // 
            this.Film.DataPropertyName = "Film";
            this.Film.HeaderText = "Film";
            this.Film.MinimumWidth = 6;
            this.Film.Name = "Film";
            this.Film.ReadOnly = true;
            this.Film.Width = 125;
            // 
            // Sala
            // 
            this.Sala.DataPropertyName = "Sala";
            this.Sala.HeaderText = "Sala";
            this.Sala.MinimumWidth = 6;
            this.Sala.Name = "Sala";
            this.Sala.ReadOnly = true;
            this.Sala.Width = 125;
            // 
            // DatumVrijeme
            // 
            this.DatumVrijeme.DataPropertyName = "DatumVrijemeOdrzavanja";
            this.DatumVrijeme.HeaderText = "Datum i vrijeme prikazivanja";
            this.DatumVrijeme.MinimumWidth = 6;
            this.DatumVrijeme.Name = "DatumVrijeme";
            this.DatumVrijeme.ReadOnly = true;
            this.DatumVrijeme.Width = 125;
            // 
            // VrstaProjekcije
            // 
            this.VrstaProjekcije.DataPropertyName = "VrstaProjekcije";
            this.VrstaProjekcije.HeaderText = "Vrsta projekcije";
            this.VrstaProjekcije.MinimumWidth = 6;
            this.VrstaProjekcije.Name = "VrstaProjekcije";
            this.VrstaProjekcije.ReadOnly = true;
            this.VrstaProjekcije.Width = 125;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.MinimumWidth = 6;
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            this.Cijena.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbFilmovi);
            this.groupBox2.Controls.Add(this.cmbSale);
            this.groupBox2.Controls.Add(this.tnPrikazi);
            this.groupBox2.Controls.Add(this.dtpDatumPrikazivanja);
            this.groupBox2.Location = new System.Drawing.Point(15, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(912, 96);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum i vrijeme prikazivanja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sala";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Film";
            // 
            // cmbFilmovi
            // 
            this.cmbFilmovi.FormattingEnabled = true;
            this.cmbFilmovi.Location = new System.Drawing.Point(19, 46);
            this.cmbFilmovi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFilmovi.Name = "cmbFilmovi";
            this.cmbFilmovi.Size = new System.Drawing.Size(176, 24);
            this.cmbFilmovi.TabIndex = 3;
            // 
            // cmbSale
            // 
            this.cmbSale.FormattingEnabled = true;
            this.cmbSale.Location = new System.Drawing.Point(259, 46);
            this.cmbSale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSale.Name = "cmbSale";
            this.cmbSale.Size = new System.Drawing.Size(176, 24);
            this.cmbSale.TabIndex = 2;
            // 
            // tnPrikazi
            // 
            this.tnPrikazi.Location = new System.Drawing.Point(803, 41);
            this.tnPrikazi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tnPrikazi.Name = "tnPrikazi";
            this.tnPrikazi.Size = new System.Drawing.Size(104, 32);
            this.tnPrikazi.TabIndex = 1;
            this.tnPrikazi.Text = "Prikaži";
            this.tnPrikazi.UseVisualStyleBackColor = true;
            this.tnPrikazi.Click += new System.EventHandler(this.tnPrikazi_Click);
            // 
            // dtpDatumPrikazivanja
            // 
            this.dtpDatumPrikazivanja.CustomFormat = " ";
            this.dtpDatumPrikazivanja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumPrikazivanja.Location = new System.Drawing.Point(495, 47);
            this.dtpDatumPrikazivanja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDatumPrikazivanja.Name = "dtpDatumPrikazivanja";
            this.dtpDatumPrikazivanja.Size = new System.Drawing.Size(232, 22);
            this.dtpDatumPrikazivanja.TabIndex = 0;
            this.dtpDatumPrikazivanja.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDatumPrikazivanja.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpDatumPrikazivanja_MouseDown);
            // 
            // frmPrikazProjekcije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 500);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPrikazProjekcije";
            this.Text = "frmPrikazProjekcije";
            this.Load += new System.EventHandler(this.frmPrikazProjekcije_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjekcije)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProjekcije;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFilmovi;
        private System.Windows.Forms.ComboBox cmbSale;
        private System.Windows.Forms.Button tnPrikazi;
        private System.Windows.Forms.DateTimePicker dtpDatumPrikazivanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjekcijaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Film;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumVrijeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaProjekcije;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
    }
}