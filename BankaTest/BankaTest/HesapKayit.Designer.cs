namespace BankaTest
{
    partial class HesapKayit
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mHesap = new System.Windows.Forms.MaskedTextBox();
            this.textSifre = new System.Windows.Forms.TextBox();
            this.textAd = new System.Windows.Forms.TextBox();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.mtextTc = new System.Windows.Forms.MaskedTextBox();
            this.mtextTel = new System.Windows.Forms.MaskedTextBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(49, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(87, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "TC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hesap No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(90, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(52, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = " Soyad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(72, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Şifre:";
            // 
            // mHesap
            // 
            this.mHesap.Enabled = false;
            this.mHesap.Location = new System.Drawing.Point(148, 214);
            this.mHesap.Mask = "000000";
            this.mHesap.Name = "mHesap";
            this.mHesap.Size = new System.Drawing.Size(148, 27);
            this.mHesap.TabIndex = 5;
            // 
            // textSifre
            // 
            this.textSifre.Location = new System.Drawing.Point(148, 263);
            this.textSifre.Name = "textSifre";
            this.textSifre.Size = new System.Drawing.Size(148, 27);
            this.textSifre.TabIndex = 6;
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(148, 28);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(148, 27);
            this.textAd.TabIndex = 1;
            // 
            // textSoyad
            // 
            this.textSoyad.Location = new System.Drawing.Point(148, 72);
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(148, 27);
            this.textSoyad.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(148, 319);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(148, 33);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // mtextTc
            // 
            this.mtextTc.Location = new System.Drawing.Point(148, 121);
            this.mtextTc.Mask = "00000000000";
            this.mtextTc.Name = "mtextTc";
            this.mtextTc.Size = new System.Drawing.Size(148, 27);
            this.mtextTc.TabIndex = 10;
            // 
            // mtextTel
            // 
            this.mtextTel.Location = new System.Drawing.Point(148, 163);
            this.mtextTel.Mask = "(999) 000-0000";
            this.mtextTel.Name = "mtextTel";
            this.mtextTel.Size = new System.Drawing.Size(148, 27);
            this.mtextTel.TabIndex = 11;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(315, 214);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(39, 27);
            this.btnRandom.TabIndex = 12;
            this.btnRandom.Text = "...";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // HesapKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(433, 411);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.mtextTel);
            this.Controls.Add(this.mtextTc);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.textAd);
            this.Controls.Add(this.textSoyad);
            this.Controls.Add(this.mHesap);
            this.Controls.Add(this.textSifre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HesapKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HesapKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mHesap;
        private System.Windows.Forms.TextBox textSifre;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.TextBox textSoyad;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.MaskedTextBox mtextTc;
        private System.Windows.Forms.MaskedTextBox mtextTel;
        private System.Windows.Forms.Button btnRandom;
    }
}