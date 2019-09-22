namespace EuropeanStudiesQuiz
{
    partial class TrueOrFalseScreen
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
            this.groupBoxPlayer = new System.Windows.Forms.GroupBox();
            this.lblDisplayTime = new System.Windows.Forms.Label();
            this.lblDisplayScore = new System.Windows.Forms.Label();
            this.lblDisplayUsername = new System.Windows.Forms.Label();
            this.picBoxAvatar = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBoxTrueFalse = new System.Windows.Forms.GroupBox();
            this.radioBtnFalse = new System.Windows.Forms.RadioButton();
            this.radioBtnTrue = new System.Windows.Forms.RadioButton();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.groupBoxPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAvatar)).BeginInit();
            this.groupBoxTrueFalse.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBoxPlayer.TabIndex = 10;
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
            // groupBoxTrueFalse
            // 
            this.groupBoxTrueFalse.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTrueFalse.Controls.Add(this.radioBtnFalse);
            this.groupBoxTrueFalse.Controls.Add(this.radioBtnTrue);
            this.groupBoxTrueFalse.Controls.Add(this.lblQuestion);
            this.groupBoxTrueFalse.Location = new System.Drawing.Point(198, 13);
            this.groupBoxTrueFalse.Name = "groupBoxTrueFalse";
            this.groupBoxTrueFalse.Size = new System.Drawing.Size(782, 698);
            this.groupBoxTrueFalse.TabIndex = 11;
            this.groupBoxTrueFalse.TabStop = false;
            this.groupBoxTrueFalse.Text = "True Or False?";
            // 
            // radioBtnFalse
            // 
            this.radioBtnFalse.AutoSize = true;
            this.radioBtnFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnFalse.Location = new System.Drawing.Point(301, 291);
            this.radioBtnFalse.Name = "radioBtnFalse";
            this.radioBtnFalse.Size = new System.Drawing.Size(152, 29);
            this.radioBtnFalse.TabIndex = 2;
            this.radioBtnFalse.Text = "radioButton1";
            this.radioBtnFalse.UseVisualStyleBackColor = true;
            this.radioBtnFalse.Click += new System.EventHandler(this.radioBtnFalse_Click);
            // 
            // radioBtnTrue
            // 
            this.radioBtnTrue.AutoSize = true;
            this.radioBtnTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnTrue.Location = new System.Drawing.Point(301, 246);
            this.radioBtnTrue.Name = "radioBtnTrue";
            this.radioBtnTrue.Size = new System.Drawing.Size(152, 29);
            this.radioBtnTrue.TabIndex = 1;
            this.radioBtnTrue.Text = "radioButton1";
            this.radioBtnTrue.UseVisualStyleBackColor = true;
            this.radioBtnTrue.Click += new System.EventHandler(this.radioBtnTrue_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(23, 40);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(70, 25);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "label1";
            // 
            // TrueOrFalseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(992, 723);
            this.Controls.Add(this.groupBoxTrueFalse);
            this.Controls.Add(this.groupBoxPlayer);
            this.Name = "TrueOrFalseScreen";
            this.Text = "TrueOrFalseScreen";
            this.Load += new System.EventHandler(this.TrueOrFalseScreen_Load);
            this.groupBoxPlayer.ResumeLayout(false);
            this.groupBoxPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAvatar)).EndInit();
            this.groupBoxTrueFalse.ResumeLayout(false);
            this.groupBoxTrueFalse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPlayer;
        private System.Windows.Forms.Label lblDisplayTime;
        private System.Windows.Forms.Label lblDisplayScore;
        private System.Windows.Forms.Label lblDisplayUsername;
        private System.Windows.Forms.PictureBox picBoxAvatar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox groupBoxTrueFalse;
        private System.Windows.Forms.RadioButton radioBtnFalse;
        private System.Windows.Forms.RadioButton radioBtnTrue;
        private System.Windows.Forms.Label lblQuestion;
    }
}