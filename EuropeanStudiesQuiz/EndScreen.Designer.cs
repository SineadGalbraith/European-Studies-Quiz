namespace EuropeanStudiesQuiz
{
    partial class EndScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndScreen));
            this.groupBoxPlayer = new System.Windows.Forms.GroupBox();
            this.lblDisplayTime = new System.Windows.Forms.Label();
            this.lblDisplayScore = new System.Windows.Forms.Label();
            this.lblDisplayUsername = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.dataScoreTable = new System.Windows.Forms.DataGridView();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.picBoxAvatar = new System.Windows.Forms.PictureBox();
            this.groupBoxPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataScoreTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPlayer
            // 
            this.groupBoxPlayer.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPlayer.Controls.Add(this.lblDisplayTime);
            this.groupBoxPlayer.Controls.Add(this.lblDisplayScore);
            this.groupBoxPlayer.Controls.Add(this.lblDisplayUsername);
            this.groupBoxPlayer.Controls.Add(this.picBoxAvatar);
            this.groupBoxPlayer.Location = new System.Drawing.Point(12, 13);
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
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(233, 53);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(86, 31);
            this.lblMessage.TabIndex = 11;
            this.lblMessage.Text = "label1";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataScoreTable
            // 
            this.dataScoreTable.AllowUserToAddRows = false;
            this.dataScoreTable.AllowUserToDeleteRows = false;
            this.dataScoreTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataScoreTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataScoreTable.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataScoreTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataScoreTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataScoreTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataScoreTable.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataScoreTable.Location = new System.Drawing.Point(385, 207);
            this.dataScoreTable.Name = "dataScoreTable";
            this.dataScoreTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataScoreTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataScoreTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataScoreTable.Size = new System.Drawing.Size(184, 235);
            this.dataScoreTable.TabIndex = 12;
            this.dataScoreTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataScoreTable_CellContentClick);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Location = new System.Drawing.Point(410, 463);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(130, 40);
            this.btnPlayAgain.TabIndex = 13;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
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
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(992, 723);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.dataScoreTable);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.groupBoxPlayer);
            this.Name = "EndScreen";
            this.Text = "EndScreen";
            this.Load += new System.EventHandler(this.EndScreen_Load);
            this.groupBoxPlayer.ResumeLayout(false);
            this.groupBoxPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataScoreTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPlayer;
        private System.Windows.Forms.Label lblDisplayTime;
        private System.Windows.Forms.Label lblDisplayScore;
        private System.Windows.Forms.Label lblDisplayUsername;
        private System.Windows.Forms.PictureBox picBoxAvatar;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.DataGridView dataScoreTable;
        private System.Windows.Forms.Button btnPlayAgain;
    }
}