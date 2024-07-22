namespace BankaTest
{
    partial class Giris
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mTextHesap = new System.Windows.Forms.MaskedTextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.textSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelKayit = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 90;
            // 
            // mTextHesap
            // 
            this.mTextHesap.Location = new System.Drawing.Point(158, 40);
            this.mTextHesap.Mask = "000000";
            this.mTextHesap.Name = "mTextHesap";
            this.mTextHesap.Size = new System.Drawing.Size(148, 27);
            this.mTextHesap.TabIndex = 10;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnGiris.ForeColor = System.Drawing.Color.Black;
            this.btnGiris.Location = new System.Drawing.Point(138, 205);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(136, 39);
            this.btnGiris.TabIndex = 13;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // textSifre
            // 
            this.textSifre.Location = new System.Drawing.Point(158, 98);
            this.textSifre.Name = "textSifre";
            this.textSifre.PasswordChar = '*';
            this.textSifre.Size = new System.Drawing.Size(148, 27);
            this.textSifre.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hesap NO:";
            // 
            // linkLabelKayit
            // 
            this.linkLabelKayit.AutoSize = true;
            this.linkLabelKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabelKayit.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabelKayit.Location = new System.Drawing.Point(152, 143);
            this.linkLabelKayit.Name = "linkLabelKayit";
            this.linkLabelKayit.Size = new System.Drawing.Size(122, 32);
            this.linkLabelKayit.TabIndex = 14;
            this.linkLabelKayit.TabStop = true;
            this.linkLabelKayit.Text = "Kayıt Ol";
            this.linkLabelKayit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelKayit_LinkClicked);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(360, 290);
            this.Controls.Add(this.linkLabelKayit);
            this.Controls.Add(this.mTextHesap);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.textSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
       
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MaskedTextBox mTextHesap;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox textSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelKayit;
    }
}

