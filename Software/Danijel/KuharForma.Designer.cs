namespace Vedrana.Danijel
{
    partial class KuharForma
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
            this.danasnjiJelovnik = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Jela = new System.Windows.Forms.Button();
            this.Jelovnici = new System.Windows.Forms.Button();
            this.Skladiste = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.danasnjiJelovnik)).BeginInit();
            this.SuspendLayout();
            // 
            // danasnjiJelovnik
            // 
            this.danasnjiJelovnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danasnjiJelovnik.Location = new System.Drawing.Point(183, 47);
            this.danasnjiJelovnik.Name = "danasnjiJelovnik";
            this.danasnjiJelovnik.RowHeadersWidth = 51;
            this.danasnjiJelovnik.RowTemplate.Height = 24;
            this.danasnjiJelovnik.Size = new System.Drawing.Size(261, 366);
            this.danasnjiJelovnik.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Današnji jelovnik:";
            // 
            // Jela
            // 
            this.Jela.Location = new System.Drawing.Point(25, 47);
            this.Jela.Name = "Jela";
            this.Jela.Size = new System.Drawing.Size(101, 41);
            this.Jela.TabIndex = 2;
            this.Jela.Text = "Jela";
            this.Jela.UseVisualStyleBackColor = true;
            this.Jela.Click += new System.EventHandler(this.Jela_Click);
            // 
            // Jelovnici
            // 
            this.Jelovnici.Location = new System.Drawing.Point(25, 123);
            this.Jelovnici.Name = "Jelovnici";
            this.Jelovnici.Size = new System.Drawing.Size(101, 41);
            this.Jelovnici.TabIndex = 3;
            this.Jelovnici.Text = "Jelovnici";
            this.Jelovnici.UseVisualStyleBackColor = true;
            this.Jelovnici.Click += new System.EventHandler(this.Jelovnici_Click);
            // 
            // Skladiste
            // 
            this.Skladiste.Location = new System.Drawing.Point(25, 198);
            this.Skladiste.Name = "Skladiste";
            this.Skladiste.Size = new System.Drawing.Size(101, 41);
            this.Skladiste.TabIndex = 4;
            this.Skladiste.Text = "Skladište";
            this.Skladiste.UseVisualStyleBackColor = true;
            this.Skladiste.Click += new System.EventHandler(this.Skladiste_Click);
            // 
            // KuharForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.Skladiste);
            this.Controls.Add(this.Jelovnici);
            this.Controls.Add(this.Jela);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.danasnjiJelovnik);
            this.Name = "KuharForma";
            this.Text = "KuharForma";
            this.Load += new System.EventHandler(this.KuharForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.danasnjiJelovnik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView danasnjiJelovnik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Jela;
        private System.Windows.Forms.Button Jelovnici;
        private System.Windows.Forms.Button Skladiste;
    }
}