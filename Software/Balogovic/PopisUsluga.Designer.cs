namespace Vedrana.Balogovic
{
    partial class PopisUsluga
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
            this.label12 = new System.Windows.Forms.Label();
            this.btnObrisiUslugu = new System.Windows.Forms.Button();
            this.btnUrediUslugu = new System.Windows.Forms.Button();
            this.btnNovaUsluga = new System.Windows.Forms.Button();
            this.dgvUsluge = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label12.Location = new System.Drawing.Point(33, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 29);
            this.label12.TabIndex = 92;
            this.label12.Text = "Popis usluga:";
            // 
            // btnObrisiUslugu
            // 
            this.btnObrisiUslugu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(219)))), ((int)(((byte)(155)))));
            this.btnObrisiUslugu.FlatAppearance.BorderSize = 0;
            this.btnObrisiUslugu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiUslugu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnObrisiUslugu.Location = new System.Drawing.Point(897, 401);
            this.btnObrisiUslugu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObrisiUslugu.Name = "btnObrisiUslugu";
            this.btnObrisiUslugu.Size = new System.Drawing.Size(143, 36);
            this.btnObrisiUslugu.TabIndex = 91;
            this.btnObrisiUslugu.Text = "Obrisi uslugu";
            this.btnObrisiUslugu.UseVisualStyleBackColor = false;
            this.btnObrisiUslugu.Click += new System.EventHandler(this.btnObrisiUslugu_Click);
            // 
            // btnUrediUslugu
            // 
            this.btnUrediUslugu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(219)))), ((int)(((byte)(155)))));
            this.btnUrediUslugu.FlatAppearance.BorderSize = 0;
            this.btnUrediUslugu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrediUslugu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnUrediUslugu.Location = new System.Drawing.Point(748, 401);
            this.btnUrediUslugu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUrediUslugu.Name = "btnUrediUslugu";
            this.btnUrediUslugu.Size = new System.Drawing.Size(143, 36);
            this.btnUrediUslugu.TabIndex = 90;
            this.btnUrediUslugu.Text = "Uredi uslugu";
            this.btnUrediUslugu.UseVisualStyleBackColor = false;
            this.btnUrediUslugu.Click += new System.EventHandler(this.btnUrediUslugu_Click);
            // 
            // btnNovaUsluga
            // 
            this.btnNovaUsluga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(219)))), ((int)(((byte)(155)))));
            this.btnNovaUsluga.FlatAppearance.BorderSize = 0;
            this.btnNovaUsluga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaUsluga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNovaUsluga.Location = new System.Drawing.Point(599, 401);
            this.btnNovaUsluga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNovaUsluga.Name = "btnNovaUsluga";
            this.btnNovaUsluga.Size = new System.Drawing.Size(143, 36);
            this.btnNovaUsluga.TabIndex = 89;
            this.btnNovaUsluga.Text = "Nova usluga";
            this.btnNovaUsluga.UseVisualStyleBackColor = false;
            this.btnNovaUsluga.Click += new System.EventHandler(this.btnNovaUsluga_Click);
            // 
            // dgvUsluge
            // 
            this.dgvUsluge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsluge.Location = new System.Drawing.Point(40, 81);
            this.dgvUsluge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUsluge.Name = "dgvUsluge";
            this.dgvUsluge.RowHeadersWidth = 51;
            this.dgvUsluge.RowTemplate.Height = 24;
            this.dgvUsluge.Size = new System.Drawing.Size(1000, 302);
            this.dgvUsluge.TabIndex = 88;
            // 
            // PopisUsluga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 682);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnObrisiUslugu);
            this.Controls.Add(this.btnUrediUslugu);
            this.Controls.Add(this.btnNovaUsluga);
            this.Controls.Add(this.dgvUsluge);
            this.Name = "PopisUsluga";
            this.Text = "PopisUsluga";
            this.Load += new System.EventHandler(this.PopisUsluga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnObrisiUslugu;
        private System.Windows.Forms.Button btnUrediUslugu;
        private System.Windows.Forms.Button btnNovaUsluga;
        private System.Windows.Forms.DataGridView dgvUsluge;
    }
}