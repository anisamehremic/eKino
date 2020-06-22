namespace eKino.WinUI.Rezervacije
{
    partial class frmDodajUrediRezervaciju
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
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtCijena = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGledaoci = new System.Windows.Forms.ComboBox();
            this.cmbProjekcije = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.chbAktivna = new System.Windows.Forms.CheckBox();
            this.clbSjedista = new System.Windows.Forms.CheckedListBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(1043, 621);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(107, 30);
            this.btnSacuvaj.TabIndex = 23;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(823, 64);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.ReadOnly = true;
            this.txtCijena.Size = new System.Drawing.Size(297, 22);
            this.txtCijena.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(823, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Cijena";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Projekcija";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Gledalac";
            // 
            // cmbGledaoci
            // 
            this.cmbGledaoci.FormattingEnabled = true;
            this.cmbGledaoci.Location = new System.Drawing.Point(29, 62);
            this.cmbGledaoci.Name = "cmbGledaoci";
            this.cmbGledaoci.Size = new System.Drawing.Size(294, 24);
            this.cmbGledaoci.TabIndex = 24;
            // 
            // cmbProjekcije
            // 
            this.cmbProjekcije.FormattingEnabled = true;
            this.cmbProjekcije.Location = new System.Drawing.Point(419, 62);
            this.cmbProjekcije.Name = "cmbProjekcije";
            this.cmbProjekcije.Size = new System.Drawing.Size(294, 24);
            this.cmbProjekcije.TabIndex = 25;
            this.cmbProjekcije.SelectedIndexChanged += new System.EventHandler(this.cmbProjekcije_SelectedIndexChanged);
            this.cmbProjekcije.Validating += new System.ComponentModel.CancelEventHandler(this.cmbProjekcije_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // chbAktivna
            // 
            this.chbAktivna.AutoSize = true;
            this.chbAktivna.Checked = true;
            this.chbAktivna.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAktivna.Location = new System.Drawing.Point(29, 630);
            this.chbAktivna.Name = "chbAktivna";
            this.chbAktivna.Size = new System.Drawing.Size(76, 21);
            this.chbAktivna.TabIndex = 26;
            this.chbAktivna.Text = "Aktivna";
            this.chbAktivna.UseVisualStyleBackColor = true;
            // 
            // clbSjedista
            // 
            this.clbSjedista.FormattingEnabled = true;
            this.clbSjedista.Location = new System.Drawing.Point(21, 30);
            this.clbSjedista.MultiColumn = true;
            this.clbSjedista.Name = "clbSjedista";
            this.clbSjedista.Size = new System.Drawing.Size(549, 429);
            this.clbSjedista.TabIndex = 27;
            this.clbSjedista.SelectedIndexChanged += new System.EventHandler(this.clbSjedista_SelectedIndexChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(3, 18);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(513, 456);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 28;
            this.pictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clbSjedista);
            this.groupBox1.Location = new System.Drawing.Point(12, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 477);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izbor sjedišta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox);
            this.groupBox2.Location = new System.Drawing.Point(631, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 477);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sjedišta u sali";
            // 
            // frmDodajUrediRezervaciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 678);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chbAktivna);
            this.Controls.Add(this.cmbProjekcije);
            this.Controls.Add(this.cmbGledaoci);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmDodajUrediRezervaciju";
            this.Text = "frmDodajUrediRezervaciju";
            this.Load += new System.EventHandler(this.frmDodajUrediRezervaciju_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.MaskedTextBox txtCijena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGledaoci;
        private System.Windows.Forms.ComboBox cmbProjekcije;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckBox chbAktivna;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox clbSjedista;
    }
}