namespace EuropeanStudiesQuiz
{
    partial class HelpScreen
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
            this.btnHelpBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHelpBack
            // 
            this.btnHelpBack.BackColor = System.Drawing.Color.Transparent;
            this.btnHelpBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpBack.Location = new System.Drawing.Point(825, 655);
            this.btnHelpBack.Name = "btnHelpBack";
            this.btnHelpBack.Size = new System.Drawing.Size(135, 55);
            this.btnHelpBack.TabIndex = 0;
            this.btnHelpBack.Text = "Back";
            this.btnHelpBack.UseVisualStyleBackColor = false;
            this.btnHelpBack.Click += new System.EventHandler(this.btnHelpBack_Click);
            // 
            // HelpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EuropeanStudiesQuiz.Properties.Resources.HelpScreenBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(992, 723);
            this.Controls.Add(this.btnHelpBack);
            this.Name = "HelpScreen";
            this.Text = "HelpScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHelpBack;
    }
}