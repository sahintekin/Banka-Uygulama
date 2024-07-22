namespace BankaTest
{
    partial class AnaSayfa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.lblHesap = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.mHesap = new System.Windows.Forms.MaskedTextBox();
            this.texTutar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hesap No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(159, 117);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(42, 20);
            this.lblTel.TabIndex = 7;
            this.lblTel.Text = "Null";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(159, 80);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(42, 20);
            this.lblTc.TabIndex = 6;
            this.lblTc.Text = "Null";
            // 
            // lblHesap
            // 
            this.lblHesap.AutoSize = true;
            this.lblHesap.Location = new System.Drawing.Point(160, 44);
            this.lblHesap.Name = "lblHesap";
            this.lblHesap.Size = new System.Drawing.Size(42, 20);
            this.lblHesap.TabIndex = 5;
            this.lblHesap.Text = "Null";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(159, 9);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(42, 20);
            this.lblAd.TabIndex = 4;
            this.lblAd.Text = "Null";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGonder);
            this.groupBox1.Controls.Add(this.mHesap);
            this.groupBox1.Controls.Add(this.texTutar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(21, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 200);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Havale";
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(125, 129);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(134, 33);
            this.btnGonder.TabIndex = 15;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // mHesap
            // 
            this.mHesap.Location = new System.Drawing.Point(125, 26);
            this.mHesap.Mask = "000000";
            this.mHesap.Name = "mHesap";
            this.mHesap.Size = new System.Drawing.Size(148, 27);
            this.mHesap.TabIndex = 13;
            // 
            // texTutar
            // 
            this.texTutar.Location = new System.Drawing.Point(125, 84);
            this.texTutar.Name = "texTutar";
            this.texTutar.Size = new System.Drawing.Size(148, 27);
            this.texTutar.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tutar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hesap No:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(290, 164);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(135, 29);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Hareketler";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Location = new System.Drawing.Point(160, 155);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(42, 20);
            this.lblBakiye.TabIndex = 11;
            this.lblBakiye.Text = "Null";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Bakiye";
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(502, 464);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblTc);
            this.Controls.Add(this.lblHesap);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaSayfa";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label lblHesap;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.MaskedTextBox mHesap;
        private System.Windows.Forms.TextBox texTutar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label label8;
    }
}