namespace Vedrana.Tokic
{
    partial class EvidencijaJela
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
            this.dgvJela = new System.Windows.Forms.DataGridView();
            this.btnNovoJelo = new System.Windows.Forms.Button();
            this.cbxTipJela = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImeJela = new System.Windows.Forms.TextBox();
            this.btnFiltrirajTip = new System.Windows.Forms.Button();
            this.btnFiltrirajIme = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJela)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJela
            // 
            this.dgvJela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJela.Location = new System.Drawing.Point(64, 161);
            this.dgvJela.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvJela.Name = "dgvJela";
            this.dgvJela.RowHeadersWidth = 51;
            this.dgvJela.RowTemplate.Height = 24;
            this.dgvJela.Size = new System.Drawing.Size(907, 268);
            this.dgvJela.TabIndex = 0;
            // 
            // btnNovoJelo
            // 
            this.btnNovoJelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(219)))), ((int)(((byte)(155)))));
            this.btnNovoJelo.FlatAppearance.BorderSize = 0;
            this.btnNovoJelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoJelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNovoJelo.Location = new System.Drawing.Point(692, 446);
            this.btnNovoJelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNovoJelo.Name = "btnNovoJelo";
            this.btnNovoJelo.Size = new System.Drawing.Size(136, 39);
            this.btnNovoJelo.TabIndex = 1;
            this.btnNovoJelo.Text = "Novo Jelo";
            this.btnNovoJelo.UseVisualStyleBackColor = false;
            this.btnNovoJelo.Click += new System.EventHandler(this.btnNovoJelo_Click);
            // 
            // cbxTipJela
            // 
            this.cbxTipJela.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.cbxTipJela.FormattingEnabled = true;
            this.cbxTipJela.Location = new System.Drawing.Point(144, 80);
            this.cbxTipJela.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxTipJela.Name = "cbxTipJela";
            this.cbxTipJela.Size = new System.Drawing.Size(135, 24);
            this.cbxTipJela.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(59, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tip jela:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(327, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ime jela:";
            // 
            // txtImeJela
            // 
            this.txtImeJela.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtImeJela.Location = new System.Drawing.Point(417, 80);
            this.txtImeJela.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImeJela.Name = "txtImeJela";
            this.txtImeJela.Size = new System.Drawing.Size(167, 22);
            this.txtImeJela.TabIndex = 5;
            // 
            // btnFiltrirajTip
            // 
            this.btnFiltrirajTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(219)))), ((int)(((byte)(155)))));
            this.btnFiltrirajTip.FlatAppearance.BorderSize = 0;
            this.btnFiltrirajTip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrirajTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFiltrirajTip.Location = new System.Drawing.Point(64, 114);
            this.btnFiltrirajTip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltrirajTip.Name = "btnFiltrirajTip";
            this.btnFiltrirajTip.Size = new System.Drawing.Size(215, 31);
            this.btnFiltrirajTip.TabIndex = 6;
            this.btnFiltrirajTip.Text = "Filtriraj po tipu";
            this.btnFiltrirajTip.UseVisualStyleBackColor = false;
            this.btnFiltrirajTip.Click += new System.EventHandler(this.btnFiltrirajTip_Click);
            // 
            // btnFiltrirajIme
            // 
            this.btnFiltrirajIme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(219)))), ((int)(((byte)(155)))));
            this.btnFiltrirajIme.FlatAppearance.BorderSize = 0;
            this.btnFiltrirajIme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrirajIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFiltrirajIme.Location = new System.Drawing.Point(332, 114);
            this.btnFiltrirajIme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltrirajIme.Name = "btnFiltrirajIme";
            this.btnFiltrirajIme.Size = new System.Drawing.Size(252, 31);
            this.btnFiltrirajIme.TabIndex = 7;
            this.btnFiltrirajIme.Text = "Filtriraj po imenu";
            this.btnFiltrirajIme.UseVisualStyleBackColor = false;
            this.btnFiltrirajIme.Click += new System.EventHandler(this.btnFiltrirajIme_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(219)))), ((int)(((byte)(155)))));
            this.btnObrisi.FlatAppearance.BorderSize = 0;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnObrisi.Location = new System.Drawing.Point(835, 446);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(136, 39);
            this.btnObrisi.TabIndex = 8;
            this.btnObrisi.Text = "Obriši Jelo";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label6.Location = new System.Drawing.Point(24, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Evidencija jela";
            // 
            // EvidencijaJela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 598);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnFiltrirajIme);
            this.Controls.Add(this.btnFiltrirajTip);
            this.Controls.Add(this.txtImeJela);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTipJela);
            this.Controls.Add(this.btnNovoJelo);
            this.Controls.Add(this.dgvJela);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EvidencijaJela";
            this.Text = "Evidencija jela";
            this.Load += new System.EventHandler(this.EvidencijaJela_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EvidencijaJela_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJela;
        private System.Windows.Forms.Button btnNovoJelo;
        private System.Windows.Forms.ComboBox cbxTipJela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImeJela;
        private System.Windows.Forms.Button btnFiltrirajTip;
        private System.Windows.Forms.Button btnFiltrirajIme;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label label6;
    }
}