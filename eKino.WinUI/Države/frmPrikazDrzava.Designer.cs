namespace eKino.WinUI.Države
{
    partial class frmPrikazDrzava
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
            this.dgv_PrikazDrzava = new System.Windows.Forms.DataGridView();
            this.DrzavaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PrikazDrzava)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_PrikazDrzava);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(169, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Države";
            // 
            // dgv_PrikazDrzava
            // 
            this.dgv_PrikazDrzava.AllowUserToAddRows = false;
            this.dgv_PrikazDrzava.AllowUserToDeleteRows = false;
            this.dgv_PrikazDrzava.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PrikazDrzava.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DrzavaId,
            this.Naziv});
            this.dgv_PrikazDrzava.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_PrikazDrzava.Location = new System.Drawing.Point(2, 15);
            this.dgv_PrikazDrzava.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_PrikazDrzava.Name = "dgv_PrikazDrzava";
            this.dgv_PrikazDrzava.ReadOnly = true;
            this.dgv_PrikazDrzava.RowHeadersWidth = 51;
            this.dgv_PrikazDrzava.RowTemplate.Height = 24;
            this.dgv_PrikazDrzava.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PrikazDrzava.Size = new System.Drawing.Size(165, 215);
            this.dgv_PrikazDrzava.TabIndex = 0;
            this.dgv_PrikazDrzava.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_PrikazDrzava_MouseDoubleClick);
            // 
            // DrzavaId
            // 
            this.DrzavaId.DataPropertyName = "DrzavaId";
            this.DrzavaId.HeaderText = "DrzavaId";
            this.DrzavaId.MinimumWidth = 6;
            this.DrzavaId.Name = "DrzavaId";
            this.DrzavaId.ReadOnly = true;
            this.DrzavaId.Visible = false;
            this.DrzavaId.Width = 125;
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
            // frmPrikazDrzava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 254);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPrikazDrzava";
            this.Text = "frmPrikazDrzava";
            this.Load += new System.EventHandler(this.frmPrikazDrzava_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PrikazDrzava)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_PrikazDrzava;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrzavaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
    }
}