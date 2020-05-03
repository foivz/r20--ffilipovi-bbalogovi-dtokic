namespace Vedrana.Filip
{
    partial class AdministratorForm
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
            this.zaposlenici = new System.Windows.Forms.DataGridView();
            this.noviZaposlenik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenici)).BeginInit();
            this.SuspendLayout();
            // 
            // zaposlenici
            // 
            this.zaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zaposlenici.Location = new System.Drawing.Point(12, 12);
            this.zaposlenici.Name = "zaposlenici";
            this.zaposlenici.RowHeadersWidth = 51;
            this.zaposlenici.RowTemplate.Height = 24;
            this.zaposlenici.Size = new System.Drawing.Size(776, 283);
            this.zaposlenici.TabIndex = 0;
            // 
            // noviZaposlenik
            // 
            this.noviZaposlenik.Location = new System.Drawing.Point(656, 362);
            this.noviZaposlenik.Name = "noviZaposlenik";
            this.noviZaposlenik.Size = new System.Drawing.Size(132, 64);
            this.noviZaposlenik.TabIndex = 1;
            this.noviZaposlenik.Text = "Novi zaposlenik";
            this.noviZaposlenik.UseVisualStyleBackColor = true;
            this.noviZaposlenik.Click += new System.EventHandler(this.noviZaposlenik_Click);
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.noviZaposlenik);
            this.Controls.Add(this.zaposlenici);
            this.Name = "AdministratorForm";
            this.Text = "AdministratorForm";
            this.Load += new System.EventHandler(this.AdministratorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView zaposlenici;
        private System.Windows.Forms.Button noviZaposlenik;
    }
}