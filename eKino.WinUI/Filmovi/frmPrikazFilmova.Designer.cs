namespace eKino.WinUI.Filmovi
{
    partial class frmPrikazFilmova
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
            this.dgvPrikazFilmova = new System.Windows.Forms.DataGridView();
            this.FilmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivFilma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trajanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumNastanka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Žanr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Država = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.SlikaThumb = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.dtpDatumIzdavanja = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clbZanrovi = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazFilmova)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPrikazFilmova);
            this.groupBox1.Location = new System.Drawing.Point(12, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(902, 380);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filmovi";
            // 
            // dgvPrikazFilmova
            // 
            this.dgvPrikazFilmova.AllowUserToAddRows = false;
            this.dgvPrikazFilmova.AllowUserToDeleteRows = false;
            this.dgvPrikazFilmova.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPrikazFilmova.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikazFilmova.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilmId,
            this.NazivFilma,
            this.Trajanje,
            this.DatumNastanka,
            this.Žanr,
            this.Opis,
            this.Država,
            this.Slika,
            this.SlikaThumb});
            this.dgvPrikazFilmova.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrikazFilmova.Location = new System.Drawing.Point(3, 18);
            this.dgvPrikazFilmova.Name = "dgvPrikazFilmova";
            this.dgvPrikazFilmova.ReadOnly = true;
            this.dgvPrikazFilmova.RowHeadersWidth = 51;
            this.dgvPrikazFilmova.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrikazFilmova.Size = new System.Drawing.Size(896, 359);
            this.dgvPrikazFilmova.TabIndex = 0;
            this.dgvPrikazFilmova.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPrikazFilmova_MouseDoubleClick);
            // 
            // FilmId
            // 
            this.FilmId.DataPropertyName = "FilmId";
            this.FilmId.HeaderText = "FilmId";
            this.FilmId.MinimumWidth = 6;
            this.FilmId.Name = "FilmId";
            this.FilmId.ReadOnly = true;
            this.FilmId.Visible = false;
            this.FilmId.Width = 73;
            // 
            // NazivFilma
            // 
            this.NazivFilma.DataPropertyName = "Naziv";
            this.NazivFilma.HeaderText = "Naziv filma";
            this.NazivFilma.MinimumWidth = 6;
            this.NazivFilma.Name = "NazivFilma";
            this.NazivFilma.ReadOnly = true;
            this.NazivFilma.Width = 97;
            // 
            // Trajanje
            // 
            this.Trajanje.DataPropertyName = "Trajanje";
            this.Trajanje.FillWeight = 70F;
            this.Trajanje.HeaderText = "Trajanje";
            this.Trajanje.MinimumWidth = 6;
            this.Trajanje.Name = "Trajanje";
            this.Trajanje.ReadOnly = true;
            this.Trajanje.Width = 89;
            // 
            // DatumNastanka
            // 
            this.DatumNastanka.DataPropertyName = "DatumSnimanja";
            this.DatumNastanka.HeaderText = "Datum nastanka";
            this.DatumNastanka.MinimumWidth = 6;
            this.DatumNastanka.Name = "DatumNastanka";
            this.DatumNastanka.ReadOnly = true;
            this.DatumNastanka.Width = 128;
            // 
            // Žanr
            // 
            this.Žanr.DataPropertyName = "Zanrovi";
            this.Žanr.HeaderText = "Žanr";
            this.Žanr.MinimumWidth = 6;
            this.Žanr.Name = "Žanr";
            this.Žanr.ReadOnly = true;
            this.Žanr.Width = 67;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.MinimumWidth = 6;
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            this.Opis.Width = 66;
            // 
            // Država
            // 
            this.Država.DataPropertyName = "Drzava";
            this.Država.HeaderText = "Država";
            this.Država.MinimumWidth = 6;
            this.Država.Name = "Država";
            this.Država.ReadOnly = true;
            this.Država.Width = 82;
            // 
            // Slika
            // 
            this.Slika.DataPropertyName = "Slika";
            this.Slika.HeaderText = "Slika";
            this.Slika.MinimumWidth = 6;
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            this.Slika.Width = 44;
            // 
            // SlikaThumb
            // 
            this.SlikaThumb.DataPropertyName = "SlikaThumb";
            this.SlikaThumb.HeaderText = "SlikaThumb";
            this.SlikaThumb.MinimumWidth = 6;
            this.SlikaThumb.Name = "SlikaThumb";
            this.SlikaThumb.ReadOnly = true;
            this.SlikaThumb.Width = 88;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(9, 58);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(200, 22);
            this.txtNaziv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv filma";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(782, 58);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(115, 33);
            this.btnPrikazi.TabIndex = 3;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dtpDatumIzdavanja
            // 
            this.dtpDatumIzdavanja.CustomFormat = " ";
            this.dtpDatumIzdavanja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumIzdavanja.Location = new System.Drawing.Point(276, 58);
            this.dtpDatumIzdavanja.Name = "dtpDatumIzdavanja";
            this.dtpDatumIzdavanja.Size = new System.Drawing.Size(200, 22);
            this.dtpDatumIzdavanja.TabIndex = 4;
            this.dtpDatumIzdavanja.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDatumIzdavanja.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpDatumIzdavanja_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Datum izdavanja";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.clbZanrovi);
            this.groupBox2.Controls.Add(this.dtpDatumIzdavanja);
            this.groupBox2.Controls.Add(this.btnPrikazi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNaziv);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(902, 135);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Žanr";
            // 
            // clbZanrovi
            // 
            this.clbZanrovi.FormattingEnabled = true;
            this.clbZanrovi.Location = new System.Drawing.Point(547, 58);
            this.clbZanrovi.Name = "clbZanrovi";
            this.clbZanrovi.Size = new System.Drawing.Size(172, 72);
            this.clbZanrovi.TabIndex = 6;
            // 
            // frmPrikazFilmova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 545);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrikazFilmova";
            this.Text = "frmPrikazFilmova";
            this.Load += new System.EventHandler(this.frmPrikazFilmova_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazFilmova)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPrikazFilmova;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.DateTimePicker dtpDatumIzdavanja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox clbZanrovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivFilma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trajanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumNastanka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Žanr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Država;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.DataGridViewImageColumn SlikaThumb;
    }
}