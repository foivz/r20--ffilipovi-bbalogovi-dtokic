namespace Vedrana.Danijel
{
    partial class JelovniciForma
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
            this.popisJelovnika = new System.Windows.Forms.DataGridView();
            this.datum = new System.Windows.Forms.DateTimePicker();
            this.DodajJelovnik = new System.Windows.Forms.Button();
            this.dorucak = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rucak = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uzina = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vecera = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.popisJelovnika)).BeginInit();
            this.SuspendLayout();
            // 
            // popisJelovnika
            // 
            this.popisJelovnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popisJelovnika.Location = new System.Drawing.Point(243, 12);
            this.popisJelovnika.Name = "popisJelovnika";
            this.popisJelovnika.RowHeadersWidth = 51;
            this.popisJelovnika.RowTemplate.Height = 24;
            this.popisJelovnika.Size = new System.Drawing.Size(545, 426);
            this.popisJelovnika.TabIndex = 0;
            // 
            // datum
            // 
            this.datum.Location = new System.Drawing.Point(12, 324);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(200, 22);
            this.datum.TabIndex = 1;
            // 
            // DodajJelovnik
            // 
            this.DodajJelovnik.Location = new System.Drawing.Point(48, 388);
            this.DodajJelovnik.Name = "DodajJelovnik";
            this.DodajJelovnik.Size = new System.Drawing.Size(128, 50);
            this.DodajJelovnik.TabIndex = 2;
            this.DodajJelovnik.Text = "Dodaj jelovnik";
            this.DodajJelovnik.UseVisualStyleBackColor = true;
            this.DodajJelovnik.Click += new System.EventHandler(this.button1_Click);
            // 
            // dorucak
            // 
            this.dorucak.FormattingEnabled = true;
            this.dorucak.Location = new System.Drawing.Point(12, 75);
            this.dorucak.Name = "dorucak";
            this.dorucak.Size = new System.Drawing.Size(213, 24);
            this.dorucak.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Novi jelovnik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dorucak:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rucak:";
            // 
            // rucak
            // 
            this.rucak.FormattingEnabled = true;
            this.rucak.Location = new System.Drawing.Point(12, 138);
            this.rucak.Name = "rucak";
            this.rucak.Size = new System.Drawing.Size(213, 24);
            this.rucak.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Užina:";
            // 
            // uzina
            // 
            this.uzina.FormattingEnabled = true;
            this.uzina.Location = new System.Drawing.Point(12, 205);
            this.uzina.Name = "uzina";
            this.uzina.Size = new System.Drawing.Size(213, 24);
            this.uzina.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Večera:";
            // 
            // vecera
            // 
            this.vecera.FormattingEnabled = true;
            this.vecera.Location = new System.Drawing.Point(12, 270);
            this.vecera.Name = "vecera";
            this.vecera.Size = new System.Drawing.Size(213, 24);
            this.vecera.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Datum:";
            // 
            // JelovniciForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vecera);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uzina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rucak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dorucak);
            this.Controls.Add(this.DodajJelovnik);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.popisJelovnika);
            this.Name = "JelovniciForma";
            this.Text = "JelovniciForma";
            this.Load += new System.EventHandler(this.JelovniciForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popisJelovnika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView popisJelovnika;
        private System.Windows.Forms.DateTimePicker datum;
        private System.Windows.Forms.Button DodajJelovnik;
        private System.Windows.Forms.ComboBox dorucak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox rucak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox uzina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox vecera;
        private System.Windows.Forms.Label label6;
    }
}