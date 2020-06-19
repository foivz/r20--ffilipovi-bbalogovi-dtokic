namespace Vedrana.Tokic
{
    partial class EvidencijaSkladista
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnNarudzbe = new System.Windows.Forms.Button();
            this.btnNoviProizvod = new System.Windows.Forms.Button();
            this.dgvSkladiste = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladiste)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 11.8F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label6.Location = new System.Drawing.Point(22, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Evidencija skladišta";
            // 
            // btnNarudzbe
            // 
            this.btnNarudzbe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(219)))), ((int)(((byte)(155)))));
            this.btnNarudzbe.FlatAppearance.BorderSize = 0;
            this.btnNarudzbe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNarudzbe.Font = new System.Drawing.Font("Roboto", 9F);
            this.btnNarudzbe.Location = new System.Drawing.Point(678, 318);
            this.btnNarudzbe.Margin = new System.Windows.Forms.Padding(2);
            this.btnNarudzbe.Name = "btnNarudzbe";
            this.btnNarudzbe.Size = new System.Drawing.Size(102, 32);
            this.btnNarudzbe.TabIndex = 15;
            this.btnNarudzbe.Text = "Popis Narudžbi";
            this.btnNarudzbe.UseVisualStyleBackColor = false;
            this.btnNarudzbe.Click += new System.EventHandler(this.btnNarudzbe_Click);
            // 
            // btnNoviProizvod
            // 
            this.btnNoviProizvod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(219)))), ((int)(((byte)(155)))));
            this.btnNoviProizvod.FlatAppearance.BorderSize = 0;
            this.btnNoviProizvod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoviProizvod.Font = new System.Drawing.Font("Roboto", 9F);
            this.btnNoviProizvod.Location = new System.Drawing.Point(572, 318);
            this.btnNoviProizvod.Margin = new System.Windows.Forms.Padding(2);
            this.btnNoviProizvod.Name = "btnNoviProizvod";
            this.btnNoviProizvod.Size = new System.Drawing.Size(102, 32);
            this.btnNoviProizvod.TabIndex = 14;
            this.btnNoviProizvod.Text = "Novi proizvod";
            this.btnNoviProizvod.UseVisualStyleBackColor = false;
            this.btnNoviProizvod.Click += new System.EventHandler(this.btnNoviProizvod_Click);
            // 
            // dgvSkladiste
            // 
            this.dgvSkladiste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkladiste.Location = new System.Drawing.Point(26, 67);
            this.dgvSkladiste.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSkladiste.Name = "dgvSkladiste";
            this.dgvSkladiste.RowHeadersWidth = 51;
            this.dgvSkladiste.RowTemplate.Height = 24;
            this.dgvSkladiste.Size = new System.Drawing.Size(754, 235);
            this.dgvSkladiste.TabIndex = 13;
            // 
            // EvidencijaSkladista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 554);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnNarudzbe);
            this.Controls.Add(this.btnNoviProizvod);
            this.Controls.Add(this.dgvSkladiste);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EvidencijaSkladista";
            this.Text = "Evidencija skladišta";
            this.Load += new System.EventHandler(this.EvidencijaSkladista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladiste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNarudzbe;
        private System.Windows.Forms.Button btnNoviProizvod;
        private System.Windows.Forms.DataGridView dgvSkladiste;
    }
}