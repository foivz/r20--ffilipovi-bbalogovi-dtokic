namespace Vedrana.Branimir
{
    partial class NoviKorisnik
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
            this.ime = new System.Windows.Forms.TextBox();
            this.prezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DodajKorisnika = new System.Windows.Forms.Button();
            this.usluge = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.usluge)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // ime
            // 
            this.ime.Location = new System.Drawing.Point(12, 44);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(167, 22);
            this.ime.TabIndex = 1;
            // 
            // prezime
            // 
            this.prezime.Location = new System.Drawing.Point(12, 99);
            this.prezime.Name = "prezime";
            this.prezime.Size = new System.Drawing.Size(167, 22);
            this.prezime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime:";
            // 
            // DodajKorisnika
            // 
            this.DodajKorisnika.Location = new System.Drawing.Point(12, 145);
            this.DodajKorisnika.Name = "DodajKorisnika";
            this.DodajKorisnika.Size = new System.Drawing.Size(100, 52);
            this.DodajKorisnika.TabIndex = 4;
            this.DodajKorisnika.Text = "Dodaj Korisnika";
            this.DodajKorisnika.UseVisualStyleBackColor = true;
            this.DodajKorisnika.Click += new System.EventHandler(this.DodajKorisnika_Click);
            // 
            // usluge
            // 
            this.usluge.AllowUserToAddRows = false;
            this.usluge.AllowUserToDeleteRows = false;
            this.usluge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usluge.Location = new System.Drawing.Point(224, 24);
            this.usluge.Name = "usluge";
            this.usluge.RowHeadersWidth = 51;
            this.usluge.RowTemplate.Height = 24;
            this.usluge.Size = new System.Drawing.Size(439, 278);
            this.usluge.TabIndex = 5;
            // 
            // NoviKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 318);
            this.Controls.Add(this.usluge);
            this.Controls.Add(this.DodajKorisnika);
            this.Controls.Add(this.prezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ime);
            this.Controls.Add(this.label1);
            this.Name = "NoviKorisnik";
            this.Text = "NoviKorisnik";
            this.Load += new System.EventHandler(this.NoviKorisnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usluge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ime;
        private System.Windows.Forms.TextBox prezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DodajKorisnika;
        private System.Windows.Forms.DataGridView usluge;
    }
}