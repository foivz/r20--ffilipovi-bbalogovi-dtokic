namespace Vedrana.Balogovic
{
    partial class NovaUsluga
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
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDodajSastojak = new System.Windows.Forms.Button();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxNjega = new System.Windows.Forms.ComboBox();
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Dodavanje nove usluge";
            // 
            // btnUnesi
            // 
            this.btnUnesi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(219)))), ((int)(((byte)(155)))));
            this.btnUnesi.FlatAppearance.BorderSize = 0;
            this.btnUnesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnUnesi.Location = new System.Drawing.Point(76, 336);
            this.btnUnesi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(276, 39);
            this.btnUnesi.TabIndex = 40;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = false;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.btnOdustani.FlatAppearance.BorderSize = 0;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnOdustani.Location = new System.Drawing.Point(76, 384);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(276, 39);
            this.btnOdustani.TabIndex = 39;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // txtOpis
            // 
            this.txtOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtOpis.Location = new System.Drawing.Point(74, 201);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(276, 109);
            this.txtOpis.TabIndex = 38;
            this.txtOpis.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label3.Location = new System.Drawing.Point(70, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 37;
            this.label3.Text = "Opis:";
            // 
            // txtCijena
            // 
            this.txtCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtCijena.Location = new System.Drawing.Point(156, 120);
            this.txtCijena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(195, 22);
            this.txtCijena.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(70, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Cijena:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtNaziv.Location = new System.Drawing.Point(156, 78);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(195, 22);
            this.txtNaziv.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label6.Location = new System.Drawing.Point(70, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 24);
            this.label6.TabIndex = 33;
            this.label6.Text = "Naziv:";
            // 
            // btnDodajSastojak
            // 
            this.btnDodajSastojak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(219)))), ((int)(((byte)(155)))));
            this.btnDodajSastojak.FlatAppearance.BorderSize = 0;
            this.btnDodajSastojak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajSastojak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDodajSastojak.Location = new System.Drawing.Point(402, 166);
            this.btnDodajSastojak.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajSastojak.Name = "btnDodajSastojak";
            this.btnDodajSastojak.Size = new System.Drawing.Size(269, 39);
            this.btnDodajSastojak.TabIndex = 32;
            this.btnDodajSastojak.Text = "Dodaj proizvod";
            this.btnDodajSastojak.UseVisualStyleBackColor = false;
            this.btnDodajSastojak.Click += new System.EventHandler(this.btnDodajSastojak_Click);
            // 
            // txtKolicina
            // 
            this.txtKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtKolicina.Location = new System.Drawing.Point(510, 120);
            this.txtKolicina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(161, 22);
            this.txtKolicina.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label4.Location = new System.Drawing.Point(397, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "Kolicina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label5.Location = new System.Drawing.Point(397, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Proizvod:";
            // 
            // cbxNjega
            // 
            this.cbxNjega.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.cbxNjega.FormattingEnabled = true;
            this.cbxNjega.Location = new System.Drawing.Point(510, 77);
            this.cbxNjega.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxNjega.Name = "cbxNjega";
            this.cbxNjega.Size = new System.Drawing.Size(161, 24);
            this.cbxNjega.TabIndex = 28;
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Location = new System.Drawing.Point(402, 226);
            this.dgvProizvodi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.RowHeadersWidth = 51;
            this.dgvProizvodi.RowTemplate.Height = 24;
            this.dgvProizvodi.Size = new System.Drawing.Size(589, 197);
            this.dgvProizvodi.TabIndex = 27;
            // 
            // NovaUsluga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 571);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDodajSastojak);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxNjega);
            this.Controls.Add(this.dgvProizvodi);
            this.Name = "NovaUsluga";
            this.Text = "NovaUsluga";
            this.Load += new System.EventHandler(this.NovaUsluga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDodajSastojak;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxNjega;
        private System.Windows.Forms.DataGridView dgvProizvodi;
    }
}