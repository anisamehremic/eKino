namespace eKino.WinUI.FilmskeUloge
{
    partial class frmPrikazFilmskeUloge
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
            this.dgvfilmskeUloge = new System.Windows.Forms.DataGridView();
            this.FilmskaUlogaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfilmskeUloge)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvfilmskeUloge);
            this.groupBox1.Location = new System.Drawing.Point(-1, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 438);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filmske uloge";
            // 
            // dgvfilmskeUloge
            // 
            this.dgvfilmskeUloge.AllowUserToAddRows = false;
            this.dgvfilmskeUloge.AllowUserToDeleteRows = false;
            this.dgvfilmskeUloge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfilmskeUloge.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilmskaUlogaId,
            this.Naziv,
            this.Opis});
            this.dgvfilmskeUloge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvfilmskeUloge.Location = new System.Drawing.Point(3, 18);
            this.dgvfilmskeUloge.Name = "dgvfilmskeUloge";
            this.dgvfilmskeUloge.ReadOnly = true;
            this.dgvfilmskeUloge.RowHeadersWidth = 51;
            this.dgvfilmskeUloge.RowTemplate.Height = 24;
            this.dgvfilmskeUloge.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvfilmskeUloge.Size = new System.Drawing.Size(402, 417);
            this.dgvfilmskeUloge.TabIndex = 0;
            this.dgvfilmskeUloge.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvfilmskeUloge_MouseDoubleClick);
            // 
            // FilmskaUlogaId
            // 
            this.FilmskaUlogaId.DataPropertyName = "FilmskaUlogaId";
            this.FilmskaUlogaId.HeaderText = "FilmskaUlogaId";
            this.FilmskaUlogaId.MinimumWidth = 6;
            this.FilmskaUlogaId.Name = "FilmskaUlogaId";
            this.FilmskaUlogaId.ReadOnly = true;
            this.FilmskaUlogaId.Visible = false;
            this.FilmskaUlogaId.Width = 125;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.MinimumWidth = 6;
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 125;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.MinimumWidth = 6;
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            this.Opis.Width = 125;
            // 
            // frmPrikazFilmskeUloge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrikazFilmskeUloge";
            this.Text = "frmPrikazFilmskeUloge";
            this.Load += new System.EventHandler(this.frmPrikazFilmskeUloge_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfilmskeUloge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvfilmskeUloge;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmskaUlogaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
    }
}