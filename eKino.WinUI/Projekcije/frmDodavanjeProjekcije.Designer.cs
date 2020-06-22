namespace eKino.WinUI.Projekcije
{
    partial class frmDodavanjeProjekcije
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
            this.cmbFilmovi = new System.Windows.Forms.ComboBox();
            this.cmbSale = new System.Windows.Forms.ComboBox();
            this.dtpProjekcije = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbVrstaProjekcije = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numCijena = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCijena)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFilmovi
            // 
            this.cmbFilmovi.FormattingEnabled = true;
            this.cmbFilmovi.Location = new System.Drawing.Point(24, 39);
            this.cmbFilmovi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFilmovi.Name = "cmbFilmovi";
            this.cmbFilmovi.Size = new System.Drawing.Size(237, 21);
            this.cmbFilmovi.TabIndex = 0;
            this.cmbFilmovi.Validating += new System.ComponentModel.CancelEventHandler(this.cmbFilmovi_Validating);
            // 
            // cmbSale
            // 
            this.cmbSale.FormattingEnabled = true;
            this.cmbSale.Location = new System.Drawing.Point(24, 86);
            this.cmbSale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSale.Name = "cmbSale";
            this.cmbSale.Size = new System.Drawing.Size(237, 21);
            this.cmbSale.TabIndex = 1;
            this.cmbSale.Validating += new System.ComponentModel.CancelEventHandler(this.cmbSale_Validating);
            // 
            // dtpProjekcije
            // 
            this.dtpProjekcije.CustomFormat = "";
            this.dtpProjekcije.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpProjekcije.Location = new System.Drawing.Point(24, 134);
            this.dtpProjekcije.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpProjekcije.Name = "dtpProjekcije";
            this.dtpProjekcije.Size = new System.Drawing.Size(237, 20);
            this.dtpProjekcije.TabIndex = 2;
            this.dtpProjekcije.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpProjekcije_MouseDown);
            this.dtpProjekcije.Validating += new System.ComponentModel.CancelEventHandler(this.dtpProjekcije_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Film";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sala";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum prikazivanja projekcije";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(165, 275);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(96, 31);
            this.btnSacuvaj.TabIndex = 6;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cmbVrstaProjekcije
            // 
            this.cmbVrstaProjekcije.FormattingEnabled = true;
            this.cmbVrstaProjekcije.Location = new System.Drawing.Point(24, 181);
            this.cmbVrstaProjekcije.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbVrstaProjekcije.Name = "cmbVrstaProjekcije";
            this.cmbVrstaProjekcije.Size = new System.Drawing.Size(237, 21);
            this.cmbVrstaProjekcije.TabIndex = 7;
            this.cmbVrstaProjekcije.Validating += new System.ComponentModel.CancelEventHandler(this.cmbVrstaProjekcije_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vrsta projekcije";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cijena";
            // 
            // numCijena
            // 
            this.numCijena.DecimalPlaces = 2;
            this.numCijena.Location = new System.Drawing.Point(24, 229);
            this.numCijena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numCijena.Name = "numCijena";
            this.numCijena.Size = new System.Drawing.Size(237, 20);
            this.numCijena.TabIndex = 11;
            this.numCijena.Validating += new System.ComponentModel.CancelEventHandler(this.numCijena_Validating);
            // 
            // frmDodavanjeProjekcije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 327);
            this.Controls.Add(this.numCijena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbVrstaProjekcije);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpProjekcije);
            this.Controls.Add(this.cmbSale);
            this.Controls.Add(this.cmbFilmovi);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDodavanjeProjekcije";
            this.Text = "frmDodavanjeProjekcije";
            this.Load += new System.EventHandler(this.frmDodavanjeProjekcije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCijena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFilmovi;
        private System.Windows.Forms.ComboBox cmbSale;
        private System.Windows.Forms.DateTimePicker dtpProjekcije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbVrstaProjekcije;
        private System.Windows.Forms.NumericUpDown numCijena;
    }
}