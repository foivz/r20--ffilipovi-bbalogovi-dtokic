namespace Vedrana
{
    partial class Login
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
            this.email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prijava = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sifra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(98, 73);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(146, 22);
            this.email.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-mail:";
            // 
            // prijava
            // 
            this.prijava.Location = new System.Drawing.Point(125, 182);
            this.prijava.Name = "prijava";
            this.prijava.Size = new System.Drawing.Size(91, 37);
            this.prijava.TabIndex = 2;
            this.prijava.Text = "Prijava";
            this.prijava.UseVisualStyleBackColor = true;
            this.prijava.Click += new System.EventHandler(this.prijava_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sifra:";
            // 
            // sifra
            // 
            this.sifra.Location = new System.Drawing.Point(98, 137);
            this.sifra.Name = "sifra";
            this.sifra.Size = new System.Drawing.Size(146, 22);
            this.sifra.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 290);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sifra);
            this.Controls.Add(this.prijava);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button prijava;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sifra;
    }
}

