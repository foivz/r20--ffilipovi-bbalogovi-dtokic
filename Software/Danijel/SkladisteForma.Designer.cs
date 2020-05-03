namespace Vedrana.Danijel
{
    partial class SkladisteForma
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
            this.podaciSkladista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.podaciSkladista)).BeginInit();
            this.SuspendLayout();
            // 
            // podaciSkladista
            // 
            this.podaciSkladista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.podaciSkladista.Location = new System.Drawing.Point(12, 12);
            this.podaciSkladista.Name = "podaciSkladista";
            this.podaciSkladista.RowHeadersWidth = 51;
            this.podaciSkladista.RowTemplate.Height = 24;
            this.podaciSkladista.Size = new System.Drawing.Size(776, 426);
            this.podaciSkladista.TabIndex = 0;
            // 
            // SkladisteForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.podaciSkladista);
            this.Name = "SkladisteForma";
            this.Text = "SkladisteForma";
            this.Load += new System.EventHandler(this.SkladisteForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.podaciSkladista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView podaciSkladista;
    }
}