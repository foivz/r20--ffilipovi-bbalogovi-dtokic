namespace Vedrana.Branimir
{
    partial class DetaljiKorisnika
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
            this.usluge = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usluge)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // ime
            // 
            this.ime.Enabled = false;
            this.ime.Location = new System.Drawing.Point(61, 5);
            this.ime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(142, 20);
            this.ime.TabIndex = 1;
            // 
            // prezime
            // 
            this.prezime.Enabled = false;
            this.prezime.Location = new System.Drawing.Point(61, 28);
            this.prezime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prezime.Name = "prezime";
            this.prezime.Size = new System.Drawing.Size(142, 20);
            this.prezime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime:";
            // 
            // usluge
            // 
            this.usluge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usluge.Location = new System.Drawing.Point(9, 50);
            this.usluge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usluge.Name = "usluge";
            this.usluge.RowHeadersWidth = 51;
            this.usluge.RowTemplate.Height = 24;
            this.usluge.Size = new System.Drawing.Size(568, 271);
            this.usluge.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Evidentiraj uslugu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(466, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Generiraj obrasce";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DetaljiKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usluge);
            this.Controls.Add(this.prezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ime);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DetaljiKorisnika";
            this.Text = "DetaljiKorisnika";
            this.Load += new System.EventHandler(this.DetaljiKorisnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usluge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ime;
        private System.Windows.Forms.TextBox prezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView usluge;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}