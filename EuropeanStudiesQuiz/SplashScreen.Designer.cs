namespace EuropeanStudiesQuiz
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.lblEuropeanStudies = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.proBarSplashScreen = new System.Windows.Forms.ProgressBar();
            this.lblLoading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEuropeanStudies
            // 
            this.lblEuropeanStudies.AutoSize = true;
            this.lblEuropeanStudies.BackColor = System.Drawing.Color.Transparent;
            this.lblEuropeanStudies.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuropeanStudies.Location = new System.Drawing.Point(301, 279);
            this.lblEuropeanStudies.Name = "lblEuropeanStudies";
            this.lblEuropeanStudies.Size = new System.Drawing.Size(407, 55);
            this.lblEuropeanStudies.TabIndex = 0;
            this.lblEuropeanStudies.Text = "European Studies";
            this.lblEuropeanStudies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // proBarSplashScreen
            // 
            this.proBarSplashScreen.BackColor = System.Drawing.Color.White;
            this.proBarSplashScreen.ForeColor = System.Drawing.Color.PaleGreen;
            this.proBarSplashScreen.Location = new System.Drawing.Point(311, 351);
            this.proBarSplashScreen.MarqueeAnimationSpeed = 1000;
            this.proBarSplashScreen.Name = "proBarSplashScreen";
            this.proBarSplashScreen.Size = new System.Drawing.Size(380, 25);
            this.proBarSplashScreen.Step = 5;
            this.proBarSplashScreen.TabIndex = 1;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.White;
            this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLoading.Location = new System.Drawing.Point(601, 381);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(51, 20);
            this.lblLoading.TabIndex = 2;
            this.lblLoading.Text = "label1";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(992, 723);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.proBarSplashScreen);
            this.Controls.Add(this.lblEuropeanStudies);
            this.DoubleBuffered = true;
            this.Name = "SplashScreen";
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEuropeanStudies;
        private System.Windows.Forms.Timer timer;
        public System.Windows.Forms.ProgressBar proBarSplashScreen;
        private System.Windows.Forms.Label lblLoading;
    }
}

