namespace eKino.WinUI.FilmoviFilmskeLicnosti
{
    partial class frmPrikazFilmoviFilmskeLicnosti
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
            this.dgvFilmoviLicnosti = new System.Windows.Forms.DataGridView();
            this.FilmFilmskaLicnostId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Film = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilmskaLicnost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilmskaUloga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmoviLicnosti)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvFilmoviLicnosti);
            this.groupBox1.Location = new System.Drawing.Point(-3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 438);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filmovi/filmske ličnosti";
            // 
            // dgvFilmoviLicnosti
            // 
            this.dgvFilmoviLicnosti.AllowUserToAddRows = false;
            this.dgvFilmoviLicnosti.AllowUserToDeleteRows = false;
            this.dgvFilmoviLicnosti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmoviLicnosti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilmFilmskaLicnostId,
            this.Film,
            this.FilmskaLicnost,
            this.FilmskaUloga});
            this.dgvFilmoviLicnosti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFilmoviLicnosti.Location = new System.Drawing.Point(3, 18);
            this.dgvFilmoviLicnosti.Name = "dgvFilmoviLicnosti";
            this.dgvFilmoviLicnosti.ReadOnly = true;
            this.dgvFilmoviLicnosti.RowHeadersWidth = 51;
            this.dgvFilmoviLicnosti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilmoviLicnosti.Size = new System.Drawing.Size(561, 417);
            this.dgvFilmoviLicnosti.TabIndex = 0;
            this.dgvFilmoviLicnosti.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvFilmoviLicnosti_MouseDoubleClick);
            // 
            // FilmFilmskaLicnostId
            // 
            this.FilmFilmskaLicnostId.DataPropertyName = "FilmFilmskaLicnostId";
            this.FilmFilmskaLicnostId.HeaderText = "FilmFilmskaLicnostId";
            this.FilmFilmskaLicnostId.MinimumWidth = 6;
            this.FilmFilmskaLicnostId.Name = "FilmFilmskaLicnostId";
            this.FilmFilmskaLicnostId.ReadOnly = true;
            this.FilmFilmskaLicnostId.Visible = false;
            this.FilmFilmskaLicnostId.Width = 125;
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
            // FilmskaLicnost
            // 
            this.FilmskaLicnost.DataPropertyName = "FilmskaLicnost";
            this.FilmskaLicnost.HeaderText = "Filmska ličnost";
            this.FilmskaLicnost.MinimumWidth = 6;
            this.FilmskaLicnost.Name = "FilmskaLicnost";
            this.FilmskaLicnost.ReadOnly = true;
            this.FilmskaLicnost.Width = 125;
            // 
            // FilmskaUloga
            // 
            this.FilmskaUloga.DataPropertyName = "FilmskaUloga";
            this.FilmskaUloga.HeaderText = "Filmska uloga";
            this.FilmskaUloga.MinimumWidth = 6;
            this.FilmskaUloga.Name = "FilmskaUloga";
            this.FilmskaUloga.ReadOnly = true;
            this.FilmskaUloga.Width = 125;
            // 
            // frmPrikazFilmoviFilmskeLicnosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrikazFilmoviFilmskeLicnosti";
            this.Text = "PrikazFilmoviFimskeLicnosti";
            this.Load += new System.EventHandler(this.frmPrikazFilmoviFilmskeLicnosti_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmoviLicnosti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvFilmoviLicnosti;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmFilmskaLicnostId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Film;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmskaLicnost;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmskaUloga;
    }
}