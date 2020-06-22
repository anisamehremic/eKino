namespace eKino.WinUI.Filmovi
{
    partial class frmDodavanjeFilmova
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
            this.components = new System.ComponentModel.Container();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.txtDodajSliku = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.cmbDrzave = new System.Windows.Forms.ComboBox();
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.clabZanrovi = new System.Windows.Forms.CheckedListBox();
            this.clbZanrovi = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.numaricTrajanje = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numaricTrajanje)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(16, 50);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(293, 22);
            this.txtNaziv.TabIndex = 0;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv filma";
            // 
            // dtpDatum
            // 
            this.dtpDatum.CustomFormat = "";
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(16, 114);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(295, 22);
            this.dtpDatum.TabIndex = 2;
            this.dtpDatum.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDatum_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datum izdavanja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Opis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Trajanje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Slika";
            // 
            // txtSlika
            // 
            this.txtSlika.Location = new System.Drawing.Point(347, 236);
            this.txtSlika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.ReadOnly = true;
            this.txtSlika.Size = new System.Drawing.Size(203, 22);
            this.txtSlika.TabIndex = 8;
            this.txtSlika.Validating += new System.ComponentModel.CancelEventHandler(this.txtSlika_Validating);
            // 
            // txtDodajSliku
            // 
            this.txtDodajSliku.Location = new System.Drawing.Point(553, 236);
            this.txtDodajSliku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDodajSliku.Name = "txtDodajSliku";
            this.txtDodajSliku.Size = new System.Drawing.Size(64, 25);
            this.txtDodajSliku.TabIndex = 10;
            this.txtDodajSliku.Text = "Dodaj";
            this.txtDodajSliku.UseVisualStyleBackColor = true;
            this.txtDodajSliku.Click += new System.EventHandler(this.txtDodajSliku_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Država";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(532, 484);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(101, 41);
            this.btnSacuvaj.TabIndex = 13;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(348, 32);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(268, 171);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;
            // 
            // cmbDrzave
            // 
            this.cmbDrzave.FormattingEnabled = true;
            this.cmbDrzave.Location = new System.Drawing.Point(16, 236);
            this.cmbDrzave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDrzave.Name = "cmbDrzave";
            this.cmbDrzave.Size = new System.Drawing.Size(292, 24);
            this.cmbDrzave.TabIndex = 15;
            this.cmbDrzave.Validating += new System.ComponentModel.CancelEventHandler(this.cmbDrzave_Validating);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(16, 298);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(292, 147);
            this.txtOpis.TabIndex = 16;
            this.txtOpis.Text = "";
            this.txtOpis.Validating += new System.ComponentModel.CancelEventHandler(this.txtOpis_Validating);
            // 
            // clabZanrovi
            // 
            this.clabZanrovi.FormattingEnabled = true;
            this.clabZanrovi.Location = new System.Drawing.Point(347, 298);
            this.clabZanrovi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clabZanrovi.Name = "clabZanrovi";
            this.clabZanrovi.Size = new System.Drawing.Size(269, 89);
            this.clabZanrovi.TabIndex = 17;
            this.clabZanrovi.Validating += new System.ComponentModel.CancelEventHandler(this.clabZanrovi_Validating);
            // 
            // clbZanrovi
            // 
            this.clbZanrovi.AutoSize = true;
            this.clbZanrovi.Location = new System.Drawing.Point(345, 277);
            this.clbZanrovi.Name = "clbZanrovi";
            this.clbZanrovi.Size = new System.Drawing.Size(38, 17);
            this.clbZanrovi.TabIndex = 18;
            this.clbZanrovi.Text = "Žanr";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // numaricTrajanje
            // 
            this.numaricTrajanje.Location = new System.Drawing.Point(16, 177);
            this.numaricTrajanje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numaricTrajanje.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numaricTrajanje.Name = "numaricTrajanje";
            this.numaricTrajanje.Size = new System.Drawing.Size(296, 22);
            this.numaricTrajanje.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.clbZanrovi);
            this.groupBox1.Controls.Add(this.numaricTrajanje);
            this.groupBox1.Controls.Add(this.clabZanrovi);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Controls.Add(this.txtOpis);
            this.groupBox1.Controls.Add(this.txtDodajSliku);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbDrzave);
            this.groupBox1.Controls.Add(this.txtSlika);
            this.groupBox1.Controls.Add(this.dtpDatum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(635, 459);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj";
            // 
            // frmDodavanjeFilmova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 534);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSacuvaj);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDodavanjeFilmova";
            this.Text = "frmDodavanjeFilmova";
            this.Load += new System.EventHandler(this.frmDodavanjeFilmova_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numaricTrajanje)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.Button txtDodajSliku;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox cmbDrzave;
        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.CheckedListBox clabZanrovi;
        private System.Windows.Forms.Label clbZanrovi;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.NumericUpDown numaricTrajanje;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}