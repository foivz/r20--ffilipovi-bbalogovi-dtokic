namespace Vedrana.Filip
{
    partial class NoviZaposlenik
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
            this.email = new System.Windows.Forms.TextBox();
            this.ime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uloge = new System.Windows.Forms.ComboBox();
            this.dodajZaposlenika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-mail:";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(72, 46);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(166, 22);
            this.email.TabIndex = 1;
            // 
            // ime
            // 
            this.ime.Location = new System.Drawing.Point(72, 99);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(166, 22);
            this.ime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime:";
            // 
            // prezime
            // 
            this.prezime.Location = new System.Drawing.Point(72, 152);
            this.prezime.Name = "prezime";
            this.prezime.Size = new System.Drawing.Size(166, 22);
            this.prezime.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prezime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Uloga:";
            // 
            // uloge
            // 
            this.uloge.FormattingEnabled = true;
            this.uloge.Location = new System.Drawing.Point(72, 202);
            this.uloge.Name = "uloge";
            this.uloge.Size = new System.Drawing.Size(166, 24);
            this.uloge.TabIndex = 7;
            // 
            // dodajZaposlenika
            // 
            this.dodajZaposlenika.Location = new System.Drawing.Point(89, 254);
            this.dodajZaposlenika.Name = "dodajZaposlenika";
            this.dodajZaposlenika.Size = new System.Drawing.Size(118, 62);
            this.dodajZaposlenika.TabIndex = 8;
            this.dodajZaposlenika.Text = "Dodaj zaposlenika";
            this.dodajZaposlenika.UseVisualStyleBackColor = true;
            this.dodajZaposlenika.Click += new System.EventHandler(this.dodajZaposlenika_Click);
            // 
            // NoviZaposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 362);
            this.Controls.Add(this.dodajZaposlenika);
            this.Controls.Add(this.uloge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prezime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label1);
            this.Name = "NoviZaposlenik";
            this.Text = "NoviZaposlenik";
            this.Load += new System.EventHandler(this.NoviZaposlenik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox ime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox uloge;
        private System.Windows.Forms.Button dodajZaposlenika;
    }
}