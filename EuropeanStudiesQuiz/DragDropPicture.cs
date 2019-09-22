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
//using System.Timers;

namespace EuropeanStudiesQuiz
{
    public partial class DragDropPicture : Form
    {
        // Create a new timer object.
        private Timer _timer = new Timer();
        // Create an instance of the Player class.
        Player _player = new Player();

        public DragDropPicture()
        {
            InitializeComponent();
            // Center the form to the middle of the screen.
            CenterToScreen();
            // Call the HideAvatars() method.
            HideAvatars();
            // Call the AllowDropPictures() method.
            AllowDropPictures();
        }

        private void AllowDropPictures()
        {
            // Allow all of the picBox's that are going to receive the flags to allow a drop.
            picBoxIreland.AllowDrop = true;
            picBoxLatvia.AllowDrop = true;
            picBoxFrance.AllowDrop = true;
            picBoxMalta.AllowDrop = true;
            picBoxItaly.AllowDrop = true;
            picBoxPoland.AllowDrop = true;
            picBoxBelgium.AllowDrop = true;
            picBoxSweden.AllowDrop = true;
        }

        private void HideAvatars()
        {

        }

        private void DragDropPicture_Load(object sender, EventArgs e)
        {
            // Display the Avatar image that was selected in the Login Screen from the Player Class.
            picBoxAvatar.Image = LoginScreen.Player.avatarImage;
            // Display the Username of the user that was entered in the LoginScreen from the Player Class.
            lblDisplayUsername.Text = LoginScreen.Player._name;
            // Display the Score as 0 to start.
            lblDisplayScore.Text = ("Score: 0");
            // Display the Time Clock as 0 to start.
            lblDisplayTime.Text = ("Time: 0");
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            // Call the SetupTimer() method.
            SetupTimer();
        }

        public void SetupTimer()
        {
            // Call the IncreaseTime() method from the Player Class.
            _player.IncreaseTime();
            // Call the GetTime() method from the Player Class and save the information within the variable _time.
            double _time = _player.GetTime();
            // Display the new time in the format 00:00:00.
            lblDisplayTime.Text = ("Time: " + _time);
            // Save the current time to the _time variable in the Player Class.
            LoginScreen.Player._time = _player.GetTime();
        }
        
