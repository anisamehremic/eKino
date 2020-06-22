namespace eKino.WinUI.FilmskeLičnosti
{
    partial class frmPrikazFilmskihLicnosti
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
            this.dgvFilmskeLicnosti = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.txtPrezimePretraga = new System.Windows.Forms.TextBox();
            this.txtImePretraga = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FilmskaLicnostId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drzava = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmskeLicnosti)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvFilmskeLicnosti);
            this.groupBox1.Location = new System.Drawing.Point(9, 95);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(511, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filmske ličnosti";
            // 
            // dgvFilmskeLicnosti
            // 
            this.dgvFilmskeLicnosti.AllowUserToAddRows = false;
            this.dgvFilmskeLicnosti.AllowUserToDeleteRows = false;
            this.dgvFilmskeLicnosti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFilmskeLicnosti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmskeLicnosti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilmskaLicnostId,
            this.Ime,
            this.Prezime,
            this.DatumRodjenja,
            this.Drzava,
            this.Slika});
            this.dgvFilmskeLicnosti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFilmskeLicnosti.Location = new System.Drawing.Point(2, 15);
            this.dgvFilmskeLicnosti.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFilmskeLicnosti.Name = "dgvFilmskeLicnosti";
            this.dgvFilmskeLicnosti.ReadOnly = true;
            this.dgvFilmskeLicnosti.RowHeadersWidth = 51;
            this.dgvFilmskeLicnosti.RowTemplate.Height = 24;
            this.dgvFilmskeLicnosti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilmskeLicnosti.Size = new System.Drawing.Size(507, 241);
            this.dgvFilmskeLicnosti.TabIndex = 0;
            this.dgvFilmskeLicnosti.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvFilmskeLicnosti_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ime";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(433, 49);
            this.btnPrikazi.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(74, 20);
            this.btnPrikazi.TabIndex = 8;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // txtPrezimePretraga
            // 
            this.txtPrezimePretraga.Location = new System.Drawing.Point(211, 50);
            this.txtPrezimePretraga.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrezimePretraga.Name = "txtPrezimePretraga";
            this.txtPrezimePretraga.Size = new System.Drawing.Size(159, 20);
            this.txtPrezimePretraga.TabIndex = 7;
            // 
            // txtImePretraga
            // 
            this.txtImePretraga.Location = new System.Drawing.Point(5, 50);
            this.txtImePretraga.Margin = new System.Windows.Forms.Padding(2);
            this.txtImePretraga.Name = "txtImePretraga";
            this.txtImePretraga.Size = new System.Drawing.Size(159, 20);
            this.txtImePretraga.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtImePretraga);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtPrezimePretraga);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnPrikazi);
            this.groupBox2.Location = new System.Drawing.Point(9, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(511, 81);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga";
            // 
            // FilmskaLicnostId
            // 
            this.FilmskaLicnostId.DataPropertyName = "FilmskaLicnostId";
            this.FilmskaLicnostId.HeaderText = "FilmskaLicnostId";
            this.FilmskaLicnostId.MinimumWidth = 6;
            this.FilmskaLicnostId.Name = "FilmskaLicnostId";
            this.FilmskaLicnostId.ReadOnly = true;
            this.FilmskaLicnostId.Visible = false;
            this.FilmskaLicnostId.Width = 110;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.MinimumWidth = 6;
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            this.Ime.Width = 49;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.MinimumWidth = 6;
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            this.Prezime.Width = 69;
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.DataPropertyName = "DatumRodjenja";
            this.DatumRodjenja.HeaderText = "Datum rođenja";
            this.DatumRodjenja.MinimumWidth = 6;
            this.DatumRodjenja.Name = "DatumRodjenja";
            this.DatumRodjenja.ReadOnly = true;
            this.DatumRodjenja.Width = 102;
            // 
            // Drzava
            // 
            this.Drzava.DataPropertyName = "Drzava";
            this.Drzava.HeaderText = "Država";
            this.Drzava.MinimumWidth = 6;
            this.Drzava.Name = "Drzava";
            this.Drzava.ReadOnly = true;
            this.Drzava.Width = 66;
            // 
            // Slika
            // 
            this.Slika.DataPropertyName = "Slika";
            this.Slika.HeaderText = "Slika";
            this.Slika.MinimumWidth = 6;
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            this.Slika.Width = 36;
            // 
            // frmPrikazFilmskihLicnosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 364);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPrikazFilmskihLicnosti";
            this.Text = "frmPrikazFilmskihLicnosti";
            this.Load += new System.EventHandler(this.frmPrikazFilmskihLicnosti_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmskeLicnosti)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvFilmskeLicnosti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.TextBox txtPrezimePretraga;
        private System.Windows.Forms.TextBox txtImePretraga;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmskaLicnostId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drzava;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
    }
}