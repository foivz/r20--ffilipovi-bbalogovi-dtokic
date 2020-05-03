namespace Vedrana.Branimir
{
    partial class ZaposlenikForma
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
            this.korisnici = new System.Windows.Forms.DataGridView();
            this.NoviKorisnik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.korisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // korisnici
            // 
            this.korisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.korisnici.Location = new System.Drawing.Point(12, 12);
            this.korisnici.Name = "korisnici";
            this.korisnici.RowHeadersWidth = 51;
            this.korisnici.RowTemplate.Height = 24;
            this.korisnici.Size = new System.Drawing.Size(776, 280);
            this.korisnici.TabIndex = 0;
            this.korisnici.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.korisnici_CellContentDoubleClick);
            // 
            // NoviKorisnik
            // 
            this.NoviKorisnik.Location = new System.Drawing.Point(669, 331);
            this.NoviKorisnik.Name = "NoviKorisnik";
            this.NoviKorisnik.Size = new System.Drawing.Size(119, 38);
            this.NoviKorisnik.TabIndex = 1;
            this.NoviKorisnik.Text = "Novi Korisnik";
            this.NoviKorisnik.UseVisualStyleBackColor = true;
            this.NoviKorisnik.Click += new System.EventHandler(this.NoviKorisnik_Click);
            // 
            // ZaposlenikForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NoviKorisnik);
            this.Controls.Add(this.korisnici);
            this.Name = "ZaposlenikForma";
            this.Text = "ZaposlenikForma";
            this.Load += new System.EventHandler(this.ZaposlenikForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.korisnici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView korisnici;
        private System.Windows.Forms.Button NoviKorisnik;
    }
}