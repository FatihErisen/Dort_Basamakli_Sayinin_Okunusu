namespace Odev_Fatih_Erisen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblYazi = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "4 Basamaklı Sayı:";
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(254, 51);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(125, 27);
            this.txtSayi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sayının Yazıyla İfadesi:";
            // 
            // lblYazi
            // 
            this.lblYazi.Location = new System.Drawing.Point(254, 126);
            this.lblYazi.Name = "lblYazi";
            this.lblYazi.Size = new System.Drawing.Size(338, 26);
            this.lblYazi.TabIndex = 3;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(66, 231);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(94, 29);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(285, 231);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(94, 29);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(420, 337);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblYazi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sayının Okunuşunu Yaz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtSayi;
        private Label label2;
        private Label lblYazi;
        private Button btnHesapla;
        private Button btnCikis;
    }
}