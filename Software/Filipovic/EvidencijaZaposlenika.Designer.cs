namespace Vedrana.Filipovic
{
    partial class EvidencijaZaposlenika
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMakniFiltere = new System.Windows.Forms.Button();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.btnNoviZaposlenik = new System.Windows.Forms.Button();
            this.cbxFilter = new System.Windows.Forms.CheckBox();
            this.btnOtpusti = new System.Windows.Forms.Button();
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(22, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 18);
            this.label2.TabIndex = 48;
            this.label2.Text = "Prikaz svih zaposlenika, pretraga i uređivanje istih";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 47;
            this.label1.Text = "Evidencija zaposlenika";
            // 
            // btnMakniFiltere
            // 
            this.btnMakniFiltere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(219)))), ((int)(((byte)(155)))));
            this.btnMakniFiltere.FlatAppearance.BorderSize = 0;
            this.btnMakniFiltere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakniFiltere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakniFiltere.Location = new System.Drawing.Point(358, 160);
            this.btnMakniFiltere.Margin = new System.Windows.Forms.Padding(2);
            this.btnMakniFiltere.Name = "btnMakniFiltere";
            this.btnMakniFiltere.Size = new System.Drawing.Size(83, 22);
            this.btnMakniFiltere.TabIndex = 46;
            this.btnMakniFiltere.Text = "Makni filtere";
            this.btnMakniFiltere.UseVisualStyleBackColor = false;
            this.btnMakniFiltere.Click += new System.EventHandler(this.btnMakniFiltere_Click);
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(219)))), ((int)(((byte)(155)))));
            this.btnFiltriraj.FlatAppearance.BorderSize = 0;
            this.btnFiltriraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltriraj.Location = new System.Drawing.Point(271, 160);
            this.btnFiltriraj.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(83, 22);
            this.btnFiltriraj.TabIndex = 45;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = false;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label5.Location = new System.Drawing.Point(22, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 44;
            this.label5.Text = "Prezime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label4.Location = new System.Drawing.Point(22, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 18);
            this.label4.TabIndex = 43;
            this.label4.Text = "Ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label3.Location = new System.Drawing.Point(22, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 22);
            this.label3.TabIndex = 42;
            this.label3.Text = "Pretraži zaposlenika:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezime.Location = new System.Drawing.Point(98, 161);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(147, 19);
            this.txtPrezime.TabIndex = 41;
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.Location = new System.Drawing.Point(98, 132);
            this.txtIme.Margin = new System.Windows.Forms.Padding(2);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(147, 19);
            this.txtIme.TabIndex = 40;
            // 
            // btnNoviZaposlenik
            // 
            this.btnNoviZaposlenik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(219)))), ((int)(((byte)(155)))));
            this.btnNoviZaposlenik.FlatAppearance.BorderSize = 0;
            this.btnNoviZaposlenik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoviZaposlenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNoviZaposlenik.Location = new System.Drawing.Point(520, 436);
            this.btnNoviZaposlenik.Margin = new System.Windows.Forms.Padding(2);
            this.btnNoviZaposlenik.Name = "btnNoviZaposlenik";
            this.btnNoviZaposlenik.Size = new System.Drawing.Size(118, 32);
            this.btnNoviZaposlenik.TabIndex = 39;
            this.btnNoviZaposlenik.Text = "Novi zaposlenik";
            this.btnNoviZaposlenik.UseVisualStyleBackColor = false;
            this.btnNoviZaposlenik.Click += new System.EventHandler(this.btnNoviZaposlenik_Click);
            // 
            // cbxFilter
            // 
            this.cbxFilter.AutoSize = true;
            this.cbxFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cbxFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.cbxFilter.Location = new System.Drawing.Point(606, 161);
            this.cbxFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.Size = new System.Drawing.Size(183, 21);
            this.cbxFilter.TabIndex = 38;
            this.cbxFilter.Text = "Prikaži bivše zaposlenike";
            this.cbxFilter.UseVisualStyleBackColor = true;
            this.cbxFilter.CheckedChanged += new System.EventHandler(this.cbxFilter_CheckedChanged);
            // 
            // btnOtpusti
            // 
            this.btnOtpusti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(219)))), ((int)(((byte)(155)))));
            this.btnOtpusti.FlatAppearance.BorderSize = 0;
            this.btnOtpusti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtpusti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnOtpusti.Location = new System.Drawing.Point(642, 436);
            this.btnOtpusti.Margin = new System.Windows.Forms.Padding(2);
            this.btnOtpusti.Name = "btnOtpusti";
            this.btnOtpusti.Size = new System.Drawing.Size(139, 32);
            this.btnOtpusti.TabIndex = 37;
            this.btnOtpusti.Text = "Otpusti zaposlenika";
            this.btnOtpusti.UseVisualStyleBackColor = false;
            this.btnOtpusti.Click += new System.EventHandler(this.btnOtpusti_Click);
            // 
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.AllowUserToAddRows = false;
            this.dgvZaposlenici.AllowUserToDeleteRows = false;
            this.dgvZaposlenici.AllowUserToOrderColumns = true;
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.Location = new System.Drawing.Point(26, 188);
            this.dgvZaposlenici.Margin = new System.Windows.Forms.Padding(2);
            this.dgvZaposlenici.MultiSelect = false;
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.RowHeadersWidth = 51;
            this.dgvZaposlenici.RowTemplate.Height = 24;
            this.dgvZaposlenici.Size = new System.Drawing.Size(754, 232);
            this.dgvZaposlenici.TabIndex = 36;
            // 
            // EvidencijaZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMakniFiltere);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.btnNoviZaposlenik);
            this.Controls.Add(this.cbxFilter);
            this.Controls.Add(this.btnOtpusti);
            this.Controls.Add(this.dgvZaposlenici);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EvidencijaZaposlenika";
            this.Text = "Evidencija zaposlenika";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMakniFiltere;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Button btnNoviZaposlenik;
        private System.Windows.Forms.CheckBox cbxFilter;
        private System.Windows.Forms.Button btnOtpusti;
        private System.Windows.Forms.DataGridView dgvZaposlenici;
    }
}