        private void picBox_DragEnter(object sender, DragEventArgs e)
        {
            // Copy the image that is dragged into the picBox.
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            // Otherwise, do not copy.
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void picBoxItalianFlag_MouseDown(object sender, MouseEventArgs e)
        {
            // Copy the image in picBoxItalianFlag.
            if (e.Button == MouseButtons.Left)
            {
                picBoxItalianFlag.DoDragDrop(picBoxItalianFlag.Image, DragDropEffects.Copy);
            }
        }

        private void picBoxItaly_DragDrop(object sender, DragEventArgs e)
        {
            picBoxItaly.Image = (Image)e.Data.GetData(DataFormats.Bitmap);

            // If the picture in picBoxItaly is the same as the picture in picBoxItalianFlag...
            if (picBoxItaly.Image == picBoxItalianFlag.Image)
            {
                // Make the image in picBoxItalianFlag invisible.
                picBoxItalianFlag.Visible = false;
                // Allow a drop for picBoxItaly.
                picBoxItaly.AllowDrop = true;
                // Call the RightAnswer() method.
                RightAnswer();
            }
            // Otherwise...
            else
            {
                // Make the image in picBoxItalianFlag remain visible.
                picBoxItalianFlag.Visible = true;
                // Remove any image from picBoxItaly.
                picBoxItaly.Image = null;
                // Call the WrongAnswer() method.
                WrongAnswer();
            }
        }

        private void picBoxPolishFlag_MouseDown(object sender, MouseEventArgs e)
        {
            // Copy the image in picBoxPolishFlag.
            if (e.Button == MouseButtons.Left)
            {
                picBoxPolishFlag.DoDragDrop(picBoxPolishFlag.Image, DragDropEffects.Copy);
            }
        }

        private void picBoxPoland_DragDrop(object sender, DragEventArgs e)
        {
            picBoxPoland.Image = (Image)e.Data.GetData(DataFormats.Bitmap);

            // If the picture in picBoxPoland is the same as the picture in picBoxPolishFlag...
            if (picBoxPoland.Image == picBoxPolishFlag.Image)
            {
                // Make the image in picBoxPolishFlag invisible.
                picBoxPolishFlag.Visible = false;
                // Allow a drop for picBoxPoland.
                picBoxPoland.AllowDrop = true;
                // Call the RightAnswer() method.
                RightAnswer();
            }
            // Otherwise...
            else
            {
                // Make the image in picBoxPolishFlag remain visible.
                picBoxPolishFlag.Visible = true;
                // Remove any image from picBoxPoland.
                picBoxPoland.Image = null;
                // Call the WrongAnswer() method.
                WrongAnswer();
            }
        }

        private void picBoxSwedishFlag_MouseDown(object sender, MouseEventArgs e)
        {
            // Copy the image in picBoxSwedishFlag.
            if (e.Button == MouseButtons.Left)
            {
                picBoxSwedishFlag.DoDragDrop(picBoxSwedishFlag.Image, DragDropEffects.Copy);
            }
        }

        private void picBoxSweden_DragDrop(object sender, DragEventArgs e)
        {
            picBoxSweden.Image = (Image)e.Data.GetData(DataFormats.Bitmap);

            // If the picture in picBoxSweden is the same as the picture in picBoxSwedishFlag...
            if (picBoxSweden.Image == picBoxSwedishFlag.Image)
            {
                // Make the image in picBoxSwedishFlag invisible.
                picBoxSwedishFlag.Visible = false;
                // Allow a drop for picBoxSweden.
                picBoxSweden.AllowDrop = true;
                // Call the RightAnswer() method.
                RightAnswer();
            }
            else
            {
                // Make the image in picBoxSwedishFlag remain visible.
                picBoxSwedishFlag.Visible = true;
                // Remove any image from picBoxSweden.
                picBoxSweden.Image = null;
                // Call the WrongAnswer() method.
                WrongAnswer();
            }
        }

        private void picBoxMalteseFlag_MouseDown(object sender, MouseEventArgs e)
        {
            // Copy the image in picBoxMalteseFlag.
            if (e.Button == MouseButtons.Left)
            {
                picBoxMalteseFlag.DoDragDrop(picBoxMalteseFlag.Image, DragDropEffects.Copy);
            }
        }

        private void picBoxMalta_DragDrop(object sender, DragEventArgs e)
        {
            picBoxMalta.Image = (Image)e.Data.GetData(DataFormats.Bitmap);

            // If the picture in picBoxMalta is the same as the picture in picBoxMalteseFlag...
            if (picBoxMalta.Image == picBoxMalteseFlag.Image)
            {
                // Make the image in picBoxMalteseFlag invisible.
                picBoxMalteseFlag.Visible = false;
                // Allow a drop for picBoxMalta.
                picBoxMalta.AllowDrop = true;
                // Call the RightAnswer() method.
                RightAnswer();
            }
            else
            {
                // Make the image in picBoxMalteseFlag remain visible.
                picBoxMalteseFlag.Visible = true;
                // Remove any image from picBoxMalta.
                picBoxMalta.Image = null;
                // Call the WrongAnswer() method.
                WrongAnswer();
            }
        }

        private void picBoxIrishFlag_MouseDown(object sender, MouseEventArgs e)
        {
            // Copy the image in picBoxIrishFlag.
            if (e.Button == MouseButtons.Left)
            {
                picBoxIrishFlag.DoDragDrop(picBoxIrishFlag.Image, DragDropEffects.Copy);
            }
        }

        private void picBoxIreland_DragDrop(object sender, DragEventArgs e)
        {
            picBoxIreland.Image = (Image)e.Data.GetData(DataFormats.Bitmap);

            // If the picture in picBoxIreland is the same as the picture in picBoxIrishFlag...
            if (picBoxIreland.Image == picBoxIrishFlag.Image)
            {
                // Make the image in picBoxIrishFlag invisible.
                picBoxIrishFlag.Visible = false;
                // Allow a drop for picBoxIreland.
                picBoxIreland.AllowDrop = true;
                // Call the RightAnswer() method.
                RightAnswer();
            }
            else
            {
                // Make the image in picBoxIrishFlag remain visible.
                picBoxIrishFlag.Visible = true;
                // Remove any image from picBoxIreland.
                picBoxIreland.Image = null;
                // Call the WrongAnswer() method.
                WrongAnswer();
            }
        }

        private void picBoxBelgiumFlag_MouseDown(object sender, MouseEventArgs e)
        {
            // Copy the image in picBoxBelgiumFlag.
            if (e.Button == MouseButtons.Left)
            {
                picBoxBelgiumFlag.DoDragDrop(picBoxBelgiumFlag.Image, DragDropEffects.Copy);
            }
        }

        private void picBoxBelgium_DragDrop(object sender, DragEventArgs e)
        {
            picBoxBelgium.Image = (Image)e.Data.GetData(DataFormats.Bitmap);

            // If the picture in picBoxBelgium is the same as the picture in picBoxBelgiumFlag...
            if (picBoxBelgium.Image == picBoxBelgiumFlag.Image)
            {
                // Make the image in picBoxBelgiumFlag invisible.
                picBoxBelgiumFlag.Visible = false;
                // Allow a drop for picBoxBelgium.
                picBoxBelgium.AllowDrop = true;
                // Call the RightAnswer() method.
                RightAnswer();
            }
            else
            {
                // Make the image in picBoxBelgiumFlag remain visible.
                picBoxBelgiumFlag.Visible = true;
                // Remove any image from picBoxBelgium.
                picBoxBelgium.Image = null;
                // Call the WrongAnswer() method.
                WrongAnswer();
            }
        }

        private void picBoxFrenchFlag_MouseDown(object sender, MouseEventArgs e)
        {
            // Copy the image in picBoxFrenchFlag.
            if (e.Button == MouseButtons.Left)
            {
                picBoxFrenchFlag.DoDragDrop(picBoxFrenchFlag.Image, DragDropEffects.Copy);
            }
        }

        private void picBoxFrance_DragDrop(object sender, DragEventArgs e)
        {
            picBoxFrance.Image = (Image)e.Data.GetData(DataFormats.Bitmap);

            // If the picture in picBoxFrance is the same as the picture in picBoxFrenchFlag...
            if (picBoxFrance.Image == picBoxFrenchFlag.Image)
            {
                // Make the image in picBoxFrenchFlag invisible.
                picBoxFrenchFlag.Visible = false;
                // Allow a drop for picBoxFrance.
                picBoxFrance.AllowDrop = true;
                // Call the RightAnswer() method.
                RightAnswer();
            }
            else
            {
                // Make the image in picBoxFrenchFlag remain visible.
                picBoxFrenchFlag.Visible = true;
                // Remove any image from picFranceItaly.
                picBoxFrance.Image = null;
                // Call the WrongAnswer() method.
                WrongAnswer();
            }
        }

        private void picBoxLatvianFlag_MouseDown(object sender, MouseEventArgs e)
        {
            // Copy the image in picBoxLatvianFlag.
            if (e.Button == MouseButtons.Left)
            {
                picBoxLatvianFlag.DoDragDrop(picBoxLatvianFlag.Image, DragDropEffects.Copy);
            }
        }

        private void picBoxLatvia_DragDrop(object sender, DragEventArgs e)
        {
            picBoxLatvia.Image = (Image)e.Data.GetData(DataFormats.Bitmap);

            // If the picture in picBoxLatvia is the same as the picture in picBoxLatvianFlag...
            if (picBoxLatvia.Image == picBoxLatvianFlag.Image)
            {
                // Make the image in picBoxLatvianFlag invisible.
                picBoxLatvianFlag.Visible = false;
                // Allow a drop for picBoxLatvia.
                picBoxLatvia.AllowDrop = true;
                // Call the RightAnswer() method.
                RightAnswer();
            }
            else
            {
                // Make the image in picBoxLatvianFlag remain visible.
                picBoxLatvianFlag.Visible = true;
                // Remove any image from picBoxLatvia.
                picBoxLatvia.Image = null;
                // Call the WrongAnswer() method.
                WrongAnswer();
            }
        }

        private void MoveToNextScreen()
        {
            // Check if all of the answers are correct and if they are...
            if(picBoxItaly.Image == picBoxItalianFlag.Image && picBoxPoland.Image == picBoxPolishFlag.Image && picBoxSweden.Image == picBoxSwedishFlag.Image && 
                picBoxMalta.Image == picBoxMalteseFlag.Image && picBoxIreland.Image == picBoxIrishFlag.Image && picBoxBelgium.Image == picBoxBelgiumFlag.Image &&
                picBoxFrance.Image == picBoxFrenchFlag.Image && picBoxLatvia.Image == picBoxLatvianFlag.Image)
            {
                // Call the GoToMultipleChoiceScreen() method.
                GoToMultipleChoiceScreen();
            }
        }

        private void GoToMultipleChoiceScreen()
        {
            // Create an instance of the MultipleChoiceScreen.
            MultipleChoiceScreen multipleChoiceScreen = new MultipleChoiceScreen();
            // Show the MultipleChoiceScreen.
            multipleChoiceScreen.Show();
            // Hide this screen.
            Hide();
        }

        private void RightAnswer()
        {
            // Call the IncreaseScore() method from the Player Class.
            LoginScreen.Player.IncreaseScore();
            // Call the GetScore() method from the Player Class and save the score under the variable _score in the Player Class.
            LoginScreen.Player._score = LoginScreen.Player.GetScore();
            // Display the score.
            lblDisplayScore.Text = ("Score: " + LoginScreen.Player._score);
            // Call the MoveToNextScreen() method.
            MoveToNextScreen();
        }

        private void WrongAnswer()
        {
            //Show a message box containing the message that the user has selected the wrong choice.
            MessageBox.Show("Incorrect. Try Again.");
        }

        
    }
}


