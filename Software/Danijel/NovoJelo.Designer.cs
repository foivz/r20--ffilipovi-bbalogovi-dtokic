namespace Vedrana.Danijel
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
            this.nazivJela = new System.Windows.Forms.TextBox();
            this.tipJela = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.popisSastojaka = new System.Windows.Forms.DataGridView();
            this.sastojakNaziv = new System.Windows.Forms.ComboBox();
            this.DodajJelo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sastojakKolicina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DodajSastojak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.popisSastojaka)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv jela:";
            // 
            // nazivJela
            // 
            this.nazivJela.Location = new System.Drawing.Point(91, 6);
            this.nazivJela.Name = "nazivJela";
            this.nazivJela.Size = new System.Drawing.Size(151, 22);
            this.nazivJela.TabIndex = 1;
            // 
            // tipJela
            // 
            this.tipJela.FormattingEnabled = true;
            this.tipJela.Location = new System.Drawing.Point(91, 47);
            this.tipJela.Name = "tipJela";
            this.tipJela.Size = new System.Drawing.Size(151, 24);
            this.tipJela.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tip jela:";
            // 
            // popisSastojaka
            // 
            this.popisSastojaka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popisSastojaka.Location = new System.Drawing.Point(12, 230);
            this.popisSastojaka.Name = "popisSastojaka";
            this.popisSastojaka.RowHeadersWidth = 51;
            this.popisSastojaka.RowTemplate.Height = 24;
            this.popisSastojaka.Size = new System.Drawing.Size(361, 218);
            this.popisSastojaka.TabIndex = 4;
            // 
            // sastojakNaziv
            // 
            this.sastojakNaziv.FormattingEnabled = true;
            this.sastojakNaziv.Location = new System.Drawing.Point(91, 108);
            this.sastojakNaziv.Name = "sastojakNaziv";
            this.sastojakNaziv.Size = new System.Drawing.Size(121, 24);
            this.sastojakNaziv.TabIndex = 5;
            // 
            // DodajJelo
            // 
            this.DodajJelo.Location = new System.Drawing.Point(298, 166);
            this.DodajJelo.Name = "DodajJelo";
            this.DodajJelo.Size = new System.Drawing.Size(75, 49);
            this.DodajJelo.TabIndex = 6;
            this.DodajJelo.Text = "Dodaj Jelo";
            this.DodajJelo.UseVisualStyleBackColor = true;
            this.DodajJelo.Click += new System.EventHandler(this.DodajJelo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sastojak:";
            // 
            // sastojakKolicina
            // 
            this.sastojakKolicina.Location = new System.Drawing.Point(91, 138);
            this.sastojakKolicina.Name = "sastojakKolicina";
            this.sastojakKolicina.Size = new System.Drawing.Size(151, 22);
            this.sastojakKolicina.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kolicina:";
            // 
            // DodajSastojak
            // 
            this.DodajSastojak.Location = new System.Drawing.Point(91, 166);
            this.DodajSastojak.Name = "DodajSastojak";
            this.DodajSastojak.Size = new System.Drawing.Size(105, 49);
            this.DodajSastojak.TabIndex = 10;
            this.DodajSastojak.Text = "Dodaj Sastojak";
            this.DodajSastojak.UseVisualStyleBackColor = true;
            this.DodajSastojak.Click += new System.EventHandler(this.DodajSastojak_Click);
            // 
            // NovoJelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 450);
            this.Controls.Add(this.DodajSastojak);
            this.Controls.Add(this.sastojakKolicina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DodajJelo);
            this.Controls.Add(this.sastojakNaziv);
            this.Controls.Add(this.popisSastojaka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tipJela);
            this.Controls.Add(this.nazivJela);
            this.Controls.Add(this.label1);
            this.Name = "NovoJelo";
            this.Text = "NovoJelo";
            this.Load += new System.EventHandler(this.NovoJelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popisSastojaka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nazivJela;
        private System.Windows.Forms.ComboBox tipJela;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView popisSastojaka;
        private System.Windows.Forms.ComboBox sastojakNaziv;
        private System.Windows.Forms.Button DodajJelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sastojakKolicina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DodajSastojak;
    }
}