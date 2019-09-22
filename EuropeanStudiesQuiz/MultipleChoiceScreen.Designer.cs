namespace EuropeanStudiesQuiz
{
    partial class MultipleChoiceScreen
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.groupBoxPlayer = new System.Windows.Forms.GroupBox();
            this.lblDisplayTime = new System.Windows.Forms.Label();
            this.lblDisplayScore = new System.Windows.Forms.Label();
            this.lblDisplayUsername = new System.Windows.Forms.Label();
            this.picBoxAvatar = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBoxPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(195, 55);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(70, 25);
            this.lblQuestion.TabIndex = 4;
            this.lblQuestion.Text = "label1";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.BackColor = System.Drawing.Color.Transparent;
            this.btnAnswer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnswer1.Location = new System.Drawing.Point(199, 206);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(300, 120);
            this.btnAnswer1.TabIndex = 5;
            this.btnAnswer1.Text = "button1";
            this.btnAnswer1.UseVisualStyleBackColor = false;
            this.btnAnswer1.Click += new System.EventHandler(this.btnanswer_Click);
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.BackColor = System.Drawing.Color.Transparent;
            this.btnAnswer2.Location = new System.Drawing.Point(541, 206);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(300, 120);
            this.btnAnswer2.TabIndex = 6;
            this.btnAnswer2.Text = "button2";
            this.btnAnswer2.UseVisualStyleBackColor = false;
            this.btnAnswer2.Click += new System.EventHandler(this.btnanswer_Click);
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.BackColor = System.Drawing.Color.Transparent;
            this.btnAnswer3.Location = new System.Drawing.Point(199, 376);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(300, 120);
            this.btnAnswer3.TabIndex = 7;
            this.btnAnswer3.Text = "button3";
            this.btnAnswer3.UseVisualStyleBackColor = false;
            this.btnAnswer3.Click += new System.EventHandler(this.btnanswer_Click);
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.BackColor = System.Drawing.Color.Transparent;
            this.btnAnswer4.Location = new System.Drawing.Point(541, 376);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(300, 120);
            this.btnAnswer4.TabIndex = 8;
            this.btnAnswer4.Text = "button4";
            this.btnAnswer4.UseVisualStyleBackColor = false;
            this.btnAnswer4.Click += new System.EventHandler(this.btnanswer_Click);
            // 
            // groupBoxPlayer
            // 
            this.groupBoxPlayer.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPlayer.Controls.Add(this.lblDisplayTime);
            this.groupBoxPlayer.Controls.Add(this.lblDisplayScore);
            this.groupBoxPlayer.Controls.Add(this.lblDisplayUsername);
            this.groupBoxPlayer.Controls.Add(this.picBoxAvatar);
            this.groupBoxPlayer.Location = new System.Drawing.Point(13, 13);
            this.groupBoxPlayer.Name = "groupBoxPlayer";
            this.groupBoxPlayer.Size = new System.Drawing.Size(167, 698);
            this.groupBoxPlayer.TabIndex = 9;
            this.groupBoxPlayer.TabStop = false;
            this.groupBoxPlayer.Text = "Player Details";
            // 
            // lblDisplayTime
            // 
            this.lblDisplayTime.AutoSize = true;
            this.lblDisplayTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayTime.Location = new System.Drawing.Point(20, 300);
            this.lblDisplayTime.Name = "lblDisplayTime";
            this.lblDisplayTime.Size = new System.Drawing.Size(51, 20);
            this.lblDisplayTime.TabIndex = 7;
            this.lblDisplayTime.Text = "label1";
            this.lblDisplayTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDisplayScore
            // 
            this.lblDisplayScore.AutoSize = true;
            this.lblDisplayScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayScore.Location = new System.Drawing.Point(20, 255);
            this.lblDisplayScore.Name = "lblDisplayScore";
            this.lblDisplayScore.Size = new System.Drawing.Size(51, 20);
            this.lblDisplayScore.TabIndex = 6;
            this.lblDisplayScore.Text = "label1";
            this.lblDisplayScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDisplayUsername
            // 
            this.lblDisplayUsername.AutoSize = true;
            this.lblDisplayUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayUsername.Location = new System.Drawing.Point(20, 210);
            this.lblDisplayUsername.Name = "lblDisplayUsername";
            this.lblDisplayUsername.Size = new System.Drawing.Size(51, 20);
            this.lblDisplayUsername.TabIndex = 5;
            this.lblDisplayUsername.Text = "label1";
            this.lblDisplayUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBoxAvatar
            // 
            this.picBoxAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxAvatar.Location = new System.Drawing.Point(20, 40);
            this.picBoxAvatar.Name = "picBoxAvatar";
            this.picBoxAvatar.Size = new System.Drawing.Size(100, 135);
            this.picBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAvatar.TabIndex = 4;
            this.picBoxAvatar.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MultipleChoiceScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(992, 723);
            this.Controls.Add(this.groupBoxPlayer);
            this.Controls.Add(this.btnAnswer4);
            this.Controls.Add(this.btnAnswer3);
            this.Controls.Add(this.btnAnswer2);
            this.Controls.Add(this.btnAnswer1);
            this.Controls.Add(this.lblQuestion);
            this.Name = "MultipleChoiceScreen";
            this.Text = "MultipleChoiceScreen";
            this.Load += new System.EventHandler(this.MultipleChoiceScreen_Load);
            this.groupBoxPlayer.ResumeLayout(false);
            this.groupBoxPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnAnswer1;
        private System.Windows.Forms.Button btnAnswer2;
        private System.Windows.Forms.Button btnAnswer3;
        private System.Windows.Forms.Button btnAnswer4;
        private System.Windows.Forms.GroupBox groupBoxPlayer;
        private System.Windows.Forms.Label lblDisplayTime;
        private System.Windows.Forms.Label lblDisplayScore;
        private System.Windows.Forms.Label lblDisplayUsername;
        private System.Windows.Forms.PictureBox picBoxAvatar;
        private System.Windows.Forms.Timer timer;
    }
}