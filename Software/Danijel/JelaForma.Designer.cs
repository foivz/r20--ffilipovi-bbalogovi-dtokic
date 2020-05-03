namespace Vedrana.Danijel
{
    partial class JelaForma
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
            this.popisJela = new System.Windows.Forms.DataGridView();
            this.NovoJelo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.popisJela)).BeginInit();
            this.SuspendLayout();
            // 
            // popisJela
            // 
            this.popisJela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popisJela.Location = new System.Drawing.Point(168, 12);
            this.popisJela.Name = "popisJela";
            this.popisJela.RowHeadersWidth = 51;
            this.popisJela.RowTemplate.Height = 24;
            this.popisJela.Size = new System.Drawing.Size(387, 411);
            this.popisJela.TabIndex = 0;
            // 
            // NovoJelo
            // 
            this.NovoJelo.Location = new System.Drawing.Point(12, 12);
            this.NovoJelo.Name = "NovoJelo";
            this.NovoJelo.Size = new System.Drawing.Size(118, 53);
            this.NovoJelo.TabIndex = 1;
            this.NovoJelo.Text = "Novo Jelo";
            this.NovoJelo.UseVisualStyleBackColor = true;
            this.NovoJelo.Click += new System.EventHandler(this.NovoJelo_Click);
            // 
            // JelaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.NovoJelo);
            this.Controls.Add(this.popisJela);
            this.Name = "JelaForma";
            this.Text = "JelaForma";
            this.Load += new System.EventHandler(this.JelaForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popisJela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView popisJela;
        private System.Windows.Forms.Button NovoJelo;
    }
}