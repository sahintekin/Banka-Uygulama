namespace BankaTest
{
    partial class Yukleniyor
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
            this.progBar = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progBar
            // 
            this.progBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progBar.AnimationSpeed = 500;
            this.progBar.BackColor = System.Drawing.Color.Transparent;
            this.progBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.progBar.ForeColor = System.Drawing.Color.DarkGreen;
            this.progBar.InnerColor = System.Drawing.Color.MintCream;
            this.progBar.InnerMargin = 2;
            this.progBar.InnerWidth = -1;
            this.progBar.Location = new System.Drawing.Point(53, 80);
            this.progBar.MarqueeAnimationSpeed = 2000;
            this.progBar.Maximum = 101;
            this.progBar.Name = "progBar";
            this.progBar.OuterColor = System.Drawing.Color.Azure;
            this.progBar.OuterMargin = -25;
            this.progBar.OuterWidth = 26;
            this.progBar.ProgressColor = System.Drawing.Color.Teal;
            this.progBar.ProgressWidth = 15;
            this.progBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.progBar.Size = new System.Drawing.Size(279, 237);
            this.progBar.StartAngle = 250;
            this.progBar.Step = 11;
            this.progBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progBar.SubscriptText = "";
            this.progBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progBar.SuperscriptText = "";
            this.progBar.TabIndex = 10;
            this.progBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.progBar.Value = 68;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Yukleniyor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(381, 385);
            this.Controls.Add(this.progBar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Yukleniyor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yükleniyor";
            this.Load += new System.EventHandler(this.Yukleniyor_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private CircularProgressBar.CircularProgressBar progBar;
        public System.Windows.Forms.Timer timer1;
    }
}