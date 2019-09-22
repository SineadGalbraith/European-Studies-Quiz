using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EuropeanStudiesQuiz
{
    public partial class DragDropText : Form
    {
        public DragDropText()
        {
            InitializeComponent();
            // Center the form to the middle of the screen.
            CenterToScreen();
            // Call the HideAvatars() method.
            HideAvatars();
            // Call the AllowDropPictures() method.
            AllowDropText();
        }

        private void AllowDropText()
        {
            // Allow all of the answer labels that are going to receive the answers to allow a drop.
            lblAnswer1.AllowDrop = true;
            lblAnswer2.AllowDrop = true;
            lblAnswer3.AllowDrop = true;
            lblAnswer4.AllowDrop = true;
            lblAnswer5.AllowDrop = true;
        }

        private void HideAvatars()
        {

        }

        private void DragDropText_Load(object sender, EventArgs e)
        {
            // Display the Avatar image that was selected in the Login Screen from the Player Class.
            picBoxAvatar.Image = LoginScreen.Player.avatarImage;
            // Display the Username of the user that was entered in the LoginScreen from the Player Class.
            lbldisplayusername.Text = LoginScreen.Player._name;
            // Dislay the User's Score from the previous screen.
            lbldisplayscore.Text = ("Score: " + LoginScreen.Player._score.ToString());
            // Display the Time from the previous screen.
            lbldisplaytime.Text = ("Time: " + LoginScreen.Player._time);

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Display the current, incrementing time.
            lbldisplaytime.Text = ("Time: " + LoginScreen.Player._time);
        }

        private void lbl_DragEnter(object sender, DragEventArgs e)
        {
            // Copy the text that is dragged into the label.
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            // Otherwise, do not copy.
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblDavidCameron_MouseDown(object sender, MouseEventArgs e)
        {
            // Copy the text in lblDavidCameron.
            if (e.Button == MouseButtons.Left)
            {
                lblDavidCameron.DoDragDrop("David Cameron", DragDropEffects.Copy);
            }
        }

        private void lblAnswer4_DragDrop(object sender, DragEventArgs e)
        {
            lblAnswer4.Text = (string)e.Data.GetData(DataFormats.Text);

            // If the text in lblAnswer4 is the same as the text in lblavidCameron...
            if (lblAnswer4.Text == "David Cameron")
            {
                // Make the text in lblDavidCameron invisible.
                lblDavidCameron.Visible = false;
                // Allow a drop for lblAnswer4.
                lblAnswer4.AllowDrop = true;
                // Call the RightAnswer() method.
                RightAnswer();
            }
            // Otherwise...
            else
            {
                // Make the text in lblDavidCameron remain visible.
                lblDavidCameron.Visible = true;
                // Remove any text from lblAnswer4.
                lblAnswer4.Text = "                          ";
                // Call the WrongAnswer() method.
                WrongAnswer();
            }

        }

        private void lblAngelaMerkel_MouseDown(object sender, MouseEventArgs e)
        {
            // Copy the text in lblAngelaMerkel.
            if (e.Button == MouseButtons.Left)
            {
                lblAngelaMerkel.DoDragDrop("Angela Merkel", DragDropEffects.Copy);
            }
        }

        private void lblAnswer1_DragDrop(object sender, DragEventArgs e)
        {
            lblAnswer1.Text = (string)e.Data.GetData(DataFormats.Text);

            // If the text in lblAnswer1 is the same as the text in lblAngelaMerkel...
            if (lblAnswer1.Text == "Angela Merkel")
            {
                // Make the text in lblAngelaMerkel invisible.
                lblAngelaMerkel.Visible = false;
                // Allow a drop for lblAnswer1.
                lblAnswer1.AllowDrop = true;
                // Call the RightAnswer() method.
                RightAnswer();
            }
            // Otherwise...
            else
            {
                // Make the text in lblAngelaMerkel remain visible.
                lblAngelaMerkel.Visible = true;
                // Remove any text from lblAnswer1.
                lblAnswer1.Text = "                          ";
                // Call the WrongAnswer() method.
                WrongAnswer();
            }
        }

        private void lblEndaKenny_MouseDown(object sender, MouseEventArgs e)
        {
            // Copy the text in lblEndaKenny.
            if (e.Button == MouseButtons.Left)
            {
                lblEndaKenny.DoDragDrop("Enda Kenny", DragDropEffects.Copy);
            }
        }

        private void lblAnswer2_DragDrop(object sender, DragEventArgs e)
        {
            lblAnswer2.Text = (string)e.Data.GetData(DataFormats.Text);

            // If the text in lblAnswer2 is the same as the text in lblEndaKenny...
            if (lblAnswer2.Text == "Enda Kenny")
            {
                // Make the text in lblEndaKenny invisible.
                lblEndaKenny.Visible = false;
                // Allow a drop for lblAnswer2.
                lblAnswer2.AllowDrop = true;
                // Call the RightAnswer() method.
                RightAnswer();
            }
            // Otherwise...
            else
            {
                // Make the text in lblEndaKenny remain visible.
                lblEndaKenny.Visible = true;
                // Remove any text from lblAnswer2.
                lblAnswer2.Text = "                          ";
                // Call the WrongAnswer() method.
                WrongAnswer();
            }
        }

        private void lblManuelValls_MouseDown(object sender, MouseEventArgs e)
        {
            // Copy the text in lblManuelValls.
            if (e.Button == MouseButtons.Left)
            {
                lblManuelValls.DoDragDrop("Manuel Valls", DragDropEffects.Copy);
            }
        }

        private void lblAnswer5_DragDrop(object sender, DragEventArgs e)
        {
            // If the text in lblAnswer5 is the same as the text in lblManuelValls...
            lblAnswer5.Text = (string)e.Data.GetData(DataFormats.Text);

            if (lblAnswer5.Text == "Manuel Valls")
            {
                // Make the text in lblManuelValls invisible.
                lblManuelValls.Visible = false;
                // Allow a drop for lblAnswer5.
                lblAnswer5.AllowDrop = true;
                // Call the RightAnswer() method.
                RightAnswer();
            }
            // Otherwise...
            else
            {
                // Make the text in lblManuelValls remain visible.
                lblManuelValls.Visible = true;
                // Remove any text from lblAnswer5.
                lblAnswer5.Text = "                          ";
                // Call the WrongAnswer() method.
                WrongAnswer();
            }

        }

        private void lblMatteoRenzi_MouseDown(object sender, MouseEventArgs e)
        {
            // Copy the text in lblMatteoRenzi.
            if (e.Button == MouseButtons.Left)
            {
                lblMatteoRenzi.DoDragDrop("Matteo Renzi", DragDropEffects.Copy);
            }

        }

        private void lblAnswer3_DragDrop(object sender, DragEventArgs e)
        {
            // If the text in lblAnswer3 is the same as the text in lblMatteoRenzi...
            lblAnswer3.Text = (string)e.Data.GetData(DataFormats.Text);

            if (lblAnswer3.Text == "Matteo Renzi")
            {
                // Make the text in lblMatteoRenzi invisible.
                lblMatteoRenzi.Visible = false;
                // Allow a drop for lblAnswer3.
                lblAnswer3.AllowDrop = true;
                // Call the RightAnswer() method.
                RightAnswer();
            }
            else
            {
                // Make the text in lblMatteoRenzi remain visible.
                lblMatteoRenzi.Visible = true;
                // Remove any text from lblAnswer3.
                lblAnswer3.Text = "                          ";
                // Call the WrongAnswer() method.
                WrongAnswer();
            }
        }

        private void RightAnswer()
        {
            // Call the IncreaseScore() method from the Player Class.
            LoginScreen.Player.IncreaseScore();
            // Call the GetScore() method from the Player Class.
            LoginScreen.Player.GetScore();
            // Display the score.
            lbldisplayscore.Text = ("Score: " + LoginScreen.Player.GetScore());
            // Call the MoveToNextScreen() method.
            MoveToNextScreen();
        }

        private void WrongAnswer()
        {
            //Show a message box containing the message that the user has selected the wrong choice.
            MessageBox.Show("Incorrect. Try Again.");
        }

        private void MoveToNextScreen()
        {
            // Check if all of the answers are correct and if they are...
            if (lblAnswer4.Text == "David Cameron" && lblAnswer1.Text == "Angela Merkel" && lblAnswer2.Text == "Enda Kenny"
                && lblAnswer5.Text == "Manuel Valls" && lblAnswer3.Text == "Matteo Renzi")
            {
                // Call the GoToTrueOrFalseScreen() method.
                GoToTrueOrFalseScreen();
            }
        }
        private void GoToTrueOrFalseScreen()
        {
            // Create an instance of the TrueOrFalseScreen.
            TrueOrFalseScreen trueOrFalseScreen = new TrueOrFalseScreen();
            // Show the TrueOrFalseScreen.
            trueOrFalseScreen.Show();
            // Hide this screen.
            this.Hide();
        }


    }
}
