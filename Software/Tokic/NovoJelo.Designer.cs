namespace Vedrana.Tokic
{
    partial class NovoJelo
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTip = new System.Windows.Forms.ComboBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.dgvSastojci = new System.Windows.Forms.DataGridView();
            this.cbxSastojak = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDodajSastojak = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSastojci)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 10.8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(36, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Roboto", 7.8F);
            this.txtNaziv.Location = new System.Drawing.Point(109, 86);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(171, 20);
            this.txtNaziv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10.8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(36, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tip:";
            // 
            // cbxTip
            // 
            this.cbxTip.Font = new System.Drawing.Font("Roboto", 7.8F);
            this.cbxTip.FormattingEnabled = true;
            this.cbxTip.Location = new System.Drawing.Point(109, 130);
            this.cbxTip.Name = "cbxTip";
            this.cbxTip.Size = new System.Drawing.Size(171, 21);
            this.cbxTip.TabIndex = 3;
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.btnOdustani.FlatAppearance.BorderSize = 0;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Font = new System.Drawing.Font("Roboto", 9F);
            this.btnOdustani.Location = new System.Drawing.Point(41, 299);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(239, 40);
            this.btnOdustani.TabIndex = 4;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnUnesi
            // 
            this.btnUnesi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(219)))), ((int)(((byte)(155)))));
            this.btnUnesi.FlatAppearance.BorderSize = 0;
            this.btnUnesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnesi.Font = new System.Drawing.Font("Roboto", 9F);
            this.btnUnesi.Location = new System.Drawing.Point(41, 253);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(239, 40);
            this.btnUnesi.TabIndex = 5;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = false;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // dgvSastojci
            // 
            this.dgvSastojci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSastojci.Location = new System.Drawing.Point(333, 170);
            this.dgvSastojci.Name = "dgvSastojci";
            this.dgvSastojci.RowHeadersWidth = 51;
            this.dgvSastojci.RowTemplate.Height = 24;
            this.dgvSastojci.Size = new System.Drawing.Size(703, 169);
            this.dgvSastojci.TabIndex = 6;
            // 
            // cbxSastojak
            // 
            this.cbxSastojak.Font = new System.Drawing.Font("Roboto", 7.8F);
            this.cbxSastojak.FormattingEnabled = true;
            this.cbxSastojak.Location = new System.Drawing.Point(429, 85);
            this.cbxSastojak.Name = "cbxSastojak";
            this.cbxSastojak.Size = new System.Drawing.Size(142, 21);
            this.cbxSastojak.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 10.8F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label3.Location = new System.Drawing.Point(328, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sastojak:";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Font = new System.Drawing.Font("Roboto", 7.8F);
            this.txtKolicina.Location = new System.Drawing.Point(429, 131);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(142, 20);
            this.txtKolicina.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 10.8F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label4.Location = new System.Drawing.Point(328, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Količina:";
            // 
            // btnDodajSastojak
            // 
            this.btnDodajSastojak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(219)))), ((int)(((byte)(155)))));
            this.btnDodajSastojak.FlatAppearance.BorderSize = 0;
            this.btnDodajSastojak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajSastojak.Font = new System.Drawing.Font("Roboto", 9F);
            this.btnDodajSastojak.Location = new System.Drawing.Point(594, 111);
            this.btnDodajSastojak.Name = "btnDodajSastojak";
            this.btnDodajSastojak.Size = new System.Drawing.Size(238, 40);
            this.btnDodajSastojak.TabIndex = 11;
            this.btnDodajSastojak.Text = "Dodaj sastojak";
            this.btnDodajSastojak.UseVisualStyleBackColor = false;
            this.btnDodajSastojak.Click += new System.EventHandler(this.btnDodajSastojak_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 11.8F);
            this.label5.Location = new System.Drawing.Point(16, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dodavanje novog jela";
            // 
            // NovoJelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 374);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDodajSastojak);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxSastojak);
            this.Controls.Add(this.dgvSastojci);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.cbxTip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NovoJelo";
            this.Text = "Dodaj jelo";
            this.Load += new System.EventHandler(this.NovoJelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSastojci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTip;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.DataGridView dgvSastojci;
        private System.Windows.Forms.ComboBox cbxSastojak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDodajSastojak;
        private System.Windows.Forms.Label label5;
    }
}