namespace eKino.WinUI.Sjedista
{
    partial class frmSjedistaPrikaz
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
            this.dgvSjedista = new System.Windows.Forms.DataGridView();
            this.SjedisteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sjediste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSjedista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSjedista
            // 
            this.dgvSjedista.AllowUserToAddRows = false;
            this.dgvSjedista.AllowUserToDeleteRows = false;
            this.dgvSjedista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSjedista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SjedisteId,
            this.Sala,
            this.Sjediste,
            this.Opis});
            this.dgvSjedista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSjedista.Location = new System.Drawing.Point(3, 18);
            this.dgvSjedista.Name = "dgvSjedista";
            this.dgvSjedista.ReadOnly = true;
            this.dgvSjedista.RowHeadersWidth = 51;
            this.dgvSjedista.RowTemplate.Height = 24;
            this.dgvSjedista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSjedista.Size = new System.Drawing.Size(560, 428);
            this.dgvSjedista.TabIndex = 0;
            this.dgvSjedista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvSjedista_MouseDoubleClick);
            // 
            // SjedisteId
            // 
            this.SjedisteId.DataPropertyName = "SjedisteId";
            this.SjedisteId.HeaderText = "SjedisteId";
            this.SjedisteId.MinimumWidth = 6;
            this.SjedisteId.Name = "SjedisteId";
            this.SjedisteId.ReadOnly = true;
            this.SjedisteId.Visible = false;
            this.SjedisteId.Width = 125;
            // 
            // Sala
            // 
            this.Sala.DataPropertyName = "Sala";
            this.Sala.HeaderText = "Sala";
            this.Sala.MinimumWidth = 6;
            this.Sala.Name = "Sala";
            this.Sala.ReadOnly = true;
            this.Sala.Width = 125;
            // 
            // Sjediste
            // 
            this.Sjediste.DataPropertyName = "Ispis";
            this.Sjediste.HeaderText = "Sjedište";
            this.Sjediste.MinimumWidth = 6;
            this.Sjediste.Name = "Sjediste";
            this.Sjediste.ReadOnly = true;
            this.Sjediste.Width = 125;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSjedista);
            this.groupBox1.Location = new System.Drawing.Point(2, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 449);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sjedišta po salama";
            // 
            // frmSjedistaPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 478);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSjedistaPrikaz";
            this.Text = "frmSjedistaPrikaz";
            this.Load += new System.EventHandler(this.frmSjedistaPrikaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSjedista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSjedista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SjedisteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sjediste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
    }
}