namespace eKino.WinUI.Ulaznice
{
    partial class frmUlaznicePrikaz
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
            this.dgvUlaznice = new System.Windows.Forms.DataGridView();
            this.UlaznicaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rezervacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Projekcija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sjediste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnPretraga = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProjekcije = new System.Windows.Forms.ComboBox();
            this.cbAktivne = new System.Windows.Forms.CheckBox();
            this.cbNeaktivne = new System.Windows.Forms.CheckBox();
            this.btnPrikaz = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUlaznice)).BeginInit();
            this.btnPretraga.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUlaznice);
            this.groupBox1.Location = new System.Drawing.Point(11, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(520, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ulaznice";
            // 
            // dgvUlaznice
            // 
            this.dgvUlaznice.AllowUserToAddRows = false;
            this.dgvUlaznice.AllowUserToDeleteRows = false;
            this.dgvUlaznice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUlaznice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUlaznice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UlaznicaId,
            this.Rezervacija,
            this.Projekcija,
            this.Sjediste,
            this.Cijena,
            this.Status});
            this.dgvUlaznice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUlaznice.Location = new System.Drawing.Point(2, 15);
            this.dgvUlaznice.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUlaznice.Name = "dgvUlaznice";
            this.dgvUlaznice.ReadOnly = true;
            this.dgvUlaznice.RowHeadersWidth = 51;
            this.dgvUlaznice.RowTemplate.Height = 24;
            this.dgvUlaznice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUlaznice.Size = new System.Drawing.Size(516, 221);
            this.dgvUlaznice.TabIndex = 0;
            this.dgvUlaznice.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvUlaznice_MouseDoubleClick);
            // 
            // UlaznicaId
            // 
            this.UlaznicaId.DataPropertyName = "UlaznicaId";
            this.UlaznicaId.HeaderText = "UlaznicaId";
            this.UlaznicaId.MinimumWidth = 6;
            this.UlaznicaId.Name = "UlaznicaId";
            this.UlaznicaId.ReadOnly = true;
            this.UlaznicaId.Visible = false;
            this.UlaznicaId.Width = 82;
            // 
            // Rezervacija
            // 
            this.Rezervacija.DataPropertyName = "Rezervacija";
            this.Rezervacija.HeaderText = "Rezervacija";
            this.Rezervacija.MinimumWidth = 6;
            this.Rezervacija.Name = "Rezervacija";
            this.Rezervacija.ReadOnly = true;
            this.Rezervacija.Width = 88;
            // 
            // Projekcija
            // 
            this.Projekcija.DataPropertyName = "Projekcija";
            this.Projekcija.HeaderText = "Projekcija";
            this.Projekcija.MinimumWidth = 6;
            this.Projekcija.Name = "Projekcija";
            this.Projekcija.ReadOnly = true;
            this.Projekcija.Width = 78;
            // 
            // Sjediste
            // 
            this.Sjediste.DataPropertyName = "Sjediste";
            this.Sjediste.HeaderText = "Sjedište";
            this.Sjediste.MinimumWidth = 6;
            this.Sjediste.Name = "Sjediste";
            this.Sjediste.ReadOnly = true;
            this.Sjediste.Width = 69;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "CijenaString";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.MinimumWidth = 6;
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            this.Cijena.Width = 61;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 43;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Controls.Add(this.btnPrikaz);
            this.btnPretraga.Controls.Add(this.cbNeaktivne);
            this.btnPretraga.Controls.Add(this.cbAktivne);
            this.btnPretraga.Controls.Add(this.label1);
            this.btnPretraga.Controls.Add(this.cmbProjekcije);
            this.btnPretraga.Location = new System.Drawing.Point(13, 11);
            this.btnPretraga.Margin = new System.Windows.Forms.Padding(2);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Padding = new System.Windows.Forms.Padding(2);
            this.btnPretraga.Size = new System.Drawing.Size(518, 73);
            this.btnPretraga.TabIndex = 2;
            this.btnPretraga.TabStop = false;
            this.btnPretraga.Text = "Pretraga";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odaberite projekciju";
            // 
            // cmbProjekcije
            // 
            this.cmbProjekcije.FormattingEnabled = true;
            this.cmbProjekcije.Location = new System.Drawing.Point(13, 43);
            this.cmbProjekcije.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProjekcije.Name = "cmbProjekcije";
            this.cmbProjekcije.Size = new System.Drawing.Size(166, 21);
            this.cmbProjekcije.TabIndex = 0;
            // 
            // cbAktivne
            // 
            this.cbAktivne.AutoSize = true;
            this.cbAktivne.Location = new System.Drawing.Point(268, 22);
            this.cbAktivne.Name = "cbAktivne";
            this.cbAktivne.Size = new System.Drawing.Size(62, 17);
            this.cbAktivne.TabIndex = 6;
            this.cbAktivne.Text = "Aktivne";
            this.cbAktivne.UseVisualStyleBackColor = true;
            // 
            // cbNeaktivne
            // 
            this.cbNeaktivne.AutoSize = true;
            this.cbNeaktivne.Location = new System.Drawing.Point(268, 45);
            this.cbNeaktivne.Name = "cbNeaktivne";
            this.cbNeaktivne.Size = new System.Drawing.Size(75, 17);
            this.cbNeaktivne.TabIndex = 7;
            this.cbNeaktivne.Text = "Neaktivne";
            this.cbNeaktivne.UseVisualStyleBackColor = true;
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.Location = new System.Drawing.Point(433, 39);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(75, 23);
            this.btnPrikaz.TabIndex = 8;
            this.btnPrikaz.Text = "Prikaži";
            this.btnPrikaz.UseVisualStyleBackColor = true;
            this.btnPrikaz.Click += new System.EventHandler(this.btnPrikaz_Click);
            // 
            // frmUlaznicePrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 336);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUlaznicePrikaz";
            this.Text = "frmUlaznicePrikaz";
            this.Load += new System.EventHandler(this.frmUlaznicePrikaz_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUlaznice)).EndInit();
            this.btnPretraga.ResumeLayout(false);
            this.btnPretraga.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUlaznice;
        private System.Windows.Forms.DataGridViewTextBoxColumn UlaznicaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rezervacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Projekcija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sjediste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.GroupBox btnPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProjekcije;
        private System.Windows.Forms.Button btnPrikaz;
        private System.Windows.Forms.CheckBox cbNeaktivne;
        private System.Windows.Forms.CheckBox cbAktivne;
    }
}