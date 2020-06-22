namespace eKino.WinUI.Ocjene
{
    partial class frmOcjenePrikaz
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
            this.dgvOcjene = new System.Windows.Forms.DataGridView();
            this.Gledalac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Film = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumOcjenjivanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProsjecnaOcjena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFilmovi = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcjene)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOcjene);
            this.groupBox1.Location = new System.Drawing.Point(11, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(573, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ocjene";
            // 
            // dgvOcjene
            // 
            this.dgvOcjene.AllowUserToAddRows = false;
            this.dgvOcjene.AllowUserToDeleteRows = false;
            this.dgvOcjene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOcjene.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gledalac,
            this.Film,
            this.Ocjena,
            this.DatumOcjenjivanja});
            this.dgvOcjene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOcjene.Location = new System.Drawing.Point(2, 15);
            this.dgvOcjene.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvOcjene.Name = "dgvOcjene";
            this.dgvOcjene.ReadOnly = true;
            this.dgvOcjene.RowHeadersWidth = 51;
            this.dgvOcjene.Size = new System.Drawing.Size(569, 240);
            this.dgvOcjene.TabIndex = 0;
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
            // Film
            // 
            this.Film.DataPropertyName = "Film";
            this.Film.HeaderText = "Film";
            this.Film.MinimumWidth = 6;
            this.Film.Name = "Film";
            this.Film.ReadOnly = true;
            this.Film.Width = 125;
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.MinimumWidth = 6;
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            this.Ocjena.Width = 125;
            // 
            // DatumOcjenjivanja
            // 
            this.DatumOcjenjivanja.DataPropertyName = "DatumOcjenjivanja";
            this.DatumOcjenjivanja.HeaderText = "Datum ocjene";
            this.DatumOcjenjivanja.MinimumWidth = 6;
            this.DatumOcjenjivanja.Name = "DatumOcjenjivanja";
            this.DatumOcjenjivanja.ReadOnly = true;
            this.DatumOcjenjivanja.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtProsjecnaOcjena);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbFilmovi);
            this.groupBox2.Location = new System.Drawing.Point(11, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(573, 75);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prosječna ocjena za odabrani film";
            // 
            // txtProsjecnaOcjena
            // 
            this.txtProsjecnaOcjena.Location = new System.Drawing.Point(405, 47);
            this.txtProsjecnaOcjena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProsjecnaOcjena.Name = "txtProsjecnaOcjena";
            this.txtProsjecnaOcjena.ReadOnly = true;
            this.txtProsjecnaOcjena.Size = new System.Drawing.Size(164, 20);
            this.txtProsjecnaOcjena.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odaberite film";
            // 
            // cmbFilmovi
            // 
            this.cmbFilmovi.FormattingEnabled = true;
            this.cmbFilmovi.Location = new System.Drawing.Point(10, 46);
            this.cmbFilmovi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFilmovi.Name = "cmbFilmovi";
            this.cmbFilmovi.Size = new System.Drawing.Size(128, 21);
            this.cmbFilmovi.TabIndex = 0;
            this.cmbFilmovi.SelectedIndexChanged += new System.EventHandler(this.cmbFilmovi_SelectedIndexChanged);
            // 
            // frmOcjenePrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmOcjenePrikaz";
            this.Text = "frmOcjenePrikaz";
            this.Load += new System.EventHandler(this.frmOcjenePrikaz_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcjene)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvOcjene;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProsjecnaOcjena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFilmovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gledalac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Film;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumOcjenjivanja;
    }
}