namespace eKino.WinUI
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_PrijaviSe = new System.Windows.Forms.Button();
            this.txt_KorisnickoIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Sifra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Korisničko ime";
            // 
            // btn_PrijaviSe
            // 
            this.btn_PrijaviSe.Location = new System.Drawing.Point(129, 142);
            this.btn_PrijaviSe.Margin = new System.Windows.Forms.Padding(2);
            this.btn_PrijaviSe.Name = "btn_PrijaviSe";
            this.btn_PrijaviSe.Size = new System.Drawing.Size(86, 25);
            this.btn_PrijaviSe.TabIndex = 9;
            this.btn_PrijaviSe.Text = "Prijavi se";
            this.btn_PrijaviSe.UseVisualStyleBackColor = true;
            this.btn_PrijaviSe.Click += new System.EventHandler(this.btn_PrijaviSe_Click_1);
            // 
            // txt_KorisnickoIme
            // 
            this.txt_KorisnickoIme.Location = new System.Drawing.Point(35, 40);
            this.txt_KorisnickoIme.Margin = new System.Windows.Forms.Padding(2);
            this.txt_KorisnickoIme.Name = "txt_KorisnickoIme";
            this.txt_KorisnickoIme.Size = new System.Drawing.Size(181, 20);
            this.txt_KorisnickoIme.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Šifra";
            // 
            // txt_Sifra
            // 
            this.txt_Sifra.Location = new System.Drawing.Point(35, 99);
            this.txt_Sifra.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Sifra.Name = "txt_Sifra";
            this.txt_Sifra.PasswordChar = '*';
            this.txt_Sifra.Size = new System.Drawing.Size(181, 20);
            this.txt_Sifra.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(249, 186);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_PrijaviSe);
            this.Controls.Add(this.txt_KorisnickoIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Sifra);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_PrijaviSe;
        private System.Windows.Forms.TextBox txt_KorisnickoIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Sifra;
    }
}