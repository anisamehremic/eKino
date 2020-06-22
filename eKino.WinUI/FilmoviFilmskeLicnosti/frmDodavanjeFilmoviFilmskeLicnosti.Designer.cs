namespace eKino.WinUI.FilmoviFilmskeLicnosti
{
    partial class frmDodavanjeFilmoviFilmskeLicnosti
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
            this.cmbFilm = new System.Windows.Forms.ComboBox();
            this.cmbLicnost = new System.Windows.Forms.ComboBox();
            this.cmbUloga = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFilm
            // 
            this.cmbFilm.FormattingEnabled = true;
            this.cmbFilm.Location = new System.Drawing.Point(16, 65);
            this.cmbFilm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFilm.Name = "cmbFilm";
            this.cmbFilm.Size = new System.Drawing.Size(201, 21);
            this.cmbFilm.TabIndex = 0;
            this.cmbFilm.Validating += new System.ComponentModel.CancelEventHandler(this.cmbFilm_Validating);
            // 
            // cmbLicnost
            // 
            this.cmbLicnost.FormattingEnabled = true;
            this.cmbLicnost.Location = new System.Drawing.Point(16, 123);
            this.cmbLicnost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbLicnost.Name = "cmbLicnost";
            this.cmbLicnost.Size = new System.Drawing.Size(201, 21);
            this.cmbLicnost.TabIndex = 1;
            this.cmbLicnost.Validating += new System.ComponentModel.CancelEventHandler(this.cmbLicnost_Validating);
            // 
            // cmbUloga
            // 
            this.cmbUloga.FormattingEnabled = true;
            this.cmbUloga.Location = new System.Drawing.Point(16, 188);
            this.cmbUloga.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbUloga.Name = "cmbUloga";
            this.cmbUloga.Size = new System.Drawing.Size(201, 21);
            this.cmbUloga.TabIndex = 2;
            this.cmbUloga.Validating += new System.ComponentModel.CancelEventHandler(this.cmbUloga_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Film";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filmska ličnost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filmska uloga";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(160, 243);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(56, 21);
            this.btnSacuvaj.TabIndex = 6;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmDodavanjeFilmoviFilmskeLicnosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 302);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUloga);
            this.Controls.Add(this.cmbLicnost);
            this.Controls.Add(this.cmbFilm);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDodavanjeFilmoviFilmskeLicnosti";
            this.Text = "DodavanjeFilmoviFilmskeLicnosti";
            this.Load += new System.EventHandler(this.frmDodavanjeFilmoviFilmskeLicnosti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFilm;
        private System.Windows.Forms.ComboBox cmbLicnost;
        private System.Windows.Forms.ComboBox cmbUloga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}